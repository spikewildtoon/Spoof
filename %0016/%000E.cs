// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0016
{
  internal sealed class \u000E : Control
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Timer \u0001;
    private int \u0001;

    public int FadeOutDelay { get; set; }

    public int FadeOutRate { get; set; }

    public int FadeOutAlphaRate { get; set; }

    static \u000E()
    {
      \u0004.\u001D\u0005(typeof (\u000E));
    }

    public \u000E()
    {
      this.\u001D\u0005();
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      this.FadeOutDelay = 5000;
      this.FadeOutRate = 10;
      this.FadeOutAlphaRate = 5;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009D\u0084((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new Timer(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 10);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0092\u0081.\u0010\u0084((object) this, \u000E.\u0001(16029));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    public void \u001E\u0005()
    {
      this.\u0001 = (int) byte.MaxValue;
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, this.FadeOutDelay);
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
      \u001A\u001E.\u0004\u0086((object) this);
    }

    public void \u001F\u0005()
    {
      if (this.\u0001 <= 0)
        return;
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, this.FadeOutRate);
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, this.FadeOutRate);
      this.\u0001 -= this.FadeOutAlphaRate;
      if (this.\u0001 <= 0)
        goto label_2;
label_1:
      \u001A\u001E.\u0004\u0086((object) this);
      return;
label_2:
      this.\u0001 = 0;
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
      goto label_1;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      if (\u0099\u0082.\u0081\u0001\u0002((object) this))
        this.\u0001 = (int) byte.MaxValue;
      if (this.\u0001 > 0)
      {
        SolidBrush solidBrush = new SolidBrush(\u008D\u001E.\u0016\u007F(this.\u0001, \u0091\u0084.\u007E\u0094\u0083((object) this)));
        try
        {
          StringFormat stringFormat = new StringFormat();
          try
          {
            \u0014\u0083.\u007E\u009E\u0082((object) stringFormat, StringAlignment.Center);
            \u0014\u0083.\u007E\u009F\u0082((object) stringFormat, StringAlignment.Center);
            \u0011\u0083.\u007E\u0002\u0083((object) stringFormat, StringTrimming.EllipsisCharacter);
            \u009F\u0084.\u007E\u009B\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), \u0002\u007F.\u007E\u001C\u0084((object) this), \u0080\u0084.\u007E\u0092\u0083((object) this), (Brush) solidBrush, \u0013\u001F.\u0097\u0082(\u008D\u0084.\u0082\u0083((object) this)), stringFormat);
          }
          finally
          {
            if (stringFormat != null)
              \u001A\u001E.\u007E\u0094\u0092((object) stringFormat);
          }
        }
        finally
        {
          if (solidBrush != null)
            \u001A\u001E.\u007E\u0094\u0092((object) solidBrush);
        }
      }
      \u0092\u001C.\u0017\u0086((object) this, e);
    }
  }
}
