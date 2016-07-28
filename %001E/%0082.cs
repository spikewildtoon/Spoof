// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001A;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001E
{
  internal sealed class \u0082 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Button \u0001;
    private LinkLabel \u0001;
    private Label \u0001;
    private Label \u0002;
    private Button \u0002;
    private \u0082.\u0018 \u0001;

    static \u0082()
    {
      \u0004.\u001D\u0005(typeof (\u001E.\u0082));
    }

    public \u0082()
    {
      this.\u001D\u0005();
      this.\u0001 = \u0081.\u0080.Instance.ApplicationSettings;
      \u0080\u0086.\u0016\u008B((object) this, \u0013.PenPaper_Icon);
      if (\u008F\u0084.\u0092\u009E(\u007F.\u001E))
        return;
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0017.\u001D\u0005(\u009E\u0081.\u001F\u0093(\u001E.\u0082.\u0001(67796), (object) \u009C\u0080.\u0008\u009F(\u007F.\u001E)), \u001E.\u0082.\u0001(37179));
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
      this.\u0001 = new LinkLabel();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0002 = new Button();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(266, 115));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001E.\u0082.\u0001(67431));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 8);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001E.\u0082.\u0001(15640));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0001, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001E.\u0082.\u0001(10735), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0001, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(72, 82));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001E.\u0082.\u0001(67444));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(205, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 18);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001E.\u0082.\u0001(67477));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0001, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(33, 48));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001E.\u0082.\u0001(67514));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(283, 29));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 19);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001E.\u0082.\u0001(67535));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001E.\u0082.\u0001(10735), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(12, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001E.\u0082.\u0001(67660));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(224, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 20);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001E.\u0082.\u0001(67697));
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0002, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(185, 115));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001E.\u0082.\u0001(16140));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 8);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001E.\u0082.\u0001(15670));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0002);
      \u000E\u001F.\u0010\u008B((object) this, new Size(349, 144));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u001E.\u0082.\u0001(67730));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001E.\u0082.\u0001(67759));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001.AcceptedContentPackAgreement = true;
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001D\u0005(object sender, LinkLabelLinkClickedEventArgs e)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u0016);
    }
  }
}
