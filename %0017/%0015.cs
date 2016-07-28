// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0016;
using \u0017;
using \u0019;
using \u001A;
using \u0084;
using System.Collections.Generic;

namespace \u0017
{
  internal sealed class \u0015
  {
    public string Version { get; set; }

    public long ExpectedSize { get; set; }

    public \u0080.\u0016 ExpectedHash { get; set; }

    public List<\u001B> Patches { get; private set; }

    public bool ForceRecheck { get; set; }

    public \u0015()
    {
      this.Patches = new List<\u001B>();
      this.ForceRecheck = false;
    }

    public \u0015(long expectedSize, \u0080.\u0016 expectedHash, string version)
      : this()
    {
      this.ExpectedSize = expectedSize;
      this.ExpectedHash = expectedHash;
      this.Version = version;
    }

    public \u0015 \u001D\u0005()
    {
      return new \u0015() { Version = this.Version, ExpectedSize = this.ExpectedSize, ExpectedHash = this.ExpectedHash };
    }

    public \u0015 \u001D\u0005(\u0080.\u0016 expectedHash)
    {
      \u0015 obj1 = this.\u001D\u0005();
      bool flag = false;
      object obj2;
      try
      {
        \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) this.Patches), ref flag);
        for (int index = this.Patches.Count - 1; index >= 0; --index)
        {
          if (\u0080.\u0016.\u001D\u0005(expectedHash, this.Patches[index].ExpectedHash))
          {
            for (; index < this.Patches.Count; ++index)
              obj1.Patches.Add(this.Patches[index].\u0001());
            break;
          }
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj2);
      }
      return obj1;
    }

    public bool \u001D\u0005(\u0080.\u0016 hash)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) this.Patches), ref flag);
        foreach (\u001B patch in this.Patches)
        {
          if (\u0080.\u0016.\u001D\u0005(patch.ExpectedHash, hash))
            return true;
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
      return false;
    }

    public \u0007 \u001D\u0005(string filename, out \u0080.\u0016 actualFileHash)
    {
      long actualFileSize;
      return this.\u001D\u0005(filename, out actualFileHash, out actualFileSize);
    }

    public \u0007 \u001D\u0005(string filename, out \u0080.\u0016 actualFileHash, out long actualFileSize)
    {
      actualFileSize = 0L;
      actualFileHash = new \u0080.\u0016();
      try
      {
        if (!\u008F\u0084.\u0092\u009E(filename))
          return \u0007.\u0001;
        actualFileHash = \u0004.\u001D\u0005(filename);
        return this.ExpectedSize == (actualFileSize = \u0012.\u001D\u0005(filename)) && \u0080.\u0016.\u001D\u0005(this.ExpectedHash, actualFileHash) ? \u0007.\u0003 : \u0007.\u0002;
      }
      finally
      {
        this.ForceRecheck = false;
      }
    }

    public \u0007 \u001D\u0005(\u0015 lastFile, string filename, out \u0080.\u0016 actualFileHash)
    {
      actualFileHash = new \u0080.\u0016();
      try
      {
        if (!\u008F\u0084.\u0092\u009E(filename))
          return \u0007.\u0001;
        if (!this.ForceRecheck && !lastFile.ForceRecheck && (!\u0008\u001F.\u009B\u0092(this.Version, lastFile.Version) && this.ExpectedSize == \u0012.\u001D\u0005(filename)))
          return \u0007.\u0003;
        actualFileHash = \u0004.\u001D\u0005(filename);
        return \u0080.\u0016.\u001D\u0005(this.ExpectedHash, actualFileHash) ? \u0007.\u0003 : \u0007.\u0002;
      }
      finally
      {
        this.ForceRecheck = false;
      }
    }
  }
}
