// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0016;
using System;

namespace \u007F
{
  internal sealed class \u001D : EventArgs
  {
    public \u0082 District { get; private set; }

    public \u001D(uint shardID)
      : this(\u0082.\u001D\u0005(shardID))
    {
    }

    public \u001D(\u0082 district)
    {
      this.District = district;
    }
  }
}
