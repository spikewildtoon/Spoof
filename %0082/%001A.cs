// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;

namespace \u0082
{
  internal static class \u001A
  {
    public static bool \u001D\u0005(this Version version)
    {
      if (\u0005\u0081.\u007E\u0008\u0098((object) version) == 0 && \u0005\u0081.\u007E\u000E\u0098((object) version) == 0 && \u0005\u0081.\u007E\u0010\u0098((object) version) == 0)
        return \u0005\u0081.\u007E\u000F\u0098((object) version) == 0;
      return false;
    }

    public static byte[] \u001D\u0005(this Version version)
    {
      byte[] numArray = new byte[16];
      \u0083\u0081.\u007E\u008C\u0092((object) \u001B\u0086.\u009C\u0094(\u0005\u0081.\u007E\u0008\u0098((object) version)), (Array) numArray, 0);
      \u0083\u0081.\u007E\u008C\u0092((object) \u001B\u0086.\u009C\u0094(\u0005\u0081.\u007E\u000E\u0098((object) version)), (Array) numArray, 4);
      \u0083\u0081.\u007E\u008C\u0092((object) \u001B\u0086.\u009C\u0094(\u0005\u0081.\u007E\u000F\u0098((object) version)), (Array) numArray, 8);
      \u0083\u0081.\u007E\u008C\u0092((object) \u001B\u0086.\u009C\u0094(\u0005\u0081.\u007E\u0010\u0098((object) version)), (Array) numArray, 12);
      return numArray;
    }
  }
}
