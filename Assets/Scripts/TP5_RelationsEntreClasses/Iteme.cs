using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TP5
{
    public abstract class Iteme
    {
        private string name;
        private string description;
        private float weight;
        private int value;
        private string itemType; // "Weapon", "Potion", "Armor", etc.

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public float Weight { get => weight; set => weight = value; }
        public int Value { get => value; set => this.value = value; }
        public string ItemType { get => itemType; set => itemType = value; }









    }

}
