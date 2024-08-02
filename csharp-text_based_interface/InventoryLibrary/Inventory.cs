using System;

namespace inventoryLibrary
{
    public class Inventory : BaseClass
    {
        public string user_id { get; set; }
        public string item_id { get; set; }
        public int quantity;

        public int quantity
        {
            get => quantity;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("can not be negative");
                }
                quantity = value;
            }
        }

        public Inventory(string UserId, string ItemId, int Quantity = 1)
        {
            this.user_id = UserId;
            this.item_id = ItemId;
            this.quantity = Quantity;
        }
    }
}
