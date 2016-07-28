// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;

namespace \u0015
{
  internal sealed class \u0010<T> : \u000F<T>
  {
    public int PreviousGroup { get; private set; }

    public int NewGroup { get; private set; }

    public \u0010(T item, int previousGroup, int newGroup)
      : base(item)
    {
      this.PreviousGroup = previousGroup;
      this.NewGroup = newGroup;
    }
  }
}
