// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0019;
using \u001A;
using \u001B;
using \u001F;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u001F
{
  internal sealed class \u0012 : UserControl
  {
    private float \u0001 = 1f;
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private SolidBrush \u0001;
    private Pen \u0001;
    private SolidBrush \u0002;
    private Pen \u0002;
    private SolidBrush \u0003;
    private Point \u0001;
    private Rectangle \u0001;
    private Bitmap \u0001;
    private Graphics \u0001;
    private Bitmap \u0002;
    private Color \u0001;
    private Rectangle? \u0001;
    private bool \u0001;
    private bool \u0002;

    public \u0007 DrawingToolSize { get; set; }

    public \u0083.\u001B DrawingTool { get; set; }

    [DefaultValue(typeof (Bitmap), null)]
    public Bitmap Image
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
        this.\u001E\u0005();
        if (this.\u0001 != null)
          goto label_4;
label_2:
        this.\u0001 = Rectangle.Empty;
        this.\u0001 = 1f;
        this.\u0086\u0005();
        this.\u0087\u0005();
        this.\u0081\u0005();
        this.\u0080\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
        return;
label_4:
        this.\u007F\u0005();
        this.\u001F\u0005();
        goto label_2;
      }
    }

    public Bitmap Overlay
    {
      get
      {
        return this.\u0002;
      }
    }

    public MouseButtons PanButton { get; set; }

    public Point Origin
    {
      get
      {
        return this.\u0001.Location;
      }
      set
      {
        if (!\u001D\u0081.\u007F\u0080(this.\u0001.Location, value))
          return;
        this.\u0001.Location = value;
        this.\u0088\u0005();
        this.\u0080\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public float ZoomFactor
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if ((double) this.\u0001 == (double) value)
          return;
        this.\u0001 = value;
        if ((double) this.\u0001 > 15.0)
          this.\u0001 = 15f;
        if ((double) this.\u0001 < 0.0500000007450581)
          this.\u0001 = 0.05f;
        if (this.\u0001 != null)
        {
          this.\u0087\u0005();
          this.\u0081\u0005();
          this.\u0088\u0005();
        }
        if (this.CursorRectangle.HasValue)
          this.\u0082\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    private Rectangle? CursorRectangle
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        Rectangle? nullable1 = this.\u0001;
        Rectangle? nullable2 = value;
        if ((nullable1.HasValue != nullable2.HasValue ? 1 : (!nullable1.HasValue ? 0 : (\u0019\u007F.\u0095\u0080(nullable1.GetValueOrDefault(), nullable2.GetValueOrDefault()) ? 1 : 0))) == 0)
          return;
        this.\u0001 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public event EventHandler ScrollPosChanged;

    static \u0012()
    {
      \u0004.\u001D\u0005(typeof (\u0012));
    }

    public \u0012()
    {
      this.\u001D\u0005();
      this.\u0001 = \u001B\u001C.\u0015\u007F(160, 64, 233, 96);
      this.\u0001 = new SolidBrush(this.\u0001);
      this.\u0001 = new Pen((Brush) this.\u0001, 0.0f);
      this.\u0002 = new SolidBrush(\u001B\u001C.\u0015\u007F(0, 0, 0, 0));
      this.\u0002 = new Pen((Brush) this.\u0002, 0.0f);
      this.\u0003 = new SolidBrush(\u001B\u001C.\u0015\u007F(195, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
      this.DrawingTool = \u0083.\u001B.\u0001;
      this.PanButton = MouseButtons.Right;
      this.DrawingToolSize = \u0007.\u0003;
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
    }

    public \u0005<T> \u001D\u0005<T>() where T : \u0013
    {
      \u0082 alpha_bitmap = new \u0082(this.\u0002);
      try
      {
        \u0082 color_bitmap = new \u0082(this.\u0001);
        try
        {
          return new \u0005<T>(alpha_bitmap, color_bitmap);
        }
        finally
        {
          if (color_bitmap != null)
            \u001A\u001E.\u007E\u0094\u0092((object) color_bitmap);
        }
      }
      finally
      {
        if (alpha_bitmap != null)
          \u001A\u001E.\u007E\u0094\u0092((object) alpha_bitmap);
      }
    }

    public void \u001D\u0005<T>(\u0005<T> value) where T : \u0013
    {
      this.\u001E\u0005();
      if (value != null)
        goto label_6;
      else
        goto label_4;
label_3:
      this.\u001F\u0005();
      return;
label_4:
      if (this.\u0001 != null)
      {
        this.\u007F\u0005();
        goto label_3;
      }
      else
        goto label_3;
label_6:
      if (this.\u0001 == null)
        throw new InvalidOperationException(\u0012.\u0001(69650));
      this.\u0002 = value.\u001D\u0005(new Color?(this.\u0001));
      goto label_3;
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0002 != null)
        \u001A\u001E.\u007E\u0013\u0080((object) this.\u0002);
      if (this.\u0003 != null)
        \u001A\u001E.\u007E\u008B\u001F((object) this.\u0003);
      if (this.\u0002 != null)
        \u001A\u001E.\u007E\u008B\u001F((object) this.\u0002);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u0013\u0080((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u001E\u007F((object) this.\u0001);
      if (this.\u0002 != null)
        \u001A\u001E.\u007E\u001D\u001F((object) this.\u0002);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u008B\u001F((object) this.\u0001);
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001E\u0005()
    {
      if (this.\u0002 == null)
        return;
      \u001A\u001E.\u007E\u001D\u001F((object) this.\u0002);
      \u001A\u001E.\u007E\u001E\u007F((object) this.\u0001);
      this.\u0002 = (Bitmap) null;
      this.\u0001 = (Graphics) null;
    }

    private void \u001F\u0005()
    {
      this.\u0001 = \u0005\u0087.\u001D\u007F((System.Drawing.Image) this.\u0002);
      \u0098\u0083.\u007E\u001F\u007F((object) this.\u0001, CompositingMode.SourceCopy);
    }

    private void \u007F\u0005()
    {
      this.\u0002 = new Bitmap(\u0005\u0081.\u007E\u007F\u001F((object) this.\u0001), \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001));
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0092\u001C.\u0017\u0086((object) this, e);
      \u0081\u0082.\u007E\u0091\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), \u0091\u0084.\u007E\u001C\u0083((object) this));
      if (this.\u0001 == null)
        return;
      \u0090\u001D.\u007E\u0082\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), PixelOffsetMode.Half);
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.None);
      \u0094\u0081.\u007E\u0083\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), InterpolationMode.NearestNeighbor);
      \u008C\u0082.\u007E\u0002\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (System.Drawing.Image) this.\u0001, \u008D\u0084.\u0082\u0083((object) this), this.\u0001, GraphicsUnit.Pixel);
      \u008C\u0082.\u007E\u0002\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (System.Drawing.Image) this.\u0002, \u008D\u0084.\u0082\u0083((object) this), this.\u0001, GraphicsUnit.Pixel);
      if (!this.CursorRectangle.HasValue)
        return;
      switch (this.DrawingTool)
      {
        case \u0083.\u001B.\u0002:
          \u0001\u0080.\u007E\u0097\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) this.\u0001, this.CursorRectangle.Value);
          break;
        case \u0083.\u001B.\u0003:
          \u0001\u0080.\u007E\u0097\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) this.\u0003, this.CursorRectangle.Value);
          break;
      }
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      this.\u0081\u0005();
      \u0088\u001C.\u0018\u0086((object) this, e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      \u001E\u001C.\u0015\u0086((object) this, e);
      if (this.\u0001 == null)
        return;
      if (!this.\u0001)
      {
        if (this.\u0002)
          this.\u001E\u0005(\u008E\u0084.\u007E\u0090\u008A((object) e));
      }
      else
        goto label_8;
label_5:
      this.\u0001 = \u008E\u0084.\u007E\u0090\u008A((object) e);
      switch (this.DrawingTool)
      {
        case \u0083.\u001B.\u0002:
        case \u0083.\u001B.\u0003:
          this.\u0082\u0005();
          return;
        default:
          return;
      }
label_8:
      this.Origin = new Point(this.\u0001.X + (int) ((double) (this.\u0001.X - \u0005\u0081.\u007E\u008D\u008A((object) e)) / (double) this.\u0001), this.\u0001.Y + (int) ((double) (this.\u0001.Y - \u0005\u0081.\u007E\u008E\u008A((object) e)) / (double) this.\u0001));
      goto label_5;
    }

    protected override void OnMouseEnter(EventArgs e)
    {
      this.\u0082\u0005();
      \u0088\u001C.\u0013\u0086((object) this, e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      this.CursorRectangle = new Rectangle?();
      \u0088\u001C.\u0014\u0086((object) this, e);
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
      \u001E\u001C.\u0094\u0086((object) this, e);
      if (\u0005\u0081.\u007E\u008F\u008A((object) e) <= 0)
      {
        if (\u0005\u0081.\u007E\u008F\u008A((object) e) >= 0)
          return;
        this.\u001D\u0005(false);
      }
      else
        this.\u001D\u0005(true);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      \u001E\u001C.\u0001\u0091((object) this, e);
      if (this.\u0001 == null)
        return;
      if (\u0094\u0080.\u007E\u008C\u008A((object) e) != MouseButtons.Left)
      {
        if (\u0094\u0080.\u007E\u008C\u008A((object) e) != MouseButtons.Right)
          return;
        this.\u0001 = true;
        \u0081\u001C.\u007E\u0088\u0083((object) this, \u009B\u0086.\u0008\u008A());
      }
      else
      {
        this.\u001E\u0005(\u008E\u0084.\u007E\u0090\u008A((object) e));
        this.\u0002 = true;
      }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      \u001E\u001C.\u0016\u0086((object) this, e);
      if (this.\u0001)
      {
        this.\u0001 = false;
        \u0081\u001C.\u007E\u0088\u0083((object) this, \u009B\u0086.\u0007\u008A());
      }
      else
      {
        if (!this.\u0002)
          return;
        this.\u0002 = false;
      }
    }

    protected override void OnResize(EventArgs e)
    {
      \u0088\u001C.\u009F\u0090((object) this, e);
      this.\u0081\u0005();
      this.\u0086\u0005();
    }

    private void \u0080\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u0081\u0005()
    {
      this.\u0001.Size = new Size((int) \u0007\u0081.\u0091\u0096((double) \u0005\u0081.\u0083\u0084((object) this) / (double) this.\u0001), (int) \u0007\u0081.\u0091\u0096((double) \u0005\u0081.\u0098\u0083((object) this) / (double) this.\u0001));
    }

    private void \u0082\u0005()
    {
      this.CursorRectangle = new Rectangle?(this.\u0001.\u001D\u0005(this.\u001D\u0005().\u001D\u0005(this.\u0001)));
    }

    private void \u001E\u0005(Point p)
    {
      switch (this.DrawingTool)
      {
        case \u0083.\u001B.\u0002:
          this.\u001D\u0005(p, this.\u0001, this.\u0001);
          break;
        case \u0083.\u001B.\u0003:
          this.\u001D\u0005(p, this.\u0002, this.\u0002);
          break;
      }
    }

    private void \u001D\u0005(Point point, SolidBrush sb, Pen p)
    {
      Point p1 = new Point((int) (((double) this.\u0001.X * (double) this.\u0001 + (double) this.\u0001.X) / (double) this.\u0001), (int) (((double) this.\u0001.Y * (double) this.\u0001 + (double) this.\u0001.Y) / (double) this.\u0001));
      Point p2 = new Point((int) (((double) this.\u0001.X * (double) this.\u0001 + (double) point.X) / (double) this.\u0001), (int) (((double) this.\u0001.Y * (double) this.\u0001 + (double) point.Y) / (double) this.\u0001));
      Size sz1 = this.\u001D\u0005();
      \u0082\u001E.\u007E\u0014\u0080((object) p, (float) sz1.Width);
      \u0084\u0081.\u007E\u008B\u007F((object) this.\u0001, p, p1, p2);
      \u0001\u0080.\u007E\u0097\u007F((object) this.\u0001, (Brush) sb, p1.\u001D\u0005(sz1));
      \u0001\u0080.\u007E\u0097\u007F((object) this.\u0001, (Brush) sb, p2.\u001D\u0005(sz1));
      Size sz2 = sz1.\u001D\u0005(this.\u0001);
      \u000E\u0080.\u0005\u0086((object) this, point.\u001D\u0005(sz2));
      \u000E\u0080.\u0005\u0086((object) this, this.\u0001.\u001D\u0005(sz2));
      \u000E\u0080.\u0005\u0086((object) this, \u0081\u0084.\u0082\u0080(\u0099\u0081.\u009F\u0096(point.X, this.\u0001.X), \u0099\u0081.\u009F\u0096(point.Y, this.\u0001.Y), \u0099\u0081.\u009E\u0096(point.X, this.\u0001.X), \u0099\u0081.\u009E\u0096(point.Y, this.\u0001.Y)).\u001D\u0005(sz2));
    }

    public void \u0083\u0005()
    {
      this.\u001D\u0005(true);
    }

    public void \u0084\u0005()
    {
      this.\u001D\u0005(false);
    }

    private void \u001D\u0005(bool zoomIn)
    {
      PointF pointF = new PointF((float) this.\u0001.X + (float) this.\u0001.Width / 2f, (float) this.\u0001.Y + (float) this.\u0001.Height / 2f);
      this.ZoomFactor = !zoomIn ? (float) \u0005\u0082.\u0097\u0096((double) this.\u0001 * 0.899999976158142, 2) : (float) \u0005\u0082.\u0097\u0096((double) this.\u0001 * 1.10000002384186, 2);
      this.Origin = new Point((int) ((double) pointF.X - (double) \u0083\u001E.\u0083\u0083((object) this).Width / (double) this.\u0001 / 2.0), (int) ((double) pointF.Y - (double) \u0083\u001E.\u0083\u0083((object) this).Height / (double) this.\u0001 / 2.0));
    }

    private Size \u001D\u0005()
    {
      switch (this.DrawingToolSize)
      {
        case \u0007.\u0001:
          return new Size(8, 8);
        case \u0007.\u0002:
          return new Size(16, 16);
        case \u0007.\u0003:
          return new Size(32, 32);
        case \u0007.\u0004:
          return new Size(64, 64);
        case \u0007.\u0005:
          return new Size(128, 128);
        case \u0007.\u0006:
          return new Size(256, 256);
        default:
          return Size.Empty;
      }
    }

    public void \u0086\u0005()
    {
      this.Origin = new Point(0, 0);
      if (this.\u0001 == null)
        return;
      float num = 1f;
      if (\u0010\u007F.\u0006\u0081(\u0083\u001E.\u007E\u001F\u001F((object) this.\u0001), \u0083\u001E.\u0083\u0083((object) this)))
      {
        if ((double) num * (double) \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001) > (double) \u0083\u001E.\u0083\u0083((object) this).Width)
          num = (float) \u0083\u001E.\u0083\u0083((object) this).Width / (float) \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001);
        if ((double) num * (double) \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001) > (double) \u0083\u001E.\u0083\u0083((object) this).Height)
          num = (float) \u0083\u001E.\u0083\u0083((object) this).Height / (float) \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001);
        if ((double) num * (double) \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001) < (double) \u0083\u001E.\u0083\u0083((object) this).Width)
          num = (float) \u0083\u001E.\u0083\u0083((object) this).Width / (float) \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001);
        if ((double) num * (double) \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001) < (double) \u0083\u001E.\u0083\u0083((object) this).Height)
          num = (float) \u0083\u001E.\u0083\u0083((object) this).Height / (float) \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001);
      }
      this.ZoomFactor = num;
      this.\u0080\u0005();
    }

    private void \u0087\u0005()
    {
      if (this.\u0001 == null)
        return;
      bool flag = false;
      if ((double) \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001) * (double) this.\u0001 < (double) \u0005\u0081.\u0098\u0083((object) this))
      {
        flag = true;
        this.\u0001 = (float) \u0005\u0081.\u0098\u0083((object) this) / (float) \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001);
      }
      if ((double) \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001) * (double) this.\u0001 < (double) \u0005\u0081.\u0083\u0084((object) this))
      {
        flag = true;
        this.\u0001 = (float) \u0005\u0081.\u0083\u0084((object) this) / (float) \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001);
      }
      if (!flag)
        return;
      this.\u0081\u0005();
      this.\u0088\u0005();
      \u001A\u001E.\u0004\u0086((object) this);
    }

    private void \u0088\u0005()
    {
      if (this.\u0001 == null)
        return;
      bool flag = false;
      if (this.\u0001.X < 0)
      {
        this.\u0001.X = 0;
        flag = true;
      }
      if (this.\u0001.Y < 0)
      {
        this.\u0001.Y = 0;
        flag = true;
      }
      if ((double) this.\u0001.X > (double) \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001) - (double) \u0083\u001E.\u0083\u0083((object) this).Width / (double) this.\u0001)
      {
        this.\u0001.X = \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001) - (int) ((double) \u0083\u001E.\u0083\u0083((object) this).Width / (double) this.\u0001);
        flag = true;
      }
      if (this.\u0001.Y > \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001) - (int) ((double) \u0083\u001E.\u0083\u0083((object) this).Height / (double) this.\u0001))
      {
        this.\u0001.Y = \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001) - (int) ((double) \u0083\u001E.\u0083\u0083((object) this).Height / (double) this.\u0001);
        flag = true;
      }
      if (this.\u0001.X < 0)
      {
        this.\u0001.X = 0;
        flag = true;
      }
      if (this.\u0001.Y < 0)
      {
        this.\u0001.Y = 0;
        flag = true;
      }
      if (!flag)
        return;
      this.\u0080\u0005();
    }
  }
}
