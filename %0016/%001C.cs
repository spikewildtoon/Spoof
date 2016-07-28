// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0015;
using \u0016;
using \u001A;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace \u0016
{
  internal sealed class \u001C : \u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private static Color \u0001;

    protected override CreateParams CreateParams
    {
      get
      {
        CreateParams createParams1 = base.CreateParams;
        \u0011\u001F obj = \u0011\u001F.\u007E\u0099\u0089;
        CreateParams createParams2 = createParams1;
        int num = createParams2.ExStyle | 134217888;
        obj((object) createParams2, num);
        return createParams1;
      }
    }

    static \u001C()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u001C)));
      \u001C.\u0001 = \u009A\u0080.\u0005\u007F();
    }

    public \u001C()
    {
      this.\u001E\u0005();
      \u000E.\u001D\u0005(new HandleRef((object) this, \u0088\u0086.\u0097\u0083((object) this)), 0U, byte.MaxValue, \u007F.\u0001);
      this.CustomPainting = true;
      this.UseOpacity = true;
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.Manual);
      \u0096\u0086.\u0018\u008B((object) this, new Point(0, 0));
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u001E\u0005()
    {
      \u001A\u001E.\u0084\u0086((object) this);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(286, 262));
      \u0099\u001F.\u0012\u008B((object) this, false);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.None);
      \u0092\u0081.\u0010\u0084((object) this, \u001C.\u0001(25462));
      \u0099\u001F.\u0080\u008B((object) this, false);
      \u0099\u001F.\u007F\u008B((object) this, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001C.\u0001(25462));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    protected override void \u001D\u0005(Graphics g)
    {
      LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, \u0005\u0081.\u0098\u0083((object) this)), \u008D\u001E.\u0016\u007F(39, \u001C.\u0001), \u008D\u001E.\u0016\u007F(190, \u001C.\u0001));
      try
      {
        Pen pen = new Pen((Brush) linearGradientBrush, (float) (\u0005\u0081.\u0083\u0084((object) this) / 2));
        try
        {
          \u0002\u0084.\u007E\u0015\u0080((object) pen, LineCap.ArrowAnchor);
          \u0002\u0084.\u007E\u0016\u0080((object) pen, LineCap.NoAnchor);
          \u0084\u0081.\u007E\u008B\u007F((object) g, pen, new Point(\u0005\u0081.\u0083\u0084((object) this) / 2, 0), new Point(\u0005\u0081.\u0083\u0084((object) this) / 2, \u0005\u0081.\u0098\u0083((object) this)));
        }
        finally
        {
          if (pen != null)
            \u001A\u001E.\u007E\u0094\u0092((object) pen);
        }
      }
      finally
      {
        if (linearGradientBrush != null)
          \u001A\u001E.\u007E\u0094\u0092((object) linearGradientBrush);
      }
    }
  }
}
