namespace OOPB
{
    internal class One
    {
        public void Method1()
        {
            new Two().Method1();
        }
    }
    public class Two 
    {
        internal void Method1() 
        {
            Method2();
        }
        protected void Method2()
        {
            new Three().Method2();
        }
    }
}
