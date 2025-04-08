using System.Collections;
using System.Collections.Generic;
using TP2_Heritage;
using Unity.VisualScripting;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private int damage;
    [SerializeField] private float speed;
    [SerializeField] private float detectionRange;
    [SerializeField] private Transform player;

    protected int Health { get => health; set => health = value; }
    protected int Damage { get => damage; set => damage = value; }
    protected float Speed { get => speed; set => speed = value; }
    protected float DetectionRange { get => detectionRange; set => detectionRange = value; }
    public Transform Player { get => player; set => player = value; }

    private void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Transform>();


        Debug.Log(GameObject.FindAnyObjectByType<Ennemy>().name + " HP : " + Health);
        Debug.Log(GameObject.FindAnyObjectByType<Ennemy>().name + " Damage : " + Damage);
        Debug.Log(GameObject.FindAnyObjectByType<Ennemy>().name + " Speed : " + Speed);
        Debug.Log(GameObject.FindAnyObjectByType<Ennemy>().name + " DetectionRange : " + DetectionRange);
    }



    protected virtual void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) < DetectionRange)
        {
            Vector3 direction = (Player.position - transform.position).normalized;
            transform.position += direction * Speed * Time.deltaTime;
        }
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerCharacter player = collision.gameObject.GetComponent<PlayerCharacter>();

            Debug.Log(player);

            if (player != null)
            {
                player.TakeDamage(Damage);
                Debug.Log("Degat");
            }
        }
    }
}
