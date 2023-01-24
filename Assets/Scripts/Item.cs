using UnityEngine;

[CreateAssetMenu(menuName = "Match-3/Item")]
public sealed class Item : ScriptableObject
{
    public Sprite icon;
    public int value;
}
