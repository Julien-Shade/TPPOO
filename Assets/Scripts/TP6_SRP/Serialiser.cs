using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Serialiser
{
    public virtual void Serialisation(DataPlayer dataPlayer, string fileName)
    {
        // S�rialisation des donn�es en JSON
        string jsonData = JsonUtility.ToJson(dataPlayer, true);
        byte[] rawData = Encoding.UTF8.GetBytes(jsonData);

    }

    public virtual void Desarialisation()
    {
        // D�s�rialisation des donn�es
        //string jsonData = Encoding.UTF8.GetString(rawData);
       // DataPlayer dataPlayer = JsonUtility.FromJson<DataPlayer>(jsonData);
    }

    
}
