using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Tors_Application
{
    public static class GlobalState
    {
        public static List<Listing> totalList { get; set; }
        public static List<Listing> additionalFavorites { get; set; }
        public static Dictionary<string, int> perNeighbourhood { get; set; }
        public static Dictionary<string, Tuple<int,int,int,int>> neighbourhoodBounds { get; set; }
        //x min, x max, y min, y max
        public static int[] currentList { get; set; }
        public static int currentIndex { get; set; }

        public static Listing similar { get; set; }

        public static ListingType paramType { get; set; }
        public static List<String> paramNeighbourhood { get; set; }
        public static Tuple<int,int> paramSize { get; set; }
        public static Tuple<int,int> paramPrice { get; set; }
        public static Tuple<int, int> paramBed { get; set; }
        public static Tuple<int, int> paramBath { get; set; }
        public static Tuple<int, int> paramYear { get; set; }
        public static List<string> paramAmenities { get; set; }
        
        static GlobalState()
        {
            totalList = new List<Listing>();
            additionalFavorites = new List<Listing>();
            perNeighbourhood = new Dictionary<string, int>();
            paramNeighbourhood = new List<String>();
            currentList = new int[9];
            neighbourhoodBounds = new Dictionary<string, Tuple<int, int, int, int>>();
            neighbourhoodBounds.Add("Citadel", new Tuple<int, int, int, int>( -300, 500, -300, 30));
            neighbourhoodBounds.Add("Hamptons", new Tuple<int, int, int, int>(-300, 350, -300, 100));
            neighbourhoodBounds.Add("Edgemont", new Tuple<int, int, int, int>(-300, 150, -350, 150));
            neighbourhoodBounds.Add("Hawkwood", new Tuple<int, int, int, int>(-200, 400, -300, 200));
            neighbourhoodBounds.Add("Simons Valley", new Tuple<int, int, int, int>(-300, 350, -300, 150));
        }

        public static void Generate()
        {
            Generate(9);
        }

        public static void Generate(int limit)
        {
            int count = 0;
            for(int i = 0; i<1000 && count<limit && count<9; i++)
            {
                if (paramNeighbourhood.Count!=0)
                {
                    if(!paramNeighbourhood.Contains(totalList[i].Neighbourhood))
                        continue;
                }
                if (paramSize!=null)
                {
                    if(paramSize.Item1 > totalList[i].Size || paramSize.Item2 < totalList[i].Size)
                        continue;
                }
                if (paramYear != null)
                {
                    if(paramYear.Item1 > totalList[i].YearBuilt || paramPrice.Item2 < totalList[i].YearBuilt)
                        continue;
                }
                if (paramPrice != null)
                {
                    if(paramPrice.Item1 > totalList[i].Price || paramPrice.Item2 < totalList[i].Price)
                        continue;
                }
                if (paramBed != null)
                {
                    if(paramBed.Item1 > totalList[i].BedNum || paramBed.Item2 < totalList[i].BedNum)
                        continue;
                }
                if (paramBath != null)
                {
                    if(paramBath.Item1 > totalList[i].BathNum || paramBath.Item2 < totalList[i].BathNum)
                        continue;
                }

                if (paramAmenities!=null)
                {
                    totalList[i].Amenities.Concat(paramAmenities);
                }
                currentList[count] = i;
                count++;
            }

            while(count<9)
            {
                currentList[count] = -1;
                count++;
            }
        }

        public static int MapListingAmount(List<Listing> listOfListings)
        {
            int count = 0;

            foreach (Listing listing in listOfListings)
            {

                //Checks the parameters

                //Neighbourhood -----------------------------------------------------------------------------------
                if (paramNeighbourhood.Count != 0) //only checks if this parameter is set
                {
                    //If this neighbourhood is not one of the ones in the parameter
                    if (!paramNeighbourhood.Contains(listing.Neighbourhood))
                    {
                        //as soon as you know its not a match, move to the next neighbourhood
                        continue;
                    }
                }

                //Size --------------------------------------------------------------------------------------------
                if (paramSize != null) //only checks if this parameter is set
                {
                    //If the listing's size is less than min or larger than max
                    if (listing.Size < paramSize.Item1 || listing.Size > paramSize.Item2)
                    {
                        //as soon as you know its not a match, move to the next neighbourhood
                        continue;
                    }
                }

                //Bed Amount --------------------------------------------------------------------------------------
                if (paramBed != null) //only checks if this parameter is set
                {
                    //If the listing's bedNum is less than min or larger than max
                    if (listing.BedNum < paramBed.Item1 || listing.BedNum > paramBed.Item2)
                    {
                        //as soon as you know its not a match, move to the next neighbourhood
                        continue;
                    }
                }

                //Bath Amount -------------------------------------------------------------------------------------
                if (paramBath != null) //only checks if this parameter is set
                {
                    //If the listing's bedNum is less than min or larger than max
                    if (listing.BathNum < paramBath.Item1 || listing.BathNum > paramBath.Item2)
                    {
                        //as soon as you know its not a match, move to the next neighbourhood
                        continue;
                    }
                }

                //Year --------------------------------------------------------------------------------------------
                if (paramYear != null) //only checks if this parameter is set
                {
                    //If the listing's bedNum is less than min or larger than max
                    if (listing.YearBuilt < paramYear.Item1 || listing.YearBuilt > paramYear.Item2)
                    {
                        //as soon as you know its not a match, move to the next neighbourhood
                        continue;
                    }
                }

                //Amenities ---------------------------------------------------------------------------------------
                //Not sure what was needed for this one


                //If it has not yet hit a continue by this point, you know its a match
                count++;
                
            }

            return count;
        }
    }
}
