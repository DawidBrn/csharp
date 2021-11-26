using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16
{
    class FamilyCar : CarBuilder
    {

        public override void SetChassisType()
        {
            carVariant.ChassisType = "family";
        }

        public override void SetSeatNumber()
        {
            carVariant.SeatNumber = "6";
        }

        public override void SetWheelSide()
        {
           carVariant.WheelSide = "Right";
        }

        public override void SetWindowNumber()
        {
            carVariant.WindowNumber = "7";
        }
    }
}
