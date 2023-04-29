namespace OOPC
{
    internal class Animal
    {
        private string name { get; set; }
        private string description { get; set; }
        private string favoriteFood { get; set; }
        public Animal(string name, string description, string favoriteFood)
        {
            this.name = name;
            this.description = description;
            this.favoriteFood = favoriteFood;
        }
        public override string ToString()
        {
            return name + " | " + description + " | It loves to eat: " + favoriteFood;
        }
        public Animal DeepCopy()
        {
            Animal temp = new Animal("", "", "");
            temp.name = name;
            temp.description = description;
            temp.favoriteFood = favoriteFood;
            return temp;
        }
        public static Animal operator ! (Animal og)
        {
            Animal temp = new Animal("", "", "");
            temp.name = og.name;
            temp.description = og.description;
            temp.favoriteFood = og.favoriteFood;
            return temp;
        }
    }
}
