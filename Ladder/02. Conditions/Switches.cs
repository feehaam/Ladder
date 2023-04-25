namespace Conditions
{
    public class Switches
    {
        // Application of switch-case statement
        internal static void fruitChoice(int choice)
        {
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Apple");
                    break;
                case 1:
                    Console.WriteLine("Orange");
                    break;
                case 2:
                    Console.WriteLine("Lemon");
                    break;
                case 3:
                    Console.WriteLine("Mango");
                    break;
                default : Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
