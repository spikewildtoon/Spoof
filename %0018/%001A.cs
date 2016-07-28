// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u001A : UserControl
  {
    private int \u0002 = 5;
    private short \u0001 = 75;
    [NonSerialized]
    internal static \u0002 \u0001;
    private int \u0001;
    private IContainer \u0001;
    private Timer \u0001;

    [Category("Appearance")]
    [Browsable(true)]
    [DefaultValue(false)]
    public bool On
    {
      get
      {
        return \u0099\u0082.\u007E\u009E\u008F((object) this.\u0001);
      }
      set
      {
        \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, value);
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    [DefaultValue(5)]
    [Category("Behavior")]
    [Browsable(true)]
    public int NoOfCircles
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        this.\u0002 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    [Category("Behavior")]
    [Browsable(true)]
    [DefaultValue(75)]
    public short AnimationSpeed
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if ((int) value > 100)
          value = (short) 100;
        if ((int) value < 1)
          value = (short) 1;
        this.\u0001 = value;
        \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 101 - (int) this.\u0001);
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    static \u001A()
    {
      \u0004.\u001D\u0005(typeof (\u001A));
    }

    public \u001A()
    {
      this.\u001D\u0005();
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001 = (this.\u0001 + 5) % 360;
      \u001A\u001E.\u0004\u0086((object) this);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.AntiAlias);
      \u0090\u001D.\u007E\u0082\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), PixelOffsetMode.HighQuality);
      float num1 = (float) \u0099\u0081.\u009F\u0096(\u0005\u0081.\u0098\u0083((object) this) - \u0097\u0086.\u0002\u0084((object) this).Vertical, \u0005\u0081.\u0083\u0084((object) this) - \u0097\u0086.\u0002\u0084((object) this).Horizontal);
      float num2 = (float) (\u0099\u0081.\u009F\u0096(\u0005\u0081.\u0098\u0083((object) this), \u0005\u0081.\u0083\u0084((object) this)) / 2);
      Pen pen = new Pen(\u0091\u0084.\u007E\u0094\u0083((object) this));
      try
      {
        for (int index = 1; index <= this.\u0002; ++index)
        {
          float num3 = (float) ((double) num1 / (double) this.\u0002 * (double) index / 2.0);
          RectangleF rectangleF = new RectangleF(num2 - num3, num2 - num3, 2f * num3, 2f * num3);
          switch (index % 4)
          {
            case 0:
              \u0083\u007F.\u007E\u008C\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, rectangleF, (float) this.\u0001, 300f);
              break;
            case 1:
              \u0083\u007F.\u007E\u008C\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, rectangleF, (float) (360 - this.\u0001 + 90), 300f);
              break;
            case 2:
              \u0083\u007F.\u007E\u008C\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, rectangleF, (float) (360 - this.\u0001 + 180), 300f);
              break;
            default:
              \u0083\u007F.\u007E\u008C\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, rectangleF, (float) (360 - this.\u0001 + 270), 300f);
              break;
          }
        }
      }
      finally
      {
        if (pen != null)
          \u001A\u001E.\u007E\u0094\u0092((object) pen);
      }
      \u0092\u001C.\u0017\u0086((object) this, e);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new Timer(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      // ISSUE: method pointer
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler((object) this, __methodptr(\u001D\u0005)));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0092\u0081.\u0010\u0084((object) this, \u001A.\u0001(38773));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
