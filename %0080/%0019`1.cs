// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Collections.Generic;

namespace \u0080
{
  internal sealed class \u0019<TValue>
  {
    private List<TValue> \u0001;

    public TValue this[int index]
    {
      get
      {
        return this.\u0001[index];
      }
      set
      {
        this.\u0001[index] = value;
      }
    }

    public TValue this[Enum enu]
    {
      get
      {
        return this.\u0001[\u0005\u0081.\u0017\u0095((object) enu)];
      }
      set
      {
        this.\u0001[\u0005\u0081.\u0017\u0095((object) enu)] = value;
      }
    }

    public \u0019(int size)
    {
      this.\u0001 = new List<TValue>(size);
      for (int index = 0; index < size; ++index)
        this.\u0001.Add(default (TValue));
    }
  }
}
