// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0017;
using \u001A;
using \u0080;

namespace \u001A
{
  internal sealed class \u001B : \u0005<\u001B>
  {
    public uint ExpectedFileSize { get; set; }

    public uint ResultingFileSize { get; set; }

    public \u0016 ExpectedHash { get; set; }

    public \u0016 ResultingHash { get; set; }

    public string Version { get; set; }

    public \u0015 \u001D\u0005()
    {
      return new \u0015() { ExpectedHash = this.ResultingHash, ExpectedSize = (long) this.ResultingFileSize, Version = this.Version };
    }

    public \u001B \u0001()
    {
      return new \u001B() { ExpectedFileSize = this.ExpectedFileSize, ResultingFileSize = this.ResultingFileSize, ExpectedHash = this.ExpectedHash, ResultingHash = this.ResultingHash, Version = this.Version };
    }
  }
}
