// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0017;
using \u001C;
using System;
using System.IO;
using System.IO.Compression;

namespace \u0018
{
  internal static class \u0018
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0018()
    {
      \u0004.\u001D\u0005(typeof (\u0018.\u0018));
    }

    public static void \u001D\u0005(Stream inStream, Stream outStream, bool isStreamOwner)
    {
      if (inStream != null)
        goto label_10;
label_1:
      throw new Exception(\u0018.\u0018.\u0001(35838));
label_10:
      if (outStream != null)
      {
        try
        {
          \u0016 source_stream = new \u0016(inStream);
          try
          {
            source_stream.IsStreamOwner = isStreamOwner;
            source_stream.\u001D\u0005(outStream, new byte[4096]);
          }
          finally
          {
            if (source_stream != null)
              \u001A\u001E.\u007E\u0094\u0092((object) source_stream);
          }
        }
        finally
        {
          if (isStreamOwner)
            \u001A\u001E.\u007E\u0084\u009D((object) outStream);
        }
      }
      else
        goto label_1;
    }

    public static void \u001D\u0005(Stream inStream, Stream outStream, bool isStreamOwner, int level)
    {
      if (inStream == null)
        throw new ArgumentNullException(\u0018.\u0018.\u0001(35855));
      if (outStream == null)
        throw new ArgumentNullException(\u0018.\u0018.\u0001(35868));
      try
      {
        \u0014 obj = new \u0014(outStream, level);
        try
        {
          obj.IsStreamOwner = isStreamOwner;
          inStream.\u001D\u0005((Stream) obj, new byte[4096]);
        }
        finally
        {
          if (obj != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj);
        }
      }
      finally
      {
        if (isStreamOwner)
          \u001A\u001E.\u007E\u0084\u009D((object) inStream);
      }
    }

    public static byte[] \u001D\u0005(Stream str)
    {
      MemoryStream memoryStream = new MemoryStream();
      try
      {
        \u0018.\u0018.\u001D\u0005((Stream) memoryStream);
        DeflateStream deflateStream = new DeflateStream((Stream) memoryStream, CompressionMode.Compress);
        try
        {
          \u0091\u0080.\u007E\u0083\u009D((object) str, (Stream) deflateStream);
          return \u0086\u0083.\u007E\u0003\u009F((object) memoryStream);
        }
        finally
        {
          if (deflateStream != null)
            \u001A\u001E.\u007E\u0094\u0092((object) deflateStream);
        }
      }
      finally
      {
        if (memoryStream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
      }
    }

    public static byte[] \u001D\u0005(byte[] data)
    {
      MemoryStream memoryStream = new MemoryStream();
      try
      {
        \u0018.\u0018.\u001D\u0005((Stream) memoryStream);
        DeflateStream deflateStream = new DeflateStream((Stream) memoryStream, CompressionMode.Compress);
        try
        {
          data.\u001D\u0005((Stream) deflateStream);
          return \u0086\u0083.\u007E\u0003\u009F((object) memoryStream);
        }
        finally
        {
          if (deflateStream != null)
            \u001A\u001E.\u007E\u0094\u0092((object) deflateStream);
        }
      }
      finally
      {
        if (memoryStream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
      }
    }

    public static byte[] \u001E\u0005(byte[] data)
    {
      MemoryStream memoryStream = new MemoryStream(data);
      try
      {
        \u0018.\u0018.\u001E\u0005((Stream) memoryStream);
        DeflateStream source = new DeflateStream((Stream) memoryStream, CompressionMode.Decompress);
        try
        {
          return source.\u001D\u0005();
        }
        finally
        {
          if (source != null)
            \u001A\u001E.\u007E\u0094\u0092((object) source);
        }
      }
      finally
      {
        if (memoryStream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
      }
    }

    public static void \u001D\u0005(Stream source, Stream destination)
    {
      \u0018.\u0018.\u001E\u0005(source);
      DeflateStream source_stream = new DeflateStream(source, CompressionMode.Decompress);
      try
      {
        source_stream.\u001D\u0005(destination, new byte[4096]);
      }
      finally
      {
        if (source_stream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) source_stream);
      }
    }

    private static void \u001D\u0005(Stream str)
    {
      \u0095\u001F.\u007E\u0090\u009D((object) str, (byte) 120);
      \u0095\u001F.\u007E\u0090\u009D((object) str, (byte) 1);
    }

    private static void \u001E\u0005(Stream str)
    {
      int num1 = \u0005\u0081.\u007E\u008E\u009D((object) str);
      int num2 = \u0005\u0081.\u007E\u008E\u009D((object) str);
    }
  }
}
