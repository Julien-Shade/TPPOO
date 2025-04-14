using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;

namespace TP5
{
    public class Armor : Iteme, IEquip, IUsable
    {
        // Propriétés spécifiques aux armures
        private int defense;
        private string armorType; // "Helmet", "Chest", "Boots", etc.

        public void EquipItem()
        {
            Debug.Log("équiper");
        }
        public void UseItem()
        {
            throw new System.NotImplementedException();
        }
    }

}
