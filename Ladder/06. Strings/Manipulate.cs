namespace Str
{
    internal class Manipulate
    {
        public static void Play()
        {
            string s = "I am feeham";
            Console.WriteLine("Length of string: "+s.Length);
            Console.WriteLine("Index of name: " + s.IndexOf("fee"));
            string name = s.Substring(5, s.Length - 5);
            Console.WriteLine(name);
            Console.WriteLine(s.Replace(" ", "_"));
        }
    }
}
