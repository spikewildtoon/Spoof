// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u001D;
using \u001E;
using System.IO;

namespace \u0084
{
  internal static class \u001F
  {
    public static void \u001D\u0005(this \u001B mfd, string path)
    {
      string str = \u009C\u0080.\u0005\u009F(path);
      if (!\u008F\u0084.\u001D\u009E(str))
      {
        DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(str, \u000F.GetDirectorySecurity);
      }
      Stream destination = (Stream) \u008F\u001C.\u0093\u009E(path, FileMode.Create, FileAccess.Write, FileShare.None);
      try
      {
        mfd.Data.\u001D\u0005(destination);
      }
      finally
      {
        if (destination != null)
          \u001A\u001E.\u007E\u0094\u0092((object) destination);
      }
    }
  }
}
