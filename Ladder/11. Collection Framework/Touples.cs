using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._11._Collection_Framework
{
    internal class Touples
    {
        public static void Play()
        {
            // Create a tuple with two elements
            Tuple<string, int> myTuple = new Tuple<string, int>("apple", 1);

            // Access the elements of the tuple using Item1 and Item2 properties
            Console.WriteLine("Item1: " + myTuple.Item1);
            Console.WriteLine("Item2: " + myTuple.Item2);

            // Create a tuple with three elements
            var myOtherTuple = Tuple.Create("banana", 2, true);

            // Access the elements of the tuple using named variables
            string fruit = myOtherTuple.Item1;
            int count = myOtherTuple.Item2;
            bool isRipe = myOtherTuple.Item3;

            Console.WriteLine("Fruit: " + fruit);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Is ripe: " + isRipe);
        }
    }
}
