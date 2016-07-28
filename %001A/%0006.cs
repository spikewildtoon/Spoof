// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u0080;
using \u0083;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001A
{
  internal sealed class \u0006 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private PictureBox \u0001;
    private Label \u0001;
    private Label \u0002;
    private Panel \u0001;
    private Button \u0001;
    private LinkLabel \u0001;

    static \u0006()
    {
      \u0004.\u001D\u0005(typeof (\u0006));
    }

    public \u0006()
    {
      this.\u001D\u0005();
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u009E\u0081.\u001F\u0093(\u0002\u007F.\u007E\u001C\u0084((object) this.\u0001), (object) \u0008.Current.FileVersion));
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u009E\u0081.\u001F\u0093(\u0002\u007F.\u007E\u001C\u0084((object) this.\u0002), (object) \u001D\u0082.\u0011\u0094().Year));
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001D\u0005(object sender, LinkLabelLinkClickedEventArgs e)
    {
      \u0082.\u001D\u0005(\u0002.\u0017);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0006)));
      this.\u0001 = new PictureBox();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0001 = new Panel();
      this.\u0001 = new LinkLabel();
      this.\u0001 = new Button();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0006.\u0001(49195)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 12));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(49220));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(438, 172));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0006.\u0001(49237), 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 189));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(49258));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(438, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0006.\u0001(49283));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.TopCenter);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0006.\u0001(49237), 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(12, 211));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0006.\u0001(49348));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(438, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0006.\u0001(49369));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0002, ContentAlignment.TopCenter);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0008\u007F());
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Top);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(35392));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(462, 256));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0001, \u008E\u001D.\u0017\u007F(0, 192, 192));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(157, 233));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(49410));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(149, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0006.\u0001(49439));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0001, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(375, 262));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(8817));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0006.\u0001(8208));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u009A\u0080.\u0016\u0081());
      \u000E\u001F.\u0010\u008B((object) this, new Size(462, 291));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedDialog);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0099\u001F.\u001E\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0006.\u0001(49476));
      \u0099\u001F.\u0080\u008B((object) this, false);
      \u0099\u001F.\u007F\u008B((object) this, false);
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0006.\u0001(49489));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
