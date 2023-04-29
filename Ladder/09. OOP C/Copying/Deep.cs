namespace OOPC
{
    internal class Deep
    {
        public static void Play()
        {
            Animal tiger1 = new Animal("Tigher",
                "It a wild animal and it loves to hunt!",
                "Deers");
            Animal tiger2 = tiger1.DeepCopy();
            Console.WriteLine(tiger1);
            Console.WriteLine(tiger2);
        }
    }
}
