﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;

namespace \u0014
{
  internal sealed class \u0015 : EventArgs
  {
    public \u001B.\u001B FileState { get; private set; }

    public \u0015(\u001B.\u001B filestate)
    {
      this.FileState = filestate;
    }
  }
}
