using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_3_
{
     interface IGeneric<T>
    {
        void Create(T entity);
        void Read(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
    
}
