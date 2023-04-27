# GZipCompression

GZipCompression is a C# library that provides a simple way to compress and decompress byte arrays using the GZip algorithm.

## Installation

Copy the `Compression.cs` file into your C# project and add a reference to the `System.IO.Compression` namespace.

## Usage

To use the GZipCompression library, you'll need to add the following `using` statement:

```csharp
using GZipCompression;
```

### Compress

To compress a byte array, use the `Compress` method:

```csharp
byte[] data = Encoding.UTF8.GetBytes("This is a sample string for testing GZipCompression.");
byte[] compressedData = Compression.Compress(data);
```

### Decompress

To decompress a byte array, use the `Decompress` method:

```csharp
byte[] decompressedData = Compression.Decompress(compressedData);
string decompressedString = Encoding.UTF8.GetString(decompressedData);
```

## Error Handling

The `Compress` and `Decompress` methods use try-catch blocks to handle any exceptions that might occur during the compression and decompression processes. If an exception occurs, an error message will be printed to the console, and the methods will return `null`.

## Unit Testing

Unit tests for the GZipCompression library can be found in the `GZipCompressionTests` namespace using the MSTest framework. The tests cover various scenarios, such as compressing and decompressing valid data, compressing null data, and decompressing invalid data.
