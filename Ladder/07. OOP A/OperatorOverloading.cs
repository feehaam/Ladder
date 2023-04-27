namespace OOPA
{ 
    internal class OperatorOverloading
    {
        public static void Play()
        {
            Height h1 = new Height(10, 300);
            Height h2 = new Height(20, 600);

            Console.WriteLine(h1);
            Console.WriteLine(h2);
            Console.WriteLine(h1+h2);
        }
    }
    class Height
    {
        private double feet { get; set; }
        private double cm { get; set; }
        public Height(double feet, double cm)
        {
            this.feet = feet;
            this.cm = cm;
        }
        public override string ToString()
        {
            return "Height is: " + feet + " feet " + cm + " centemeters.";
        }
        public static Height operator + (Height h1, Height h2)
        {
            Height temp = new Height(h1.feet+h2.feet, h1.cm+h2.cm);
            return temp;
        }
    }
}
