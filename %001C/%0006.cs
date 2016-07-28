// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001C;

namespace \u001C
{
  internal struct \u0006
  {
    public string Key { get; private set; }

    public string Value { get; private set; }

    public \u0006(string key, string value)
    {
      this = new \u0006();
      switch (key)
      {
        case null:
          key = string.Empty;
          break;
      }
      switch (value)
      {
        case null:
          value = string.Empty;
          break;
      }
      this.Key = key;
      this.Value = value;
    }
  }
}
