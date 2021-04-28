using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryEx : MonoBehaviour
{
    public GameObject inventoryExplanation;
    public static bool explanationOn = false;
    public GameObject GlowButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HitMonster.monsterDown == true && Counter.gscore == 1){
            inventoryExplanation.SetActive(true);
            explanationOn = true;
            GlowButton.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F)){
            Destroy(inventoryExplanation);
            explanationOn = false;
            GlowButton.SetActive(false);
            HitMonster.monsterDown = false;
            }
        }  
    }
