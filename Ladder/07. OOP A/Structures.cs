namespace OOPA
{
    internal class Structures
    {
        Student student = new Student("Feeham", 130, "CSE");
    }
    struct Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Department { get; set; }
        public Student(string name, int id, string department)
        {
            Name = name;
            Id = id;
            Department = department;
        }
        public void Print()
        {
            Console.WriteLine(Id+". "+Name+" from "+Department);
        }
    }
}
