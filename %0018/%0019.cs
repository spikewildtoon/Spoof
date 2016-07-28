// Decompiled with JetBrains decompiler
// Type: .
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
using \u0083;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u0019 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u001D.\u001E \u0001;
    private TextBox \u0001;
    private TextBox \u0002;
    private Label \u0001;
    private Label \u0002;
    private Label \u0003;
    private Button \u0001;
    private RadioButton \u0001;
    private RadioButton \u0002;
    private Label \u0004;
    private TabControl \u0001;
    private TabPage \u0001;
    private TabPage \u0002;
    private Button \u0002;
    private \u001C \u0001;
    private \u0014.\u001F \u0001;
    private \u001D.\u0080 \u0001;
    private Label \u0005;
    private WebBrowser \u0001;
    private WebBrowser \u0002;
    private \u001D.\u001E \u0002;
    private ContextMenuStrip \u0001;
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
    private \u001D.\u0001 \u0001;
    private bool \u0001;

    static \u0019()
    {
      \u0004.\u001D\u0005(typeof (\u0019));
      \u0019.\u0001 = \u0019.\u0001(36779);
      \u0019.\u0002 = \u0019.\u0001(36836);
      \u0019.\u0003 = \u0019.\u0001(36873);
      \u0019.\u0004 = \u0019.\u0001(37079);
      \u0019.\u0005 = \u0019.\u0001(37116);
      \u0019.\u0006 = \u0019.\u0001(37542);
      \u0019.\u0007 = \u0019.\u0001(37591);
      \u0019.\u0008 = \u0019.\u0001(37608);
      \u0019.\u000E = \u0019.\u0001(37746);
      \u0019.\u000F = \u0019.\u0001(37767);
      \u0019.\u0010 = \u0019.\u0001(37816);
      \u0019.\u0011 = \u0019.\u0001(37849);
      \u0019.\u0012 = \u0019.\u0001(38047);
      \u0019.\u0013 = \u0019.\u0001(38076);
      \u0019.\u0014 = \u0019.\u0001(38254);
      \u0019.\u0015 = \u0019.\u0001(38287);
      \u0019.\u0016 = \u0019.\u0001(38304);
      \u0019.\u0017 = \u0019.\u0001(38450);
      \u0019.\u0018 = \u0019.\u0001(38475);
      \u0019.\u0019 = \u0019.\u0001(38596);
      \u0019.\u001A = \u0019.\u0001(38621);
      \u0019.\u001B = \u0019.\u0001(38642);
      \u0019.\u001C = \u0019.\u0001(38711);
    }

    public \u0019()
    {
      this.\u001D\u0005();
      this.\u0001 = \u0081.\u0080.Instance.ConnectSettings;
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0002, this.\u0001.ToonTownAccounts.Count > 0);
      switch (this.\u0001.SelectedServer)
      {
        case \u0080.\u0001.\u0002:
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, true);
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, false);
          break;
        case \u0080.\u0001.\u0003:
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, true);
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, false);
          break;
      }
      this.\u001E\u0005();
      \u008E\u0083.\u007E\u0005\u0091((object) this.\u0002, new Uri(\u0010.\u0007));
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0002, new EventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0001, new EventHandler(this.\u001D\u0005));
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0019)));
      this.\u0001 = new ContextMenuStrip(this.\u0001);
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0001 = new \u001C();
      this.\u0002 = new \u001D.\u001E();
      this.\u0005 = new Label();
      this.\u0003 = new Label();
      this.\u0001 = new Label();
      this.\u0001 = new TabControl();
      this.\u0001 = new TabPage();
      this.\u0001 = new WebBrowser();
      this.\u0002 = new TabPage();
      this.\u0002 = new WebBrowser();
      this.\u0001 = new \u001D.\u001E();
      this.\u0002 = new RadioButton();
      this.\u0001 = new TextBox();
      this.\u0002 = new TextBox();
      this.\u0001 = new RadioButton();
      this.\u0002 = new Label();
      this.\u0004 = new Label();
      this.\u0001 = new \u0014.\u001F();
      this.\u0001 = new \u001D.\u0080(this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0002);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(35882));
      \u0099\u001F.\u007E\u0011\u0087((object) this.\u0001, false);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(61, 4));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0019.\u0001(5514), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(301, 99));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(35911));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u0001(35932));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Right);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0002, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(382, 99));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u0001(35945));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u0001(35962));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u007F\u0005));
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(224, 224, 224);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.ImageBounds = new Rectangle(0, 0, 0, 0);
      this.\u0001.ImageLocation = new Point(0, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(3, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(8383));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(511, 342));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 8);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Right);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0002, \u009B\u0086.\u0008\u008A());
      this.\u0002.ImageEnter = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0019.\u0001(35971));
      this.\u0002.ImageNormal = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0019.\u0001(36012));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(475, 73));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u0001(36057));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(22, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 25);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0002, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u0081\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0005, AnchorStyles.Top | AnchorStyles.Right);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u0019.\u0001(5514), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0005, \u009A\u0080.\u0092\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(390, 132));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0019.\u0001(7877));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 24);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0019.\u0001(7902));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0019.\u0001(8619), 12f, FontStyle.Bold));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u008E\u001D.\u0017\u007F(95, 95, 95));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(10, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0019.\u0001(36086));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(253, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0019.\u0001(36111));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0019.\u0001(7093), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(27, 44));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(36156));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(144, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u0001(8559));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(10, 128));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(36185));
      \u0011\u001F.\u007E\u0084\u008F((object) this.\u0001, 0);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(490, 206));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 6);
      \u0087\u007F.\u007E\u0087\u008F((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0096\u0086.\u007E\u0099\u008F((object) this.\u0001, new Point(4, 22));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(36206));
      \u0001\u001F.\u007E\u0089\u0084((object) this.\u0001, new Padding(3));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(482, 180));
      \u0011\u001F.\u007E\u009A\u008F((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u0001(36219));
      \u0099\u001F.\u007E\u0098\u008F((object) this.\u0001, true);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(3, 3));
      \u000E\u001F.\u007E\u0007\u0084((object) this.\u0001, new Size(20, 20));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(36240));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(476, 174));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0002);
      \u0096\u0086.\u007E\u0099\u008F((object) this.\u0002, new Point(4, 22));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u0001(36269));
      \u0001\u001F.\u007E\u0089\u0084((object) this.\u0002, new Padding(3));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(482, 180));
      \u0011\u001F.\u007E\u009A\u008F((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u0001(36286));
      \u0099\u001F.\u007E\u0098\u008F((object) this.\u0002, true);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0002, DockStyle.Fill);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(3, 3));
      \u000E\u001F.\u007E\u0007\u0084((object) this.\u0002, new Size(20, 20));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u0001(36323));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(476, 174));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 0);
      \u0094\u001C.\u007E\u0006\u0091((object) this.\u0002, new WebBrowserDocumentCompletedEventHandler(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0001, \u009B\u0086.\u0008\u008A());
      this.\u0001.ImageEnter = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0019.\u0001(36364));
      this.\u0001.ImageNormal = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0019.\u0001(36409));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(461, 44));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(36454));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(20, 43));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0019.\u0001(7093), 8.25f));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(188, 102));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u0001(36483));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(49, 18));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u0001(8344));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, false);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0019.\u0001(7093), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(177, 41));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(8051));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(280, 22));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0019.\u0001(7093), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(177, 69));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u0001(8068));
      \u0090\u001E.\u007E\u0087\u008A((object) this.\u0002, '*');
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(280, 22));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0019.\u0001(7093), 8.25f));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(129, 102));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(36512));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(55, 18));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u0001(8374));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, false);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0019.\u0001(7093), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(100, 71));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u0001(36541));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(71, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u0001(8606));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0019.\u0001(7093), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0004, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(73, 104));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0019.\u0001(36570));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(50, 14));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0019.\u0001(8584));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      this.\u0001.BlinkSpeed = 200;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(19, 76));
      this.\u0001.MaximumBlinkDelay = 5000;
      this.\u0001.MinimumBlinkDelay = 1000;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001(36599));
      this.\u0001.OffImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0019.\u0001(36616));
      this.\u0001.OnImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0019.\u0001(36645));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(41, 60));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0082\u0005));
      this.\u0001.ContractDistance = 2;
      this.\u0001.ContractedDelay = 500;
      this.\u0001.ContractRate = 10;
      this.\u0001.ControlToSlide = (Control) this.\u0001;
      this.\u0001.Enabled = false;
      this.\u0001.EndPosition = 150;
      this.\u0001.ExpandDistance = 6;
      this.\u0001.ExpandedDelay = 5000;
      this.\u0001.ExpandRate = 30;
      this.\u0001.RunOnce = true;
      this.\u0001.SlideDirection = \u007F.\u0081.\u0004;
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u0001\u001D.\u007E\u001F\u0083((object) this, ImageLayout.Center);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0002);
      \u000E\u001F.\u0010\u008B((object) this, new Size(517, 348));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0099\u001F.\u007E\u008D\u0083((object) this, true);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0019.\u0001(6636)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0019.\u0001(36674));
      \u0001\u001F.\u0089\u0084((object) this, new Padding(3));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0019.\u0001(36687));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0002, false);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001.SelectedServer = !\u0099\u0082.\u007E\u0090\u008E((object) this.\u0001) ? \u0080.\u0001.\u0003 : \u0080.\u0001.\u0002;
      if (this.\u0001.NewsType != \u0080.\u001A.\u0001)
        return;
      this.\u001E\u0005();
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    private void \u001E\u0005()
    {
      switch (this.\u0001.NewsType)
      {
        case \u0080.\u001A.\u0001:
          if (\u009B\u007F.\u007E\u0086\u008F((object) this.\u0001) != this.\u0001)
            \u0099\u001D.\u007E\u0088\u008F((object) this.\u0001, this.\u0001);
          if (\u0099\u0082.\u007E\u0090\u008E((object) this.\u0001))
          {
            \u008E\u0083.\u007E\u0005\u0091((object) this.\u0001, new Uri(\u0010.\u0005));
            break;
          }
          \u008E\u0083.\u007E\u0005\u0091((object) this.\u0001, new Uri(\u0010.\u0006));
          break;
        case \u0080.\u001A.\u0002:
          if (\u009B\u007F.\u007E\u0086\u008F((object) this.\u0001) != this.\u0002)
            \u0099\u001D.\u007E\u0088\u008F((object) this.\u0001, this.\u0002);
          \u008E\u0083.\u007E\u0005\u0091((object) this.\u0001, new Uri(\u0010.\u0008));
          break;
      }
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (\u009B\u007F.\u007E\u0086\u008F((object) this.\u0001) != this.\u0001)
      {
        if (\u009B\u007F.\u007E\u0086\u008F((object) this.\u0001) != this.\u0002 || this.\u0001.NewsType == \u0080.\u001A.\u0002)
          return;
        this.\u0001.NewsType = \u0080.\u001A.\u0002;
        this.\u001E\u0005();
      }
      else
      {
        if (this.\u0001.NewsType == \u0080.\u001A.\u0001)
          return;
        this.\u0001.NewsType = \u0080.\u001A.\u0001;
        this.\u001E\u0005();
      }
    }

    private void \u001F\u0005()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u0001 obj1 = new \u0019.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      if (!\u001C.CanLoginToToonTownOrDialog)
        return;
      \u001C.InstallingOrLoggingIn = true;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = \u0002\u007F.\u007E\u001C\u0084((object) this.\u0001);
      string password = \u0002\u007F.\u007E\u001C\u0084((object) this.\u0002);
      // ISSUE: reference to a compiler-generated field
      if (\u008F\u0084.\u009E\u0092(obj1.\u0001) || \u008F\u0084.\u009E\u0092(password))
      {
        \u0017.\u001D\u0005(\u0019.\u0001, \u0019.\u0002);
        \u001C.InstallingOrLoggingIn = false;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = \u0099\u0082.\u007E\u0090\u008E((object) this.\u0002) ? \u0080.\u0001.\u0003 : (\u0099\u0082.\u007E\u0090\u008E((object) this.\u0001) ? \u0080.\u0001.\u0002 : \u0080.\u0001.\u0002);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (\u0080.\u0018.\u001D\u0005(obj1.\u0001, obj1.\u0001))
        {
          if (\u0017.\u001E\u0005(\u0019.\u0003, \u0019.\u0004, \u0016.\u0006, \u0016.\u0007) != DialogResult.Yes)
          {
            \u001C.InstallingOrLoggingIn = false;
            return;
          }
        }
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0019.\u0002 obj2 = new \u0019.\u0002();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = new \u0016(obj1.\u0001, obj1.\u0001, password);
        try
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          \u0019.\u0003 obj3 = new \u0019.\u0003();
          // ISSUE: reference to a compiler-generated field
          obj3.\u0001 = obj2;
          // ISSUE: reference to a compiler-generated field
          obj3.\u0001 = obj1;
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
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u001F\u0005();
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      \u0002 obj = new \u0002();
      try
      {
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj) == DialogResult.OK)
          this.\u001D\u0005(obj.SelectedAccount);
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0002, this.\u0001.ToonTownAccounts.Count > 0);
    }

    private void \u001D\u0005(\u0003 act)
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, act.Username);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, act.Password);
      if (act.ToonTownAccountType == \u0080.\u0001.\u0002)
        \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, true);
      else
        \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, true);
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0019.\u0004 obj1 = new \u0019.\u0004();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      \u001A\u001E.\u007E\u008E\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001));
      List<\u0003> toonTownAccounts = this.\u0001.ToonTownAccounts;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = new \u0008[toonTownAccounts.Count];
      for (int index = 0; index < toonTownAccounts.Count; ++index)
      {
        \u0003 settings = toonTownAccounts[index];
        // ISSUE: reference to a compiler-generated field
        \u0008 obj2 = obj1.\u0001[index] = new \u0008(settings);
        \u0092\u0081.\u007E\u007F\u0087((object) obj2, settings.ReferenceName);
      }
      // ISSUE: reference to a compiler-generated field
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), (ToolStripItem[]) obj1.\u0001);
      // ISSUE: reference to a compiler-generated method
      \u0084\u001D.\u007E\u000F\u0087((object) this.\u0001, new ToolStripItemClickedEventHandler(obj1.\u001D\u0005));
      // ISSUE: reference to a compiler-generated method
      \u0015\u001F.\u007E\u0018\u0089((object) this.\u0001, new ToolStripDropDownClosedEventHandler(obj1.\u001D\u0005));
      \u008A\u001D.\u007E\u0089\u0089((object) this.\u0001, (Control) this.\u0002, \u0098\u001B.\u007E\u001A\u0086((object) this.\u0002, \u0098\u0080.\u000F\u0084()));
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      if (this.\u0001.Enabled)
        return;
      this.\u0001.Enabled = true;
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u001F);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    private void \u001D\u0005(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      HtmlDocument htmlDocument = \u001B\u0081.\u007E\u0004\u0091((object) this.\u0002);
      if (!\u0003\u001D.\u0011\u008C(htmlDocument, (HtmlDocument) null))
        return;
      HtmlElement htmlElement1 = \u0091\u0082.\u007E\u0010\u008C((object) htmlDocument, \u0019.\u0001(36728));
      if (\u009A\u0083.\u0012\u008C(htmlElement1, (HtmlElement) null))
        this.\u001D\u0005((MethodInvoker) (() =>
        {
          if (\u009B\u007F.\u007E\u0086\u008F((object) this.\u0001) == this.\u0002)
            return;
          \u0099\u001D.\u007E\u0088\u008F((object) this.\u0001, this.\u0002);
        }));
      HtmlElement htmlElement2 = \u0091\u0082.\u007E\u0010\u008C((object) htmlDocument, \u0019.\u0001(36745));
      if (\u009A\u0083.\u0012\u008C(htmlElement2, (HtmlElement) null))
        this.\u001D\u0005((MethodInvoker) (() => this.\u0001 = true));
      HtmlElement htmlElement3 = \u0091\u0082.\u007E\u0010\u008C((object) htmlDocument, \u0019.\u0001(36762));
      if (!\u009A\u0083.\u0012\u008C(htmlElement3, (HtmlElement) null))
        return;
      this.\u001D\u0005((MethodInvoker) (() =>
      {
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
        \u001A\u001E.\u007E\u0081\u0089((object) this.\u0001);
      }));
    }
  }
}
