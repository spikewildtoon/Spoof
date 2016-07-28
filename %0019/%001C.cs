// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0016;
using \u0017;
using \u0019;
using \u001A;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TSN.Drawing;

namespace \u0019
{
  internal sealed class \u001C : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private Stream \u0001;
    private Stream \u0002;
    private Stream \u0003;
    private Bitmap \u0001;
    private Bitmap \u0002;
    private Bitmap \u0003;
    private IContainer \u0001;
    private PictureBox \u0001;
    private PictureBox \u0002;
    private Button \u0001;
    private Button \u0002;
    private \u007F.\u0082 \u0001;
    private Label \u0001;
    private PictureBox \u0003;
    private Label \u0002;
    private Label \u0003;
    private Label \u0004;
    private Label \u0005;

    public Stream RGBStream
    {
      get
      {
        return this.\u0002;
      }
    }

    public Stream JPGStream
    {
      get
      {
        return this.\u0003;
      }
    }

    static \u001C()
    {
      \u0004.\u001D\u0005(typeof (\u001C));
    }

    public \u001C(Stream stream)
    {
      this.\u0001 = stream;
      \u0012\u0080.\u007E\u0082\u009D((object) this.\u0001, 0L);
      this.\u0001 = \u0099\u001C.\u001C\u001F(this.\u0001) as Bitmap;
      if (!\u0015.\u0082.\u001D\u0005(\u0087\u001F.\u007E\u0081\u001F((object) this.\u0001)))
        throw new InvalidPixelFormatException(\u0087\u001F.\u007E\u0081\u001F((object) this.\u0001));
      \u0012\u0080.\u007E\u0082\u009D((object) this.\u0001, 0L);
      if (stream == null)
        throw new ArgumentNullException(\u001C.\u0001(45760));
      this.\u001E\u0005();
      this.\u001D\u0005();
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }

    private void \u001D\u0005(object sender, \u001D e)
    {
      this.\u001D\u0005();
    }

    private void \u001D\u0005()
    {
      if (this.\u0002 == null)
        goto label_5;
label_1:
      \u0012\u0080.\u007E\u008C\u009D((object) this.\u0002, 0L);
      if (this.\u0003 == null)
        goto label_6;
label_2:
      \u0012\u0080.\u007E\u008C\u009D((object) this.\u0003, 0L);
      if (this.\u0002 == null)
        this.\u0002 = new Bitmap(\u0005\u0081.\u007E\u007F\u001F((object) this.\u0001), \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001));
      \u0082.\u0017.\u001D\u0005(this.\u0001, this.\u0002, this.\u0002, new Color?(this.\u0001.SelectedColor), true, \u0002.\u0004);
      \u0012\u0080.\u007E\u0082\u009D((object) this.\u0002, 0L);
      this.\u0003 = \u0082.\u0017.\u001D\u0005(this.\u0002);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0003, (Image) this.\u0001);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) this.\u0002);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0002, (Image) this.\u0003);
      \u0008.\u001E\u0005(this.\u0002, this.\u0003, 100);
      \u0012\u0080.\u007E\u0082\u009D((object) this.\u0001, 0L);
      \u0012\u0080.\u007E\u0082\u009D((object) this.\u0003, 0L);
      \u0012\u0080.\u007E\u0082\u009D((object) this.\u0002, 0L);
      return;
label_6:
      this.\u0003 = (Stream) new MemoryStream();
      goto label_2;
label_5:
      this.\u0002 = (Stream) new MemoryStream();
      goto label_1;
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u001C);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0003 != null)
      {
        \u001A\u001E.\u007E\u0086\u009D((object) this.\u0003);
        this.\u0003 = (Stream) null;
      }
      if (this.\u0002 != null)
      {
        \u001A\u001E.\u007E\u0086\u009D((object) this.\u0002);
        this.\u0002 = (Stream) null;
      }
      if (this.\u0002 != null)
      {
        \u001A\u001E.\u007E\u001D\u001F((object) this.\u0002);
        this.\u0002 = (Bitmap) null;
      }
      if (this.\u0003 != null)
      {
        \u001A\u001E.\u007E\u001D\u001F((object) this.\u0003);
        this.\u0003 = (Bitmap) null;
      }
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u001D\u001F((object) this.\u0001);
        this.\u0001 = (Bitmap) null;
      }
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001E\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001C)));
      this.\u0001 = new PictureBox();
      this.\u0002 = new PictureBox();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0001 = new Label();
      this.\u0003 = new PictureBox();
      this.\u0002 = new Label();
      this.\u0003 = new Label();
      this.\u0004 = new Label();
      this.\u0001 = new \u007F.\u0082();
      this.\u0005 = new Label();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0002);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0003);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(178, 33));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(45769));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(160, 160));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.StretchImage);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(344, 33));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001C.\u0001(45782));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(160, 160));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0002, PictureBoxSizeMode.StretchImage);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0002, 0);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0002, false);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0001, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(429, 199));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(8035));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001C.\u0001(8048));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(348, 199));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001C.\u0001(45791));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001C.\u0001(14388));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(214, 204));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(6245));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(94, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001C.\u0001(45804));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(12, 33));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001C.\u0001(45829));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(160, 160));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0003, PictureBoxSizeMode.StretchImage);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0003, 0);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0003, false);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001C.\u0001(8957), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(7, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001C.\u0001(45842));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(79, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001C.\u0001(45859));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u001C.\u0001(8957), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(173, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001C.\u0001(45872));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(51, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u001C.\u0001(45881));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u001C.\u0001(8957), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(339, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u001C.\u0001(45886));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(78, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u001C.\u0001(45903));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(314, 198));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(45916));
      this.\u0001.SelectedColor = \u009A\u0080.\u0090\u001F();
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      this.\u0001.ColorChanged += new EventHandler<\u001D>(this.\u001D\u0005);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u001C.\u0001(5852), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(1, 215));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u001C.\u0001(8215));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 22);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u001C.\u0001(8240));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0002);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0001);
      \u000E\u001F.\u0010\u008B((object) this, new Size(515, 230));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001C.\u0001(6974)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u001C.\u0001(45929));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001C.\u0001(45942));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0002);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0003);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
