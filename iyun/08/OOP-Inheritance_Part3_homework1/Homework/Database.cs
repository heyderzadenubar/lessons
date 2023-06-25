using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework
{
    public class Database:Item
    {
        private static ArrayList database;
        public  TV[] tvs;
        public  Laptop[] laptops;

        static Database()
        {
            database = new ArrayList();
        }
      
        public Database()
        {
            tvs = new TV[10];
            laptops = new Laptop[10];
        }

        public static bool CheckDublicateBarcode(string barcode)
        {
            for (int i = 0; i < database.Count; i++)
            {
                Item databaseTemp = (Item)database[i];
                if (databaseTemp.Barcode == barcode && databaseTemp.IsDeleted == false)
                {
                    isDubicateBarcode = true;
                    return true;
                }
                else
                {
                    isDubicateBarcode = false;
                }
            }
            return false;
        }

        //_____________________ New item __________________________________
        public void NewItem(Item item)
        {
            if (isDubicateBarcode == false && isValidBuyPrice == true && isValidsellPrice == true && isValidOfferPrice == true)
            {
                Console.WriteLine($"__ Item - {Id} __");
                database.Add(item);
            }
        }

        //_____________________ New items __________________________________
        public void NewItems(params Item[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Item databaseTemp = items[i];
                if (!string.IsNullOrEmpty(databaseTemp.Barcode) && databaseTemp.buyPrice!=0 && databaseTemp.sellPrice != 0 && databaseTemp.offerPrice != 0)
                {
                    Console.WriteLine($"__ Item - {databaseTemp.Id} __");
                    database.Add(items[i]);
                }
            }
        }

        //_____________________ Update item _________________________________

        public void UpdateItem(Item updateItem)
        {
            bool hasİtem = false;
            for(int i = 0; i < database.Count; i++)
            {
               Item itemTemp = (Item)database[i];
                if (itemTemp.Id == updateItem.Id)
                {
                    hasİtem = true;
                    itemTemp.Brand = "NewBrand";
                    itemTemp.EditDate = DateTime.Now;
                    break;
                }
            }
            if (hasİtem == false)
            {
                Console.WriteLine("Mehsul tapilmadi");
            }
        }

        //_____________________ Delete item _________________________________

        public void DeleteItem(Item updateItem)
        {
            bool hasItem = false;
            for (int i = 0; i < database.Count; i++)
            {
                Item itemTemp = (Item)database[i];
                if (itemTemp.Id == updateItem.Id)
                {
                    hasItem = true;
                    itemTemp.IsDeleted = true;
                    itemTemp.DeleteDate = DateTime.Now;
                    break;
                }
            }

            if (hasItem == false)
            {
                Console.WriteLine("Mehsul tapilmadi");
            }
        }
    }
}
