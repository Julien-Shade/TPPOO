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


        // Propriétés spécifiques aux armes
        private readonly int damage = 10;
        private readonly float range = 2;

        public void EquipItem()
        {
            Debug.Log("équiper");
           // return;
        }

        public void UseItem()
        {
            // Logique d'attaque avec l'arme équipée
            System.Console.WriteLine($"{Name} attaque pour {damage} points de dégâts!");
        }
    }
}

