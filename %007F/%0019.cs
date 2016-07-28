// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u007F;
using System;

namespace \u007F
{
  internal static class \u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0019()
    {
      \u0004.\u001D\u0005(typeof (\u0019));
    }

    public static Version \u001D\u0005(this byte[] data)
    {
      if (data == null)
        throw new ArgumentNullException(\u0019.\u0001(47836));
      return new Version(\u0014\u001E.\u0001\u0095(data, 0), \u0014\u001E.\u0001\u0095(data, 4), \u0014\u001E.\u0001\u0095(data, 8), \u0014\u001E.\u0001\u0095(data, 12));
    }

    public static short \u001D\u0005(this byte[] bytes, int startIndex)
    {
      byte[] numArray = new byte[2];
      \u0089\u0083.\u0084\u0092((Array) bytes, startIndex, (Array) numArray, 0, 2);
      if (BitConverter.IsLittleEndian)
        \u0096\u001B.\u008E\u0092((Array) numArray);
      return \u0013\u0084.\u009F\u0094(numArray, 0);
    }
  }
}
