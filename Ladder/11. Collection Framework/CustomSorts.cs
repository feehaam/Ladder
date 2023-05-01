using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._11._Collection_Framework
{
    internal class CustomSorts
    {
        public static void Play()
        {
            List<(int, string, double)> list = new List<(int, string, double)> ();
            list.Add((130, "Feeham", 82.4));
            list.Add((166, "Tanim", 92));
            list.Add((76, "Susmita", 78));

            Print(list);

            list.Sort((a, b) => a.Item1.CompareTo(b.Item1));
            Print(list);

            list.Sort((a, b) => {
                return - (a.Item1.CompareTo(b.Item1));
            });
            Print(list);
        }

        static void Print(List<(int, string, double)> list)
        {
            foreach (var item in list) Console.WriteLine(item.Item1 + ". " + item.Item2 + " -> " + item.Item3);
            Console.WriteLine("---------");
        }
    }
}
