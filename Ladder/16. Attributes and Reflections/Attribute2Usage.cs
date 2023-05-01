using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._16._Attributes_and_Reflections
{
    internal class Attribute2Usage
    {
    }

    // In this example, we define a custom attribute called MyCustomAttribute that takes
    // a string parameter called name. The AttributeUsage attribute specifies that this
    // attribute can only be applied to classes.
    [AttributeUsage(AttributeTargets.Class)]
    public class MyCustomAttribute : Attribute
    {
        public string Name { get; set; }

        public MyCustomAttribute(string name)
        {
            Name = name;
        }
    }

    // In this example, we apply the MyCustom attribute to the MyClass class
    // with the value "MyClass" for the Name property.
    [MyCustom("MyClass")]
    public class MyClass
    {
        // implementation
    }


}
