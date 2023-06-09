using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 1:
            /*İlk öncə aşağıdakı kimi bir menu çıxsın ekranda.

                Menu:
                1 - Element elave et
                2 - Elementleri goster
                3 - Element axtar
                4 - Element editle
                5 - Element sil
                6 - Exit
                Emeliyyat novunu secin:

                Əməliyyat növünü user seçdikdən sonra aşağıdakı kimi proses davam edəcək...
                1:
                Soruşacaq: "Zehmet olmasa elave etmek istediyiniz elementi daxil edin: "
                Daxil edəndən sonra: "Element elave olundu!"

                2:
                Bunu seçəndə bütün elementlər aşağıdakı kimi göstəriləcək.
                1. Element = 15
                2. Element = Salam
                3. Element = Hi
                Burdan çıxmaq üçündə "Davam etmek ucun Enter'e basin" yazısı görsənəcək.

                3:
                Bunu seçəndə aşağıdakı yazı çıxacaq.
                "Axtarmaq istediyiniz elementi daxil edin: "
                Daxil edəndən sonra əgər tapılıbsa, aşağıdakı yazı çıxsın
                "Element tapildi : Index :0 - Deyer: Salam"
                tapılmayıbsa bu yazı çıxsın
                "Axtardiginiz element tapilmadi".

                4:
                "Editlemek istediyiniz elementi daxil edin : " yazısı çıxsın və məsələn Salam sözünü editləmək istəyirsə,
                ilk öncə yoxlayın Salam elementi var mı? Yoxdursa bu yazı çıxsın:
                "Axtardiginiz element tapilmadi"
                Varsa:
                "Salam elementini ne ile evezlemek isteyirsiniz?"
                Editləyəndən sonra da "Element editlendi!" yazısı çıxsın.

                5:
                İlk öncə bunu soruşsun:
                "Butun elementleri silmek isteyirsiniz? (H/Y)"
                əgər cavab H olarsa o zaman bütün elementləri silib "Butun elementler silindi" yazısı çıxsın.
                əgər cavab Y olarsa o zaman "Silmek istediyiniz elementi daxil edin: " yazısı çıxsın və məsələn adam Salam daxil etdisə 
                ilk öncə yoxlayın Salam var mı? Varsa silib "Element silindi" yazın yoxdursa "Silmek istediyiniz element tapilmadi!" yazısı
                çıxsın.*/
            #endregion

            ArrayList arrList = new ArrayList();
        BeginAgain:
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Element elave et");
            Console.WriteLine("2 - Elementleri goster");
            Console.WriteLine("3 - Element axtar");
            Console.WriteLine("4 - Element editle");
            Console.WriteLine("5 - Element sil");
            Console.WriteLine("6 - Exit");

            Console.Write("Emeliyyat novunu secin:  ");
            byte choice = Convert.ToByte(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine();
                        Console.Write("Zehmet olmasa elave etmek istediyiniz elementi daxil edin: ");
                        string newElement = Console.ReadLine();
                            arrList.Add(newElement);
                        Console.WriteLine("Element elave olundu!");
                        goto BeginAgain;
                    }
                case 2:
                    {
                        Console.WriteLine();
                        if (arrList.Count > 0)
                        {
                            for (int i = 0; i < arrList.Count; i++)
                            {
                                Console.WriteLine(i + ". " + arrList[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hec bir element movcud deyil");
                        }
                        goto BeginAgain;
                    }
                case 3:
                    {
                        Console.WriteLine();
                        Console.Write("Axtarmaq istediyiniz elementi daxil edin: ");
                        string findElement=Console.ReadLine();
                        if (arrList.Contains(findElement))
                        {
                            Console.WriteLine($"Element tapildi : Index :{arrList.IndexOf((object)findElement)} - Deyer: {arrList[arrList.IndexOf((object)findElement)]}");
                        }
                        else
                        {
                            Console.WriteLine("Axtardiginiz element tapilmadi");
                        }
                        goto BeginAgain;
                    }
                case 4:
                    {
                    startEdit:
                        Console.WriteLine("Editlemek istediyiniz elementi daxil edin : ");
                        string editElement = Console.ReadLine();
                        if (arrList.Contains(editElement))
                        {
                            Console.Write($"{editElement} elementini ne ile evezlemek isteyirsiniz?   ");
                            string EditedToNewElement=Console.ReadLine();
                            int indexOfeditElement = arrList.IndexOf(editElement);
                            arrList[indexOfeditElement] = EditedToNewElement;
                            Console.WriteLine("Element editlendi!");
                        }
                        else
                        {
                            Console.WriteLine("Axtardiginiz element tapilmadi");
                            goto startEdit;
                        }
                
                    }goto BeginAgain;
                case 5:
                    {
                        Console.WriteLine( "Butun elementleri silmek isteyirsiniz? (H/Y)");
                        string ans = Console.ReadLine();
                        if (ans.ToUpper() == "H")
                        {
                            arrList.Clear();
                            Console.WriteLine("Butun elementler silindi");
                        }
                        else if(ans.ToUpper() == "Y")
                        { startRemove:
                            Console.Write("Silmek istediyiniz elementi daxil edin:  ");
                            string RemoveElement = Console.ReadLine();
                            if (arrList.Contains(RemoveElement))
                            {
                                int indexOfRemoveElement = arrList.IndexOf(RemoveElement);
                                arrList.RemoveAt(indexOfRemoveElement);
                                Console.WriteLine("Element silindi");
                            }
                            else
                            {
                                Console.WriteLine("Silmek istediyiniz element tapilmadi!");
                                goto startRemove;
                            }
                        }else if (ans.ToLower() == "exit")
                        {
                            goto BeginAgain;
                        }
                        goto BeginAgain;
                    }
                default:
                    break;
            }
        }
    }
}
