using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._16._Attributes_and_Reflections
{
    internal class Reflection1 : Attribute1Description // Extended only to get those methods. It could have been okay even if the code was written in Attribute1De... class
    {
        public static void Play()
        {
            MethodInfo methodInfo = typeof(Attribute1Description).GetMethod("MyMethod");
            DescriptionAttribute descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(DescriptionAttribute));
            if (descriptionAttribute != null)
            {
                Console.WriteLine(descriptionAttribute.Description);
            }

        }
    }
}
