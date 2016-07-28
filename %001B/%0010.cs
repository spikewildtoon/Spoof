// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;

namespace \u001B
{
  internal sealed class \u0010 : EventArgs
  {
    public string ErrorTitle { get; private set; }

    public string ErrorMessage { get; private set; }

    public bool PrematureExit { get; private set; }

    public \u0010(string errorTitle, string errorMessage)
    {
      this.ErrorTitle = errorTitle;
      this.ErrorMessage = errorMessage;
    }

    public \u0010(bool prematureExit, string errorTitle, string errorMessage)
      : this(errorTitle, errorMessage)
    {
      this.PrematureExit = prematureExit;
    }
  }
}
