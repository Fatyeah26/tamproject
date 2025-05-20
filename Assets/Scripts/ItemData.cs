using UnityEngine;
[CreateAssetMenu(fileName ="NewItemData" , menuName = "Toomtoom/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite itemIcon;
}