using UnityEngine;

namespace TP2_Heritage
{
    public class Zombie : Ennemy
    {
        public Zombie()
        {
            Health = 20;
            Damage = 4;
            Speed = 10;
            DetectionRange = 15;
        }

        public Zombie(int health, int damage, float speed, float detectionRange)
        {

        }
    }
}