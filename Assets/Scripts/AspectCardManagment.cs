using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AspectCardManagment : MonoBehaviour
{
    private void Start()
    {
        string name = "Flame aspect";
        AspectCardsDatabase foundCard = new AspectCardsDatabase();

        AspectAttributes foundedcard = foundCard.GetCardByName(name);

        Debug.Log(foundedcard.name);
        Debug.Log(foundedcard.aspectEffect);

    }


}
