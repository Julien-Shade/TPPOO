using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TP3
{
    public class TP3 : MonoBehaviour
    {
        public List<Arme> equipement = new();





        // Start is called before the first frame update
        void Start()
        {
            Arme sword = new Epee();
            Arme arc = new Arc();


            

            equipement.Add(sword);
            equipement.Add(arc);



            //((Arme) sword).Attaquer();

            foreach (Arme arme in equipement)
            {
                arme.Attaquer();
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

