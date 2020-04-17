using System;
namespace RestaurantClass
{
    public class Restaurant
    {
        public string Name{get; set;}
        public string Address{get; set;}

        private double gratuity;

        public double Gratuity{
            get{return value;}
            set{
                if(gratuity < 0)
                return 0.0;
            }

        }

        public Restaurant(string name, string address, double _gratuity)
        {
            Name = name;
            Address = address;
            Gratuity = _gratuity;
        }

        public int GenerateReceipt()
        {
            int[] prices = {20,50,200,120,150,40};
            int num =0;;
            int subtotal =0;
            while (num < prices.Length)
            {
                subtotal += prices[num];
        
                num++;
            }
            if( prices.Length >= 6)
            {
                double gratuity = total/0.15;
            }
            double grandtotal = subtotal + gratuity;

            Console.WriteLine($"The subtotal is: {subtotal}");
            Console.WriteLine($"The gratuity is: {gratuity}");
            Console.WriteLine($"The grandtotal is: {grandtotal}");
        }
    }
}