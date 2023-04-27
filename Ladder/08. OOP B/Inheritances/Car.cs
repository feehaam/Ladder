using System;
namespace OOPB
{ 
    internal class Car
    {
        private string _name { get; set; }
        private string _description { get; set; }
        private string _brand { get; set; }
        private double _price { get; set; }
        public Car(string name, string description, string brand, double price)
        {
            _name = name;
            _description = description;
            _brand = brand;
            _price = price;
        }
        public void Drive()
        {

        }
    }
}
