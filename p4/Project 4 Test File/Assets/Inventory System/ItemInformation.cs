using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemInformation : MonoBehaviour
{
    public Item thisitem;
    public Inventory inventory;


    void OnTriggerEnter(Collider player)
    {
        inventory.InventoryChange(thisitem);
        Destroy(gameObject);
    }
}
