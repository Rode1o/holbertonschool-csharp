using System;

/// <summary> Item class that inherits from BaseClass </summary>
public class Item : BaseClass
{
    public string name { get; set; }
    ///<summary>Optional description of item.</summary>
    public string description { get; set; }
    ///<summary>Optional price of item.</summary>
    public float price { get; set; }
    ///<summary>Optional tag(s) for item.</summary>
    public List<string> tags { get; set; }
    ///<summary>Constructor for item object.</summary>
    public Item(string name, string description=null, float price=0, string[] tags=null)
    {
        this.name = name;
        this.description = description;
        if (price > 0)
            this.price = (float)Math.Round(price, 2);
        this.tags = tags;
    }
}