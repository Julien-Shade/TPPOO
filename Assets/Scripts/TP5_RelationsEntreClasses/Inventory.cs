namespace TP5
{
    public class Inventory
    {
        private Item[] items = new Item[20]; // Taille fixe d'inventaire
        private int itemCount = 0;

        public Item[] Items { get => items; set => items = value; }
        public int ItemCount { get => itemCount; set => itemCount = value; }

        public void AddItem(Item item)
        {
            if (ItemCount < Items.Length)
            {
                Items[ItemCount] = item;
                ItemCount++;
            }
        }

        public void RemoveItem(int index)
        {
            if (index >= 0 && index < ItemCount)
            {
                // Décaler tous les éléments
                for (int i = index; i < ItemCount - 1; i++)
                {
                    Items[i] = Items[i + 1];
                }
                Items[ItemCount - 1] = null;
                ItemCount--;
            }
        }

        public float GetTotalWeight()
        {
            float totalWeight = 0;
            for (int i = 0; i < ItemCount; i++)
            {
                totalWeight += Items[i].Weight;
            }
            return totalWeight;
        }
    }
}