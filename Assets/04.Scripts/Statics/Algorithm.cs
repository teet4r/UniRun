using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algorithm
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T t = a; a = b; b = t;
    }
}
