using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._11._Collection_Framework
{
    internal class Hashings
    {
        public static void Play()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(231, "Milk");
            dict.Add(300, "Bread");
            dict.Add(2, "Sugar");
            string val;
            dict.TryGetValue(231, out val);
            Console.WriteLine(val);
        }
    }
}
