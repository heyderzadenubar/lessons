using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class GenericRepository <T> : ICrud<T>
    {

        public List<T> ItemList = new List<T>();
        public GenericRepository()
        {

        }

        public virtual void Create(params T[] data)
        {
            foreach (var item in data)
            {
                ItemList.Add(item);
            }
        }
        public virtual void Read()
        {
            foreach (T item in ItemList)
            {
                Console.WriteLine(item);
            }
        }

        public virtual void Update(T data)
        {
            //Item.ForEach(data);
        }

        public virtual void Delete(params T[] data)
        {
            foreach (var item in data)
            {
                ItemList.Remove(item);
            }
        }

    }
}
