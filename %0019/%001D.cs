// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0018;
using \u001A;
using \u001E;
using \u007F;
using \u0083;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace \u0019
{
  internal sealed class \u001D : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Label \u0001;
    private PictureBox \u0001;
    private Label \u0002;
    private Label \u0003;
    private Label \u0004;
    private Label \u0005;
    private \u001F.\u001E \u0001;
    private \u001F.\u001E \u0002;
    private Label \u0006;
    private Button \u0001;
    private Button \u0002;
    private Button \u0003;
    private \u0013 \u0001;
    private LinkLabel \u0001;
    private CheckBox \u0001;
    private CheckBox \u0002;
    private Label \u0007;
    private ComboBox \u0001;
    private Label \u0008;
    private \u001B.\u001C \u0001;
    private Label \u000E;
    private LinkLabel \u0002;
    private Button \u0004;
    private Button \u0005;
    private Label \u000F;
    private PictureBox \u0002;
    private OpenFileDialog \u0001;
    private Label \u0010;
    private Label \u0011;
    private Label \u0012;
    private Label \u0013;
    private Label \u0014;
    private \u0002 \u0001;
    private Label \u0015;
    private \u0007 \u0001;
    private List<\u001F.\u0081> \u0001;
    private \u001D.\u0001 \u0001;
    private List<string> \u0001;
    private \u0084.\u001C \u0001;
    private \u0082.\u0018 \u0001;

    static \u001D()
    {
      \u0004.\u001D\u0005(typeof (\u0019.\u001D));
    }

    public \u001D(List<string> contentPackPaths)
    {
      this.\u001D\u0005();
      this.\u0001 = \u0081.\u0080.Instance.ConnectSettings;
      this.\u0001 = \u0081.\u0080.Instance.CreatedFileArchive;
      this.\u0001 = \u0081.\u0080.Instance.ApplicationSettings;
      if (\u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) != 1)
        \u0011\u001F.\u007E\u000E\u0088((object) this.\u0001, 1);
      else
        this.\u001E\u0005();
      this.\u001F\u0005();
      this.\u0001 = contentPackPaths;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        goto label_3;
label_2:
      \u0099\u001F.\u0093\u008B((object) this, disposing);
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
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0019.\u001D)));
      this.\u0002 = new Button();
      this.\u0003 = new Button();
      this.\u0004 = new Button();
      this.\u0005 = new Button();
      this.\u0001 = new OpenFileDialog();
      this.\u0001 = new \u001B.\u001C();
      this.\u0015 = new Label();
      this.\u0001 = new \u0002();
      this.\u0002 = new PictureBox();
      this.\u0001 = new PictureBox();
      this.\u000F = new Label();
      this.\u000E = new Label();
      this.\u0001 = new Label();
      this.\u0001 = new Button();
      this.\u0008 = new Label();
      this.\u0001 = new \u001F.\u001E();
      this.\u0006 = new Label();
      this.\u0002 = new \u001F.\u001E();
      this.\u0001 = new ComboBox();
      this.\u0007 = new Label();
      this.\u0002 = new CheckBox();
      this.\u0005 = new Label();
      this.\u0001 = new CheckBox();
      this.\u0004 = new Label();
      this.\u0002 = new LinkLabel();
      this.\u0001 = new LinkLabel();
      this.\u0003 = new Label();
      this.\u0010 = new Label();
      this.\u0011 = new Label();
      this.\u0012 = new Label();
      this.\u0013 = new Label();
      this.\u0014 = new Label();
      this.\u0002 = new Label();
      this.\u0001 = new \u0013();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0002);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(472, 386));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u001D.\u0001(45994));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(83, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 15);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(46015));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0003, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0003, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(561, 386));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0019.\u001D.\u0001(36302));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(83, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 15);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0019.\u001D.\u0001(36319));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u0081\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0004, AnchorStyles.Bottom | AnchorStyles.Left);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(117, 386));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0019.\u001D.\u0001(46028));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(108, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0019.\u001D.\u0001(46057));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u0084\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0005, AnchorStyles.Bottom | AnchorStyles.Left);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(3, 386));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0019.\u001D.\u0001(46078));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(108, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0019.\u001D.\u0001(46103));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0005, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0005, new EventHandler(this.\u0086\u0005));
      \u0092\u0081.\u007E\u0095\u008A((object) this.\u0001, \u0019.\u001D.\u0001(46124));
      \u0092\u0081.\u007E\u0099\u008A((object) this.\u0001, \u0019.\u001D.\u0001(46153));
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(224, 224, 224);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0015);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0010);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0011);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0012);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0013);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0014);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.ImageBounds = new Rectangle(0, 0, 0, 0);
      this.\u0001.ImageLocation = new Point(0, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(3, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46198));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(641, 377));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 20);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0015, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0015, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0015, new Font(\u0019.\u001D.\u0001(5871), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0015, \u009A\u0080.\u0092\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0015, new Point(4, 361));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0015, \u0019.\u001D.\u0001(8234));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0015, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0015, 23);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0015, \u0019.\u001D.\u0001(8259));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(248, 7));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46219));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(149, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 22);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0002, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0019.\u001D.\u0001(46240)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(522, 40));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u001D.\u0001(46273));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(97, 98));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0002, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0002, 21);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0002, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0012\u0082.\u007E\u001C\u008E((object) this.\u0001, BorderStyle.FixedSingle);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(22, 51));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46298));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(208, 208));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.StretchImage);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 11);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u000F, AnchorStyles.Top | AnchorStyles.Right);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000F, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000F, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000F, new Font(\u0019.\u001D.\u0001(8976), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u000F, \u009A\u0080.\u0092\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(473, 10));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u0019.\u001D.\u0001(46327));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(57, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u0019.\u001D.\u0001(46344));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000E, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000E, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000E, new Font(\u0019.\u001D.\u0001(8976), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u000E, \u009A\u0080.\u0092\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(123, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0019.\u001D.\u0001(46357));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(66, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u0019.\u001D.\u0001(46390));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0019.\u001D.\u0001(8976), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(10, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46403));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(110, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46428));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(536, 159));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46449));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(83, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 15);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u001D.\u0001(31789));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0008, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0008, new Font(\u0019.\u001D.\u0001(8976), 9f));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0008, \u009A\u0080.\u0092\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(92, 338));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0019.\u001D.\u0001(46482));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(69, 14));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u0019.\u001D.\u0001(46507));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      this.\u0001.HoverEndColor = \u009A\u0080.\u0096\u001F();
      this.\u0001.HoverStartColor = \u009A\u0080.\u000E\u007F();
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(34, 286));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46524));
      this.\u0001.NormalEndColor = \u009A\u0080.\u0092\u001F();
      this.\u0001.NormalStartColor = \u009A\u0080.\u000E\u007F();
      this.\u0001.Rotation = 270;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(55, 55));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46549));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0082\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0006, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0006, new Font(\u0019.\u001D.\u0001(8976), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0006, \u009A\u0080.\u0092\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(98, 304));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0019.\u001D.\u0001(46566));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(56, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0019.\u001D.\u0001(46583));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      this.\u0002.HoverEndColor = \u009A\u0080.\u0096\u001F();
      this.\u0002.HoverStartColor = \u009A\u0080.\u000E\u007F();
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(163, 286));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u001D.\u0001(46592));
      this.\u0002.NormalEndColor = \u009A\u0080.\u0092\u001F();
      this.\u0002.NormalStartColor = \u009A\u0080.\u000E\u007F();
      this.\u0002.Rotation = 90;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(55, 55));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(46549));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u0083\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0019\u001D.\u007E\u009B\u0088((object) this.\u0001, ComboBoxStyle.DropDownList);
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0001, true);
      \u0003\u0083.\u007E\u0004\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), new object[2]
      {
        (object) \u0019.\u001D.\u0001(46613),
        (object) \u0019.\u001D.\u0001(46622)
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(536, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46643));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(95, 21));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 19);
      \u0087\u007F.\u007E\u009C\u0088((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0007, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0007, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(265, 139));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0019.\u001D.\u0001(46664));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(75, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u0019.\u001D.\u0001(46705));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(267, 166));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u001D.\u0001(46726));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(119, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 18);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(46747));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, false);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0002, new EventHandler(this.\u007F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0005, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(264, 117));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0019.\u001D.\u0001(46772));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(40, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0019.\u001D.\u0001(46805));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(444, 165));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46818));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(86, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 18);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46843));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, false);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0001, new EventHandler(this.\u0087\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0004, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(264, 95));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0019.\u001D.\u0001(46860));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(45, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0019.\u001D.\u0001(46893));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0002, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0019.\u001D.\u0001(8976), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0002, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(194, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u001D.\u0001(46906));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(53, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 17);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0002, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(46939));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0002, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0001, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0001, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(55, 262));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46948));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(142, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 17);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u001D.\u0001(46969));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0001, new LinkLabelLinkClickedEventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(264, 73));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0019.\u001D.\u0001(47006));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(41, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0019.\u001D.\u0001(47039));
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0010, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0010, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0010, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0010, new Point(345, 139));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0010, \u0019.\u001D.\u0001(47052));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0010, new Size(164, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0010, 13);
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0011, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0011, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0011, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0011, new Point(345, 117));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0011, \u0019.\u001D.\u0001(18006));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0011, new Size(164, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0011, 13);
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0012, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0012, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0012, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0012, new Point(345, 95));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0012, \u0019.\u001D.\u0001(47077));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0012, new Size(164, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0012, 13);
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0013, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0013, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0013, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0013, new Point(345, 73));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0013, \u0019.\u001D.\u0001(47094));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0013, new Size(164, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0013, 13);
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0014, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0014, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0014, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0014, new Point(345, 51));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0014, \u0019.\u001D.\u0001(47111));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0014, new Size(164, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0014, 13);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(264, 51));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u001D.\u0001(47124));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(38, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(47153));
      \u0012\u0082.\u007E\u0012\u008A((object) this.\u0001, BorderStyle.None);
      \u0099\u001F.\u007E\u0099\u008E((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(267, 186));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u001D.\u0001(47162));
      \u0099\u001F.\u007E\u0019\u008A((object) this.\u0001, true);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(352, 168));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 16);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u001D.\u0001(4033));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0003);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0003);
      \u000E\u001F.\u0010\u008B((object) this, new Size(646, 413));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0019.\u001D.\u0001(6993)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0019.\u001D.\u0001(47183));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0019.\u001D.\u0001(47200));
      \u0087\u007F.\u008F\u008B((object) this, new EventHandler(this.\u001E\u0005));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0002);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
      this.\u007F\u0005();
    }

    private void \u001E\u0005()
    {
      switch (\u0005\u0081.\u007E\u0008\u0088((object) this.\u0001))
      {
        case 1:
          this.\u0001 = this.\u0001.ContentPacks.OrderBy<\u001F.\u0081, DateTime>((Func<\u001F.\u0081, DateTime>) (item => item.DateInstalled)).ToList<\u001F.\u0081>();
          break;
        default:
          this.\u0001 = this.\u0001.ContentPacks.OrderBy<\u001F.\u0081, string>((Func<\u001F.\u0081, string>) (item => item.Name)).ToList<\u001F.\u0081>();
          break;
      }
    }

    private void \u001D\u0005(object sender, LinkLabelLinkClickedEventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u001D.\u0001 obj = new \u0019.\u001D.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = new \u0014.\u001A();
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        obj.\u0001.Shown += new EventHandler(obj.\u001D\u0005);
        // ISSUE: reference to a compiler-generated field
        int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj.\u0001);
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj.\u0001);
        }
      }
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u001F\u0005()
    {
      if (this.\u0001.SpoofedToonTownEnabled)
      {
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u0019.\u001D.\u0001(47249));
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(47262));
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      }
      else
      {
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u0019.\u001D.\u0001(46390));
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(46939));
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, true);
      }
    }

    private void \u001D\u0005(\u0007 contentPack)
    {
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) null);
      if (this.\u0001 != null && this.\u0001 != contentPack)
      {
        this.\u0001.Dispose();
        this.\u0001 = (\u0007) null;
      }
      if (contentPack == null)
      {
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0013, string.Empty);
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0014, string.Empty);
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0012, string.Empty);
        \u0092\u0081.\u007E\u009B\u008E((object) this.\u0001, string.Empty);
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, string.Empty);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
        this.\u001E\u0005((\u0007) null);
      }
      else
      {
        \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) contentPack.ContentPack.Icon);
        this.\u0013.Text = \u008F\u0084.\u009E\u0092(contentPack.ContentPack.Author) ? \u0019.\u001D.\u0001(28269) : contentPack.ContentPack.Author;
        this.\u0014.Text = \u008F\u0084.\u009E\u0092(contentPack.ContentPack.Name) ? \u0019.\u001D.\u0001(47275) : contentPack.ContentPack.Name;
        switch (contentPack.ContentPack.Type)
        {
          case \u001E.\u0081.\u0001:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0012, \u0019.\u001D.\u0001(47288));
            break;
          case \u001E.\u0081.\u0002:
            this.\u0012.Text = contentPack.ContentPack.Version.\u001D\u0005() ? \u0019.\u001D.\u0001(28269) : \u009C\u007F.\u007E\u0011\u0098((object) contentPack.ContentPack.Version, 4);
            break;
        }
        this.\u0001.Rtf = \u008F\u0084.\u009E\u0092(contentPack.ContentPack.Description) ? string.Empty : contentPack.ContentPack.Description;
        switch (contentPack.ContentPackSettings.InstallState)
        {
          case \u001D.\u001D.\u0002:
          case \u001D.\u001D.\u0004:
            \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, !contentPack.ContentPackSettings.LoaderPack);
            break;
          default:
            \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
            break;
        }
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, \u009E\u0081.\u001F\u0093(\u0019.\u001D.\u0001(47313), (object) contentPack.ContentPackSettings.DateInstalled));
        this.\u001E\u0005(contentPack);
      }
      this.\u0001 = contentPack;
      this.\u007F\u0005();
    }

    private void \u001E\u0005(\u0007 contentPack)
    {
      if (contentPack == null)
      {
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, string.Empty);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, false);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, false);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(46747));
      }
      else
      {
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, true);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, this.\u0001.SpoofedToonTownEnabled);
        if (contentPack.ContentPackSettings.LoaderPack)
        {
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
          \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, true);
        }
        else
        {
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, \u008E\u0081.\u008B\u0002\u0002(contentPack.ContentPackSettings.UpdateUri, (Uri) null));
          \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, contentPack.ContentPackSettings.AutoUpdate);
        }
        switch (contentPack.ContentPackSettings.InstallState)
        {
          case \u001D.\u001D.\u0001:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(47454));
            \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, false);
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, \u0019.\u001D.\u0001(47479));
            break;
          case \u001D.\u001D.\u0002:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(47334));
            \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, false);
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, \u0019.\u001D.\u0001(47359));
            break;
          case \u001D.\u001D.\u0003:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(47496));
            \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, true);
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, \u0019.\u001D.\u0001(47541));
            break;
          case \u001D.\u001D.\u0004:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u001D.\u0001(47372));
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, \u0019.\u001D.\u0001(47413));
            \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, true);
            break;
        }
      }
    }

    private void \u007F\u0005()
    {
      if (this.\u0001 == null || this.\u0001.Count == 0)
      {
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u009E\u0081.\u001F\u0093(\u0019.\u001D.\u0001(47586), (object) this.\u0001.Count));
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      }
      else
      {
        int num = this.\u0001.IndexOf(this.\u0001.ContentPackSettings);
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u0014\u0084.\u007F\u0093(\u0019.\u001D.\u0001(47607), (object) (num + 1), (object) this.\u0001.Count));
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, num < this.\u0001.Count - 1);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, num > 0);
      }
    }

    public void \u001D\u0005(List<string> contentPackPaths)
    {
      if (this.\u0001 == null || this.\u0001.Count <= 0)
        return;
      foreach (string contentPackPath in contentPackPaths)
        this.\u001D\u0005(contentPackPath);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u0080\u0005();
      if (this.\u0001.FirstTimeOpeningContentPacks)
      {
        this.\u0001.FirstTimeOpeningContentPacks = false;
        this.\u0083\u0005();
      }
      this.\u001D\u0005(this.\u0001);
    }

    private void \u0080\u0005()
    {
      if (this.\u0001.Count > 0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0019.\u001D.\u0002 obj = new \u0019.\u001D.\u0002();
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = this;
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = new \u0014.\u001A();
        try
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj.\u0001.Shown += new EventHandler(obj.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj.\u0001);
        }
        finally
        {
          // ISSUE: reference to a compiler-generated field
          if (obj.\u0001 != null)
          {
            // ISSUE: reference to a compiler-generated field
            \u001A\u001E.\u007E\u0094\u0092((object) obj.\u0001);
          }
        }
      }
      else
        this.\u001D\u0005((\u0007) null);
    }

    private void \u0081\u0005()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u001D.\u0003 obj1 = new \u0019.\u001D.\u0003();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      \u001C.\u001A contentPack = (\u001C.\u001A) null;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this.\u0001[0];
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = (\u0007) null;
      try
      {
        // ISSUE: reference to a compiler-generated field
        contentPack = new \u001C.\u001A(obj1.\u0001.FileName, true, false);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = new \u0007(obj1.\u0001, contentPack);
      }
      catch (Exception ex)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0019.\u001D.\u0004 obj2 = new \u0019.\u001D.\u0004();
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = obj1;
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = ex;
        if (contentPack != null)
          contentPack.Dispose();
        // ISSUE: reference to a compiler-generated field
        if (obj1.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001.Dispose();
        }
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = (\u0007) null;
        // ISSUE: reference to a compiler-generated method
        this.\u001E\u0005(new MethodInvoker(obj2.\u001D\u0005));
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj1.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated method
          this.\u001E\u0005(new MethodInvoker(obj1.\u001D\u0005));
        }
      }
    }

    private void \u001D\u0005(\u001F.\u0081 settings)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u001D.\u0005 obj1 = new \u0019.\u001D.\u0005();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = settings;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u001D.\u0006 obj2 = new \u0019.\u001D.\u0006();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new \u0014.\u001A();
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        obj2.\u0001.Shown += new EventHandler(obj2.\u001D\u0005);
        // ISSUE: reference to a compiler-generated field
        int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2.\u0001);
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj2.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj2.\u0001);
        }
      }
    }

    private void \u0082\u0005()
    {
      HashSet<string> changedMultiFiles;
      \u001F.\u0081.\u001D\u0005(\u001A.\u007F.ToonTownOpenDataDirectory, out changedMultiFiles);
      \u0081.\u0080.Instance.ConnectSettings.SpoofedToonTownVersionData.\u001D\u0005((\u001B.\u0019) null, changedMultiFiles, \u001A.\u007F.ToonTownOpenDataDirectory);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      \u0092\u0081.\u007E\u0093\u008A((object) this.\u0001, string.Empty);
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK)
        return;
      this.\u001D\u0005(\u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
    }

    private void \u001D\u0005(string path)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u001D.\u0007 obj1 = new \u0019.\u001D.\u0007();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = path;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u001D.\u0008 obj2 = new \u0019.\u001D.\u0008();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new \u0014.\u001A();
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        obj2.\u0001.Shown += new EventHandler(obj2.\u001D\u0005);
        // ISSUE: reference to a compiler-generated field
        int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2.\u0001);
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj2.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj2.\u0001);
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (obj1.\u0001)
        \u0018.\u0017.\u001D\u0005(\u0019.\u001D.\u0001(47628), \u0019.\u001D.\u0001(47766));
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 == null)
        return;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u001D.\u000E obj = new \u0019.\u001D.\u000E();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = new \u0014.\u001A();
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        obj.\u0001.Shown += new EventHandler(obj.\u001D\u0005);
        // ISSUE: reference to a compiler-generated field
        int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj.\u0001);
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj.\u0001);
        }
      }
      this.\u001D\u0005(this.\u0001);
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 == null)
        return;
      if (\u0018.\u0017.\u001E\u0005(string.Format(\u0019.\u001D.\u0001(47787), \u008F\u0084.\u009E\u0092(this.\u0001.ContentPackSettings.Name) ? (object) \u0019.\u001D.\u0001(28269) : (object) this.\u0001.ContentPackSettings.Name), \u0019.\u001D.\u0001(47840), \u0016.\u0006, \u0016.\u0007) != DialogResult.Yes)
        return;
      this.\u001E\u0005(this.\u0001.ContentPackSettings);
    }

    private void \u001E\u0005(\u001F.\u0081 settings)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u001D.\u000F obj1 = new \u0019.\u001D.\u000F();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = settings;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u001D.\u0010 obj2 = new \u0019.\u001D.\u0010();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new \u0014.\u001A();
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        obj2.\u0001.Shown += new EventHandler(obj2.\u001D\u0005);
        // ISSUE: reference to a compiler-generated field
        int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2.\u0001);
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj2.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj2.\u0001);
        }
      }
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005(this.\u0001[this.\u0001.IndexOf(this.\u0001.ContentPackSettings) - 1]);
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005(this.\u0001[this.\u0001.IndexOf(this.\u0001.ContentPackSettings) + 1]);
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      if (!\u0083.\u001C.CanOpenMakePackageOrDialog)
        return;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u001D.\u0011 obj = new \u0019.\u001D.\u0011();
      \u0083.\u001C.MakePackageOpen = true;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = new \u0007((Form) this);
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = new \u007F.\u001E();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      obj.\u0001.\u001D\u0005((Form) obj.\u0001, true);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      \u0096\u001C.\u007E\u008D\u008B((object) obj.\u0001, new FormClosedEventHandler(obj.\u001D\u0005));
      // ISSUE: reference to a compiler-generated field
      \u001A\u001E.\u007E\u0083\u0086((object) obj.\u0001);
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      this.\u0083\u0005();
    }

    private void \u0083\u0005()
    {
      if (!\u008F\u0084.\u0092\u009E(\u001A.\u007F.\u007F))
      {
        if (\u008F\u0084.\u0092\u009E(\u001A.\u007F.\u001F))
        {
          try
          {
            \u001C.\u001A obj = new \u001C.\u001A(\u001A.\u007F.\u001F, false, false);
            Guid id;
            try
            {
              id = obj.ID;
            }
            finally
            {
              if (obj != null)
                \u001A\u001E.\u007E\u0094\u0092((object) obj);
            }
            \u001F.\u0081 settings = \u001F.\u0081.\u001D\u0005(id);
            if (settings == null)
            {
              this.\u001D\u0005(\u001A.\u007F.\u001F);
            }
            else
            {
              \u0018.\u0017.\u001D\u0005(\u0019.\u001D.\u0001(47869), \u0019.\u001D.\u0001(47942));
              this.\u001D\u0005(settings);
            }
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005((object) \u001A.\u007F.\u001F);
            \u0018.\u0017.\u001D\u0005(ex, \u001A.\u007F.\u001F);
          }
        }
        else
          \u0018.\u0017.\u001E\u0005(\u0019.\u001D.\u0001(47979), \u0019.\u001D.\u0001(48100));
      }
      else
        this.\u001D\u0005(\u001A.\u007F.\u007F);
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001.ContentPackSettings.AutoUpdate = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001);
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u001E\u0005(object sender, LinkLabelLinkClickedEventArgs e)
    {
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u0005 obj2 = new \u0005(this.\u0001.ContentPackSettings);
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) == DialogResult.OK)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            \u0019.\u001D.\u0012 obj3 = new \u0019.\u001D.\u0012();
            // ISSUE: reference to a compiler-generated field
            obj3.\u0001 = this;
            // ISSUE: reference to a compiler-generated field
            obj3.\u0001 = new \u0014.\u001A();
            try
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              obj3.\u0001.Shown += new EventHandler(obj3.\u001D\u0005);
              // ISSUE: reference to a compiler-generated field
              int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj3.\u0001);
            }
            finally
            {
              // ISSUE: reference to a compiler-generated field
              if (obj3.\u0001 != null)
              {
                // ISSUE: reference to a compiler-generated field
                \u001A\u001E.\u007E\u0094\u0092((object) obj3.\u0001);
              }
            }
          }
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
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u0004);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }
  }
}
