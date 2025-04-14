using UnityEngine;

namespace TP5
{
    public class Player : MonoBehaviour
    {
        private string name;
        private int health;
        private int maxHealth;

        private string currentArme;

        private Item iteme;

        // L'inventaire est directement intégré dans la classe Player
        private Inventory inventory = new Inventory();

        // Des références directes aux objets équipés
        private Item equippedWeapon;
        private Item equippedHelmet;
        private Item equippedChest;
        private Item equippedBoots;

        public string Name { get => Name1; set => Name1 = value; }
        public int Health{get => Health1; set{Health1 = System.Math.Min(Health + value, MaxHealth);}}
        public int MaxHealth { get => MaxHealth1; set => MaxHealth1 = value; }
        public string CurrentArme { get => CurrentArme1; set => CurrentArme1 = value; }
        public string Name1 { get => name; set => name = value; }
        public int Health1 { get => health; set => health = value; }
        public int MaxHealth1 { get => maxHealth; set => maxHealth = value; }
        public string CurrentArme1 { get => currentArme; set => currentArme = value; }
        public Item Iteme { get => iteme; set => iteme = value; }
        public Inventory Inventory { get => inventory; set => inventory = value; }
        public Item EquippedWeapon { get => equippedWeapon; set => equippedWeapon = value; }
        public Item EquippedHelmet { get => equippedHelmet; set => equippedHelmet = value; }
        public Item EquippedChest { get => equippedChest; set => equippedChest = value; }
        public Item EquippedBoots { get => equippedBoots; set => equippedBoots = value; }
    }
}