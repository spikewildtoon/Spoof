// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0015;
using \u001C;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace \u001D
{
  internal sealed class \u001C : \u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0018 \u0001;
    private \u001D.\u001C.\u0002[] \u0001;
    private readonly \u0084.\u0015 \u0001;
    private readonly \u001D.\u001C.\u0001[] \u0001;
    private readonly Font \u0001;
    private readonly Rectangle \u0001;
    private readonly Rectangle \u0002;
    private readonly \u001D.\u001C.\u0001 \u0001;
    private int \u0001;

    public event EventHandler MoveToNotificationArea;

    public event EventHandler CheckForUpdatesLaunched;

    public event EventHandler MyGalleryLaunched;

    public event EventHandler ContentPacksLaunched;

    public event EventHandler<\u001A.\u0001> HotkeysLaunched;

    public event EventHandler GuideLaunched;

    public event EventHandler ConnectLaunched;

    public event EventHandler InvasionsLaunched;

    public event EventHandler GagAMaticLaunched;

    public event EventHandler JoeFishLaunched;

    public event EventHandler GardenerFloraLaunched;

    public event EventHandler RemoteControlLaunched;

    public event EventHandler RaceTrackLaunched;

    public event EventHandler OptionsLaunched;

    public event EventHandler AboutLaunched;

    public event EventHandler ReleaseNotesLaunched;

    public event EventHandler ParTeePuttLaunched;

    static \u001C()
    {
      \u0004.\u001D\u0005(typeof (\u001D.\u001C));
    }

    public \u001C(\u0084.\u0015 mainSpawner)
    {
      this.\u0001 = mainSpawner;
      this.\u001E\u0005();
      this.\u0001 = \u0081.\u0080.Instance.ApplicationSettings;
      this.\u0001 = new Font(\u001D.\u001C.\u0001(64258), 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.\u0002 = new Rectangle(111, 111, 64, 64);
      this.\u0001 = new Rectangle(62, 62, 164, 48);
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.ResizeRedraw, true);
      this.\u0001 = new \u001D.\u001C.\u0002[6];
      this.\u0001[0] = new \u001D.\u001C.\u0002((Image) \u0013.VisualMode_03, (Image) \u0013.VisualMode_Hover_03, new Rectangle(77, 201, 68, 43), new Rectangle(81, 206, 58, 35), new EventHandler(this.\u0090\u0005));
      this.\u0001[1] = new \u001D.\u001C.\u0002((Image) \u0013.VisualMode_04, (Image) \u0013.VisualMode_Hover_04, new Rectangle(145, 201, 67, 43), new Rectangle(147, 206, 58, 35), new EventHandler(this.\u0091\u0005));
      this.\u0001[2] = new \u001D.\u001C.\u0002((Image) \u0013.VisualMode_07, (Image) \u0013.VisualMode_Hover_07, new Rectangle(77, 252, 135, 32), new Rectangle(98, 254, 114, 26), new EventHandler(this.\u0092\u0005));
      this.\u0001[3] = new \u001D.\u001C.\u0002((Image) \u0013.VisualMode_Close, (Image) \u0013.VisualMode_Close_Hover, new Rectangle(228, 13, 23, 23), new Rectangle(228, 13, 23, 23), new EventHandler(this.\u008D\u0005));
      this.\u0001[4] = new \u001D.\u001C.\u0002((Image) \u0013.VisualMode_Restore, (Image) \u0013.VisualMode_Restore_Hover, new Rectangle(203, 13, 23, 23), new Rectangle(203, 13, 23, 23), new EventHandler(this.\u008F\u0005));
      this.\u0001[5] = new \u001D.\u001C.\u0002((Image) \u0013.VisualMode_Minimize, (Image) \u0013.VisualMode_Minimize_Hover, new Rectangle(178, 13, 23, 23), new Rectangle(178, 13, 23, 23), new EventHandler(this.\u008E\u0005));
      this.\u0001 = new \u001D.\u001C.\u0001[16];
      this.\u0001[0] = new \u001D.\u001C.\u0001((Image) \u0013.Connect_LargeIcon, \u001D.\u001C.\u0001(37785), Keys.C, new EventHandler(this.\u001D\u0005));
      this.\u0001[1] = new \u001D.\u001C.\u0001((Image) \u0013.Invasions_LargeIcon, \u001D.\u001C.\u0001(64271), Keys.I, new EventHandler(this.\u001E\u0005));
      this.\u0001[2] = new \u001D.\u001C.\u0001((Image) \u0013.GagAMatic_LargeIcon, \u001D.\u001C.\u0001(64288), Keys.G, new EventHandler(this.\u001F\u0005));
      this.\u0001[3] = new \u001D.\u001C.\u0001((Image) \u0013.JoeFish_LargeIcon, \u001D.\u001C.\u0001(64305), Keys.J, new EventHandler(this.\u007F\u0005));
      this.\u0001[4] = new \u001D.\u001C.\u0001((Image) \u0013.GardenerFlora_LargeIcon, \u001D.\u001C.\u0001(64318), Keys.F, new EventHandler(this.\u0080\u0005));
      this.\u0001[5] = new \u001D.\u001C.\u0001((Image) \u0013.RemoteController_LargeIcon, \u001D.\u001C.\u0001(64339), Keys.R, new EventHandler(this.\u0081\u0005));
      this.\u0001[6] = new \u001D.\u001C.\u0001((Image) \u0013.RaceTrack_LargeIcon, \u001D.\u001C.\u0001(64360), Keys.T, new EventHandler(this.\u0082\u0005));
      this.\u0001[7] = new \u001D.\u001C.\u0001((Image) \u0013.ParTeePutt_LargeIcon, \u001D.\u001C.\u0001(64377), Keys.U, new EventHandler(this.\u0083\u0005));
      this.\u0001[8] = new \u001D.\u001C.\u0001((Image) \u0013.MyGallery_LargeIcon, \u001D.\u001C.\u0001(64394), Keys.M, new EventHandler(this.\u0088\u0005));
      this.\u0001[9] = new \u001D.\u001C.\u0001((Image) \u0013.ContentPacks_LargeIcon, \u001D.\u001C.\u0001(64411), Keys.P, new EventHandler(this.\u0084\u0005));
      this.\u0001 = this.\u0001[10] = new \u001D.\u001C.\u0001((Image) \u0013.Hotkeys_LargeIcon, this.\u001D\u0005(), Keys.H, new EventHandler(this.\u008C\u0005));
      this.\u0001[11] = new \u001D.\u001C.\u0001((Image) \u0013.GenericSettings_LargeIcon, \u001D.\u001C.\u0001(8328), Keys.O, new EventHandler(this.\u0086\u0005));
      this.\u0001[12] = new \u001D.\u001C.\u0001((Image) \u0013.Guide_LargeIcon, \u001D.\u001C.\u0001(64432), Keys.F1, new EventHandler(this.\u008A\u0005));
      this.\u0001[13] = new \u001D.\u001C.\u0001((Image) \u0013.ReleaseNotes_LargeIcon, \u001D.\u001C.\u0001(64449), Keys.N, new EventHandler(this.\u0089\u0005));
      this.\u0001[14] = new \u001D.\u001C.\u0001((Image) \u0013.Updating_LargeIcon, \u001D.\u001C.\u0001(62845), Keys.None, new EventHandler(this.\u008B\u0005));
      this.\u0001[15] = new \u001D.\u001C.\u0001((Image) \u0013.About_LargeIcon, \u001D.\u001C.\u0001(64470), Keys.A, new EventHandler(this.\u0087\u0005));
      StringFormat sf = \u001D.\u001C.\u001D\u0005();
      try
      {
        foreach (\u001D.\u001C.\u0001 img in this.\u0001)
          this.\u001D\u0005(img, sf);
      }
      finally
      {
        if (sf != null)
          \u001A\u001E.\u007E\u0094\u0092((object) sf);
      }
      this.CustomPainting = true;
      this.UseOpacity = true;
      this.AllowFormDrag = true;
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.Manual);
      \u0096\u0086.\u0018\u008B((object) this, new Point(\u008D\u0084.\u007E\u0015\u008F((object) \u0001\u001E.\u0014\u008F()).Width - \u0005\u0081.\u0083\u0084((object) this), \u008D\u0084.\u007E\u0015\u008F((object) \u0001\u001E.\u0014\u008F()).Height - \u0005\u0081.\u0098\u0083((object) this)));
    }

    protected override void Dispose(bool disposing)
    {
      // ISSUE: unable to decompile the method.
    }

    private void \u001E\u0005()
    {
      \u001A\u001E.\u0084\u0086((object) this);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(295, 342));
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.None);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u000E\u001F.\u007E\u0005\u0084((object) this, new Size(295, 342));
      \u000E\u001F.\u007E\u0007\u0084((object) this, new Size(295, 342));
      \u0092\u0081.\u0010\u0084((object) this, \u001D.\u001C.\u0001(64245));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001D.\u001C.\u0001(54227));
      \u0087\u0086.\u008D\u0084((object) this, new KeyEventHandler(this.\u001D\u0005));
      \u0086\u001D.\u0098\u0084((object) this, new PreviewKeyDownEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private string \u001D\u0005()
    {
      if (this.\u0001.HotkeysEnabled)
        return \u001D.\u001C.\u0001(63372);
      return \u001D.\u001C.\u0001(63397);
    }

    private void \u001D\u0005(\u001D.\u001C.\u0001 img, StringFormat sf = null)
    {
      bool flag = sf == null;
      try
      {
        if (flag)
          sf = \u001D.\u001C.\u001D\u0005();
        if (img.\u0002 != null)
          \u001A\u001E.\u007E\u001D\u001F((object) img.\u0002);
        img.\u0002 = \u001B.\u001D\u0005(img.\u0001, this.\u0001, \u008E\u001D.\u0017\u007F(7, 54, 109), \u009A\u0080.\u009A\u001F(), sf, this.\u0001.Size, 6);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u007E\u009C\u0082((object) sf);
      }
    }

    private static StringFormat \u001D\u0005()
    {
      StringFormat stringFormat = (StringFormat) null;
      try
      {
        stringFormat = new StringFormat();
        \u0014\u0083.\u007E\u009E\u0082((object) stringFormat, StringAlignment.Center);
        \u0014\u0083.\u007E\u009F\u0082((object) stringFormat, StringAlignment.Center);
        \u0011\u0083.\u007E\u0002\u0083((object) stringFormat, StringTrimming.Character);
        \u009D\u0083.\u007E\u0001\u0083((object) stringFormat, HotkeyPrefix.Show);
        return stringFormat;
      }
      catch
      {
        if (stringFormat != null)
          \u001A\u001E.\u007E\u009C\u0082((object) stringFormat);
        throw;
      }
    }

    private void \u001F\u0005()
    {
      \u000E\u0080.\u0005\u0086((object) this, this.\u0002);
      \u000E\u0080.\u0005\u0086((object) this, this.\u0001);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.\u0006 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0006, (object) this, EventArgs.Empty);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (this.\u0007 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0007, (object) this, EventArgs.Empty);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      if (this.\u0008 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0008, (object) this, EventArgs.Empty);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (this.\u000E == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u000E, (object) this, EventArgs.Empty);
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      if (this.\u000F == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u000F, (object) this, EventArgs.Empty);
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      if (this.\u0010 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0010, (object) this, EventArgs.Empty);
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      if (this.\u0011 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0011, (object) this, EventArgs.Empty);
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      if (this.\u0015 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0015, (object) this, EventArgs.Empty);
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      if (this.\u0004 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0004, (object) this, EventArgs.Empty);
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      if (this.\u0012 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0012, (object) this, EventArgs.Empty);
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      if (this.\u0013 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0013, (object) this, EventArgs.Empty);
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      if (this.\u0003 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0003, (object) this, EventArgs.Empty);
    }

    private void \u0089\u0005(object sender, EventArgs e)
    {
      if (this.\u0014 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0014, (object) this, EventArgs.Empty);
    }

    private void \u008A\u0005(object sender, EventArgs e)
    {
      if (this.\u0005 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0005, (object) this, EventArgs.Empty);
    }

    private void \u008B\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
    }

    private void \u008C\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 == null)
        return;
      \u001A.\u0001 e1 = new \u001A.\u0001();
      this.\u0001((object) this, e1);
      if (!e1.HotkeysEnabledStateChangedResult)
        return;
      this.\u0001.\u0001 = this.\u001D\u0005();
      this.\u001D\u0005(this.\u0001, (StringFormat) null);
      this.\u001F\u0005();
    }

    public void \u007F\u0005()
    {
      this.\u0001.\u0001 = this.\u001D\u0005();
      this.\u001D\u0005(this.\u0001, (StringFormat) null);
      if (this.\u0001 != this.\u0001[this.\u0001])
        return;
      this.\u001F\u0005();
    }

    private void \u008D\u0005(object sender, EventArgs e)
    {
      if (!\u0083.\u001C.CanExitTheToonTownSpoofer)
        return;
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u008E\u0005(object sender, EventArgs e)
    {
      // ISSUE: unable to decompile the method.
    }

    private void \u008F\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u0090\u0005(object sender, EventArgs e)
    {
      this.\u0080\u0005();
    }

    private void \u0080\u0005()
    {
      --this.\u0001;
      if (this.\u0001 < 0)
        this.\u0001 = this.\u0001.Length - 1;
      this.\u001F\u0005();
    }

    private void \u0091\u0005(object sender, EventArgs e)
    {
      this.\u0081\u0005();
    }

    private void \u0081\u0005()
    {
      ++this.\u0001;
      if (this.\u0001 >= this.\u0001.Length)
        this.\u0001 = 0;
      this.\u001F\u0005();
    }

    private void \u0092\u0005(object sender, EventArgs e)
    {
      this.\u0082\u0005();
    }

    private void \u0082\u0005()
    {
      this.\u0001[this.\u0001].\u0081\u0005();
    }

    private void \u001D\u0005(object sender, KeyEventArgs e)
    {
      switch (\u007F\u0081.\u007E\u0013\u008C((object) e))
      {
        case Keys.Return:
          this.\u0082\u0005();
          break;
        case Keys.Left:
          this.\u0080\u0005();
          break;
        case Keys.Right:
          this.\u0081\u0005();
          break;
        default:
          for (int index = 0; index < this.\u0001.Length; ++index)
          {
            \u001D.\u001C.\u0001 obj = this.\u0001[index];
            if (obj.\u0001 == \u007F\u0081.\u007E\u0013\u008C((object) e))
            {
              this.\u0001 = index;
              this.\u001F\u0005();
              obj.\u0081\u0005();
              break;
            }
          }
          break;
      }
    }

    private void \u001D\u0005(object sender, PreviewKeyDownEventArgs e)
    {
      switch (\u007F\u0081.\u007E\u0082\u008E((object) e))
      {
        case Keys.Left:
        case Keys.Right:
          \u0099\u001F.\u007E\u0083\u008E((object) e, true);
          break;
      }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      // ISSUE: unable to decompile the method.
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      // ISSUE: unable to decompile the method.
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      // ISSUE: unable to decompile the method.
    }

    protected override void \u001D\u0005(Graphics gr)
    {
      \u0015\u0083.\u007E\u0081\u007F((object) gr, SmoothingMode.HighQuality);
      \u0094\u0081.\u007E\u0083\u007F((object) gr, InterpolationMode.HighQualityBilinear);
      \u0008\u0083.\u007E\u0080\u007F((object) gr, TextRenderingHint.AntiAliasGridFit);
      \u0004\u001F.\u007E\u009E\u007F((object) gr, (Image) \u0013.VisualMode_01, new Rectangle(0, 0, 295, 201));
      \u0004\u001F.\u007E\u009E\u007F((object) gr, (Image) \u0013.VisualMode_02, new Rectangle(0, 201, 77, 83));
      foreach (\u001D.\u001C.\u0002 obj in this.\u0001)
      {
        if (obj.\u0001 == \u0019.\u0002)
        {
          if (obj.\u0002 != null)
            \u0004\u001F.\u007E\u009E\u007F((object) gr, obj.\u0002, obj.\u0002);
        }
        else if (obj.\u0001 != null)
          \u0004\u001F.\u007E\u009E\u007F((object) gr, obj.\u0001, obj.\u0002);
      }
      \u0004\u001F.\u007E\u009E\u007F((object) gr, (Image) \u0013.VisualMode_05, new Rectangle(212, 201, 83, 83));
      \u0004\u001F.\u007E\u009E\u007F((object) gr, (Image) \u0013.VisualMode_06, new Rectangle(77, 244, 135, 8));
      \u0004\u001F.\u007E\u009E\u007F((object) gr, (Image) \u0013.VisualMode_08, new Rectangle(0, 284, 295, 58));
      \u001D.\u001C.\u0001 obj1 = this.\u0001[this.\u0001];
      \u0004\u001F.\u007E\u009E\u007F((object) gr, obj1.\u0001, this.\u0002);
      \u0004\u001F.\u007E\u009E\u007F((object) gr, obj1.\u0002, new Rectangle(new Point(this.\u0001.\u001D\u0005() - \u0005\u0081.\u007E\u007F\u001F((object) obj1.\u0002) / 2, this.\u0001.\u001E\u0005() - \u0005\u0081.\u007E\u0080\u001F((object) obj1.\u0002) / 2), \u0083\u001E.\u007E\u001F\u001F((object) obj1.\u0002)));
      \u0004\u001F.\u007E\u009E\u007F((object) gr, (Image) \u0013.VisualMode_Screen_Overlay, new Rectangle(58, 46, 173, 108));
      base.\u001D\u0005(gr);
    }

    private sealed class \u0001 : \u0016
    {
      public Image \u0001;
      public string \u0001;
      public Image \u0002;
      public Keys \u0001;

      public event EventHandler LaunchClicked;

      public \u0001(Image normalImage, string text, Keys hotkey, EventHandler launchClicked)
      {
        this.\u0001 = normalImage;
        this.\u0001 = text;
        this.\u0001 = hotkey;
        this.\u0001 = launchClicked;
      }

      protected override void \u001D\u0005()
      {
        if (this.\u0002 != null)
          \u001A\u001E.\u007E\u001D\u001F((object) this.\u0002);
        base.\u001D\u0005();
      }

      public void \u0081\u0005()
      {
        if (this.\u0001 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
      }
    }

    private sealed class \u0002
    {
      public \u0019 \u0001;
      public Rectangle \u0001;
      public Image \u0001;
      public Image \u0002;
      public Rectangle \u0002;

      public event EventHandler ButtonClicked;

      public \u0002(Image normalImage, Image hoverImage, Rectangle imageBounds, Rectangle mouseBounds, EventHandler clicked)
      {
        this.\u0001 = mouseBounds;
        this.\u0002 = imageBounds;
        this.\u0002 = hoverImage;
        this.\u0001 = normalImage;
        this.\u0001 = clicked;
      }

      public void \u001D\u0005()
      {
        if (this.\u0001 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
      }
    }
  }
}
