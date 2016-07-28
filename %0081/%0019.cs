// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001F;
using System;

namespace \u0081
{
  internal sealed class \u0019 : EventArgs
  {
    public Version MinimumVersion { get; private set; }

    public \u0081 ContentPackData { get; private set; }

    public bool IsPatch { get; private set; }

    public \u0019(\u0081 contentPackData, Version minimumVersion, bool isPatch)
    {
      this.ContentPackData = contentPackData;
      this.MinimumVersion = minimumVersion;
      this.IsPatch = isPatch;
    }
  }
}
