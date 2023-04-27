using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPB
{
    internal class Cow : Animal
    {
        public override void Legs()
        {
            Console.WriteLine("I have four legs");
        }

        public override void Sound()
        {
            Console.WriteLine("Hambaaaaaaaa");
        }
    }
}
