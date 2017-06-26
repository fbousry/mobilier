using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobilier
{
    public class Furniture
    {
        public String DesignerName { get; set; }

        public Int32 Height { get; set; }

        public int Weight { get; set; }

        public int Price { get; set; }

        public String Type { get; set; }

        public int ShipmentPrice { get; set; }

        public override string ToString()
        {
            return "§ " + Type + " " + DesignerName + " " + Height + "cm " + Weight + "kg " + Price + "euros " + "prix de livraison:" + ShipmentPrice + " euros ";
        }
    }
}
