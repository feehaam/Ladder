using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPB
{
    internal class Duck : Animal
    {
        public override void Legs()
        {
            Console.WriteLine("I have two legs");
        }

        public override void Sound()
        {
            Console.WriteLine("Pek pek pek pek");
        }
    }
}
