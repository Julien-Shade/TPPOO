using System;
using UnityEngine;

// Classe dédiée aux données du joueur
[Serializable]
public class PlayerData
{
    private string playerName;
    private int level;
    private float health;
    private Vector3 position;
    private Quaternion rotation;
    private int[] inventory;
    private int currency;

    public string PlayerName { get => playerName; set => playerName = value; }
    public int Level { get => level; set => level = value; }
    public float Health { get => health; set => health = value; }
    public Vector3 Position { get => position; set => position = value; }
    public Quaternion Rotation { get => rotation; set => rotation = value; }
    public int[] Inventory { get => inventory; set => inventory = value; }
    public int Currency { get => currency; set => currency = value; }
}