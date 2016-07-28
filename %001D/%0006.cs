// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0016;
using \u001A;
using \u001D;
using \u0081;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace \u001D
{
  internal sealed class \u0006 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0013 \u0001;
    private Image \u0001;
    private \u0003 \u0001;
    private Rectangle \u0001;
    private short \u0001;
    private string \u0001;
    private readonly object \u0001;

    public event EventHandler ErrorLoading;

    public event EventHandler ImageLoaded;

    static \u0006()
    {
      \u0004.\u001D\u0005(typeof (\u0006));
    }

    public \u0006()
    {
      this.\u0001 = new object();
      this.\u001D\u0005();
      this.\u0001 = \u0080.Instance.MyGallerySettings;
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        goto label_4;
label_3:
      \u0099\u001F.\u009A\u0086((object) this, disposing);
      return;
label_4:
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u001D\u001F((object) this.\u0001);
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
        goto label_3;
      }
      else
        goto label_3;
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new \u0013();
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.None);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      this.\u0001.BorderColor = \u009A\u0080.\u0004\u007F();
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(192, 0, 192);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(160, 110));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(61975));
      this.\u0001.OffsetAngle = 0;
      this.\u0001.Running = false;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(80, 80));
      this.\u0001.SurroundColor = \u009A\u0080.\u0002\u007F();
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u009A\u0080.\u0090\u001F());
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0006.\u0001(61984));
      \u000E\u001F.\u0018\u0084((object) this, new Size(400, 300));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    public void \u001E\u0005()
    {
      if (!\u0099\u0082.\u009A\u0083((object) this))
        return;
      if ((int) this.\u0001 == 0)
        \u000E.\u001D\u0005(new HandleRef((object) this, \u0088\u0086.\u0097\u0083((object) this)), \u001B.\u000F, false, 0);
      this.\u0001 = (short) ((int) this.\u0001 + 1);
    }

    public void \u001F\u0005()
    {
      this.\u0001 = (short) ((int) this.\u0001 - 1);
      if ((int) this.\u0001 != 0)
        return;
      \u000E.\u001D\u0005(new HandleRef((object) this, \u0088\u0086.\u0097\u0083((object) this)), \u001B.\u000F, true, 0);
      \u001A\u001E.\u0004\u0086((object) this);
    }

    private void \u007F\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u001A\u001E.\u007E\u001D\u001F((object) this.\u0001);
      this.\u0001 = (Image) null;
      if (\u0019\u007F.\u0095\u0080(this.\u0001, Rectangle.Empty))
        \u000E\u0080.\u0005\u0086((object) this, this.\u0001);
      this.\u0001 = Rectangle.Empty;
      \u001A\u001E.\u0086\u0086((object) this);
    }

    public void \u001D\u0005(string imagePath)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0006.\u0001 obj1 = new \u0006.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = imagePath;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (\u008F\u0084.\u009E\u0092(obj1.\u0001) || !\u008F\u0084.\u0092\u009E(obj1.\u0001))
      {
        bool flag = false;
        object obj2;
        try
        {
          \u0098\u0082.\u0081\u0098(obj2 = this.\u0001, ref flag);
          this.\u0001 = (string) null;
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj2);
        }
        this.\u007F\u0005();
      }
      else
      {
        bool flag = false;
        object obj2;
        try
        {
          \u0098\u0082.\u0081\u0098(obj2 = this.\u0001, ref flag);
          // ISSUE: reference to a compiler-generated field
          this.\u0001 = obj1.\u0001;
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj2);
        }
        \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, true);
        this.\u0001.Running = true;
        try
        {
          // ISSUE: reference to a compiler-generated method
          int num = \u001E\u001F.\u009A\u0098(new WaitCallback(obj1.\u001D\u0005), (object) null) ? 1 : 0;
        }
        catch (Exception ex)
        {
          int num = (int) \u008D\u0083.\u009E\u008D(\u0002\u007F.\u007E\u0090\u0091((object) ex));
        }
      }
    }

    public void \u0080\u0005()
    {
      if (this.\u0001 == null)
        return;
      Rectangle rectangle = this.\u0001;
      switch (this.\u0001.ScreenshotScaling)
      {
        case \u0011.\u0002:
          this.\u0001.Size = \u0083\u001E.\u007E\u001F\u001F((object) this.\u0001).\u001D\u0005(\u0005\u0081.\u0083\u0084((object) this), \u0005\u0081.\u0098\u0083((object) this));
          break;
        case \u0011.\u0003:
          if ((double) ((float) \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001) / (float) \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001)) > (double) ((float) \u0005\u0081.\u0083\u0084((object) this) / (float) \u0005\u0081.\u0098\u0083((object) this)))
          {
            this.\u0001.Width = \u0005\u0081.\u0083\u0084((object) this);
            this.\u0001.Height = (int) ((double) \u0005\u0081.\u0083\u0084((object) this) / (double) \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001) * (double) \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001));
            break;
          }
          this.\u0001.Height = \u0005\u0081.\u0098\u0083((object) this);
          this.\u0001.Width = (int) ((double) \u0005\u0081.\u0098\u0083((object) this) / (double) \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001) * (double) \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001));
          break;
        default:
          this.\u0001.Size = new Size(\u0005\u0081.\u0083\u0084((object) this), \u0005\u0081.\u0098\u0083((object) this));
          break;
      }
      this.\u0001.Location = new Point(\u0005\u0081.\u0083\u0084((object) this) / 2 - this.\u0001.Width / 2, \u0005\u0081.\u0098\u0083((object) this) / 2 - this.\u0001.Height / 2);
      if (this.\u0001 != null && \u0019\u007F.\u0095\u0080(this.\u0001, Rectangle.Empty))
        \u000E\u0080.\u0005\u0086((object) this, this.\u0001);
      if (\u0019\u007F.\u0095\u0080(rectangle, Rectangle.Empty))
        \u000E\u0080.\u0005\u0086((object) this, rectangle);
      \u001A\u001E.\u0086\u0086((object) this);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      if (this.\u0001 != null)
        goto label_2;
label_1:
      \u0088\u001C.\u0018\u0086((object) this, e);
      return;
label_2:
      this.\u0080\u0005();
      goto label_1;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
      SolidBrush solidBrush = new SolidBrush(\u0091\u0084.\u007E\u001C\u0083((object) this));
      try
      {
        \u0001\u0080.\u007E\u0093\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) solidBrush, \u008D\u0084.\u0082\u0083((object) this));
      }
      finally
      {
        if (solidBrush != null)
          \u001A\u001E.\u007E\u0094\u0092((object) solidBrush);
      }
      if (this.\u0001 == null)
        return;
      \u0094\u0081.\u007E\u0083\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), InterpolationMode.High);
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.AntiAlias);
      \u0004\u001F.\u007E\u009E\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0001, this.\u0001);
    }
  }
}
