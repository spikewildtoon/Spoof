// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Collections.Generic;

namespace \u0017
{
  internal sealed class \u0014 : EventArgs
  {
    public Dictionary<string, string> Result { get; private set; }

    public bool NewFormat { get; private set; }

    public \u0014(bool newFormat, Dictionary<string, string> result)
    {
      this.NewFormat = newFormat;
      this.Result = result;
    }
  }
}
