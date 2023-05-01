namespace EnumException
{
    internal class CreatingExceptions
    {
        public static void Play()
        {
            try
            {
                TestCustomException(200);
            }
            catch (AgeException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
        public static void TestCustomException(int age) 
        {
            if (age < 0 || age > 110)
            {
                throw new AgeException(age);
            }
        }
    }
    internal class AgeException : Exception
    {
        public AgeException() 
        {
        
        }
        public AgeException(int age) : base("Invalid age ("+age+")!") 
        {

        }
    }
}
