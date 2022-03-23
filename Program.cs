using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizal_Ardiansyah
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat object taxi
            Taxi taxi = new Taxi();

            //seting parameter taxi
            taxi.DriverName = "Rizal Ardiansyah";
            taxi.OnDuty = true;
            taxi.NumPassenger = 5;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();

        }
    }
}