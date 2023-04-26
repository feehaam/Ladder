namespace Str
{
    internal class Iterate
    {
        public static void Play()
        {
            string s = "I am none";
            for(int i=0; i<s.Length; i++) {
                Console.Write(s[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
