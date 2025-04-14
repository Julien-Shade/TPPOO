using System;
using System.IO;
using UnityEngine;

// Classe responsable uniquement de la gestion des fichiers sur le disque
public class FileStorage
{
    private readonly string saveFolderPath;
    
    public FileStorage(string saveFolderName)
    {
        saveFolderPath = Path.Combine(Application.persistentDataPath, saveFolderName);
        EnsureSaveFolderExists();
    }
    
    // Assure que le dossier de sauvegarde existe
    private void EnsureSaveFolderExists()
    {
        if (!Directory.Exists(saveFolderPath))
        {
            Directory.CreateDirectory(saveFolderPath);
        }
    }
    
    // Sauvegarde des données dans un fichier
    public void SaveFile(byte[] data, string fileName)
    {
        string filePath = GetFullPath(fileName);
        File.WriteAllBytes(filePath, data);
    }
    
    // Charge des données depuis un fichier
    public byte[] LoadFile(string fileName)
    {
        string filePath = GetFullPath(fileName);
        
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Fichier de sauvegarde {fileName} introuvable", filePath);
        }
        
        return File.ReadAllBytes(filePath);
    }
    
    // Supprime un fichier
    public void DeleteFile(string fileName)
    {
        string filePath = GetFullPath(fileName);
        
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Fichier de sauvegarde {fileName} introuvable", filePath);
        }
        
        File.Delete(filePath);
    }
    
    // Liste tous les fichiers disponibles
    public string[] ListFiles()
    {
        if (!Directory.Exists(saveFolderPath))
        {
            return new string[0];
        }
        
        string[] filePaths = Directory.GetFiles(saveFolderPath, "*.sav");
        
        // Convertir les chemins complets en noms de fichiers sans extension
        for (int i = 0; i < filePaths.Length; i++)
        {
            filePaths[i] = Path.GetFileNameWithoutExtension(filePaths[i]);
        }
        
        return filePaths;
    }
    
    // Obtient le chemin complet d'un fichier
    private string GetFullPath(string fileName)
    {
        return Path.Combine(saveFolderPath, fileName + ".sav");
    }
}