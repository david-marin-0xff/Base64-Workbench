using System;
using System.Drawing;
using System.IO;

namespace Base64Workbench.Helpers;

public static class Base64Helper
{
    public static string EncodeImage(string path)
    {
        byte[] bytes = File.ReadAllBytes(path);

        return Convert.ToBase64String(bytes);
    }


    public static Image DecodeImage(string base64)
    {
        byte[] bytes = Convert.FromBase64String(base64);

        using MemoryStream stream = new(bytes);

        return Image.FromStream(stream);
    }
}