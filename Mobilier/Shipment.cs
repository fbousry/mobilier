using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobilier
{
    public interface IShipment
    {
        double Compute(int weight, int height);
    }
    public class Shipment : IShipment
    {
        public double Compute(int weight, int height)
        {
            return weight * height * 0.001;
        }
    }

    public class ColissimoShipment : IShipment
    {
        public double Compute(int weight, int height)
        {
            return weight * 0.55 + height * 0.001;
        }
    }
}
