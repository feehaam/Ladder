namespace Str
{
    internal class Anagram
    {
        public static void AnagramCheck(string a, string b)
        {
            if(a.Length != b.Length)
            {
                Console.WriteLine("Not an anagram");
                return;
            }
            a = a.ToLower();
            b = b.ToLower();
            int[] freq = new int[26];
            for(int i=0; i<a.Length; i++)
            {
                freq[a[i]-'a']++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                freq[b[i] - 'a']--;
                if (freq[b[i] - 'a'] == -1)
                {
                    Console.WriteLine("Not an anagram");
                    return;
                }
            }
            Console.WriteLine("These strings are anagram");
        }
    }
}
