using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework_2
{
    public class Book : GenericRepository<Book>
    {

        private readonly int _id;
        public static int globalId;

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {

            }
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime CreateDate { get; set; }

        public Book()
        {
            _id = Interlocked.Increment(ref globalId);
        }

        //public override void Read(params Book[] book)
        //{
        //    VirtualDatabase<Book>.ItemList.ForEach(i => Console.WriteLine($"____ Book - {i.Id}\r\n_____," +
        //                                              $"ID: {i.Id}\r\n" +
        //                                              $"Name: {i.Name}\r\n" +
        //                                              $"Author: {i.Author}\r\n" +
        //                                              $"Crate Date: {i.CreateDate}"));
        //}
    }
}
