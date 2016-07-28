// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0017;

namespace \u001B
{
  internal class \u001A
  {
    public string PhaseName { get; private set; }

    public string FileName { get; private set; }

    public string FilePath { get; private set; }

    public string AltFileName { get; private set; }

    public string AltFilePath { get; private set; }

    public \u0015 FileDetails { get; protected set; }

    public bool Virtualized { get; private set; }

    public \u001A(string phaseName, string fileName, string filePath, string altFileName, string altFilePath, bool virtualized)
    {
      this.PhaseName = phaseName;
      this.FileName = fileName;
      this.FilePath = filePath;
      this.AltFileName = altFileName;
      this.AltFilePath = altFilePath;
      this.Virtualized = virtualized;
    }
  }
}
