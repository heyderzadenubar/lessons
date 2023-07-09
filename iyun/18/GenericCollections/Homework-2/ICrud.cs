using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
   public interface ICrud <T>
    {
        void Create(params T[] data);
        void Read();
        void Update(T data);
        void Delete(params T[] data);


    }
}
