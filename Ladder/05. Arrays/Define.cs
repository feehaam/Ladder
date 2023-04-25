namespace Arrays
{
    internal class Define
    {
        // Defining arrays in two ways
        internal static int[] Play()
        {
            int[] AR = { 1, 2, 3, 4, 5 };
            int[] ar = new int[5];
            ar[2] = 20; 
            ar[3] = 30;
            ar[4] = 10;
            ar[0] = 50; 
            ar[1] = 100;
            return ar;
        }
    }
}
