using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using UnityEngine;

public class Compression : MonoBehaviour
{
    #region Compression
    // Compresse les données
    private byte[] CompressData(byte[] data)
    {
        using (MemoryStream output = new MemoryStream())
        {
            using (GZipStream gzip = new GZipStream(output, CompressionMode.Compress))
            {
                gzip.Write(data, 0, data.Length);
            }
            return output.ToArray();
        }
    }

    // Décompresse les données
    private byte[] DecompressData(byte[] data)
    {
        using (MemoryStream input = new MemoryStream(data))
        {
            using (GZipStream gzip = new GZipStream(input, CompressionMode.Decompress))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    gzip.CopyTo(output);
                    return output.ToArray();
                }
            }
        }
    }
    #endregion
}
