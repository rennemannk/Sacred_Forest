using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitMonster : MonoBehaviour
{

 

    public float numOfMonster;
     
    bool hitOne = true;
    bool hitTwo = false;
    bool hitThree = false;
    public Image damageIndicator;
    public bool coolingDown = true;
    public static bool monsterDown = false;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    [Tooltip("The book")]
    public Book book;
    [Tooltip("The type or category of creature")]
    public CreatureType creatureType;


    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Ball") {

            if (hitOne == true) {
                
                hitTwo = true;
                hitOne = false;
                Destroy(heart3);
                
            }
            else if (hitTwo == true) {
                
                hitThree = true;
                hitTwo = false;
                Destroy(heart2);
                
            }
            else if (hitThree == true) {
             
                damageIndicator.fillAmount += numOfMonster;

                Destroy(gameObject);
                Counter.gscore += 1; //add score
                monsterDown = true;
                Destroy(heart1);
                this.book.FoundCreature(this.creatureType);
            }
        }
    }
}
