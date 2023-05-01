using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._09._OOP_C
{
    internal class YeildKeyword
    {
        public static void Play()
        {
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int n in Even(ar))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            foreach (int n in Odd(ar))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            foreach (int n in SquareNumber(10))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
        public static IEnumerable<int> Even(IEnumerable<int> ar)
        {
            foreach(int n in ar)
            {
                if(n % 2 == 0)
                {
                    yield return n;
                }
            }
        }
        public static IEnumerable<int> Odd(IEnumerable<int> ar)
        {
            foreach(int n in ar)
            {
                if(n % 2 == 1)
                {
                    yield return n;
                }
            }
        }
        public static IEnumerable<int> SquareNumber(int upto)
        {
            for(int i = 1; i<=upto; i++)
            {
                yield return i * i;
            }
        }
    }
}
