// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001A;
using \u001E;
using \u007F;
using \u0081;
using System;
using System.ComponentModel;
using System.Drawing;

namespace \u001E
{
  internal static class \u0012
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly int \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;

    static \u0012()
    {
      \u0004.\u001D\u0005(typeof (\u0012));
      \u0012.\u0001 = (int) ushort.MaxValue;
      \u0012.\u0001 = \u0012.\u0001(65380);
      \u0012.\u0002 = \u0012.\u0001(65449);
    }

    public static Bitmap \u001D\u0005()
    {
      return \u0012.\u001E\u0005(\u000E.\u007F\u0005(), \u0097\u0080.\u001E\u008F());
    }

    public static Bitmap \u001D\u0005(Rectangle rec)
    {
      return \u0012.\u001E\u0005(\u000E.\u007F\u0005(), rec);
    }

    public static Bitmap \u001D\u0005(IntPtr hWnd)
    {
      return \u0012.\u001E\u0005(\u000E.\u007F\u0005(), \u0013.\u001E\u0005(hWnd));
    }

    public static Bitmap \u001D\u0005(IntPtr hWnd, Rectangle rec)
    {
      Rectangle rectangle = \u0013.\u001E\u0005(hWnd);
      if (rec.Size.Height + rec.Y > rectangle.Size.Height || rec.Size.Width + rec.X > rectangle.Size.Width)
        throw new ArgumentException(\u0013\u001C.\u0080\u0093(\u0012.\u0002, (object) rec.Size, (object) rec.Location, (object) rectangle.Size));
      rec.X += rectangle.X;
      rec.Y += rectangle.Y;
      return \u0012.\u001E\u0005(\u000E.\u007F\u0005(), rec);
    }

    private static Bitmap \u001E\u0005(IntPtr handle, Rectangle rec)
    {
      IntPtr num1 = IntPtr.Zero;
      IntPtr num2 = IntPtr.Zero;
      try
      {
        num1 = \u000E.\u001F\u0005(handle);
        if (\u0008\u0081.\u0086\u0096(num1, IntPtr.Zero))
          throw new Win32Exception();
        num2 = \u000E.\u007F\u0005(num1);
        if (\u0008\u0081.\u0086\u0096(num2, IntPtr.Zero))
          throw new Win32Exception();
        IntPtr hObject1 = \u000E.\u001D\u0005(num1, rec.Width, rec.Height);
        if (\u0008\u0081.\u0086\u0096(hObject1, IntPtr.Zero))
          throw new Win32Exception();
        using (\u0008 hObject2 = \u0008.\u001D\u0005(hObject1))
        {
          IntPtr hObject3 = \u000E.\u001E\u0005(num2, \u0008.\u001D\u0005(hObject2));
          if (\u0008\u0081.\u0086\u0096(hObject3, IntPtr.Zero) || hObject3.ToInt32() == \u0012.\u0001)
            throw new InvalidOperationException(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0012.\u0001, new object[1]{ (object) hObject3.ToString() }));
          if (!\u000E.\u001D\u0005(num2, 0, 0, rec.Width, rec.Height, num1, rec.X, rec.Y, \u0011.\u0001))
            throw new Win32Exception();
          IntPtr num3 = \u000E.\u001E\u0005(num2, hObject3);
          if (\u0008\u0081.\u0086\u0096(num3, IntPtr.Zero) || num3.ToInt32() == \u0012.\u0001)
            throw new InvalidOperationException(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0012.\u0001, new object[1]{ (object) num3.ToString() }));
          return \u0082\u0084.\u0083\u001F(\u0008.\u001D\u0005(hObject2));
        }
      }
      finally
      {
        if (\u0008\u0081.\u0087\u0096(num2, IntPtr.Zero) && !\u000E.\u007F\u0005(num2))
          throw new Win32Exception();
        if (\u0008\u0081.\u0087\u0096(num1, IntPtr.Zero) && \u000E.\u001D\u0005(handle, num1) == 0)
          throw new Win32Exception();
      }
    }
  }
}
