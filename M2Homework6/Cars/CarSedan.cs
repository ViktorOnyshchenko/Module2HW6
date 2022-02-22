using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework6.Cars
{
    public class CarSedan : Car
    {
        public const int Seats = 5;
        public CarSedan(string color, decimal price)
        {
            Color = color;
            Price = price;
        }
        public virtual void Move()
        {
            Console.WriteLine($"The car is moving at a speed of {Price} and has {Seats} seats");
        }
    }
}
