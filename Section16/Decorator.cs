using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16
{
    public interface IVehicle
    {
        public string Type { get; }
        public double Price { get; }
    }
    public class Vehicle : IVehicle
    {
        public string Type { get { return " Tesla"; } }

        public double Price { get { return 5000000; } }

       
    }
    public abstract class CarDecorator :IVehicle
    {
        public IVehicle vehicle;
        public CarDecorator(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string Type { get { return vehicle.Type; } }

        public double Price { get { return vehicle.Price; } }
    }
    public class DisountedVihecles : CarDecorator
    {
        public DisountedVihecles(IVehicle vehicle) : base(vehicle) { }

        public int DiscountPercentage { get; set; }
        public string Offer { get; set; }

        public double Price
        {
            get
            {
                double price = base.Price;
                int percentage = 100 - DiscountPercentage;
                return Math.Round((price * percentage) / 100, 2);
            }
        }
    }
}
