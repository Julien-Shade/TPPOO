using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

/*public class SauvegardeManager : MonoBehaviour
{
    [SerializeField] private string saveFolderName = "SaveData";
    [SerializeField] private string encryptionKey = "GameSaveEncryptKey";
    [SerializeField] private bool useCompression = true;
    [SerializeField] private bool useEncryption = true;

    //[SerializeField] pri

    public string SaveFolderName { get => saveFolderName; set => saveFolderName = value; }
    public string EncryptionKey { get => encryptionKey; set => encryptionKey = value; }
    public bool UseCompression { get => useCompression; set => useCompression = value; }
    public bool UseEncryption { get => useEncryption; set => useEncryption = value; }

    private string SaveFolderPath => Path.Combine(Application.persistentDataPath, saveFolderName);

    private void Start()
    {
        // Créer le dossier de sauvegarde s'il n'existe pas
        if (!Directory.Exists(SaveFolderPath))
        {
            Directory.CreateDirectory(SaveFolderPath);
        }
    }

    // Sauvegarde les données du joueur
    public void SaveGame(DataPlayer playerData, string fileName)
    {
        try
        {
            // Sérialisation des données en JSON
            string jsonData = JsonUtility.ToJson(playerData, true);
            byte[] rawData = Encoding.UTF8.GetBytes(jsonData);

            // Compression des données si activée
            if (useCompression)
            {
                rawData = CompressData(rawData);
            }

            // Chiffrement des données si activé
            if (useEncryption)
            {
                rawData = EncryptData(rawData);
            }

            // Sauvegarde dans un fichier
            string filePath = Path.Combine(SaveFolderPath, fileName + ".sav");
            File.WriteAllBytes(filePath, rawData);

            // Affiche un message de réussite
            ShowMessage($"Sauvegarde réussie dans {fileName}.sav");
            Debug.Log($"Données sauvegardées dans {filePath}");
        }
        catch (Exception e)
        {
            // Gestion des erreurs
            ShowMessage($"Erreur lors de la sauvegarde : {e.Message}");
            Debug.LogError($"Erreur lors de la sauvegarde : {e.Message}");
        }
    }

    // Charge les données du joueur
    public PlayerData LoadGame(string fileName)
    {
        try
        {
            string filePath = Path.Combine(SaveFolderPath, fileName + ".sav");

            if (!File.Exists(filePath))
            {
                ShowMessage($"Fichier de sauvegarde {fileName}.sav introuvable");
                Debug.LogWarning($"Fichier de sauvegarde introuvable: {filePath}");
                return null;
            }

            // Lecture du fichier
            byte[] rawData = File.ReadAllBytes(filePath);

            // Déchiffrement des données si nécessaire
            if (useEncryption)
            {
                rawData = DecryptData(rawData);
            }

            // Décompression des données si nécessaire
            if (useCompression)
            {
                rawData = DecompressData(rawData);
            }

            // Désérialisation des données
            string jsonData = Encoding.UTF8.GetString(rawData);
            PlayerData playerData = JsonUtility.FromJson<PlayerData>(jsonData);

            // Affiche un message de réussite
            ShowMessage($"Chargement réussi de {fileName}.sav");
            Debug.Log($"Données chargées depuis {filePath}");

            return playerData;
        }
        catch (Exception e)
        {
            // Gestion des erreurs
            ShowMessage($"Erreur lors du chargement : {e.Message}");
            Debug.LogError($"Erreur lors du chargement : {e.Message}");
            return null;
        }
    }
}*/
