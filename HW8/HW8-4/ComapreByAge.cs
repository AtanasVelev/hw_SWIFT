using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_4
{
    class CompareByAge:IComparer<Animal>
    {
        //public CompareByAge()
        //{
            
        //}
        public int Compare(Animal left, Animal right)

        {
            // return left.AgeOfAnimal - right.AgeOfAnimal; Ascending!
            return right.AgeOfAnimal - left.AgeOfAnimal; 
        }
        public IComparer<Animal> SortByYears()
        {
            return (IComparer<Animal>)new CompareByAge();
        }
    }
}
