// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.Diagnostics;

namespace \u0081
{
  internal static class \u0001
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    public static bool DesignMode
    {
      get
      {
        Process process = \u000F\u001F.\u0014\u0004\u0002();
        try
        {
          return \u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0019\u0093((object) \u0002\u007F.\u007E\u0004\u0004\u0002((object) process)), \u0081.\u0001.\u0001(93960));
        }
        finally
        {
          if (process != null)
            \u001A\u001E.\u007E\u0094\u0092((object) process);
        }
      }
    }

    static \u0001()
    {
      \u0004.\u001D\u0005(typeof (\u0081.\u0001));
    }
  }
}
