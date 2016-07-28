// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001C;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001D
{
  internal sealed class \u001E : UserControl
  {
    private \u0019 \u0001;
    private Image \u0001;
    private Image \u0002;
    private Image \u0003;
    private IContainer \u0001;

    [Category("Appearance")]
    [DefaultValue(typeof (Image), null)]
    public Image ImageEnter
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

    [Category("Appearance")]
    [DefaultValue(typeof (Image), null)]
    public Image ImageNormal
    {
      get
      {
        return this.\u0003;
      }
      set
      {
        if (this.\u0003 == value)
          return;
        this.\u0003 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    [DefaultValue(typeof (Image), null)]
    [Category("Appearance")]
    public Image ImageDown
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

    public \u001E()
    {
      this.\u001D\u0005();
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
      this.\u0001 = \u0019.\u0001;
    }

    protected override void OnMouseEnter(EventArgs e)
    {
      this.\u0001 = \u0019.\u0002;
      \u001A\u001E.\u0004\u0086((object) this);
      \u0088\u001C.\u0013\u0086((object) this, e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      this.\u0001 = \u0019.\u0001;
      \u001A\u001E.\u0004\u0086((object) this);
      \u0088\u001C.\u0014\u0086((object) this, e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      switch (this.\u0001)
      {
        case \u0019.\u0002:
          this.\u001E\u0005(e);
          break;
        case \u0019.\u0003:
          this.\u001D\u0005(e);
          break;
        default:
          this.\u001F\u0005(e);
          break;
      }
      \u0092\u001C.\u0017\u0086((object) this, e);
    }

    private void \u001D\u0005(PaintEventArgs e)
    {
      if (this.ImageDown != null)
        \u0004\u001F.\u007E\u009E\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.ImageDown, \u008D\u0084.\u0082\u0083((object) this));
      else
        this.\u001F\u0005(e);
    }

    private void \u001E\u0005(PaintEventArgs e)
    {
      if (this.ImageEnter != null)
        \u0004\u001F.\u007E\u009E\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.ImageEnter, \u008D\u0084.\u0082\u0083((object) this));
      else
        this.\u001F\u0005(e);
    }

    private void \u001F\u0005(PaintEventArgs e)
    {
      if (this.ImageNormal == null)
        return;
      \u0004\u001F.\u007E\u009E\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.ImageNormal, \u008D\u0084.\u0082\u0083((object) this));
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
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
    }
  }
}
