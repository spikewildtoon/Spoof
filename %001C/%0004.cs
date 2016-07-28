// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001C;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001C
{
  internal sealed class \u0004 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0010 \u0001;
    private Label \u0001;
    private Label \u0002;
    private Button \u0001;

    public int WaterCount
    {
      get
      {
        return this.\u0001.Value;
      }
      set
      {
        this.\u0001.Value = value;
      }
    }

    public event EventHandler ClosePopup;

    public event EventHandler ValueChanged;

    static \u0004()
    {
      \u0004.\u001D\u0005(typeof (\u0004));
    }

    public \u0004()
    {
      this.\u001D\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new \u0010();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0001 = new Button();
      \u001A\u001E.\u0084\u0086((object) this);
      this.\u0001.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(54, 2));
      this.\u0001.MaximumValue = 5;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0001, 1);
      this.\u0001.MinimumValue = 0;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0004.\u0001(58809));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(12, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 7);
      this.\u0001.Value = 0;
      \u0087\u007F.\u007E\u001E\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(43, 5));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0004.\u0001(58834));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(12, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 8);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0004.\u0001(54713));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(5, 5));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0004.\u0001(58851));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(36, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0004.\u0001(58868));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0004.\u0001(6487), 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(73, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0004.\u0001(16253));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(18, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0004.\u0001(16266));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0012\u0082.\u009D\u0090((object) this, BorderStyle.FixedSingle);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0004.\u0001(58877));
      \u000E\u001F.\u0018\u0084((object) this, new Size(94, 25));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, e);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, e);
    }
  }
}
