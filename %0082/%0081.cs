// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0082;
using System;
using System.IO;

namespace \u0082
{
  internal static class \u0081
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0081()
    {
      \u0004.\u001D\u0005(typeof (\u0081));
    }

    public static DateTime \u001D\u0005(Stream fs)
    {
      \u0012\u0080 obj = \u0012\u0080.\u007E\u0082\u009D;
      Stream stream = fs;
      long num = stream.Position + 4L;
      obj((object) stream, num);
      byte[] data = new byte[4];
      \u0081.\u001D\u0005(fs, data);
      int year = \u0014\u001E.\u0001\u0095(data, 0);
      \u0081.\u001D\u0005(fs, data);
      int month = \u0014\u001E.\u0001\u0095(data, 0);
      \u0081.\u001D\u0005(fs, data);
      int day = \u0014\u001E.\u0001\u0095(data, 0);
      \u0081.\u001D\u0005(fs, data);
      int hour = \u0014\u001E.\u0001\u0095(data, 0);
      \u0081.\u001D\u0005(fs, data);
      int minute = \u0014\u001E.\u0001\u0095(data, 0);
      \u0081.\u001D\u0005(fs, data);
      int second = \u0014\u001E.\u0001\u0095(data, 0);
      return new DateTime(year, month, day, hour, minute, second);
    }

    public static string \u001D\u0005(Stream fs)
    {
      byte[] data1 = new byte[4];
      \u0081.\u001D\u0005(fs, data1);
      byte[] data2 = new byte[\u0014\u001E.\u0001\u0095(data1, 0)];
      \u0081.\u001D\u0005(fs, data2);
      return \u0099\u0084.\u007E\u0018\u009C((object) \u001D\u001F.\u001B\u009C(), data2);
    }

    public static string \u001E\u0005(Stream fs)
    {
      byte[] data = new byte[\u0081.\u001D\u0005(fs)];
      \u0081.\u001D\u0005(fs, data);
      return \u0099\u0084.\u007E\u0018\u009C((object) \u001D\u001F.\u001B\u009C(), data);
    }

    public static byte[] \u001D\u0005(Stream fs)
    {
      byte[] data1 = new byte[4];
      \u0081.\u001D\u0005(fs, data1);
      byte[] data2 = new byte[\u0014\u001E.\u0001\u0095(data1, 0)];
      \u0081.\u001D\u0005(fs, data2);
      return data2;
    }

    public static int \u001D\u0005(Stream fs)
    {
      byte[] data = new byte[4];
      \u0012\u0080 obj = \u0012\u0080.\u007E\u0082\u009D;
      Stream stream = fs;
      long num = stream.Position + 4L;
      obj((object) stream, num);
      \u0081.\u001D\u0005(fs, data);
      return \u0014\u001E.\u0001\u0095(data, 0);
    }

    public static bool \u001D\u0005(Stream fs)
    {
      return \u0081.\u001D\u0005(fs) == 1;
    }

    public static long \u001D\u0005(Stream fs)
    {
      byte[] data = new byte[8];
      \u0012\u0080 obj = \u0012\u0080.\u007E\u0082\u009D;
      Stream stream = fs;
      long num = stream.Position + 4L;
      obj((object) stream, num);
      \u0081.\u001D\u0005(fs, data);
      return \u0005\u001C.\u0002\u0095(data, 0);
    }

    public static short \u001D\u0005(Stream fs)
    {
      byte[] data = new byte[2];
      \u0012\u0080 obj = \u0012\u0080.\u007E\u0082\u009D;
      Stream stream = fs;
      long num = stream.Position + 4L;
      obj((object) stream, num);
      \u0081.\u001D\u0005(fs, data);
      return \u0013\u0084.\u009F\u0094(data, 0);
    }

    public static bool \u001D\u0005(Stream fs, string HeaderShouldBe)
    {
      byte[] numArray = new byte[\u0005\u0081.\u007E\u0001\u0093((object) HeaderShouldBe)];
      int num = \u0080\u0081.\u007E\u008D\u009D((object) fs, numArray, 0, numArray.Length);
      string str = \u0099\u0084.\u007E\u0018\u009C((object) \u001D\u001F.\u001B\u009C(), numArray);
      return \u0008\u001F.\u009A\u0092(str, HeaderShouldBe);
    }

    public static bool \u001D\u0005(Stream fs, byte endByte, byte readValue)
    {
      if ((int) endByte == (int) readValue)
        return true;
      if (\u001F\u001E.\u007E\u0080\u009D((object) fs) == \u001F\u001E.\u007E\u0081\u009D((object) fs))
        throw new Exception(\u0081.\u0001(100201));
      return false;
    }

    public static void \u001D\u0005(Stream fs, byte flag)
    {
      if ((int) flag >= 128 && (int) flag <= 159)
        return;
      byte[] numArray = new byte[4];
      int num1 = \u0080\u0081.\u007E\u008D\u009D((object) fs, numArray, 0, 4);
      \u0012\u0080 obj = \u0012\u0080.\u007E\u0082\u009D;
      Stream stream = fs;
      long num2 = stream.Position + (long) \u0014\u001E.\u0001\u0095(numArray, 0);
      obj((object) stream, num2);
    }

    public static void \u001D\u0005(Stream stream, byte[] data)
    {
      int num1 = 0;
      int length = data.Length;
      while (length > 0)
      {
        int num2 = \u0080\u0081.\u007E\u008D\u009D((object) stream, data, num1, length);
        if (num2 <= 0)
          throw new EndOfStreamException(\u009E\u0081.\u001F\u0093(\u0081.\u0001(100234), (object) length));
        length -= num2;
        num1 += num2;
      }
    }
  }
}
