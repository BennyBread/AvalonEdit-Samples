using System;
using System.IO;
using System.Reflection;

namespace ListeAdd;

public static class ResourceReader
{
    public static string GetFile(string fileName, Assembly executingAssembly)
    {
        using var stream = executingAssembly.GetManifestResourceStream(fileName);

        if (stream != null)
        {
            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        throw new Exception(
            $"Resource {fileName} not found in {executingAssembly.FullName}.  Valid resources are: {string.Join(", ", executingAssembly.GetManifestResourceNames())}.");
    }

    public static byte[] GetBytes(string fileName, Assembly executingAssembly)
    {
        using var stream = executingAssembly.GetManifestResourceStream(fileName);

        if (stream != null) 
            return ToByteArray(stream);

        var resourceNames = executingAssembly.GetManifestResourceNames();
        throw new Exception(
            $"Resource {fileName} not found in {executingAssembly.FullName}.  Valid resources are: {string.Join(", ", resourceNames)}.");

    }

    private static byte[] ToByteArray(Stream stream)
    {
        using var ms = new MemoryStream();
        var buffer = new byte[1024];

        int read;

        while((read = stream.Read(buffer, 0, buffer.Length)) > 0)
        {
            ms.Write(buffer, 0, read);
        }

        return ms.ToArray();
    }
}