using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DissapearBall : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Monster")
        {
            Destroy(gameObject);

        }

        if (col.gameObject.tag == "Terrain ")
        {
            Destroy(gameObject);

        }
    }
}