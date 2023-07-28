using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class DirectAttack : MonoBehaviour
{
    [Header("Direct attack card attributes")]
    public string cardName = "Direct Attack";
    public int damage;
    public int actionCost;
    [Header("Buff attributes")]
    public string aspectBufftype;
    public int damageAspect; // Changing attack type or buffing damage
    public string buffAspect; // Name of effect
    public bool buffAspectCounter; // Gaining buff counter like strength counter
    [Header("Debuff attributes")]
    public string aspectDebufftype;
    public string debuffAspect; // Name of effect
    public bool debuffAspectCounter; // Gaining buff counter like strength counter

    public void Awake()
    {
        damage = 5;
        actionCost = 1;

        aspectBufftype = "";
        damageAspect = 0;
        buffAspect = "";
        buffAspectCounter = false;

        aspectDebufftype = "";
        debuffAspect = "";
        debuffAspectCounter = false;

    }

}
