using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class GenericRepository<T> : ICRUD<T>
    {
        public void Create(T data)
        {
            VirtualDatabase<T>.virtualDatabase.Add(data);
        }

        public List<T> GetAll()
        {
            return new List<T>();
        }

        public virtual void Read()
        {

        }

        public virtual void Update(int id)
        {
            
        }

        public virtual void Delete(int id)
        {

        }
    }
}
