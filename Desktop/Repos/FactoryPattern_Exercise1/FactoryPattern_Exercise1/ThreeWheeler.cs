using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Exercise1
{
    public class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Three Wheeler is in drive.");
        }

    }
}
