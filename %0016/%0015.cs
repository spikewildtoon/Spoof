// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u001A;
using \u001B;
using \u001C;
using \u001E;
using \u0080;
using \u0081;
using \u0084;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0016
{
  internal sealed class \u0015 : \u0016.\u0014
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private IContainer \u0001;
    private \u0010 \u0001;
    private LinkLabel \u0001;
    private \u0010 \u0002;
    private LinkLabel \u0002;
    private \u0010 \u0003;
    private LinkLabel \u0003;
    private \u0010 \u0004;
    private \u0010 \u0005;
    private \u0010 \u0006;
    private \u0010 \u0007;
    private LinkLabel \u0004;
    private LinkLabel \u0005;
    private \u0010 \u0008;
    private Label \u0001;
    private LinkLabel \u0006;
    private \u0010 \u000E;
    private \u0010 \u000F;
    private Label \u0002;
    private LinkLabel \u0007;
    private Label \u0003;
    private PictureBox \u0001;
    private Label \u0004;
    private LinkLabel \u0008;
    private LinkLabel \u000E;
    private \u001B.\u001C \u0001;
    private LinkLabel \u000F;
    private LinkLabel \u0010;
    private \u0010 \u0010;
    private Panel \u0001;
    private MenuStrip \u0001;
    private ToolStripMenuItem \u0001;
    private ToolStripMenuItem \u0002;
    private ToolStripMenuItem \u0003;
    private ToolStripMenuItem \u0004;
    private ToolStripMenuItem \u0005;
    private ToolStripMenuItem \u0006;
    private ToolStripSeparator \u0001;
    private ToolStripSeparator \u0002;
    private ToolStripMenuItem \u0007;
    private ToolStripMenuItem \u0008;
    private ToolStripMenuItem \u000E;
    private ToolStripMenuItem \u000F;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    private static readonly string \u0007;
    private static readonly string \u0008;
    private static readonly string \u000E;
    private static readonly string \u000F;
    private static readonly string \u0010;
    private static readonly string \u0011;
    private static readonly string \u0012;
    private static readonly string \u0013;
    private static readonly string \u0014;
    private static readonly string \u0015;
    private static readonly string \u0016;
    private static readonly string \u0017;
    private static readonly string \u0018;
    private static readonly string \u0019;
    private static readonly string \u001A;
    private static readonly string \u001B;
    private static readonly string \u001C;
    private static readonly string \u001D;
    private static readonly string \u001E;
    private static readonly string \u001F;
    private static readonly string \u007F;
    private static readonly string \u0080;
    private \u0082 \u0001;
    private \u0084.\u001C \u0001;

    static \u0015()
    {
      \u0004.\u001D\u0005(typeof (\u0016.\u0015));
      \u0016.\u0015.\u0001 = \u0016.\u0015.\u0001(17799);
      \u0016.\u0015.\u0002 = \u0016.\u0015.\u0001(17880);
      \u0016.\u0015.\u0003 = \u0016.\u0015.\u0001(17913);
      \u0016.\u0015.\u0004 = \u0016.\u0015.\u0001(18006);
      \u0016.\u0015.\u0005 = \u0016.\u0015.\u0001(18123);
      \u0016.\u0015.\u0006 = \u0016.\u0015.\u0001(18156);
      \u0016.\u0015.\u0007 = \u0016.\u0015.\u0001(18290);
      \u0016.\u0015.\u0008 = \u0016.\u0015.\u0001(18335);
      \u0016.\u0015.\u000E = \u0016.\u0015.\u0001(18452);
      \u0016.\u0015.\u000F = \u0016.\u0015.\u0001(18481);
      \u0016.\u0015.\u0010 = \u0016.\u0015.\u0001(18598);
      \u0016.\u0015.\u0011 = \u0016.\u0015.\u0001(18707);
      \u0016.\u0015.\u0012 = \u0016.\u0015.\u0001(18820);
      \u0016.\u0015.\u0013 = \u0016.\u0015.\u0001(18921);
      \u0016.\u0015.\u0014 = \u0016.\u0015.\u0001(19038);
      \u0016.\u0015.\u0015 = \u0016.\u0015.\u0001(19163);
      \u0016.\u0015.\u0016 = \u0016.\u0015.\u0001(19301);
      \u0016.\u0015.\u0017 = \u0016.\u0015.\u0001(19451);
      \u0016.\u0015.\u0018 = \u0016.\u0015.\u0001(19581);
      \u0016.\u0015.\u0019 = \u0016.\u0015.\u0001(19650);
      \u0016.\u0015.\u001A = \u0016.\u0015.\u0001(19800);
      \u0016.\u0015.\u001B = \u0016.\u0015.\u0001(19889);
      \u0016.\u0015.\u001C = \u0016.\u0015.\u0001(19962);
      \u0016.\u0015.\u001D = \u0016.\u0015.\u0001(20039);
      \u0016.\u0015.\u001E = \u0016.\u0015.\u0001(20092);
      \u0016.\u0015.\u001F = \u0016.\u0015.\u0001(17741);
      \u0016.\u0015.\u007F = \u0016.\u0015.\u0001(20141);
      \u0016.\u0015.\u0080 = \u0016.\u0015.\u0001(20186);
    }

    public \u0015()
    {
      this.\u0082\u0005();
      this.\u0001 = \u0081.\u0080.Instance.JoeFishSettings.JoeFishCaptureSettings;
      // ISSUE: method pointer
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler((object) this, __methodptr(\u001D\u0005)));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(((\u0014.\u0017) this).\u001E\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(((\u0014.\u0017) this).\u007F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(((\u0014.\u0017) this).\u001F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(((\u0014.\u0017) this).\u0080\u0005));
      this.\u001E\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      base.\u0001.Dispose();
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u0082\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0016.\u0015)));
      this.\u0001 = new \u001B.\u001C();
      this.\u0001 = new \u0010();
      this.\u0004 = new LinkLabel();
      this.\u0001 = new LinkLabel();
      this.\u000F = new LinkLabel();
      this.\u0002 = new \u0010();
      this.\u000E = new LinkLabel();
      this.\u0002 = new LinkLabel();
      this.\u0010 = new LinkLabel();
      this.\u0008 = new LinkLabel();
      this.\u0003 = new \u0010();
      this.\u0004 = new Label();
      this.\u0003 = new LinkLabel();
      this.\u0001 = new PictureBox();
      this.\u0004 = new \u0010();
      this.\u0010 = new \u0010();
      this.\u0003 = new Label();
      this.\u0005 = new \u0010();
      this.\u0007 = new LinkLabel();
      this.\u0006 = new \u0010();
      this.\u0002 = new Label();
      this.\u0007 = new \u0010();
      this.\u000F = new \u0010();
      this.\u000E = new \u0010();
      this.\u0005 = new LinkLabel();
      this.\u0006 = new LinkLabel();
      this.\u0008 = new \u0010();
      this.\u0001 = new Label();
      this.\u0001 = new Panel();
      this.\u0001 = new MenuStrip();
      this.\u0001 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripMenuItem();
      this.\u0003 = new ToolStripMenuItem();
      this.\u0001 = new ToolStripSeparator();
      this.\u0004 = new ToolStripMenuItem();
      this.\u0005 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripSeparator();
      this.\u0006 = new ToolStripMenuItem();
      this.\u0007 = new ToolStripMenuItem();
      this.\u0008 = new ToolStripMenuItem();
      this.\u000E = new ToolStripMenuItem();
      this.\u000F = new ToolStripMenuItem();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(224, 224, 224);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0010);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0010);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.ImageBounds = new Rectangle(0, 0, 0, 0);
      this.\u0001.ImageLocation = new Point(0, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0015.\u0001(16202));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(466, 348));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 31);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(24, 131));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0015.\u0001(16235));
      this.\u0001.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 28);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0016.\u0015.\u0001(16272));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0004, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0004, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(55, 110));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0016.\u0015.\u0001(16281));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(85, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 40);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0004, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0016.\u0015.\u0001(16298));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0004, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0004, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0004, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0001, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0001, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(55, 295));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0015.\u0001(16315));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(118, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 37);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0016.\u0015.\u0001(16336));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0001, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0001, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u000F, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000F, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000F, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000F, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u000F, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(55, 68));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u0016.\u0015.\u0001(16357));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(136, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 36);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u000F, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u0016.\u0015.\u0001(16382));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u000F, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u000F, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u000F, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(24, 194));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0016.\u0015.\u0001(16407));
      this.\u0002.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 27);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0016.\u0015.\u0001(16272));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u000E, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000E, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000E, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000E, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u000E, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(55, 131));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0016.\u0015.\u0001(16444));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(154, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 38);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u000E, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u0016.\u0015.\u0001(16473));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u000E, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u000E, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u000E, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0002, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0002, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(55, 152));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0016.\u0015.\u0001(16506));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(130, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 35);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0002, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0016.\u0015.\u0001(16531));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0002, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0002, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0002, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0010, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0010, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0010, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0010, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0010, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0010, new Point(55, (int) byte.MaxValue));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0010, \u0016.\u0015.\u0001(16560));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0010, new Size(124, 38));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0010, 34);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0010, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, \u0016.\u0015.\u0001(16597));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0010, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0010, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0010, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0008, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0008, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0008, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0008, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(55, 234));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0016.\u0015.\u0001(16642));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(124, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 34);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0008, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u0016.\u0015.\u0001(16663));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0008, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0008, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0008, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(24, 173));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0016.\u0015.\u0001(16688));
      this.\u0003.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 30);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0016.\u0015.\u0001(16272));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0016.\u0015.\u0001(7871), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0004, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(55, 46));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0016.\u0015.\u0001(16709));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(60, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0016.\u0015.\u0001(16726));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0003, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0003, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(55, 89));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0016.\u0015.\u0001(16739));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(126, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 39);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0003, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0016.\u0015.\u0001(16764));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0003, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0003, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0003, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0016.\u0015.\u0001(16789)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(389, 271));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0015.\u0001(16814));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(64, 64));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 46);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(24, 295));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0016.\u0015.\u0001(16831));
      this.\u0004.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 23);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0016.\u0015.\u0001(16272));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0010, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0010, new Point(24, (int) byte.MaxValue));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0010, \u0016.\u0015.\u0001(16856));
      this.\u0010.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0010, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0010, 22);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, \u0016.\u0015.\u0001(16272));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0016.\u0015.\u0001(7871), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(13, 46));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0016.\u0015.\u0001(16901));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(42, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 45);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0016.\u0015.\u0001(16918));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(24, 234));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0016.\u0015.\u0001(16927));
      this.\u0005.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 22);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0016.\u0015.\u0001(16272));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0007, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0007, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0007, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0007, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(55, 316));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0016.\u0015.\u0001(16956));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(109, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 43);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0007, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u0016.\u0015.\u0001(16977));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0007, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0007, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0007, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(24, 89));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0016.\u0015.\u0001(17002));
      this.\u0006.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0016.\u0015.\u0001(16272));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(214, 72));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0016.\u0015.\u0001(17031));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(238, 163));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 33);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0090\u0083.\u007E\u001F\u009C((object) componentResourceManager, \u0016.\u0015.\u0001(17052)));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(24, 68));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0016.\u0015.\u0001(17081));
      this.\u0007.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 26);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u0016.\u0015.\u0001(16272));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000F, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(24, 316));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u0016.\u0015.\u0001(17110));
      this.\u000F.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 29);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u0016.\u0015.\u0001(16272));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000E, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(24, 110));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0016.\u0015.\u0001(17139));
      this.\u000E.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 25);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u0016.\u0015.\u0001(16272));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0005, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0005, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(55, 194));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0016.\u0015.\u0001(17160));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(132, 38));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 42);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0005, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0016.\u0015.\u0001(17197));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0005, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0005, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0005, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0006, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0006, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0006, new Font(\u0016.\u0015.\u0001(7871), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0006, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(55, 173));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0016.\u0015.\u0001(17242));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(132, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 41);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0006, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0016.\u0015.\u0001(17267));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0006, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0006, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0006, new EventHandler(this.\u0082\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(24, 152));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0016.\u0015.\u0001(17292));
      this.\u0008.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 24);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u0016.\u0015.\u0001(16272));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0016.\u0015.\u0001(7871), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(10, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0015.\u0001(17325));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(171, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 32);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0016.\u0015.\u0001(17354));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 24));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0015.\u0001(17387));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(466, 348));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 47);
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[3]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0007,
        (ToolStripItem) this.\u000E
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0015.\u0001(17428));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(466, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 48);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0016.\u0015.\u0001(5483));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0001), new ToolStripItem[7]
      {
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0005,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0006
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0016.\u0015.\u0001(17461));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(37, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0016.\u0015.\u0001(5513));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0016.\u0015.\u0001(17474));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0002, Keys.N | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0016.\u0015.\u0001(5531));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0016.\u0015.\u0001(17495));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0003, Keys.O | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0016.\u0015.\u0001(5553));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0016.\u0015.\u0001(5651));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0016.\u0015.\u0001(17520));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0004, Keys.S | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u0016.\u0015.\u0001(5604));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0016.\u0015.\u0001(17545));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0005, Keys.S | Keys.Shift | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u0016.\u0015.\u0001(5634));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0016.\u0015.\u0001(5562));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u0016.\u0015.\u0001(17570));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0006, Keys.W | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u0016.\u0015.\u0001(5697));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0007), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0008
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u0016.\u0015.\u0001(17595));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(63, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u0016.\u0015.\u0001(17612));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0008, \u0016.\u0015.\u0001(17625));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0008, new Size(213, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0008, \u0016.\u0015.\u0001(17654));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0008, new EventHandler(this.\u0081\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u000E), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u000F
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000E, \u0016.\u0015.\u0001(5832));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000E, new Size(44, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000E, \u0016.\u0015.\u0001(5849));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000F, \u0016.\u0015.\u0001(17687));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u000F, Keys.F1);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000F, new Size(124, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000F, \u0016.\u0015.\u0001(5879));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000F, new EventHandler(this.\u0084\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u000E\u001F.\u0010\u008B((object) this, new Size(466, 372));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u001A\u001D.\u0019\u008B((object) this, this.\u0001);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u000E\u001F.\u007E\u0005\u0084((object) this, new Size(472, 400));
      \u000E\u001F.\u007E\u0007\u0084((object) this, new Size(472, 400));
      \u0092\u0081.\u0010\u0084((object) this, \u0016.\u0015.\u0001(17712));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0016.\u0015.\u0001(17741));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    protected override bool \u001D\u0005(out \u0084.\u001B filePath)
    {
      \u0008 obj = new \u0008();
      try
      {
        obj.LabelMessage = \u0016.\u0015.\u001B;
        \u0092\u0081.\u007E\u001D\u0084((object) obj, \u0016.\u0015.\u001C);
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj) == DialogResult.OK)
        {
          filePath = new \u0084.\u001B(obj.Value, \u001A.\u0016.\u001E\u0005(\u007F.JoeFishCaptureSettingsDirectory, \u0016.\u0015.\u0001(17790)));
          return true;
        }
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
      filePath = (\u0084.\u001B) null;
      return false;
    }

    protected override void \u001D\u0005(\u0084.\u001B fileName)
    {
      this.\u007F\u0005(fileName);
    }

    protected override bool \u001D\u0005(\u0084.\u001B fileName)
    {
      try
      {
        this.\u0001.\u001D\u0005(fileName.\u0002);
        this.\u007F\u0005(fileName);
        return true;
      }
      catch (Exception ex)
      {
        \u0018.\u0017.\u001D\u0005(ex, fileName.\u0002);
        return false;
      }
    }

    private void \u007F\u0005(\u0084.\u001B fileName)
    {
      if (this.\u0001.Files.Contains(fileName))
        return;
      this.\u0001.Files.Add(fileName);
      \u0081.\u0080.\u001D\u0005();
    }

    protected override bool \u001E\u0005(out \u0084.\u001B fileName)
    {
      \u0084.\u001B selectedFile;
      bool flag = \u007F.\u001D\u0005(out selectedFile);
      fileName = !flag ? (\u0084.\u001B) null : selectedFile;
      return flag;
    }

    protected override bool \u001E\u0005(\u0084.\u001B fileName)
    {
      try
      {
        \u0082 obj = new \u0082(fileName.\u0002);
        if (this.\u0001 != null)
          this.\u0001.Dispose();
        this.\u0001 = obj;
        this.\u0083\u0005();
        return true;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u0016.\u0015.\u001D, (object) fileName.\u0002));
        \u0018.\u0017.\u001D\u0005(ex, fileName.\u0002);
        return false;
      }
    }

    protected override void \u001D\u0005()
    {
      if (this.\u0001 != null)
        goto label_2;
label_1:
      this.\u0001 = new \u0082();
      this.\u0083\u0005();
      return;
label_2:
      this.\u0001.Dispose();
      goto label_1;
    }

    protected override void \u001D\u0005(\u0084.\u001B fileName, bool modified)
    {
      if (\u0084.\u001B.\u001D\u0005(fileName, (object) null))
      {
        if (modified)
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0016.\u0015.\u001E);
        else
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0016.\u0015.\u001F);
      }
      else if (modified)
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u009E\u0081.\u001F\u0093(\u0016.\u0015.\u007F, (object) fileName.\u0001));
      else
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u0081\u0086.\u0086\u0093(\u0016.\u0015.\u0080, fileName.\u0001));
    }

    private void \u0083\u0005()
    {
      \u0016.\u0014.\u001D\u0005(this.\u0001.BootCaughtCapture, this.\u0007);
      \u0016.\u0014.\u001D\u0005(this.\u0001.BucketFullCapture, this.\u0006);
      \u0016.\u0014.\u001D\u0005(this.\u0001.CastCapture, this.\u000E);
      \u0016.\u0014.\u001D\u0005(this.\u0001.EstateSellFishCapture, this.\u0001);
      \u0016.\u0014.\u001D\u0005(this.\u0001.ExitFishingCapture, this.\u0008);
      \u0016.\u0014.\u001D\u0005(this.\u0001.FishCaughtCapture, this.\u0003);
      \u0016.\u0014.\u001D\u0005(this.\u0001.FishCaughtDuringBingoCapture, this.\u0002);
      \u0016.\u0014.\u001D\u0005(this.\u0001.NewSpeciesCapture, this.\u0005);
      \u0016.\u0014.\u001D\u0005(this.\u0001.NewSpeciesDuringBingoCapture, this.\u0010);
      \u0016.\u0014.\u001D\u0005(this.\u0001.NoBeansCapture, this.\u0004);
      \u0016.\u0014.\u001D\u0005(this.\u0001.SellFishCapture, this.\u000F);
    }

    private void \u001D\u0005(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.\u0080\u0005();
      \u0082 bmp = (\u0082) null;
      try
      {
        if (!\u0013\u0080.\u0089\u0091(sender, (object) this.\u0004))
        {
          if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0002))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0016.\u0015.\u0003, \u0016.\u0015.\u0002, this.\u0001.ExitFishingBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.ExitFishingCapture != null)
              {
                this.\u0001.ExitFishingCapture.Dispose();
                this.\u0001.ExitFishingCapture = (\u0083.\u0018) null;
              }
              this.\u0001.ExitFishingCapture = new \u0083.\u0018(bmp);
              this.\u0001.ExitFishingBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0006))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0016.\u0015.\u0004, \u0016.\u0015.\u0005, this.\u0001.FishCaughtBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.FishCaughtCapture != null)
              {
                this.\u0001.FishCaughtCapture.Dispose();
                this.\u0001.FishCaughtCapture = (\u0083.\u0018) null;
              }
              this.\u0001.FishCaughtCapture = new \u0083.\u0018(bmp);
              this.\u0001.FishCaughtBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0005))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0016.\u0015.\u0006, \u0016.\u0015.\u0007, this.\u0001.FishCaughtDuringBingoBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.FishCaughtDuringBingoCapture != null)
              {
                this.\u0001.FishCaughtDuringBingoCapture.Dispose();
                this.\u0001.FishCaughtDuringBingoCapture = (\u0083.\u0018) null;
              }
              this.\u0001.FishCaughtDuringBingoCapture = new \u0083.\u0018(bmp);
              this.\u0001.FishCaughtDuringBingoBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u000F))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0016.\u0015.\u0008, \u0016.\u0015.\u000E, this.\u0001.BootCaughtBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.BootCaughtCapture != null)
              {
                this.\u0001.BootCaughtCapture.Dispose();
                this.\u0001.BootCaughtCapture = (\u0083.\u0018) null;
              }
              this.\u0001.BootCaughtCapture = new \u0083.\u0018(bmp);
              this.\u0001.BootCaughtBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0003))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0016.\u0015.\u000F, \u0016.\u0015.\u0010, this.\u0001.BucketFullBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.BucketFullCapture != null)
              {
                this.\u0001.BucketFullCapture.Dispose();
                this.\u0001.BucketFullCapture = (\u0083.\u0018) null;
              }
              this.\u0001.BucketFullCapture = new \u0083.\u0018(bmp);
              this.\u0001.BucketFullBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0007))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0016.\u0015.\u0011, \u0016.\u0015.\u0012, this.\u0001.SellFishBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.SellFishCapture != null)
              {
                this.\u0001.SellFishCapture.Dispose();
                this.\u0001.SellFishCapture = (\u0083.\u0018) null;
              }
              this.\u0001.SellFishCapture = new \u0083.\u0018(bmp);
              this.\u0001.SellFishBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0001))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0016.\u0015.\u0013, \u0016.\u0015.\u0014, this.\u0001.NoBeansBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.NoBeansCapture != null)
              {
                this.\u0001.NoBeansCapture.Dispose();
                this.\u0001.NoBeansCapture = (\u0083.\u0018) null;
              }
              this.\u0001.NoBeansCapture = new \u0083.\u0018(bmp);
              this.\u0001.NoBeansBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u000E))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0016.\u0015.\u0015, \u0016.\u0015.\u0016, this.\u0001.EstateSellFishBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.EstateSellFishCapture != null)
              {
                this.\u0001.EstateSellFishCapture.Dispose();
                this.\u0001.EstateSellFishCapture = (\u0083.\u0018) null;
              }
              this.\u0001.EstateSellFishCapture = new \u0083.\u0018(bmp);
              this.\u0001.EstateSellFishBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0008))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0016.\u0015.\u0017, \u0016.\u0015.\u0018, this.\u0001.NewSpeciesBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.NewSpeciesCapture != null)
              {
                this.\u0001.NewSpeciesCapture.Dispose();
                this.\u0001.NewSpeciesCapture = (\u0083.\u0018) null;
              }
              this.\u0001.NewSpeciesCapture = new \u0083.\u0018(bmp);
              this.\u0001.NewSpeciesBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0010))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0016.\u0015.\u0019, \u0016.\u0015.\u001A, this.\u0001.NewSpeciesDuringBingoBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.NewSpeciesDuringBingoCapture != null)
              {
                this.\u0001.NewSpeciesDuringBingoCapture.Dispose();
                this.\u0001.NewSpeciesDuringBingoCapture = (\u0083.\u0018) null;
              }
              this.\u0001.NewSpeciesDuringBingoCapture = new \u0083.\u0018(bmp);
              this.\u0001.NewSpeciesDuringBingoBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
        }
        else
        {
          \u0013 resulting_ratio;
          if (this.\u001D\u0005(\u0016.\u0015.\u0001, \u0016.\u0015.\u0002, this.\u0001.CastBounds, out bmp, out resulting_ratio))
          {
            if (this.\u0001.CastCapture != null)
            {
              this.\u0001.CastCapture.Dispose();
              this.\u0001.CastCapture = (\u0083.\u0018) null;
            }
            this.\u0001.CastCapture = new \u0083.\u0018(bmp);
            this.\u0001.CastBounds = resulting_ratio;
            this.FileModified = true;
          }
        }
      }
      catch
      {
        if (bmp != null)
          bmp.Dispose();
        throw;
      }
      this.\u0083\u0005();
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      base.\u0001.\u001D\u0005((Form) this, (EventHandler<\u0080.\u0017>) null);
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      \u0083.\u0018 pix = (\u0083.\u0018) null;
      Control ctr = (Control) null;
      if (!\u0013\u0080.\u0089\u0091(sender, (object) this.\u0004))
      {
        if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0002))
        {
          pix = this.\u0001.ExitFishingCapture;
          ctr = (Control) this.\u0002;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0006))
        {
          pix = this.\u0001.FishCaughtCapture;
          ctr = (Control) this.\u0006;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0005))
        {
          pix = this.\u0001.FishCaughtDuringBingoCapture;
          ctr = (Control) this.\u0005;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u000F))
        {
          pix = this.\u0001.BootCaughtCapture;
          ctr = (Control) this.\u000F;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0003))
        {
          pix = this.\u0001.BucketFullCapture;
          ctr = (Control) this.\u0003;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0007))
        {
          pix = this.\u0001.SellFishCapture;
          ctr = (Control) this.\u0007;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0001))
        {
          pix = this.\u0001.NoBeansCapture;
          ctr = (Control) this.\u0001;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u000E))
        {
          pix = this.\u0001.EstateSellFishCapture;
          ctr = (Control) this.\u000E;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0008))
        {
          pix = this.\u0001.NewSpeciesCapture;
          ctr = (Control) this.\u0008;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0010))
        {
          pix = this.\u0001.NewSpeciesDuringBingoCapture;
          ctr = (Control) this.\u0010;
        }
      }
      else
        goto label_24;
label_22:
      if (pix == null || ctr == null)
        return;
      this.\u001D\u0005(pix, ctr);
      return;
label_24:
      pix = this.\u0001.CastCapture;
      ctr = (Control) this.\u0004;
      goto label_22;
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      this.\u0080\u0005();
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      \u0082.\u001D\u0005(\u0002.\u001B);
    }
  }
}
