namespace IO;

internal class IntIO
{
    // Handling integer input
    internal static void Play()
    {
        Console.WriteLine("Enter an integer number");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You entered: " + x);
    }
}
