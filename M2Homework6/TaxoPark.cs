using M2Homework6.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework6
{
    public class TaxoPark : ITaxoPark
    {
        private List<Car> cars;
        public List<Car> Cars { get { return cars; } }
        public TaxoPark()
        {
            cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            if (car != null)
            {
                cars.Add(car);
            }
        }
        public void SortCars()
        {
            cars.Sort();
        }
        public decimal TotalPrice()
        {
            return cars.Select(x => x.Price).Sum();
        }
    }
}
