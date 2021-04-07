using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    [Tooltip("The book")]
    public GameObject book;

    [Tooltip("Show the card?")]
    public bool showCard1;
    [Tooltip("The card")]
    public GameObject card1;
    [Tooltip("Show the card?")]

    public bool showCard2;
    [Tooltip("The card")]
    public GameObject card2;

    [Tooltip("Show the card?")]
    public bool showCard3;
    [Tooltip("The card")]
    public GameObject card3;

    [Tooltip("Show the card?")]
    public bool showCard4;
    [Tooltip("The card")]
    public GameObject card4;

    [Tooltip("Show the card?")]
    public bool showCard5;
    [Tooltip("The card")]
    public GameObject card5;

    [Tooltip("Show the card?")]
    public bool showCard6;
    [Tooltip("The card")]
    public GameObject card6;

    // creature counters
    public Text catCountText;
    public int catCount = 0;
    public Text duckCountText;
    public int duckCount = 0;
    public Text penguinCountText;
    public int penguinCount = 0;
    public Text flowerCountText;
    public int flowerCount = 0;
    public Text moleCountText;
    public int moleCount = 0;
    public Text sheepCountText;
    public int sheepCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Hide or show cards based on selections
        this.toggleCardsVisibility();

        // Hide or show the book when clicking 
        if (Input.GetKeyDown(KeyCode.P))
        {
            this.toggleBookVisibility();
        }
    }

    // Call this when a creature is found.
    public void FoundCreature(CreatureType creatureType) {
        switch (creatureType) {
            case CreatureType.CAT:
                catCount++;
                catCountText.text = catCount.ToString();
                showCard1 = true;
                break;
            case CreatureType.DUCK:
                duckCount++;
                duckCountText.text = duckCount.ToString();
                showCard2 = true;
                break;
            case CreatureType.PENGUIN:
                penguinCount++;
                penguinCountText.text = penguinCount.ToString();
                showCard3 = true;
                break;
            case CreatureType.FLOWER:
                flowerCount++;
                flowerCountText.text = flowerCount.ToString();
                showCard4 = true;
                break;
            case CreatureType.MOLE:
                moleCount++;
                moleCountText.text = moleCount.ToString();
                showCard5 = true;
                break;
            case CreatureType.SHEEP:
                sheepCount++;
                sheepCountText.text = sheepCount.ToString();
                showCard6 = true;
                break;
        }
        toggleCardsVisibility();
    }

    // Hide or show the book.
    private void toggleBookVisibility()
    {
        book.SetActive(!book.activeInHierarchy);        
    }

    // Hide or show the cards.
    private void toggleCardsVisibility()
    {
        if (showCard1)
        {
            card1.SetActive(true);
        }
        else
        {
            card1.SetActive(false);
        }

        if (showCard2)
        {
            card2.SetActive(true);
        }
        else
        {
            card2.SetActive(false);
        }

        if (showCard3)
        {
            card3.SetActive(true);
        }
        else
        {
            card3.SetActive(false);
        }

        if (showCard4)
        {
            card4.SetActive(true);
        }
        else
        {
            card4.SetActive(false);
        }

        if (showCard5)
        {
            card5.SetActive(true);
        }
        else
        {
            card5.SetActive(false);
        }

        if (showCard6)
        {
            card6.SetActive(true);
        }
        else
        {
            card6.SetActive(false);
        }
    }
}
