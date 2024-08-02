using System;

public class Item : BaseClass
{
    public string name { get; set; }
    public string description { get; set; }
    public float price { get; set; }
    public List<string> tags { get; set; }

    public Item(string Name, string Description, float Price = 0.00f, List<string> Tags)
    {
        this.name = Name;
        this.description = Description;
        this.price = Price;
        this.tags = new List<string>();
    }
}