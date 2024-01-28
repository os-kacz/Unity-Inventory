using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Pickup/NewItem", order = 0)]
public class ItemTemplate : ScriptableObject
{
    public string title;
    public int ID;
    [TextArea]
    public string description;
    public int weight;
    public int value;
    public Sprite image;
    public int MaxStackSize;
}
