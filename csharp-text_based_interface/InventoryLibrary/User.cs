using System;

namespace InventoryLibrary
{
    public class User : BaseClass
    {
        public string name { get; set; }

        public User(string Name)
        {
            this.name = Name;
        }
    }
}