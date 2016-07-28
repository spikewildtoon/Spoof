// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001D;
using System;
using System.IO;

namespace \u001D
{
  internal static class \u0014
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0014()
    {
      \u0004.\u001D\u0005(typeof (\u0014));
    }

    public static bool \u001D\u0005(string file1, string file2)
    {
      if (\u008F\u0084.\u009E\u0092(file1))
        throw new ArgumentNullException(\u0014.\u0001(63787));
      if (\u008F\u0084.\u009E\u0092(file2))
        throw new ArgumentNullException(\u0014.\u0001(63796));
      if (\u0005\u0081.\u007E\u0001\u0093((object) file1) > 3)
      {
        while ((int) \u008C\u0086.\u007E\u009C\u0092((object) file1, \u0005\u0081.\u007E\u0001\u0093((object) file1) - 1) == (int) Path.DirectorySeparatorChar)
          file1 = \u0084\u0080.\u007E\u0006\u0093((object) file1, 0, \u0005\u0081.\u007E\u0001\u0093((object) file1) - 1);
      }
      if (\u0005\u0081.\u007E\u0001\u0093((object) file2) > 3)
      {
        while ((int) \u008C\u0086.\u007E\u009C\u0092((object) file2, \u0005\u0081.\u007E\u0001\u0093((object) file2) - 1) == (int) Path.DirectorySeparatorChar)
          file2 = \u0084\u0080.\u007E\u0006\u0093((object) file2, 0, \u0005\u0081.\u007E\u0001\u0093((object) file2) - 1);
      }
      file1 = \u009C\u0080.\u0007\u009F(file1);
      file2 = \u009C\u0080.\u0007\u009F(file2);
      return \u0008\u0080.\u0099\u0092(file1, file2, StringComparison.OrdinalIgnoreCase);
    }
  }
}
