using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle areas= new Rectangle(3,2);
           double num = areas.area(3,2);

            Console.Write($"The area is {num}");
        }
    }
}

