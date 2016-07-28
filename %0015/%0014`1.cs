// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Collections;
using System.Collections.Generic;

namespace \u0015
{
  internal interface \u0014<T> : IEnumerable<T>, IEnumerable, IDisposable, ICollection<T> where T : class
  {
    IEnumerable<T> LiveList { get; }

    IEnumerable<T> CompleteList { get; }

    IEnumerable<T> LiveListWithoutPurge { get; }

    int CompleteCount { get; }

    int DeadCount { get; }

    int LiveCount { get; }

    int LiveCountWithoutPurge { get; }

    void \u009C\u0002();
  }
}
