// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001C;
using \u001E;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001E
{
  internal sealed class \u0006 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private PictureBox \u0001;
    private CheckBox \u0001;
    private Label \u0001;
    private LinkLabel \u0001;
    private int \u0001;
    private \u007F \u0001;
    private \u0003 \u0001;
    private \u0004 \u0001;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int WaterCount
    {
      get
      {
        return this.\u0001.WaterCount;
      }
      set
      {
        this.\u0001.WaterCount = value;
      }
    }

    public int TreeNumber
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, this.\u0001.ToString());
      }
    }

    [Browsable(false)]
    public bool TreeEnabled
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u007F.\u0002);
      }
      set
      {
        if (this.TreeEnabled == value)
          return;
        if (!value)
          goto label_7;
        else
          goto label_6;
label_2:
        if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001) == this.TreeEnabled)
          return;
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, this.TreeEnabled);
        return;
label_6:
        this.\u0001 |= \u007F.\u0002;
        goto label_2;
label_7:
        this.\u0001 &= ~\u007F.\u0002;
        goto label_2;
      }
    }

    [Browsable(false)]
    public \u007F GardeningActions
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (this.\u0001 == value)
          return;
        this.\u0001 = value;
        if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001) == this.TreeEnabled)
          return;
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, this.TreeEnabled);
      }
    }

    static \u0006()
    {
      \u0004.\u001D\u0005(typeof (\u0006));
    }

    public \u0006()
    {
      this.\u001D\u0005();
      this.\u0001 = new \u0004();
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(94, 25));
      // ISSUE: method pointer
      this.\u0001.ClosePopup += new EventHandler((object) this, __methodptr(\u001D\u0005));
      this.\u0001 = new \u0003((Control) this.\u0001);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0006)));
      this.\u0001 = new PictureBox();
      this.\u0001 = new CheckBox();
      this.\u0001 = new Label();
      this.\u0001 = new LinkLabel();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0006.\u0001(65026)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(65055));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(44, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(65076));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(15, 14));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(33, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(65101));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(13, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0006.\u0001(30042));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleRight);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0006.\u0001(7486), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(33, 17));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(43041));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(29, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0006.\u0001(43062));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0006.\u0001(65122));
      \u000E\u001F.\u0018\u0084((object) this, new Size(62, 32));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u007E\u0081\u0089((object) this.\u0001);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001E\u0005((Control) this);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, !\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001));
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      this.TreeEnabled = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001);
    }
  }
}
