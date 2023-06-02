using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 3: İstifadəçidən 10 dənə fərqli rəqəm alıb bir dəyişəndə toplayın. Bu taskı da çıxma, vurma və bölmə üçün
             də edin. Çıxmada və toplama əməliyyatlarında 10-cu dəyər daxil edildikdən sonra alınan nəticəyə 1 toplayacaq
             və ya çıxacaqsız. Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.
             */
            int _a1, _a2, _a3, _a4, _a5, _a6, _a7, _a8, _a9, _a10, _aToplama, _aCixma, _aVurma;
            double _aBolme;
            
            //-------toplama--------
            Console.Write("1-ci reqem: ");
            _a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-ci reqem: ");
            _a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3-cu reqem: ");
            _a3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("4-cu reqem: ");
            _a4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("5-ci reqem: ");
            _a5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("6-ci reqem: ");
            _a6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("7-ci reqem: ");
            _a7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("8-ci reqem: ");
            _a8 = Convert.ToInt32(Console.ReadLine());
            Console.Write("9-cu reqem: ");
            _a9 = Convert.ToInt32(Console.ReadLine());
            Console.Write("10-cu reqem: ");
            _a10 = Convert.ToInt32(Console.ReadLine());

            //-----------------------Toplama---------------
            _aToplama = _a1;
            _aToplama += _a2;
            _aToplama += _a3;
            _aToplama += _a4;
            _aToplama += _a5;
            _aToplama += _a6;
            _aToplama += _a7;
            _aToplama += _a8;
            _aToplama += _a9;
            _aToplama +=_a10;
            _aToplama++;
            Console.WriteLine($"Netice (toplama): {_aToplama}");
            Console.WriteLine();
            //-----------------------Cixma---------------
            _aCixma = _a1;
            _aCixma -= _a2;
            _aCixma -= _a3;
            _aCixma -= _a4;
            _aCixma -= _a5;
            _aCixma -= _a6;
            _aCixma -= _a7;
            _aCixma -= _a8;
            _aCixma -= _a9;
            _aCixma -= _a10;
            _aCixma--;
            Console.WriteLine($"Netice (cixma): {_aCixma}");
            Console.WriteLine();
            //-----------------------Vurma---------------
            _aVurma = _a1;
            _aVurma *= _a2;
            _aVurma *= _a3;
            _aVurma *= _a4;
            _aVurma *= _a5;
            _aVurma *= _a6;
            _aVurma *= _a7;
            _aVurma *= _a8;
            _aVurma *= _a9;
            _aVurma *= _a10;
            _aVurma *= 20;
            Console.WriteLine($"Netice (vurma): {_aVurma}");
            Console.WriteLine();
            //-----------------------Bolme---------------
            _aBolme = (double)_a1;
            _aBolme /= (double)_a2;
            _aBolme /= (double)_a3;
            _aBolme /= (double)_a4;
            _aBolme /= (double)_a5;
            _aBolme /= (double)_a6;
            _aBolme /= (double)_a7;
            _aBolme /= (double)_a8;
            _aBolme /= (double)_a9;
            _aBolme /= (double)_a10;
            _aBolme /= (double)20;
            Console.WriteLine($"Netice (bolme): {_aBolme}");
            Console.WriteLine();


        }
    }
}
