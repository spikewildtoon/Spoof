// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0019;
using \u001B;
using \u001F;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0016
{
  internal sealed class \u0018 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private VScrollBar \u0001;
    private TableLayoutPanel \u0001;
    private HScrollBar \u0001;
    private \u0012 \u0001;

    [DefaultValue(typeof (Bitmap), null)]
    public Bitmap Image
    {
      get
      {
        return this.\u0001.Image;
      }
      set
      {
        this.\u0001.Image = value;
      }
    }

    public Bitmap Overlay
    {
      get
      {
        return this.\u0001.Overlay;
      }
    }

    public \u0007 DrawingToolSize
    {
      get
      {
        return this.\u0001.DrawingToolSize;
      }
      set
      {
        this.\u0001.DrawingToolSize = value;
      }
    }

    public \u0083.\u001B DrawingTool
    {
      get
      {
        return this.\u0001.DrawingTool;
      }
      set
      {
        this.\u0001.DrawingTool = value;
      }
    }

    static \u0018()
    {
      \u0004.\u001D\u0005(typeof (\u0018));
    }

    public \u0018()
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
      this.\u0001 = new VScrollBar();
      this.\u0001 = new TableLayoutPanel();
      this.\u0001 = new HScrollBar();
      this.\u0001 = new \u0012();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Right);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0011\u001F.\u007E\u0005\u008C((object) this.\u0001, 1);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(183, 0));
      \u0011\u001F.\u007E\u0006\u008C((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0001(24541));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(17, 183));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0087\u007F.\u007E\u000E\u008C((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u009D\u001C.\u007E\u009B\u008A((object) this.\u0001, AutoSizeMode.GrowAndShrink);
      \u0011\u001F.\u007E\u008B\u008F((object) this.\u0001, 2);
      int num1 = \u0096\u007F.\u007E\u0095\u008F((object) \u008F\u0082.\u007E\u008F\u008F((object) this.\u0001), new ColumnStyle(SizeType.Percent, 100f));
      int num2 = \u0096\u007F.\u007E\u0095\u008F((object) \u008F\u0082.\u007E\u008F\u008F((object) this.\u0001), new ColumnStyle());
      \u008A\u0083.\u007E\u0090\u008F((object) \u0092\u001F.\u007E\u008A\u008F((object) this.\u0001), (Control) this.\u0001, 1, 0);
      \u008A\u0083.\u007E\u0090\u008F((object) \u0092\u001F.\u007E\u008A\u008F((object) this.\u0001), (Control) this.\u0001, 0, 1);
      \u008A\u0083.\u007E\u0090\u008F((object) \u0092\u001F.\u007E\u008A\u008F((object) this.\u0001), (Control) this.\u0001, 0, 0);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      \u0080\u0080.\u007E\u008C\u008F((object) this.\u0001, TableLayoutPanelGrowStyle.FixedSize);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0001(24558));
      \u0011\u001F.\u007E\u008D\u008F((object) this.\u0001, 2);
      int num3 = \u0098\u007F.\u007E\u0096\u008F((object) \u0016\u001C.\u007E\u008E\u008F((object) this.\u0001), new RowStyle(SizeType.Percent, 100f));
      int num4 = \u0098\u007F.\u007E\u0096\u008F((object) \u0016\u001C.\u007E\u008E\u008F((object) this.\u0001), new RowStyle());
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(200, 200));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Bottom);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0011\u001F.\u007E\u0005\u008C((object) this.\u0001, 1);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 183));
      \u0011\u001F.\u007E\u0006\u008C((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0001(24575));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(183, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0087\u007F.\u007E\u000E\u008C((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      this.\u0001.DrawingTool = \u0083.\u001B.\u0001;
      this.\u0001.DrawingToolSize = \u0007.\u0003;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(3, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0001(24592));
      this.\u0001.Origin = new Point(0, 0);
      this.\u0001.PanButton = MouseButtons.Right;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(177, 177));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      this.\u0001.ZoomFactor = 1f;
      this.\u0001.ScrollPosChanged += new EventHandler(this.\u001D\u0005);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0018.\u0001(24613));
      \u000E\u001F.\u0018\u0084((object) this, new Size(200, 200));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    public \u0005<T> \u001D\u0005<T>() where T : \u0013
    {
      return this.\u0001.\u001D\u0005<T>();
    }

    public void \u001D\u0005<T>(\u0005<T> value) where T : \u0013
    {
      this.\u0001.\u001D\u0005<T>(value);
    }

    public void \u001E\u0005()
    {
      this.\u0001.\u0083\u0005();
    }

    public void \u001F\u0005()
    {
      this.\u0001.\u0084\u0005();
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.\u0001.Image == null)
      {
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
        \u0011\u001F.\u007E\u0008\u008C((object) this.\u0001, 0);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
        \u0011\u001F.\u007E\u0008\u008C((object) this.\u0001, 0);
      }
      else
      {
        int num1 = \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001.Image);
        int num2 = \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001.Image);
        int x = this.\u0001.Origin.X;
        int y = this.\u0001.Origin.Y;
        int num3 = (int) \u0007\u0081.\u0091\u0096((double) \u0005\u0081.\u007E\u0083\u0084((object) this.\u0001) / (double) this.\u0001.ZoomFactor);
        int num4 = (int) \u0007\u0081.\u0091\u0096((double) \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001) / (double) this.\u0001.ZoomFactor);
        \u0011\u001F.\u007E\u0006\u008C((object) this.\u0001, num1);
        \u0011\u001F.\u007E\u0006\u008C((object) this.\u0001, num2);
        if (num3 >= num1)
        {
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
          \u0011\u001F.\u007E\u0008\u008C((object) this.\u0001, 0);
        }
        else
        {
          \u0011\u001F.\u007E\u0005\u008C((object) this.\u0001, num3);
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, true);
          \u0011\u001F.\u007E\u0008\u008C((object) this.\u0001, x);
        }
        if (num4 >= num2)
        {
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
          \u0011\u001F.\u007E\u0008\u008C((object) this.\u0001, 0);
        }
        else
        {
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, true);
          \u0011\u001F.\u007E\u0005\u008C((object) this.\u0001, num4);
          \u0011\u001F.\u007E\u0008\u008C((object) this.\u0001, y);
        }
      }
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u0001.Origin = new Point(\u0005\u0081.\u007E\u0007\u008C((object) this.\u0001), \u0005\u0081.\u007E\u0007\u008C((object) this.\u0001));
    }
  }
}
