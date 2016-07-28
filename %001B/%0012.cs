// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001A;
using \u007F;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace \u001B
{
  internal static class \u0012
  {
    public static void \u001D\u0005(IntPtr hWnd, int id, \u0016 modifiers, Keys key)
    {
      if (!\u000E.\u001D\u0005(hWnd, id, modifiers, key))
        throw new Win32Exception();
    }

    public static void \u001D\u0005(IntPtr hWnd, int id)
    {
      if (!\u000E.\u001D\u0005(hWnd, id))
        throw new Win32Exception();
    }
  }
}
