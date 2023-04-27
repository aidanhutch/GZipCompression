using System.IO.Compression;

namespace GZipCompression
{
    public static class Compression
    {
        public static byte[] Compress(byte[] data)
        {
            try
            {
                var ms = new MemoryStream();
                using (var gzipStream = new GZipStream(ms, CompressionMode.Compress, false))
                {
                    gzipStream.Write(data, 0, data.Length);
                }

                return ms.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during compression: {ex.Message}");
                return null!;
            }
        }

        public static byte[] Decompress(byte[] data)
        {
            try
            {
                using var decompressedData = new MemoryStream();

                var compressedStream = new MemoryStream(data);
                using (var gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress, false))
                {
                    gzipStream.CopyTo(decompressedData);
                }

                return decompressedData.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during decompression: {ex.Message}");
                return null!;
            }
        }
    }
}