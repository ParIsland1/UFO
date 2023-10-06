using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToInventory : MonoBehaviour
{
    public int inventory = 0;
    
    public void AddtoInventory(int value)
    {
        inventory += value;
        Debug.Log("Inventory: " + inventory);
    }
}