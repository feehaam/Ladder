using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._14._Threading
{
    internal class TripleThread
    {
        public static void Play()
        {
            Chars chars = new Chars();
            Nums nums = new Nums();

            Console.WriteLine("Everything is peacefull, sequencial but slow!");
            chars.PrintLower();
            chars.PrintUpper();
            nums.Print();

            Thread t1 = new Thread(chars.PrintLower);
            Thread t2 = new Thread(chars.PrintUpper);
            Thread t3 = new Thread(nums.Print);

            Console.WriteLine("\n\nFull of chaos, unordered but fast!");
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
    class Chars
    {
        public void PrintLower()
        {
            for (int i = 0; i < 26; i++)
            {
                char c = (char)('a' + i);
                Console.Write(c+" ");
                if (i % 5 == 0 && i != 0) Console.WriteLine();
                Thread.Sleep(100);
            }
        }
        public void PrintUpper()
        {
            for (int i = 0; i < 26; i++)
            {
                char c = (char)('A' + i);
                Console.Write(c+" ");
                if (i % 5 == 0 && i != 0) Console.WriteLine();
                Thread.Sleep(100);
            }
        }
    }
    class Nums
    {
        public void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                char c = (char)('0' + i);
                Console.Write(c+" ");
                if (i % 5 == 0 && i != 0) Console.WriteLine();
                Thread.Sleep(100);
            }
        }
    }

}
