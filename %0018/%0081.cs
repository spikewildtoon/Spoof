// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0018;
using \u001B;
using \u001C;
using \u001E;
using \u0080;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u0081 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private CheckBox \u0001;
    private LinkLabel \u0001;
    private ContextMenu \u0001;
    private MenuItem \u0001;
    private MenuItem \u0002;
    private Label \u0001;
    private \u0008 \u0001;
    private \u0003 \u0001;
    private \u0006 \u0001;
    private \u0003 \u0002;
    private \u007F \u0001;
    private int \u0001;

    public int FlowerNumber
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
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public \u007F FloraActions
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
        if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001) != this.FlowerEnabled)
          \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, this.FlowerEnabled);
        this.\u0001.FloraActions = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool FlowerEnabled
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u007F.\u0002);
      }
      set
      {
        if (this.FlowerEnabled == value)
          return;
        if (!value)
          goto label_7;
        else
          goto label_6;
label_2:
        if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001) == value)
          return;
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, value);
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
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public \u001C.\u0018 BeanCombination
    {
      get
      {
        return this.\u0001.BeanCombination;
      }
      set
      {
        this.\u0001.BeanCombination = value;
      }
    }

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

    static \u0081()
    {
      \u0004.\u001D\u0005(typeof (\u0081));
    }

    public \u0081()
    {
      this.\u001D\u0005();
      this.\u0001 = new \u0008();
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(87, 66));
      // ISSUE: method pointer
      this.\u0001.GardenerActionsChanged += new EventHandler<\u0002>((object) this, __methodptr(\u001D\u0005));
      this.\u0001.ClosePopup += new EventHandler(this.\u001D\u0005);
      this.\u0001 = new \u0003((Control) this.\u0001);
      this.\u0001 = new \u0006();
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(210, 210));
      this.\u0001.ClosePopup += new EventHandler(this.\u001E\u0005);
      this.\u0002 = new \u0003((Control) this.\u0001);
      this.FloraActions = \u007F.\u0002 | \u007F.\u0003 | \u007F.\u0004 | \u007F.\u0005;
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0002 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0002);
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new CheckBox();
      this.\u0001 = new LinkLabel();
      this.\u0001 = new ContextMenu();
      this.\u0001 = new MenuItem();
      this.\u0002 = new MenuItem();
      this.\u0001 = new Label();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(17, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0081.\u0001(41168));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(15, 14));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0081.\u0001(5642), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 16));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0081.\u0001(41197));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(29, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0081.\u0001(41218));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0001, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0081\u001E.\u007E\u0010\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0001), new MenuItem[2]
      {
        this.\u0001,
        this.\u0002
      });
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0001, \u0081.\u0001(41227));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0002, \u0081.\u0001(41240));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0002, new EventHandler(this.\u0081\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(-1, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0081.\u0001(41249));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(20, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0081.\u0001(41274));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleRight);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0081.\u0001(41279));
      \u000E\u001F.\u0018\u0084((object) this, new Size(36, 30));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u007E\u0081\u0089((object) this.\u0001);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u007E\u0081\u0089((object) this.\u0002);
    }

    private void \u001D\u0005(object sender, \u0002 e)
    {
      if (this.FlowerEnabled)
        this.FloraActions = e.FloraActions | \u007F.\u0002;
      else
        this.FloraActions = e.FloraActions;
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.FlowerEnabled = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001);
    }

    private void \u001D\u0005(object sender, LinkLabelLinkClickedEventArgs e)
    {
      \u008A\u001D.\u007E\u0015\u0089((object) this.\u0001, (Control) this.\u0001, new Point(0, \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001)));
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, !\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001));
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001E\u0005((Control) this);
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      this.\u0002.\u001E\u0005((Control) this);
    }
  }
}
