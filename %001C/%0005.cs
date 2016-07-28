// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0016;
using \u001F;
using System;

namespace \u001C
{
  internal sealed class \u0005 : EventArgs
  {
    public \u0080 Response { get; private set; }

    public \u0015 PreviousStep { get; private set; }

    public \u0005(\u0080 response, \u0015 previousStep)
    {
      this.Response = response;
      this.PreviousStep = previousStep;
    }
  }
}
