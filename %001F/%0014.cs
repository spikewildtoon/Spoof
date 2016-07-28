// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0016;
using \u001B;
using \u001D;
using \u001E;
using \u001F;
using \u007F;
using \u0080;
using \u0081;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001F
{
  internal sealed class \u0014 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0019.\u0015 \u0001;
    private LinkLabel \u0001;
    private Label \u0001;
    private ContextMenuStrip \u0001;
    private ToolStripMenuItem \u0001;
    private ContextMenuStrip \u0002;
    private ToolStripMenuItem \u0002;
    private ToolStripMenuItem \u0003;
    private ToolStripSeparator \u0001;
    private ToolStripMenuItem \u0004;
    private ContextMenuStrip \u0003;
    private ToolStripMenuItem \u0005;
    private ToolStripMenuItem \u0006;
    private ContextMenuStrip \u0004;
    private ToolStripMenuItem \u0007;
    private ToolStripMenuItem \u0008;
    private ContextMenuStrip \u0005;
    private ToolStripMenuItem \u000E;
    private readonly Bitmap \u0001;
    private readonly Bitmap \u0002;
    private readonly Bitmap \u0003;
    private readonly Bitmap \u0004;
    private readonly Bitmap \u0005;
    private \u0083.\u001D \u0001;
    private \u0014.\u0001 \u0001;
    private string \u0001;
    private bool \u0001;
    private \u0010 \u0001;
    private \u0011 \u0001;
    private readonly string \u0002;
    private readonly string \u0003;

    public \u0002 UpdateStepOn
    {
      get
      {
        return this.\u0001.UpdateStepOn;
      }
    }

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

    [Category("Updater")]
    [Description("Event is raised before the update checking begins.")]
    public event EventHandler<\u0005> BeforeChecking;

    [Description("Event is raised before the downloading of the update begins.")]
    [Category("Updater")]
    public event EventHandler<\u0005> BeforeDownloading;

    [Category("Updater")]
    [Description("Event is raised when checking or updating is canceled.")]
    public event EventHandler Canceled;

    [Description("Event is raised when the checking for updates fails.")]
    [Category("Updater")]
    public event EventHandler<\u0010> CheckingFailed;

    [Category("Updater")]
    [Description("Event is raised when an update can't be installed and the closing is aborted.")]
    public event EventHandler ClosingAborted;

    [Category("Updater")]
    [Description("Event is raised when the update fails to download or extract.")]
    public event EventHandler<\u0010> DownloadingOrExtractingFailed;

    [Category("Updater")]
    [Description("Event is raised when the update is ready to be installed.")]
    public event EventHandler ReadyToBeInstalled;

    [Description("Event is raised when a new update is found.")]
    [Category("Updater")]
    public event EventHandler UpdateAvailable;

    [Category("Updater")]
    [Description("Event is raised when an update fails to install.")]
    public event EventHandler<\u0010> UpdateFailed;

    [Description("Event is raised when an update installs successfully and the dismiss item is clicked.")]
    [Category("Updater")]
    public event EventHandler<\u0011> UpdateSuccessful;

    public event EventHandler UpdateFailedTryLater;

    public event EventHandler CloseApplicationNow;

    [Description("Event is raised when the latest version is already installed.")]
    [Category("Updater")]
    public event EventHandler<\u0011> UpToDate;

    [Description("Event is raised when the updater should close.")]
    [Category("Updater")]
    public event EventHandler Dismiss;

    static \u0014()
    {
      \u0004.\u001D\u0005(typeof (\u0014));
    }

    public \u0014()
    {
      this.\u001D\u0005();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0014)));
      this.\u0001 = (Bitmap) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0001(74222));
      this.\u0002 = (Bitmap) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0001(74239));
      this.\u0003 = (Bitmap) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0001(74272));
      this.\u0004 = (Bitmap) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0001(74301));
      this.\u0005 = (Bitmap) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0001(74318));
      this.\u0002 = \u0090\u0083.\u007E\u001F\u009C((object) componentResourceManager, \u0014.\u0001(74339));
      this.\u0003 = \u0090\u0083.\u007E\u001F\u009C((object) componentResourceManager, \u0014.\u0001(74380));
      this.\u0001 = new \u0083.\u001D();
      this.\u0001.UpdaterExitedPrematurely_Title = this.\u0002;
      this.\u0001.UpdaterExitedPrematurely = this.\u0003;
      this.\u0001.UseCloseAppNow = true;
      this.\u0001.UpToDate += new EventHandler<\u0011>(this.\u001D\u0005);
      this.\u0001.UpdateSuccessful += new EventHandler<\u0011>(this.\u001E\u0005);
      this.\u0001.UpdateStepMismatch += new EventHandler(this.\u007F\u0005);
      this.\u0001.UpdateFailed += new EventHandler<\u0010>(this.\u001F\u0005);
      this.\u0001.UpdateAvailable += new EventHandler(this.\u0080\u0005);
      this.\u0001.ReadyToBeInstalled += new EventHandler(this.\u0081\u0005);
      this.\u0001.ProgressChanged += new EventHandler<\u0005>(this.\u001D\u0005);
      this.\u0001.ExtractingFailed += new EventHandler<\u0010>(this.\u007F\u0005);
      this.\u0001.BeforeChecking += new EventHandler<\u0005>(this.\u001F\u0005);
      this.\u0001.Canceled += new EventHandler(this.\u001F\u0005);
      this.\u0001.CloseAppNow += new EventHandler(this.\u001E\u0005);
      this.\u0001.ClosingAborted += new EventHandler(this.\u001D\u0005);
      this.\u0001.DownloadingFailed += new EventHandler<\u0010>(this.\u001E\u0005);
      this.\u0001.BeforeExtracting += new EventHandler<\u0005>(this.\u001E\u0005);
      this.\u0001.CheckingFailed += new EventHandler<\u0010>(this.\u001D\u0005);
      this.\u0001.BeforeDownloading += new EventHandler<\u0005>(this.\u001D\u0005);
      this.\u0001.Arguments = \u0012.Current.OriginalString;
      this.\u0001.UpdateType = \u000E.\u0004;
      this.\u001D\u0005((Image) this.\u0003, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        goto label_3;
label_2:
      \u0099\u001F.\u009A\u0086((object) this, disposing);
      return;
label_3:
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
        goto label_2;
      }
      else
        goto label_2;
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new LinkLabel();
      this.\u0001 = new Label();
      this.\u0001 = new ContextMenuStrip(this.\u0001);
      this.\u0001 = new ToolStripMenuItem();
      this.\u0002 = new ContextMenuStrip(this.\u0001);
      this.\u0002 = new ToolStripMenuItem();
      this.\u0003 = new ToolStripMenuItem();
      this.\u0001 = new ToolStripSeparator();
      this.\u0004 = new ToolStripMenuItem();
      this.\u0003 = new ContextMenuStrip(this.\u0001);
      this.\u0005 = new ToolStripMenuItem();
      this.\u0006 = new ToolStripMenuItem();
      this.\u0004 = new ContextMenuStrip(this.\u0001);
      this.\u0007 = new ToolStripMenuItem();
      this.\u0008 = new ToolStripMenuItem();
      this.\u0005 = new ContextMenuStrip(this.\u0001);
      this.\u000E = new ToolStripMenuItem();
      this.\u0001 = new \u0019.\u0015();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0002);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0003);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0004);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0005);
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0001, true);
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0001, \u008E\u001D.\u0017\u007F(0, 192, 192));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(20, 0));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0001, new Padding(13, 0, 3, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0001(73633));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(224, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleLeft);
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0001, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(20, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0001(73650));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(224, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleLeft);
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0001
      });
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0001(73667));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(257, 26));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0014.\u0001(73684));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(256, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0014.\u0001(73713));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0001, new EventHandler(this.\u0082\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0002), new ToolStripItem[4]
      {
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0004
      });
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0014.\u0001(73762));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(165, 76));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0014.\u0001(73787));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(164, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0014.\u0001(73816));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler(this.\u0083\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0014.\u0001(73837));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(164, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0014.\u0001(73866));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(this.\u0084\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0014.\u0001(73891));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(161, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0014.\u0001(73912));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(164, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u0014.\u0001(73937));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(this.\u0086\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0003), new ToolStripItem[2]
      {
        (ToolStripItem) this.\u0005,
        (ToolStripItem) this.\u0006
      });
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0014.\u0001(73966));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(68, 48));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0014.\u0001(73983));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(67, 22));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(this.\u0089\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u0014.\u0001(74004));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(67, 22));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(this.\u0087\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0004), new ToolStripItem[2]
      {
        (ToolStripItem) this.\u0007,
        (ToolStripItem) this.\u0008
      });
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0014.\u0001(73966));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(100, 48));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u0014.\u0001(74033));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(99, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u0014.\u0001(74062));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0007, new EventHandler(this.\u008A\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0008, \u0014.\u0001(74071));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0008, new Size(99, 22));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0008, new EventHandler(this.\u0087\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0005), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u000E
      });
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0014.\u0001(74108));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(115, 26));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000E, \u0014.\u0001(74129));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000E, new Size(114, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000E, \u0014.\u0001(74150));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000E, new EventHandler(this.\u0088\u0005));
      this.\u0001.AnimationInterval = 25;
      this.\u0001.Columns = 10;
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Left);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0001(74163));
      this.\u0001.Rows = 5;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(16, 16));
      this.\u0001.StaticImage = false;
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0014.\u0001(74176));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0014.\u0001(74201));
      \u000E\u001F.\u0018\u0084((object) this, new Size(244, 16));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0002, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0003, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0004, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0005, false);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001E\u0005()
    {
      \u001A\u001E.\u007E\u0081\u0089((object) this.\u0001);
      \u001A\u001E.\u007E\u0081\u0089((object) this.\u0002);
      \u001A\u001E.\u007E\u0081\u0089((object) this.\u0003);
      \u001A\u001E.\u007E\u0081\u0089((object) this.\u0004);
      \u001A\u001E.\u007E\u0081\u0089((object) this.\u0005);
    }

    private void \u001D\u0005(object sender, \u0005 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u0002()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(object sender, \u0010 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u0003()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001E\u0005(object sender, \u0005 e)
    {
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) this, __methodptr(\u0081\u0005)));
    }

    private void \u001E\u0005(object sender, \u0010 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u0004()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) this, __methodptr(\u0082\u0005)));
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) this, __methodptr(\u0083\u0005)));
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u0005()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    public void \u001F\u0005()
    {
      this.\u0001.\u0082\u0005();
    }

    private void \u001D\u0005(\u0002 uso)
    {
      switch (uso)
      {
        case \u0002.\u0002:
          \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, this.\u0001 = \u0014.\u0001(74413));
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
          break;
        case \u0002.\u0003:
          \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0014.\u0001(74492));
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
          break;
        case \u0002.\u0004:
          \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, this.\u0001 = \u0014.\u0001(74442));
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
          break;
        case \u0002.\u0005:
          \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0014.\u0001(74537));
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
          break;
        case \u0002.\u0006:
          \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, this.\u0001 = \u0014.\u0001(74467));
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
          break;
        case \u0002.\u0007:
          \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0014.\u0001(74582));
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
          break;
      }
    }

    private void \u001F\u0005(object sender, \u0005 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u0006()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(object sender, \u0011 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u0007()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001E\u0005(object sender, \u0011 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u0008()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) this, __methodptr(\u0084\u0005)));
    }

    private void \u001F\u0005(object sender, \u0010 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u000E()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u000F()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u0010()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(object sender, \u0005 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u0011()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u007F\u0005(object sender, \u0010 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0014.\u0012()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(\u0010 e)
    {
      if (e.PrematureExit)
        e = new \u0010(true, this.\u0002, e.ErrorMessage ?? this.\u0003);
      this.\u0001 = e;
      this.\u0001 = \u0014.\u0001.\u0007;
      this.\u001D\u0005((Image) this.\u0005, true);
    }

    private void \u001D\u0005(Image img, bool staticImg)
    {
      this.\u0001.\u001E\u0005();
      this.\u0001.StaticImage = staticImg;
      this.\u0001.AnimationInterval = 25;
      this.\u0001.BaseImage = img;
      this.\u0001.\u001D\u0005();
    }

    public void \u007F\u0005()
    {
      if (\u0099\u0082.\u0081\u0001\u0002((object) this))
        return;
      this.\u0001.\u008C\u0005();
      if (this.\u0001.ClosingForInstall)
      {
        this.\u001D\u0005((Image) this.\u0002, false);
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0014.\u0001(74635));
        \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
        \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, true);
      }
      else
        this.\u001D\u0005();
    }

    public bool \u001D\u0005()
    {
      return this.\u001D\u0005(false);
    }

    public bool \u001D\u0005(bool recheck)
    {
      if (this.\u0001.UpdateStepOn != \u0002.\u0001 && (!recheck || this.\u0001.UpdateStepOn != \u0002.\u0003))
        return false;
      return this.\u0001.\u001D\u0005(recheck);
    }

    private void \u001D\u0005(object sender, LinkLabelLinkClickedEventArgs e)
    {
      switch (this.\u0001)
      {
        case \u0014.\u0001.\u0002:
        case \u0014.\u0001.\u0004:
        case \u0014.\u0001.\u0005:
          \u008A\u001D.\u007E\u0089\u0089((object) this.\u0001, (Control) this.\u0001, new Point(0, \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001)));
          break;
        case \u0014.\u0001.\u0003:
        case \u0014.\u0001.\u0006:
          \u008A\u001D.\u007E\u0089\u0089((object) this.\u0003, (Control) this.\u0001, new Point(0, \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001)));
          break;
        case \u0014.\u0001.\u0007:
          \u008A\u001D.\u007E\u0089\u0089((object) this.\u0002, (Control) this.\u0001, new Point(0, \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001)));
          break;
        case \u0014.\u0001.\u0008:
          \u008A\u001D.\u007E\u0089\u0089((object) this.\u0005, (Control) this.\u0001, new Point(0, \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001)));
          break;
        case \u0014.\u0001.\u000E:
          \u008A\u001D.\u007E\u0089\u0089((object) this.\u0004, (Control) this.\u0001, new Point(0, \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001)));
          break;
      }
    }

    public void \u0080\u0005()
    {
      this.\u0001.\u0081\u0005();
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.\u001F\u0005();
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005(true);
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      if (this.\u0005 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0005, (object) this, EventArgs.Empty);
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      \u0008 obj = new \u0008(this.\u0001);
      try
      {
        int num = (int) \u001B\u0080.\u007E\u009A\u008B((object) obj, (IWin32Window) \u008E\u0086.\u0099\u0086((object) this));
        if (!obj.TryAgainLater || this.\u0005 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0005, (object) this, EventArgs.Empty);
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      \u000F obj = new \u000F(this.\u0001.Version, this.\u0001.RawChanges, this.\u0001.AreChangesRTF, this.\u0001);
      try
      {
        int num = (int) \u001B\u0080.\u007E\u009A\u008B((object) obj, (IWin32Window) \u008E\u0086.\u0099\u0086((object) this));
        if (!obj.UpdateNow)
          return;
        this.\u0080\u0005();
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      if (this.\u0007 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0007, (object) this, e);
    }

    private void \u0089\u0005(object sender, EventArgs e)
    {
      this.\u0080\u0005();
    }

    private void \u008A\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, this.\u0001);
    }

    private enum \u0001
    {
      \u0001,
      \u0002,
      \u0003,
      \u0004,
      \u0005,
      \u0006,
      \u0007,
      \u0008,
      \u000E,
    }
  }
}
