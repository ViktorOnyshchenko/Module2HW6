using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework6.Cars
{
    public class MercedesBenz : Mercedes
    {
        public FuelType FuelType { get; protected set; }
        public bool Radio { get; private set; }

        public MercedesBenz(string color, decimal price) : base(color, price)
        {
            FuelType = FuelType.Petrol;
            Radio = false;
        }

        public void TurnOnOffRadio()
        {
            if (Radio)
            {
                Console.WriteLine("Radio turned off!");
                Radio = false;
            }
            else
            {
                Console.WriteLine("Radio turned on!");
                Radio = true;
            }
        }
    }
}
