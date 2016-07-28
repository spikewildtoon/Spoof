// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001B;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001A
{
  internal sealed class \u0004 : \u0003
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private IContainer \u0001;

    static \u0004()
    {
      \u0004.\u001D\u0005(typeof (\u0004));
    }

    public \u0004()
    {
      this.\u001F\u0005();
      this.\u001D\u0005<\u0008>();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u001F\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0004)));
      \u001A\u001E.\u0084\u0086((object) this);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(456, 223));
      \u0092\u0081.\u0010\u0084((object) this, \u0004.\u0001(48648));
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0004.\u0001(48665));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
