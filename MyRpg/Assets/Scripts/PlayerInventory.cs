using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the actual object containing the player inventory
[System.Serializable]
[CreateAssetMenu(fileName = "New inventory", menuName = "Inventory/player Inventory")]
public class PlayerInventory : ScriptableObject
{
    public int numOfKeys;
    public int coins;

    public void Awake()
    {
        coins = 0;
    }

    public void AddToInvKey() //for chests
    {
        numOfKeys++; 
    }
}