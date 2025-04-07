using UnityEngine;

namespace TP1_Encapsulation
{
    public class PlayerCharacterBroken : MonoBehaviour
    {
        // Toutes les données sont publiques et peuvent être modifiées n'importe où
        /*        public string playerName;
                public int health;
                public int maxHealth;
                public float moveSpeed;
                public int gold;
                public bool isInvincible;
                */
        [SerializeField]
        Transform pos;
        [SerializeField]
        Player player;






        private void Start()
        {
            pos = transform;

            player = gameObject.AddComponent<Player>();
            player.MaxHealth = 100;
            player.Health = 100;
            //player.TakeDamage(105);
            Debug.Log("health = " + player.Health);
            player.TransformPlayer = pos;
            player.Deplacement(pos.transform.forward);
        }
        void Update()
        {


            if (Input.GetKeyDown(KeyCode.W))
            {
                player.Deplacement(pos.transform.forward);
            }
            
            /*if (health <= 0)
            {
                Debug.Log("Player is dead");
            }*/

            // La vitesse peut être modifiée à n'importe quelle valeur
            // Le personnage peut avoir une vitesse négative car rien ne l'empêche
            
            
            //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        
        /*public void GainGold(int amount)
        {
            gold += amount;
        }

       
        public void TakeDamage(int amount)
        {
            health -= amount;
        }*/
    }
}