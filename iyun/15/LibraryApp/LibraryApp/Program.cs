using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework (LibraryApp)
            /*
             Bir dənə kitabxana app'ı yazacaqsınız. İlk öncə mən bir neçə müəllif əlavə edəcəyəm və sonra da
             müəlliflərin kitablarını əlavə edəcəyəm. Nəzərə alın ki, müəllifləri əlavə edəndən sonra birinci müəllif
             məlumatlarını ekranda görməliyəm ki, kitab'ı əlavə edəndə müəllifin Id dəyərinə görə əlavə edəcəm.
             Bura qədər bildiyiniz hər şeydən istifadə edərək bu app'ı yazmağa çalışın. Müəllif və kitabları əlavə
             etmək, silmək, hamısını görmək, Ad'a görə axtarmaq kimi seçim olacaq. Bacarsanız editləmək funksiyasını
             da yazın.
             */
            #endregion
            VirtualDatabase virtualDatabase = new VirtualDatabase();

            Users user1 = new Users()
            {
                Name = "Nubar",
                Surname = "Heyderzade",
                Username = "nubarheyderzade",
                Birthday = new DateTime(1993, 10, 09),
                Gender = GenderEnum.Female,
                Address = "Address-1",
                TableNumber = 2345
            };
            #region Menu
            #region Add authors
            Authors ElxanElatli = new Authors()
            {
                Name = "Elxan",
                Surname = "Elatli",
                Birthday = new DateTime(1963, 10, 09),
                Gender = GenderEnum.Male,
            };
            Authors XalidHuseyni = new Authors()
            {
                Name = "Xalid",
                Surname = "Huseyni",
                Birthday = new DateTime(1963, 10, 09),
                Gender = GenderEnum.Male,
            };

            Authors Varis = new Authors()
            {
                Name = "Varis",
                Birthday = new DateTime(1965, 10, 09),
                Gender = GenderEnum.Male,
            };
            virtualDatabase.NewAuthors(ElxanElatli, XalidHuseyni);
            #endregion

            BeginAgain:
            Console.WriteLine("Emeliyyat secin:");
            Console.WriteLine("1. Muellif elave et");
            Console.WriteLine("2. Kitab elave et");
            Console.WriteLine("3. Muellif sil");
            Console.WriteLine("4. Kitab sil");
            Console.WriteLine("5. Hamisini gor");
            Console.WriteLine("6. Ada gore axtar");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    virtualDatabase.NewAuthors(Varis);
                    goto BeginAgain;
                case 2:
                    Books book1 = new Books()
                    {
                        AuthorId = ElxanElatli.id,
                        Name = "book1",
                        CreateDate = DateTime.Now,
                    };

                    Books book2 = new Books()
                    {
                        AuthorId = ElxanElatli.id,
                        Name = "book2",
                        CreateDate = DateTime.Now,
                    };

                    Books book3 = new Books()
                    {
                        AuthorId = XalidHuseyni.id,
                        Name = "book3",
                        CreateDate = DateTime.Now,
                    };
                    Books book4 = new Books()
                    {
                        AuthorId = 3,
                        Name = "book3",
                        CreateDate = DateTime.Now,
                    };
                    virtualDatabase.NewBooks(book1, book2, book3, book4);
                    goto BeginAgain;
                default:
                    Console.WriteLine("Error");
                    goto BeginAgain;
            }
            #endregion

        }
    }
}
