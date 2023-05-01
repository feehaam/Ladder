using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._17._Asynchronous_Programming
{
    internal class SyncWithAsync
    {
        static string hello = "Hello";
        public static async Task Play()
        {
            GetData();
            Console.WriteLine(hello);
        }
        static async Task GetData()
        {
            await Task.Delay(100);
            hello = "Hi there!";

            Console.WriteLine(hello);
        }
    }
}
