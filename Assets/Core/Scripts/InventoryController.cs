using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryController : MonoBehaviour
{
    public Canvas inventory_canvas;
    //public delegate void ToggleInventoryDelegate(bool _show);
    //public static ToggleInventoryDelegate OnToggleInventory;
    public delegate bool InventoryDelegate();
    public static InventoryDelegate inventory;
    private static bool toggle;
 
    // Start is called before the first frame update
    void Start()
    {
        inventory_canvas = GetComponent<Canvas>();
        inventory_canvas.gameObject.SetActive(false);
        inventory = open_inventory;
    }

    // Update is called once per frame
    public bool toggleInventory()
    {
        return inventory();
    }

    private bool open_inventory()
    {
        Debug.Log("Opened inventory");
        inventory_canvas.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        inventory = close_inventory;
        return true;
    }

    private bool close_inventory()
    {
        Debug.Log("Closed inventory");
        inventory_canvas.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        inventory = open_inventory;
        return false;
    }
}
