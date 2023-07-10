using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework2
{
    public class Book : GenericRepository<Book>
    {
        private readonly int _id;
        public string Name { get; set; }
        public string Author { get; set; }

        public static int globalId;

        public int Id
        {
            set
            {

            }
            get
            {
                return _id;
            }
        }

        public Book()
        {
            _id = Interlocked.Increment(ref globalId);
        }
        static int i = 1;

        public override void Read()
        {
            Console.WriteLine($"_Book-{i}_\r\nName: {Name}\r\nAuthor: {Author}\r\n");
            i++;
        }

        public override void Update(int id)
        {
            Book foundBook = VirtualDatabase<Book>.virtualDatabase.Find(i => i.Id == id);
            if (foundBook != null)
            {
                foundBook.Name = "Update name";
            }
            else
            {
                Console.WriteLine("Kitab tapilmadi!");
            }
        }

        public override void Delete(int id)
        {
            Book foundBook = VirtualDatabase<Book>.virtualDatabase.Find(i => i.Id == id);
            if (foundBook != null)
            {
                VirtualDatabase<Book>.virtualDatabase.Remove(foundBook);
            }
        }
    }
}
