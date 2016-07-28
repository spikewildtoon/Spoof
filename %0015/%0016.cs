// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Diagnostics;

namespace \u0015
{
  internal class \u0016 : IDisposable
  {
    public bool IsDisposed { [DebuggerStepThrough] get; [DebuggerStepThrough] private set; }

    public bool IsDisposing { [DebuggerStepThrough] get; [DebuggerStepThrough] private set; }

    public bool IsDisposingOrDisposed
    {
      get
      {
        if (this.IsDisposed)
          return true;
        return this.IsDisposing;
      }
    }

    public event EventHandler OnDisposing;

    public event EventHandler OnDisposed;

    ~\u0016()
    {
      try
      {
        this.\u007F\u0005(false);
      }
      finally
      {
        \u001A\u001E.\u008C\u0091((object) this);
      }
    }

    private void \u001F\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u007F\u0005()
    {
      if (this.\u0002 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
    }

    public void Dispose()
    {
      this.\u007F\u0005(true);
      \u001A\u001E.\u0005\u0096((object) this);
    }

    [DebuggerStepThrough]
    private void \u007F\u0005(bool disposing)
    {
      if (this.IsDisposed)
        return;
      if (this.IsDisposing)
        return;
      try
      {
        this.IsDisposing = true;
        this.\u001F\u0005();
        this.\u001D\u0005(disposing);
        this.\u001E\u0005();
        if (disposing)
          this.\u001D\u0005();
      }
      finally
      {
        this.IsDisposing = false;
        this.IsDisposed = true;
      }
      this.\u007F\u0005();
    }

    protected virtual void \u001D\u0005()
    {
    }

    protected virtual void \u001E\u0005()
    {
    }

    protected virtual void \u001D\u0005(bool disposing)
    {
    }

    [DebuggerStepThrough]
    public override string ToString()
    {
      return \u0002\u007F.\u007E\u0017\u0097((object) \u009C\u0083.\u008B\u0091((object) this));
    }

    [DebuggerStepThrough]
    protected void \u0080\u0005()
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(\u0002\u007F.\u007E\u0087\u0091((object) this));
    }
  }
}
