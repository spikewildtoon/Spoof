// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001C;
using \u0084;
using System;

namespace \u0084
{
  internal static class \u001E
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u001E()
    {
      \u0004.\u001D\u0005(typeof (\u001E));
    }

    public static string \u001D\u0005(this \u0017 type, bool allowAlphaToJPG)
    {
      switch (type)
      {
        case \u0017.\u0002:
          return \u001E.\u0001(106385);
        case \u0017.\u0003:
          if (allowAlphaToJPG)
            return \u001E.\u0001(106410);
          return \u001E.\u0001(106487);
        case \u0017.\u0004:
          return \u001E.\u0001(106541);
        case \u0017.\u0005:
          return \u001E.\u0001(106520);
        case \u0017.\u0006:
          return \u001E.\u0001(106566);
        default:
          return string.Empty;
      }
    }
  }
}
