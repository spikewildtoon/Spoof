// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using System;
using System.IO;

namespace \u0015
{
  internal static class \u0081
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0081()
    {
      \u0004.\u001D\u0005(typeof (\u0081));
    }

    public static void \u001D\u0005(this byte[] source, Stream destination)
    {
      int num1 = 0;
      while (num1 < source.Length)
      {
        int num2 = num1 + 4096 > source.Length ? source.Length - num1 : 4096;
        \u0016\u0086.\u007E\u008F\u009D((object) destination, source, num1, num2);
        num1 += num2;
      }
    }

    public static byte[] \u001D\u0005(this Stream source)
    {
      MemoryStream memoryStream = new MemoryStream();
      try
      {
        byte[] numArray1 = new byte[4096];
        while (true)
        {
          \u0080\u0081 obj = \u0080\u0081.\u007E\u008D\u009D;
          Stream stream = source;
          byte[] numArray2 = numArray1;
          int num1 = 0;
          int length = numArray1.Length;
          int num2;
          if ((num2 = obj((object) stream, numArray2, num1, length)) != 0)
            \u0016\u0086.\u007E\u008F\u009D((object) memoryStream, numArray1, 0, num2);
          else
            break;
        }
        return \u0086\u0083.\u007E\u0003\u009F((object) memoryStream);
      }
      finally
      {
        if (memoryStream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
      }
    }

    public static bool \u001D\u0005(this Stream str)
    {
      return \u001F\u001E.\u007E\u0081\u009D((object) str) == \u001F\u001E.\u007E\u0080\u009D((object) str);
    }

    public static bool \u001D\u0005(this BinaryReader reader)
    {
      return \u0081.\u001D\u0005(\u009F\u001D.\u007E\u0093\u009D((object) reader));
    }

    public static byte[] \u001D\u0005(this Stream reader, int numberOfBytes)
    {
      byte[] numArray = new byte[numberOfBytes];
      int num = \u0080\u0081.\u007E\u008D\u009D((object) reader, numArray, 0, numberOfBytes);
      return numArray;
    }

    public static void \u001D\u0005(this Stream source_stream, Stream destination_stream, byte[] buffer)
    {
      if (source_stream == null)
        throw new ArgumentNullException(\u0081.\u0001(15336));
      if (destination_stream == null)
        throw new ArgumentNullException(\u0081.\u0001(15357));
      if (buffer == null)
        throw new ArgumentNullException(\u0081.\u0001(15327));
      if (buffer.Length < 128)
        throw new ArgumentException(\u0081.\u0001(15382), \u0081.\u0001(15327));
      int num;
      while ((num = \u0080\u0081.\u007E\u008D\u009D((object) source_stream, buffer, 0, buffer.Length)) != 0)
        \u0016\u0086.\u007E\u008F\u009D((object) destination_stream, buffer, 0, num);
      \u001A\u001E.\u007E\u0088\u009D((object) destination_stream);
    }

    public static void \u001D\u0005(this Stream str, byte[] buffer)
    {
      int num1 = 0;
      int num2 = 4096;
      while (true)
      {
        Stream stream = str;
        byte[] buffer1 = buffer;
        int offset = num1;
        int count = num1 + num2 > buffer.Length ? buffer.Length - num1 : num2;
        int num3;
        if ((num3 = stream.Read(buffer1, offset, count)) > 0)
          num1 += num3;
        else
          break;
      }
    }

    public static void \u001D\u0005(this Stream str, Stream dest, long copyLength)
    {
      byte[] buffer = new byte[4096];
      while (copyLength > 0L)
      {
        int num = str.Read(buffer, 0, copyLength > (long) buffer.Length ? buffer.Length : (int) copyLength);
        \u0016\u0086.\u007E\u008F\u009D((object) dest, buffer, 0, num);
        copyLength -= (long) num;
      }
    }

    public static void \u001D\u0005(this Stream str, byte[] buffer, long copyLength)
    {
      int offset = 0;
      while (copyLength > 0L)
      {
        offset += str.Read(buffer, offset, copyLength > (long) buffer.Length ? buffer.Length : (int) copyLength);
        copyLength -= (long) offset;
      }
    }
  }
}
