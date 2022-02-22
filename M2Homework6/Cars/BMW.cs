using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework6.Cars
{
    public class BMW : CarCoupe
    {
        public const string CompanyName = "BMW";

        public BMW(string color, decimal price) : base(color, price)
        {
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine($"The car called {CompanyName}");
        }
    }
}
