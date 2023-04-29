namespace OOPC
{
    internal class Shallow
    {
        static public void Play()
        {
            Animal cat1 = new Animal("Cat", 
                "It a domestic animal and it loves to sleep!", 
                "Milk & Fish");
            Animal cat2 = cat1;
            Console.WriteLine(cat1);
            Console.WriteLine(cat2);
        }
    }
}
