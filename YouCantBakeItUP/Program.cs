using System;

/* 
 * Title of Program 
 * Your Name, Date
 * Introduction to Programming
 */

namespace YouCantBakeItUP
{

    class Program
    {
        static void Main()
        {
            Product swissChocolateDonut = new Product("Swiss Chocolate Donut", 2.00);
            Product BloooooBerryMufen = new Product();
            BloooooBerryMufen.Name = "BlooooBerry Mufen";
            BloooooBerryMufen.Price = 3;

            swissChocolateDonut.About();
            BloooooBerryMufen.About();

            Console.ReadKey();
        }
    }
}
