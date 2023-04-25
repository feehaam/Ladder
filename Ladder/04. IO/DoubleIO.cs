namespace IO;

internal class DoubleIO
{
    // Handling double input
    internal static void Play()
    {
        Console.WriteLine("Enter a double number");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("You entered: " + x);
    }
}
