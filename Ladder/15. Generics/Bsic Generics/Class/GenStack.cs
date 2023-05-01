using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._15._Generics.Bsic_Generics.Class
{
    internal class GenStack <T>
    {
        LinkedList<T> stack;
        public GenStack() 
        { 
            stack = new LinkedList<T>();
        }
        public void Push(T item)
        {
            stack.AddFirst(item);
        }
        public T Pop()
        {
            if (stack.Count == 0)
            {
                return default(T);
            }
            else
            {
                T item = stack.First();
                stack.RemoveFirst();
                return item;
            }
        }
    }
}
