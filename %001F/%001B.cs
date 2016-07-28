// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Diagnostics;

namespace \u001F
{
  internal static class \u001B
  {
    [DebuggerStepThrough]
    public static bool \u001D\u0005(this char c)
    {
      if ((int) c >= 97 && (int) c <= 102 || (int) c >= 48 && (int) c <= 57)
        return true;
      if ((int) c < 65)
        return false;
      return (int) c <= 70;
    }
  }
}
