namespace IO
{
    internal class Wrapping
    {
        public static void ConvertAll()
        {
            string strVal = "125.26";
            double doubleVal = Convert.ToDouble(strVal);
            int intVal = (int) doubleVal;
            Console.WriteLine("String: {0}, double: {1}, int: {2}", strVal, doubleVal, intVal);
        }
    }
}
