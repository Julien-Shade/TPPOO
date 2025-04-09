using System.Collections;
using System.Collections.Generic;
using TP3;
using TP3_Polymorphisme;
using UnityEngine;
public class Bow : Weapon
{
    public Bow()
    {
        Name = "La mort venu du ciel";
        Damage = 2;
        Range = 2f;
        Mana = 3f;
    }

    public override void Attaquer()
    {
        //Debug.Log(Name + " a fait " + Damage + " dégats !");
    }


}
