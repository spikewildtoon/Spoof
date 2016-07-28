// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001B;
using \u001D;
using System;

namespace \u001F
{
  internal sealed class \u001F : EventArgs
  {
    public \u0017 InstallerState { get; private set; }

    public \u0080 InstallFailureType { get; private set; }

    public \u001F(\u0017 installerState)
    {
      this.InstallerState = installerState;
    }

    public \u001F(\u0017 installerState, \u0080 installFailureType)
      : this(installerState)
    {
      this.InstallFailureType = installFailureType;
    }
  }
}
