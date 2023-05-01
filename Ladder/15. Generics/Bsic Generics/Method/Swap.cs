using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._15._Generics.Bsic_Generics
{
    internal class Swap
    {
        public static void SwapIt<T> (ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}
