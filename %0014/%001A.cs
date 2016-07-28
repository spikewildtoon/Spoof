// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0018;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0014
{
  internal sealed class \u001A : \u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private bool \u0001;
    private IContainer \u0001;
    private \u001A \u0001;
    private Label \u0001;

    static \u001A()
    {
      \u0004.\u001D\u0005(typeof (\u001A));
      \u001A.\u0001 = \u001A.\u0001(5805);
    }

    public \u001A()
      : base(false)
    {
      this.\u007F\u0005();
      // ISSUE: method pointer
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler((object) this, __methodptr(\u001E\u0005)));
    }

    private void \u001E\u0005(object sender, FormClosingEventArgs e)
    {
      if (\u009A\u001E.\u007E\u009D\u008B((object) e) == CloseReason.WindowsShutDown || this.\u0001)
        return;
      \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
    }

    protected override void \u001D\u0005(\u0015 e)
    {
      e.Cancel = true;
      e.CancelReason = \u001A.\u0001;
      base.\u001D\u0005(e);
    }

    public void \u001E\u0005()
    {
      this.\u0001 = true;
      \u001A\u001E.\u0092\u008B((object) this);
    }

    public void \u001F\u0005()
    {
      this.\u001E\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u007F\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001A)));
      this.\u0001 = new \u001A();
      this.\u0001 = new Label();
      \u001A\u001E.\u0084\u0086((object) this);
      this.\u0001.AnimationSpeed = (short) 75;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(175, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001A.\u0001(5695));
      this.\u0001.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(30, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001A.\u0001(5708), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(10, 11));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001A.\u0001(5721));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(133, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001A.\u0001(5738));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(210, 35));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001A.\u0001(5251)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0099\u001F.\u001E\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u001A.\u0001(5771));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001A.\u0001(5784));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
