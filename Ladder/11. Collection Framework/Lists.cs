using Microsoft.VisualBasic;
using OOPB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._11._Collection_Framework
{
    internal class Lists
    {
        public static void Play()
        {
            //In the .NET framework, there are several classes that implement the IList interface. Some of these classes include:
            //ArrayList: This class provides a dynamic array implementation of the IList interface.
            //List<T>: This class provides a strongly-typed list implementation of the IList interface.
            //LinkedList<T>: This class provides a doubly-linked list implementation of the IList interface.
            //Queue<T>: This class provides a first-in, first-out (FIFO) implementation of the IList interface.
            //Stack<T>: This class provides a last-in, first-out (LIFO) implementation of the IList interface.
            //SortedSet<T>: This class provides a sorted set implementation of the IList interface.
            ArrayList arrayList = new ArrayList();
            LinkedList<int> linkedList = new LinkedList<int>();
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add(7);
            linkedList.AddLast(5);
            linkedList.AddFirst(10);
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (int i in linkedList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
