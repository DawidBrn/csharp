using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16
{
    public class CarDirector
    {
        public Car CreateCar(CarBuilder carManufacturer)
        {
            carManufacturer.CreateNewCar();
            carManufacturer.SetChassisType();
            carManufacturer.SetSeatNumber();
            carManufacturer.SetWheelSide();
            carManufacturer.SetWindowNumber();

            return carManufacturer.GetCar();
        }
    }
}
