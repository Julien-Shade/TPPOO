using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TP5
{
    public class Potion : Iteme, IUsable
    {
        // Propri�t�s sp�cifiques aux potions
        private int healthRestored;
        private float duration;

        public void UseItem()
        {
            Debug.Log(healthRestored + " restaur�");
        }
    }
}

