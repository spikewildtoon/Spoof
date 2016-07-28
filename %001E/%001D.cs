// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001A;
using \u001E;
using System;

namespace \u001E
{
  internal static class \u001D
  {
    public static \u0015 Logger { get; set; }

    public static void \u001D\u0005(this Exception ex)
    {
      ex.\u001D\u0005((object[]) null);
    }

    public static void \u001D\u0005(this Exception ex, params object[] state)
    {
      if (\u001D.Logger == null)
        return;
      \u001D.Logger.\u0001(ex, state);
    }
  }
}
