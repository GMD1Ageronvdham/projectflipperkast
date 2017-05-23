using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public bool inventoryIsOpen;
    public GameObject Inventory;

    void Start()
    {
        CloseInventory();
    }
    void Update ()
    {
		if (Input.GetButtonDown("Inventory"))
        {
            if (inventoryIsOpen == false)
            {
                inventoryIsOpen = true;
                OpenInventory();
            }else if (inventoryIsOpen == true)
            {
                inventoryIsOpen = false;
                CloseInventory();
                Inventory.GetComponent<Inventory>().DisplayNothing();
            }
        }
        if (Input.GetButtonDown("Cancel"))
        {
            if (inventoryIsOpen == true)
            {
                inventoryIsOpen = false;
                CloseInventory();
                Inventory.GetComponent<Inventory>().DisplayNothing();
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

        }
	}
    public void OpenInventory()
    {
        Inventory.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;

    }
    public void CloseInventory()
    {
        Inventory.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
