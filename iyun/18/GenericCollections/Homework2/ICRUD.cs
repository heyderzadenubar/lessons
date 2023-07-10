using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public interface ICRUD<T>
    {
        void Create(T data);
        void Read();
        void Update(int id);
        void Delete(int id);
    }
}
