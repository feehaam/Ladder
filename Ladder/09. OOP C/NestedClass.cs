namespace OOPC
{
    internal class NestedClass
    {
        public static void Play()
        {
            Pair pair = new Pair(130, 50);
        }
        class Pair
        {
            int key, value;
            public Pair(int key, int value)
            {
                this.key = key;
                this.value = value;
            }
        }
    }
}
