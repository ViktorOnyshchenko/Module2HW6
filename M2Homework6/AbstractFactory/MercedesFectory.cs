using M2Homework6.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework6.AbstractFactory
{
    public class MercedesFectory : ICarsFactory
    {
        public CarCoupe CreateCoupe(string color, int speed)
        {
            throw new NotImplementedException();
        }

        public CarSedan CreateSedan(string color, int speed)
        {
            return new Mercedes(color, speed);
        }
    }
}
