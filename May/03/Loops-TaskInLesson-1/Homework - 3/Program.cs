using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 3: App'ın işləmə prinsipi: İlk öncə istifadəçidən "Texmin oyunu ucun en yuksek deyeri daxil edin: " yazısı ilə bir rəqəm
                    alınmalıdır. Sonra 1 ilə bu rəqəm arasında random bir rəqəm generate edilməlidir və istifadəçidən generate olunan rəqəmi 
                    tapmağı istənməlidir. "1. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: " mesajı ilə istifadəçidən bir rəqəm soruşulur. 
                    Hər səhv daxil edilən rəqəmdə eyni şey təkrar göstərilir. Sadəcə 2. 3. 4. deyə artır cəhd sayı. İstifadəçi düzgün rəqəmi
                    tapdığı zaman "5. Cəhdinizdə düzgün rəqəmi tapdınız!" mesajı göstərilməlidir.*/
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Texmin oyunu ucun en yuksek deyeri daxil edin: ");
            int aUser = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int aRand = rand.Next(1, aUser);
            bool TexminUserBool = true;
            int cehd = 1;

            while (TexminUserBool)
            {
                Console.Write($"{cehd}. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: ");
                int aTexminUser = Convert.ToInt32(Console.ReadLine());

                if (aTexminUser != aRand)
                {
                    cehd++;
                }
                else
                {
                    TexminUserBool = false;
                    Console.WriteLine();
                    Console.WriteLine($"{cehd}. Cəhdinizdə düzgün rəqəmi tapdınız!");
                }
            }
        }
    }
}
