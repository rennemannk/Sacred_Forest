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

    // Hide or show the book.
    private void toggleBookVisibility()
    {
        book.SetActive(!book.activeInHierarchy);
    }

    // Hide or show the cards.
    private void toggleCardsVisibility()
    {
        if (!showCard1)
        {
            card1.SetActive(false);
        }
        else
        {
            card1.SetActive(true);
        }

        if (!showCard2)
        {
            card2.SetActive(false);
        }
        else
        {
            card2.SetActive(true);
        }

        if (!showCard3)
        {
            card3.SetActive(false);
        }
        else
        {
            card3.SetActive(true);
        }

        if (!showCard4)
        {
            card4.SetActive(false);
        }
        else
        {
            card4.SetActive(true);
        }

        if (!showCard5)
        {
            card5.SetActive(false);
        }
        else
        {
            card5.SetActive(true);
        }

        if (!showCard6)
        {
            card6.SetActive(false);
        }
        else
        {
            card6.SetActive(true);
        }
    }
}
