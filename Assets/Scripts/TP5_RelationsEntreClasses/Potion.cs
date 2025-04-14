using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TP5
{
    public class Potion : Iteme, IUsable
    {
        // Propriétés spécifiques aux potions
        private int healthRestored;
        private float duration;

        public void UseItem()
        {
            Debug.Log(healthRestored + " restauré");
        }
    }
}

