using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MiniGame2/Item")]
public sealed class Item : ScriptableObject
{
    public int value;
    
    public Sprite sprite;
}
