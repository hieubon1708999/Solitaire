using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;

public class CardsHandler : MonoBehaviour
{
    private Dictionary<GameObject, int> cards = new Dictionary<GameObject, int>();

    private GameObject card;

    private List<int> checkContains;

    private string splitedString;
    private string replacedString;

    private int countElement;

    void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            card = transform.GetChild(i).gameObject;
            splitedString = card.name.Substring(0, card.name.Length - 3);
            replacedString = Regex.Replace(splitedString, "[^0-9]", "");
            cards.Add(card, int.Parse(replacedString));
        }
    }

    void Update()
    {
        RandomCard();
    }

    void RandomCard()
    {
        Random random = new Random();
        int randomIndex = random.Next(dictionary.Count);
        Debug.Log(cards.ElementAt(randomIndex));
    }
}
