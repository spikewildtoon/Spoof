// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;

namespace \u0082
{
  internal sealed class \u001F<T> : \u000F<T>
  {
    public int RemovedIndex { get; private set; }

    public int GroupIndex { get; private set; }

    public \u001F(T item, int removedIndex, int groupIndex)
      : base(item)
    {
      this.RemovedIndex = removedIndex;
      this.GroupIndex = groupIndex;
    }
  }
}
