namespace Str
{
    internal class Palindrome
    {
        internal static void CheckPalindrome(string s)
        {
            for(int i=0; i<s.Length/2; i++)
            {
                int left = i, right = s.Length - i - 1;
                if (s[left] != s[right])
                {
                    Console.WriteLine("Not a palindrome");
                    return;
                }
            }
            Console.WriteLine("It is a palindrome!");
        }
    }
}
