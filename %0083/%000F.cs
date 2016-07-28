// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0016;
using System;
using System.Collections.Generic;

namespace \u0083
{
  internal sealed class \u000F : EventArgs
  {
    public readonly List<\u0082> \u0001;

    public \u000F(List<\u0082> districts)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) districts), ref flag);
        this.\u0001 = new List<\u0082>((IEnumerable<\u0082>) districts);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }
  }
}
