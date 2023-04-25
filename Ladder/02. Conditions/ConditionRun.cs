namespace Conditions
{
    public class ConditionRun
    {
        public ConditionRun() {
            IfElse.ageVarify(25);
            IfElse.ageVarify(105);
            IfElse.ageVarify(5);

            IfElse.signCheck(5);
            IfElse.signCheck(-22);

            Switches.fruitChoice(3);
            Switches.fruitChoice(4);
            Console.WriteLine("-------------------------------");
        }
    }
}
