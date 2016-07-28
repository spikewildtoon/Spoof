// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001C;
using System;
using System.Runtime.InteropServices;

namespace \u0018
{
  internal sealed class \u0008<T> : IDisposable where T : class
  {
    private \u000E \u0001;

    public T Target
    {
      get
      {
        return this.\u0001.Handle.Target as T;
      }
    }

    public bool IsAlive
    {
      get
      {
        return this.\u0001.Handle.Target != null;
      }
    }

    public \u0008(T target)
    {
      this.\u0001 = new \u000E((object) target, GCHandleType.Weak);
    }

    public void Dispose()
    {
      \u001A\u001E.\u007E\u0097\u0097((object) this.\u0001);
    }
  }
}
