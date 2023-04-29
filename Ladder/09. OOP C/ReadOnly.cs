namespace OOPC
{
    internal class ReadOnly
    {
        public static readonly double pi;
        public static readonly int lightSpeed;
        static ReadOnly()
        {
            pi = Math.PI;
            lightSpeed = 300000000;
        }
    }
}
