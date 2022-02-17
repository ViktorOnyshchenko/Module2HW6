using M2Homework6.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework6
{
    public static class TaxoParkExtentions
    {
        public static Car? FindCar(this List<Car> cars, decimal price)
        {
            return cars.First(car => car.Price <= price) ?? null;
        }
    }
}
