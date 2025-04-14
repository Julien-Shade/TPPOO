using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Serialiser
{
    public virtual void Serialisation(DataPlayer dataPlayer, string fileName)
    {
        // Sérialisation des données en JSON
        string jsonData = JsonUtility.ToJson(dataPlayer, true);
        byte[] rawData = Encoding.UTF8.GetBytes(jsonData);

    }

    public virtual void Desarialisation()
    {
        // Désérialisation des données
        //string jsonData = Encoding.UTF8.GetString(rawData);
       // DataPlayer dataPlayer = JsonUtility.FromJson<DataPlayer>(jsonData);
    }

    
}
