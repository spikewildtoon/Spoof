// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0080;
using \u0081;
using System;
using System.IO;
using System.Security.Cryptography;

namespace \u0081
{
  internal static class \u0014
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0014()
    {
      \u0004.\u001D\u0005(typeof (\u0014));
    }

    public static \u0016 \u001D\u0005(this byte[] data)
    {
      if (data == null)
        throw new ArgumentNullException(\u0014.\u0001(48465));
      MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
      try
      {
        return new \u0016(\u0092\u0084.\u0004\u0095(\u0087\u0080.\u007E\u0002\u0001\u0002((object) cryptoServiceProvider, data, 0, data.Length)));
      }
      finally
      {
        if (cryptoServiceProvider != null)
          \u001A\u001E.\u007E\u0094\u0092((object) cryptoServiceProvider);
      }
    }

    public static \u0016 \u001D\u0005(this Stream stream, int startPosition, int length)
    {
      long num1 = \u001F\u001E.\u007E\u0081\u009D((object) stream);
      \u0012\u0080.\u007E\u0082\u009D((object) stream, (long) startPosition);
      byte[] numArray = new byte[length];
      int num2 = \u0080\u0081.\u007E\u008D\u009D((object) stream, numArray, 0, length);
      MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
      \u0016 obj;
      try
      {
        obj = new \u0016(\u0092\u0084.\u0004\u0095(\u0087\u0080.\u007E\u0002\u0001\u0002((object) cryptoServiceProvider, numArray, 0, length)));
      }
      finally
      {
        if (cryptoServiceProvider != null)
          \u001A\u001E.\u007E\u0094\u0092((object) cryptoServiceProvider);
      }
      \u0012\u0080.\u007E\u0082\u009D((object) stream, num1);
      return obj;
    }

    public static \u0016 \u001D\u0005(this Stream stream)
    {
      long num = \u001F\u001E.\u007E\u0081\u009D((object) stream);
      \u0012\u0080.\u007E\u0082\u009D((object) stream, 0L);
      MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
      \u0016 obj;
      try
      {
        obj = new \u0016(\u0092\u0084.\u0004\u0095(\u0083\u0083.\u007E\u009F\u009F((object) cryptoServiceProvider, stream)));
      }
      finally
      {
        if (cryptoServiceProvider != null)
          \u001A\u001E.\u007E\u0094\u0092((object) cryptoServiceProvider);
      }
      \u0012\u0080.\u007E\u0082\u009D((object) stream, num);
      return obj;
    }
  }
}
