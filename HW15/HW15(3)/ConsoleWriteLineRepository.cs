using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_3_
{
    class ConsoleWriteLineRepository<T>:IGeneric<T>
    {
        public ConsoleWriteLineRepository()
        { }
        public void Create(T entity)
        {
            Console.WriteLine($"Create {entity}");
        }
        public void Read(T entity)
        {
            Console.WriteLine($"Read a {entity}");
        }
        public void Update(T entity)
        {
            Console.WriteLine($"Update {entity}");
        }
        public void Delete(T entity)
        {
            Console.WriteLine($"Deleting ... {entity}");
        }
    }
}
