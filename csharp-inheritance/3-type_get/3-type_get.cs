using System;
using System.Reflection;

/// <summary>
/// Represents The Obj class.
/// </summary>
class Obj
{
    /// <summary>
    /// Method to print properties.
    /// </summary>
    public static void Print(object myObj)
    {
        Type t = myObj.GetType();
        PropertyInfo[] properties = t.GetProperties();
        MethodInfo[] methods = t.GetMethods();
        
        Console.WriteLine("{0} Properties:", t.Name);

        foreach (var property in properties)
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("{0} Methods:", t.Name);

        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}