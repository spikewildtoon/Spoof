// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Windows.Forms;

namespace \u001F
{
  internal struct \u0010 : IDisposable
  {
    private Form \u0001;

    public \u0010(Form owner)
    {
      \u001A\u001E.\u007E\u0001\u0086((object) owner);
      this.\u0001 = owner;
    }

    public void Dispose()
    {
      if (this.\u0001 == null || \u0099\u0082.\u007E\u008A\u0083((object) this.\u0001) || \u0099\u0082.\u007E\u008B\u0083((object) this.\u0001))
        return;
      \u001A\u001E.\u007E\u0083\u0086((object) this.\u0001);
      this.\u0001 = (Form) null;
    }
  }
}
