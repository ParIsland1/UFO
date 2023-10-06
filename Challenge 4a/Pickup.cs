using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int pickupValue = 1; // Adjust the pickup value as needed

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                // Add the pickup value to the player's inventory
                player.AddToInventory(pickupValue);

                // Destroy the pickup object
                Destroy(gameObject);
            }
        }
    }
}