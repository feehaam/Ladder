namespace EnumException
{
    internal class EnumTest
    {
        public static void Play()
        {
            // By default it is set to first item
            Level level = new Level();
            Console.WriteLine(level);
            level = Level.Medium;
            Console.WriteLine(level);
            // By default the value of enum is its index
            int val = (int)level;
            Console.WriteLine(val);
            level = Level.High;
            // But this time it'll show 10 as value
            val = (int)level;
            Console.WriteLine(val);
        }
    }
    public enum Level
    {
        Low, 
        Medium, 
        High = 10
    }
}
