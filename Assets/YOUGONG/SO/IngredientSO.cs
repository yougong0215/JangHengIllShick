using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum IngredientValues
{ 
    Metal = 0,
    TITANYUM,
    PLATINUM,
    DISCONYUM,
    DELTANYUM
}


public class Ingreient
{   

    static Dictionary<IngredientValues, int> IngredentDC = new Dictionary<IngredientValues, int>();

    public static void AddIngredent(IngredientValues Ing, int value)
    {
        if (IngredentDC.ContainsKey(Ing))
            IngredentDC[Ing] += value;
        else
            IngredentDC.Add(Ing, value);
    }

    public static int GetIngredent(IngredientValues Ing)
    {
        return IngredentDC[Ing];
    }
}   