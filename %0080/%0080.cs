// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0080
{
  internal sealed class \u0080 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Label \u0001;
    private Label \u0002;
    private \u001E.\u001E \u0001;
    private \u001E.\u001E \u0002;
    private Button \u0001;
    private Button \u0002;

    public PointF SelectedPoint
    {
      get
      {
        return new PointF(this.\u0001.Value, this.\u0002.Value);
      }
      set
      {
        this.\u0001.Value = value.X;
        this.\u0002.Value = value.Y;
      }
    }

    public event EventHandler<\u0011<PointF>> ValueValidating;

    static \u0080()
    {
      \u0004.\u001D\u0005(typeof (\u0080.\u0080));
    }

    public \u0080()
    {
      this.\u001D\u0005();
    }

    private void \u001D\u0005(object sender, FormClosingEventArgs e)
    {
      if (\u0097\u001E.\u0014\u008B((object) this) != DialogResult.OK || this.\u0001 == null)
        return;
      \u0011<PointF> e1 = new \u0011<PointF>(this.SelectedPoint);
      this.\u0001((object) this, e1);
      if (e1.IsValid)
        return;
      \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0080.\u0080)));
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0001 = new \u001E.\u001E();
      this.\u0002 = new \u001E.\u001E();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(137, 15));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0080.\u0080.\u0001(93450));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(17, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0080.\u0080.\u0001(93459));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(8, 15));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0080.\u0080.\u0001(93464));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(17, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 43);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0080.\u0080.\u0001(93473));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(266, 10));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0080.\u0080.\u0001(35515));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0080.\u0080.\u0001(10868));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0002, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(347, 10));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0080.\u0080.\u0001(17200));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0080.\u0080.\u0001(10886));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(31, 11));
      this.\u0001.MaximumValue = 3.402823E+38f;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0001, 32);
      this.\u0001.MinimumValue = -3.402823E+38f;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0080.\u0080.\u0001(93478));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(100, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      this.\u0001.Value = 0.0f;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(160, 11));
      this.\u0002.MaximumValue = 3.402823E+38f;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0002, 32);
      this.\u0002.MinimumValue = -3.402823E+38f;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0080.\u0080.\u0001(93487));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(100, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      this.\u0002.Value = 0.0f;
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0002);
      \u000E\u001F.\u0010\u008B((object) this, new Size(434, 41));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0080.\u0080.\u0001(9812)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0080.\u0080.\u0001(93496));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0080.\u0080.\u0001(93513));
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
