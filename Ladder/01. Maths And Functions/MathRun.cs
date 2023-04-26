using Maths;

namespace Maths
{
    public class MathRun
    {
        public MathRun()
        {
            Calculator.Sum(5, 10);
            Calculator.Sub(15, 30);
            Calculator.Mul(10, 20);
            Calculator.Div(10, 30);

            MathClass.Root(12);
            MathClass.Log(16);
            MathClass.Abs(-11);
            MathClass.Floor(3.5);
            MathClass.Ceil(3.5);

            InstanceAndStatic.StaticMethod();
            new InstanceAndStatic().InstanceMethod();

            ParameterVarities.Play();

            Console.WriteLine("-------------------------------");
        }
    }
}
