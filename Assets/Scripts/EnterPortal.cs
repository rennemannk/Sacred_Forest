using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPortal : MonoBehaviour
{
    public string levelToLoad;

    void onTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "portal")
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}
