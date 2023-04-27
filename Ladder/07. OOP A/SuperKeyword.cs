namespace OOPA
{
    internal class SuperKeyword : B
    {
        override internal void SayHi()
        {
            base.SayHi();
            Console.WriteLine("Feeham");
        }
    }
    class B
    {
        virtual internal void SayHi()
        {
            Console.WriteLine("Hi, ");
        }
    }
}
