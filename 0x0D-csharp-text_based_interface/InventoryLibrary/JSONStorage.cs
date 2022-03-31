using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 

///<summary>JSON storage Class.</summary>
public class JSONStorage
{
    public Dictionary objects = new Dictionary<string, dynamic>();
    
    ///<summary>Returns all inventory objects.</summary>
    public Dictionary<string, dynamic> All (){
        return objects;
    }
     ///<summary> Add a new key-value pair to objects.</summary>
    public void New(dynamic obj){
        if (obj == null)
            return;

        string key = $"{obj.GetType().Name}.{obj.id}";
        objects.Add(key, obj);
    }
    ///<summary> Saves objects to file.</summary>
    public void Save()
    {
        string jsonString = JsonSerializer.Serialize(objects);
        File.WriteAllText("storage/inventory_manager.json", jsonString);
    }
     ///<summary> deserializes JSON file to objects </summary>
    public void Load()
    {   /* ../../../.. */
        string fileName = "storage/inventory_manager.json";
        string jsonString = File.ReadAllText(fileName);
        objects = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(jsonString);
    }
}