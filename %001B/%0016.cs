// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001B;
using System;
using System.Diagnostics;

namespace \u001B
{
  internal static class \u0016
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0016()
    {
      \u0004.\u001D\u0005(typeof (\u0016));
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005(this Uri uri)
    {
      if (!\u0099\u0082.\u007E\u0089\u0002\u0002((object) uri))
        return false;
      if (!\u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0087\u0002\u0002((object) uri), \u0016.\u0001(54812)))
        return \u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0087\u0002\u0002((object) uri), \u0016.\u0001(54821));
      return true;
    }
  }
}
