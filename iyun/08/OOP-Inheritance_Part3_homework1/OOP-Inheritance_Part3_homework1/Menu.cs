using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Part3_homework1
{
    public class Menu
    {
        Database db = new Database();

        public void SelectOperation()
        { 
            BeginAgain:
            Console.WriteLine("Select operation:");
            Console.WriteLine("1. Add new item");
            Console.WriteLine("2. Add new items");
            Console.WriteLine("3. Update item");
            Console.WriteLine("4. Delete item");

            byte choice = Convert.ToByte(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Select category (Laptop, TV): ");
                    string category = Console.ReadLine();

                    if (category.ToUpper() == "TV")
                    {
                        db.tv.IsSmartTv = true;
                        db.tv.Barcode = 34354;
                        db.tv.Brand = "Samsung";
                        db.tv.BuyPrice = 150.00;
                        db.tv.CreateDate = DateTime.Now;
                        db.tv.HasHDMI = true;
                        db.tv.Model = "ModelTV";
                    }else if (category.ToUpper() == "LAPTOP")
                    {
                        db.laptop.Barcode = 343546;
                        db.laptop.Brand = "Samsung Laptop";
                        db.laptop.BuyPrice = 150.00;
                        db.laptop.Ram = 7;
                        db.laptop.Model = "Model Laptop";
                        db.laptop.GraphicCard = "Graphic Card Laptop";
                        db.laptop.CreateDate = DateTime.Now;
                    }
                    db.NewItem(category);
                    db.ShowItem();
                    goto BeginAgain;
                case 2:
                    BeginAgainNewItems:
                    Console.WriteLine("Select category (Laptop, TV): ");
                    string category2 = Console.ReadLine();
                    if (category2.ToUpper() == "EXIT")
                    {
                        Console.WriteLine();
                        db.ShowItem();
                        Console.WriteLine();
                        goto BeginAgain;
                    }
                    else if (category2.ToUpper() == "LAPTOP")
                    {
                        db.laptop.Barcode = 343546;
                        db.laptop.Brand = "Samsung Laptop 2";
                        db.laptop.BuyPrice = 150.00;
                        db.laptop.Ram = 7;
                        db.laptop.Model = "Model Laptop";
                        db.laptop.GraphicCard = "Graphic Card Laptop";
                        db.laptop.CreateDate = DateTime.Now;
                        db.NewItemsLaptop(category2);
                    }else if(category2.ToUpper() == "TV")
                    {
                        db.tv.IsSmartTv = true;
                        db.tv.Barcode = 34354;
                        db.tv.Brand = "Samsung TV 2";
                        db.tv.BuyPrice = 150.00;
                        db.tv.CreateDate = DateTime.Now;
                        db.tv.HasHDMI = true;
                        db.tv.Model = "ModelTV";
                        db.NewItemsTV(category2);
                    }
                    goto BeginAgainNewItems;
                    
                default:
                    goto BeginAgain;
            }
        }
    }
}
