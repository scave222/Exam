using System;
namespace Area
{
    public class Rectangle
    {
        private double length = 1;
        private double width = 1;

        public double Length
    {
        get { return length; }
        set
        {
            if ((value <= 0.0) || (value >= 20.0))
            {
            length = value;
            }
        }

        
    }

       public double Width
    {
        get { return width; }
        set
        {
            if ((value <= 0.0) || (value >= 20.0))
            {
            width = value;
            }
        }

    }

    public Rectangle (double lenth, double with)
    {
        Length = lenth;
        Width = with;
    }

    public double area(double len, double wit)
    {
        return len * wit;
    }

    public void ToString(double length, double width)
    {
        
         area(length,width);
         
    }
}
}