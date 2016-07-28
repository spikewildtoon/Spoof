// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0018;
using \u0081;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Permissions;

namespace \u0015
{
  internal sealed class \u0082 : \u0016
  {
    private unsafe \u001D.\u0015* \u0001 = (\u001D.\u0015*) null;
    [NonSerialized]
    internal static \u0002 \u0001;
    private Bitmap \u0001;
    private BitmapData \u0001;
    private bool \u0001;
    private Rectangle \u0001;
    private bool \u0002;

    public unsafe \u001D.\u0015* pBase
    {
      [DebuggerStepThrough] get
      {
        return this.\u0001;
      }
    }

    public int Width
    {
      [DebuggerStepThrough] get
      {
        return this.\u0001.Width;
      }
    }

    public int Height
    {
      [DebuggerStepThrough] get
      {
        return this.\u0001.Height;
      }
    }

    public Size Size
    {
      [DebuggerStepThrough] get
      {
        return this.\u0001.Size;
      }
    }

    public Bitmap BaseBitmap
    {
      [DebuggerStepThrough] get
      {
        return this.\u0001;
      }
    }

    public bool IsLocked
    {
      [DebuggerStepThrough] get
      {
        return this.\u0001;
      }
    }

    public unsafe \u001D.\u0015[,] Colors
    {
      get
      {
        \u001D.\u0015[,] objArray = new \u001D.\u0015[this.Size.Width, this.Size.Height];
        \u001D.\u0015* objPtr = this.\u0001;
        for (int index1 = 0; index1 < this.Size.Height; ++index1)
        {
          for (int index2 = 0; index2 < this.Size.Width; ++index2)
          {
            objArray[index2, index1] = *objPtr;
            ++objPtr;
          }
        }
        return objArray;
      }
    }

    static \u0082()
    {
      \u0004.\u001D\u0005(typeof (\u0082));
    }

    public unsafe \u0082(Bitmap source, bool ownsBitmap)
    {
      if (source == null)
        throw new ArgumentNullException(\u0082.\u0001(15412));
      this.\u0002 = ownsBitmap;
      this.\u0001 = source;
      GraphicsUnit graphicsUnit = GraphicsUnit.Pixel;
      this.\u0001 = \u008E\u001C.\u0096\u0080(\u0016\u0081.\u007E\u0082\u001F((object) this.\u0001, ref graphicsUnit));
    }

    public \u0082(Bitmap source)
      : this(source, false)
    {
    }

    public unsafe \u0082(Size size)
    {
      this.\u0002 = true;
      this.\u0001 = new Bitmap(size.Width, size.Height);
      this.\u0001 = new Rectangle(Point.Empty, size);
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public unsafe void \u0081\u0005()
    {
      if (this.\u0001)
        return;
      this.\u0001 = true;
      this.\u0001 = \u0015\u0080.\u007E\u0089\u001F((object) this.\u0001, this.\u0001, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
      this.\u0001 = (\u001D.\u0015*) \u0088\u0086.\u007E\u001F\u0081((object) this.\u0001).ToPointer();
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public unsafe void \u0082\u0005()
    {
      if (!this.\u0001)
        return;
      \u0099\u001E.\u007E\u008A\u001F((object) this.\u0001, this.\u0001);
      this.\u0001 = (BitmapData) null;
      this.\u0001 = (\u001D.\u0015*) null;
      this.\u0001 = false;
    }

    protected override void \u001D\u0005()
    {
      if (this.\u0001)
        this.\u0082\u0005();
      if (this.\u0001 != null && this.\u0002)
      {
        \u001A\u001E.\u007E\u001D\u001F((object) this.\u0001);
        this.\u0001 = (Bitmap) null;
      }
      base.\u001D\u0005();
    }

    public static bool \u001D\u0005(PixelFormat format)
    {
      switch (format)
      {
        case PixelFormat.Format32bppPArgb:
        case PixelFormat.Format32bppArgb:
        case PixelFormat.Format24bppRgb:
        case PixelFormat.Format32bppRgb:
          return true;
        default:
          return false;
      }
    }

    public unsafe void \u001D\u0005(Rectangle bounds, out \u0082 result)
    {
      if (bounds.Width <= 0 || bounds.Height <= 0)
        throw new ArgumentOutOfRangeException(\u0082.\u0001(15421), \u0082.\u0001(15430));
      if (this.Width < bounds.Right || this.Height < bounds.Bottom)
        throw new ArgumentOutOfRangeException(\u0082.\u0001(15421), \u0082.\u0001(15467));
      result = new \u0082(new Size(bounds.Width, bounds.Height));
      \u0082.\u0002 obj1 = new \u0082.\u0002(this);
      try
      {
        \u0082.\u0002 obj2 = new \u0082.\u0002(result);
        try
        {
          \u001D.\u0015* objPtr1 = result.\u0001;
          for (int top = bounds.Top; top < bounds.Bottom; ++top)
          {
            \u001D.\u0015* objPtr2 = this.\u0001 + top * this.\u0001.Width + bounds.Left;
            for (int index = 0; index < bounds.Width; ++index)
            {
              *objPtr1 = *objPtr2;
              ++objPtr1;
              ++objPtr2;
            }
          }
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
    }

    public static unsafe void \u001D\u0005(Bitmap original)
    {
      \u0082 owner = new \u0082(original);
      try
      {
        \u0082.\u0002 obj = new \u0082.\u0002(owner);
        try
        {
          \u001D.\u0015* objPtr = owner.\u0001;
          int num1 = \u0005\u0081.\u007E\u0080\u001F((object) original) * \u0005\u0081.\u007E\u007F\u001F((object) original);
          for (int index = 0; index < num1; ++index)
          {
            // ISSUE: explicit non-virtual call
            // ISSUE: explicit non-virtual call
            // ISSUE: explicit non-virtual call
            byte num2 = (byte) ((double) __nonvirtual (objPtr->R) * 0.3 + (double) __nonvirtual (objPtr->G) * 0.59 + (double) __nonvirtual (objPtr->B) * 0.11);
            *objPtr = new \u001D.\u0015(num2, num2, num2, objPtr->A);
            ++objPtr;
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

    public static unsafe \u0082 \u001D\u0005(Bitmap[] bitmaps)
    {
      if (bitmaps == null)
        throw new ArgumentNullException(\u0082.\u0001(15504));
      if (bitmaps.Length == 0 || bitmaps.Length > (int) byte.MaxValue)
        throw new ArgumentException(\u009E\u0081.\u001F\u0093(\u0082.\u0001(15517), (object) bitmaps.Length));
      Size size = \u0083\u001E.\u007E\u001F\u001F((object) bitmaps[0]);
      for (int index = 1; index < bitmaps.Length; ++index)
      {
        if (\u0010\u007F.\u0006\u0081(\u0083\u001E.\u007E\u001F\u001F((object) bitmaps[index]), size))
          throw new ArgumentException(\u0082.\u0001(15562));
      }
      \u0082 owner = (\u0082) null;
      try
      {
        owner = new \u0082(size);
        \u0082.\u0004 utilities = new \u0082.\u0004(bitmaps);
        try
        {
          \u0082.\u0003 obj1 = new \u0082.\u0003(utilities);
          try
          {
            \u0082.\u0002 obj2 = new \u0082.\u0002(owner);
            try
            {
              int length = bitmaps.Length;
              int num1 = \u001F.\u001D\u0005(length);
              byte num2 = 0;
              \u001D.\u0015* objPtr1 = owner.\u0001;
              \u001D.\u0015** objPtr2 = stackalloc \u001D.\u0015*[length];
              \u001D.\u0015** objPtr3 = objPtr2;
              int* numPtr1 = stackalloc int[num1];
              int* numPtr2 = numPtr1;
              \u0082.\u0001* entries = stackalloc \u0082.\u0001[num1];
              int num3 = 0;
              int num4 = size.Height * size.Width;
              for (int index = 0; index < num1; ++index)
              {
                *numPtr2 = -1;
                ++numPtr2;
              }
              for (int index = 0; index < length; ++index)
              {
                *objPtr3 = utilities.\u0001[index].\u0001;
                ++objPtr3;
              }
              byte repeat_count = 0;
              for (int index1 = 0; index1 < num4; ++index1)
              {
                \u001D.\u0015** objPtr4 = objPtr2;
                int* buckets_ps;
                for (int index2 = 0; index2 < length; ++index2)
                {
                  int hash = (*objPtr4)->GetHashCode() & int.MaxValue;
                  buckets_ps = numPtr1 + hash % num1;
                  if (!\u0082.\u001D\u0005(ref buckets_ps, ref entries, ref hash, ref repeat_count, **objPtr4))
                  {
                    \u0082.\u0001* objPtr5 = entries + num3;
                    objPtr5->\u0001 = hash;
                    objPtr5->\u0002 = *buckets_ps;
                    objPtr5->\u0001 = **objPtr4;
                    objPtr5->\u0001 = repeat_count = (byte) 1;
                    *buckets_ps = num3;
                    ++num3;
                  }
                  if ((int) num2 < (int) repeat_count)
                  {
                    *objPtr1 = **objPtr4;
                    num2 = repeat_count;
                  }
                  \u001D.\u0015** objPtr6 = objPtr4;
                  IntPtr num5 = (IntPtr) (*objPtr6 + 1);
                  *objPtr6 = (\u001D.\u0015*) num5;
                  ++objPtr4;
                }
                buckets_ps = numPtr1;
                for (int index2 = 0; index2 < num1; ++index2)
                {
                  *buckets_ps = -1;
                  ++buckets_ps;
                }
                \u0082.\u0001* objPtr7 = entries;
                for (int index2 = 0; index2 < num1; ++index2)
                {
                  *objPtr7 = \u0082.\u0001.\u0001;
                  ++objPtr7;
                }
                num3 = 0;
                num2 = (byte) 0;
                ++objPtr1;
              }
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
        }
        finally
        {
          if (utilities != null)
            \u001A\u001E.\u007E\u0094\u0092((object) utilities);
        }
        return owner;
      }
      catch
      {
        if (owner != null)
          owner.Dispose();
        throw;
      }
    }

    private static unsafe bool \u001D\u0005(ref int* buckets_ps, ref \u0082.\u0001* entries, ref int hash, ref byte repeat_count, \u001D.\u0015 color)
    {
      if (*buckets_ps > -1)
        goto label_5;
label_4:
      return false;
label_5:
      \u0082.\u0001* objPtr;
      for (objPtr = entries + *buckets_ps; objPtr->\u0001 != hash || !\u001D.\u0015.\u001D\u0005(objPtr->\u0001, color); objPtr = entries + objPtr->\u0002)
      {
        if (objPtr->\u0002 == -1)
          goto label_4;
      }
      ++objPtr->\u0001;
      repeat_count = objPtr->\u0001;
      return true;
    }

    public static unsafe int \u001D\u0005(Bitmap bmp)
    {
      int num = 0;
      \u0082 owner = new \u0082(bmp);
      try
      {
        \u0082.\u0002 obj = new \u0082.\u0002(owner);
        try
        {
          \u001D.\u0015* pBase = owner.pBase;
          for (int index = 0; index < \u0083\u001E.\u007E\u001F\u001F((object) bmp).Width * \u0083\u001E.\u007E\u001F\u001F((object) bmp).Height; ++index)
          {
            if ((int) pBase->A > 0)
              ++num;
            ++pBase;
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
      return num;
    }

    private struct \u0001
    {
      public static readonly \u0082.\u0001 \u0001 = new \u0082.\u0001(0, 0, \u001D.\u0015.\u0001, (byte) 0);
      public int \u0001;
      public int \u0002;
      public \u001D.\u0015 \u0001;
      public byte \u0001;

      public \u0001(int hashCode, int next, \u001D.\u0015 color, byte count)
      {
        this.\u0001 = hashCode;
        this.\u0002 = next;
        this.\u0001 = color;
        this.\u0001 = count;
      }
    }

    internal sealed class \u0002 : IDisposable
    {
      private \u0082 \u0001;
      private bool \u0001;

      public \u0002(\u0082 owner)
      {
        this.\u0001 = owner;
        if (!(this.\u0001 = !this.\u0001.IsLocked))
          return;
        this.\u0001.\u0081\u0005();
      }

      public void Dispose()
      {
        if (!this.\u0001)
          return;
        this.\u0001.\u0082\u0005();
      }
    }

    private sealed class \u0003 : IDisposable
    {
      private \u0082[] \u0001;
      private bool[] \u0001;

      public \u0003(\u0082[] owners)
      {
        this.\u0001 = owners;
        this.\u0001 = new bool[this.\u0001.Length];
        for (int index1 = 0; index1 < this.\u0001.Length; ++index1)
        {
          bool[] flagArray = this.\u0001;
          int index2 = index1;
          \u0082[] objArray = this.\u0001;
          int index3 = index1;
          int num;
          bool flag = (num = !objArray[index3].IsLocked ? 1 : 0) != 0;
          flagArray[index2] = num != 0;
          if (flag)
            this.\u0001[index1].\u0081\u0005();
        }
      }

      public \u0003(\u0082.\u0004 utilities)
        : this(utilities.\u0001)
      {
      }

      public void Dispose()
      {
        for (int index = 0; index < this.\u0001.Length; ++index)
        {
          if (this.\u0001[index])
            this.\u0001[index].\u0082\u0005();
        }
      }
    }

    private sealed class \u0004 : IDisposable
    {
      public readonly \u0082[] \u0001;

      public \u0004(Bitmap[] bitmaps)
      {
        // ISSUE: unable to decompile the method.
      }

      public void Dispose()
      {
        ((IEnumerable<\u0082>) this.\u0001).\u001D\u0005<\u0082>();
      }
    }
  }
}
