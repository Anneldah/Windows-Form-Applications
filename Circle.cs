using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public abstract class Circle
    {
        private double Radius;

        public double propRadius
        {
            get { return Radius; }
            set { Radius = value; }
        }
        public Circle()
        {
            propRadius = 0.0d;
        }
        public Circle(double R)
        {
            propRadius = R;
        }
        public virtual double calcArea()
        {
            return (3.14 * propRadius * propRadius);
        }
        public abstract double calcCost();

        public virtual string displayInfo()
        {
            string Message = "";

            Message += "Area of a Circle:" + calcArea().ToString("0.00")+"\n\n";
                Message += "  ";
            return Message;

        }
    }
}
