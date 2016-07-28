// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001A;
using \u001B;
using \u001E;
using \u001F;
using \u0082;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u0003 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u001D \u0001;
    private \u0081 \u0001;
    private \u0081 \u0002;
    private \u0081 \u0003;
    private \u0081 \u0004;
    private \u0081 \u0005;
    private \u0081 \u0006;
    private \u0081 \u0007;
    private \u0081 \u0008;
    private \u0081 \u000E;
    private \u0081 \u000F;
    private Button \u0001;
    private Button \u0002;
    private PictureBox \u0001;
    private PictureBox \u0002;
    private PictureBox \u0003;
    private PictureBox \u0004;
    private PictureBox \u0005;
    private PictureBox \u0006;
    private PictureBox \u0007;
    private PictureBox \u0008;
    private PictureBox \u000E;
    private PictureBox \u000F;
    private \u0006 \u0001;
    private \u0006 \u0002;
    private \u0006 \u0003;
    private \u0006 \u0004;
    private \u0006 \u0005;
    private \u0006 \u0006;
    private \u0006 \u0007;
    private \u0006 \u0008;
    private PictureBox \u0010;
    private PictureBox \u0011;
    private Label \u0001;
    private Label \u0002;
    private \u001C \u0001;
    private Label \u0003;
    private Label \u0004;
    private Panel \u0001;
    private Label \u0005;
    private \u000E \u0001;
    private Dictionary<\u0081, \u001E.\u0001> \u0001;
    private Dictionary<\u0006, \u0080.\u001E> \u0001;
    private Dictionary<PictureBox, \u0081> \u0001;

    static \u0003()
    {
      \u0004.\u001D\u0005(typeof (\u0003));
    }

    public \u0003(\u000E estate)
    {
      this.\u001D\u0005();
      this.\u0001 = new Dictionary<\u0081, \u001E.\u0001>();
      this.\u0001 = new Dictionary<\u0006, \u0080.\u001E>();
      this.\u0001 = new Dictionary<PictureBox, \u0081>();
      this.\u0001 = estate;
      this.\u0001.EstateHome = this.\u0001.HouseColor;
      this.\u0001.Add(this.\u0004, this.\u0001.Flowers[\u007F.\u007F.\u0006]);
      this.\u0001.Add(this.\u0001, this.\u0001.Flowers[\u007F.\u007F.\u0007]);
      this.\u0001.Add(this.\u0002, this.\u0001.Flowers[\u007F.\u007F.\u0008]);
      this.\u0001.Add(this.\u0003, this.\u0001.Flowers[\u007F.\u007F.\u000E]);
      this.\u0001.Add(this.\u0005, this.\u0001.Flowers[\u007F.\u007F.\u000F]);
      this.\u0001.Add(this.\u0006, this.\u0001.Flowers[\u007F.\u007F.\u0010]);
      this.\u0001.Add(this.\u000E, this.\u0001.Flowers[\u007F.\u007F.\u0011]);
      this.\u0001.Add(this.\u0008, this.\u0001.Flowers[\u007F.\u007F.\u0012]);
      this.\u0001.Add(this.\u0007, this.\u0001.Flowers[\u007F.\u007F.\u0013]);
      this.\u0001.Add(this.\u000F, this.\u0001.Flowers[\u007F.\u007F.\u0014]);
      this.\u0001.Add(this.\u0001, this.\u0001.Trees[\u007F.\u007F.\u0015]);
      this.\u0001.Add(this.\u0002, this.\u0001.Trees[\u007F.\u007F.\u0016]);
      this.\u0001.Add(this.\u0003, this.\u0001.Trees[\u007F.\u007F.\u0017]);
      this.\u0001.Add(this.\u0004, this.\u0001.Trees[\u007F.\u007F.\u0018]);
      this.\u0001.Add(this.\u0005, this.\u0001.Trees[\u007F.\u007F.\u0019]);
      this.\u0001.Add(this.\u0006, this.\u0001.Trees[\u007F.\u007F.\u001A]);
      this.\u0001.Add(this.\u0007, this.\u0001.Trees[\u007F.\u007F.\u001B]);
      this.\u0001.Add(this.\u0008, this.\u0001.Trees[\u007F.\u007F.\u001C]);
      this.\u0001.Add(this.\u000F, this.\u0004);
      this.\u0001.Add(this.\u0008, this.\u0001);
      this.\u0001.Add(this.\u0007, this.\u0002);
      this.\u0001.Add(this.\u0006, this.\u0003);
      this.\u0001.Add(this.\u0003, this.\u0005);
      this.\u0001.Add(this.\u0002, this.\u0006);
      this.\u0001.Add(this.\u0001, this.\u000E);
      this.\u0001.Add(this.\u0004, this.\u0008);
      this.\u0001.Add(this.\u0005, this.\u0007);
      this.\u0001.Add(this.\u000E, this.\u000F);
      foreach (KeyValuePair<\u0006, \u0080.\u001E> keyValuePair in this.\u0001)
        \u0003.\u001D\u0005(keyValuePair.Key, keyValuePair.Value);
      foreach (KeyValuePair<\u0081, \u001E.\u0001> keyValuePair in this.\u0001)
        \u0003.\u001D\u0005(keyValuePair.Key, keyValuePair.Value);
      this.\u001E\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0003)));
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0001 = new \u001C();
      this.\u0001 = new Panel();
      this.\u0011 = new PictureBox();
      this.\u0008 = new PictureBox();
      this.\u0002 = new PictureBox();
      this.\u0001 = new \u0006();
      this.\u0005 = new PictureBox();
      this.\u0001 = new \u001D();
      this.\u000E = new PictureBox();
      this.\u0001 = new \u0081();
      this.\u0007 = new PictureBox();
      this.\u0004 = new \u0081();
      this.\u000F = new PictureBox();
      this.\u0002 = new Label();
      this.\u0004 = new PictureBox();
      this.\u000F = new \u0081();
      this.\u0006 = new PictureBox();
      this.\u0001 = new Label();
      this.\u0003 = new PictureBox();
      this.\u0007 = new \u0081();
      this.\u0001 = new PictureBox();
      this.\u0010 = new PictureBox();
      this.\u0002 = new \u0006();
      this.\u0002 = new \u0081();
      this.\u0003 = new \u0006();
      this.\u0008 = new \u0006();
      this.\u0006 = new \u0081();
      this.\u0003 = new \u0081();
      this.\u0004 = new \u0006();
      this.\u0007 = new \u0006();
      this.\u0005 = new \u0081();
      this.\u0008 = new \u0081();
      this.\u0005 = new \u0006();
      this.\u0006 = new \u0006();
      this.\u000E = new \u0081();
      this.\u0003 = new Label();
      this.\u0004 = new Label();
      this.\u0005 = new Label();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0011);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0008);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0002);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0005);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u000E);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0007);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u000F);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0004);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0006);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0003);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0010);
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(444, 522));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(32192));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0003.\u0001(7545));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0002, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(363, 522));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0003.\u0001(13877));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0003.\u0001(7563));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      this.\u0001.CenterColor = \u009A\u0080.\u009C\u001F();
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.ImageBounds = new Rectangle(0, 0, 0, 0);
      this.\u0001.ImageLocation = new Point(0, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(8236));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(515, 514));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 18);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u009C\u001F());
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0011);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0010);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000E);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 35));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(32750));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(506, 476));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 18);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0011, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0011, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(32771)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0011, new Point(5, 438));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0011, \u0003.\u0001(32792));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0011, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0011, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0011, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0011, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0011, new EventHandler(this.\u007F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0008, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(32805)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(179, 258));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0003.\u0001(32830));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0008, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0008, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0008, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0008, new EventHandler(this.\u001F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0002, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(32847)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point((int) byte.MaxValue, 155));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0003.\u0001(32872));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0002, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0002, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0002, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u009C\u001F());
      this.\u0001.GardeningActions = \u0017.\u007F.\u0001;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(360, 295));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(32889));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(62, 32));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 13);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      this.\u0001.TreeEnabled = false;
      this.\u0001.TreeNumber = 1;
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0005, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(32902)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(294, 259));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0003.\u0001(32927));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0005, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0005, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0005, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0005, new EventHandler(this.\u001F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u009C\u001F());
      this.\u0001.EstateHome = \u0014.\u007F.\u0004;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(227, 207));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(32944));
      this.\u0001.Size = new Size(56, 64);
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0003.\u0001(32961));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000E, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u000E, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(32982)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(273, 295));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0003.\u0001(33007));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u000E, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u000E, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u000E, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u000E, new EventHandler(this.\u001F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u009C\u001F());
      this.\u0001.FlowerNumber = 2;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(145, 259));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(33024));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(36, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0007, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(33041)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(179, 224));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0003.\u0001(33066));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0007, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0007, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0007, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0007, new EventHandler(this.\u001F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u009C\u001F());
      this.\u0004.FlowerNumber = 1;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(198, 327));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0003.\u0001(33083));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(36, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0004, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000F, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u000F, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(33100)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(201, 295));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u0003.\u0001(33125));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u000F, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u000F, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u000F, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u000F, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u009C\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(43, 457));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0003.\u0001(5710));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(43, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 15);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0003.\u0001(33142));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0004, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(33155)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(294, 225));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0003.\u0001(33180));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0004, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0004, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0004, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u001F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000F, \u009A\u0080.\u009C\u001F());
      this.\u000F.FlowerNumber = 10;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(270, 327));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u0003.\u0001(33197));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(36, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 10);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u000F, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0006, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(33214)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(179, 190));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0003.\u0001(33239));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0006, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0006, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0006, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0006, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u009C\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(130, 457));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(5760));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(34, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 15);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0003.\u0001(33256));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0003, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(33265)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(221, 155));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0003.\u0001(33290));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0003, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0003, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0003, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u001F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u009A\u0080.\u009C\u001F());
      this.\u0007.FlowerNumber = 9;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(323, 259));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0003.\u0001(33307));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(36, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0007, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(33324)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(294, 191));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(33349));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 12);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0010, \u009A\u0080.\u009C\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0010, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(33366)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0010, new Point(92, 438));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0010, \u0003.\u0001(33387));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0010, new Size(32, 32));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0010, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0010, 14);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0010, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0010, new EventHandler(this.\u0080\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u009C\u001F());
      this.\u0002.GardeningActions = \u0017.\u007F.\u0001;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(428, 295));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0003.\u0001(33400));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(62, 32));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 13);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0002, false);
      this.\u0002.TreeEnabled = false;
      this.\u0002.TreeNumber = 2;
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u009C\u001F());
      this.\u0002.FlowerNumber = 3;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(145, 225));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0003.\u0001(33413));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(36, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0002, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u009C\u001F());
      this.\u0003.GardeningActions = \u0017.\u007F.\u0001;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(360, 333));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0003.\u0001(33430));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(62, 32));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 13);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0003, false);
      this.\u0003.TreeEnabled = false;
      this.\u0003.TreeNumber = 3;
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u009A\u0080.\u009C\u001F());
      this.\u0008.GardeningActions = \u0017.\u007F.\u0001;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(428, 409));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0003.\u0001(33443));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(62, 32));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 13);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0008, false);
      this.\u0008.TreeEnabled = false;
      this.\u0008.TreeNumber = 8;
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u009A\u0080.\u009C\u001F());
      this.\u0006.FlowerNumber = 6;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(253, 124));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0003.\u0001(33456));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(36, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0006, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u009C\u001F());
      this.\u0003.FlowerNumber = 4;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(145, 191));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0003.\u0001(33473));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(36, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0003, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u009C\u001F());
      this.\u0004.GardeningActions = \u0017.\u007F.\u0001;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(428, 333));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0003.\u0001(33490));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(62, 32));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 13);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0004, false);
      this.\u0004.TreeEnabled = false;
      this.\u0004.TreeNumber = 4;
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u009A\u0080.\u009C\u001F());
      this.\u0007.GardeningActions = \u0017.\u007F.\u0001;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(360, 409));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0003.\u0001(33503));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(62, 32));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 13);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0007, false);
      this.\u0007.TreeEnabled = false;
      this.\u0007.TreeNumber = 7;
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u009C\u001F());
      this.\u0005.FlowerNumber = 5;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(219, 124));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0003.\u0001(33516));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(36, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0005, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u009A\u0080.\u009C\u001F());
      this.\u0008.FlowerNumber = 8;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(323, 225));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0003.\u0001(33533));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(36, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0008, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u009C\u001F());
      this.\u0005.GardeningActions = \u0017.\u007F.\u0001;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(360, 371));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0003.\u0001(33550));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(62, 32));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 13);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0005, false);
      this.\u0005.TreeEnabled = false;
      this.\u0005.TreeNumber = 5;
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u009A\u0080.\u009C\u001F());
      this.\u0006.GardeningActions = \u0017.\u007F.\u0001;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(428, 371));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0003.\u0001(33563));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(62, 32));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 13);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0006, false);
      this.\u0006.TreeEnabled = false;
      this.\u0006.TreeNumber = 6;
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000E, \u009A\u0080.\u009C\u001F());
      this.\u000E.FlowerNumber = 7;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(323, 191));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0003.\u0001(33576));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(36, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u000E, false);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0003.\u0001(8472), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0092\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(173, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0003.\u0001(33593));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(208, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 17);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0003.\u0001(33622));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0003.\u0001(8472), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0004, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(10, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0003.\u0001(17926));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(157, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 16);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0003.\u0001(33663));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u0003.\u0001(5367), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(1, 536));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0003.\u0001(7730));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 19);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0003.\u0001(7755));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u0001\u001D.\u007E\u001F\u0083((object) this, ImageLayout.Center);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0002);
      \u000E\u001F.\u0010\u008B((object) this, new Size(522, 550));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(6489)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0003.\u0001(33692));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0003.\u0001(33725));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0011);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0008);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0002);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0005);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u000E);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0007);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u000F);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0004);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0006);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0003);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0010);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001E\u0005()
    {
      switch (this.\u0001.HouseColor)
      {
        case \u0014.\u007F.\u0001:
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(46, 238));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(12, 102));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(89, 135));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(226, 87));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(364, 157));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(432, 223));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(384, 297));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(323, 359));
          break;
        case \u0014.\u007F.\u0002:
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 381));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(47, 341));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(116, 303));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(12, 261));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(227, 88));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point((int) byte.MaxValue, 50));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(413, 67));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(389, 260));
          break;
        case \u0014.\u007F.\u0003:
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(36, 361));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(94, 317));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(94, 107));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(36, 64));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(262, 77));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(338, 345));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(367, 304));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(435, 304));
          break;
        case \u0014.\u007F.\u0004:
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(46, 261));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(12, 109));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(227, 64));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(297, 24));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(389, 191));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(419, 244));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(389, 297));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(351, 381));
          break;
        case \u0014.\u007F.\u0005:
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(48, 297));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(12, 109));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(119, 61));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point((int) byte.MaxValue, 12));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(300, 88));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(341, 50));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(386, 12));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(435, 50));
          break;
        case \u0014.\u007F.\u0006:
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(222, 382));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(33, 225));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(191, 88));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(259, 75));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(419, 124));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(432, 176));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(432, 327));
          \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(351, 368));
          break;
      }
    }

    private static void \u001D\u0005(\u0080.\u001E settings, \u0006 control)
    {
      settings.GardeningActions = control.GardeningActions;
      settings.WaterCount = control.WaterCount;
    }

    private static void \u001D\u0005(\u0006 control, \u0080.\u001E settings)
    {
      control.GardeningActions = settings.GardeningActions;
      control.WaterCount = settings.WaterCount;
    }

    private static void \u001D\u0005(\u0081 control, \u001E.\u0001 settings)
    {
      control.FloraActions = ((\u0004) settings).GardeningActions;
      control.BeanCombination = settings.BeanCombination;
      control.WaterCount = settings.WaterCount;
    }

    private static void \u001D\u0005(\u001E.\u0001 settings, \u0081 control)
    {
      settings.GardeningActions = control.FloraActions;
      settings.BeanCombination = control.BeanCombination;
      settings.WaterCount = control.WaterCount;
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      foreach (KeyValuePair<\u0006, \u0080.\u001E> keyValuePair in this.\u0001)
        \u0003.\u001D\u0005(keyValuePair.Value, keyValuePair.Key);
      foreach (KeyValuePair<\u0081, \u001E.\u0001> keyValuePair in this.\u0001)
        \u0003.\u001D\u0005(keyValuePair.Value, keyValuePair.Key);
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      \u0081 obj = this.\u0001[sender as PictureBox];
      obj.FlowerEnabled = !obj.FlowerEnabled;
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      bool flag = false;
      foreach (\u0081 key in this.\u0001.Keys)
      {
        if (key.FlowerEnabled)
        {
          flag = true;
          break;
        }
      }
      foreach (\u0081 key in this.\u0001.Keys)
        key.FlowerEnabled = !flag;
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      bool flag = false;
      foreach (\u0006 key in this.\u0001.Keys)
      {
        if (key.TreeEnabled)
        {
          flag = true;
          break;
        }
      }
      foreach (\u0006 key in this.\u0001.Keys)
        key.TreeEnabled = !flag;
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u0019);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }
  }
}
