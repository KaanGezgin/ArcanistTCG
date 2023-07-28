using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectDefense : MonoBehaviour
{
    [Header("Direct defense card attributes")]
    public string cardName = "Direct Defense";
    public int armor;
    public int actionCost;
    [Header("Buff attributes")]
    public string aspectBufftype;
    public int defenseAspect; // Buffing defense
    public string buffAspect; // Name of effect
    public bool buffAspectCounter; // Gaining buff counter like strength counter
    [Header("Debuff attributes")]
    public string aspectDebufftype;
    public string debuffAspect; // Name of effect
    public bool debuffAspectCounter; // Gaining buff counter like strength counter
    public void Awake()
    {
        armor = 5;
        actionCost = 1;

        aspectBufftype = "";
        defenseAspect = 0;
        buffAspect = "";
        buffAspectCounter = false;

        aspectDebufftype = "";
        debuffAspect = "";
        debuffAspectCounter = false;
    }
}
