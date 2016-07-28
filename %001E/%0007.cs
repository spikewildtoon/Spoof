// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u001C;
using \u001F;

namespace \u001E
{
  internal sealed class \u0007 : \u0016
  {
    public \u0081 ContentPackSettings { get; private set; }

    public \u001A ContentPack { get; private set; }

    public \u0007(\u0081 contentPackSettings, \u001A contentPack)
    {
      this.ContentPackSettings = contentPackSettings;
      this.ContentPack = contentPack;
    }

    protected override void \u001D\u0005()
    {
      if (this.ContentPack != null)
        this.ContentPack.Dispose();
      base.\u001D\u0005();
    }
  }
}
