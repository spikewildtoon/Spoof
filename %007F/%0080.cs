// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u001A;
using \u001B;
using \u001D;
using \u007F;
using \u0080;
using \u0081;
using \u0084;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace \u007F
{
  internal sealed class \u0080 : Form
  {
    private Dictionary<\u0082, \u007F.\u0080.\u0001> \u0001 = new Dictionary<\u0082, \u007F.\u0080.\u0001>();
    private Dictionary<\u0018, \u007F.\u0080.\u0001> \u0001 = new Dictionary<\u0018, \u007F.\u0080.\u0001>();
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0010 \u0001;
    private \u001C \u0001;
    private Label \u0001;
    private Label \u0002;
    private \u0002 \u0001;
    private Label \u0003;
    private Label \u0004;
    private Label \u0005;
    private Label \u0006;
    private Label \u0007;
    private Label \u0008;
    private Label \u000E;
    private Label \u000F;
    private System.Timers.Timer \u0001;
    private FlowLayoutPanel \u0001;
    private FlowLayoutPanel \u0002;
    private \u001D.\u0080 \u0001;
    private static readonly TimeSpan \u0001;
    private TimeSpan? \u0001;
    private TimeSpan? \u0002;
    private Control \u0001;

    static \u0080()
    {
      \u0004.\u001D\u0005(typeof (\u007F.\u0080));
      \u007F.\u0080.\u0001 = new TimeSpan(0, 0, 1);
    }

    public \u0080()
    {
      this.\u001D\u0005();
      this.\u001D\u0005((\u0082) null, new \u001E?());
      // ISSUE: method pointer
      \u0018.WindowDistrictChanged += new EventHandler<\u007F.\u001D>((object) this, __methodptr(\u001D\u0005));
      // ISSUE: method pointer
      \u0018.WindowInvasionStateChanged += new EventHandler<\u0019>((object) this, __methodptr(\u001D\u0005));
      this.\u001E\u0005();
      this.\u0001 = new Control();
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, this.\u0001.ImageBounds.Location);
      this.\u0001.LocationChanged += (EventHandler) ((sender, e) => this.\u0001.ImageLocation = \u008E\u0084.\u007E\u009E\u0083((object) this.\u0001));
      this.\u0001.ControlToSlide = this.\u0001;
    }

    protected override void Dispose(bool disposing)
    {
      // ISSUE: method pointer
      \u0018.WindowDistrictChanged -= new EventHandler<\u007F.\u001D>((object) this, __methodptr(\u001D\u0005));
      // ISSUE: method pointer
      \u0018.WindowInvasionStateChanged -= new EventHandler<\u0019>((object) this, __methodptr(\u001D\u0005));
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u007F.\u0080)));
      this.\u0001 = new System.Timers.Timer();
      this.\u0001 = new \u001C();
      this.\u0001 = new FlowLayoutPanel();
      this.\u0004 = new Label();
      this.\u000F = new Label();
      this.\u0005 = new Label();
      this.\u000E = new Label();
      this.\u0002 = new FlowLayoutPanel();
      this.\u0003 = new Label();
      this.\u0007 = new Label();
      this.\u0006 = new Label();
      this.\u0008 = new Label();
      this.\u0001 = new \u0002();
      this.\u0002 = new Label();
      this.\u0001 = new Label();
      this.\u0001 = new \u0010();
      this.\u0001 = new \u001D.\u0080(this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0002);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, true);
      \u0002\u001D.\u007E\u0096\u0003\u0002((object) this.\u0001, 1000.0);
      \u0019\u0081.\u007E\u0098\u0003\u0002((object) this.\u0001, (ISynchronizeInvoke) this);
      \u0010\u0081.\u007E\u0097\u0003\u0002((object) this.\u0001, new ElapsedEventHandler(this.\u001D\u0005));
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(224, 224, 224);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.Image = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u0080.\u0001(80356));
      this.\u0001.ImageBounds = new Rectangle(400, 34, 86, 70);
      this.\u0001.ImageLocation = new Point(400, 34);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u0080.\u0001(80381));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(396, 106));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u009D\u001C.\u007E\u009B\u008A((object) this.\u0001, AutoSizeMode.GrowAndShrink);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000E);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(72, 79));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u0080.\u0001(80398));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(246, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 24);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0004, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(3, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u007F.\u0080.\u0001(11381));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(74, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u007F.\u0080.\u0001(80423));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000F, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000F, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000F, new Font(\u007F.\u0080.\u0001(8298), 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u000F, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(83, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u007F.\u0080.\u0001(80444));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(44, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u007F.\u0080.\u0001(80465));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0005, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(133, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u007F.\u0080.\u0001(8641));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(60, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u007F.\u0080.\u0001(80474));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000E, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000E, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000E, new Font(\u007F.\u0080.\u0001(8298), 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u000E, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(199, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u007F.\u0080.\u0001(80491));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(44, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u007F.\u0080.\u0001(80465));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u009D\u001C.\u007E\u009B\u008A((object) this.\u0002, AutoSizeMode.GrowAndShrink);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0008);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(72, 45));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u007F.\u0080.\u0001(80516));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(199, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 23);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(3, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u007F.\u0080.\u0001(8691));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(29, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u007F.\u0080.\u0001(80541));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0003, ContentAlignment.MiddleLeft);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0007, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0007, new Font(\u007F.\u0080.\u0001(8298), 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0007, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(38, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u007F.\u0080.\u0001(80550));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(45, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u007F.\u0080.\u0001(30869));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0006, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(89, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u007F.\u0080.\u0001(12217));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(56, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u007F.\u0080.\u0001(80559));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0006, ContentAlignment.MiddleLeft);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0008, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0008, new Font(\u007F.\u0080.\u0001(8298), 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0008, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(151, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u007F.\u0080.\u0001(80572));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(45, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u007F.\u0080.\u0001(30869));
      \u0019\u001D.\u007E\u009B\u0088((object) this.\u0001, ComboBoxStyle.DropDownList);
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(158, 7));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u0080.\u0001(80589));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size((int) sbyte.MaxValue, 21));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 20);
      \u0087\u007F.\u007E\u009C\u0088((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u007F.\u0080.\u0001(11403), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0092\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(85, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u007F.\u0080.\u0001(80606));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(67, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 11);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u007F.\u0080.\u0001(80623));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u007F.\u0080.\u0001(11403), 12f, FontStyle.Bold));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(95, 95, 95));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(7, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u0080.\u0001(8599));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(72, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u007F.\u0080.\u0001(63898));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      this.\u0001.BaseColor = \u008E\u001D.\u0017\u007F(64, 64, 64);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(16, 45));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u0080.\u0001(80640));
      this.\u0001.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(50, 50));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u007F.\u0080.\u0001(19804));
      this.\u0001.ContractDistance = 6;
      this.\u0001.ContractedDelay = 2000;
      this.\u0001.ContractRate = 30;
      this.\u0001.ControlToSlide = (Control) null;
      this.\u0001.Enabled = false;
      this.\u0001.EndPosition = 330;
      this.\u0001.ExpandDistance = 2;
      this.\u0001.ExpandedDelay = 6000;
      this.\u0001.ExpandRate = 10;
      this.\u0001.RunOnce = true;
      this.\u0001.SlideDirection = \u007F.\u0081.\u0001;
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u000E\u001F.\u0010\u008B((object) this, new Size(404, 114));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u0080.\u0001(9420)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u007F.\u0080.\u0001(63898));
      \u0001\u001F.\u0089\u0084((object) this, new Padding(4));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u007F.\u0080.\u0001(80657));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0002, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0002);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001E\u0005()
    {
      \u001A\u001E.\u007E\u0005\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001));
      this.\u0001.Clear();
      this.\u0001.Clear();
      ReadOnlyCollection<\u0018> openToonTownWindows = \u0018.OpenToonTownWindows;
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) openToonTownWindows), ref flag);
        IEnumerator<\u0018> enumerator = openToonTownWindows.GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            \u0018 current = enumerator.Current;
            if (current.District != null)
            {
              \u007F.\u0080.\u0001 obj2;
              if (!this.\u0001.ContainsKey(current.District))
                this.\u0001.Add(current.District, obj2 = new \u007F.\u0080.\u0001(current.District));
              else
                obj2 = this.\u0001[current.District];
              obj2.Windows.Add(current);
              this.\u0001.Add(current, obj2);
            }
          }
        }
        finally
        {
          if (enumerator != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
      object[] objArray = (object[]) this.\u0001.Values.OrderBy<\u007F.\u0080.\u0001, string>((Func<\u007F.\u0080.\u0001, string>) (item => item.District.\u0001)).ToArray<\u007F.\u0080.\u0001>();
      \u0003\u0083.\u007E\u0004\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), objArray);
      if (objArray.Length > 0)
        \u008E\u007F.\u007E\u0099\u0088((object) this.\u0001, objArray[0]);
      else
        \u008E\u007F.\u007E\u0099\u0088((object) this.\u0001, (object) null);
    }

    private void \u001D\u0005(object sender, \u007F.\u001D e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.\u001D\u0005(new MethodInvoker(new \u007F.\u0080.\u0002()
      {
        \u0001 = sender,
        \u0001 = e,
        \u0001 = this
      }.\u001D\u0005));
    }

    private void \u001D\u0005(object sender, \u0019 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.\u001D\u0005(new MethodInvoker(new \u007F.\u0080.\u0003()
      {
        \u0001 = sender,
        \u0001 = e,
        \u0001 = this
      }.\u001D\u0005));
    }

    private void \u001D\u0005(\u0082 district, \u001E? state)
    {
      this.\u0001 = new TimeSpan?();
      this.\u0002 = new TimeSpan?();
      if (!state.HasValue || district == null)
      {
        \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
        this.\u0001.On = false;
        this.\u001D\u0005(\u0084.\u0016.\u0001);
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u007F.\u0080.\u0001(30869));
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u007F.\u0080.\u0001(30869));
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u007F.\u0080.\u0001(80465));
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u007F.\u0080.\u0001(80465));
      }
      else
        goto label_6;
label_5:
      this.\u001F\u0005();
      return;
label_6:
      this.\u0002 = new TimeSpan?(\u001B\u0082.\u001F\u0094(\u001D\u0082.\u0011\u0094(), state.Value.\u0001));
      this.\u0001.On = true;
      \u001E obj = state.Value;
      this.\u001D\u0005(obj.\u0001.\u0001);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, obj.\u0001.\u0001);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, obj.\u0001.\u0001.\u001D\u0005());
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u007F.\u0080.\u001D\u0005(this.\u0002.Value));
      if (this.\u0001.HasValue)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u007F.\u0080.\u001D\u0005(this.\u0001.Value));
      else
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u007F.\u0080.\u0001(30696));
      \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, true);
      goto label_5;
    }

    private void \u001D\u0005(\u0084.\u0016 type)
    {
      switch (type)
      {
        case \u0084.\u0016.\u0002:
          this.\u0001.BaseColor = \u008E\u001D.\u0017\u007F((int) byte.MaxValue, 0, 0);
          break;
        case \u0084.\u0016.\u0003:
          this.\u0001.BaseColor = \u008E\u001D.\u0017\u007F(153, (int) byte.MaxValue, 54);
          break;
        case \u0084.\u0016.\u0004:
          this.\u0001.BaseColor = \u008E\u001D.\u0017\u007F(200, 100, 0);
          break;
        case \u0084.\u0016.\u0005:
          this.\u0001.BaseColor = \u008E\u001D.\u0017\u007F(14, 0, 200);
          break;
        default:
          this.\u0001.BaseColor = \u008E\u001D.\u0017\u007F(64, 64, 64);
          break;
      }
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) this, __methodptr(\u007F\u0005)));
    }

    private static string \u001D\u0005(TimeSpan ts)
    {
      if (ts.Days > 0)
        return \u0081\u0086.\u0086\u0093(ts.ToString(\u007F.\u0080.\u0001(80702)), \u007F.\u0080.\u0001(80707));
      if (ts.Hours > 0)
        return ts.ToString(\u007F.\u0080.\u0001(80716));
      return ts.ToString(\u007F.\u0080.\u0001(80733));
    }

    private void \u001D\u0005(DateTime startTime)
    {
      if (!\u0017\u0084.\u0080\u0094(startTime, \u009E\u0086.\u001E\u0094(\u001D\u0082.\u0011\u0094(), this.\u0002.Value)))
        return;
      this.\u0002 = new TimeSpan?(\u001B\u0082.\u001F\u0094(\u001D\u0082.\u0011\u0094(), startTime));
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u007F.\u0080.\u001D\u0005(this.\u0002.Value));
    }

    private void \u001D\u0005(DateTime startTime, uint estimatedDuration)
    {
      DateTime dateTime1 = \u009E\u0086.\u001D\u0094(startTime, new TimeSpan(0, 0, (int) estimatedDuration));
      DateTime dateTime2 = \u001D\u0082.\u0011\u0094();
      this.\u0001 = !\u0017\u0084.\u0081\u0094(dateTime2, dateTime1) ? new TimeSpan?(\u001B\u0082.\u001F\u0094(dateTime1, dateTime2)) : new TimeSpan?(TimeSpan.Zero);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u007F.\u0080.\u001D\u0005(this.\u0001.Value));
    }

    private void \u001F\u0005()
    {
      if (!this.\u0001.HasValue)
        \u0081\u0082.\u007E\u0095\u0083((object) this.\u000E, \u009A\u0080.\u0095\u001F());
      else if (this.\u0001.Value.TotalSeconds < 60.0)
        \u0081\u0082.\u007E\u0095\u0083((object) this.\u000E, \u009A\u0080.\u0005\u007F());
      else if (this.\u0001.Value.TotalSeconds < 120.0)
        \u0081\u0082.\u007E\u0095\u0083((object) this.\u000E, \u008E\u001D.\u0017\u007F((int) byte.MaxValue, 153, 0));
      else
        \u0081\u0082.\u007E\u0095\u0083((object) this.\u000E, \u009A\u0080.\u0095\u001F());
    }

    private void \u001D\u0005(\u0082 district, string cogID, uint cogsRemaining, bool skelecog, DateTime startTime)
    {
      if (district == null)
        throw new ArgumentNullException(\u007F.\u0080.\u0001(80746));
      if (\u008F\u0084.\u009E\u0092(cogID))
        throw new ArgumentNullException(\u007F.\u0080.\u0001(80759));
      if (!\u0006.Cogs.ContainsKey(cogID))
        throw new ArgumentException(\u0081\u0086.\u0086\u0093(\u007F.\u0080.\u0001(80768), cogID));
      this.\u0001 = new TimeSpan?();
      uint? estimatedDuration;
      \u0011.\u001D\u0005(district, \u0006.Cogs[cogID], cogsRemaining, skelecog, startTime, out estimatedDuration, out startTime);
      startTime = startTime.ToLocalTime();
      if (estimatedDuration.HasValue)
        this.\u001D\u0005(startTime, estimatedDuration.Value);
      else
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u007F.\u0080.\u0001(30696));
      this.\u001D\u0005(startTime);
      this.\u001F\u0005();
    }

    private void \u001D\u0005(\u0082 district)
    {
      \u0011.\u001E\u0005(district);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (\u0005\u007F.\u007E\u0098\u0088((object) this.\u0001) != null)
      {
        \u0018 obj1 = \u007F.\u0080.\u001D\u0005((ICollection<\u0018>) (\u0005\u007F.\u007E\u0098\u0088((object) this.\u0001) as \u007F.\u0080.\u0001).Windows);
        if (obj1 == null)
        {
          this.\u001D\u0005((\u0082) null, new \u001E?());
        }
        else
        {
          this.\u001D\u0005(obj1.District, obj1.Invasion);
          \u001E obj2 = obj1.Invasion.Value;
          this.\u001D\u0005(obj1.District, obj2.\u0001.\u0002, obj2.\u0001, obj2.\u0001, obj2.\u0001);
        }
      }
      else
        this.\u001D\u0005((\u0082) null, new \u001E?());
    }

    private static \u0018 \u001D\u0005(ICollection<\u0018> windows)
    {
      uint num = 0;
      \u0018 obj = (\u0018) null;
      IEnumerator<\u0018> enumerator = windows.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          \u0018 current = enumerator.Current;
          if (current.Invasion.HasValue && num < current.Invasion.Value.\u0001)
          {
            num = current.Invasion.Value.\u0001;
            obj = current;
          }
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      return obj;
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0082.\u001D\u0005(\u0002.\u0007);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    private sealed class \u0001
    {
      [NonSerialized]
      internal static \u0002 \u0001;

      public List<\u0018> Windows { get; private set; }

      public \u0082 District { get; private set; }

      static \u0001()
      {
        \u0004.\u001D\u0005(typeof (\u007F.\u0080.\u0001));
      }

      public \u0001(\u0082 district)
      {
        if (district == null)
          throw new ArgumentNullException(\u007F.\u0080.\u0001.\u0001(80772));
        this.Windows = new List<\u0018>();
        this.District = district;
      }

      public override string ToString()
      {
        return \u0081\u0086.\u0086\u0093(this.District.\u0001, this.\u001D\u0005());
      }

      private string \u001D\u0005()
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) this.Windows), ref flag);
          if (this.Windows.Count == 0)
            return string.Empty;
          string str = \u007F.\u0080.\u0001.\u0001(80831);
          for (int index = 0; index < this.Windows.Count; ++index)
          {
            if (index > 0)
              str = \u0081\u0086.\u0086\u0093(str, \u007F.\u0080.\u0001.\u0001(30806));
            str = \u0081\u0086.\u0086\u0093(str, this.Windows[index].Username);
          }
          return \u0081\u0086.\u0086\u0093(str, \u007F.\u0080.\u0001.\u0001(32543));
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
    }
  }
}
