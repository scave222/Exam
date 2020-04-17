using System;

namespace RestaurantClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.GenerateReceipt();
        }
    }
}
