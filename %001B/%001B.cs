// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

namespace \u001B
{
  internal sealed class \u001B
  {
    public string FileName { get; private set; }

    public bool FileExists { get; set; }

    public string ClientMd5 { get; set; }

    public string ExpectedMd5 { get; set; }

    public bool UpToDate { get; set; }

    public int ClientSize { get; set; }

    public int ExpectedSize { get; set; }

    public \u001B(string fileName)
    {
      this.FileName = fileName;
      this.FileExists = false;
      this.ClientMd5 = (string) null;
      this.ExpectedMd5 = (string) null;
      this.UpToDate = false;
      this.ClientSize = 0;
      this.ExpectedSize = 0;
    }
  }
}
