// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u0084
{
  internal sealed class \u0010 : Control
  {
    private bool \u0001 = true;
    private Color \u0001;

    [Category("Appearance")]
    [DefaultValue(typeof (Color), "153, 255, 54")]
    public Color BaseColor
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
        this.\u001D\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public Color DarkColor { get; private set; }

    public Color DarkDarkColor { get; private set; }

    public bool On
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

    public \u0010()
    {
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      this.\u0001 = \u001B\u001C.\u0015\u007F((int) byte.MaxValue, 153, (int) byte.MaxValue, 54);
      this.\u001D\u0005();
    }

    private void \u001D\u0005()
    {
      this.DarkColor = \u0083\u001C.\u008E\u0089(this.\u0001);
      this.DarkDarkColor = \u0083\u001C.\u008F\u0089(this.\u0001);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.AntiAlias);
      this.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e));
    }

    private void \u001D\u0005(Graphics g)
    {
      Color color1 = this.\u0001 ? this.BaseColor : this.DarkColor;
      Color color2 = this.\u0001 ? this.DarkColor : this.DarkDarkColor;
      Rectangle rectangle1 = new Rectangle(\u0097\u0086.\u0088\u0084((object) this).Left, \u0097\u0086.\u0088\u0084((object) this).Top, \u0005\u0081.\u0083\u0084((object) this) - \u0097\u0086.\u0088\u0084((object) this).Horizontal, \u0005\u0081.\u0098\u0083((object) this) - \u0097\u0086.\u0088\u0084((object) this).Vertical);
      int num = (rectangle1.Width < rectangle1.Height ? rectangle1.Width : rectangle1.Height) - 1;
      Rectangle rectangle2 = new Rectangle(rectangle1.X, rectangle1.Y, num, num);
      if (rectangle2.Width < 1)
        rectangle2.Width = 1;
      if (rectangle2.Height < 1)
        rectangle2.Height = 1;
      SolidBrush solidBrush = new SolidBrush(color2);
      try
      {
        \u0001\u0080.\u007E\u0097\u007F((object) g, (Brush) solidBrush, rectangle2);
      }
      finally
      {
        if (solidBrush != null)
          \u001A\u001E.\u007E\u0094\u0092((object) solidBrush);
      }
      GraphicsPath path = new GraphicsPath();
      try
      {
        \u000E\u0080.\u007E\u0002\u0082((object) path, rectangle2);
        PathGradientBrush pathGradientBrush1 = new PathGradientBrush(path);
        try
        {
          \u0081\u0082.\u007E\u001B\u0082((object) pathGradientBrush1, color1);
          \u008A\u0086.\u007E\u001C\u0082((object) pathGradientBrush1, new Color[1]
          {
            \u008D\u001E.\u0016\u007F(0, color1)
          });
          \u0001\u0080.\u007E\u0097\u007F((object) g, (Brush) pathGradientBrush1, rectangle2);
        }
        finally
        {
          if (pathGradientBrush1 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) pathGradientBrush1);
        }
        GraphicsPath graphicsPath1 = new GraphicsPath();
        try
        {
          \u000E\u0080.\u007E\u0002\u0082((object) graphicsPath1, rectangle2);
          \u0089\u0084.\u007E\u0005\u0080((object) g, graphicsPath1);
        }
        finally
        {
          if (graphicsPath1 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) graphicsPath1);
        }
        GraphicsPath graphicsPath2 = new GraphicsPath();
        try
        {
          Rectangle rectangle3 = new Rectangle(rectangle2.X - \u0013\u0081.\u001A\u0095((float) rectangle2.Width * 0.15f), rectangle2.Y - \u0013\u0081.\u001A\u0095((float) rectangle2.Width * 0.15f), \u0013\u0081.\u001A\u0095((float) rectangle2.Width * 0.8f), \u0013\u0081.\u001A\u0095((float) rectangle2.Height * 0.8f));
          \u000E\u0080.\u007E\u0002\u0082((object) graphicsPath2, rectangle3);
          PathGradientBrush pathGradientBrush2 = new PathGradientBrush(path);
          try
          {
            \u0081\u0082.\u007E\u001B\u0082((object) pathGradientBrush2, \u001B\u001C.\u0015\u007F(180, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
            \u008A\u0086.\u007E\u001C\u0082((object) pathGradientBrush2, new Color[1]
            {
              \u001B\u001C.\u0015\u007F(0, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
            });
            \u0001\u0080.\u007E\u0097\u007F((object) g, (Brush) pathGradientBrush2, rectangle3);
          }
          finally
          {
            if (pathGradientBrush2 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) pathGradientBrush2);
          }
        }
        finally
        {
          if (graphicsPath2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) graphicsPath2);
        }
      }
      finally
      {
        if (path != null)
          \u001A\u001E.\u007E\u0094\u0092((object) path);
      }
      \u000E\u0080.\u007E\u0004\u0080((object) g, \u008D\u0084.\u0082\u0083((object) this));
      if (!this.\u0001)
        return;
      Pen pen = new Pen(\u008D\u001E.\u0016\u007F(85, \u009A\u0080.\u0090\u001F()), 1f);
      try
      {
        \u0007\u0084.\u007E\u008F\u007F((object) g, pen, rectangle2);
      }
      finally
      {
        if (pen != null)
          \u001A\u001E.\u007E\u0094\u0092((object) pen);
      }
    }
  }
}
