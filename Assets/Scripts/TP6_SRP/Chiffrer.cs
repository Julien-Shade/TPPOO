using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

/*public class Chiffrer : MonoBehaviour
{
    #region Encryption
    // Chiffre les données
    private byte[] EncryptData(byte[] data)
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
    private byte[] DecryptData(byte[] data)
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
    #endregion
}
*/