namespace OOPA
{
    internal class MethodOverloading
    {
        static int sum(int a, int b)
        {
            return a + b;
        }
        static int sum(int a, int b, int c)
        {
            return (a + b + c);
        }
        static int sum(params int[] numbers)
        {
            int s = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                s += numbers[i];
            }
            return s;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        static int mul(params int[] numbers)
        {
            int s = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                s *= numbers[i];
            }
            return s;
        }
    }
}
