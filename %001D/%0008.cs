// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001B;
using \u001D;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001D
{
  internal sealed class \u0008 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0013 \u0001;
    private Button \u0001;
    private Label \u0001;
    private Button \u0002;

    public bool TryAgainLater { get; private set; }

    static \u0008()
    {
      \u0004.\u001D\u0005(typeof (\u0008));
    }

    public \u0008(\u0010 failArgs)
    {
      \u0094\u0083.\u007E\u0093\u0083((object) this, \u001E\u0080.\u001B\u0081());
      this.\u001D\u0005();
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, failArgs.ErrorMessage);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0008.\u0001(37080));
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0008.\u0001(37359));
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0008.\u0001(63190));
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, failArgs.ErrorTitle);
      \u0011\u001F.\u007E\u009D\u0083((object) this.\u0002, \u0005\u0081.\u007E\u009C\u0083((object) this.\u0001) - \u0005\u0081.\u007E\u0083\u0084((object) this.\u0002) - 6);
      \u000E\u001F.\u007E\u0007\u0084((object) this, new Size(\u0005\u0081.\u007E\u009C\u0083((object) this.\u0001) + \u0005\u0081.\u0015\u0084((object) this) - \u0005\u0081.\u007E\u009C\u0083((object) this.\u0002), 250));
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new Button();
      this.\u0001 = new Label();
      this.\u0001 = new \u0013();
      this.\u0002 = new Button();
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0001, DialogResult.Cancel);
      \u0018\u001C.\u007E\u0086\u0087((object) this.\u0001, FlatStyle.System);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(259, 228));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0008.\u0001(9080));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(68, 22));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0008.\u0001(63126));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(0, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u001A\u0081());
      \u0012\u0082.\u007E\u0012\u008A((object) this.\u0001, BorderStyle.None);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 27));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0008.\u0001(63139));
      \u0099\u001F.\u007E\u0019\u008A((object) this.\u0001, true);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(315, 184));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0008.\u0001(5073));
      \u0099\u001F.\u007E\u0099\u008E((object) this.\u0001, false);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0002, DialogResult.Cancel);
      \u0018\u001C.\u007E\u0086\u0087((object) this.\u0002, FlatStyle.System);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(161, 228));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0008.\u0001(63152));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(92, 22));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 5);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0001);
      \u000E\u001F.\u0010\u008B((object) this, new Size(339, 262));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0099\u001F.\u001E\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0008.\u0001(63177));
      \u0099\u001F.\u0080\u008B((object) this, false);
      \u0099\u001F.\u007F\u008B((object) this, false);
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    protected override void OnLayout(LayoutEventArgs levent)
    {
      \u0007\u001D.\u0095\u008B((object) this, levent);
      if (this.\u0001 == null)
        return;
      \u0011\u001F.\u007E\u0084\u0084((object) this.\u0001, \u008D\u0084.\u0082\u0083((object) this).Width - 2 * \u0005\u0081.\u007E\u009C\u0083((object) this.\u0001));
      \u0011\u001F.\u007E\u0099\u0083((object) this.\u0001, \u008D\u0084.\u0082\u0083((object) this).Height - \u0005\u0081.\u007E\u001F\u0084((object) this.\u0001) - \u0005\u0081.\u007E\u009C\u0083((object) this.\u0001) - (\u008D\u0084.\u0082\u0083((object) this).Height - \u0005\u0081.\u007E\u001F\u0084((object) this.\u0001)));
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.TryAgainLater = true;
      \u001A\u001E.\u0092\u008B((object) this);
    }
  }
}
