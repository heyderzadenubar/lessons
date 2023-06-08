using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 4
            /*Array'ın property və method'larını araşdırın, nə işə yarayır, necə istifadə edilir, nə üçün istifadə edilir və s.
             Araşdırdığınız method və property'ləri mütləq praktika edin!*/
            #endregion

            int[] arr = new int[5]
            {
                15,
                52,
                15,
                24,
                52
            };
            //___________ Parametrler _______________
            int length = arr.Length;
            bool isFixedSizeBool = arr.IsFixedSize;
            bool isReadOnly = arr.IsReadOnly;

            //___________ Basqa array-e kopyalama _______________
            int[] arrCopy = new int[5];
            Array.Copy(arr, arrCopy, 5);   // 5 elementti arrCopy-e kopyala

            //___________ Elementin silinmesi _______________
            Array.Clear(arr, 2, 3);   // 2-ci indexden baslayaraq 3 elementi sil

            //___________ Indexof _______________
            Console.WriteLine(Array.IndexOf(arrCopy, 15));   // array-de movcud (tekrarlanan) elementlerden ilk olanin indexini qaytarir, element movcud deyilse -1 qaytarir

            //___________ LastIndexOf _______________
            Console.WriteLine(Array.LastIndexOf(arrCopy, 52));   // array-de movcud (tekrarlanan) elementlerden son olanin indexini qaytarir qaytarir, element movcud deyilse -1 qaytarir

        }
    }
}
