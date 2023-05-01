using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._16._Attributes_and_Reflections
{
    internal class Attribute3Obsolete
    {
        public Attribute3Obsolete() 
        {
            Obs obj = new Obs();
            obj.MyOldMethod(); // Depricated
            obj.MyNewMethod();
        }
    }
    public class Obs
    {
        [Obsolete("This method is deprecated. Use MyNewMethod instead.")]
        public void MyOldMethod()
        {
            // implementation
        }

        public void MyNewMethod()
        {
            // implementation
        }
    }

}
