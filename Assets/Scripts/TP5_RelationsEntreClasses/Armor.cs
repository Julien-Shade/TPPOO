using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;

namespace TP5
{
    public class Armor : Iteme, IEquip, IUsable
    {
        // Propri�t�s sp�cifiques aux armures
        private int defense;
        private string armorType; // "Helmet", "Chest", "Boots", etc.

        public void EquipItem()
        {
            Debug.Log("�quiper");
        }
        public void UseItem()
        {
            throw new System.NotImplementedException();
        }
    }

}
