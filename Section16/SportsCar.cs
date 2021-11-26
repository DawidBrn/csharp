using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16
{
    class SportsCar : CarBuilder
    {
        public override void SetChassisType()
        {
            carVariant.ChassisType = "Sport";
        }

        public override void SetWindowNumber()
        {
            carVariant.WindowNumber = "4";
        }

        public override void SetSeatNumber()
        {
            carVariant.SeatNumber = "2";
        }

        public override void SetWheelSide()
        {
            carVariant.WheelSide = "Right";
        }
    }
}
