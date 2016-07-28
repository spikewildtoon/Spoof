// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0019;
using \u001A;
using \u007F;
using System;
using System.ComponentModel;
using System.Drawing;

namespace \u001B
{
  internal static class \u0011
  {
    public static void \u001D\u0005(IntPtr hWnd)
    {
      IntPtr hDC = \u000E.\u001F\u0005(hWnd);
      Graphics graphics = \u001B\u0084.\u001B\u007F(hDC);
      try
      {
        SolidBrush solidBrush = new SolidBrush(\u008D\u001E.\u0016\u007F(100, \u009A\u0080.\u0005\u007F()));
        try
        {
          \u0001\u0080.\u007E\u0093\u007F((object) graphics, (Brush) solidBrush, \u0013.\u001F\u0005(hWnd));
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
      if (\u000E.\u001D\u0005(hWnd, hDC) == 0)
        throw new Win32Exception();
      \u0013.\u001E\u0005(hWnd);
    }

    public static void \u001E\u0005(IntPtr hWnd)
    {
      \u0013.\u001D\u0005(hWnd);
      \u000E.\u001D\u0005(hWnd, IntPtr.Zero, IntPtr.Zero, \u000F.\u0001 | \u000F.\u0003 | \u000F.\u0008 | \u000F.\u000E | \u000F.\u0010);
      \u000E.\u001D\u0005(hWnd, IntPtr.Zero, true);
      \u000E.\u0083\u0005(hWnd);
    }
  }
}
