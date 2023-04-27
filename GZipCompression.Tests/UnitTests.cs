using System.Text;

namespace GZipCompression.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestCompressAndDecompress_ValidData()
        {
            // Arrange
            var testString = "This is a sample string for testing GZip Compression";
            var testData = Encoding.UTF8.GetBytes(testString);

            // Act
            var compressedData = Compression.Compress(testData);
            var decompressedData = Compression.Decompress(compressedData);
            var decompressedString = Encoding.UTF8.GetString(decompressedData);

            // Assert
            Assert.IsNotNull(compressedData);
            Assert.IsNotNull(decompressedData);
            Assert.AreEqual(testString, decompressedString);
        }

        [TestMethod]
        public void TestCompress_NullData()
        {
            // Arrange
            byte[] testData = null;

            // Act
            var compressedData = Compression.Compress(testData);

            // Assert
            Assert.IsNull(compressedData);
        }

        [TestMethod]
        public void TestDecompress_InvalidData()
        {
            // Arrange
            var testData = new byte[] { 1, 2, 3, 4, 5 };

            // Act
            var decompressedData = Compression.Decompress(testData);

            // Assert
            Assert.IsNull(decompressedData);
        }
    }
}