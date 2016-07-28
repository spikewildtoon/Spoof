// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u001E;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u0016
{
  internal sealed class \u0013 : UserControl
  {
    private int \u0001 = 8;
    private Size \u0001 = new Size(16, 16);
    private List<\u0013.\u0001> \u0001 = new List<\u0013.\u0001>();
    private int \u0003 = 6;
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Timer \u0001;
    private bool \u0001;
    private int \u0002;
    private bool \u0002;
    private Color \u0001;
    private Color \u0002;
    private Color \u0003;
    private int \u0004;

    public Color SurroundColor
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
        this.\u001F\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public Color CenterColor
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
        this.\u001F\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public Color BorderColor
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
        this.\u001F\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public int OffsetAngle
    {
      get
      {
        return this.\u0004;
      }
      set
      {
        if (this.\u0004 == value)
          return;
        this.\u0004 = value;
        this.\u001F\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public bool Running
    {
      get
      {
        return \u0099\u0082.\u007E\u009E\u008F((object) this.\u0001);
      }
      set
      {
        \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, value);
      }
    }

    static \u0013()
    {
      \u0004.\u001D\u0005(typeof (\u0013));
    }

    public \u0013()
    {
      this.SurroundColor = \u001B\u001C.\u0015\u007F((int) byte.MaxValue, 177, 234, 250);
      this.CenterColor = \u001B\u001C.\u0015\u007F((int) byte.MaxValue, 82, 160, 239);
      this.BorderColor = \u001B\u001C.\u0015\u007F((int) byte.MaxValue, 158, 242, 239);
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      this.\u001E\u0005();
      this.\u001F\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        goto label_3;
label_2:
      \u0099\u001F.\u009A\u0086((object) this, disposing);
      return;
label_3:
      this.\u001D\u0005();
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
        goto label_2;
      }
      else
        goto label_2;
    }

    private void \u001D\u0005()
    {
      foreach (\u0013.\u0001 obj in this.\u0001)
        obj.Dispose();
      this.\u0001.Clear();
    }

    private void \u001E\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new Timer(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 50);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0092\u0081.\u0010\u0084((object) this, \u0013.\u0001(16056));
      \u000E\u001F.\u0018\u0084((object) this, new Size(100, 100));
      \u0087\u007F.\u0019\u0084((object) this, new EventHandler(this.\u001E\u0005));
      \u0007\u0086.\u008A\u0084((object) this, new PaintEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001D\u0005(object sender, PaintEventArgs e)
    {
      this.\u0001 = false;
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.AntiAlias);
      using (List<\u0013.\u0001>.Enumerator enumerator = this.\u0001.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          PathGradientBrush pathGradientBrush = new PathGradientBrush(enumerator.Current.\u0001);
          try
          {
            \u0017\u0083.\u007E\u001D\u0082((object) pathGradientBrush, \u001C\u0086.\u001E\u0080(enumerator.Current.\u0001));
            \u0081\u0082.\u007E\u001B\u0082((object) pathGradientBrush, \u008D\u001E.\u0016\u007F(enumerator.Current.\u0001, this.\u0002));
            \u0017\u0083.\u007E\u001F\u0082((object) pathGradientBrush, new PointF(0.0f, 0.0f));
            \u0014\u001F.\u007E\u001E\u0082((object) pathGradientBrush, 0.0f, 0.8429412f);
            \u008A\u0086.\u007E\u001C\u0082((object) pathGradientBrush, new Color[1]
            {
              \u008D\u001E.\u0016\u007F(enumerator.Current.\u0001, this.\u0001)
            });
            \u0001\u0080.\u007E\u0097\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) pathGradientBrush, enumerator.Current.\u0001);
            Pen pen = new Pen(\u008D\u001E.\u0016\u007F(enumerator.Current.\u0001, this.\u0003));
            try
            {
              \u0007\u0084.\u007E\u008F\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, enumerator.Current.\u0001);
            }
            finally
            {
              if (pen != null)
                \u001A\u001E.\u007E\u0094\u0092((object) pen);
            }
          }
          finally
          {
            if (pathGradientBrush != null)
              \u001A\u001E.\u007E\u0094\u0092((object) pathGradientBrush);
          }
        }
      }
    }

    private void \u001F\u0005()
    {
      this.\u001D\u0005();
      Point point1 = new Point(\u0005\u0081.\u0083\u0084((object) this) / 2, \u0005\u0081.\u0098\u0083((object) this) / 2);
      for (int index = 0; index < this.\u0001; ++index)
      {
        double num1 = \u0082.\u0001.\u001D\u0005((double) ((360 / this.\u0001 * index + this.\u0004) % 360));
        int num2 = \u0099\u0081.\u009F\u0096(\u0005\u0081.\u0083\u0084((object) this) - this.\u0001.Width - \u0097\u0086.\u0002\u0084((object) this).Horizontal, \u0005\u0081.\u0098\u0083((object) this) - this.\u0001.Height - \u0097\u0086.\u0002\u0084((object) this).Vertical) / 2;
        Point point2 = new Point((int) \u0007\u0081.\u0096\u0096((double) point1.X + (double) num2 * \u0007\u0081.\u0092\u0096(num1)), (int) \u0007\u0081.\u0096\u0096((double) point1.Y + (double) num2 * \u0007\u0081.\u0095\u0096(num1)));
        Point location = new Point(point2.X - this.\u0001.Width / 2, point2.Y - this.\u0001.Height / 2);
        \u0013.\u0001 obj = (\u0013.\u0001) null;
        try
        {
          obj = new \u0013.\u0001();
          obj.\u0001 = new Rectangle(location, this.\u0001);
          obj.\u0001 = new GraphicsPath();
          \u000E\u0080.\u007E\u0002\u0082((object) obj.\u0001, obj.\u0001);
          obj.\u0001 = point2;
          this.\u0001.Add(obj);
        }
        catch (Exception ex)
        {
          if (obj != null)
            obj.Dispose();
          ex.\u001D\u0005();
        }
      }
      this.\u007F\u0005();
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.\u0001)
        return;
      this.\u0001 = true;
      if (this.\u0002)
      {
        for (int index = 0; index < this.\u0001.Count; ++index)
        {
          if (index == this.\u0002)
            continue;
          this.\u0001[index].\u0001 -= (int) ((double) byte.MaxValue * (1.0 / (double) this.\u0003));
          if (this.\u0001[index].\u0001 < 0)
            this.\u0001[index].\u0001 = 0;
        }
      }
      else
      {
        ++this.\u0002;
        if (this.\u0002 >= this.\u0001)
          this.\u0002 = 0;
        this.\u007F\u0005();
      }
      this.\u0002 = !this.\u0002;
      \u001A\u001E.\u0004\u0086((object) this);
    }

    private void \u007F\u0005()
    {
      int num = (int) byte.MaxValue;
      foreach (\u0013.\u0001 obj in this.\u0001)
        obj.\u0001 = 0;
      int index1 = this.\u0002;
      for (int index2 = 0; index2 < this.\u0003; ++index2)
      {
        if (index1 > this.\u0001 - 1)
          index1 = 0;
        this.\u0001[index1].\u0001 = (int) ((double) num * (((double) index2 + 1.0) / (double) this.\u0003));
        ++index1;
      }
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u001F\u0005();
    }

    private sealed class \u0001 : IDisposable
    {
      public GraphicsPath \u0001;
      public Rectangle \u0001;
      public Point \u0001;
      public int \u0001;

      public void Dispose()
      {
        if (this.\u0001 == null)
          return;
        \u001A\u001E.\u007E\u009A\u0081((object) this.\u0001);
        this.\u0001 = (GraphicsPath) null;
      }
    }
  }
}
