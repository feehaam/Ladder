namespace OOPA
{
    //Private, Overloading, Static
    internal class ConstructorVarities
    {
        //M m = new M(); can not create a new M, because constructor is private
        N n1 = new N();
        N n2 = new N(5, 10);
        
    }
    class M
    {
        private M() { }
    }
    class N
    {
        int a, b;
        public N()
        {

        }
        public N(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public N(N n)
        {
            a = n.a;
            b = n.b;
        }
    }

    class Perimeter
    {
        private static readonly double pi;
        static Perimeter()
        {
            pi = 3.14159;
            Console.WriteLine("Setting the value of pi");
        }
        public double GetPerimeter(double radius)
        {
            return 2 * pi * radius;
        }
    }
}
