// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0083;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001C
{
  [ToolboxItem(false)]
  internal sealed class \u0001 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private PictureBox \u0001;
    private Bitmap \u0001;

    static \u0001()
    {
      \u0004.\u001D\u0005(typeof (\u001C.\u0001));
    }

    public \u0001(\u0018 pix)
    {
      this.\u001D\u0005();
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) (this.\u0001 = pix.GetBitmap));
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u001D\u001F((object) this.\u0001);
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new PictureBox();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(2, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001.\u0001(57996));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(100, 100));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.StretchImage);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u001C.\u0001.\u0001(58021));
      \u000E\u001F.\u0018\u0084((object) this, new Size(104, 104));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
