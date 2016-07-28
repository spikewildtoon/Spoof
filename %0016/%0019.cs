// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0016
{
  internal sealed class \u0019 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Timer \u0001;
    private bool \u0001;
    private int \u0001;
    private Region \u0001;
    private bool \u0002;

    public int BorderSize
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
        \u0081\u007F.\u0003\u0086((object) this, this.\u0001);
        this.\u001E\u0005();
        \u0081\u007F.\u0003\u0086((object) this, this.\u0001);
      }
    }

    public bool EnableFlashing
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if (this.\u0002 == value)
          return;
        this.\u0002 = value;
        \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, this.\u0002);
        if (this.\u0002)
          return;
        this.\u0001 = false;
        \u0081\u007F.\u0003\u0086((object) this, this.\u0001);
      }
    }

    static \u0019()
    {
      \u0004.\u001D\u0005(typeof (\u0019));
    }

    public \u0019()
    {
      this.\u001D\u0005();
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      this.\u0001 = new Region();
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u009C\u0080((object) this.\u0001);
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new Timer(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 1000);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0092\u0081.\u0010\u0084((object) this, \u0019.\u0001(24648));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      if (this.\u0001)
      {
        SolidBrush solidBrush = new SolidBrush(\u0091\u0084.\u007E\u0094\u0083((object) this));
        try
        {
          \u008D\u0081.\u007E\u0099\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) solidBrush, this.\u0001);
        }
        finally
        {
          if (solidBrush != null)
            \u001A\u001E.\u007E\u0094\u0092((object) solidBrush);
        }
      }
      \u0092\u001C.\u0017\u0086((object) this, e);
    }

    private void \u001E\u0005()
    {
      \u001A\u001E.\u007E\u009D\u0080((object) this.\u0001);
      \u000E\u0080.\u007E\u009E\u0080((object) this.\u0001, new Rectangle(Point.Empty, new Size(\u0005\u0081.\u0083\u0084((object) this), this.\u0001)));
      \u000E\u0080.\u007E\u009E\u0080((object) this.\u0001, new Rectangle(new Point(0, this.\u0001), new Size(this.\u0001, \u0005\u0081.\u0098\u0083((object) this) - this.\u0001 * 2)));
      \u000E\u0080.\u007E\u009E\u0080((object) this.\u0001, new Rectangle(new Point(\u0005\u0081.\u0083\u0084((object) this) - this.\u0001, this.\u0001), new Size(this.\u0001, \u0005\u0081.\u0098\u0083((object) this) - this.\u0001 * 2)));
      \u000E\u0080.\u007E\u009E\u0080((object) this.\u0001, new Rectangle(new Point(0, \u0005\u0081.\u0098\u0083((object) this) - this.\u0001), new Size(\u0005\u0081.\u0083\u0084((object) this), this.\u0001)));
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      \u0088\u001C.\u0018\u0086((object) this, e);
      this.\u001E\u0005();
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001 = !this.\u0001;
      \u0081\u007F.\u0003\u0086((object) this, this.\u0001);
    }
  }
}
