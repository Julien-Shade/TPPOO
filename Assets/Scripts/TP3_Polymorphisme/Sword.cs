using System.Collections;
using System.Collections.Generic;
using TP3;
using TP3_Polymorphisme;
using UnityEngine;

public class Sword : Weapon
{
    public Sword()
    {
        Name = "Him";
        Damage = 25;
        Range = 2f;
        Mana = 0f; // en utilise pas logique
    }

    public override void Attaquer()
    {
        //Debug.Log(Name + " a fait " + Damage + " dégats !");
    }



}
