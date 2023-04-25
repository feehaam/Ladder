namespace Arrays
{
    internal class Loop
    {
        // For-each looping in an array
        public static void Play(int[] ar)
        {
            foreach(int x in ar)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
        }
    }
}
