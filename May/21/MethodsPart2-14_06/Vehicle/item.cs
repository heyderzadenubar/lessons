using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Item
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal KmUsed { get; set; }
        public int FuelType { get; set; }
        public int TransmissionType { get; set; }
        public decimal BuyPrice { get; set; } 
        public decimal SellPrice { get; set; } 
        public decimal MaxDiscount { get; set; } 
        private decimal _Price { get; set; }

        public Item()
        {

        }
        public Item(string mark, string model)
        {
            mark = Mark;
            model = Model;
        }
        public Item(string mark, string model, int year)
        {
            mark = Mark;
            model = Model;
            year = Year;
        }
        public Item(string mark, string model, decimal km)
        {
            mark = Mark;
            model = Model;
            km = KmUsed;
        }
        public Item(string mark, string model, int year, decimal km, int fuelType, int transmissionType, decimal buyPrice, decimal sellPrice, decimal maxDiscount, decimal price)
        {
            Mark = mark;
            Model = model;
           Year = year;
            KmUsed = km;
            FuelType = fuelType;
            TransmissionType = transmissionType;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            MaxDiscount = maxDiscount;
            _Price = price;
        }

        public void ShowAllInfo()
        {
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Km Used: {KmUsed}");
            Console.WriteLine($"Fuel type: {FuelType}");
            Console.WriteLine($"Transmission type: {TransmissionType}");
            Console.WriteLine($"Price: {_Price}");
        }

        public void SetPrice(decimal price)
        {
            if (price < (SellPrice - MaxDiscount))
            {
                Console.WriteLine("Max. endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!");
            }
            else
            {
                _Price = price;
            }
        }
    }
}
