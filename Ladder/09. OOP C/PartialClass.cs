namespace OOPC
{
    internal class PartialClass
    {
        public static void Play()
        {
            Meal meal = new Meal(5);
            meal.BreakFast();
            meal.Snack();
            meal.Dinner();
            meal.Lunch();
        }
    }
    public partial class Meal
    {
        public Meal(int x)
        {

        }
        public void BreakFast()
        {

        }
        public void Lunch()
        {

        }
    }
    public partial class Meal
    {
        public void Dinner()
        {

        }
        public void Snack()
        {

        }
    }
}
