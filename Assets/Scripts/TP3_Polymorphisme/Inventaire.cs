using System.Collections;
using System.Collections.Generic;
using TP3;
using TP3_Polymorphisme;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Inventaire : MonoBehaviour
{
    public List<Weapon> equipement = new();

    public string weapon;

    Weapon sword = new Sword();
    Weapon bow = new Bow();
    Weapon wand = new Wand();

    public Weapon currentWeapon;

    // Start is called before the first frame update
    void Start()
    {
       

        equipement.Add(sword);
        equipement.Add(bow);
        equipement.Add(wand);


/*        foreach (Weapon weapon in equipement)
        {
            Debug.Log(weapon);
            weapon.Attaquer();
        }*/



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwitchWeapon(sword);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SwitchWeapon(bow);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SwitchWeapon(wand);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            if (currentWeapon != null)
            {
                currentWeapon.Attaquer(); // polymorphysme
                currentWeapon.Cast(currentWeapon.Mana); // polymorphisme
            }
            else
            {
                Debug.Log("PAS D'ARME");
            }


        }

    }

    public void SwitchWeapon(Weapon weaponName)
    {
        currentWeapon = weaponName;

        //Debug.Log("Switched to " + currentWeapon + " -> " + currentWeapon.Name);
        weapon = currentWeapon.ToString();
    }
}
