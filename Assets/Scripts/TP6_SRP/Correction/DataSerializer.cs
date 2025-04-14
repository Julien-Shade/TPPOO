using System;
using System.Text;
using UnityEngine;

// Classe responsable uniquement de la sérialisation et désérialisation des données
public class DataSerializer
{
    // Sérialise un objet en données binaires
    public byte[] Serialize<T>(T data)
    {
        string jsonData = JsonUtility.ToJson(data, true);
        return Encoding.UTF8.GetBytes(jsonData);
    }
    
    // Désérialise des données binaires en objet
    public T Deserialize<T>(byte[] data)
    {
        string jsonData = Encoding.UTF8.GetString(data);
        return JsonUtility.FromJson<T>(jsonData);
    }
}