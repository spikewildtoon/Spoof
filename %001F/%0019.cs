// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u001A;
using \u001E;
using \u001F;
using System;
using TSN.Native.Enums;

namespace \u001F
{
  internal static class \u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0019()
    {
      \u0004.\u001D\u0005(typeof (\u0019));
    }

    public static \u0080 \u001D\u0005(this Win32Error errorCode)
    {
      int num = (int) errorCode;
      if (((long) num & 2147483648L) != 2147483648L)
        return (\u0080) (-2147024896 | num & (int) ushort.MaxValue);
      return (\u0080) num;
    }

    public static unsafe string \u001D\u0005(this Win32Error errorCode)
    {
      \u0010 obj1 = new \u0010();
      // ISSUE: reference to a compiler-generated field
      if ((int) (obj1.\u0001 = (byte) \u000E.\u001D\u0005(12800, IntPtr.Zero, (int) errorCode, 0, new IntPtr((void*) &obj1.\u0001.\u0001), \u0010.\u0001, IntPtr.Zero)) == 0)
        return \u009E\u0081.\u001F\u0093(\u0019.\u0001(74846), (object) (int) errorCode);
      \u0010 obj2 = new \u0010();
      for (int index = 0; index < (int) obj1.\u0001; ++index)
      {
        // ISSUE: reference to a compiler-generated field
        char c = (&obj1.\u0001.\u0001)[index];
        if (\u0095\u0080.\u0011\u0095(c) || \u0095\u0080.\u0010\u0095(c) || (\u0095\u0080.\u0014\u0095(c) || \u0095\u0080.\u000F\u0095(c)))
          obj2.\u001D\u0005(c);
        else
          break;
      }
      return \u008B\u0080.\u007E\u001D\u0093((object) obj2.ToString(), \u0019.\u0001(74879), \u0019.\u0001(6144));
    }
  }
}
