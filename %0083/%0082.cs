// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0083;
using System;

namespace \u0083
{
  internal static class \u0082
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0082()
    {
      \u0004.\u001D\u0005(typeof (\u0082));
    }

    public static string \u001D\u0005(this int bytes)
    {
      return \u0082.\u001D\u0005((long) bytes);
    }

    public static string \u001D\u0005(this long bytes)
    {
      string[] strArray = new string[4]
      {
        \u0082.\u0001(105389),
        \u0082.\u0001(105394),
        \u0082.\u0001(105399),
        \u0082.\u0001(105404)
      };
      long num = (long) \u0090\u007F.\u009A\u0096(1024.0, (double) (strArray.Length - 1));
      foreach (string str in strArray)
      {
        if (bytes > num)
          return \u0014\u0084.\u007F\u0093(\u0082.\u0001(105413), (object) \u000E\u0081.\u0081\u0095(\u0002\u001C.\u0086\u0095(bytes), \u0002\u001C.\u0086\u0095(num)), (object) str);
        num /= 1024L;
      }
      return \u0082.\u0001(105434);
    }
  }
}
