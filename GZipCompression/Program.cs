// See https://aka.ms/new-console-template for more information

using GZipCompression;

Console.WriteLine("GZip Compression example...");

var inputFile = "testimage.bmp";

//read file in to byte array
var fileBytes = File.ReadAllBytes(inputFile);

Console.WriteLine("Input file is {0} bytes", fileBytes.Length);

//compress data
var compressedData = Compression.Compress(fileBytes);

Console.WriteLine("GZip Compressed byte array is {0} bytes", compressedData.Length);

//save compressed data as file
File.WriteAllBytes(inputFile + ".gz", compressedData);

Console.WriteLine(inputFile + ".gz written to debug folder.");

Console.WriteLine(Environment.NewLine);

Console.WriteLine("GZip Decompression example...");

//read compressed data file into byte array
var data = File.ReadAllBytes(inputFile + ".gz");

var decompressedData = Compression.Decompress(data);

Console.WriteLine("Decompressed data is {0} bytes", decompressedData.Length);

//save decompressed file to debug folder
File.WriteAllBytes("decompressed.bmp", decompressedData);

Console.WriteLine("Decompressed file decompressed.bmp has been written to Debug folder");