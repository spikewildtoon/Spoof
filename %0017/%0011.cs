// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0017;
using \u001C;

namespace \u0017
{
  internal class \u0011
  {
    public \u0012 Hotkey { get; private set; }

    public object State { get; private set; }

    public \u0012 Owner { get; private set; }

    public bool AllowRepeat { get; private set; }

    private \u0011()
    {
    }

    protected \u0011(\u0012 owner, \u0012 hotkey, bool allow_repeat, object state = null)
    {
      this.Owner = owner;
      this.Hotkey = hotkey;
      this.AllowRepeat = allow_repeat;
      this.State = state;
    }

    public override string ToString()
    {
      return this.Hotkey.ToString();
    }
  }
}
