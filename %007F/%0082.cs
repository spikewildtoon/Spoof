// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0019;
using \u007F;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u007F
{
  internal sealed class \u0082 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private ColorDialog \u0001;
    private \u001E \u0001;
    private ToolTip \u0001;

    public Color SelectedColor
    {
      get
      {
        return this.\u0001.SelectedColor;
      }
      set
      {
        this.\u0001.SelectedColor = value;
      }
    }

    public event EventHandler<\u001D> ColorChanged;

    static \u0082()
    {
      \u0004.\u001D\u0005(typeof (\u0082));
    }

    public \u0082()
    {
      this.\u001D\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new ColorDialog();
      this.\u0001 = new \u001E();
      this.\u0001 = new ToolTip(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u008C\u0088((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0008\u007F());
      this.\u0001.DrawBorder = true;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(2, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0082.\u0001(48396));
      this.\u0001.SelectedColor = Color.Empty;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(20, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0082.\u0001(80844));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u0098\u0090((object) this.\u0001, true);
      \u0086\u001C.\u007E\u0099\u0090((object) this.\u0001, ToolTipIcon.Info);
      \u0092\u0081.\u007E\u009A\u0090((object) this.\u0001, \u0082.\u0001(80885));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0082.\u0001(80894));
      \u000E\u001F.\u0018\u0084((object) this, new Size(24, 24));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001E\u0005()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u001D(this.SelectedColor));
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK)
        return;
      this.\u0001.SelectedColor = \u0091\u0084.\u007E\u008A\u0088((object) this.\u0001);
      \u001A\u001E.\u007E\u0004\u0086((object) this.\u0001);
      this.\u001E\u0005();
    }
  }
}
