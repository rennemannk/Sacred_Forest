using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowScript : MonoBehaviour
{
    public GameObject ballPrefab;
    

    float rockImpulse = 30f;

    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
        {
            Camera cam = Camera.main;
            GameObject therock = (GameObject)Instantiate(ballPrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            therock.GetComponent<Rigidbody>().AddForce(cam.transform.forward * rockImpulse, ForceMode.Impulse);
        }
    }
}

