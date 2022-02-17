using M2Homework6.AbstractFactory;
using M2Homework6.Cars;

namespace M2Homework6
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            TaxoPark park = new TaxoPark();
            ICarsFactory factoryBMW = new BMWFactory();
            Car car = factoryBMW.CreateCoupe("red", 320000);
            ICarsFactory factoryMercedes = new MercedesFectory();
            Car car2 = factoryMercedes.CreateSedan("blue", 240000);
            park.AddCar(car);
            park.AddCar(car2);
            List<Car> cars = park.Cars;
            Console.WriteLine("Cars:");
            foreach(Car entry in cars)
            {
                Console.WriteLine($"\t{entry.Color} {entry.Price}");
            }
            park.SortCars();
            cars = park.Cars;
            Console.WriteLine("Cars after sort:");
            foreach (Car entry in cars)
            {
                Console.WriteLine($"\t{entry.Color} {entry.Price}");
            }
            decimal price = 250000;
            Car foundCar = cars.FindCar(250000);
            if (foundCar == null)
            {
                Console.WriteLine($"Found car: {foundCar.Color} {foundCar.Price}");
            }
            else
            {
                Console.WriteLine($"Car with price less than or equal to {price} not found!");
            }
                Console.WriteLine($"Total price is: {park.TotalPrice()}");
            Console.ReadLine();
        }
    }
}