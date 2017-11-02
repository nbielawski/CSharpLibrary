using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces
{
    class ListClass : IEnum, ICollect, IList
    {
        public void AddStuff()
        {
            Console.WriteLine("Added stuff to list");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Checked the capacity of the list");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Checked the count");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("iterated over the list");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removed some stuff from the list");
        }
    }
}
