// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;

namespace \u0082
{
  internal sealed class \u0011<T> : EventArgs
  {
    public readonly T \u0001;

    public bool IsValid
    {
      get
      {
        return (bool) this.\u0001;
      }
      set
      {
        this.\u0001 = (T) (value ? 1 : 0);
      }
    }

    public \u0011(T value)
      : this(value, true)
    {
    }

    public \u0011(T value, bool defaultIsValid)
    {
      this.\u0001 = value;
      this.IsValid = defaultIsValid;
    }
  }
}
