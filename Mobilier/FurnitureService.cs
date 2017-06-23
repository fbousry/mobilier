using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;

namespace Mobilier
{
    public class FurnitureService
    {
        private string jsonPath = Path.Combine(Environment.CurrentDirectory, @"..\..\Json\furniture.json");        

        /// <summary>
        /// add a single furniture
        /// </summary>
        /// <param name="array">property of the furniture</param>
        /// <returns>return true if the furniture is succesfully added</returns>
        public bool addFurniture(String[] array)
        {
            Furniture furniture = null;
            int height = 0, weight = 0, price = 0;

            if (array != null & array.Count() >= 6)
            {
                if (array[0] == "add")
                {
                    if (Int32.TryParse(array[3], out height) && Int32.TryParse(array[4], out weight) && Int32.TryParse(array[5], out price))
                    {
                        switch (array[1].ToUpper())
                        {
                            case "TABLE":
                                furniture = new Table(array[2], height, weight, price);
                                break;
                            case "CHAIR":
                                furniture = new Chair(array[2], height, weight, price);
                                break;
                            case "ARMCHAIR":
                                furniture = new Armchair(array[2], height, weight, price);
                                break;
                        }
                        AddFurnitureToJson(furniture);
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// add a furniture to the Json file
        /// </summary>
        /// <param name="furniture"></param>
        private void AddFurnitureToJson(Furniture furniture)
        {
            var list = getAllFurniture();
            if (list == null)
                list = new List<Furniture>();
            list.Add(furniture);
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            
            using (TextWriter writer = File.CreateText(jsonPath))
            {
                writer.Write(convertedJson);
            }
        }

        /// <summary>
        /// return a list of all the furnitures from Json file
        /// </summary>
        /// <returns></returns>
        public List<Furniture> getAllFurniture()
        {
            var list = new List<Furniture>();
            string jsonString = String.Empty;
            using (TextReader reader = File.OpenText(jsonPath))
            {
                jsonString = reader.ReadToEnd();
            }
            list = JsonConvert.DeserializeObject<List<Furniture>>(jsonString);            
            return list;
        }
    }
}
