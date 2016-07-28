// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0015;
using \u0019;
using \u001B;
using \u001D;
using \u0084;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace \u001B
{
  internal sealed class \u0005<ColorType> : \u0080 where ColorType : \u0013
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private readonly System.Type \u0001;
    private readonly bool \u0001;
    private Size \u0001;
    private Array \u0001;
    private Rectangle \u0001;
    private int \u0001;
    private int[][] \u0001;

    protected override int? Version
    {
      get
      {
        return new int?(1);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override int MinimumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override byte[] Header
    {
      get
      {
        return new byte[3]{ (byte) 74, (byte) 66, (byte) 83 };
      }
    }

    public Size OriginalSize
    {
      get
      {
        return (Size) this.\u0001;
      }
    }

    public Rectangle Bounds
    {
      get
      {
        return (Rectangle) this.\u0001;
      }
    }

    static \u0005()
    {
      \u0004.\u001D\u0005(typeof (\u0005<>));
      \u0005<ColorType>.\u0001 = (\u0002) \u0006.\u001D\u0005(51475);
      \u0005<ColorType>.\u0002 = \u0006.\u001D\u0005(51512);
    }

    public \u0005(\u0082 alpha_bitmap, \u0082 color_bitmap)
    {
      this.\u0001 = (\u0002) typeof (ColorType);
      this.\u0001 = (\u0002) (typeof (ColorType) == typeof (\u001D.\u0015) ? 1 : 0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.\u0001 = (\u0002) alpha_bitmap.Size;
      \u0082.\u0002 obj1 = new \u0082.\u0002(alpha_bitmap);
      try
      {
        \u0082.\u0002 obj2 = new \u0082.\u0002(color_bitmap);
        try
        {
          this.\u001D\u0005(alpha_bitmap, color_bitmap);
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
      this.\u001D\u0005();
    }

    public \u0005(Stream stream)
    {
      this.\u0001 = (\u0002) typeof (ColorType);
      this.\u0001 = (\u0002) (typeof (ColorType) == typeof (\u001D.\u0015) ? 1 : 0);
      // ISSUE: explicit constructor call
      base.\u002Ector(stream);
    }

    public \u0005(string fileName)
    {
      this.\u0001 = (\u0002) typeof (ColorType);
      this.\u0001 = (\u0002) (typeof (ColorType) == typeof (\u001D.\u0015) ? 1 : 0);
      // ISSUE: explicit constructor call
      base.\u002Ector(fileName);
    }

    private void \u001D\u0005()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0005<ColorType>.\u0002 obj = new \u0005<ColorType>.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = (Exception) this;
      this.\u0001 = (\u0002) new int[this.\u0001.Height][];
      int maxStackSize = 1048576 + this.\u0001.Height * this.\u0001.Width;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = (Exception) null;
      // ISSUE: reference to a compiler-generated method
      Thread thread = new Thread(new ThreadStart(obj.\u001D\u0005), maxStackSize);
      \u0099\u001F.\u007E\u0091\u0098((object) thread, true);
      \u001A\u001E.\u007E\u008A\u0098((object) thread);
      \u001A\u001E.\u007E\u008D\u0098((object) thread);
      // ISSUE: reference to a compiler-generated field
      if (obj.\u0001 != null)
      {
        // ISSUE: reference to a compiler-generated field
        throw obj.\u0001;
      }
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      // ISSUE: unable to decompile the method.
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      writer.\u001D\u0005((Size) this.\u0001);
      if (this.\u0001 == null)
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, false);
      }
      else
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, true);
        \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.\u0001.Left);
        \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.\u0001.Top);
        \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.\u0001.Right);
        \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.\u0001.Bottom);
        IEnumerator enumerator1 = \u0015\u0082.\u007E\u008D\u0092((object) this.\u0001);
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator1))
          {
            Array[] arrayArray = (Array[]) \u0005\u007F.\u007E\u0092\u0092((object) enumerator1);
            \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) arrayArray.Length);
            foreach (Array array in arrayArray)
            {
              \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) \u0096\u0081.\u007E\u008B\u0092((object) array, 0));
              \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) \u0005\u0081.\u007E\u0089\u0092((object) array));
              if (this.\u0001 != null)
              {
                IEnumerator enumerator2 = \u0015\u0082.\u007E\u008D\u0092((object) array);
                try
                {
                  while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator2))
                  {
                    \u001D.\u0015 color = (\u001D.\u0015) \u0005\u007F.\u007E\u0092\u0092((object) enumerator2);
                    writer.\u001D\u0005(color);
                  }
                }
                finally
                {
                  IDisposable disposable = enumerator2 as IDisposable;
                  if (disposable != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) disposable);
                }
              }
              else
              {
                IEnumerator enumerator2 = \u0015\u0082.\u007E\u008D\u0092((object) array);
                try
                {
                  while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator2))
                  {
                    \u0002 color = (\u0002) \u0005\u007F.\u007E\u0092\u0092((object) enumerator2);
                    writer.\u001D\u0005(color);
                  }
                }
                finally
                {
                  IDisposable disposable = enumerator2 as IDisposable;
                  if (disposable != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) disposable);
                }
              }
            }
          }
        }
        finally
        {
          IDisposable disposable = enumerator1 as IDisposable;
          if (disposable != null)
            \u001A\u001E.\u007E\u0094\u0092((object) disposable);
        }
      }
      base.\u001D\u0005(writer);
    }

    public unsafe Bitmap \u001D\u0005(Color? replaceColor = null)
    {
      Bitmap source = (Bitmap) null;
      try
      {
        source = new Bitmap(this.\u0001.Width, this.\u0001.Height);
        if (this.\u0001 != null)
          goto label_27;
label_26:
        return source;
label_27:
        \u0082 owner = new \u0082(source);
        try
        {
          \u0082.\u0002 obj1 = new \u0082.\u0002(owner);
          try
          {
            for (int top = this.\u0001.Top; top < this.\u0001.Bottom; ++top)
            {
              Array[] arrayArray = (Array[]) \u009F\u007F.\u007E\u0087\u0092((object) this.\u0001, top);
              for (short index1 = 0; (int) index1 < arrayArray.Length; ++index1)
              {
                Array array = (Array) \u009F\u007F.\u007E\u0087\u0092((object) arrayArray, (int) index1);
                int num1 = \u0096\u0081.\u007E\u008B\u0092((object) array, 0);
                int num2 = num1 + \u0005\u0081.\u007E\u0089\u0092((object) array) - 1;
                \u001D.\u0015* objPtr = owner.pBase + top * this.\u0001.Width + num1 + this.\u0001.Left;
                if (replaceColor.HasValue)
                {
                  \u001D.\u0015 obj2 = \u001D.\u0015.\u001D\u0005(replaceColor.Value);
                  for (int index2 = num1; index2 <= num2; ++index2)
                  {
                    *objPtr = obj2;
                    ++objPtr;
                  }
                }
                else if (this.\u0001 != null)
                {
                  for (int index2 = num1; index2 <= num2; ++index2)
                  {
                    *objPtr = (\u001D.\u0015) \u009F\u007F.\u007E\u0087\u0092((object) array, index2);
                    ++objPtr;
                  }
                }
                else
                {
                  for (int index2 = num1; index2 <= num2; ++index2)
                  {
                    *objPtr = \u001D.\u0015.\u001D\u0005((\u0002) \u009F\u007F.\u007E\u0087\u0092((object) array, index2));
                    ++objPtr;
                  }
                }
              }
            }
            goto label_26;
          }
          finally
          {
            if (obj1 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj1);
          }
        }
        finally
        {
          if (owner != null)
            \u001A\u001E.\u007E\u0094\u0092((object) owner);
        }
      }
      catch
      {
        if (source != null)
          \u001A\u001E.\u007E\u001D\u001F((object) source);
        throw;
      }
    }

    private void \u001D\u0005(\u0082 alpha_bitmap, \u0082 color_bitmap = null)
    {
      \u001D.\u0015[,] colors = alpha_bitmap.Colors;
      \u001D.\u0015[,] color_data = color_bitmap == null ? colors : color_bitmap.Colors;
      this.\u0001 = (\u0002) 0;
      short result1;
      short result2;
      short result3;
      short result4;
      if (!\u0005<ColorType>.\u001D\u0005(colors, (Size) this.\u0001, FlowDirection.LeftToRight, out result1) || (!\u0005<ColorType>.\u001D\u0005(colors, (Size) this.\u0001, FlowDirection.TopDown, out result2) || !\u0005<ColorType>.\u001D\u0005(colors, (Size) this.\u0001, FlowDirection.RightToLeft, out result3)) || !\u0005<ColorType>.\u001D\u0005(colors, (Size) this.\u0001, FlowDirection.BottomUp, out result4))
      {
        this.\u0001 = (\u0002) null;
      }
      else
      {
        this.\u0001 = (\u0002) \u0081\u0084.\u0082\u0080((int) result1, (int) result2, (int) result3 + 1, (int) result4 + 1);
        // ISSUE: type reference
        this.\u0001 = (\u0002) \u0006\u001E.\u0082\u0092(\u009C\u0082.\u0016\u0097(__typeref (Array[])), new int[1]
        {
          this.\u0001.Height
        }, new int[1]{ this.\u0001.Top });
        for (short y = result2; (int) y < this.\u0001.Bottom; ++y)
          \u001B\u0083.\u007E\u0088\u0092((object) this.\u0001, (object) this.\u001D\u0005(colors, color_data, result1, result3, y), (int) y);
      }
    }

    private Array[] \u001D\u0005(\u001D.\u0015[,] pixels, \u001D.\u0015[,] color_data, short left, short right, short y)
    {
      // ISSUE: unable to decompile the method.
    }

    private static bool \u001D\u0005(\u001D.\u0015[,] pixels, ref short left, short right, int y)
    {
      while ((int) left <= (int) right)
      {
        if ((int) pixels[(int) left, y].A != 0)
          return true;
        ++left;
      }
      return false;
    }

    private static void \u001D\u0005(\u001D.\u0015[,] pixels, ref short left, short right, short y)
    {
      while ((int) left <= (int) right && (int) pixels[(int) left, (int) y].A != 0)
        ++left;
      --left;
    }

    private static bool \u001D\u0005(\u001D.\u0015[,] pixels, Size sz, FlowDirection direction, out short result)
    {
      switch (direction)
      {
        case FlowDirection.LeftToRight:
          for (short index1 = 0; (int) index1 < sz.Width; ++index1)
          {
            for (short index2 = 0; (int) index2 < sz.Height; ++index2)
            {
              if ((int) pixels[(int) index1, (int) index2].A > 0)
              {
                result = index1;
                return true;
              }
            }
          }
          break;
        case FlowDirection.TopDown:
          for (short index1 = 0; (int) index1 < sz.Height; ++index1)
          {
            for (short index2 = 0; (int) index2 < sz.Width; ++index2)
            {
              if ((int) pixels[(int) index2, (int) index1].A > 0)
              {
                result = index1;
                return true;
              }
            }
          }
          break;
        case FlowDirection.RightToLeft:
          for (short index1 = (short) (sz.Width - 1); (int) index1 >= 0; --index1)
          {
            for (short index2 = 0; (int) index2 < sz.Height; ++index2)
            {
              if ((int) pixels[(int) index1, (int) index2].A > 0)
              {
                result = index1;
                return true;
              }
            }
          }
          break;
        case FlowDirection.BottomUp:
          for (short index1 = (short) (sz.Height - 1); (int) index1 >= 0; --index1)
          {
            for (short index2 = 0; (int) index2 < sz.Width; ++index2)
            {
              if ((int) pixels[(int) index2, (int) index1].A > 0)
              {
                result = index1;
                return true;
              }
            }
          }
          break;
      }
      result = (short) 0;
      return false;
    }

    public Rectangle[] \u001D\u0005(Bitmap bmp, Size minimum_size, Size maximum_size, CancellationToken token)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0005<ColorType>.\u0003 obj = new \u0005<ColorType>.\u0003();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = (List<Rectangle>) bmp;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = (List<Rectangle>) minimum_size;
      // ISSUE: reference to a compiler-generated field
      obj.\u0002 = maximum_size;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = (List<Rectangle>) token;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = (List<Rectangle>) this;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001.ThrowIfCancellationRequested();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = new List<Rectangle>();
      int maxStackSize = 1048576 + this.\u0001.Height * this.\u0001.Width * 2;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = (List<Rectangle>) null;
      // ISSUE: reference to a compiler-generated method
      Thread thread = new Thread(new ThreadStart(obj.\u001D\u0005), maxStackSize);
      \u0099\u001F.\u007E\u0091\u0098((object) thread, true);
      \u001A\u001E.\u007E\u008A\u0098((object) thread);
      \u001A\u001E.\u007E\u008D\u0098((object) thread);
      // ISSUE: reference to a compiler-generated field
      if (obj.\u0001 != null)
      {
        // ISSUE: reference to a compiler-generated field
        throw obj.\u0001;
      }
      // ISSUE: reference to a compiler-generated field
      obj.\u0001.ThrowIfCancellationRequested();
      // ISSUE: reference to a compiler-generated field
      return obj.\u0001.ToArray();
    }

    private unsafe \u0008 \u001D\u0005(bool* start_pixel, int x_start, int y_start)
    {
      \u0008 obj1 = new \u0008(x_start, y_start, x_start, y_start);
      \u0005<ColorType>.\u0001 obj2 = \u0005<ColorType>.\u0001.\u0001;
      \u0005<ColorType>.\u0001 obj3 = obj2;
      int num1 = x_start;
      int num2 = y_start;
      bool* flagPtr = start_pixel;
      \u0008* objPtr = &obj1;
      do
      {
        switch (obj3)
        {
          case \u0005<ColorType>.\u0001.\u0001:
            if (num2 > 0 && *(flagPtr - this.\u0001.Width))
            {
              --num2;
              flagPtr -= this.\u0001.Width;
              obj3 = \u0005<ColorType>.\u0001.\u0004;
              if (objPtr->\u0002 > num2)
              {
                objPtr->\u0002 = num2;
                break;
              }
              break;
            }
            if (num1 + 1 < this.\u0001.Width && flagPtr[1])
            {
              ++num1;
              ++flagPtr;
              if (objPtr->\u0003 < num1)
              {
                objPtr->\u0003 = num1;
                break;
              }
              break;
            }
            obj3 = \u0005<ColorType>.\u0001.\u0003;
            break;
          case \u0005<ColorType>.\u0001.\u0002:
            if (num2 + 1 < this.\u0001.Height && flagPtr[this.\u0001.Width])
            {
              ++num2;
              flagPtr += this.\u0001.Width;
              obj3 = \u0005<ColorType>.\u0001.\u0003;
              if (objPtr->\u0004 < num2)
              {
                objPtr->\u0004 = num2;
                break;
              }
              break;
            }
            if (num1 > 0 && *(flagPtr - 1))
            {
              --num1;
              --flagPtr;
              if (objPtr->\u0001 > num1)
              {
                objPtr->\u0001 = num1;
                break;
              }
              break;
            }
            obj3 = \u0005<ColorType>.\u0001.\u0004;
            break;
          case \u0005<ColorType>.\u0001.\u0003:
            if (num1 + 1 < this.\u0001.Width && flagPtr[1])
            {
              ++num1;
              ++flagPtr;
              obj3 = \u0005<ColorType>.\u0001.\u0001;
              if (objPtr->\u0003 < num1)
              {
                objPtr->\u0003 = num1;
                break;
              }
              break;
            }
            if (num2 + 1 < this.\u0001.Height && flagPtr[this.\u0001.Width])
            {
              ++num2;
              flagPtr += this.\u0001.Width;
              if (objPtr->\u0004 < num2)
              {
                objPtr->\u0004 = num2;
                break;
              }
              break;
            }
            obj3 = \u0005<ColorType>.\u0001.\u0002;
            break;
          case \u0005<ColorType>.\u0001.\u0004:
            if (num1 > 0 && *(flagPtr - 1))
            {
              --num1;
              --flagPtr;
              obj3 = \u0005<ColorType>.\u0001.\u0002;
              if (objPtr->\u0001 > num1)
              {
                objPtr->\u0001 = num1;
                break;
              }
              break;
            }
            if (num2 > 0 && *(flagPtr - this.\u0001.Width))
            {
              --num2;
              flagPtr -= this.\u0001.Width;
              if (objPtr->\u0002 > num2)
              {
                objPtr->\u0002 = num2;
                break;
              }
              break;
            }
            obj3 = \u0005<ColorType>.\u0001.\u0001;
            break;
        }
      }
      while (obj2 != obj3 || start_pixel != flagPtr);
      return obj1;
    }

    public bool \u001D\u0005(Bitmap bmp, float minimum_percent)
    {
      // ISSUE: unable to decompile the method.
    }

    private enum \u0001
    {
      \u0001,
      \u0002,
      \u0003,
      \u0004,
    }
  }
}
