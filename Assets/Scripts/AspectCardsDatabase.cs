using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectCardsDatabase : MonoBehaviour
{
    /*
    public class AspectAttributes
    {
        public string aspectCardName;
        public string aspectEffect;
    }
    */
    public List<AspectAttributes> aspectCardLists = new List<AspectAttributes>();

    private void Awake()
    {
        AddingACard("Flame aspect", "add 5 fire damage");
    }

    private void AddingACard(string cardName, string cardEffect) 
    {
        AspectAttributes newAspectCard = new AspectAttributes
        {
            aspectCardName = cardName,
            aspectEffect = cardEffect
        };
        aspectCardLists.Add(newAspectCard);
    }

    public AspectAttributes GetCardByName(string searchedCardName)
    {
        return aspectCardLists.Find(card => card.aspectCardName == searchedCardName);
    }
}
