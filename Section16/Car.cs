using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16
{
    public class Car
    {
        public string ChassisType { get; set; }
        public string WindowNumber { get; set; }
        public string SeatNumber { get; set; }
        public string WheelSide { get; set; }

        public void DisplayCar()
        {
            Console.WriteLine("Chassis type : " + ChassisType);
            Console.WriteLine("Window number : " + WindowNumber);
            Console.WriteLine("Seet number : " + SeatNumber);
            Console.WriteLine("Wheel side : " + WheelSide);
        }
    }
}
