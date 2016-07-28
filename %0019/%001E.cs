// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u0019
{
  internal sealed class \u001E : Control
  {
    private bool \u0001 = true;
    private Color \u0001;

    public Color SelectedColor
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

    public bool DrawBorder
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

    public \u001E()
    {
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.HighQuality);
      Rectangle rectangle;
      if ((int) this.\u0001.A < (int) byte.MaxValue)
      {
        bool flag = false;
        int y = 0;
        while (y < \u0005\u0081.\u0098\u0083((object) this))
        {
          int x = 0;
          while (x < \u0005\u0081.\u0083\u0084((object) this))
          {
            rectangle = new Rectangle(x, y, 8, 8);
            if (flag)
              \u0001\u0080.\u007E\u0093\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), \u0017\u001E.\u008C\u001F(), rectangle);
            else
              \u0001\u0080.\u007E\u0093\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), \u0017\u001E.\u008E\u001F(), rectangle);
            flag = !flag;
            x += 8;
          }
          y += 8;
        }
      }
      rectangle = new Rectangle(Point.Empty, new Size(\u0083\u001E.\u0017\u0084((object) this).Width - 1, \u0083\u001E.\u0017\u0084((object) this).Height - 1));
      if ((int) this.\u0001.A > 0)
      {
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
      }
      Pen pen = new Pen(\u0091\u0084.\u007E\u0094\u0083((object) this));
      try
      {
        \u0007\u0084.\u007E\u008D\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, rectangle);
      }
      finally
      {
        if (pen != null)
          \u001A\u001E.\u007E\u0094\u0092((object) pen);
      }
    }
  }
}
