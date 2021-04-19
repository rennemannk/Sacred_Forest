using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public static int gscore = 0; 
    public string levelToLoad;
    public int numMon;

    public GameObject portal;
    
    
    // Update is called once per frame
    void Update()
    {
        if (gscore == numMon){
            portal.SetActive(true);
            //Application.LoadLevel(levelToLoad);
        }
    }
}
