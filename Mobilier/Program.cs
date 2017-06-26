using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobilier
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                var service = new FurnitureService();
                var shipment = new Shipment();
                var colissimoShipment = new ColissimoShipment();
                double shipmentPrice = 0;

                var listFurniture = service.getAllFurniture();
                if (listFurniture != null)
                {
                    foreach (var furniture in listFurniture) { 
                        Console.WriteLine(furniture.ToString());
                        shipmentPrice += furniture.ShipmentPrice;
                    }
                    Console.WriteLine();
                    Console.WriteLine("cost of shipment:{0} euros", shipmentPrice);
                }
                Console.WriteLine();
                Console.WriteLine("Enter furniture: (q to exit)");
                string line = Console.ReadLine(); 
                if (line == "q") 
                {
                    break;
                }
                var array = line.Split(' ');
                var added = service.addFurniture(array);
                if (added)
                    Console.WriteLine("furniture added");
                else
                    Console.WriteLine("furniture can't be added");
                Console.WriteLine();
            }
        }
    }
}
