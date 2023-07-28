using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardAttributes : ScriptableObject
{
    public int cardID;
    public string cardName;
    public string cardType;// Card Types maybe become a tag in future
    public string cardAppliedEffect;
    public string cardCost;
    //public string rangeRequest;

    public CardAttributes()
    {

    }
    public CardAttributes(int CardID, string CardName, string CardType, string CardAppliedEffect)
    {
        cardID = CardID;
        cardName = CardName;
        cardType = CardType;
        cardAppliedEffect = CardAppliedEffect;
    }
}
