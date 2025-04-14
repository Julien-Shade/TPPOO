using System;
using UnityEngine;

// Classe de coordination qui ne contient plus les détails d'implémentation
public class SaveManager : MonoBehaviour
{
    [SerializeField] private string saveFolderName = "SaveData";
    [SerializeField] private string encryptionKey = "GameSaveEncryptKey";
    [SerializeField] private bool useCompression = true;
    [SerializeField] private bool useEncryption = true;
    
    // Référence aux composants d'UI
    [SerializeField] private UIMessageDisplay messageDisplay;
    
    // Services dédiés à chaque responsabilité
    private DataSerializer serializer;
    private DataCompressor compressor;
    private DataEncryptor encryptor;
    private FileStorage fileStorage;
    
    private void Awake()
    {
        // Initialisation des composants
        serializer = new DataSerializer();
        compressor = new DataCompressor();
        encryptor = new DataEncryptor(encryptionKey);
        fileStorage = new FileStorage(saveFolderName);
        
        // Valider que l'affichage des messages est disponible
        if (messageDisplay == null)
        {
            messageDisplay = GetComponent<UIMessageDisplay>();
        }

        //Data test pour sauvegarde
        PlayerData testData = new PlayerData();
        testData.PlayerName = "Seb";
        testData.Currency = 10;

        //Sauvegarder sur le fichier seb.sav
        SaveGame(testData, "seb");
    }
    
    // Sauvegarde les données du joueur
    public void SaveGame(PlayerData playerData, string fileName)
    {
        try
        {
            // Sérialisation des données
            byte[] data = serializer.Serialize(playerData);
            
            // Compression des données si activée
            if (useCompression)
            {
                data = compressor.Compress(data);
            }
            
            // Chiffrement des données si activé
            if (useEncryption)
            {
                data = encryptor.Encrypt(data);
            }
            
            // Sauvegarde dans un fichier
            fileStorage.SaveFile(data, fileName);
            
            // Affiche un message de réussite
            ShowMessage($"Sauvegarde réussie dans {fileName}.sav");
            Debug.Log($"Données sauvegardées dans {fileName}.sav");
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
            // Lecture du fichier
            byte[] data = fileStorage.LoadFile(fileName);
            
            // Déchiffrement des données si nécessaire
            if (useEncryption)
            {
                data = encryptor.Decrypt(data);
            }
            
            // Décompression des données si nécessaire
            if (useCompression)
            {
                data = compressor.Decompress(data);
            }
            
            // Désérialisation des données
            PlayerData playerData = serializer.Deserialize<PlayerData>(data);
            
            // Affiche un message de réussite
            ShowMessage($"Chargement réussi de {fileName}.sav");
            Debug.Log($"Données chargées depuis {fileName}.sav");
            
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
    
    // Supprime un fichier de sauvegarde
    public bool DeleteSaveFile(string fileName)
    {
        try
        {
            fileStorage.DeleteFile(fileName);
            ShowMessage($"Sauvegarde {fileName}.sav supprimée");
            return true;
        }
        catch (Exception e)
        {
            ShowMessage($"Erreur lors de la suppression : {e.Message}");
            Debug.LogError($"Erreur lors de la suppression : {e.Message}");
            return false;
        }
    }
    
    // Liste toutes les sauvegardes disponibles
    public string[] ListSaveFiles()
    {
        try
        {
            return fileStorage.ListFiles();
        }
        catch (Exception e)
        {
            Debug.LogError($"Erreur lors de la liste des sauvegardes : {e.Message}");
            return new string[0];
        }
    }
    
    // Méthode d'aide pour afficher des messages
    private void ShowMessage(string message)
    {
        if (messageDisplay != null)
        {
            messageDisplay.ShowMessage(message);
        }
    }
}