using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LibraryApp
{
    public class Item
    {
        public int id { get; set; }
        public string Name { get; set; }
        public static int globalId;

        public Item()
        {
            id = Interlocked.Increment(ref globalId);
        }
    }
}
