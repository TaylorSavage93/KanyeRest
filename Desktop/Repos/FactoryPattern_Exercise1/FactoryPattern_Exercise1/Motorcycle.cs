using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Exercise1
{
    internal class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The motorcyle is in drive.");
        }
    }
}
