using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobilier
{
    public class Table : Furniture
    {
        public Table(string designerName, int height, int weight, int price)
        {
            this.DesignerName = designerName;
            this.Height = height;
            this.Weight = weight;
            this.Price = price;
            this.Type = "Table";
        }
    }
}
