namespace Conditions
{
    public class IfElse
    {
        // Application of if-else conditions
        internal static void ageVarify(int age)
        {
            if(age < 0 || age > 100)
            {
                Console.WriteLine("INvalid");
            }
            else if(age < 18)
            {
                Console.WriteLine("You can't vote");
            }
            else { 
                Console.WriteLine("You are ready to go!");
            }
        }
        internal static void signCheck(int val)
        {
            Console.WriteLine("The sign of the number {0} is {1}", val, (val >= 0 ? "+" : "-"));
        }
    }
}
