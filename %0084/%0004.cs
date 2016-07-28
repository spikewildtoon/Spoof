// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001E;
using \u0080;
using \u0081;
using \u0084;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace \u0084
{
  internal static class \u0004
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0004()
    {
      \u0004.\u001D\u0005(typeof (\u0004));
    }

    public static \u0016 \u001D\u0005(string fileName)
    {
      Stream stream = (Stream) \u008F\u001C.\u0093\u009E(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
      try
      {
        return stream.\u001D\u0005();
      }
      finally
      {
        if (stream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) stream);
      }
    }

    public static string \u001D\u0005(string data)
    {
      switch (data)
      {
        case null:
          return (string) null;
        default:
          UnicodeEncoding unicodeEncoding1 = (UnicodeEncoding) null;
          try
          {
            UnicodeEncoding unicodeEncoding2 = new UnicodeEncoding();
            return \u0004.\u001D\u0005(\u0094\u0082.\u007E\u0017\u009C((object) unicodeEncoding2, data));
          }
          finally
          {
            unicodeEncoding1 = (UnicodeEncoding) null;
          }
      }
    }

    public static string \u001D\u0005(byte[] data)
    {
      if (data == null)
        return (string) null;
      UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
      SHA1 shA1 = (SHA1) new SHA1CryptoServiceProvider();
      try
      {
        return \u008B\u0080.\u007E\u001D\u0093((object) \u0092\u0084.\u0004\u0095(\u0082\u0083.\u007E\u0001\u0001\u0002((object) shA1, data)), \u0004.\u0001(7801), \u0004.\u0001(7491));
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        return (string) null;
      }
      finally
      {
        if (shA1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) shA1);
      }
    }
  }
}
