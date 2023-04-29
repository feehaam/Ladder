using OOPA;

namespace OOPC
{
    internal class DeepCopyWithOperatorOverload
    {
        public static void Play()
        {
            Animal goat1 = new Animal("Goat",
                "It a domestic animal and it loves to yell!",
                "Leaf");
            Animal goat2 = (!goat1.DeepCopy());
            Console.WriteLine(goat1);
            Console.WriteLine(goat2);
        }
    }
}
