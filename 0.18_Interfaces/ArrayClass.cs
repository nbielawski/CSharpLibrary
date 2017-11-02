using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces
{
    class ArrayClass : IEnum, IList, ICollect
    {
        
        public void IterateOverCollection()
        {
            Console.WriteLine("you are iterating over the array...");
        }

        public void AddStuff()
        {
            Console.WriteLine("added stuff to the array");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("removed stuff from the array");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("you cannot check capacity on an array");
        }


        public void CheckTheCount()
        {
            Console.WriteLine("Checking the count of the array");
        }

       

    }
}
