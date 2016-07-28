// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0018;
using \u001A;
using \u001C;
using \u001E;
using \u007F;
using \u0081;
using \u0083;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace \u0081
{
  internal static class \u000E
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u000E()
    {
      \u0004.\u001D\u0005(typeof (\u000E));
    }

    public static \u0080 \u001D\u0005(this MouseButtons button, bool buttonDown)
    {
      if (!buttonDown)
      {
        switch (button)
        {
          case MouseButtons.Middle:
            return \u0080.\u0007;
          case MouseButtons.XButton1:
            return \u0080.\u000E;
          case MouseButtons.XButton2:
            return \u0080.\u000E;
          case MouseButtons.Left:
            return \u0080.\u0003;
          case MouseButtons.Right:
            return \u0080.\u0005;
          default:
            throw new NotSupportedException(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u000E.\u0001(94799), new object[1]{ (object) button }));
        }
      }
      else
      {
        switch (button)
        {
          case MouseButtons.Middle:
            return \u0080.\u0006;
          case MouseButtons.XButton1:
            return \u0080.\u0008;
          case MouseButtons.XButton2:
            return \u0080.\u0008;
          case MouseButtons.Left:
            return \u0080.\u0002;
          case MouseButtons.Right:
            return \u0080.\u0004;
          default:
            throw new NotSupportedException(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u000E.\u0001(94750), new object[1]{ (object) button }));
        }
      }
    }

    public static void \u001D\u0005(MouseButtons button)
    {
      if (\u0013.\u001D\u0005(new \u000F().\u001D\u0005(button)))
        return;
      \u000E.\u001D\u0005(button.\u001D\u0005(true), 0U, 0U, 0U, IntPtr.Zero);
    }

    public static void \u001E\u0005(MouseButtons button)
    {
      if (\u0013.\u001D\u0005(new \u000F().\u001E\u0005(button)))
        return;
      \u000E.\u001D\u0005(button.\u001D\u0005(false), 0U, 0U, 0U, IntPtr.Zero);
    }

    public static void \u001D\u0005(Point p)
    {
      \u007F\u001C.\u0001\u008A(p);
      if (\u000E.\u001D\u0005(p.X, p.Y))
        return;
      new Win32Exception().\u001D\u0005();
      \u000F obj = new \u000F();
      Point p1 = \u0013.\u001D\u0005(p);
      if (\u0013.\u001D\u0005(obj.\u001D\u0005(p1)))
        return;
      \u000E.\u001D\u0005(\u0080.\u0001 | \u0080.\u0011, (uint) p1.X, (uint) p1.Y, 0U, IntPtr.Zero);
    }

    public static void \u001D\u0005(IntPtr hWnd, Point p)
    {
      Rectangle rectangle = \u0013.\u001E\u0005(hWnd);
      if (p.X < 0)
        p.X = 0;
      if (p.Y < 0)
        p.Y = 0;
      if (p.X > rectangle.Width)
        p.X = rectangle.Width;
      if (p.Y > rectangle.Height)
        p.Y = rectangle.Height;
      p.X += rectangle.X;
      p.Y += rectangle.Y;
      \u000E.\u001D\u0005(p);
    }

    public static void \u001D\u0005(Rectangle window_bounds, Point p)
    {
      if (p.X < 0)
        p.X = 0;
      if (p.Y < 0)
        p.Y = 0;
      if (p.X > window_bounds.Width)
        p.X = window_bounds.Width;
      if (p.Y > window_bounds.Height)
        p.Y = window_bounds.Height;
      p.X += window_bounds.X;
      p.Y += window_bounds.Y;
      \u000E.\u001D\u0005(p);
    }

    public static void \u001D\u0005(MouseButtons button, TimeSpan delay, ManualResetEventSlim reset)
    {
      if (!\u0099\u0082.\u007E\u009E\u0098((object) reset))
        goto label_6;
label_1:
      if (!\u0099\u0082.\u007E\u009E\u0098((object) reset) && \u0002\u001F.\u0091\u0097(delay, TimeSpan.Zero))
      {
        int num = \u0001\u0082.\u007E\u0005\u0099((object) reset, delay) ? 1 : 0;
      }
      if (\u0099\u0082.\u007E\u009E\u0098((object) reset))
        return;
      \u000E.\u001E\u0005(button);
      return;
label_6:
      \u000E.\u001D\u0005(button);
      goto label_1;
    }

    public static void \u001F\u0005(MouseButtons button)
    {
      ManualResetEventSlim reset = new ManualResetEventSlim(false);
      try
      {
        \u000E.\u001D\u0005(button, TimeSpan.Zero, reset);
      }
      finally
      {
        if (reset != null)
          \u001A\u001E.\u007E\u0094\u0092((object) reset);
      }
    }

    public static void \u001D\u0005(MouseButtons button, int delay, ManualResetEventSlim reset)
    {
      \u000E.\u001D\u0005(button, new TimeSpan(0, 0, 0, 0, delay), reset);
    }

    public static void \u001D\u0005(IntPtr hWnd, Keys Key)
    {
      \u000E.\u001E\u0005(hWnd, Key);
      \u000E.\u001F\u0005(hWnd, Key);
    }

    public static void \u001D\u0005(IntPtr hWnd, Keys Key, WaitHandle[] waitHandle, int delay)
    {
      \u000E.\u001E\u0005(hWnd, Key);
      if (delay > 0)
      {
        int num = \u0008\u001E.\u001C\u0098(waitHandle, delay);
      }
      \u000E.\u001F\u0005(hWnd, Key);
    }

    public static void \u001D\u0005(IntPtr hWnd, Keys Key, ManualResetEventSlim reset, int delay)
    {
      if (!\u0099\u0082.\u007E\u009E\u0098((object) reset))
        goto label_6;
label_1:
      if (!\u0099\u0082.\u007E\u009E\u0098((object) reset) && delay > 0)
      {
        int num = \u0095\u0081.\u007E\u0006\u0099((object) reset, delay) ? 1 : 0;
      }
      if (\u0099\u0082.\u007E\u009E\u0098((object) reset))
        return;
      \u000E.\u001F\u0005(hWnd, Key);
      return;
label_6:
      \u000E.\u001E\u0005(hWnd, Key);
      goto label_1;
    }

    public static void \u001D\u0005(IntPtr hWnd, Keys Key, ManualResetEventSlim reset, TimeSpan delay)
    {
      if (!\u0099\u0082.\u007E\u009E\u0098((object) reset))
        goto label_6;
label_1:
      if (!\u0099\u0082.\u007E\u009E\u0098((object) reset) && \u0002\u001F.\u0091\u0097(delay, TimeSpan.Zero))
      {
        int num = \u0001\u0082.\u007E\u0005\u0099((object) reset, delay) ? 1 : 0;
      }
      if (\u0099\u0082.\u007E\u009E\u0098((object) reset))
        return;
      \u000E.\u001F\u0005(hWnd, Key);
      return;
label_6:
      \u000E.\u001E\u0005(hWnd, Key);
      goto label_1;
    }

    public static void \u001E\u0005(IntPtr hWnd, Keys Key)
    {
      \u000E.\u001D\u0005(hWnd, \u001B.\u0083\u0002, (int) Key, 0);
    }

    public static void \u001F\u0005(IntPtr hWnd, Keys Key)
    {
      \u000E.\u001D\u0005(hWnd, \u001B.\u0084\u0002, (int) Key, 0);
    }
  }
}
