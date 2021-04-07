using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creature : MonoBehaviour
{
    [Tooltip("The book")]
    public Book book;
    [Tooltip("The type or category of creature")]
    public CreatureType creatureType; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Trigger when creature collides with things.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Ball"))
        {
            this.book.FoundCreature(this.creatureType);
        }
    }
}
