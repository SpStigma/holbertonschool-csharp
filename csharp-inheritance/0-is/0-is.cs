using System;

/// <summary>
/// Represent the class obj.
/// </summary>
class Obj
{
    /// <summary>
    /// Method that return true or false if is type int.
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}

