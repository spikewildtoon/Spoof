// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001A;
using System;

namespace \u0017
{
  internal struct \u0003 : IDisposable
  {
    internal IntPtr \u0001;
    public int \u0001;
    internal IntPtr \u0002;

    public void Dispose()
    {
      if (!\u0008\u0081.\u0087\u0096(this.\u0002, IntPtr.Zero))
        return;
      \u000E.\u0080\u0005(this.\u0002);
      this.\u0002 = IntPtr.Zero;
    }
  }
}
