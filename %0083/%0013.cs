// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001C;
using \u0083;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u0083
{
  internal sealed class \u0013 : Control
  {
    private Color \u0001 = SystemColors.Control;
    private Color \u0002 = SystemColors.Control;
    private Color \u0003 = SystemColors.Control;
    private RectangleF \u0001 = RectangleF.Empty;
    private Color \u0004 = SystemColors.Control;
    private Color \u0005 = SystemColors.Control;
    private int \u0002 = 3;
    private RectangleF \u0003 = RectangleF.Empty;
    private float \u0001 = 100f;
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly int \u0001;
    private \u0019 \u0001;
    private RectangleF \u0002;
    private float \u0002;
    private float \u0003;
    private int \u0003;

    public float MaxValue
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
        if ((double) this.\u0002 > (double) this.\u0001)
          this.\u0002 = this.\u0001;
        this.\u007F\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public float Value
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if ((double) this.\u0002 == (double) value)
          return;
        if ((double) value < 0.0 || (double) value > (double) this.\u0001)
          throw new ArgumentOutOfRangeException(\u0013.\u0001(102335));
        this.\u0002 = value;
        this.\u007F\u0005();
        this.\u001F\u0005();
        this.\u001D\u0005();
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    [Description("Gets or set tracker's color.")]
    [Category("Appearance")]
    public Color TrackerColor
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

    [Description("Gets or sets the color of the track line.")]
    [Category("Appearance")]
    public Color TrackLineColor
    {
      get
      {
        return this.\u0004;
      }
      set
      {
        if (!\u0097\u001D.\u001A\u007F(value, this.\u0004))
          return;
        this.\u0004 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public event EventHandler ValueChanged;

    static \u0013()
    {
      \u0004.\u001D\u0005(typeof (\u0013));
      \u0013.\u0001 = 6;
    }

    public \u0013()
    {
      this.\u0001 = \u008E\u001D.\u0017\u007F(24, 130, 198);
      this.\u0003 = \u008E\u001D.\u0017\u007F(43, 86, 114);
      this.\u0002 = \u008E\u001D.\u0017\u007F(92, 185, 245);
      this.\u0005 = \u008E\u001D.\u0017\u007F(92, 185, 245);
      this.\u0004 = \u008E\u001D.\u0017\u007F(90, 93, 90);
      this.\u0001.Width = 20f;
      this.\u0001.Height = 20f;
      this.\u0002 = 3;
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.ResizeRedraw | ControlStyles.UserMouse | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    private void \u001D\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u001E\u0005()
    {
      this.\u0003 = new RectangleF((float) (\u0097\u0086.\u0002\u0084((object) this).Left + \u0013.\u0001), (float) ((double) \u0005\u0081.\u0098\u0083((object) this) / 2.0 - (double) this.\u0002 / 2.0), (float) (\u0005\u0081.\u0083\u0084((object) this) - \u0097\u0086.\u0002\u0084((object) this).Horizontal - \u0013.\u0001 * 2), (float) this.\u0002);
    }

    private void \u001F\u0005()
    {
      this.\u0002 = new RectangleF((float) (\u0097\u0086.\u0002\u0084((object) this).Left + \u0013.\u0001), (float) ((double) \u0005\u0081.\u0098\u0083((object) this) / 2.0 - (double) this.\u0002 / 2.0), this.\u0001.X - (float) \u0097\u0086.\u0002\u0084((object) this).Left, (float) this.\u0002);
    }

    private void \u007F\u0005()
    {
      this.\u0001.X = ((float) (\u0005\u0081.\u0083\u0084((object) this) - \u0097\u0086.\u0002\u0084((object) this).Horizontal) - this.\u0001.Width) * this.\u0002 / this.\u0001 + (float) \u0097\u0086.\u0002\u0084((object) this).Left;
      this.\u0001.Y = (float) ((double) \u0005\u0081.\u0098\u0083((object) this) / 2.0 - (double) this.\u0001.Height / 2.0);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      this.\u007F\u0005();
      this.\u001E\u0005();
      this.\u001F\u0005();
      \u0088\u001C.\u0018\u0086((object) this, e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.AntiAlias);
      \u0011.\u001E\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0003, this.\u0004, Orientation.Horizontal);
      \u0011.\u001E\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0002, this.\u0001, Orientation.Horizontal);
      switch (this.\u0001)
      {
        case \u0019.\u0002:
          \u0011.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0001, this.\u0002, Orientation.Horizontal);
          break;
        case \u0019.\u0003:
          \u0011.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0001, this.\u0003, Orientation.Horizontal);
          break;
        default:
          \u0011.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0001, this.\u0001, Orientation.Horizontal);
          break;
      }
      \u0092\u001C.\u0017\u0086((object) this, e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      if (this.\u0001 == \u0019.\u0003)
      {
        float num1 = (float) (\u0005\u0081.\u0083\u0084((object) this) - \u0097\u0086.\u0002\u0084((object) this).Horizontal) - this.\u0001.Width;
        float num2 = (float) (\u0005\u0081.\u007E\u008D\u008A((object) e) - this.\u0003) + this.\u0003;
        if ((double) num2 < (double) \u0097\u0086.\u0002\u0084((object) this).Left)
          num2 = (float) \u0097\u0086.\u0002\u0084((object) this).Left;
        if ((double) num2 > (double) (\u0005\u0081.\u0083\u0084((object) this) - \u0097\u0086.\u0002\u0084((object) this).Right) - (double) this.\u0001.Width)
          num2 = (float) (\u0005\u0081.\u0083\u0084((object) this) - \u0097\u0086.\u0002\u0084((object) this).Right) - this.\u0001.Width;
        float num3 = (num2 - (float) \u0097\u0086.\u0002\u0084((object) this).Left) / num1 * this.\u0001;
        if ((double) num3 != (double) this.\u0002)
        {
          this.\u0002 = num3;
          this.\u0001.X = num2;
          this.\u001F\u0005();
          \u001A\u001E.\u0004\u0086((object) this);
          this.\u001D\u0005();
        }
      }
      else if (this.\u0001.Contains(\u001C\u0086.\u001E\u0080(\u008E\u0084.\u007E\u0090\u008A((object) e))))
      {
        if (this.\u0001 != \u0019.\u0002)
        {
          this.\u0001 = \u0019.\u0002;
          \u001A\u001E.\u0004\u0086((object) this);
        }
      }
      else if (this.\u0001 == \u0019.\u0002)
      {
        this.\u0001 = \u0019.\u0001;
        \u001A\u001E.\u0004\u0086((object) this);
      }
      \u001E\u001C.\u0015\u0086((object) this, e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      if (this.\u0001 != \u0019.\u0003)
        goto label_3;
      else
        goto label_2;
label_1:
      \u0088\u001C.\u0014\u0086((object) this, e);
      return;
label_2:
      this.\u0001 = \u0019.\u0001;
      \u001A\u001E.\u0004\u0086((object) this);
      goto label_1;
label_3:
      if (this.\u0001 == \u0019.\u0002)
      {
        this.\u0001 = \u0019.\u0001;
        \u001A\u001E.\u0004\u0086((object) this);
        goto label_1;
      }
      else
        goto label_1;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      if (this.\u0001 == \u0019.\u0002)
      {
        this.\u0003 = this.\u0001.X;
        this.\u0003 = \u008E\u0084.\u007E\u0090\u008A((object) e).X;
        this.\u0001 = \u0019.\u0003;
        \u001A\u001E.\u0004\u0086((object) this);
      }
      \u001E\u001C.\u0012\u0086((object) this, e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      if (this.\u0001 == \u0019.\u0003)
        goto label_2;
label_1:
      \u001E\u001C.\u0016\u0086((object) this, e);
      return;
label_2:
      this.\u0001 = !this.\u0001.Contains(\u001C\u0086.\u001E\u0080(\u008E\u0084.\u007E\u0090\u008A((object) e))) ? \u0019.\u0001 : \u0019.\u0002;
      \u001A\u001E.\u0004\u0086((object) this);
      goto label_1;
    }
  }
}
