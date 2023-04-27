namespace OOPA
{
    internal class MethodOverriding : A
    {
        override internal void SayHi()
        {
            base.SayHi();
            Console.WriteLine("Feeham");
        }
    }
    class A { 
        virtual internal void SayHi()
        {
            Console.WriteLine("Hi, ");
        }
    }
}
