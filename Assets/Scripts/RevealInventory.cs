using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevealInventory : MonoBehaviour
{
    public GameObject Inventory;
    public bool InventoryOn = false;


    public void InventoryButtonClick(){
        if (InventoryOn == false){
            Inventory.SetActive(true);
        }
        else if (InventoryOn == true){
            Inventory.SetActive(false);
        }
    }
}
