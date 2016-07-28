// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0018;
using \u001E;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace \u001E
{
  internal sealed class \u0004 : \u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Timer \u0001;

    public int SecondsRemaining { get; set; }

    public event EventHandler CountDownCompleted;

    static \u0004()
    {
      \u0004.\u001D\u0005(typeof (\u0004));
    }

    public \u0004()
    {
      this.\u001E\u0005();
      this.SecondsRemaining = 3;
      this.CustomPainting = true;
      this.UseOpacity = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u001E\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new Timer(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 1000);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(233f, 447f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u009A\u0080.\u0015\u0081());
      \u000E\u001F.\u0010\u008B((object) this, new Size(600, 600));
      \u0094\u0083.\u007E\u0093\u0083((object) this, new Font(\u0004.\u0001(64901), 300f));
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.None);
      \u0001\u001F.\u001A\u008B((object) this, new Padding(116, 103, 116, 103));
      \u0092\u0081.\u0010\u0084((object) this, \u0004.\u0001(64910));
      \u0099\u001F.\u007F\u008B((object) this, false);
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0004.\u0001(64923));
      \u0099\u001F.\u0086\u008B((object) this, true);
      \u0087\u007F.\u008F\u008B((object) this, new EventHandler(this.\u001E\u0005));
      \u009F\u0083.\u008E\u0084((object) this, new KeyPressEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001F\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      --this.SecondsRemaining;
      if (this.SecondsRemaining == 0)
      {
        \u001A\u001E.\u007E\u0003\u0090((object) this.\u0001);
        this.\u001F\u0005();
        \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
      }
      else
        base.\u001D\u0005();
    }

    protected override void \u001D\u0005(Graphics gr)
    {
      \u0015\u0083.\u007E\u0081\u007F((object) gr, SmoothingMode.AntiAlias);
      \u0008\u0083.\u007E\u0080\u007F((object) gr, TextRenderingHint.AntiAlias);
      float num = (float) ((double) \u0094\u0084.\u007E\u0084\u007F((object) gr) * (double) \u0094\u0084.\u007E\u0097\u0081((object) \u0080\u0084.\u007E\u0092\u0083((object) this)) / 72.0);
      SizeF sizeF = \u0095\u001D.\u007E\u009D\u007F((object) gr, this.SecondsRemaining.ToString((IFormatProvider) \u0013.\u0001), \u0080\u0084.\u007E\u0092\u0083((object) this));
      PointF pointF = new PointF((float) \u0005\u0081.\u0083\u0084((object) this) / 2f, (float) \u0005\u0081.\u0098\u0083((object) this) / 2f);
      GraphicsPath graphicsPath = new GraphicsPath();
      try
      {
        \u001A\u007F.\u007E\u0004\u0082((object) graphicsPath, this.SecondsRemaining.ToString((IFormatProvider) \u0013.\u0001), \u009D\u001D.\u007E\u008E\u0081((object) \u0080\u0084.\u007E\u0092\u0083((object) this)), 0, num, new PointF(pointF.X - sizeF.Width / 2f, pointF.Y - sizeF.Height / 2f), \u008A\u0081.\u0003\u0083());
        \u0098\u0081.\u007E\u0098\u007F((object) gr, \u0017\u001E.\u008E\u001F(), graphicsPath);
        Pen pen = new Pen(\u009A\u0080.\u0090\u001F(), 2f);
        try
        {
          \u008A\u0082.\u007E\u0090\u007F((object) gr, pen, graphicsPath);
        }
        finally
        {
          if (pen != null)
            \u001A\u001E.\u007E\u0094\u0092((object) pen);
        }
      }
      finally
      {
        if (graphicsPath != null)
          \u001A\u001E.\u007E\u0094\u0092((object) graphicsPath);
      }
    }

    private void \u001D\u0005(object sender, KeyPressEventArgs e)
    {
      \u001A\u001E.\u007E\u0003\u0090((object) this.\u0001);
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u007E\u0002\u0090((object) this.\u0001);
    }
  }
}
