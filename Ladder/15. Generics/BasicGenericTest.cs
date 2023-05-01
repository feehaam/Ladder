using Ladder._15._Generics.Bsic_Generics;
using Ladder._15._Generics.Bsic_Generics.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._15._Generics
{
    internal class BasicGenericTest
    {
        public static void Play()
        {
            int x = 10; 
            int y = 20;
            Swap.SwapIt(ref x, ref y);

            Console.WriteLine("x = {0} and y = {1}", x, y);
            Console.WriteLine("Between ABC and XYZ, {0} is greater", MaxMin<string>.Max("ABC", "XYZ"));
            Console.WriteLine("Between 25 and 10, {0} is lesser", MaxMin<int>.Min(25, 10));

            ExceptionGeneric.ExceptionGen(new DivideByZeroException());
            ExceptionGeneric.ExceptionGen(new NullReferenceException());

            GenStack<int> stack = new GenStack<int>();
            stack.Push(5);
            stack.Push(10);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            GenStack<string> stackS = new GenStack<string>();
            stackS.Push("Feeham");
            Console.WriteLine(stackS.Pop());
            Console.WriteLine(stackS.Pop());
        }
    }
}
