// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001D;
using \u001E;
using \u0080;
using \u0082;
using \u0083;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u001D
{
  internal sealed class \u0003 : Control
  {
    private \u0019 \u0001 = \u0019.\u0002;
    private Bitmap \u0001;
    private Region \u0001;
    private Region \u0002;
    private Rectangle \u0001;
    private Rectangle \u0002;
    private Color \u0001;
    private Color \u0002;
    private Color \u0003;
    private Color \u0004;
    private Color \u0005;
    private bool \u0001;
    private bool \u0002;

    public string LockedMessage { get; set; }

    public string MovableMessage { get; set; }

    public string MovableResizeMessage { get; set; }

    public bool FullScreen
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

    public Color WindowRegionOverlayColor
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if (!\u0097\u001D.\u001A\u007F(this.\u0002, value))
          return;
        this.\u0002 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public Color CloseMessageTextColor
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

    public Color CloseMessageBorderTextColor
    {
      get
      {
        return this.\u0003;
      }
      set
      {
        if (!\u0097\u001D.\u001A\u007F(this.\u0003, value))
          return;
        this.\u0003 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public Rectangle SelectedRegion
    {
      get
      {
        return this.\u0001.\u001D\u0005();
      }
      set
      {
        if (!\u0019\u007F.\u0095\u0080(this.\u0001, value))
          return;
        this.\u0001 = value.\u001D\u0005();
        this.\u001D\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public \u0019 SelectorType
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
      }
    }

    public Color BorderColor
    {
      get
      {
        return this.\u0004;
      }
      set
      {
        if (!\u0097\u001D.\u001A\u007F(this.\u0004, value))
          return;
        this.\u0004 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public Color BackgroundOverlayColor
    {
      get
      {
        return this.\u0005;
      }
      set
      {
        if (!\u0097\u001D.\u001A\u007F(this.\u0005, value))
          return;
        this.\u0005 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public Bitmap ScreenCapture
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

    public Rectangle SelectionBounds
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if (!\u0019\u007F.\u0095\u0080(this.\u0002, value))
          return;
        this.\u0002 = value;
        this.\u001E\u0005();
        this.\u001D\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public \u0003()
    {
      this.LockedMessage = string.Empty;
      this.MovableMessage = string.Empty;
      this.MovableResizeMessage = string.Empty;
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0002 != null)
        \u001A\u001E.\u007E\u009C\u0080((object) this.\u0002);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u009C\u0080((object) this.\u0001);
      \u0099\u001F.\u009D\u0084((object) this, disposing);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      this.\u001E\u0005();
      this.\u001D\u0005();
      \u001A\u001E.\u0004\u0086((object) this);
      \u0088\u001C.\u0018\u0086((object) this, e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.HighQuality);
      if (this.\u0001 != null)
      {
        \u0004\u001F.\u007E\u009E\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Image) this.\u0001, \u008D\u0084.\u0082\u0083((object) this));
        if (this.\u0002 != null)
        {
          SolidBrush solidBrush1 = new SolidBrush(this.\u0005);
          try
          {
            \u008D\u0081.\u007E\u0099\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) solidBrush1, this.\u0002);
          }
          finally
          {
            if (solidBrush1 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) solidBrush1);
          }
          if (this.\u0001 != null)
          {
            SolidBrush solidBrush2 = new SolidBrush(this.\u0002);
            try
            {
              \u008D\u0081.\u007E\u0099\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) solidBrush2, this.\u0001);
            }
            finally
            {
              if (solidBrush2 != null)
                \u001A\u001E.\u007E\u0094\u0092((object) solidBrush2);
            }
            Pen pen = new Pen(\u009A\u0080.\u0005\u007F());
            try
            {
              Rectangle rectangle = this.\u0001.\u001D\u0005();
              Point point1 = new Point(rectangle.X, rectangle.Y);
              Point point2 = new Point(point1.X + rectangle.Width, point1.Y);
              Point point3 = new Point(point1.X, point1.Y + rectangle.Height);
              Point point4 = new Point(point2.X, point2.Y + rectangle.Height);
              \u0084\u0081.\u007E\u008B\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, new Point(this.\u0002.X, point2.Y), point2);
              \u0084\u0081.\u007E\u008B\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, new Point(point4.X, this.\u0002.Y), point4);
              \u0084\u0081.\u007E\u008B\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, point3, new Point(this.\u0002.X + this.\u0002.Width, point3.Y));
              \u0084\u0081.\u007E\u008B\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, point1, new Point(point1.X, this.\u0002.Y + this.\u0002.Height));
            }
            finally
            {
              if (pen != null)
                \u001A\u001E.\u007E\u0094\u0092((object) pen);
            }
          }
          Pen pen1 = new Pen(this.\u0004, 2f);
          try
          {
            \u0007\u0084.\u007E\u008D\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen1, this.\u0002.\u001D\u0005(2, 2).\u001E\u0005(-1, -1));
          }
          finally
          {
            if (pen1 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) pen1);
          }
        }
      }
      if (this.\u0001)
      {
        StringFormat sf = new StringFormat();
        try
        {
          \u0014\u0083.\u007E\u009E\u0082((object) sf, StringAlignment.Near);
          \u0014\u0083.\u007E\u009F\u0082((object) sf, StringAlignment.Near);
          for (int index = 0; index < \u001A\u0083.\u0012\u008F().Length; ++index)
          {
            Screen screen = \u001A\u0083.\u0012\u008F()[index];
            Rectangle rectangle = new Rectangle(\u008D\u0084.\u007E\u0013\u008F((object) screen).X - \u0097\u0080.\u001E\u008F().X, \u008D\u0084.\u007E\u0013\u008F((object) screen).Y - \u0097\u0080.\u001E\u008F().Y, \u008D\u0084.\u007E\u0013\u008F((object) screen).Width, \u008D\u0084.\u007E\u0013\u008F((object) screen).Height);
            switch (this.\u0001)
            {
              case \u0019.\u0001:
                \u001B.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), \u0080\u0084.\u007E\u0092\u0083((object) this), this.MovableResizeMessage, 0.4f, \u0013\u001F.\u0097\u0082(rectangle), this.CloseMessageTextColor, this.\u0003, sf);
                break;
              case \u0019.\u0002:
                \u001B.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), \u0080\u0084.\u007E\u0092\u0083((object) this), this.MovableMessage, 0.4f, \u0013\u001F.\u0097\u0082(rectangle), this.CloseMessageTextColor, this.\u0003, sf);
                break;
              case \u0019.\u0003:
                \u001B.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), \u0080\u0084.\u007E\u0092\u0083((object) this), this.LockedMessage, 0.4f, \u0013\u001F.\u0097\u0082(rectangle), this.CloseMessageTextColor, this.\u0003, sf);
                break;
            }
          }
        }
        finally
        {
          if (sf != null)
            \u001A\u001E.\u007E\u0094\u0092((object) sf);
        }
      }
      else
      {
        StringFormat sf = new StringFormat();
        try
        {
          \u0014\u0083.\u007E\u009E\u0082((object) sf, StringAlignment.Near);
          \u0014\u0083.\u007E\u009F\u0082((object) sf, StringAlignment.Near);
          \u0011\u0083.\u007E\u0002\u0083((object) sf, StringTrimming.None);
          \u001D\u0083.\u007E\u009D\u0082((object) sf, StringFormatFlags.NoClip);
          SizeF sizeF = SizeF.Empty;
          switch (this.\u0001)
          {
            case \u0019.\u0001:
              sizeF = \u0002\u0081.\u007E\u009C\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.MovableResizeMessage, \u0080\u0084.\u007E\u0092\u0083((object) this), \u008D\u001F.\u0002\u0081(\u0083\u001E.\u0083\u0083((object) this)), sf);
              break;
            case \u0019.\u0002:
              sizeF = \u0002\u0081.\u007E\u009C\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.MovableMessage, \u0080\u0084.\u007E\u0092\u0083((object) this), \u008D\u001F.\u0002\u0081(\u0083\u001E.\u0083\u0083((object) this)), sf);
              break;
            case \u0019.\u0003:
              sizeF = \u0002\u0081.\u007E\u009C\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.LockedMessage, \u0080\u0084.\u007E\u0092\u0083((object) this), \u008D\u001F.\u0002\u0081(\u0083\u001E.\u0083\u0083((object) this)), sf);
              break;
          }
          if ((double) sizeF.Width <= (double) \u0083\u001E.\u0083\u0083((object) this).Width)
          {
            if ((double) sizeF.Height <= (double) \u0083\u001E.\u0083\u0083((object) this).Height)
            {
              switch (this.\u0001)
              {
                case \u0019.\u0001:
                  \u001B.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), \u0080\u0084.\u007E\u0092\u0083((object) this), this.MovableResizeMessage, 0.4f, \u0013\u001F.\u0097\u0082(\u008D\u0084.\u0082\u0083((object) this)), this.CloseMessageTextColor, this.\u0003, sf);
                  break;
                case \u0019.\u0002:
                  \u001B.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), \u0080\u0084.\u007E\u0092\u0083((object) this), this.MovableMessage, 0.4f, \u0013\u001F.\u0097\u0082(\u008D\u0084.\u0082\u0083((object) this)), this.CloseMessageTextColor, this.\u0003, sf);
                  break;
                case \u0019.\u0003:
                  \u001B.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), \u0080\u0084.\u007E\u0092\u0083((object) this), this.LockedMessage, 0.4f, \u0013\u001F.\u0097\u0082(\u008D\u0084.\u0082\u0083((object) this)), this.CloseMessageTextColor, this.\u0003, sf);
                  break;
              }
            }
          }
        }
        finally
        {
          if (sf != null)
            \u001A\u001E.\u007E\u0094\u0092((object) sf);
        }
      }
      \u0092\u001C.\u0017\u0086((object) this, e);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      if (\u0094\u0080.\u007E\u008C\u008A((object) e) == MouseButtons.Left)
        goto label_5;
label_4:
      \u001E\u001C.\u0012\u0086((object) this, e);
      return;
label_5:
      switch (this.\u0001)
      {
        case \u0019.\u0001:
          if (this.\u0002.Contains(\u008E\u0084.\u007E\u0090\u008A((object) e)))
          {
            this.\u0001.Location = \u008E\u0084.\u007E\u0090\u008A((object) e);
            this.\u0001.Size = Size.Empty;
            this.\u001D\u0005();
            \u000E\u0080.\u0005\u0086((object) this, this.\u0002);
            this.\u0002 = true;
            goto label_4;
          }
          else
            goto label_4;
        case \u0019.\u0002:
          if (this.\u0002.Contains(\u008E\u0084.\u007E\u0090\u008A((object) e)))
          {
            this.\u0001.Location = \u0003.\u001D\u0005(new Point(\u0005\u0081.\u007E\u008D\u008A((object) e) - this.\u0001.Width / 2, \u0005\u0081.\u007E\u008E\u008A((object) e) - this.\u0001.Height / 2), this.\u0001.Size, this.\u0002);
            this.\u001D\u0005();
            \u000E\u0080.\u0005\u0086((object) this, this.\u0002);
            this.\u0002 = true;
            goto label_4;
          }
          else
            goto label_4;
        default:
          goto label_4;
      }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      if (this.\u0002)
      {
        Point point = \u008E\u0084.\u007E\u0090\u008A((object) e).\u001D\u0005(this.\u0002);
        switch (this.\u0001)
        {
          case \u0019.\u0001:
            this.\u0001.Size = new Size(point.X - this.\u0001.X, point.Y - this.\u0001.Y);
            this.\u001D\u0005();
            \u000E\u0080.\u0005\u0086((object) this, this.\u0002);
            break;
          case \u0019.\u0002:
            this.\u0001.Location = \u0003.\u001D\u0005(new Point(point.X - this.\u0001.Width / 2, point.Y - this.\u0001.Height / 2), this.\u0001.Size, this.\u0002);
            this.\u001D\u0005();
            \u000E\u0080.\u0005\u0086((object) this, this.\u0002);
            break;
        }
      }
      \u001E\u001C.\u0015\u0086((object) this, e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      this.\u0002 = false;
      \u001E\u001C.\u0016\u0086((object) this, e);
    }

    private static Point \u001D\u0005(Point p, Size sz, Rectangle max)
    {
      if (p.X + sz.Width > max.Right)
        p.X = max.Right - sz.Width;
      if (p.X < max.Left)
        p.X = max.Left;
      if (p.Y + sz.Height > max.Bottom)
        p.Y = max.Bottom - sz.Height;
      if (p.Y < max.Top)
        p.Y = max.Top;
      return p;
    }

    private void \u001D\u0005()
    {
      if (this.\u0001 == null)
        return;
      if (\u0019\u007F.\u0094\u0080(this.\u0002, Rectangle.Empty))
      {
        if (this.\u0001 == null)
          return;
        \u001A\u001E.\u007E\u009C\u0080((object) this.\u0001);
        this.\u0001 = (Region) null;
      }
      else
      {
        if (this.\u0001 != null)
          \u001A\u001E.\u007E\u009D\u0080((object) this.\u0001);
        else
          goto label_9;
label_6:
        \u000E\u0080.\u007E\u009E\u0080((object) this.\u0001, this.\u0002);
        \u000E\u0080.\u007E\u009F\u0080((object) this.\u0001, this.\u0001);
        return;
label_9:
        this.\u0001 = new Region();
        goto label_6;
      }
    }

    private void \u001E\u0005()
    {
      if (this.\u0001 == null)
        return;
      if (this.\u0002 != null)
        \u001A\u001E.\u007E\u009D\u0080((object) this.\u0002);
      else
        goto label_5;
label_2:
      \u000E\u0080.\u007E\u009E\u0080((object) this.\u0002, \u008D\u0084.\u0082\u0083((object) this));
      \u000E\u0080.\u007E\u009F\u0080((object) this.\u0002, this.\u0002);
      return;
label_5:
      this.\u0002 = new Region();
      goto label_2;
    }
  }
}
