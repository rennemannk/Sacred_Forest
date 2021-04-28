using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevealInventory : MonoBehaviour
{
    public GameObject Inventory;
    public bool InventoryOn = false;


    public void Update(){
        if (InventoryOn == false && Input.GetKeyDown(KeyCode.I)){
            Inventory.SetActive(true);
        }
        else if (InventoryOn == true && Input.GetKeyDown(KeyCode.I)){
            Inventory.SetActive(false);
        }
    }
}
