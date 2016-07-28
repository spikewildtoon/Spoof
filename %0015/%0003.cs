// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0017;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0015
{
  internal sealed class \u0003 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0082 \u0001;
    private Label \u0001;

    [DefaultValue(typeof (Bitmap), null)]
    public Bitmap Image
    {
      get
      {
        return this.\u0001.Image;
      }
      set
      {
        this.\u0001.Image = value;
      }
    }

    public string FileName
    {
      get
      {
        return \u0002\u007F.\u007E\u001C\u0084((object) this.\u0001);
      }
      set
      {
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, value);
      }
    }

    public bool Selected
    {
      get
      {
        return this.\u0001.Selected;
      }
      set
      {
        this.\u0001.Selected = value;
      }
    }

    public event EventHandler ShowScreenshot
    {
      add
      {
        this.\u0001.ShowScreenshot += value;
      }
      remove
      {
        this.\u0001.ShowScreenshot -= value;
      }
    }

    public event EventHandler ButtonSelected
    {
      add
      {
        this.\u0001.ButtonSelected += value;
      }
      remove
      {
        this.\u0001.ButtonSelected -= value;
      }
    }

    static \u0003()
    {
      \u0004.\u001D\u0005(typeof (\u0003));
    }

    public \u0003()
    {
      this.\u001D\u0005();
    }

    private void \u001D\u0005(object sender, PreviewKeyDownEventArgs e)
    {
      if (\u007F\u0081.\u007E\u0082\u008E((object) e) != Keys.Tab)
        return;
      \u0099\u001F.\u007E\u0083\u008E((object) e, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new Label();
      this.\u0001 = new \u0082();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0003.\u0001(4273), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 134));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(12035));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(178, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleCenter);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0016\u0081());
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0001, \u009B\u0086.\u0008\u008A());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(12052));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(178, 134));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0003.\u0001(12069));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0003.\u0001(12094));
      \u000E\u001F.\u0018\u0084((object) this, new Size(178, 146));
      \u0086\u001D.\u0098\u0084((object) this, new PreviewKeyDownEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
