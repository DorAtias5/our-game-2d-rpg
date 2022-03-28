using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//the blueprint and all the data an item needs
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Items")]

public class InventoryItem : ScriptableObject
{
    public string itemName;
    public string description;
    public int numberInInv; //if not unique can stack
    public bool isKey;
    public string relatedText;
    public Sprite itemImg;
    public UnityEvent thisEvent;

    public void Use()
    {
        thisEvent.Invoke();
    }

    public void DecreaseAmount(int amount)
    {
        numberInInv -= amount;
        if (numberInInv < 0)
        {
            numberInInv = 0;
        }
    }

    public void IncreaseAmount(int amount)
    {
        numberInInv += amount;
        if (numberInInv > 999)
        {
            numberInInv = 999;
        }
    }
}