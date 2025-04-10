using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerVehicle : MonoBehaviour
{
   public Vehicle car;




    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("voiture").GetComponent<Vehicle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
