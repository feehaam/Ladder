namespace Loop
{
    internal class AllLoops
    {
        // Application of all loops
        internal static void LoopIt()
        {
            // For
            for(int i=0; i<10; i++) {
                Console.Write(i+" ");
            }

            // fOR
            for(int i=9; ;)
            {
                i++;
                if (i == 20) break;
                if (i % 2 == 0) continue;
                Console.Write(i+" ");
            }
            Console.WriteLine();

            // While
            int t = 5; 
            while(t --> 0)
            {
                Console.Write(t+" ");
            }
            Console.WriteLine();

            // Do while
            int x = 1; 
            do
            {
                Console.WriteLine("I love you");
                x--;
            }
            while (x > 0);

            int[] ar = { 1, 2, 3, 4, 5, 6 };
            foreach(int v in ar)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();
        }
    }
}
