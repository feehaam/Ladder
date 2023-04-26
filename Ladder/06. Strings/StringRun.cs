namespace Str
{
    internal class StringRun
    {
        public StringRun()
        {
            Iterate.Play();
            Anagram.AnagramCheck("Bangladesh", "Bangladeshi");
            Anagram.AnagramCheck("Bangladesh", "Bangaadesh");
            Anagram.AnagramCheck("Bangladesh", "Bangladesh");
            Palindrome.CheckPalindrome("abaaba");
            Palindrome.CheckPalindrome("ababa");
            Palindrome.CheckPalindrome("abcaba");
            ExtentionMethod.Play();
            Manipulate.Play();
        }
    }
}
