namespace OOPB
{
    internal class AbstractionsRun
    {
        static void Play()
        {
            // Can not access all
            new One().Method1();
            new Two().Method1();
            new Three().Method3();
        }
    }
}
