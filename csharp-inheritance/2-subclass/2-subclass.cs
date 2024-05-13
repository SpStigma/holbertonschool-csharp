using System;

/// <summary>
/// Represent the obj class.
/// </summary>
class Obj
{
    /// <summary>
    /// Method to return True if it is a Subclass.
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);  
    }
}
