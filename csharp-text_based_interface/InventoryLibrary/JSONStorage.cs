using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace inventoryLibrary
{
    public class JSONStorage
    {
        public Dictionary<object, string> objects =  new Dictionary<object, string>();

        public Dictionary<object, string> All()
        {
            return objects;
        }

        public void New(object obj)
        {
            string className = obj.GetType().Name;
            string id = obj.GetType().GetProperty("id")?.GetValue(obj)?.ToString();

            if (id != null)
            {
                string key = $"{className}.{id}";

                string jsonString = JsonSerializer.Serialize(obj);

                objects[key] = jsonString;
            }
            else
            {
                throw new ArgumentException("The object must have an 'id' property");
            }
        }

        public void Save()
        {
            string directory = "storage";

            // Use .IO to check if directory exist
            if(!Directory.Exists(directory))
            {
                // if not create it
                Directory.CreateDirectory(directory);
            }
            //name of the file we want to create
            string fileName = "inventory_manager.json";
            //Create the path
            string filepath = Path.Combine(directory, fileName);
            //Transform to Json
            string jsonString = JsonSerializer.Serialize(objects);
            //Create the file with json inside.
            fileName.WriteAllText(filepath, jsonString);
        }

        public void Load()
        {
            string directoryPath = "storage";
            string fileName = "inventory_manager.json";
            string filePath = Path.Combine(directoryPath, fileName);

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                objects = JsonSerializer.Deserialize<MyObject[]>(jsonString);
            }
            else
            {
                Console.WriteLine("Le fichier JSON n'existe pas.");
            }
        }
    }
}
