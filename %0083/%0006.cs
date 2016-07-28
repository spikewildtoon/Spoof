// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001C;
using \u0083;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace \u0083
{
  internal sealed class \u0006
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly int \u0001;
    private static readonly int \u0002;
    private static readonly string \u0002;

    static \u0006()
    {
      \u0004.\u001D\u0005(typeof (\u0006));
      \u0006.\u0001 = \u0006.\u0001(100325);
      \u0006.\u0001 = 256;
      \u0006.\u0002 = 2;
      \u0006.\u0002 = \u0006.\u0001(95332);
    }

    internal static void \u001D\u0005(Stream source, Stream destination, string sPassword, string sSalt)
    {
      ASCIIEncoding asciiEncoding = new ASCIIEncoding();
      byte[] numArray1 = \u0094\u0082.\u007E\u0017\u009C((object) asciiEncoding, \u0006.\u0001);
      byte[] numArray2 = (byte[]) null;
      byte[] password = \u0094\u0082.\u007E\u0017\u009C((object) asciiEncoding, sPassword);
      byte[] salt = \u0094\u0082.\u007E\u0017\u009C((object) asciiEncoding, sSalt);
      try
      {
        PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(password, salt, \u0006.\u0002, \u0006.\u0002);
        try
        {
          byte[] numArray3 = \u0004\u0086.\u007E\u009E\u009F((object) passwordDeriveBytes, \u0006.\u0001 / 8);
          RijndaelManaged rijndaelManaged = new RijndaelManaged();
          try
          {
            \u0099\u007F.\u007E\u0095\u009F((object) rijndaelManaged, CipherMode.CBC);
            ICryptoTransform transform = \u001F\u0083.\u007E\u0099\u009F((object) rijndaelManaged, numArray3, numArray1);
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
      finally
      {
        numArray2 = (byte[]) null;
      }
    }

    internal static byte[] \u001D\u0005(string productID, string name, string key)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      try
      {
        \u001A\u001E.\u007E\u009A\u009F((object) rijndaelManaged);
        \u001A\u001E.\u007E\u009B\u009F((object) rijndaelManaged);
        MemoryStream memoryStream1 = new MemoryStream();
        byte[] numArray1;
        try
        {
          ICryptoTransform transform = \u0016\u0082.\u007E\u0096\u009F((object) rijndaelManaged);
          try
          {
            CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream1, transform, CryptoStreamMode.Write);
            try
            {
              BinaryWriter binaryWriter = new BinaryWriter((Stream) cryptoStream, \u0013.\u0001);
              try
              {
                \u0092\u0081.\u007E\u001A\u009E((object) binaryWriter, name);
                \u0092\u0081.\u007E\u001A\u009E((object) binaryWriter, key);
                \u0092\u0081.\u007E\u001A\u009E((object) binaryWriter, \u0011.HashedUniqueSerial);
                \u0092\u0081.\u007E\u001A\u009E((object) binaryWriter, productID);
              }
              finally
              {
                if (binaryWriter != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) binaryWriter);
              }
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
          numArray1 = \u0086\u0083.\u007E\u0003\u009F((object) memoryStream1);
        }
        finally
        {
          if (memoryStream1 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) memoryStream1);
        }
        byte[] numArray2 = \u0086\u0083.\u007E\u0093\u009F((object) rijndaelManaged);
        \u001A\u001E.\u007E\u009A\u009F((object) rijndaelManaged);
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          BinaryWriter binaryWriter1 = new BinaryWriter((Stream) memoryStream2, \u0013.\u0001);
          try
          {
            \u0011\u001F.\u007E\u0015\u009E((object) binaryWriter1, numArray1.Length);
            \u0015\u001C.\u007E\u0010\u009E((object) binaryWriter1, numArray1);
            \u0011\u001F.\u007E\u0015\u009E((object) binaryWriter1, \u0086\u0083.\u007E\u0091\u009F((object) rijndaelManaged).Length);
            \u0015\u001C.\u007E\u0010\u009E((object) binaryWriter1, \u0086\u0083.\u007E\u0091\u009F((object) rijndaelManaged));
            MemoryStream memoryStream3 = new MemoryStream();
            byte[] numArray3;
            try
            {
              ICryptoTransform transform = \u0016\u0082.\u007E\u0096\u009F((object) rijndaelManaged);
              try
              {
                CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream3, transform, CryptoStreamMode.Write);
                try
                {
                  BinaryWriter binaryWriter2 = new BinaryWriter((Stream) cryptoStream, \u0013.\u0001);
                  try
                  {
                    \u0015\u001C.\u007E\u0010\u009E((object) binaryWriter2, numArray2);
                  }
                  finally
                  {
                    if (binaryWriter2 != null)
                      \u001A\u001E.\u007E\u0094\u0092((object) binaryWriter2);
                  }
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
              numArray3 = \u0086\u0083.\u007E\u0003\u009F((object) memoryStream3);
            }
            finally
            {
              if (memoryStream3 != null)
                \u001A\u001E.\u007E\u0094\u0092((object) memoryStream3);
            }
            \u0011\u001F.\u007E\u0015\u009E((object) binaryWriter1, numArray3.Length);
            \u0015\u001C.\u007E\u0010\u009E((object) binaryWriter1, numArray3);
            \u0011\u001F.\u007E\u0015\u009E((object) binaryWriter1, \u0086\u0083.\u007E\u0093\u009F((object) rijndaelManaged).Length);
            \u0015\u001C.\u007E\u0010\u009E((object) binaryWriter1, \u0086\u0083.\u007E\u0093\u009F((object) rijndaelManaged));
            return \u0086\u0083.\u007E\u0003\u009F((object) memoryStream2);
          }
          finally
          {
            if (binaryWriter1 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) binaryWriter1);
          }
        }
        finally
        {
          if (memoryStream2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) memoryStream2);
        }
      }
      finally
      {
        if (rijndaelManaged != null)
          \u001A\u001E.\u007E\u0094\u0092((object) rijndaelManaged);
      }
    }
  }
}
