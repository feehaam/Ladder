using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._11._Collection_Framework
{
    internal class Stacks
    {
        public static void Play()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(3);
            stack.Push(4);
            while(stack.Count > 0)
            {
                int x = stack.Pop();
                Console.Write(x+" ");
            }
            Console.WriteLine();
        }
    }
}
