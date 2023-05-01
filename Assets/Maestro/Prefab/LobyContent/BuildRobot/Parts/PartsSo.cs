using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Parts/PartsData")]
public class PartsSo : ScriptableObject
{
    public Sprite partsImage;
    public string partsname;
    public float atk;
    public float def;
    public string info;
}
