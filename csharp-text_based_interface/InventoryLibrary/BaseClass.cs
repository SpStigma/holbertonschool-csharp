using System;

namespace inventoryLibrary
{
    public class BaseClass
    {
        public string id { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }

        public BaseClass()
        {
            id = Guid.NewGuid().ToString();
            date_created = DateTime.UtcNow;
            date_updated = DateTime.UtcNow;
        }
    }
}