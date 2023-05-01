using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._11._Collection_Framework
{
    internal class PriorityQueues
    {
        public static void Play()
        {
            PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();
            priorityQueue.Enqueue("Goat", 100);
            priorityQueue.Enqueue("Sheep", 100);
            priorityQueue.Enqueue("Ant", 1);
            priorityQueue.Enqueue("Grasopher", 3);
            priorityQueue.Enqueue("Bee", 3);
            priorityQueue.Enqueue("Lion", 350);
            priorityQueue.Enqueue("Cow", 350);

            while(priorityQueue.Count != 0)
            {
                Console.Write(priorityQueue.Dequeue()+" ");
            }
            Console.WriteLine();
        }
    }
}
