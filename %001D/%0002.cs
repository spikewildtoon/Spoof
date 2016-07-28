// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001B;
using \u001D;
using \u0080;
using \u0081;
using \u0082;
using \u0083;
using \u0084;
using System;
using System.Drawing;
using System.IO;

namespace \u001D
{
  internal static class \u0002
  {
    public static \u001C \u001D\u0005(this BinaryReader reader)
    {
      return new \u001C(\u0002.\u001D\u0005(reader), \u0004\u0081.\u007E\u009A\u009D((object) reader), \u0004\u0081.\u007E\u009A\u009D((object) reader), \u0004\u0081.\u007E\u009A\u009D((object) reader), \u0004\u0081.\u007E\u009A\u009D((object) reader));
    }

    public static void \u001D\u0005(this BinaryWriter writer, \u001C stats)
    {
      writer.\u001D\u0005(stats.TotalRunTime);
      \u000F\u0083.\u007E\u0016\u009E((object) writer, stats.TotalFishCaught);
      \u000F\u0083.\u007E\u0016\u009E((object) writer, stats.TotalBootsCaught);
      \u000F\u0083.\u007E\u0016\u009E((object) writer, stats.TotalBucketsSold);
      \u000F\u0083.\u007E\u0016\u009E((object) writer, stats.TotalCasts);
    }

    public static \u0005<\u0002> \u001D\u0005(this BinaryReader reader)
    {
      if (!\u0099\u0082.\u007E\u0095\u009D((object) reader))
        return (\u0005<\u0002>) null;
      byte[] buffer = \u0002.\u001D\u0005(reader);
      if (buffer == null)
        return (\u0005<\u0002>) null;
      MemoryStream memoryStream = new MemoryStream(buffer);
      try
      {
        return new \u0005<\u0002>((Stream) memoryStream);
      }
      finally
      {
        if (memoryStream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
      }
    }

    public static void \u001D\u0005(this BinaryWriter writer, \u0005<\u0002> jbmp)
    {
      if (jbmp == null)
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, false);
      }
      else
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, true);
        MemoryStream memoryStream = new MemoryStream();
        try
        {
          jbmp.\u001D\u0005((Stream) memoryStream);
          writer.\u001D\u0005(\u0086\u0083.\u007E\u0003\u009F((object) memoryStream));
        }
        finally
        {
          if (memoryStream != null)
            \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
        }
      }
    }

    public static unsafe \u0018 \u001D\u0005(this BinaryReader reader)
    {
      if (\u0099\u0082.\u007E\u0095\u009D((object) reader))
      {
        Size sz = new Size(\u0005\u0081.\u007E\u0099\u009D((object) reader), \u0005\u0081.\u007E\u0099\u009D((object) reader));
        byte[] numArray = \u0002.\u001D\u0005(reader);
        if (numArray != null)
        {
          \u0002[] pixels = new \u0002[sz.Width * sz.Height];
          fixed (byte* numPtr = numArray)
            fixed (\u0002* objPtr1 = pixels)
            {
              \u0002* objPtr2 = objPtr1;
              \u0002* objPtr3 = (\u0002*) numPtr;
              for (int index = 0; index < sz.Width * sz.Height; ++index)
              {
                *objPtr2 = *objPtr3;
                ++objPtr2;
                ++objPtr3;
              }
            }
          return new \u0018(pixels, sz);
        }
      }
      return (\u0018) null;
    }

    public static unsafe void \u001D\u0005(this BinaryWriter writer, \u0018 pix)
    {
      if (pix == null)
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, false);
      }
      else
      {
        Size size = pix.\u0001;
        \u0099\u001F.\u007E\u000E\u009E((object) writer, true);
        \u0011\u001F.\u007E\u0015\u009E((object) writer, size.Width);
        \u0011\u001F.\u007E\u0015\u009E((object) writer, size.Height);
        byte[] data = new byte[size.Width * size.Height * 3];
        \u0002[] getPixels = pix.GetPixels;
        fixed (byte* numPtr = data)
        {
          \u0002* objPtr1 = (\u0002*) numPtr;
          fixed (\u0002* objPtr2 = getPixels)
          {
            \u0002* objPtr3 = objPtr2;
            for (int index = 0; index < size.Width * size.Height; ++index)
            {
              *objPtr1 = *objPtr3;
              ++objPtr3;
              ++objPtr1;
            }
          }
        }
        writer.\u001D\u0005(data);
      }
    }

    public static void \u001D\u0005(this BinaryWriter writer, byte[] data)
    {
      byte[] dst = (byte[]) null;
      if (data != null)
      {
        try
        {
          \u0002.\u001D\u0005(data, out dst);
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005();
          dst = (byte[]) null;
        }
      }
      if (dst == null)
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, false);
      }
      else
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, true);
        \u0011\u001F.\u007E\u0015\u009E((object) writer, data.Length);
        \u0011\u001F.\u007E\u0015\u009E((object) writer, dst.Length);
        \u0015\u001C.\u007E\u0010\u009E((object) writer, dst);
      }
    }

    public static byte[] \u001D\u0005(this BinaryReader reader)
    {
      if (!\u0099\u0082.\u007E\u0095\u009D((object) reader))
        return (byte[]) null;
      int length = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      int num = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      byte[] src = \u0004\u0086.\u007E\u0003\u009E((object) reader, num);
      byte[] dst = new byte[length];
      try
      {
        \u0002.\u001D\u0005(src, dst);
        return dst;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        return (byte[]) null;
      }
      finally
      {
      }
    }

    public static void \u001D\u0005(this BinaryWriter writer, \u0019 parser)
    {
      if (parser == null)
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, false);
      }
      else
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, true);
        parser.\u001E\u0005(writer);
      }
    }

    public static \u0019 \u001D\u0005(this BinaryReader reader)
    {
      if (!\u0099\u0082.\u007E\u0095\u009D((object) reader))
        return (\u0019) null;
      return new \u0019(reader);
    }

    public static TimeSpan \u001D\u0005(this BinaryReader reader)
    {
      return \u001A\u001F.\u008E\u0097(\u001F\u001E.\u007E\u009B\u009D((object) reader));
    }

    public static void \u001D\u0005(this BinaryWriter writer, TimeSpan time)
    {
      \u0012\u0080.\u007E\u0017\u009E((object) writer, time.Ticks);
    }

    public static PointF \u001D\u0005(this BinaryReader reader)
    {
      return new PointF(\u0094\u0084.\u007E\u009D\u009D((object) reader), \u0094\u0084.\u007E\u009D\u009D((object) reader));
    }

    public static void \u001D\u0005(this BinaryWriter writer, PointF p)
    {
      \u0082\u001E.\u007E\u0019\u009E((object) writer, p.X);
      \u0082\u001E.\u007E\u0019\u009E((object) writer, p.Y);
    }

    public static Size \u001D\u0005(this BinaryReader reader)
    {
      return new Size(\u0005\u0081.\u007E\u0099\u009D((object) reader), \u0005\u0081.\u007E\u0099\u009D((object) reader));
    }

    public static void \u001D\u0005(this BinaryWriter writer, Size sz)
    {
      \u0011\u001F.\u007E\u0015\u009E((object) writer, sz.Width);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, sz.Height);
    }

    public static \u0002 \u001D\u0005(this BinaryReader reader)
    {
      return new \u0002(\u0001\u0081.\u007E\u0096\u009D((object) reader), \u0001\u0081.\u007E\u0096\u009D((object) reader), \u0001\u0081.\u007E\u0096\u009D((object) reader));
    }

    public static void \u001D\u0005(this BinaryWriter writer, \u0002 color)
    {
      \u0095\u001F.\u007E\u000F\u009E((object) writer, color.R);
      \u0095\u001F.\u007E\u000F\u009E((object) writer, color.G);
      \u0095\u001F.\u007E\u000F\u009E((object) writer, color.B);
    }

    public static \u001D.\u0015 \u001D\u0005(this BinaryReader reader)
    {
      return new \u001D.\u0015(\u0001\u0081.\u007E\u0096\u009D((object) reader), \u0001\u0081.\u007E\u0096\u009D((object) reader), \u0001\u0081.\u007E\u0096\u009D((object) reader), \u0001\u0081.\u007E\u0096\u009D((object) reader));
    }

    public static void \u001D\u0005(this BinaryWriter writer, \u001D.\u0015 color)
    {
      \u0095\u001F.\u007E\u000F\u009E((object) writer, color.R);
      \u0095\u001F.\u007E\u000F\u009E((object) writer, color.G);
      \u0095\u001F.\u007E\u000F\u009E((object) writer, color.B);
      \u0095\u001F.\u007E\u000F\u009E((object) writer, color.A);
    }

    public static void \u001D\u0005(this BinaryWriter writer, \u0013 fbr)
    {
      \u0002\u001D.\u007E\u0012\u009E((object) writer, fbr.\u0001);
      \u0002\u001D.\u007E\u0012\u009E((object) writer, fbr.\u0002);
      \u0002\u001D.\u007E\u0012\u009E((object) writer, fbr.\u0003);
      \u0002\u001D.\u007E\u0012\u009E((object) writer, fbr.\u0004);
    }

    public static \u0013 \u001D\u0005(this BinaryReader reader)
    {
      return new \u0013(\u0090\u001C.\u007E\u009E\u009D((object) reader), \u0090\u001C.\u007E\u009E\u009D((object) reader), \u0090\u001C.\u007E\u009E\u009D((object) reader), \u0090\u001C.\u007E\u009E\u009D((object) reader));
    }

    public static \u0016 \u001D\u0005(this Stream stream)
    {
      byte[] bytes = new byte[16];
      int num = \u0080\u0081.\u007E\u008D\u009D((object) stream, bytes, 0, bytes.Length);
      return new \u0016(bytes);
    }

    public static void \u001D\u0005(this Stream stream, \u0016 hashCode)
    {
      \u0016\u0086.\u007E\u008F\u009D((object) stream, hashCode.\u001D\u0005(), 0, 16);
    }

    public static \u0016 \u001D\u0005(this BinaryReader reader)
    {
      return new \u0016(\u0004\u0086.\u007E\u0003\u009E((object) reader, 16));
    }

    public static void \u001D\u0005(this BinaryWriter writer, \u0016 hash)
    {
      \u0015\u001C.\u007E\u0010\u009E((object) writer, hash.\u001D\u0005());
    }

    public static void \u001D\u0005(this BinaryWriter writer, Version version)
    {
      \u0011\u001F.\u007E\u0015\u009E((object) writer, \u0005\u0081.\u007E\u0008\u0098((object) version));
      \u0011\u001F.\u007E\u0015\u009E((object) writer, \u0005\u0081.\u007E\u000E\u0098((object) version));
      \u0011\u001F.\u007E\u0015\u009E((object) writer, \u0005\u0081.\u007E\u000F\u0098((object) version));
      \u0011\u001F.\u007E\u0015\u009E((object) writer, \u0005\u0081.\u007E\u0010\u0098((object) version));
    }

    public static Version \u001D\u0005(this BinaryReader reader)
    {
      return new Version(\u0005\u0081.\u007E\u0099\u009D((object) reader), \u0005\u0081.\u007E\u0099\u009D((object) reader), \u0005\u0081.\u007E\u0099\u009D((object) reader), \u0005\u0081.\u007E\u0099\u009D((object) reader));
    }

    public static void \u001D\u0005(this BinaryWriter writer, Guid guid)
    {
      \u0015\u001C.\u007E\u0010\u009E((object) writer, guid.ToByteArray());
    }

    public static Guid \u001D\u0005(this BinaryReader reader)
    {
      return new Guid(\u0004\u0086.\u007E\u0003\u009E((object) reader, 16));
    }

    public static DateTime \u001D\u0005(this BinaryReader reader)
    {
      return \u0014\u0080.\u0006\u0094(\u001F\u001E.\u007E\u009B\u009D((object) reader));
    }

    public static void \u001D\u0005(this BinaryWriter writer, DateTime dateTime)
    {
      \u0012\u0080.\u007E\u0017\u009E((object) writer, dateTime.ToBinary());
    }

    public static Uri \u001D\u0005(this BinaryReader reader)
    {
      if (!\u0099\u0082.\u007E\u0095\u009D((object) reader))
        return (Uri) null;
      string uriString = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      if (\u008F\u0084.\u009E\u0092(uriString))
        return (Uri) null;
      return new Uri(uriString);
    }

    public static void \u001D\u0005(this BinaryWriter writer, Uri uri)
    {
      if (\u008E\u0081.\u008A\u0002\u0002(uri, (Uri) null) || \u008F\u0084.\u009E\u0092(\u0002\u007F.\u007E\u0088\u0002\u0002((object) uri)))
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, false);
      }
      else
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, true);
        \u0092\u0081.\u007E\u001A\u009E((object) writer, \u0002\u007F.\u007E\u0088\u0002\u0002((object) uri));
      }
    }

    public static int \u001D\u0005(this Stream reader)
    {
      byte[] numArray = \u0015.\u0081.\u001D\u0005(reader, 4);
      if (BitConverter.IsLittleEndian)
        \u0096\u001B.\u008E\u0092((Array) numArray);
      return \u0014\u001E.\u0001\u0095(numArray, 0);
    }

    public static void \u001D\u0005(this Stream writer, int value)
    {
      byte[] numArray = \u001B\u0086.\u009C\u0094(value);
      if (BitConverter.IsLittleEndian)
        \u0096\u001B.\u008E\u0092((Array) numArray);
      \u0016\u0086.\u007E\u008F\u009D((object) writer, numArray, 0, numArray.Length);
    }

    public static short \u001D\u0005(this Stream reader)
    {
      byte[] numArray = \u0015.\u0081.\u001D\u0005(reader, 2);
      if (BitConverter.IsLittleEndian)
        \u0096\u001B.\u008E\u0092((Array) numArray);
      return \u0013\u0084.\u009F\u0094(numArray, 0);
    }

    public static void \u001D\u0005(this Stream writer, short value)
    {
      byte[] numArray = \u009D\u001E.\u009B\u0094(value);
      if (BitConverter.IsLittleEndian)
        \u0096\u001B.\u008E\u0092((Array) numArray);
      \u0016\u0086.\u007E\u008F\u009D((object) writer, numArray, 0, numArray.Length);
    }
  }
}
