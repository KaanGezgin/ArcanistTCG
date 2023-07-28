using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<CardAttributes> carddatabase = new List<CardAttributes>();

    private void Awake()
    {
        carddatabase.Add(new CardAttributes(0, "Direct Attack", "Attack", "Deal 5 damage"));
        carddatabase.Add(new CardAttributes(1, "Direct Defense", "Defense", "Gain 5 armor"));
        carddatabase.Add(new CardAttributes(2, "Debuff", "Debuff", "Apply weakness to enemy"));
        carddatabase.Add(new CardAttributes(3, "Buff", "Buff", "Gain strength"));



    }
}
