// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u001D;
using \u0082;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace \u0082
{
  internal static class \u0017
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public static readonly short \u0001;

    static \u0017()
    {
      \u0004.\u001D\u0005(typeof (\u0017));
      \u0017.\u0001 = (short) 474;
    }

    public static void \u001D\u0005(Stream data_stream, Stream destination_stream, Bitmap destination_bitmap, Color? backGroundColor, bool convert_to_grayscale, \u0002 format)
    {
      Bitmap original = (Bitmap) \u0099\u001C.\u001C\u001F(data_stream);
      try
      {
        if (destination_bitmap != null && backGroundColor.HasValue)
        {
          if (\u0005\u0081.\u007E\u007F\u001F((object) destination_bitmap) != \u0005\u0081.\u007E\u007F\u001F((object) original) || \u0005\u0081.\u007E\u0080\u001F((object) destination_bitmap) != \u0005\u0081.\u007E\u0080\u001F((object) original))
            throw new ArgumentException(\u0017.\u0001(98987));
          Graphics graphics = \u0005\u0087.\u001D\u007F((Image) destination_bitmap);
          try
          {
            SolidBrush solidBrush = new SolidBrush(backGroundColor.Value);
            try
            {
              \u0015\u0083.\u007E\u0081\u007F((object) graphics, SmoothingMode.HighQuality);
              \u0094\u0081.\u007E\u0083\u007F((object) graphics, InterpolationMode.High);
              \u0099\u0083.\u007E\u007F\u007F((object) graphics, CompositingQuality.HighQuality);
              \u001A\u0082.\u007E\u0094\u007F((object) graphics, (Brush) solidBrush, 0, 0, \u0005\u0081.\u007E\u007F\u001F((object) destination_bitmap), \u0005\u0081.\u007E\u0080\u001F((object) destination_bitmap));
              \u009B\u001F.\u007E\u009F\u007F((object) graphics, (Image) original, 0, 0, \u0005\u0081.\u007E\u007F\u001F((object) original), \u0005\u0081.\u007E\u0080\u001F((object) original));
            }
            finally
            {
              if (solidBrush != null)
                \u001A\u001E.\u007E\u0094\u0092((object) solidBrush);
            }
          }
          finally
          {
            if (graphics != null)
              \u001A\u001E.\u007E\u0094\u0092((object) graphics);
          }
        }
        if (convert_to_grayscale)
          \u0015.\u0082.\u001D\u0005(original);
        \u0010 writer = new \u0010(destination_stream);
        try
        {
          BinaryWriter binaryWriter = new BinaryWriter((Stream) writer);
          try
          {
            writer.\u001D\u0005(\u0017.\u0001);
            \u0095\u001F.\u007E\u0090\u009D((object) writer, (byte) 1);
            \u0095\u001F.\u007E\u0090\u009D((object) writer, (byte) 1);
            short num1;
            short num2;
            switch (format)
            {
              case \u0002.\u0001:
                num1 = (short) 4;
                num2 = (short) 3;
                break;
              case \u0002.\u0002:
                num1 = (short) 3;
                num2 = (short) 3;
                break;
              case \u0002.\u0003:
                num1 = (short) 2;
                num2 = (short) 3;
                break;
              case \u0002.\u0004:
                num1 = (short) 1;
                num2 = (short) 2;
                break;
              default:
                throw new NotSupportedException(\u009E\u0081.\u001F\u0093(\u0017.\u0001(99068), (object) format));
            }
            writer.\u001D\u0005(num2);
            writer.\u001D\u0005((short) \u0005\u0081.\u007E\u007F\u001F((object) original));
            writer.\u001D\u0005((short) \u0005\u0081.\u007E\u0080\u001F((object) original));
            writer.\u001D\u0005(num1);
            writer.\u001D\u0005(0);
            writer.\u001D\u0005((int) byte.MaxValue);
            \u0015\u001C.\u007E\u0010\u009E((object) binaryWriter, new byte[4]);
            \u0015\u001C.\u007E\u0010\u009E((object) binaryWriter, new byte[80]);
            writer.\u001D\u0005(0);
            \u0015\u001C.\u007E\u0010\u009E((object) binaryWriter, new byte[404]);
            for (int index1 = 0; index1 < (int) num1; ++index1)
            {
              for (int index2 = 0; index2 < \u0005\u0081.\u007E\u0080\u001F((object) original); ++index2)
                writer.\u001D\u0005(0);
              for (int index2 = 0; index2 < \u0005\u0081.\u007E\u0080\u001F((object) original); ++index2)
                writer.\u001D\u0005(0);
            }
            \u0017.\u0001[] objArray1 = new \u0017.\u0001[\u0005\u0081.\u007E\u0080\u001F((object) original)];
            \u0017.\u0001[] objArray2;
            if (destination_bitmap == null)
            {
              objArray2 = new \u0017.\u0001[\u0005\u0081.\u007E\u0080\u001F((object) original) * (int) num1];
              \u001D.\u0015[,] data = new \u001D.\u0015[\u0005\u0081.\u007E\u007F\u001F((object) original), \u0005\u0081.\u007E\u0080\u001F((object) original)];
              \u0017.\u001E\u0005(original, data);
              switch (format)
              {
                case \u0002.\u0001:
                case \u0002.\u0002:
                  for (int index1 = (int) num1 - 1; index1 >= 0; --index1)
                  {
                    int num3 = ((int) num1 - 1 - index1) * \u0005\u0081.\u007E\u0080\u001F((object) original);
                    for (int index2 = 0; index2 < \u0005\u0081.\u007E\u0080\u001F((object) original); ++index2)
                    {
                      \u0017.\u0001 obj = objArray2[num3 + index2] = new \u0017.\u0001();
                      obj.\u0001 = new byte[\u0005\u0081.\u007E\u007F\u001F((object) original)];
                      for (int index3 = 0; index3 < \u0005\u0081.\u007E\u007F\u001F((object) original); ++index3)
                      {
                        switch (index1)
                        {
                          case 0:
                            obj.\u0001[index3] = data[index3, index2].R;
                            break;
                          case 1:
                            obj.\u0001[index3] = data[index3, index2].G;
                            break;
                          case 2:
                            obj.\u0001[index3] = data[index3, index2].B;
                            break;
                          case 3:
                            obj.\u0001[index3] = data[index3, index2].A;
                            break;
                        }
                      }
                    }
                  }
                  break;
                case \u0002.\u0003:
                  for (int index1 = (int) num1 - 1; index1 >= 0; --index1)
                  {
                    int num3 = ((int) num1 - 1 - index1) * \u0005\u0081.\u007E\u0080\u001F((object) original);
                    for (int index2 = 0; index2 < \u0005\u0081.\u007E\u0080\u001F((object) original); ++index2)
                    {
                      \u0017.\u0001 obj = objArray2[num3 + index2] = new \u0017.\u0001();
                      obj.\u0001 = new byte[\u0005\u0081.\u007E\u007F\u001F((object) original)];
                      for (int index3 = 0; index3 < \u0005\u0081.\u007E\u007F\u001F((object) original); ++index3)
                      {
                        switch (index1)
                        {
                          case 0:
                            obj.\u0001[index3] = data[index3, index2].R;
                            break;
                          case 1:
                            obj.\u0001[index3] = data[index3, index2].A;
                            break;
                        }
                      }
                    }
                  }
                  break;
                case \u0002.\u0004:
                  for (int index1 = 0; index1 < \u0005\u0081.\u007E\u0080\u001F((object) original); ++index1)
                  {
                    objArray2[index1] = new \u0017.\u0001();
                    objArray2[index1].\u0001 = new byte[\u0005\u0081.\u007E\u007F\u001F((object) original)];
                    for (int index2 = 0; index2 < \u0005\u0081.\u007E\u007F\u001F((object) original); ++index2)
                      objArray2[index1].\u0001[index2] = data[index2, index1].R;
                  }
                  break;
                default:
                  throw new NotSupportedException(\u0089\u001D.\u0083\u0093((object) \u0017.\u0001(99129), (object) format));
              }
            }
            else
            {
              objArray2 = new \u0017.\u0001[\u0005\u0081.\u007E\u0080\u001F((object) original)];
              Color[,] data = new Color[\u0005\u0081.\u007E\u007F\u001F((object) original), \u0005\u0081.\u007E\u0080\u001F((object) original)];
              \u0017.\u001D\u0005(original, data);
              for (int index1 = 0; index1 < \u0005\u0081.\u007E\u0080\u001F((object) original); ++index1)
              {
                objArray2[index1] = new \u0017.\u0001();
                objArray2[index1].\u0001 = new byte[\u0005\u0081.\u007E\u007F\u001F((object) original)];
                for (int index2 = 0; index2 < \u0005\u0081.\u007E\u007F\u001F((object) original); ++index2)
                  objArray2[index1].\u0001[index2] = data[index2, index1].A;
              }
            }
            foreach (\u0017.\u0001 tbl in objArray2)
              \u0017.\u001E\u0005((Stream) writer, tbl);
            \u0096\u001B.\u008E\u0092((Array) objArray2);
            long num4 = \u009E\u001D.\u007E\u0008\u009E((object) binaryWriter, 512, SeekOrigin.Begin);
            foreach (\u0017.\u0001 obj in objArray2)
              writer.\u001D\u0005(obj.\u0001);
            foreach (\u0017.\u0001 obj in objArray2)
              writer.\u001D\u0005(obj.\u0002);
          }
          finally
          {
            if (binaryWriter != null)
              \u001A\u001E.\u007E\u0094\u0092((object) binaryWriter);
          }
        }
        finally
        {
          if (writer != null)
            \u001A\u001E.\u007E\u0094\u0092((object) writer);
        }
      }
      finally
      {
        if (original != null)
          \u001A\u001E.\u007E\u0094\u0092((object) original);
      }
    }

    public static \u0002 \u001D\u0005(Stream data_stream)
    {
      \u0010 reader = new \u0010(data_stream);
      try
      {
        BinaryReader binaryReader = new BinaryReader((Stream) reader);
        try
        {
          int num1 = (int) reader.\u001D\u0005();
          int num2 = (int) \u0001\u0081.\u007E\u0096\u009D((object) binaryReader);
          int num3 = (int) \u0001\u0081.\u007E\u0096\u009D((object) binaryReader);
          short num4 = reader.\u001D\u0005();
          int num5 = (int) reader.\u001D\u0005();
          int num6 = (int) reader.\u001D\u0005();
          short num7 = reader.\u001D\u0005();
          switch (num4)
          {
            case 1:
            case 2:
              return \u0002.\u0004;
            case 3:
              switch (num7)
              {
                case 2:
                  return \u0002.\u0003;
                case 3:
                  return \u0002.\u0002;
                case 4:
                  return \u0002.\u0001;
                default:
                  throw new NotSupportedException(\u009E\u0081.\u001F\u0093(\u0017.\u0001(99162), (object) num7));
              }
            default:
              throw new NotSupportedException(\u009E\u0081.\u001F\u0093(\u0017.\u0001(99203), (object) num4));
          }
        }
        finally
        {
          if (binaryReader != null)
            \u001A\u001E.\u007E\u0094\u0092((object) binaryReader);
        }
      }
      finally
      {
        if (reader != null)
          \u001A\u001E.\u007E\u0094\u0092((object) reader);
      }
    }

    public static Bitmap \u001D\u0005(Stream data_stream)
    {
      \u0010 reader = new \u0010(data_stream);
      try
      {
        BinaryReader binaryReader = new BinaryReader((Stream) reader);
        try
        {
          int num1 = (int) reader.\u001D\u0005();
          byte num2 = \u0001\u0081.\u007E\u0096\u009D((object) binaryReader);
          int num3 = (int) \u0001\u0081.\u007E\u0096\u009D((object) binaryReader);
          short num4 = reader.\u001D\u0005();
          short num5 = reader.\u001D\u0005();
          short num6 = reader.\u001D\u0005();
          short num7 = reader.\u001D\u0005();
          reader.\u001D\u0005();
          reader.\u001D\u0005();
          reader.\u001D\u0005();
          byte[] numArray1 = \u0004\u0086.\u007E\u0003\u009E((object) binaryReader, 80);
          reader.\u001D\u0005();
          byte[] numArray2 = \u0004\u0086.\u007E\u0003\u009E((object) binaryReader, 404);
          int length = (int) num6 * (int) num7;
          \u0017.\u0001[] objArray = new \u0017.\u0001[length];
          int num8 = 0;
          int num9 = 0;
          if ((int) num2 == 1)
          {
            for (int index = 0; index < length; ++index)
            {
              objArray[index] = new \u0017.\u0001();
              objArray[index].\u0001 = reader.\u001D\u0005();
            }
            for (int index = 0; index < length; ++index)
              objArray[index].\u0002 = reader.\u001D\u0005();
            for (int index = 0; index < length; ++index)
              objArray[index].\u0001 = new byte[(int) num5];
            \u0096\u001B.\u008E\u0092((Array) objArray);
            if ((int) num4 == 1)
            {
              \u0017.\u001D\u0005((Stream) reader, objArray[0]);
            }
            else
            {
              if ((int) num4 != 2 && (int) num4 != 3)
                throw new InvalidDataException(\u0017.\u0001(99252));
              foreach (\u0017.\u0001 tbl in objArray)
              {
                \u0017.\u001D\u0005((Stream) reader, tbl);
                ++num8;
              }
            }
          }
          \u001D.\u0015[,] data = new \u001D.\u0015[(int) num5, (int) num6];
          int index1 = 0;
          int index2 = 0;
          bool flag;
          if ((int) num4 == 3)
          {
            switch (num7)
            {
              case 2:
                flag = true;
                for (int index3 = 0; index3 < (int) num7; ++index3)
                {
                  int num10 = (int) num6 * index3;
                  int index4 = 0;
                  int index5 = 0;
                  for (int index6 = num10; index6 < num10 + (int) num6; ++index6)
                  {
                    foreach (byte num11 in objArray[index6].\u0001)
                    {
                      switch (index3)
                      {
                        case 0:
                          data[index4, index5].A = num11;
                          break;
                        case 1:
                          data[index4, index5].R = num11;
                          data[index4, index5].G = num11;
                          data[index4, index5].B = num11;
                          break;
                      }
                      ++index4;
                    }
                    index4 = 0;
                    ++index5;
                  }
                }
                break;
              case 3:
              case 4:
                flag = (int) num7 == 4;
                for (int index3 = (int) num7 - 1; index3 >= 0; --index3)
                {
                  int num10 = (int) num6 * ((int) num7 - index3 - 1);
                  int index4 = 0;
                  int index5 = 0;
                  for (int index6 = num10; index6 < num10 + (int) num6; ++index6)
                  {
                    foreach (byte num11 in objArray[index6].\u0001)
                    {
                      switch (index3)
                      {
                        case 0:
                          data[index4, index5].R = num11;
                          break;
                        case 1:
                          data[index4, index5].G = num11;
                          break;
                        case 2:
                          data[index4, index5].B = num11;
                          break;
                        case 3:
                          data[index4, index5].A = num11;
                          break;
                      }
                      ++index4;
                    }
                    index4 = 0;
                    ++index5;
                  }
                }
                break;
              default:
                throw new NotSupportedException(\u009E\u0081.\u001F\u0093(\u0017.\u0001(99162), (object) num7));
            }
          }
          else
          {
            flag = true;
            foreach (\u0017.\u0001 obj in objArray)
            {
              foreach (byte num10 in obj.\u0001)
              {
                data[index1, index2].R = num10;
                data[index1, index2].G = num10;
                data[index1, index2].B = num10;
                data[index1, index2].A = num10;
                ++index1;
              }
              index1 = 0;
              ++index2;
            }
          }
          num9 = 0;
          Bitmap bmp = (Bitmap) null;
          try
          {
            bmp = !flag ? new Bitmap((int) num5, (int) num6, PixelFormat.Format32bppRgb) : new Bitmap((int) num5, (int) num6, PixelFormat.Format32bppArgb);
            \u0017.\u001D\u0005(bmp, data);
            return bmp;
          }
          catch
          {
            if (bmp != null)
              \u001A\u001E.\u007E\u001D\u001F((object) bmp);
            throw;
          }
        }
        finally
        {
          if (binaryReader != null)
            \u001A\u001E.\u007E\u0094\u0092((object) binaryReader);
        }
      }
      finally
      {
        if (reader != null)
          \u001A\u001E.\u007E\u0094\u0092((object) reader);
      }
    }

    private static unsafe void \u001D\u0005(Bitmap bmp, \u001D.\u0015[,] data)
    {
      \u0015.\u0082 owner = new \u0015.\u0082(bmp);
      try
      {
        \u0015.\u0082.\u0002 obj = new \u0015.\u0082.\u0002(owner);
        try
        {
          \u001D.\u0015[,] objArray;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          fixed (\u001D.\u0015* objPtr1 = &^((objArray = data) == null || \u0005\u0081.\u007E\u0089\u0092((object) objArray) == 0 ? (\u001D.\u0015&) IntPtr.Zero : objArray.Address(0, 0)))
          {
            \u001D.\u0015* objPtr2 = objPtr1;
            \u001D.\u0015* pBase = owner.pBase;
            for (int index = 0; index < \u0005\u0081.\u007E\u007F\u001F((object) bmp) * \u0005\u0081.\u007E\u0080\u001F((object) bmp); ++index)
            {
              *pBase = *objPtr2;
              ++pBase;
              ++objPtr2;
            }
          }
        }
        finally
        {
          if (obj != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj);
        }
      }
      finally
      {
        if (owner != null)
          \u001A\u001E.\u007E\u0094\u0092((object) owner);
      }
    }

    private static unsafe void \u001E\u0005(Bitmap original, \u001D.\u0015[,] data)
    {
      int num1 = \u0005\u0081.\u007E\u007F\u001F((object) original);
      int num2 = \u0005\u0081.\u007E\u0080\u001F((object) original);
      \u0015.\u0082 owner = new \u0015.\u0082(original);
      try
      {
        \u0015.\u0082.\u0002 obj = new \u0015.\u0082.\u0002(owner);
        try
        {
          \u001D.\u0015* pBase = owner.pBase;
          for (int index1 = 0; index1 < num2; ++index1)
          {
            for (int index2 = 0; index2 < num1; ++index2)
            {
              data[index2, index1] = *pBase;
              ++pBase;
            }
          }
        }
        finally
        {
          if (obj != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj);
        }
      }
      finally
      {
        if (owner != null)
          \u001A\u001E.\u007E\u0094\u0092((object) owner);
      }
    }

    private static unsafe void \u001D\u0005(Bitmap original, Color[,] data)
    {
      int num1 = \u0005\u0081.\u007E\u007F\u001F((object) original);
      int num2 = \u0005\u0081.\u007E\u0080\u001F((object) original);
      \u0015.\u0082 owner = new \u0015.\u0082(original);
      try
      {
        \u0015.\u0082.\u0002 obj = new \u0015.\u0082.\u0002(owner);
        try
        {
          \u001D.\u0015* pBase = owner.pBase;
          for (int index1 = 0; index1 < num2; ++index1)
          {
            for (int index2 = 0; index2 < num1; ++index2)
            {
              data[index2, index1] = \u001D.\u0015.\u001D\u0005(*pBase);
              ++pBase;
            }
          }
        }
        finally
        {
          if (obj != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj);
        }
      }
      finally
      {
        if (owner != null)
          \u001A\u001E.\u007E\u0094\u0092((object) owner);
      }
    }

    private static void \u001D\u0005(Stream reader, \u0017.\u0001 tbl)
    {
      \u0012\u0080.\u007E\u0082\u009D((object) reader, (long) tbl.\u0001);
      int index = 0;
label_1:
      int num1 = \u0005\u0081.\u007E\u008E\u009D((object) reader);
      int num2 = num1 & (int) sbyte.MaxValue;
      if (num2 == 0)
        return;
      if ((num1 & 128) > 0)
      {
        while (num2 > 0)
        {
          byte num3 = (byte) \u0005\u0081.\u007E\u008E\u009D((object) reader);
          tbl.\u0001[index] = num3;
          --num2;
          ++index;
        }
        goto label_1;
      }
      else
      {
        byte num3 = (byte) \u0005\u0081.\u007E\u008E\u009D((object) reader);
        while (num2 > 0)
        {
          tbl.\u0001[index] = num3;
          --num2;
          ++index;
        }
        goto label_1;
      }
    }

    private static void \u001E\u0005(Stream writer, \u0017.\u0001 tbl)
    {
      tbl.\u0001 = (int) \u001F\u001E.\u007E\u0081\u009D((object) writer);
      int index1 = 0;
      while (index1 != tbl.\u0001.Length)
      {
        byte num1 = tbl.\u0001[index1];
        int num2 = 1;
        for (int index2 = index1 + 1; index2 - index1 < (int) sbyte.MaxValue && index2 < tbl.\u0001.Length && (int) tbl.\u0001[index2] == (int) num1; ++index2)
          ++num2;
        int num3 = 1;
        int index3 = index1 + 1;
        while (index3 - index1 < (int) sbyte.MaxValue && index3 + 1 < tbl.\u0001.Length && (int) tbl.\u0001[index3] != (int) tbl.\u0001[index3 + 1])
        {
          ++num3;
          index3 += 2;
        }
        if (num3 > 1)
        {
          \u0095\u001F.\u007E\u0090\u009D((object) writer, (byte) (128 + num3));
          ++tbl.\u0002;
          for (int index2 = index1; index2 < index1 + num3; ++index2)
          {
            \u0095\u001F.\u007E\u0090\u009D((object) writer, tbl.\u0001[index2]);
            ++tbl.\u0002;
          }
          index1 += num3;
        }
        else
        {
          \u0095\u001F.\u007E\u0090\u009D((object) writer, (byte) num2);
          ++tbl.\u0002;
          \u0095\u001F.\u007E\u0090\u009D((object) writer, num1);
          ++tbl.\u0002;
          index1 += num2;
        }
      }
      \u0095\u001F.\u007E\u0090\u009D((object) writer, (byte) 0);
      ++tbl.\u0002;
    }

    private sealed class \u0001
    {
      public int \u0001;
      public int \u0002;
      public byte[] \u0001;
    }
  }
}
