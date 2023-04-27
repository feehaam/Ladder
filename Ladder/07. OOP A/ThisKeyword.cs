namespace OOPA
{
    internal class ThisKeyword
    {
        int val = 10;
        public void Play()
        {
            int val = 20;
            Console.WriteLine("value = {0}, this.value = {1}", val, this.val);
        }
    }
}
