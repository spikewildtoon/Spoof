// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001D;
using System.Collections.Generic;
using System.IO;

namespace \u0082
{
  internal sealed class \u0019 : IEqualityComparer<FileSystemInfo>
  {
    public bool Equals(FileSystemInfo x, FileSystemInfo y)
    {
      if (\u0013\u0080.\u0089\u0091((object) x, (object) y))
        return true;
      if (\u0013\u0080.\u0089\u0091((object) x, (object) null) || \u0013\u0080.\u0089\u0091((object) y, (object) null))
        return false;
      return \u0014.\u001D\u0005(\u0002\u007F.\u007E\u0082\u009E((object) x), \u0002\u007F.\u007E\u0082\u009E((object) y));
    }

    public int GetHashCode(FileSystemInfo product)
    {
      return \u0089\u0086.\u007E\u0096\u0093((object) \u0093\u001B.\u0090\u0093(), \u0002\u007F.\u007E\u0082\u009E((object) product));
    }
  }
}
