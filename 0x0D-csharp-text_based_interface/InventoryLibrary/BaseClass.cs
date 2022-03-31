using System;

/// <summary> BaseClass to inherit from </summary>
public class BaseClass
{
    /// <summary> id of the object </summary>
    public string id{get; set;}
    /// <summary> date when object was created </summary>
    public DateTime date_created{get; set;}
    /// <summary> date when object was updated </summary>
    public DateTime date_updated{get; set;}

    ///<summary>Base Class constructor.</summary>
    public BaseClass()
    {
        this.id = System.Guid.NewGuid().ToString();
        this.date_created = DateTime.Now;
        this.date_updated = DateTime.Now;
    }
}
