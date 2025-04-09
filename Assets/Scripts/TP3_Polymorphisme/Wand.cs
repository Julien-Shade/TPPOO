using System.Collections;
using System.Collections.Generic;
using TP3;
using TP3_Polymorphisme;
using UnityEngine;

public class Wand : Weapon
{
    public Wand()
    {
        Name = "Peak";
        Damage = 2;
        Range = 2f;
        Mana = 30f;
    }

    public override void Attaquer()
    {
        //Debug.Log(Name + " a fait " + Damage + " dégats !");
    }




}
