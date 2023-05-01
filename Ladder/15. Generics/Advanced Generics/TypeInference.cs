using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._15._Generics.Advanced_Generics
{
    internal class TypeInference
    {
        public static T Min<T>(T[] values) where T : IComparable<T>
        {
            T min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(min) < 0)
                    min = values[i];
            }
            return min;
        }
        public static void Play()
        {
            int[] numbers = { 5, 2, 9, 1, 7 };
            int min = Min(numbers);
            Console.WriteLine(min);
        }
    }
}
