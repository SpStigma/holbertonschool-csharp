using System;
using System.Collections.Generic;

/// <summary>
/// Represent the Obj class.
/// </summary>
class Obj
{
    /// <summary>
    /// Represent the method to return true of false if is type s Array or inherited from Array.
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
