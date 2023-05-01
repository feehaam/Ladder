using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._14._Threading
{
    internal class ChildThread
    {
        public static void Play()
        {
            // Create a new thread
            Thread t = new Thread(DoWork);
            // Start the thread
            t.Start();
            // Do partial works
            Console.WriteLine("Hello, I'm being printed while another thread is running!");
            // Wait for the thread to finish
            t.Join();
            Console.WriteLine("Main thread exiting...");
        }

        static void DoWork()
        {
            Console.WriteLine("Thread started...");
            Thread.Sleep(2000); // Simulate some work being done
            Console.WriteLine("Thread finished...");
        }
    }
}
