using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework6.Cars
{
    public class CarCoupe : Car, IMovable
    {
        public const int Seats = 2;

        public CarCoupe(string color, decimal price)
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
