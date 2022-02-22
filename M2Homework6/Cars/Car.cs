using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework6.Cars
{
    public abstract class Car : IComparable<Car>
    {
        public string Color { get; protected set; }

        public decimal Price { get; protected set; }

        public int CompareTo(Car? other)
        {
            if (this.Price >= other.Price)
            {
                if(this.Price == other.Price)
                {
                    return 0;
                }
                return 1;
            }
            return -1;
        }
    }
}
