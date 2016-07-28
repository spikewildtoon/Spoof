// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using System;
using System.Drawing;

namespace \u001F
{
  internal sealed class \u0006 : \u0016
  {
    public Bitmap \u0001;

    public string FileName { get; private set; }

    public DateTime DateCreated { get; private set; }

    public string FilePath { get; private set; }

    public \u0006(string fileName, string filePath, DateTime dateCreated)
    {
      this.FileName = fileName;
      this.DateCreated = dateCreated;
      this.FilePath = filePath;
    }

    protected override void \u001D\u0005()
    {
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u001D\u001F((object) this.\u0001);
      this.\u0001 = (Bitmap) null;
      base.\u001D\u0005();
    }
  }
}
