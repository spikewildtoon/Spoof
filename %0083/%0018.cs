// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0081;
using \u0083;
using \u0084;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace \u0083
{
  internal sealed class \u0018 : \u0016
  {
    private readonly object \u0001 = new object();
    [NonSerialized]
    internal static \u0002 \u0001;
    private Dictionary<Size, \u0018> \u0001;
    private readonly \u0015.\u0082 \u0001;
    public readonly Size \u0001;

    public Bitmap GetBitmap
    {
      get
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
          Bitmap bitmap = (Bitmap) null;
          try
          {
            bitmap = new Bitmap(this.\u0001.Size.Width, this.\u0001.Size.Height);
            this.\u0001.\u0082\u0005();
            Graphics graphics = \u0005\u0087.\u001D\u007F((Image) bitmap);
            try
            {
              \u0004\u001F.\u007E\u009E\u007F((object) graphics, (Image) this.\u0001.BaseBitmap, new Rectangle(Point.Empty, this.\u0001.Size));
            }
            finally
            {
              if (graphics != null)
                \u001A\u001E.\u007E\u0094\u0092((object) graphics);
            }
            return bitmap;
          }
          catch
          {
            if (bitmap != null)
              \u001A\u001E.\u007E\u001D\u001F((object) bitmap);
            throw;
          }
          finally
          {
            this.\u0001.\u0081\u0005();
          }
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
    }

    public unsafe \u0002[] GetPixels
    {
      get
      {
        \u0002[] objArray = new \u0002[this.\u0001.Width * this.\u0001.Height];
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
          \u001D.\u0015* pBase = this.\u0001.pBase;
          fixed (\u0002* objPtr1 = objArray)
          {
            \u0002* objPtr2 = objPtr1;
            for (int index = 0; index < this.\u0001.Width * this.\u0001.Height; ++index)
            {
              *objPtr2 = \u0002.\u001D\u0005(*pBase);
              ++pBase;
              ++objPtr2;
            }
          }
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
        return objArray;
      }
    }

    static \u0018()
    {
      \u0004.\u001D\u0005(typeof (\u0018));
    }

    private \u0018()
    {
      this.\u0001 = new Dictionary<Size, \u0018>();
    }

    public \u0018(\u0015.\u0082 bmp)
      : this()
    {
      this.\u0001 = bmp.Size;
      this.\u0001 = bmp;
      this.\u0001.\u0081\u0005();
    }

    public \u0018(Bitmap bmp, bool ownsBitmap)
      : this()
    {
      this.\u0001 = \u0083\u001E.\u007E\u001F\u001F((object) bmp);
      this.\u0001 = new \u0015.\u0082(bmp, ownsBitmap);
      this.\u0001.\u0081\u0005();
    }

    public unsafe \u0018(\u0002[] pixels, Size sz)
      : this()
    {
      if (pixels == null)
        throw new ArgumentNullException(\u0018.\u0001(103029));
      this.\u0001 = sz;
      this.\u0001 = new \u0015.\u0082(sz);
      this.\u0001.\u0081\u0005();
      \u001D.\u0015* pBase = this.\u0001.pBase;
      fixed (\u0002* objPtr1 = pixels)
      {
        \u0002* objPtr2 = objPtr1;
        for (int index = 0; index < sz.Width * sz.Height; ++index)
        {
          *pBase = \u001D.\u0015.\u001D\u0005(*objPtr2);
          ++pBase;
          ++objPtr2;
        }
      }
    }

    protected override void \u001D\u0005()
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        this.\u0001.Dispose();
        this.\u0081\u0005();
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
      base.\u001D\u0005();
    }

    public void \u0081\u0005()
    {
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = this.\u0001, ref flag);
        foreach (\u0016 obj2 in this.\u0001.Values)
          obj2.Dispose();
        this.\u0001.Clear();
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    public static unsafe bool \u001D\u0005(\u0018 source, \u0013 sourceRatio, \u0018 value, \u0013 valueRatio, int max_diff, out Point location)
    {
      int num1 = (int) ((double) source.\u0001.Width / sourceRatio.\u0003);
      int num2 = (int) ((double) source.\u0001.Height / sourceRatio.\u0004);
      int num3 = (int) ((double) value.\u0001.Width / valueRatio.\u0003);
      int num4 = (int) ((double) value.\u0001.Height / valueRatio.\u0004);
      int num5 = num1 <= num3 ? num1 : num3;
      int num6 = num2 <= num4 ? num2 : num4;
      Size sz1 = new Size((int) \u0007\u0081.\u0096\u0096(sourceRatio.\u0003 * (double) num5), (int) \u0007\u0081.\u0096\u0096(sourceRatio.\u0004 * (double) num6));
      Size sz2 = new Size((int) \u0007\u0081.\u0096\u0096(valueRatio.\u0003 * (double) num5), (int) \u0007\u0081.\u0096\u0096(valueRatio.\u0004 * (double) num6));
      if (sz2.Width > sz1.Width || sz2.Height > sz1.Height)
      {
        location = Point.Empty;
        return false;
      }
      \u0018 obj1 = source.\u001D\u0005(sz1);
      \u0018 obj2 = value.\u001D\u0005(sz2);
      bool flag1 = false;
      object obj3;
      try
      {
        \u0098\u0082.\u0081\u0098(obj3 = obj1.\u0001, ref flag1);
        bool flag2 = false;
        object obj4;
        try
        {
          \u0098\u0082.\u0081\u0098(obj4 = obj2.\u0001, ref flag2);
          \u001D.\u0015* pBase1 = obj1.\u0001.pBase;
          \u001D.\u0015* pBase2 = obj2.\u0001.pBase;
          Decimal num7 = \u000E\u0081.\u0089\u0095(\u0084\u001C.\u0083\u0095(sz2.Width * sz2.Height), new Decimal(3));
          for (int index1 = 0; index1 < sz1.Height - sz2.Height; ++index1)
          {
            for (int index2 = 0; index2 < sz1.Width - sz2.Width; ++index2)
            {
              \u001D.\u0015* objPtr1 = pBase2;
              uint num8 = 0;
              int num9 = index2 + sz2.Width;
              for (int index3 = index1; index3 < index1 + sz2.Height; ++index3)
              {
                \u001D.\u0015* objPtr2 = pBase1 + index3 * sz1.Width + index2;
                for (int index4 = index2; index4 < num9; ++index4)
                {
                  // ISSUE: explicit non-virtual call
                  // ISSUE: explicit non-virtual call
                  // ISSUE: explicit non-virtual call
                  // ISSUE: explicit non-virtual call
                  // ISSUE: explicit non-virtual call
                  // ISSUE: explicit non-virtual call
                  num8 = num8 + \u0082.\u0001.\u001D\u0005((int) __nonvirtual (objPtr2->R), (int) __nonvirtual (objPtr1->R)) + \u0082.\u0001.\u001D\u0005((int) __nonvirtual (objPtr2->G), (int) __nonvirtual (objPtr1->G)) + \u0082.\u0001.\u001D\u0005((int) __nonvirtual (objPtr2->B), (int) __nonvirtual (objPtr1->B));
                  ++objPtr2;
                  ++objPtr1;
                }
                if (\u009F\u001B.\u008D\u0095(\u000E\u0081.\u008A\u0095(\u009E\u0084.\u0084\u0095(num8), num7), \u0084\u001C.\u0083\u0095(max_diff)))
                  break;
              }
              if (\u009F\u001B.\u008C\u0095(\u000E\u0081.\u008A\u0095(\u009E\u0084.\u0084\u0095(num8), num7), \u0084\u001C.\u0083\u0095(max_diff)))
              {
                location = new Point((int) \u0007\u0081.\u0096\u0096((double) index2 / (double) sz1.Width * (double) source.\u0001.Width), (int) \u0007\u0081.\u0096\u0096((double) index1 / (double) sz1.Height * (double) source.\u0001.Height));
                return true;
              }
            }
          }
        }
        finally
        {
          if (flag2)
            \u001A\u001E.\u0082\u0098(obj4);
        }
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj3);
      }
      location = Point.Empty;
      return false;
    }

    public static bool \u001D\u0005(\u0018 left, \u0018 right, int max_diff)
    {
      if (\u0010\u007F.\u0006\u0081(left.\u0001, right.\u0001))
        goto label_39;
label_1:
      int num1 = 1;
      int num2 = \u0018.\u001D\u0005(left, right, 0, 0);
      if (num2 <= max_diff)
        return true;
      bool flag1 = left.\u0001.Width > num1;
      bool flag2 = left.\u0001.Height > num1;
      if (flag1)
      {
        int num3;
        if ((num3 = \u0018.\u001D\u0005(left, right, -num1, 0)) < num2)
          num2 = num3;
        if (num2 <= max_diff)
          return true;
        int num4;
        if ((num4 = \u0018.\u001D\u0005(left, right, num1, 0)) < num2)
          num2 = num4;
        if (num2 <= max_diff)
          return true;
      }
      if (flag1 && flag2)
      {
        int num3;
        if ((num3 = \u0018.\u001D\u0005(left, right, -num1, num1)) < num2)
          num2 = num3;
        if (num2 <= max_diff)
          return true;
        int num4;
        if ((num4 = \u0018.\u001D\u0005(left, right, -num1, -num1)) < num2)
          num2 = num4;
        if (num2 <= max_diff)
          return true;
        int num5;
        if ((num5 = \u0018.\u001D\u0005(left, right, num1, num1)) < num2)
          num2 = num5;
        if (num2 <= max_diff)
          return true;
        int num6;
        if ((num6 = \u0018.\u001D\u0005(left, right, num1, -num1)) < num2)
          num2 = num6;
        if (num2 <= max_diff)
          return true;
      }
      if (flag2)
      {
        int num3;
        if ((num3 = \u0018.\u001D\u0005(left, right, 0, -num1)) < num2)
          num2 = num3;
        if (num2 <= max_diff)
          return true;
        int num4;
        if ((num4 = \u0018.\u001D\u0005(left, right, 0, num1)) < num2)
          num2 = num4;
        if (num2 <= max_diff)
          return true;
      }
      return false;
label_39:
      Size size1 = left.\u0001;
      int width = \u0099\u0081.\u009F\u0096(size1.Width, right.\u0001.Width);
      Size size2 = left.\u0001;
      int height = \u0099\u0081.\u009F\u0096(size2.Width, right.\u0001.Height);
      Size sz = new Size(width, height);
      left = left.\u001D\u0005(sz);
      right = right.\u001D\u0005(sz);
      goto label_1;
    }

    public static unsafe int \u001D\u0005(\u0018 left, \u0018 right, int x_pixel_offset, int y_pixel_offset)
    {
      bool flag1 = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = right.\u0001, ref flag1);
        bool flag2 = false;
        object obj2;
        try
        {
          \u0098\u0082.\u0081\u0098(obj2 = left.\u0001, ref flag2);
          uint num1 = 0;
          Size size = left.\u0001;
          \u001D.\u0015* pBase1 = left.\u0001.pBase;
          \u001D.\u0015* pBase2 = right.\u0001.pBase;
          int num2;
          int num3;
          if (x_pixel_offset > 0)
          {
            num2 = x_pixel_offset;
            num3 = 0;
          }
          else
          {
            x_pixel_offset = \u000F\u0081.\u009B\u0096(x_pixel_offset);
            num3 = x_pixel_offset;
            num2 = 0;
          }
          int num4;
          int num5;
          if (y_pixel_offset > 0)
          {
            num4 = y_pixel_offset;
            num5 = 0;
          }
          else
          {
            y_pixel_offset = \u000F\u0081.\u009B\u0096(y_pixel_offset);
            num5 = y_pixel_offset;
            num4 = 0;
          }
          int num6 = y_pixel_offset;
          while (num6 < size.Height)
          {
            \u001D.\u0015* objPtr1 = pBase1 + num4 * size.Width + num2;
            \u001D.\u0015* objPtr2 = pBase2 + num5 * size.Width + num3;
            for (int index = x_pixel_offset; index < size.Width; ++index)
            {
              // ISSUE: explicit non-virtual call
              // ISSUE: explicit non-virtual call
              // ISSUE: explicit non-virtual call
              // ISSUE: explicit non-virtual call
              // ISSUE: explicit non-virtual call
              // ISSUE: explicit non-virtual call
              num1 = num1 + \u0082.\u0001.\u001D\u0005((int) __nonvirtual (objPtr1->R), (int) __nonvirtual (objPtr2->R)) + \u0082.\u0001.\u001D\u0005((int) __nonvirtual (objPtr1->G), (int) __nonvirtual (objPtr2->G)) + \u0082.\u0001.\u001D\u0005((int) __nonvirtual (objPtr1->B), (int) __nonvirtual (objPtr2->B));
              ++objPtr1;
              ++objPtr2;
            }
            ++num6;
            ++num4;
            ++num5;
          }
          return \u0093\u0081.\u0087\u0095(\u000E\u0081.\u008A\u0095(\u009E\u0084.\u0084\u0095(num1), \u000E\u0081.\u0089\u0095(\u0084\u001C.\u0083\u0095((size.Width - x_pixel_offset) * (size.Height - y_pixel_offset)), new Decimal(3))));
        }
        finally
        {
          if (flag2)
            \u001A\u001E.\u0082\u0098(obj2);
        }
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    private \u0018 \u001D\u0005(Size sz)
    {
      if (\u0010\u007F.\u0005\u0081(this.\u0001, sz))
        return this;
      if (this.\u0001.ContainsKey(sz))
        return this.\u0001[sz];
      Bitmap bmp = (Bitmap) null;
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = this.\u0001, ref flag);
        try
        {
          bmp = new Bitmap(sz.Width, sz.Height);
          this.\u0001.\u0082\u0005();
          Graphics graphics = \u0005\u0087.\u001D\u007F((Image) bmp);
          try
          {
            \u0094\u0081.\u007E\u0083\u007F((object) graphics, InterpolationMode.High);
            \u0015\u0083.\u007E\u0081\u007F((object) graphics, SmoothingMode.AntiAlias);
            \u0004\u001F.\u007E\u009E\u007F((object) graphics, (Image) this.\u0001.BaseBitmap, new Rectangle(Point.Empty, sz));
          }
          finally
          {
            if (graphics != null)
              \u001A\u001E.\u007E\u0094\u0092((object) graphics);
          }
          \u0018 obj2 = (\u0018) null;
          try
          {
            obj2 = new \u0018(bmp, true);
            this.\u0001.Add(sz, obj2);
            return obj2;
          }
          catch
          {
            if (obj2 != null)
              obj2.Dispose();
            throw;
          }
        }
        catch
        {
          if (bmp != null)
            \u001A\u001E.\u007E\u001D\u001F((object) bmp);
          throw;
        }
        finally
        {
          this.\u0001.\u0081\u0005();
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }
  }
}
