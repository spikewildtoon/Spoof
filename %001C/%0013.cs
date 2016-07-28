// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;

namespace \u001C
{
  internal sealed class \u0013
  {
    public Uri DownloadUri { get; private set; }

    public Version MinimumVersion { get; private set; }

    public Version ExpectedContentPackVersion { get; private set; }

    public \u0013(Uri downloadUri, Version minimumVersion, Version expectedContentPackVersion)
    {
      this.DownloadUri = downloadUri;
      this.MinimumVersion = minimumVersion;
      this.ExpectedContentPackVersion = expectedContentPackVersion;
    }
  }
}
