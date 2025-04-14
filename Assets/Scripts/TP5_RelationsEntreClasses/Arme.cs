using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TP5
{
    public class Arme : Iteme, IEquip, IUsable
    {
/*        Arme()
        {
            Name = "N###er Slayer";
            Description = "explicit enough";
            Weight = 1;
            Value = 10;
            ItemType = "Arme";
        }*/


        // Propri�t�s sp�cifiques aux armes
        private readonly int damage = 10;
        private readonly float range = 2;

        public void EquipItem()
        {
            Debug.Log("�quiper");
           // return;
        }

        public void UseItem()
        {
            // Logique d'attaque avec l'arme �quip�e
            System.Console.WriteLine($"{Name} attaque pour {damage} points de d�g�ts!");
        }
    }
}

