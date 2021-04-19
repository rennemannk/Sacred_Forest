using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPortal : MonoBehaviour
{
    public string levelToLoad;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Destroy(gameObject);
            Application.LoadLevel(levelToLoad);
        }
    }
}
