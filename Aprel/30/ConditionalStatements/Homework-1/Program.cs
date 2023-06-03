using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            /*Homework 1:
             Əvvəlcədən iki dəyişəndə username və password saxlayın. Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. Yəni proqramda belə dəyişdirmək mümkün olmasın
             Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
             Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.*/

            const string _usernameConst = "nubarheyderzade";
            const string _passwordConst = "123456";
            int _attempt = 1;
        BeginAgain1:
            Console.Write("İstifadəçi adınızı daxil edin: ");
            string _usernameVar= Console.ReadLine();
            Console.Write("Şifrənizi daxil edin: ");
            string _passwordVar = Console.ReadLine();

            if(_usernameVar == _usernameConst && _passwordVar == _passwordConst)
            {
                Console.WriteLine("Sisteme daxil olundu.");
            }
            else if (_attempt <= 3)
            {
                _attempt++;
                goto BeginAgain1;
            }
            else
            {
                Console.WriteLine("Hesab bloklandi");
            }
        }
    }
}
