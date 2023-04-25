namespace Arrays
{
    internal class ArrayRun
    {
        public ArrayRun() {
            int [] ar = Define.Play();
            Loop.Play(ar);
            BuiltIn.Sort(ar);
            Loop.Play(ar);
            BuiltIn.Reverse(ar);
            Loop.Play(ar);
            Console.WriteLine("-------------------------------");
        }
    }
}
