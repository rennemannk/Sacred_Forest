using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public static int gscore = 0; 
    public Text scoreText;
    public string levelToLoad;

    public GameObject portal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Monsters: " + gscore;
        if (gscore == 4){
            portal.SetActive(true);
            //Application.LoadLevel(levelToLoad);
        }
    }
}
