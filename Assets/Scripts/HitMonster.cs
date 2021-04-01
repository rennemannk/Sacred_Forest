using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitMonster : MonoBehaviour
{

    public Material red;
    public Material blue;

    bool hitOne = true;
    bool hitTwo = false;
    bool hitThree = false;
    public Image damageIndicator;
    public bool coolingDown = true;
    


    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Ball") {

            if (hitOne == true) {
                gameObject.GetComponent<Renderer>().material = red;
                hitTwo = true;
                hitOne = false;
                
            }
            else if (hitTwo == true) {
                gameObject.GetComponent<Renderer>().material = blue;
                hitThree = true;
                hitTwo = false;
                
            }
            else if (hitThree == true) {
                damageIndicator.fillAmount += .25f;
                Destroy(gameObject);
                Counter.gscore += 1; //add score
            }

        }
    }
}
