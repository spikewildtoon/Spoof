// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using System;
using System.Windows.Forms;

namespace \u001A
{
  internal sealed class \u0082 : ListBox, \u0081
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0082()
    {
      \u0004.\u001D\u0005(typeof (\u0082));
    }

    public void \u0087\u0002(int index)
    {
      \u0011\u001F.\u001A\u0088((object) this, index);
    }

    public void \u009E\u0002()
    {
      \u001A\u001E.\u0019\u0088((object) this);
    }

    public void \u0017(object obj)
    {
      int num = \u007F\u001F.\u007E\u0080\u0088((object) \u0019\u0082.\u0011\u0088((object) this), obj);
      if (num == -1)
        throw new ArgumentException(\u0082.\u0001(54203));
      \u0011\u001F.\u001A\u0088((object) this, num);
    }
  }
}
