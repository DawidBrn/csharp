using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16
{
    public abstract class CarBuilder
    {
        protected Car carVariant;

        public abstract void SetChassisType();
        public abstract void SetWindowNumber();
        public abstract void SetSeatNumber();
        public abstract void SetWheelSide();

        public void CreateNewCar()
        {
            carVariant = new Car();
        }
        public Car GetCar()
        {
            return carVariant;
        }
    }
}
