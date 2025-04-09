using System.Collections;
using System.Collections.Generic;
using TP3;
using UnityEngine;


namespace TP3
{
    public class Epee : Arme
    {
        public Epee() { }


        public override void Attaquer()
        {
            Debug.Log("Attaqué CAC !");
        }
    }
}

