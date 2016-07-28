// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u007F;
using System;

namespace \u007F
{
  internal static class \u0018
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0018()
    {
      \u0004.\u001D\u0005(typeof (\u0018));
    }

    public static void \u001D\u0005(this Random rnd, byte[] buffer, byte minValue, byte maxValue)
    {
      if (buffer == null)
        throw new ArgumentNullException(\u0018.\u0001(18801));
      for (int index = 0; index < buffer.Length; ++index)
        buffer[index] = (byte) \u0099\u0086.\u007E\u000F\u0097((object) rnd, (int) minValue, (int) maxValue);
    }
  }
}
