// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u0082;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u0082
{
  internal sealed class \u001D : Control
  {
    private \u007F \u0001 = \u007F.\u0004;
    private static readonly Size \u0001 = new Size(56, 64);
    private static readonly GraphicsPath \u0001 = new GraphicsPath();

    public \u007F EstateHome
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

    public new Size Size
    {
      get
      {
        return \u001D.\u0001;
      }
      set
      {
        \u000E\u001F.\u0018\u0084((object) this, \u001D.\u0001);
      }
    }

    static \u001D()
    {
      \u008F\u0086.\u007E\u0003\u0082((object) \u001D.\u0001, new Point[10]
      {
        new Point(25, 1),
        new Point(30, 1),
        new Point(30, 10),
        new Point(53, 34),
        new Point(50, 38),
        new Point(28, 15),
        new Point(27, 15),
        new Point(5, 38),
        new Point(2, 34),
        new Point(25, 10)
      });
      \u008F\u0086.\u007E\u0003\u0082((object) \u001D.\u0001, new Point[14]
      {
        new Point(9, 40),
        new Point(27, 20),
        new Point(28, 20),
        new Point(46, 40),
        new Point(46, 62),
        new Point(33, 62),
        new Point(33, 37),
        new Point(22, 37),
        new Point(22, 42),
        new Point(33, 42),
        new Point(33, 47),
        new Point(22, 47),
        new Point(22, 62),
        new Point(9, 62)
      });
    }

    public \u001D()
    {
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    private static SolidBrush \u001D\u0005(\u007F estate)
    {
      switch (estate)
      {
        case \u007F.\u0001:
          return new SolidBrush(\u009A\u0080.\u0005\u007F());
        case \u007F.\u0002:
          return new SolidBrush(\u009A\u0080.\u0099\u001F());
        case \u007F.\u0003:
          return new SolidBrush(\u009A\u0080.\u0004\u007F());
        case \u007F.\u0005:
          return new SolidBrush(\u009A\u0080.\u0003\u007F());
        case \u007F.\u0006:
          return new SolidBrush(\u009A\u0080.\u000F\u007F());
        default:
          return new SolidBrush(\u009A\u0080.\u0091\u001F());
      }
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      if (\u0010\u007F.\u0006\u0081(\u0083\u001E.\u0017\u0084((object) this), \u001D.\u0001))
        \u000E\u001F.\u0018\u0084((object) this, \u001D.\u0001);
      \u0088\u001C.\u0018\u0086((object) this, e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      SolidBrush solidBrush1 = new SolidBrush(\u0091\u0084.\u007E\u001C\u0083((object) this));
      try
      {
        \u0001\u0080.\u007E\u0093\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) solidBrush1, \u008D\u0084.\u0082\u0083((object) this));
      }
      finally
      {
        if (solidBrush1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) solidBrush1);
      }
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.AntiAlias);
      SolidBrush solidBrush2 = \u001D.\u001D\u0005(this.\u0001);
      try
      {
        \u0098\u0081.\u007E\u0098\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) solidBrush2, \u001D.\u0001);
      }
      finally
      {
        if (solidBrush2 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) solidBrush2);
      }
      \u0092\u001C.\u0017\u0086((object) this, e);
    }
  }
}
