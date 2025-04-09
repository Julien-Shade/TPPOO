using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public abstract class Weapon
    {
        private string name;
        private int damage;
        private float range;
        private float mana;
        public string Name { get => name; set => name = value; }
        protected int Damage { get => damage; set => damage = value; }
        protected float Range { get => range; set => range = value; }
        public float Mana { get => mana; set => mana = value; }

        public virtual void Attaquer()
        {
            //Dark souls pu >>>>
            Debug.Log("Attaqué ek KOI KONYAR ????!!");
        }



        public virtual void Cast(float amount)
        {
        //Debug.Log(Name + " consome : " + Mana + " mana");
        PlayerCharacter playerCharacter = GameObject.Find("Player").GetComponent<PlayerCharacter>();

            playerCharacter.SpendMana(amount);
    }



    
/*        protected abstract void Cast()
        {
            // Création d'une flèche
            GameObject objectPrefab = Resources.Load<GameObject>("Arrow");
            if (objectPrefab != null)
            {
                GameObject arrow = Instantiate(objectPrefab, transform.position + transform.forward, Quaternion.identity);
                Rigidbody rb = arrow.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.velocity = transform.forward * 20f;
                }
            }
        }*/





    }


