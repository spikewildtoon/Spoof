﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;

namespace \u0015
{
  internal class \u000F<T> : EventArgs
  {
    public T Item { get; private set; }

    public \u000F(T item)
    {
      this.Item = item;
    }
  }
}