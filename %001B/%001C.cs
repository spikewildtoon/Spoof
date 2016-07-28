// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0019;
using \u0080;
using \u0081;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u001B
{
  internal sealed class \u001C : Panel
  {
    private IContainer \u0001;
    private int \u0001;
    private Color \u0001;
    private Image \u0001;
    private Rectangle \u0001;

    public Point ImageLocation
    {
      get
      {
        return this.\u0001.Location;
      }
      set
      {
        if (!\u001D\u0081.\u007F\u0080(this.\u0001.Location, value))
          return;
        this.ImageBounds = new Rectangle(value, this.ImageBounds.Size);
      }
    }

    public Rectangle ImageBounds
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (!\u0019\u007F.\u0095\u0080(this.\u0001, value))
          return;
        if (this.\u0001.\u001D\u0005())
          \u000E\u0080.\u0005\u0086((object) this, this.\u0001);
        this.\u0001 = value;
        if (!this.\u0001.\u001D\u0005())
          return;
        \u000E\u0080.\u0005\u0086((object) this, this.\u0001);
      }
    }

    [DefaultValue(typeof (Image), null)]
    public Image Image
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
        if (!\u0010\u007F.\u0006\u0081(this.\u0001.Size, Size.Empty))
          return;
        \u000E\u0080.\u0005\u0086((object) this, this.\u0001);
      }
    }

    [Category("Appearance")]
    public int HeaderHeight
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
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    [Category("Appearance")]
    public Color CenterColor
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (!\u0097\u001D.\u001A\u007F(this.\u0001, value))
          return;
        this.\u0001 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public \u001C()
    {
      this.\u001D\u0005();
      this.\u0001 = \u009A\u0080.\u0008\u007F();
      this.\u0001 = 30;
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009D\u0084((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0092\u001C.\u0017\u0086((object) this, e);
      int num = \u0005\u0081.\u0098\u0083((object) this) - \u0097\u0086.\u0002\u0084((object) this).Vertical;
      int width = \u0005\u0081.\u0083\u0084((object) this) - \u0097\u0086.\u0002\u0084((object) this).Horizontal;
      GraphicsPath graphicsPath = \u001F.\u001D\u0005(new Rectangle(\u0097\u0086.\u0002\u0084((object) this).Left, \u0097\u0086.\u0002\u0084((object) this).Top, width, this.\u0001), 5, \u001A.\u0002 | \u001A.\u0003);
      try
      {
        LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(\u0097\u0086.\u0002\u0084((object) this).Left, \u0097\u0086.\u0002\u0084((object) this).Top), new Point(\u0097\u0086.\u0002\u0084((object) this).Left, this.\u0001 + \u0097\u0086.\u0002\u0084((object) this).Top), \u009A\u0080.\u0008\u007F(), \u009A\u0080.\u009D\u001F());
        try
        {
          Point point1 = new Point(\u0097\u0086.\u0002\u0084((object) this).Left, \u0005\u0081.\u0098\u0083((object) this) - \u0097\u0086.\u0002\u0084((object) this).Bottom);
          Point point2 = new Point(\u0005\u0081.\u0083\u0084((object) this) - \u0097\u0086.\u0002\u0084((object) this).Right, \u0005\u0081.\u0098\u0083((object) this) - \u0097\u0086.\u0002\u0084((object) this).Bottom);
          Point point3 = new Point(\u0097\u0086.\u0002\u0084((object) this).Left, this.\u0001 + \u0097\u0086.\u0002\u0084((object) this).Top);
          Point point4 = new Point(point2.X, point3.Y);
          Rectangle rectangle = new Rectangle(\u0097\u0086.\u0002\u0084((object) this).Left, \u0097\u0086.\u0002\u0084((object) this).Top + this.\u0001, width, num - this.\u0001);
          SolidBrush solidBrush = new SolidBrush(this.\u0001);
          try
          {
            \u0001\u0080.\u007E\u0093\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) solidBrush, rectangle);
          }
          finally
          {
            if (solidBrush != null)
              \u001A\u001E.\u007E\u0094\u0092((object) solidBrush);
          }
          \u0084\u0081.\u007E\u008B\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), \u0012\u001E.\u0018\u0080(), point3, point1);
          \u0084\u0081.\u007E\u008B\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), \u0012\u001E.\u0018\u0080(), point1, point2);
          \u0084\u0081.\u007E\u008B\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), \u0012\u001E.\u0018\u0080(), point2, point4);
          \u0098\u0081.\u007E\u0098\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) linearGradientBrush, graphicsPath);
          \u008A\u0082.\u007E\u0090\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), \u0012\u001E.\u0018\u0080(), graphicsPath);
          if (!this.\u0001.\u001D\u0005() || this.\u0001 == null)
            return;
          \u000E\u0080.\u007E\u0001\u0082((object) graphicsPath, rectangle);
          \u0089\u0084.\u007E\u0005\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e), graphicsPath);
          \u0004\u001F.\u007E\u009E\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0001, this.\u0001);
          \u001A\u001E.\u007E\u0006\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e));
        }
        finally
        {
          if (linearGradientBrush != null)
            \u001A\u001E.\u007E\u0094\u0092((object) linearGradientBrush);
        }
      }
      finally
      {
        if (graphicsPath != null)
          \u001A\u001E.\u007E\u0094\u0092((object) graphicsPath);
      }
    }
  }
}
