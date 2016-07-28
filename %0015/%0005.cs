// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0017;
using \u001A;
using \u001B;
using \u007F;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0015
{
  internal sealed class \u0005 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0010 \u0001;
    private Label \u0001;
    private Label \u0002;
    private \u0010 \u0002;
    private Label \u0003;
    private \u0010 \u0003;
    private Label \u0004;
    private \u0010 \u0004;
    private Label \u0005;
    private \u0010 \u0005;
    private Label \u0006;
    private Label \u0007;
    private Label \u0008;
    private \u001E.\u001E \u0001;
    private Button \u0001;
    private Button \u0002;
    private Button \u0003;
    private \u001C \u0001;
    private Label \u000E;
    private Label \u000F;
    private Label \u0010;
    private Panel \u0001;
    private Panel \u0002;
    private CheckBox \u0001;
    private Label \u0011;

    static \u0005()
    {
      \u0004.\u001D\u0005(typeof (\u0005));
    }

    public \u0005()
    {
      this.\u001D\u0005();
      \u0080\u0086.\u0016\u008B((object) this, \u0013.GenericSettings_Icon);
      \u0081.\u0081 joeFishSettings = \u0081.\u0080.Instance.JoeFishSettings;
      this.\u0003.Value = joeFishSettings.CastDragDelay;
      this.\u0005.Value = joeFishSettings.AfterCastDelay;
      this.\u0002.Value = joeFishSettings.ButtonClickDelay;
      this.\u0004.Value = joeFishSettings.AfterMoveBeforeClickDelay;
      this.\u0001.Value = ((\u0005) joeFishSettings).MaxColorRange;
      this.\u0001.Value = ((\u0005) joeFishSettings).TargetRange;
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, joeFishSettings.RequireStableTarget);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0003 = new Button();
      this.\u0010 = new Label();
      this.\u0001 = new \u001C();
      this.\u000F = new Label();
      this.\u000E = new Label();
      this.\u0001 = new \u0010();
      this.\u0002 = new \u0010();
      this.\u0001 = new \u001E.\u001E();
      this.\u0003 = new \u0010();
      this.\u0005 = new Label();
      this.\u0005 = new \u0010();
      this.\u0008 = new Label();
      this.\u0004 = new \u0010();
      this.\u0006 = new Label();
      this.\u0001 = new Label();
      this.\u0007 = new Label();
      this.\u0002 = new Label();
      this.\u0004 = new Label();
      this.\u0003 = new Label();
      this.\u0001 = new Panel();
      this.\u0002 = new Panel();
      this.\u0001 = new CheckBox();
      this.\u0011 = new Label();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0002);
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0001, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(349, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(12810));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(6496));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(268, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0005.\u0001(12823));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0005.\u0001(12836));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0003, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(187, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0005.\u0001(12845));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0005.\u0001(12858));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u001F\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0010, AnchorStyles.Bottom | AnchorStyles.Left);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0010, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0010, new Font(\u0005.\u0001(4300), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0010, new Point(2, 16));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0010, \u0005.\u0001(6663));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0010, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0010, 37);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, \u0005.\u0001(6688));
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(224, 224, 224);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0011);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.ImageBounds = new Rectangle(0, 0, 0, 0);
      this.\u0001.ImageLocation = new Point(0, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(12867));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(426, 274));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 15);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000F, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000F, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000F, new Font(\u0005.\u0001(7405), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u000F, \u009A\u0080.\u0092\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(75, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u0005.\u0001(12888));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(226, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 15);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u0005.\u0001(12925));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000E, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000E, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000E, new Font(\u0005.\u0001(7405), 12f, FontStyle.Bold));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u000E, \u008E\u001D.\u0017\u007F(95, 95, 95));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(7, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0005.\u0001(12970));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(66, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u0005.\u0001(12991));
      this.\u0001.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(340, 144));
      this.\u0001.MaximumValue = (int) byte.MaxValue;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0001, 3);
      this.\u0001.MinimumValue = 0;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(13004));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(56, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      this.\u0001.Value = 0;
      this.\u0002.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(340, 92));
      this.\u0002.MaximumValue = 1000;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0002, 4);
      this.\u0002.MinimumValue = 0;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0005.\u0001(13033));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(56, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 2);
      this.\u0002.Value = 0;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(340, 170));
      this.\u0001.MaximumValue = 1.5f;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0001, 10);
      this.\u0001.MinimumValue = 0.01f;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(13066));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(56, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(13091));
      this.\u0001.Value = 0.01f;
      this.\u0003.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(340, 40));
      this.\u0003.MaximumValue = 1000;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0003, 4);
      this.\u0003.MinimumValue = 0;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0005.\u0001(13100));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(56, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 0);
      this.\u0003.Value = 0;
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0005, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(17, 69));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0005.\u0001(8219));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(220, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0005.\u0001(13129));
      this.\u0005.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(340, 66));
      this.\u0005.MaximumValue = 20000;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0005, 5);
      this.\u0005.MinimumValue = 1000;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0005.\u0001(13194));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(56, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0005.\u0001(13223));
      this.\u0005.Value = 1000;
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0008, AnchorStyles.Bottom | AnchorStyles.Left);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0008, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0008, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(43, 252));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0005.\u0001(7306));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(114, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u0005.\u0001(13232));
      this.\u0004.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(340, 118));
      this.\u0004.MaximumValue = 1000;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0004, 4);
      this.\u0004.MinimumValue = 0;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0005.\u0001(13265));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(56, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 3);
      this.\u0004.Value = 0;
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0006, AnchorStyles.Bottom | AnchorStyles.Left);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0006, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0006, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(41, 230));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0005.\u0001(7418));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(209, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0005.\u0001(13310));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(17, 147));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(4693));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(186, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(13371));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0007, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0007, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(17, 173));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0005.\u0001(7336));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(168, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u0005.\u0001(13424));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(17, 95));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0005.\u0001(4643));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(248, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0005.\u0001(13473));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0004, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(17, 121));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0005.\u0001(7383));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(320, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0005.\u0001(13546));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(17, 43));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0005.\u0001(4601));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(199, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0005.\u0001(13639));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0010);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Bottom);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 282));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0001, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(13700));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(434, 31));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 38);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0001);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0002, DockStyle.Fill);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(0, 0));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0002, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0005.\u0001(13717));
      \u0001\u001F.\u007E\u0089\u0084((object) this.\u0002, new Padding(4));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(434, 282));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 39);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0016\u001E.\u007E\u0001\u0088((object) this.\u0001, ContentAlignment.MiddleRight);
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(340, 199));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(13738));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(15, 14));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 16);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, false);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0011, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0011, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0011, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0011, new Point(17, 199));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0011, \u0005.\u0001(13783));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0011, new Size((int) sbyte.MaxValue, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0011, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, \u0005.\u0001(13824));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0002);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0001);
      \u000E\u001F.\u0010\u008B((object) this, new Size(434, 313));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0005.\u0001(13861));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0005.\u0001(13890));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0002, false);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u0081.\u0081 joeFishSettings = \u0081.\u0080.Instance.JoeFishSettings;
      joeFishSettings.CastDragDelay = this.\u0003.Value;
      joeFishSettings.AfterCastDelay = this.\u0005.Value;
      joeFishSettings.ButtonClickDelay = this.\u0002.Value;
      joeFishSettings.AfterMoveBeforeClickDelay = this.\u0004.Value;
      joeFishSettings.MaxColorRange = this.\u0001.Value;
      joeFishSettings.TargetRange = this.\u0001.Value;
      joeFishSettings.RequireStableTarget = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001);
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
      this.\u0003.Value = \u0081.\u0081.\u0002;
      this.\u0005.Value = \u0081.\u0081.\u0003;
      this.\u0002.Value = \u0005.\u0001;
      this.\u0004.Value = \u0005.\u0002;
      this.\u0001.Value = \u0081.\u0081.\u0001;
      this.\u0001.Value = \u0005.\u0001;
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, \u0081.\u0081.\u0002);
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u001D);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }
  }
}
