// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001F;
using \u0081;
using \u0084;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u001F
{
  [Description("Arrow Button Control")]
  [Designer(typeof (\u0018))]
  internal sealed class \u001E : Control
  {
    private static readonly int \u0001 = 24;
    private Color \u0001 = Color.WhiteSmoke;
    private Color \u0002 = Color.DarkGray;
    private Color \u0003 = Color.WhiteSmoke;
    private Color \u0004 = Color.DarkRed;
    private GraphicsPath \u0001 = new GraphicsPath();
    private BitArray \u0001 = new BitArray(2);
    private IContainer \u0001;
    private Point[] \u0001;
    private Point \u0001;
    private int \u0002;

    [Category("ArrowButton")]
    [Description("The start color")]
    public Color NormalStartColor
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

    [Category("ArrowButton")]
    [Description("The end color")]
    public Color NormalEndColor
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

    [Category("ArrowButton")]
    [Description("The hover start color")]
    public Color HoverStartColor
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

    [Description("The hover end color")]
    [Category("ArrowButton")]
    public Color HoverEndColor
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

    [Description("Pointing direction")]
    [Category("ArrowButton")]
    public int Rotation
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
        this.\u001F\u0005();
        this.\u001E\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public \u001E()
    {
      this.\u001D\u0005();
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u009A\u0081((object) this.\u0001);
      this.\u0001 = (GraphicsPath) null;
      this.\u0001 = (BitArray) null;
      this.\u0001 = (Point[]) null;
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009D\u0084((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      // ISSUE: method pointer
      \u000F\u0086.\u0097\u0084((object) this, new MouseEventHandler((object) this, __methodptr(\u001D\u0005)));
      // ISSUE: method pointer
      \u0087\u007F.\u0093\u0084((object) this, new EventHandler((object) this, __methodptr(\u001E\u0005)));
      \u0087\u007F.\u0094\u0084((object) this, new EventHandler(this.\u001D\u0005));
      \u000F\u0086.\u0092\u0084((object) this, new MouseEventHandler(this.\u001E\u0005));
    }

    private void \u001D\u0005(object sender, MouseEventArgs e)
    {
      \u008D\u007F.\u007E\u0090\u0099((object) this.\u0001, 0, false);
      \u001A\u001E.\u0004\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u008D\u007F.\u007E\u0090\u0099((object) this.\u0001, 1, false);
      \u001A\u001E.\u0004\u0086((object) this);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u008D\u007F.\u007E\u0090\u0099((object) this.\u0001, 1, true);
      \u001A\u001E.\u0004\u0086((object) this);
    }

    private void \u001E\u0005(object sender, MouseEventArgs e)
    {
      \u008D\u007F.\u007E\u0090\u0099((object) this.\u0001, 0, true);
      \u001A\u001E.\u0004\u0086((object) this);
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
      \u0088\u001C.\u0008\u0086((object) this, e);
      \u008D\u007F.\u007E\u0090\u0099((object) this.\u0001, 0, false);
      \u008D\u007F.\u007E\u0090\u0099((object) this.\u0001, 1, false);
      \u001A\u001E.\u0004\u0086((object) this);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      \u0088\u001C.\u0018\u0086((object) this, e);
      this.\u001F\u0005();
      this.\u001E\u0005();
      \u001A\u001E.\u0004\u0086((object) this);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0092\u001C.\u0017\u0086((object) this, e);
      if (!\u0099\u0082.\u0081\u0001\u0002((object) this))
        \u0089\u0084.\u007E\u0005\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0001);
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.AntiAlias);
      LinearGradientBrush linearGradientBrush = \u0095\u0081.\u007E\u008F\u0099((object) this.\u0001, 1) ? new LinearGradientBrush(\u008D\u0084.\u0082\u0083((object) this), this.\u0003, this.\u0004, 0.0f, true) : new LinearGradientBrush(\u008D\u0084.\u0082\u0083((object) this), this.\u0001, this.\u0002, 0.0f, true);
      try
      {
        \u0098\u0081.\u007E\u0098\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) linearGradientBrush, this.\u0001);
      }
      finally
      {
        if (linearGradientBrush != null)
          \u001A\u001E.\u007E\u0094\u0092((object) linearGradientBrush);
      }
      this.\u001D\u0005(e, this.\u0001);
    }

    private void \u001E\u0005()
    {
      \u001A.\u001D\u0005(this, \u001E.\u0001);
      int dx = \u0005\u0081.\u0083\u0084((object) this) - 3;
      \u007F.\u001D\u0005(dx, out this.\u0001);
      this.\u0001 = new Point(\u0005\u0081.\u0083\u0084((object) this) / 2, \u0005\u0081.\u0083\u0084((object) this) / 2);
      \u007F.\u001D\u0005(this.\u0002, this.\u0001);
      \u007F.\u001D\u0005(dx, this.\u0002, ref this.\u0001, this.\u0001);
      \u007F.\u001D\u0005(this.\u0001, this.\u0001, this.\u0001);
    }

    private void \u001F\u0005()
    {
      this.\u0001 = (Point[]) null;
      \u001A\u001E.\u007E\u009B\u0081((object) this.\u0001);
    }

    private void \u001D\u0005(PaintEventArgs e, BitArray butstate)
    {
      if (!\u0099\u0082.\u008E\u0083((object) this))
        return;
      if (!\u0095\u0081.\u007E\u008F\u0099((object) butstate, 0))
      {
        for (int index = 0; index < 7; ++index)
        {
          Pen pen = this.\u0001[index].Y <= this.\u0001[index + 1].Y ? new Pen(\u009A\u0080.\u0018\u0081(), 2f) : new Pen(\u009A\u0080.\u0017\u0081(), 2f);
          try
          {
            \u009A\u001B.\u007E\u008A\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, this.\u0001.X + this.\u0001[index].X, this.\u0001.Y + this.\u0001[index].Y, this.\u0001.X + this.\u0001[index + 1].X, this.\u0001.Y + this.\u0001[index + 1].Y);
          }
          finally
          {
            if (pen != null)
              \u001A\u001E.\u007E\u0094\u0092((object) pen);
          }
        }
      }
      else
      {
        for (int index = 0; index < 7; ++index)
        {
          Pen pen = this.\u0001[index].Y <= this.\u0001[index + 1].Y ? new Pen(\u009A\u0080.\u0017\u0081(), 2f) : new Pen(\u009A\u0080.\u0018\u0081(), 2f);
          try
          {
            \u009A\u001B.\u007E\u008A\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, this.\u0001.X + this.\u0001[index].X, this.\u0001.Y + this.\u0001[index].Y, this.\u0001.X + this.\u0001[index + 1].X, this.\u0001.Y + this.\u0001[index + 1].Y);
          }
          finally
          {
            if (pen != null)
              \u001A\u001E.\u007E\u0094\u0092((object) pen);
          }
        }
      }
    }

    private enum \u0001
    {
      \u0001,
      \u0002,
    }
  }
}
