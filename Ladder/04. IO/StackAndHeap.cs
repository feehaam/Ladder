namespace IO
{
    internal class StackAndHeap
    {
        public static void Play()
        {
            // goes into stack memory
            int a = 0;
            int b = 0;
            GoToHeap gth;

            // goes to heap memory 
            gth = new GoToHeap();
        }
    }
    public class GoToHeap
    {
        int a = 0, b = 0;
    }
}
