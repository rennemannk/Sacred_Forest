using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{

    public string levelToLoad;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("has quited");
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.P) ) {
            Application.LoadLevel(levelToLoad); }
            
    }
}
