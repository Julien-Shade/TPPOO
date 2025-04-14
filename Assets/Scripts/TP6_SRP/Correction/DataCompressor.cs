using System.IO;
using System.IO.Compression;

// Classe responsable uniquement de la compression et décompression des données
public class DataCompressor
{
    // Compresse les données
    public byte[] Compress(byte[] data)
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
    public byte[] Decompress(byte[] data)
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
}