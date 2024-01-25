using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public ItemTemplate ItemData;
    void OnCollisionEnter(Collision collision)
    {
        IPickupable pickupable = collision.gameObject.GetComponent<IPickupable>();
        if (pickupable != null)
        {
            pickupable.Pickup();
            var inventory = collision.transform.GetComponent<InventoryHolder>();

            if (!inventory) return;

            if (inventory.InventorySystem.AddToInventory(ItemData,1))
            {
                return;
            }
        }
    }
}
