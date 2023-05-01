using Ladder._15._Generics.Advanced_Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._15._Generics
{
    internal class AdvancedGenericsTest
    {
        public static void Play()
        {
            MyDictionary<string, string>.Play();
            TypeInference.Play();
        }
    }
}
