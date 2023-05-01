using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._17._Asynchronous_Programming
{
    internal class HareAndTortoise
    {
        public static async Task Play()
        {
            // Though the functions are saying that we can run in asynchonous way but by using the await 
            // keyword, the functions are treated just like all traditional functions. 
            // As a result after a long time wastage by Tortoise(), the Hare() function will be called. 
            //await Tortoise();
            //await Hare();

            // But now lets run asynchonous programming
            Tortoise();
            Hare();
        }
        static int run = 1;
        async static Task Hare()
        {
            Console.WriteLine("Hare started running.("+run+")");
            await Task.Delay(100);
            Console.WriteLine("Hare completed running.(" + run + ")");
        }
        async static Task Tortoise()
        {
            Console.WriteLine("Tortoise started running.(" + run + ")");
            await Task.Delay(2500);
            Console.WriteLine("Tortoise completed running.(" + run + ")");
        }
    }
}
