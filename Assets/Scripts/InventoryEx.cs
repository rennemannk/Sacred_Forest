using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryEx : MonoBehaviour
{
    public GameObject inventoryExplanation;
    public bool explanationOn = false;
    public GameObject GlowButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HitMonster.monsterDown == true){
            inventoryExplanation.SetActive(true);
            explanationOn = true;
            GlowButton.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F)){
                inventoryExplanation.SetActive(false);
                explanationOn = false;
                GlowButton.SetActive(false);
                HitMonster.monsterDown = false;
            }
        }  
    }
}
