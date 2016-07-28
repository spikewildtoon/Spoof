// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0015;
using \u001A;
using \u001B;
using \u001D;
using \u001E;
using \u001F;
using \u007F;
using \u0080;
using \u0083;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0016
{
  internal sealed class \u0016 : \u0014.\u0017
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private IContainer \u0001;
    private \u0005 \u0001;
    private \u0005 \u0002;
    private \u0005 \u0003;
    private \u0005 \u0004;
    private \u0005 \u0005;
    private Panel \u0001;
    private \u0005 \u0006;
    private Label \u0001;
    private Label \u0002;
    private Label \u0003;
    private Button \u0001;
    private Button \u0002;
    private Label \u0004;
    private new OpenFileDialog \u0001;
    private PictureBox \u0001;
    private LinkLabel \u0001;
    private MenuStrip \u0001;
    private ToolStripMenuItem \u0001;
    private ToolStripMenuItem \u0002;
    private ToolStripMenuItem \u0003;
    private ToolStripSeparator \u0001;
    private ToolStripMenuItem \u0004;
    private ToolStripMenuItem \u0005;
    private ToolStripSeparator \u0002;
    private ToolStripMenuItem \u0006;
    private ToolStripMenuItem \u0007;
    private ToolStripMenuItem \u0008;
    private ToolStripMenuItem \u000E;
    private ToolStripMenuItem \u000F;
    private ToolStripSeparator \u0003;
    private ToolStripMenuItem \u0010;
    private ToolStripMenuItem \u0011;
    private ToolStripMenuItem \u0012;
    private ToolStripMenuItem \u0013;
    private ToolStripSeparator \u0004;
    private ToolStripMenuItem \u0014;
    private ToolStripSeparator \u0005;
    private ToolStripMenuItem \u0015;
    private ToolStripMenuItem \u0016;
    private ToolStripMenuItem \u0017;
    private ToolStripMenuItem \u0018;
    private ToolStripMenuItem \u0019;
    private \u0083.\u0016 \u0001;
    private \u001F.\u001C \u0001;
    private \u0017.\u0080 \u0001;
    private \u0082 \u0001;
    private \u0006 \u0001;
    private \u0003 \u0001;
    private \u0084.\u001C \u0001;

    static \u0016()
    {
      \u0004.\u001D\u0005(typeof (\u0016.\u0016));
    }

    public \u0016()
    {
      this.\u0080\u0005();
      this.\u0001 = \u0081.\u0080.Instance.GardenerFloraSettings.GardenerFloraFiles;
      this.\u0001 = new \u001F.\u001C();
      this.\u0001 = new \u0006();
      this.\u0001 = new \u0003((Control) this.\u0001);
      this.\u0001.ClosePopup += (EventHandler) ((obj, e) => \u001A\u001E.\u007E\u0081\u0089((object) this.\u0001));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler(((\u0014.\u0017) this).\u001D\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(((\u0014.\u0017) this).\u001E\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(((\u0014.\u0017) this).\u001F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(((\u0014.\u0017) this).\u007F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(((\u0014.\u0017) this).\u0080\u0005));
      this.\u001E\u0005();
      string customCaptureFile = \u0081.\u0080.Instance.GardenerFloraSettings.CustomCaptureFile;
      if (\u008F\u0084.\u009E\u0092(customCaptureFile) || !\u008F\u0084.\u0092\u009E(customCaptureFile))
        this.\u007F\u0005(true);
      else if (!this.\u001D\u0005(customCaptureFile))
        this.\u007F\u0005(true);
      string wayPointSettings = \u0081.\u0080.Instance.GardenerFloraSettings.CustomWayPointSettings;
      if (\u008F\u0084.\u009E\u0092(wayPointSettings) || !\u008F\u0084.\u0092\u009E(wayPointSettings))
      {
        this.\u0080\u0005(true);
      }
      else
      {
        if (this.\u001E\u0005(wayPointSettings))
          return;
        this.\u0080\u0005(true);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      if (disposing)
        goto label_11;
label_6:
      base.Dispose(disposing);
      return;
label_11:
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
        goto label_6;
      }
      else
        goto label_6;
    }

    private void \u0080\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0016.\u0016)));
      this.\u0001 = new Panel();
      this.\u0005 = new \u0005();
      this.\u0004 = new \u0005();
      this.\u0003 = new \u0005();
      this.\u0002 = new \u0005();
      this.\u0001 = new \u0005();
      this.\u0006 = new \u0005();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0003 = new Label();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0004 = new Label();
      this.\u0001 = new OpenFileDialog();
      this.\u0001 = new PictureBox();
      this.\u0001 = new LinkLabel();
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
      this.\u0003 = new ToolStripSeparator();
      this.\u0010 = new ToolStripMenuItem();
      this.\u0011 = new ToolStripMenuItem();
      this.\u0012 = new ToolStripMenuItem();
      this.\u0013 = new ToolStripMenuItem();
      this.\u0004 = new ToolStripSeparator();
      this.\u0014 = new ToolStripMenuItem();
      this.\u0005 = new ToolStripSeparator();
      this.\u0015 = new ToolStripMenuItem();
      this.\u0016 = new ToolStripMenuItem();
      this.\u0017 = new ToolStripMenuItem();
      this.\u0018 = new ToolStripMenuItem();
      this.\u0019 = new ToolStripMenuItem();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u0093\u0086((object) this.\u0001, true);
      \u0012\u0082.\u007E\u009C\u008A((object) this.\u0001, BorderStyle.Fixed3D);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(266, 49));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0016.\u0001(20297));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(367, 142));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u0016\u0081());
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0005, DockStyle.Top);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(0, 350));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0005, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0016.\u0016.\u0001(20310));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(346, 70));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 6);
      this.\u0005.OnModified += new EventHandler(this.\u0081\u0005);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u0016\u0081());
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0004, DockStyle.Top);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(0, 280));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0004, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0016.\u0016.\u0001(20335));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(346, 70));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 5);
      this.\u0004.OnModified += new EventHandler(this.\u0081\u0005);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u0016\u0081());
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0003, DockStyle.Top);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(0, 210));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0003, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0016.\u0016.\u0001(20360));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(346, 70));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 4);
      this.\u0003.OnModified += new EventHandler(this.\u0081\u0005);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u0016\u0081());
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0002, DockStyle.Top);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(0, 140));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0002, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0016.\u0016.\u0001(20385));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(346, 70));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      this.\u0002.OnModified += new EventHandler(this.\u0081\u0005);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0016\u0081());
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Top);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 70));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0001, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0016.\u0001(20410));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(346, 70));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      this.\u0001.OnModified += new EventHandler(this.\u0081\u0005);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u009A\u0080.\u0016\u0081());
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0006, DockStyle.Top);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(0, 0));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0006, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0016.\u0016.\u0001(20435));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(346, 70));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 2);
      this.\u0006.OnModified += new EventHandler(this.\u0081\u0005);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0016.\u0016.\u0001(3016), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(91, 75));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0016.\u0001(20456));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(77, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0016.\u0016.\u0001(20481));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0016.\u0016.\u0001(3016), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(146, 57));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0016.\u0016.\u0001(20502));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(114, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 12);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0016.\u0016.\u0001(20535));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0016.\u0016.\u0001(7945), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(9, 49));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0016.\u0016.\u0001(20560));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(139, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 11);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0016.\u0016.\u0001(20585));
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0016.\u0016.\u0001(20606)));
      \u0016\u001E.\u007E\u008A\u0087((object) this.\u0001, ContentAlignment.MiddleRight);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(8, 158));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0016.\u0001(20635));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(252, 33));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 15);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0016.\u0016.\u0001(20656));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u008B\u0005));
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0002, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0016.\u0016.\u0001(20677)));
      \u0016\u001E.\u007E\u008A\u0087((object) this.\u0002, ContentAlignment.MiddleRight);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(8, 119));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0016.\u0016.\u0001(20722));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(252, 33));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 15);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0016.\u0016.\u0001(20759));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u0082\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0016.\u0016.\u0001(3016), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(265, 31));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0016.\u0016.\u0001(20792));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(141, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 12);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0016.\u0016.\u0001(20829));
      \u0092\u0081.\u007E\u0095\u008A((object) this.\u0001, \u0016.\u0016.\u0001(20866));
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0016.\u0016.\u0001(20923)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(167, 73));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0016.\u0001(20960));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(35, 18));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 16);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(412, 32));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0016.\u0001(20989));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(183, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 17);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0016.\u0016.\u0001(21018));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0001, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[4]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0007,
        (ToolStripItem) this.\u0016,
        (ToolStripItem) this.\u0018
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0016.\u0001(21067));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(640, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 18);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0016.\u0016.\u0001(5557));
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
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0016.\u0016.\u0001(21092));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(37, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0016.\u0016.\u0001(5587));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0016.\u0016.\u0001(21109));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0002, Keys.N | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0016.\u0016.\u0001(5605));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0016.\u0016.\u0001(21126));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0003, Keys.O | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0016.\u0016.\u0001(5627));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0016.\u0016.\u0001(21143));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0016.\u0016.\u0001(21168));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0004, Keys.S | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u0016.\u0016.\u0001(5678));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0016.\u0016.\u0001(5687));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0005, Keys.S | Keys.Shift | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u0016.\u0016.\u0001(5708));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0016.\u0016.\u0001(21185));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u0016.\u0016.\u0001(21214));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0006, Keys.W | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u0016.\u0016.\u0001(5771));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0007), new ToolStripItem[4]
      {
        (ToolStripItem) this.\u0008,
        (ToolStripItem) this.\u0011,
        (ToolStripItem) this.\u0005,
        (ToolStripItem) this.\u0015
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u0016.\u0016.\u0001(21235));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(75, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u0016.\u0016.\u0001(21260));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0008), new ToolStripItem[4]
      {
        (ToolStripItem) this.\u000E,
        (ToolStripItem) this.\u000F,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0010
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0008, \u0016.\u0016.\u0001(21277));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0008, new Size(152, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0008, \u0016.\u0016.\u0001(21302));
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u000E, true);
      \u0014\u001D.\u007E\u008E\u008D((object) this.\u000E, CheckState.Checked);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000E, \u0016.\u0016.\u0001(21315));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000E, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000E, \u0016.\u0016.\u0001(21348));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000E, new EventHandler(this.\u0083\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000F, \u0016.\u0016.\u0001(21361));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000F, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000F, \u0016.\u0016.\u0001(21394));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000F, new EventHandler(this.\u0084\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0016.\u0016.\u0001(21407));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(113, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0010, \u0016.\u0016.\u0001(21436));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0010, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0010, \u0016.\u0016.\u0001(21469));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0010, new EventHandler(this.\u0086\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0011), new ToolStripItem[4]
      {
        (ToolStripItem) this.\u0012,
        (ToolStripItem) this.\u0013,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0014
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0011, \u0016.\u0016.\u0001(21482));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0011, new Size(152, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0011, \u0016.\u0016.\u0001(21507));
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, true);
      \u0014\u001D.\u007E\u008E\u008D((object) this.\u0012, CheckState.Checked);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0012, \u0016.\u0016.\u0001(21524));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0012, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0012, \u0016.\u0016.\u0001(21348));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0012, new EventHandler(this.\u0087\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0013, \u0016.\u0016.\u0001(21557));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0013, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0013, \u0016.\u0016.\u0001(21394));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0013, new EventHandler(this.\u0088\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0016.\u0016.\u0001(21590));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(113, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0014, \u0016.\u0016.\u0001(21631));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0014, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0014, \u0016.\u0016.\u0001(21469));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0014, new EventHandler(this.\u0089\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0016.\u0016.\u0001(21664));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(149, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0015, \u0016.\u0016.\u0001(21701));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0015, new Size(152, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0015, \u0016.\u0016.\u0001(21726));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0015, new EventHandler(this.\u008D\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0016), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0017
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0016, \u0016.\u0016.\u0001(21739));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0016, new Size(63, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0016, \u0016.\u0016.\u0001(17686));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0017, \u0016.\u0016.\u0001(17699));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0017, new Size(213, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0017, \u0016.\u0016.\u0001(17728));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0017, new EventHandler(this.\u008A\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0018), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0019
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0018, \u0016.\u0016.\u0001(5906));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0018, new Size(44, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0018, \u0016.\u0016.\u0001(5923));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0019, \u0016.\u0016.\u0001(5932));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0019, Keys.F1);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0019, new Size(124, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0019, \u0016.\u0016.\u0001(5953));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0019, new EventHandler(this.\u008C\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(640, 198));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0016.\u0016.\u0001(5962)));
      \u001A\u001D.\u0019\u008B((object) this, this.\u0001);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0016.\u0016.\u0001(21760));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0016.\u0016.\u0001(21781));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    protected override void \u001D\u0005(\u0084.\u001B fileName, bool modified)
    {
      if (!\u0084.\u001B.\u001D\u0005(fileName, (object) null))
      {
        if (modified)
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u009E\u0081.\u001F\u0093(\u0016.\u0016.\u0001(21939), (object) fileName.\u0001));
        else
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0081\u0086.\u0086\u0093(\u0016.\u0016.\u0001(22012), fileName.\u0001));
      }
      else if (modified)
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u0016.\u0016.\u0001(21858));
      else
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u0016.\u0016.\u0001(21781));
    }

    protected override void \u001D\u0005()
    {
      this.\u0001 = new \u0083.\u0016();
      this.\u0081\u0005();
    }

    protected override bool \u001E\u0005(out \u0084.\u001B fileName)
    {
      \u0084.\u001B selectedFile;
      bool flag = \u0080.\u007F.\u001F\u0005(out selectedFile);
      fileName = !flag ? (\u0084.\u001B) null : selectedFile;
      return flag;
    }

    protected override bool \u001E\u0005(\u0084.\u001B fileName)
    {
      try
      {
        this.\u0001 = new \u0083.\u0016(fileName.\u0002);
        this.\u0081\u0005();
        return true;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u0016.\u0016.\u0001(22081), (object) fileName.\u0002));
        \u0018.\u0017.\u001D\u0005(ex, fileName.\u0002);
        return false;
      }
    }

    protected override bool \u001D\u0005(out \u0084.\u001B filePath)
    {
      \u0008 obj = new \u0008();
      try
      {
        obj.LabelMessage = \u0016.\u0016.\u0001(22126);
        \u0092\u0081.\u007E\u001D\u0084((object) obj, \u0016.\u0016.\u0001(22195));
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj) == DialogResult.OK)
        {
          filePath = new \u0084.\u001B(obj.Value, \u001A.\u0016.\u001E\u0005(\u001A.\u007F.GardenerFloraEstateSettings, \u0016.\u0016.\u0001(22260)));
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

    private void \u0081\u0005()
    {
      this.\u0003.FloraEstatePlantingDetails = this.\u0001.EstatePlantSettings[\u0014.\u007F.\u0004];
      this.\u0001.FloraEstatePlantingDetails = this.\u0001.EstatePlantSettings[\u0014.\u007F.\u0002];
      this.\u0004.FloraEstatePlantingDetails = this.\u0001.EstatePlantSettings[\u0014.\u007F.\u0005];
      this.\u0002.FloraEstatePlantingDetails = this.\u0001.EstatePlantSettings[\u0014.\u007F.\u0003];
      this.\u0006.FloraEstatePlantingDetails = this.\u0001.EstatePlantSettings[\u0014.\u007F.\u0001];
      this.\u0005.FloraEstatePlantingDetails = this.\u0001.EstatePlantSettings[\u0014.\u007F.\u0006];
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      this.FileModified = true;
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u0014.\u001B obj2 = new \u0014.\u001B();
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          obj2.PlantMethod = this.\u0001.PlantMethod;
          obj2.CheckedBeanCombinations = this.\u0001.BeanCombinations;
          if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) != DialogResult.OK)
            return;
          this.\u0001.PlantMethod = obj2.PlantMethod;
          this.\u0001.BeanCombinations.Clear();
          this.\u0001.BeanCombinations.AddRange((IEnumerable<\u001C.\u0018>) obj2.CheckedBeanCombinations);
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      this.\u007F\u0005(true);
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      \u0084.\u001B selectedFile;
      if (!\u0080.\u007F.\u001E\u0005(out selectedFile))
        return;
      if (this.\u001D\u0005(selectedFile.\u0002))
        \u0081.\u0080.Instance.GardenerFloraSettings.CustomCaptureFile = selectedFile.\u0002;
      else
        this.\u007F\u0005(false);
    }

    private static bool \u001D\u0005(\u0082 settings)
    {
      if (settings.FinalPlantCapture != null && settings.NoWaterCapture != null && (settings.PickFlowerCapture != null && settings.PlantFailedCapture != null) && (settings.PlantFlowerCapture != null && (settings.PlantSuccessCapture != null && settings.WaterPlantCapture != null) && (settings.BasketFullCapture != null && settings.SellFlowersCapture != null && (settings.DisabledBeanSlotCapture != null && settings.FinalPickCapture != null))))
        return settings.CancelPlantCapture != null;
      return false;
    }

    private void \u007F\u0005(bool displayErrorIfFailure)
    {
      \u0081.\u0080.Instance.GardenerFloraSettings.CustomCaptureFile = (string) null;
      if (\u008F\u0084.\u0092\u009E(\u001A.\u007F.\u0019))
      {
        bool flag = false;
        \u0082 settings = (\u0082) null;
        try
        {
          settings = new \u0082(\u001A.\u007F.\u0019);
          flag = true;
        }
        catch (Exception ex)
        {
          if (settings != null)
            settings.Dispose();
          settings = (\u0082) null;
          if (displayErrorIfFailure)
            ex.\u001D\u0005((object) \u001A.\u007F.\u0019);
        }
        if (flag && \u0016.\u0016.\u001D\u0005(settings))
        {
          if (this.\u0001 != null)
            this.\u0001.Dispose();
          this.\u0001 = settings;
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u000E, true);
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u000F, false);
        }
        else
        {
          if (settings != null)
            settings.Dispose();
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u000E, false);
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u000F, false);
          if (!displayErrorIfFailure)
            return;
          \u0018.\u0017.\u001D\u0005(\u0016.\u0016.\u0001(22269), \u0016.\u0016.\u0001(22439));
        }
      }
      else
      {
        if (this.\u0001 != null)
          this.\u0001.Dispose();
        this.\u0001 = (\u0082) null;
        if (displayErrorIfFailure)
          \u0018.\u0017.\u001D\u0005(\u0016.\u0016.\u0001(22472), \u0016.\u0016.\u0001(22686));
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u000E, false);
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u000F, false);
      }
    }

    private bool \u001D\u0005(string filePath)
    {
      \u0082 settings = (\u0082) null;
      bool flag = false;
      try
      {
        settings = new \u0082(filePath);
        flag = true;
      }
      catch (Exception ex)
      {
        if (settings != null)
          settings.Dispose();
        settings = (\u0082) null;
        ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u0016.\u0016.\u0001(22711), (object) filePath));
        \u0018.\u0017.\u001D\u0005(ex, filePath);
      }
      if (flag && \u0016.\u0016.\u001D\u0005(settings))
      {
        if (this.\u0001 != null)
          this.\u0001.Dispose();
        this.\u0001 = settings;
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u000F, true);
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u000E, false);
        return true;
      }
      if (settings != null)
        settings.Dispose();
      \u0018.\u0017.\u001D\u0005(\u0016.\u0016.\u0001(22772), \u0016.\u0016.\u0001(22439));
      return false;
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u0013 obj2 = new \u0013();
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2);
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    private void \u0080\u0005(bool displayErrorIfFailure)
    {
      \u0081.\u0080.Instance.GardenerFloraSettings.CustomWayPointSettings = (string) null;
      if (\u008F\u0084.\u0092\u009E(\u001A.\u007F.\u001B))
      {
        bool flag;
        try
        {
          this.\u0001 = new \u0017.\u0080(\u001A.\u007F.\u001B);
          flag = true;
        }
        catch (Exception ex)
        {
          this.\u0001 = (\u0017.\u0080) null;
          if (displayErrorIfFailure)
            \u0018.\u0017.\u001D\u0005(ex, \u001A.\u007F.\u001B);
          flag = false;
        }
        if (flag && \u0016.\u0016.\u001D\u0005(this.\u0001))
        {
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, true);
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0013, false);
        }
        else
        {
          this.\u0001 = (\u0017.\u0080) null;
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, false);
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0013, false);
          if (!displayErrorIfFailure)
            return;
          \u0018.\u0017.\u001D\u0005(\u0016.\u0016.\u0001(22974), \u0016.\u0016.\u0001(23328));
        }
      }
      else
      {
        this.\u0001 = (\u0017.\u0080) null;
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, false);
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0013, false);
        if (!displayErrorIfFailure)
          return;
        \u0018.\u0017.\u001D\u0005(\u0016.\u0016.\u0001(23365), \u0016.\u0016.\u0001(23631));
      }
    }

    private bool \u001E\u0005(string filePath)
    {
      bool flag;
      try
      {
        this.\u0001 = new \u0017.\u0080(filePath);
        flag = true;
      }
      catch (Exception ex)
      {
        this.\u0001 = (\u0017.\u0080) null;
        \u0018.\u0017.\u001D\u0005(ex, filePath);
        flag = false;
      }
      if (flag && \u0016.\u0016.\u001D\u0005(this.\u0001))
      {
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, false);
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0013, true);
        return true;
      }
      \u0018.\u0017.\u001D\u0005(\u0016.\u0016.\u0001(23676), \u0016.\u0016.\u0001(23328));
      return false;
    }

    private static bool \u001D\u0005(\u0017.\u0080 settings)
    {
      if (settings == null || !settings.HasCategories || (!\u0016.\u0016.\u001D\u0005(settings[\u0008.\u0004]) || (!\u0016.\u0016.\u001D\u0005(settings[\u0008.\u0002]) || (!\u0016.\u0016.\u001D\u0005(settings[\u0008.\u0005]) || !\u0016.\u0016.\u001D\u0005(settings[\u0008.\u0003])) || (!\u0016.\u0016.\u001D\u0005(settings[\u0008.\u0001]) || !\u0016.\u0016.\u001D\u0005(settings[\u0008.\u0006]) || !settings[\u0008.\u0007].WayPoints.ContainsKey(\u001A.\u0019.\u0002)))))
        return false;
      return settings[\u0008.\u0007].WayPoints[\u001A.\u0019.\u0002].\u001D\u0005<PointF, \u007F.\u007F>(new \u007F.\u007F[1]{ \u007F.\u007F.\u001D });
    }

    private static bool \u001D\u0005(\u001F.\u0001 settings)
    {
      if (!settings.WayPoints.ContainsKey(\u001A.\u0019.\u0002))
        return false;
      return settings.WayPoints[\u001A.\u0019.\u0002].\u001D\u0005<PointF, \u007F.\u007F>(new \u007F.\u007F[18]{ \u007F.\u007F.\u0006, \u007F.\u007F.\u0007, \u007F.\u007F.\u0008, \u007F.\u007F.\u000E, \u007F.\u007F.\u000F, \u007F.\u007F.\u0010, \u007F.\u007F.\u0011, \u007F.\u007F.\u0012, \u007F.\u007F.\u0013, \u007F.\u007F.\u0014, \u007F.\u007F.\u0015, \u007F.\u007F.\u0016, \u007F.\u007F.\u0017, \u007F.\u007F.\u0018, \u007F.\u007F.\u0019, \u007F.\u007F.\u001A, \u007F.\u007F.\u001B, \u007F.\u007F.\u001C });
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      this.\u0080\u0005(true);
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK)
        return;
      \u0081.\u0080.Instance.GardenerFloraSettings.CustomWayPointSettings = string.Empty;
      if (this.\u001E\u0005(\u0002\u007F.\u007E\u0092\u008A((object) this.\u0001)))
        \u0081.\u0080.Instance.GardenerFloraSettings.CustomWayPointSettings = \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001);
      else
        this.\u0080\u0005(false);
    }

    private void \u0089\u0005(object sender, EventArgs e)
    {
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u0019.\u0001 obj2 = new \u0019.\u0001();
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2);
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    private void \u008A\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001D\u0005((Form) this, (EventHandler<\u0080.\u0017>) null);
    }

    private bool \u0081\u0005()
    {
      if (!this.\u0001.ProcessOpen && !this.\u0001.\u001D\u0005((Form) this))
        return false;
      if (this.\u0001 == null)
      {
        \u0018.\u0017.\u001D\u0005(\u0016.\u0016.\u0001(24022), \u0016.\u0016.\u0001(24204));
        return false;
      }
      if (this.\u0001 == null)
      {
        \u0018.\u0017.\u001D\u0005(\u0016.\u0016.\u0001(24237), \u0016.\u0016.\u0001(24318));
        return false;
      }
      bool flag = false;
      foreach (\u000E obj1 in this.\u0001.EstatePlantSettings.Values)
      {
        if (obj1.Enabled)
        {
          if (obj1.Customized)
          {
            foreach (\u0080.\u001E obj2 in obj1.Trees.Values)
            {
              if (obj2.Enabled && obj2.Water && obj2.WaterCount > 0)
              {
                flag = true;
                break;
              }
            }
            foreach (\u001E.\u0001 obj2 in obj1.Flowers.Values)
            {
              if (obj2.Enabled && (((\u0004) obj2).Water && obj2.WaterCount > 0 || (((\u0004) obj2).Pick || ((\u0004) obj2).Plant)))
              {
                flag = true;
                break;
              }
            }
          }
          else if (obj1.GardenTrees && obj1.Water || obj1.GardenFlowers && (((\u0004) obj1).Pick || ((\u0004) obj1).Plant || obj1.Water))
            flag = true;
        }
        if (flag)
          break;
      }
      if (flag)
        return true;
      \u0018.\u0017.\u001D\u0005(\u0016.\u0016.\u0001(24363), \u0016.\u0016.\u0001(24464));
      return false;
    }

    private void \u008B\u0005(object sender, EventArgs e)
    {
      if (!this.\u0081\u0005())
        return;
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u0016.\u001B obj2 = new \u0016.\u001B(this.\u0001.MainWindowHandle, this.\u0001, this.\u0001, this.\u0001);
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2);
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
      this.\u0001.\u001D\u0005();
    }

    private void \u008C\u0005(object sender, EventArgs e)
    {
      \u0082.\u001D\u0005(\u0002.\u0005);
    }

    private void \u001D\u0005(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.\u0001.\u001E\u0005((Control) this.\u0001);
    }

    private void \u008D\u0005(object sender, EventArgs e)
    {
      \u000E obj = new \u000E();
      try
      {
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj) != DialogResult.OK)
          return;
        \u0081.\u0080.\u001D\u0005();
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
    }
  }
}
