using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Player : MonoBehaviour {

    // variables du player
    [SerializeField]
    private string playerName;
    [SerializeField]
    private int health;
    [SerializeField]
    private int maxHealth;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private int gold;
    [SerializeField]
    private bool isInvincible;

    [SerializeField]
    private Transform transformPlayer;


    



    // accesseurs
    public string PlayerName { get => playerName; set => playerName = value; }
    //public int Health { get => health; set => health = value; }
    public int Health
    {
        get
        {
            Debug.Log("get health");
            health = Mathf.Clamp(this.health, 0, maxHealth);
            return this.health;
        }
        set
        {
            Debug.Log("value " + value);
            Debug.Log("set  health " + health);
            health = Mathf.Clamp(value, 0, maxHealth);
            Debug.Log("set health après clamp " + health);
        }
    }

    public int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public float MoveSpeed
    {
        get
        {
            return moveSpeed;
        } 
        set
        {
            moveSpeed = Mathf.Clamp(value, -10, 10); // je clamp la vitesse entre -10 et 10
            moveSpeed = value;
        } 
    
    }
    public int Gold { get => gold; set => gold = value; }
    public bool IsInvincible { get => isInvincible; set => isInvincible = value; }
    public Transform TransformPlayer { get => transformPlayer; set => transformPlayer = value; }

    public void GainGold(int amount)
    {
        gold += amount;
    }


    public void TakeDamage(int amount)
    {
        if (isInvincible) return;


        Health -= amount;
    }

    public void Heal(int amount)
    {
        Health += amount;
    }

    public void Deplacement(Vector3 pos)
    {
        TransformPlayer.Translate(pos * moveSpeed * Time.deltaTime);
    }



    public void Mouvement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }

}

