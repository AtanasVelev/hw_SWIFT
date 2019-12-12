using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_3_
{
    class ConsoleWriteRepository<T>:IGeneric<T>
    {
       public void Create(T entity)
        {
            Console.Write($"Create num {entity}");
        }
        public void Read(T entity)
        {
            Console.Write($"Read num {entity}");
        }
        public void Update(T entity)
        {
            Console.Write($"Update num {entity}");
        }
        public void Delete(T entity)
        {
            Console.Write($"Delete num {entity}");
        }
    }
}
