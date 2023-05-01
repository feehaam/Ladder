using System;

namespace EnumException
{
    internal class HandlingExceptions
    {
        public static void Play()
        {
            DivideZero();
            NullValue(null);
        }
        public static void DivideZero()
        {
            int a = 10;
            int b = 0;
            try
            {
                int x = a / b;
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("Exception occured: Division impossible");
            }
        }
        public static void NullValue(string str)
        {
            try
            {
                Console.WriteLine(str.Length);
            }
            catch(NullReferenceException nre)
            {
                Console.WriteLine("Exception occured: Null reference");
            }
        }
        
    }
}
