using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Armor", fileName = "New Armor")]

public class Armors : ScriptableObject
{
    public string armorName;
    public string armorDescription;
    public Sprite armorSprite;
    public float armorRsistance;
}