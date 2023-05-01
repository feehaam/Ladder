using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._15._Generics.Bsic_Generics
{
    internal class ExceptionGeneric
    {
        public static void ExceptionGen<T>(T exception)
        {
            Console.WriteLine("Exception: "+exception.ToString());
        }
    }
}
