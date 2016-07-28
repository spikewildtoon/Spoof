// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0081;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace \u0081
{
  internal static class \u0017
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly int \u0001;
    private static readonly int \u0002;

    static \u0017()
    {
      \u0004.\u001D\u0005(typeof (\u0017));
      \u0017.\u0001 = \u0017.\u0001(95018);
      \u0017.\u0001 = 256;
      \u0017.\u0002 = 7;
    }

    internal static void \u001D\u0005(string initialVector, Stream source, Stream destination)
    {
      byte[] numArray1 = new byte[40];
      \u0017.Instance.\u001D\u0005(numArray1);
      ASCIIEncoding asciiEncoding = new ASCIIEncoding();
      byte[] numArray2 = \u0094\u0082.\u007E\u0017\u009C((object) asciiEncoding, initialVector);
      byte[] numArray3 = new byte[16];
      \u0017.Instance.\u001D\u0005(numArray3);
      byte[] data = new byte[numArray1.Length + numArray3.Length];
      \u0089\u0083.\u0084\u0092((Array) numArray1, 0, (Array) data, 0, 40);
      \u0089\u0083.\u0084\u0092((Array) numArray3, 0, (Array) data, 40, 16);
      byte[] numArray4 = \u0017.\u001D\u0005(data);
      \u0016\u0086.\u007E\u008F\u009D((object) destination, numArray4, 0, numArray4.Length);
      PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(numArray1, numArray3, \u0017.\u0001, \u0017.\u0002);
      try
      {
        byte[] numArray5 = \u0004\u0086.\u007E\u009E\u009F((object) passwordDeriveBytes, \u0017.\u0001 / 8);
        RijndaelManaged rijndaelManaged = new RijndaelManaged();
        try
        {
          \u0099\u007F.\u007E\u0095\u009F((object) rijndaelManaged, CipherMode.CBC);
          ICryptoTransform transform = \u001F\u0083.\u007E\u0097\u009F((object) rijndaelManaged, numArray5, numArray2);
          try
          {
            CryptoStream cryptoStream = new CryptoStream(destination, transform, CryptoStreamMode.Write);
            try
            {
              \u0091\u0080.\u007E\u0083\u009D((object) source, (Stream) cryptoStream);
            }
            finally
            {
              if (cryptoStream != null)
                \u001A\u001E.\u007E\u0094\u0092((object) cryptoStream);
            }
          }
          finally
          {
            if (transform != null)
              \u001A\u001E.\u007E\u0094\u0092((object) transform);
          }
          \u001A\u001E.\u007E\u0090\u009F((object) rijndaelManaged);
        }
        finally
        {
          if (rijndaelManaged != null)
            \u001A\u001E.\u007E\u0094\u0092((object) rijndaelManaged);
        }
      }
      finally
      {
        if (passwordDeriveBytes != null)
          \u001A\u001E.\u007E\u0094\u0092((object) passwordDeriveBytes);
      }
    }

    internal static void \u001E\u0005(string initialVector, Stream source, Stream destination)
    {
      byte[] data = new byte[56];
      byte[] password = new byte[40];
      byte[] salt = new byte[16];
      int num = \u0080\u0081.\u007E\u008D\u009D((object) source, data, 0, 56);
      byte[] numArray1 = \u0017.\u001E\u0005(data);
      \u0089\u0083.\u0084\u0092((Array) numArray1, 0, (Array) password, 0, 40);
      \u0089\u0083.\u0084\u0092((Array) numArray1, 40, (Array) salt, 0, 16);
      ASCIIEncoding asciiEncoding = new ASCIIEncoding();
      byte[] numArray2 = \u0094\u0082.\u007E\u0017\u009C((object) asciiEncoding, initialVector);
      PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(password, salt, \u0017.\u0001, \u0017.\u0002);
      try
      {
        byte[] numArray3 = \u0004\u0086.\u007E\u009E\u009F((object) passwordDeriveBytes, \u0017.\u0001 / 8);
        RijndaelManaged rijndaelManaged = new RijndaelManaged();
        try
        {
          \u0099\u007F.\u007E\u0095\u009F((object) rijndaelManaged, CipherMode.CBC);
          ICryptoTransform transform = \u001F\u0083.\u007E\u0099\u009F((object) rijndaelManaged, numArray3, numArray2);
          try
          {
            CryptoStream cryptoStream = new CryptoStream(source, transform, CryptoStreamMode.Read);
            try
            {
              \u0091\u0080.\u007E\u0083\u009D((object) cryptoStream, destination);
            }
            finally
            {
              if (cryptoStream != null)
                \u001A\u001E.\u007E\u0094\u0092((object) cryptoStream);
            }
          }
          finally
          {
            if (transform != null)
              \u001A\u001E.\u007E\u0094\u0092((object) transform);
          }
          \u001A\u001E.\u007E\u0090\u009F((object) rijndaelManaged);
        }
        finally
        {
          if (rijndaelManaged != null)
            \u001A\u001E.\u007E\u0094\u0092((object) rijndaelManaged);
        }
      }
      finally
      {
        if (passwordDeriveBytes != null)
          \u001A\u001E.\u007E\u0094\u0092((object) passwordDeriveBytes);
      }
    }

    private static byte[] \u001D\u0005(byte[] data)
    {
      if (data.Length % 2 != 0)
        throw new ArgumentException();
      byte[] data1 = new byte[data.Length];
      \u0083\u0081.\u007E\u008C\u0092((object) data, (Array) data1, 0);
      \u0096\u001B.\u008E\u0092((Array) data1);
      return \u0017.\u007F\u0005(\u0017.\u001F\u0005(\u0017.\u0080\u0005(data1)));
    }

    private static byte[] \u001E\u0005(byte[] data)
    {
      if (data.Length % 2 != 0)
        throw new ArgumentException();
      byte[] numArray = \u0017.\u0080\u0005(\u0017.\u001F\u0005(\u0017.\u007F\u0005(data)));
      \u0096\u001B.\u008E\u0092((Array) numArray);
      return numArray;
    }

    private static byte[] \u001F\u0005(byte[] data)
    {
      byte[] numArray = new byte[data.Length];
      int index = 0;
      while (index < data.Length - 2)
      {
        numArray[index] = data[index + 2];
        numArray[index + 1] = data[index + 1];
        numArray[index + 2] = data[index];
        index += 3;
      }
      for (; index < data.Length; ++index)
        numArray[index] = data[index];
      return numArray;
    }

    private static byte[] \u007F\u0005(byte[] data)
    {
      byte[] numArray = new byte[data.Length];
      int index = 0;
      while (index < data.Length - 1)
      {
        numArray[index] = data[index + 1];
        numArray[index + 1] = data[index];
        index += 2;
      }
      for (; index < data.Length; ++index)
        numArray[index] = data[index];
      return numArray;
    }

    private static byte[] \u0080\u0005(byte[] data)
    {
      byte[] numArray = new byte[data.Length];
      int num = data.Length / 2;
      for (int index = 0; index < num; ++index)
        numArray[num + index] = data[index];
      for (int index = data.Length - 1; index >= num; --index)
        numArray[index - num] = data[index];
      return numArray;
    }
  }
}
