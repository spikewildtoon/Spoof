// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0019;
using \u001B;
using \u001E;
using \u007F;
using \u0081;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u007F
{
  internal class \u0007 : \u0014.\u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private bool \u0001;
    private IContainer \u0001;
    private \u001F.\u0014 \u0001;
    private PictureBox \u0001;
    private Label \u0001;
    private Label \u0002;

    public \u0006 UpdateResult { get; private set; }

    public \u000E UpdateType
    {
      get
      {
        return this.\u0001.UpdateType;
      }
      set
      {
        this.\u0001.UpdateType = value;
      }
    }

    [DefaultValue(typeof (Image), null)]
    public Image Logo
    {
      get
      {
        return \u000E\u0086.\u007E\u001D\u008E((object) this.\u0001);
      }
      set
      {
        \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, value);
      }
    }

    public string Title
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

    static \u0007()
    {
      \u0004.\u001D\u0005(typeof (\u0007));
    }

    private \u0007()
    {
      this.\u001E\u0005();
      this.UpdateResult = \u0006.\u0001;
      // ISSUE: method pointer
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler((object) this, __methodptr(\u001E\u0005)));
    }

    public \u0007(bool autoCloseOnUpToDate)
      : this()
    {
      this.\u0001 = autoCloseOnUpToDate;
    }

    private void \u001E\u0005(object sender, FormClosingEventArgs e)
    {
      if (\u009A\u001E.\u007E\u009D\u008B((object) e) == CloseReason.WindowsShutDown)
        return;
      switch (this.\u0001.UpdateStepOn)
      {
        case \u0002.\u0002:
        case \u0002.\u0004:
        case \u0002.\u0006:
          \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
          this.EnableCloseButton = false;
          this.\u0001.\u001F\u0005();
          break;
      }
    }

    protected override void \u001D\u0005(\u0018.\u0015 e)
    {
      switch (this.\u0001.UpdateStepOn)
      {
        case \u0002.\u0002:
        case \u0002.\u0004:
        case \u0002.\u0006:
          e.Cancel = true;
          e.CancelReason = \u0007.\u0001(75629);
          this.EnableCloseButton = false;
          this.\u0001.\u001F\u0005();
          break;
      }
      base.\u001D\u0005(e);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u007F\u0005();
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.UpdateResult = \u0006.\u0002;
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.UpdateResult = \u0006.\u0003;
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      this.UpdateResult = \u0006.\u0004;
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001D\u0005(object sender, \u0011 e)
    {
      this.UpdateResult = \u0006.\u0005;
      if (!this.\u0001)
        return;
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      this.UpdateResult = \u0006.\u0006;
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001E\u0005(object sender, \u0011 e)
    {
      this.UpdateResult = \u0006.\u0007;
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001D\u0005(object sender, \u0010 e)
    {
      this.UpdateResult = \u0006.\u0008;
    }

    private void \u001E\u0005(object sender, \u0010 e)
    {
      this.UpdateResult = \u0006.\u000E;
    }

    private void \u001F\u0005(object sender, \u0010 e)
    {
      this.UpdateResult = \u0006.\u000F;
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      this.UpdateResult = \u0006.\u0010;
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.UpdateResult = \u0006.\u0011;
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u001E\u0005()
    {
      this.\u0001 = new \u001F.\u0014();
      this.\u0001 = new PictureBox();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 58));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0007.\u0001(75674));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(226, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      this.\u0001.UpdateType = \u000E.\u0004;
      this.\u0001.Canceled += new EventHandler(this.\u001E\u0005);
      this.\u0001.CheckingFailed += new EventHandler<\u0010>(this.\u001F\u0005);
      this.\u0001.ClosingAborted += new EventHandler(this.\u001F\u0005);
      this.\u0001.DownloadingOrExtractingFailed += new EventHandler<\u0010>(this.\u001E\u0005);
      this.\u0001.ReadyToBeInstalled += new EventHandler(this.\u0082\u0005);
      this.\u0001.UpdateAvailable += new EventHandler(this.\u0081\u0005);
      this.\u0001.UpdateFailed += new EventHandler<\u0010>(this.\u001D\u0005);
      this.\u0001.UpdateSuccessful += new EventHandler<\u0011>(this.\u001E\u0005);
      this.\u0001.UpdateFailedTryLater += new EventHandler(this.\u007F\u0005);
      this.\u0001.CloseApplicationNow += new EventHandler(this.\u0080\u0005);
      this.\u0001.UpToDate += new EventHandler<\u0011>(this.\u001D\u0005);
      this.\u0001.Dismiss += new EventHandler(this.\u0083\u0005);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(248, 10));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0007.\u0001(75695));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(64, 64));
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0007.\u0001(11177), 15.75f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(3, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0007.\u0001(75716));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(241, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleCenter);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(76, 40));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0007.\u0001(75733));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(95, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0007.\u0001(75762));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(324, 85));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0099\u001F.\u001E\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0007.\u0001(75787));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0007.\u0001(75804));
      \u0087\u007F.\u008F\u008B((object) this, new EventHandler(this.\u001D\u0005));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
