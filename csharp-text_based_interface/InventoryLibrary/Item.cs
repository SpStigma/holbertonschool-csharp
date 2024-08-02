using System;
using System.Collections.Generic;

namespace inventoryLibrary
{
    public class Item : BaseClass
    {
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public List<string> tags { get; set; }

        public Item(string Name, string Description, float Price = 0.00f, List<string> Tags = null)
        {
            this.name = Name;
            this.description = Description;
            this.price = Price;
            this.tags = Tags ?? new List<string>();
        }
    }
}