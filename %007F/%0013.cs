// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0019;
using \u001A;
using \u001B;
using \u001C;
using \u001D;
using \u007F;
using \u0082;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace \u007F
{
  internal sealed class \u0013
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly int \u0001;
    private static readonly byte \u0001;
    private static readonly byte \u0002;

    static \u0013()
    {
      \u0004.\u001D\u0005(typeof (\u0013));
      \u0013.\u0001 = \u0013.\u0001(76393);
      \u0013.\u0001 = 2;
      \u0013.\u0001 = (byte) 0;
      \u0013.\u0002 = (byte) 1;
    }

    public static void \u001D\u0005(IntPtr hWnd, Point location, Size size, Bitmap bitmap)
    {
      \u0013.\u001D\u0005(hWnd, location, size, bitmap, byte.MaxValue);
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static void \u001D\u0005(IntPtr hWnd, Point location, Size size, Bitmap bitmap, byte opacity)
    {
      if (\u0087\u001F.\u007E\u0081\u001F((object) bitmap) != PixelFormat.Format32bppArgb)
        throw new ApplicationException(\u0013.\u0001(76286));
      IntPtr num1 = \u000E.\u001E\u0005(IntPtr.Zero);
      IntPtr num2 = \u000E.\u007F\u0005(num1);
      IntPtr hObject1 = IntPtr.Zero;
      IntPtr hObject2 = IntPtr.Zero;
      try
      {
        hObject1 = \u0014\u0082.\u007E\u0088\u001F((object) bitmap, \u0086\u007F.\u0014\u007F(0));
        hObject2 = \u000E.\u001E\u0005(num2, hObject1);
        Point pprSrc = Point.Empty;
        \u0008 pblend = new \u0008() { \u0001 = \u0013.\u0001, \u0002 = 0, \u0003 = opacity, \u0004 = \u0013.\u0002 };
        if (!\u000E.\u001D\u0005(hWnd, num1, ref location, ref size, num2, ref pprSrc, 0, ref pblend, \u0013.\u0001))
          throw new Win32Exception();
      }
      finally
      {
        \u000E.\u001D\u0005(IntPtr.Zero, num1);
        if (\u0008\u0081.\u0087\u0096(hObject1, IntPtr.Zero))
        {
          \u000E.\u001E\u0005(num2, hObject2);
          \u000E.\u0080\u0005(hObject1);
        }
        \u000E.\u007F\u0005(num2);
      }
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static void \u001D\u0005(IntPtr Handle, Bitmap bitmap, byte opacity, Point Location)
    {
      if (\u0087\u001F.\u007E\u0081\u001F((object) bitmap) != PixelFormat.Format32bppArgb)
        throw new ApplicationException(\u0013.\u0001(76347));
      IntPtr num1 = \u000E.\u001E\u0005(IntPtr.Zero);
      IntPtr num2 = \u000E.\u007F\u0005(num1);
      IntPtr hObject1 = IntPtr.Zero;
      IntPtr hObject2 = IntPtr.Zero;
      try
      {
        hObject1 = \u0014\u0082.\u007E\u0088\u001F((object) bitmap, \u0086\u007F.\u0014\u007F(0));
        hObject2 = \u000E.\u001E\u0005(num2, hObject1);
        Size psize = new Size(\u0005\u0081.\u007E\u007F\u001F((object) bitmap), \u0005\u0081.\u007E\u0080\u001F((object) bitmap));
        Point pprSrc = new Point(0, 0);
        Point pptDst = Location;
        \u000E.\u001D\u0005(Handle, num1, ref pptDst, ref psize, num2, ref pprSrc, 0, ref new \u0008()
        {
          \u0001 = \u0013.\u0001,
          \u0002 = (byte) 0,
          \u0003 = opacity,
          \u0004 = \u0013.\u0002
        }, \u0013.\u0001);
      }
      finally
      {
        \u000E.\u001D\u0005(IntPtr.Zero, num1);
        if (\u0008\u0081.\u0087\u0096(hObject1, IntPtr.Zero))
        {
          \u000E.\u001E\u0005(num2, hObject2);
          \u000E.\u0080\u0005(hObject1);
        }
        \u000E.\u007F\u0005(num2);
      }
    }

    public static void \u001D\u0005(IntPtr hWnd)
    {
      \u000E.\u001D\u0005(hWnd, \u0015.\u001B.\u000F, true, 0);
    }

    public static void \u001E\u0005(IntPtr hWnd)
    {
      \u000E.\u001D\u0005(hWnd, \u0015.\u001B.\u000F, false, 0);
    }

    public static void \u001F\u0005(IntPtr hWnd)
    {
      if (!\u000E.\u001D\u0005(hWnd, \u0015.\u001B.\u0093\u0002, \u0010.\u0008, 0))
        throw new Win32Exception();
    }

    public static void \u007F\u0005(IntPtr hWnd)
    {
      if (!\u000E.\u001D\u0005(hWnd, \u0015.\u001B.\u0093\u0002, \u0010.\u000E, 0))
        throw new Win32Exception();
    }

    public static void \u0080\u0005(IntPtr hWnd)
    {
      if (!\u000E.\u001D\u0005(hWnd, \u0015.\u001B.\u0093\u0002, \u0010.\u0014, 0))
        throw new Win32Exception();
    }

    public static void \u001D\u0005(object wrapper, IntPtr hWnd)
    {
      \u000E.\u001D\u0005(hWnd, \u000E.\u0004, 0, 0, 0, 0, \u0004.\u0008 | \u0004.\u0012 | \u0004.\u0014);
      \u000E.\u001D\u0005(hWnd, \u0006.\u0005);
      if (wrapper == null)
        \u000E.\u0081\u0005(hWnd);
      else
        \u000E.\u001D\u0005(new HandleRef(wrapper, hWnd));
    }

    public static void \u001D\u0005(Control control)
    {
      \u000E.\u001D\u0005(new HandleRef((object) control, \u0088\u0086.\u007E\u0097\u0083((object) control)), \u000E.\u0005, 0, 0, 0, 0, \u0004.\u0006 | \u0004.\u0008 | \u0004.\u0012);
    }

    public static void \u001D\u0005(Control top, Control under)
    {
      \u000E.\u001D\u0005(new HandleRef((object) under, \u0088\u0086.\u007E\u0097\u0083((object) under)), new HandleRef((object) top, \u0088\u0086.\u007E\u0097\u0083((object) top)), 0, 0, 0, 0, \u0004.\u0006 | \u0004.\u0008 | \u0004.\u0012);
    }

    public static void \u001D\u0005(Control control, int time, \u000F flags)
    {
      \u000E.\u001D\u0005(new HandleRef((object) control, \u0088\u0086.\u007E\u0097\u0083((object) control)), time, flags);
    }

    public static void \u001D\u0005(List<KeyValuePair<IntPtr, Rectangle>> windows)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0013.\u0001 obj = new \u0013.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = windows;
      // ISSUE: reference to a compiler-generated field
      if (obj.\u0001 == null)
        throw new ArgumentNullException(\u0013.\u0001(76384));
      // ISSUE: reference to a compiler-generated field
      obj.\u0001.Clear();
      // ISSUE: reference to a compiler-generated method
      if (!\u000E.\u001D\u0005(new \u000E.\u0001(obj.\u001D\u0005), new IntPtr(0)))
        throw new Win32Exception();
    }

    public static Point \u001D\u0005(Point p)
    {
      \u0093\u0081 obj1 = \u0093\u0081.\u0087\u0095;
      \u000E\u0084 obj2 = \u000E\u0084.\u0090\u0096;
      \u000E\u0081 obj3 = \u000E\u0081.\u008A\u0095;
      Decimal num1 = \u000E\u0081.\u0089\u0095(\u0084\u001C.\u0083\u0095(p.X), new Decimal((int) ushort.MaxValue));
      Rectangle rectangle1 = \u008D\u0084.\u007E\u0013\u008F((object) \u0001\u001E.\u0014\u008F());
      Decimal num2 = \u0084\u001C.\u0083\u0095(rectangle1.Width);
      Decimal num3 = obj3(num1, num2);
      Decimal num4 = obj2(num3);
      int x = obj1(num4);
      \u0093\u0081 obj4 = \u0093\u0081.\u0087\u0095;
      \u000E\u0084 obj5 = \u000E\u0084.\u0090\u0096;
      \u000E\u0081 obj6 = \u000E\u0081.\u008A\u0095;
      Decimal num5 = \u000E\u0081.\u0089\u0095(\u0084\u001C.\u0083\u0095(p.Y), new Decimal((int) ushort.MaxValue));
      Rectangle rectangle2 = \u008D\u0084.\u007E\u0013\u008F((object) \u0001\u001E.\u0014\u008F());
      Decimal num6 = \u0084\u001C.\u0083\u0095(rectangle2.Height);
      Decimal num7 = obj6(num5, num6);
      Decimal num8 = obj5(num7);
      int y = obj4(num8);
      return new Point(x, y);
    }

    public static Rectangle \u001D\u0005(IntPtr hWnd)
    {
      \u0008 lpRect;
      if (\u000E.\u001D\u0005(hWnd, out lpRect))
        return lpRect.\u001D\u0005();
      throw new Win32Exception();
    }

    public static Rectangle \u001D\u0005(IntPtr hWnd, IntPtr parenthWnd)
    {
      \u0008 lpRect;
      if (!\u000E.\u001D\u0005(hWnd, out lpRect))
        throw new Win32Exception();
      if (\u000E.\u001D\u0005(\u000E.\u007F\u0005(), parenthWnd, ref lpRect, 2U) != 0)
        return lpRect.\u001D\u0005();
      throw new Win32Exception();
    }

    public static Rectangle \u001E\u0005(IntPtr hWnd)
    {
      \u0008 lpRect;
      if (!\u000E.\u001E\u0005(hWnd, out lpRect))
        throw new Win32Exception();
      Rectangle rectangle = new Rectangle(0, 0, lpRect.\u0003 - lpRect.\u0001, lpRect.\u0004 - lpRect.\u0002);
      Point lpPoint = new Point(lpRect.\u0001, lpRect.\u0002);
      if (!\u000E.\u001D\u0005(hWnd, ref lpPoint))
        throw new Win32Exception();
      rectangle.Location = new Point(lpPoint.X, lpPoint.Y);
      return rectangle;
    }

    public static bool \u001D\u0005(IntPtr hWnd, Size sz)
    {
      Size size1 = \u0013.\u001D\u0005(hWnd);
      if (\u0010\u007F.\u0005\u0081(size1, sz))
        return false;
      Rectangle rectangle = \u0013.\u001D\u0005(hWnd);
      Size size2 = \u0003\u0086.\u0003\u0081(rectangle.Size, \u0003\u0086.\u0004\u0081(sz, size1));
      return \u0013.\u001D\u0005(hWnd, size2, false);
    }

    public static Size \u001D\u0005(IntPtr hWnd)
    {
      \u0008 lpRect;
      if (\u000E.\u001E\u0005(hWnd, out lpRect))
        return new Size(lpRect.\u0003 - lpRect.\u0001, lpRect.\u0004 - lpRect.\u0002);
      throw new Win32Exception();
    }

    public static Rectangle \u001F\u0005(IntPtr hWnd)
    {
      Rectangle rectangle1 = \u0013.\u001D\u0005(hWnd);
      Rectangle rectangle2 = \u0013.\u001E\u0005(hWnd);
      return new Rectangle(rectangle2.X - rectangle1.X, rectangle2.Y - rectangle1.Y, rectangle2.Width, rectangle2.Height);
    }

    public static Rectangle \u007F\u0005(IntPtr hWnd)
    {
      \u0008 lpRect;
      if (\u000E.\u001E\u0005(hWnd, out lpRect))
        return lpRect.\u001D\u0005();
      throw new Win32Exception();
    }

    public static FormWindowState \u001D\u0005(HandleRef hWnd)
    {
      Rectangle normalRect;
      return \u0013.\u001D\u0005(hWnd, out normalRect);
    }

    public static FormWindowState \u001D\u0005(HandleRef hWnd, out Rectangle normalRect)
    {
      \u0007 placement = new \u0007();
      // ISSUE: type reference
      placement.\u0001 = (uint) \u0082\u001D.\u0005\u009D(\u009C\u0082.\u0016\u0097(__typeref (\u0007)));
      \u000E.\u001D\u0005(hWnd, ref placement);
      normalRect = placement.\u0001.\u001D\u0005();
      if (placement.\u0001 == \u0006.\u0003)
        return FormWindowState.Maximized;
      if (placement.\u0001 != \u0006.\u000E)
        return FormWindowState.Normal;
      return \u0095\u001C.\u0099\u0091((object) placement.\u0001, (Enum) \u0013.\u0002) ? FormWindowState.Minimized | FormWindowState.Maximized : FormWindowState.Minimized;
    }

    public static void \u001D\u0005(HandleRef hWnd, FormWindowState state, Rectangle? rect = null)
    {
      Rectangle normalRect;
      FormWindowState formWindowState;
      if ((formWindowState = \u0013.\u001D\u0005(hWnd, out normalRect)) == state && (!rect.HasValue || !\u0019\u007F.\u0095\u0080(normalRect, rect.Value)))
        return;
      \u0007 placement = new \u0007();
      // ISSUE: type reference
      placement.\u0001 = (uint) \u0082\u001D.\u0005\u009D(\u009C\u0082.\u0016\u0097(__typeref (\u0007)));
      \u000E.\u001D\u0005(hWnd, ref placement);
      if (rect.HasValue && \u0019\u007F.\u0095\u0080(normalRect, rect.Value))
        placement.\u0001 = new \u0008(rect.Value);
      if (formWindowState != state)
      {
        if (\u0095\u001C.\u0099\u0091((object) state, (Enum) FormWindowState.Maximized))
        {
          if (\u0095\u001C.\u0099\u0091((object) state, (Enum) FormWindowState.Minimized))
          {
            placement.\u0001 |= \u0013.\u0002;
            placement.\u0001 = \u0006.\u000E;
          }
          else
          {
            placement.\u0001 = \u0006.\u0003;
            placement.\u0001 &= ~\u0013.\u0002;
          }
        }
        else if (\u0095\u001C.\u0099\u0091((object) state, (Enum) FormWindowState.Minimized))
        {
          placement.\u0001 = \u0006.\u000E;
          placement.\u0001 &= ~\u0013.\u0002;
        }
        else
        {
          placement.\u0001 = \u0006.\u0005;
          placement.\u0001 &= ~\u0013.\u0002;
        }
      }
      \u000E.\u001E\u0005(hWnd, ref placement);
    }

    public static bool \u001D\u0005(IntPtr hWnd, Size size, bool activate)
    {
      if (!\u0010\u007F.\u0005\u0081(size, \u0013.\u001D\u0005(hWnd).Size))
      {
        \u000E.\u001D\u0005(hWnd, \u0015.\u001B.\u008C\u0003, IntPtr.Zero, IntPtr.Zero);
        if (activate)
        {
          if (!\u000E.\u001D\u0005(hWnd, \u000E.\u0004, 0, 0, size.Width, size.Height, \u0004.\u0008))
            throw new Win32Exception();
        }
        else if (!\u000E.\u001D\u0005(hWnd, \u000E.\u0004, 0, 0, size.Width, size.Height, \u0004.\u0006 | \u0004.\u0008))
          throw new Win32Exception();
        \u000E.\u001D\u0005(hWnd, \u0015.\u001B.\u008D\u0003, IntPtr.Zero, IntPtr.Zero);
        return true;
      }
      if (activate && !\u000E.\u001D\u0005(hWnd, \u000E.\u0004, 0, 0, 0, 0, \u0004.\u0008 | \u0004.\u0012))
        throw new Win32Exception();
      return false;
    }

    public static \u0015.\u001C \u001D\u0005(IntPtr hWnd)
    {
      return (\u0015.\u001C) \u000E.\u001D\u0005(hWnd, \u0012.\u0005);
    }

    public static void \u001D\u0005(IntPtr hWnd, \u0015.\u001C style)
    {
      \u000E.\u001D\u0005(hWnd, \u0012.\u0005, (int) style);
    }

    public static bool \u001D\u0005(IntPtr hWnd)
    {
      return \u0095\u001C.\u0099\u0091((object) \u0013.\u001D\u0005(hWnd), (Enum) \u0015.\u001C.\u001D);
    }

    public static bool \u001D\u0005(IntPtr hWnd, string data, IntPtr dwData, uint timeOut)
    {
      using (\u0003 lParam = new \u0003())
      {
        lParam.\u0001 = (\u0005\u0081.\u007E\u0001\u0093((object) data) + 1) * 2;
        lParam.\u0002 = \u000E.\u001D\u0005(\u0014.\u0004, new IntPtr(lParam.\u0001));
        \u0019\u001C.\u0007\u009D(\u0084\u001E.\u007E\u009D\u0092((object) data), 0, lParam.\u0002, \u0005\u0081.\u007E\u0001\u0093((object) data));
        lParam.\u0001 = dwData;
        IntPtr lpdwResult;
        return \u0008\u0081.\u0087\u0096(\u000E.\u001D\u0005(hWnd, \u0015.\u001B.\u009D, IntPtr.Zero, ref lParam, \u001F.\u0017.\u0001, timeOut, out lpdwResult), IntPtr.Zero);
      }
    }
  }
}
