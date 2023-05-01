namespace OOPA
{
    internal class AnonymousType
    {
        public static void Play()
        {
            var person = new
            {
                FirstName = "Muhammad",
                LastName = "Feeham",
                Age = 35
            };
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Age: {person.Age}");
        }
    }
}
