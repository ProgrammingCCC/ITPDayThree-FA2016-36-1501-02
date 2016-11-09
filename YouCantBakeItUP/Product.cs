using System;


namespace YouCantBakeItUP
{
    class Product
    {
        //attributes
        public double Price;
        public string Name;
        public double Popularity;
        public string Taste;

        //constructor
        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //operations
        public void Decay()
        {
            //statements for the method
        }

        public void About()
        {
            Console.WriteLine("The " + Name + " costs $" + Price);
        }
    }
}
