using M2Homework6.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework6.AbstractFactory
{
    public interface ICarsFactory
    {
        CarCoupe CreateCoupe(string color, int speed);
        CarSedan CreateSedan(string color, int speed);
    }
}
