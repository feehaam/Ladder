using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._15._Generics.Bsic_Generics
{
    internal class MaxMin <T> where T : IComparable
    {
        public static T Max(T item1, T item2)
        {
            if(item1.CompareTo(item2) > 0) 
                return item1;
            else 
                return item2;
        }
        public static T Min(T item1, T item2)
        {
            if(item1.CompareTo(item2) < 0) 
                return item1;
            else 
                return item2;
        }
    }
}
