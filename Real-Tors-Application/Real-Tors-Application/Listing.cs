using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Tors_Application {

    public enum ListingType
    {
        SingleFamily,
        Duplex,
        Triplex,
        Townhome,
        Apartment,
        Loft
    }

    public class Listing
    {

        private string[] listOfNeighbourhoods = System.IO.File.ReadAllLines("../../resources/neighbourhoods.txt");
        private string[] listOfStreetNames = System.IO.File.ReadAllLines("../../resources/street.txt");


        public string Neighbourhood { get; set; }
        public string Address { get; set; }

        public int Size { get; set; }
        public string Description { get; set; }
        public List<string> Amenities { get; set; }
        public int Price { get; set; }
        public int BathNum { get; set; }
        public int BedNum { get; set; }
        public int YearBuilt { get; set; }
        public ListingType Type { get; set; }
        public int NumOfImg { get; set; }
        public Tuple<double, double> Coordinates { get; set; }
        public bool Favorited { get; set; }

        public Listing(string neighbourhood, string address, int size,
            string description, List<string> amenities, 
            int price, int bathNum, int bedNum, 
            int yearBuilt, ListingType type, int numOfImg, 
            Tuple<double, double> coordinates, bool favorited)
        {
            Neighbourhood = neighbourhood;
            Address = address;
            Size = size;
            Description = description;
            Amenities = amenities;
            Price = price;
            BathNum = bathNum;
            BedNum = bedNum;
            YearBuilt = yearBuilt;
            Type = type;
            NumOfImg = numOfImg;
            Coordinates = coordinates;
            Favorited = favorited;
        }

        public Listing(Random rand)
        {
            
            Neighbourhood = listOfNeighbourhoods[rand.Next(listOfNeighbourhoods.Length)];

            Address = rand.Next(1000) + " " + Neighbourhood + " " + listOfStreetNames[rand.Next(listOfStreetNames.Length)];

            Size = (rand.Next(50)+1)*100;

            Amenities = new List<string> { "granite countertops", "walkout basement"};

            Price = (rand.Next(2000)+1) * 1000;

            BathNum = rand.Next(5) + 1;

            BedNum = rand.Next(5) + 1;

            YearBuilt = 2020-rand.Next(50);

            Type = ListingType.SingleFamily;

            NumOfImg = 1;

            Coordinates = new Tuple<double, double> ( -141.12, 51.12 );

            Favorited = false;

            Description = "This house is a beautfiul home built in " + YearBuilt + ". It is nestled in the pristine neighbourhood of " + Neighbourhood + ".";

        }

        public Listing(Random rand, string[] neighbourhoodSelect)
        {

            Neighbourhood = neighbourhoodSelect[rand.Next(neighbourhoodSelect.Length)];

            Address = rand.Next(1000) + " " + Neighbourhood + " " + listOfStreetNames[rand.Next(listOfStreetNames.Length)];

            Size = (rand.Next(50) + 1) * 100;

            Amenities = new List<string> { "Granite countertops", "Walkout basement" };

            Price = (rand.Next(2000) + 1) * 1000;

            BathNum = rand.Next(5) + 1;

            BedNum = rand.Next(5) + 1;

            YearBuilt = 2020 - rand.Next(50);

            Type = ListingType.SingleFamily;

            NumOfImg = 1;

            Coordinates = new Tuple<double, double>(-141.12, 51.12);

            Favorited = false;

            Description = "This house is a beautfiul home built in " + YearBuilt + ". It is nestled in the pristine neighbourhood of " + Neighbourhood + ".";

        }

        public string toString()
        {
            return "Neighbourhood: " + Neighbourhood +
                ",\t\tAddress: " + Address +
                ",\t\tPrice: " + Price;
        }
    }
}
