
namespace TP5
{
    public abstract class Item
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

/*        public virtual void UseItem(Player player)
        {
            if (itemType == "Weapon")
            {
                // Logique d'utilisation d'une arme
                //player.Attack(damage);
            }
            else if (itemType == "Potion")
            {
                // Logique d'utilisation d'une potion
                //player.RestoreHealth(healthRestored);
            }
            else if (itemType == "Armor")
            {
                // Logique d'équipement d'une armure
                //player.EquipArmor(this);
            }
        }*/
    }
}