using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._11._Collection_Framework
{
    internal class Queues
    {
        public static void Play()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(4);
            while (queue.Count > 0)
            {
                int x = queue.Dequeue();
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
