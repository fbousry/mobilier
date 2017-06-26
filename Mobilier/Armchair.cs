using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobilier
{
    public class Armchair : Furniture
    {
        public Armchair(string designerName, int height, int weight, int price, int shipmentPrice)
        {
            this.DesignerName = designerName;
            this.Height = height;
            this.Weight = weight;
            this.Price = price;
            this.ShipmentPrice = shipmentPrice;
            this.Type = "Armchair";
        }
    }
}
