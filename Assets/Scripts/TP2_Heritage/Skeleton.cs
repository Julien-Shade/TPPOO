using System;
using UnityEngine;

namespace TP2_Heritage
{
    public class Skeleton : Ennemy
    {
        public Skeleton()
        {
            Health = 20;
            Damage = 6;
            Speed = 7.5f;
            DetectionRange = 25;
        }

        [SerializeField] private GameObject FLECHE;






        protected override void Update()
        {
            if (Vector3.Distance(transform.position, Player.position) < DetectionRange && Vector3.Distance(transform.position, Player.position) > 15)
            {
                Vector3 direction = (Player.position - transform.position).normalized;
                transform.position += direction * Speed * Time.deltaTime;
            }
            if (Vector3.Distance(transform.position, Player.position) < 15)
            {
                Debug.Log("FLECHE !!!!!");
                GameObject fleche = Instantiate(FLECHE);
                fleche.GetComponent<Rigidbody>().AddForce(transform.forward * 100);
            }
        }

    }
}