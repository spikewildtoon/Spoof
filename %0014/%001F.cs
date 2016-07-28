// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0015;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0014
{
  internal sealed class \u001F : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private bool \u0001;
    private int \u0001;
    private int \u0002;
    private int \u0003;
    private Image \u0001;
    private Image \u0002;
    private IContainer \u0001;
    private Timer \u0001;

    [DefaultValue(typeof (Image), null)]
    public Image OffImage
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if (this.\u0002 == value)
          return;
        this.\u0002 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    [DefaultValue(typeof (Image), null)]
    public Image OnImage
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

    public int MinimumBlinkDelay
    {
      get
      {
        return this.\u0003;
      }
      set
      {
        if (this.\u0002 == value)
          return;
        this.\u0003 = value;
        this.\u0001 = false;
        this.\u001D\u0005();
      }
    }

    public int MaximumBlinkDelay
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if (this.\u0002 == value)
          return;
        this.\u0002 = value;
        this.\u0001 = false;
        this.\u001D\u0005();
      }
    }

    public int BlinkSpeed
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
        this.\u0001 = false;
        this.\u001D\u0005();
      }
    }

    static \u001F()
    {
      \u0004.\u001D\u0005(typeof (\u001F));
    }

    public \u001F()
    {
      this.\u001E\u0005();
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      this.\u0001 = 200;
      this.\u0002 = 5000;
      this.\u0003 = 1000;
      this.\u0001 = false;
      this.\u001D\u0005();
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
      \u0088\u001C.\u0008\u0086((object) this, e);
      this.\u0001 = false;
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, \u0099\u0082.\u008E\u0083((object) this));
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0092\u001C.\u0017\u0086((object) this, e);
      if (!this.\u0001)
      {
        if (this.OffImage == null)
          return;
        \u0004\u001F.\u007E\u009E\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.OffImage, \u008D\u0084.\u0082\u0083((object) this));
      }
      else
      {
        if (this.OnImage == null)
          return;
        \u0004\u001F.\u007E\u009E\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.OnImage, \u008D\u0084.\u0082\u0083((object) this));
      }
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001 = !this.\u0001;
      if (this.\u0001)
        \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, this.\u0001);
      else
        goto label_3;
label_2:
      \u001A\u001E.\u0004\u0086((object) this);
      return;
label_3:
      this.\u001D\u0005();
      goto label_2;
    }

    private void \u001D\u0005()
    {
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, \u0017.Instance.\u001D\u0005(this.\u0003, this.\u0002));
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001E\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new Timer(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      // ISSUE: method pointer
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler((object) this, __methodptr(\u001D\u0005)));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0092\u0081.\u0010\u0084((object) this, \u001F.\u0001(11965));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
