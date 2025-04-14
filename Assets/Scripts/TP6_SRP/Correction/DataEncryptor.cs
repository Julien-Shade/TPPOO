using System.IO;
using System.Text;
using System.Security.Cryptography;

// Classe responsable uniquement du chiffrement et déchiffrement des données
public class DataEncryptor
{
    private readonly string encryptionKey;
    
    public DataEncryptor(string encryptionKey)
    {
        this.encryptionKey = encryptionKey;
    }
    
    // Chiffre les données
    public byte[] Encrypt(byte[] data)
    {
        using (Aes aes = Aes.Create())
        {
            byte[] key = Encoding.UTF8.GetBytes(encryptionKey.PadRight(16, '*').Substring(0, 16));
            aes.Key = key;
            aes.IV = new byte[16]; // IV simplifié pour l'exemple
            
            using (ICryptoTransform encryptor = aes.CreateEncryptor())
            {
                return PerformCrypto(data, encryptor);
            }
        }
    }
    
    // Déchiffre les données
    public byte[] Decrypt(byte[] data)
    {
        using (Aes aes = Aes.Create())
        {
            byte[] key = Encoding.UTF8.GetBytes(encryptionKey.PadRight(16, '*').Substring(0, 16));
            aes.Key = key;
            aes.IV = new byte[16]; // IV simplifié pour l'exemple
            
            using (ICryptoTransform decryptor = aes.CreateDecryptor())
            {
                return PerformCrypto(data, decryptor);
            }
        }
    }
    
    // Effectue la transformation cryptographique
    private byte[] PerformCrypto(byte[] data, ICryptoTransform transform)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            using (CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
            {
                cs.Write(data, 0, data.Length);
                cs.FlushFinalBlock();
                return ms.ToArray();
            }
        }
    }
}