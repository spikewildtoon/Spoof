// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0018;
using \u001B;
using \u001C;
using \u001D;
using \u001E;
using \u001F;
using \u0083;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001D
{
  internal sealed class \u0005 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0082.\u001D \u0001;
    private CheckBox \u0001;
    private CheckBox \u0002;
    private CheckBox \u0003;
    private CheckBox \u0004;
    private Label \u0001;
    private Label \u0002;
    private CheckBox \u0005;
    private CheckBox \u0006;
    private CheckBox \u0007;
    private LinkLabel \u0001;
    private LinkLabel \u0002;
    private \u000E \u0001;
    private \u0003 \u0001;
    private \u0004 \u0001;

    [Browsable(false)]
    public \u000E FloraEstatePlantingDetails
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (this.\u0001 == value)
          return;
        this.\u0001 = value;
        this.\u0001.EstateHome = this.\u0001.HouseColor;
        switch (this.\u0001.HouseColor)
        {
          case \u007F.\u0001:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(44030));
            break;
          case \u007F.\u0002:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(44064));
            break;
          case \u007F.\u0003:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(44102));
            break;
          case \u007F.\u0004:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(44140));
            break;
          case \u007F.\u0005:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(44178));
            break;
          case \u007F.\u0006:
            \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(44216));
            break;
        }
        this.\u001F\u0005();
      }
    }

    public event EventHandler OnModified;

    static \u0005()
    {
      \u0004.\u001D\u0005(typeof (\u0005));
    }

    public \u0005()
    {
      this.\u001D\u0005();
      this.\u0001 = new \u0004();
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(94, 25));
      // ISSUE: method pointer
      this.\u0001.ClosePopup += new EventHandler((object) this, __methodptr(\u001D\u0005));
      this.\u0001.ValueChanged += new EventHandler(this.\u0082\u0005);
      this.\u0001 = new \u0003((Control) this.\u0001);
      this.FloraEstatePlantingDetails = new \u000E(\u007F.\u0004);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        goto label_5;
label_4:
      \u0099\u001F.\u009A\u0086((object) this, disposing);
      return;
label_5:
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
        goto label_4;
      }
      else
        goto label_4;
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new CheckBox();
      this.\u0002 = new CheckBox();
      this.\u0003 = new CheckBox();
      this.\u0004 = new CheckBox();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0005 = new CheckBox();
      this.\u0006 = new CheckBox();
      this.\u0007 = new CheckBox();
      this.\u0001 = new LinkLabel();
      this.\u0002 = new LinkLabel();
      this.\u0001 = new \u0082.\u001D();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0005.\u0001(9945), 15.75f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(65, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(61666));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(126, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(44140));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0005.\u0001(6840), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(122, 48));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0005.\u0001(61695));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(42, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0002, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0005.\u0001(61712));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0002, new EventHandler(this.\u0086\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0005.\u0001(6840), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(186, 48));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0005.\u0001(61721));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(45, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 4);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0003, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0005.\u0001(61738));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0003, new EventHandler(this.\u0087\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0005.\u0001(6840), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(253, 48));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0005.\u0001(61747));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(15, 14));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 5);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0004, false);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0004, new EventHandler(this.\u0088\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0005.\u0001(6840), 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(68, 49));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(7233));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(48, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(61764));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0005.\u0001(6840), 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(75, 33));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0005.\u0001(7183));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(41, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0005.\u0001(61777));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u0005.\u0001(6840), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(122, 32));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0005.\u0001(61790));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(58, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0005, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0005.\u0001(34615));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0005, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0005, new EventHandler(this.\u0083\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0006, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0006, new Font(\u0005.\u0001(6840), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(186, 32));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0005.\u0001(61811));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(47, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 2);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0006, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0005.\u0001(34729));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0006, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0006, new EventHandler(this.\u0084\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0007, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0007, new Font(\u0005.\u0001(6840), 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(299, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0005.\u0001(61828));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(15, 14));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 7);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0007, false);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0007, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0007, new EventHandler(this.\u0081\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0005.\u0001(6840), 6.75f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(258, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(61853));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(38, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 6);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(54982));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0001, new LinkLabelLinkClickedEventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0005.\u0001(6840), 6.75f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(269, 48));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0002, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0005.\u0001(61874));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(30, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 8);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0002, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0005.\u0001(59221));
      \u0093\u0086.\u007E\u0081\u008C((object) this.\u0002, new LinkLabelLinkClickedEventHandler(this.\u001D\u0005));
      this.\u0001.EstateHome = \u007F.\u0004;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(3, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(61887));
      this.\u0001.Size = new Size(56, 64);
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(34434));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u009A\u0080.\u0016\u0081());
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0005.\u0001(61920));
      \u000E\u001F.\u0018\u0084((object) this, new Size(317, 70));
      \u0087\u007F.\u0086\u0084((object) this, new EventHandler(this.\u0080\u0005));
      \u0087\u007F.\u0093\u0084((object) this, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u0094\u0084((object) this, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u007E\u0081\u0089((object) this.\u0001);
    }

    private void \u001D\u0005(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.\u0001.\u001E\u0005((Control) this.\u0002);
    }

    private void \u001E\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u001F\u0005()
    {
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0003, ((\u0004) this.\u0001).Plant);
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, ((\u0004) this.\u0001).Pick);
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0004, this.\u0001.Water);
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0005, this.\u0001.GardenFlowers);
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0006, this.\u0001.GardenTrees);
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0007, this.\u0001.Customized);
      this.\u0001.WaterCount = (int) this.\u0001.WaterCount;
      this.\u007F\u0005();
    }

    private void \u007F\u0005()
    {
      if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001) != this.\u0001.Enabled)
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, this.\u0001.Enabled);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, this.\u0001.Enabled);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0007, this.\u0001.Enabled);
      bool flag = this.\u0001.Enabled && !this.\u0001.Customized;
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0005, flag);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0006, flag);
      this.\u0080\u0005();
    }

    private void \u0080\u0005()
    {
      bool flag1 = this.\u0001.Enabled && !this.\u0001.Customized;
      bool flag2 = flag1 && this.\u0001.GardenFlowers;
      bool flag3 = flag1 && (this.\u0001.GardenFlowers || this.\u0001.GardenTrees);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, flag2);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, flag2);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, flag3);
      this.\u0002.Enabled = flag1 && \u0099\u0082.\u007E\u0002\u0088((object) this.\u0004);
    }

    protected override void InitLayout()
    {
      IEnumerator enumerator = \u0015\u0082.\u007E\u008D\u0086((object) \u0096\u001D.\u0087\u0083((object) this));
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          Control control = (Control) \u0005\u007F.\u007E\u0092\u0092((object) enumerator);
          // ISSUE: method pointer
          \u0087\u007F.\u007E\u0093\u0084((object) control, new EventHandler((object) this, __methodptr(\u001E\u0005)));
          \u0087\u007F.\u007E\u0094\u0084((object) control, new EventHandler(this.\u001F\u0005));
        }
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          \u001A\u001E.\u007E\u0094\u0092((object) disposable);
      }
      \u001A\u001E.\u0002\u0086((object) this);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (!\u0097\u001D.\u001A\u007F(\u0091\u0084.\u007E\u001C\u0083((object) this), \u009A\u0080.\u0019\u0081()))
        return;
      this.\u001D\u0005(\u009A\u0080.\u0019\u0081());
      \u0081\u001C.\u007E\u0088\u0083((object) this, \u009B\u0086.\u0008\u008A());
      IEnumerator enumerator = \u0015\u0082.\u007E\u008D\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) \u0003\u001E.\u0011\u0084((object) this)));
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          \u0005 obj = (Control) \u0005\u007F.\u007E\u0092\u0092((object) enumerator) as \u0005;
          if (obj != null && obj != this)
            obj.\u0081\u0005();
        }
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          \u001A\u001E.\u007E\u0094\u0092((object) disposable);
      }
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u0081\u0005();
    }

    private void \u0081\u0005()
    {
      if (!\u0097\u001D.\u001A\u007F(\u0091\u0084.\u007E\u001C\u0083((object) this), \u009A\u0080.\u0016\u0081()) || \u008D\u0084.\u0082\u0083((object) this).Contains(\u0098\u001B.\u001A\u0086((object) this, \u0098\u0080.\u009F\u0089())))
        return;
      this.\u001D\u0005(\u009A\u0080.\u0016\u0081());
      \u0081\u001C.\u007E\u0088\u0083((object) this, \u009B\u0086.\u0007\u008A());
    }

    private void \u001D\u0005(Color c)
    {
      IEnumerator enumerator = \u0015\u0082.\u007E\u008D\u0086((object) \u0096\u001D.\u0087\u0083((object) this));
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          Control control = (Control) \u0005\u007F.\u007E\u0092\u0092((object) enumerator);
          \u0081\u0082.\u007E\u001D\u0083((object) control, c);
          \u001A\u001E.\u007E\u0086\u0086((object) control);
        }
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          \u001A\u001E.\u007E\u0094\u0092((object) disposable);
      }
      \u0081\u0082.\u007E\u001D\u0083((object) this, c);
      \u001A\u001E.\u0086\u0086((object) this);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (this.\u0001.Enabled == \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001))
        return;
      this.\u0001.Enabled = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001);
      this.\u007F\u0005();
      this.\u001E\u0005();
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, !\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001));
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      if (this.\u0001.Customized == \u0099\u0082.\u007E\u0002\u0088((object) this.\u0007))
        return;
      this.\u0001.Customized = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0007);
      this.\u007F\u0005();
      this.\u001E\u0005();
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      if ((int) this.\u0001.WaterCount == this.\u0001.WaterCount)
        return;
      this.\u0001.WaterCount = (ushort) this.\u0001.WaterCount;
      this.\u001E\u0005();
    }

    private void \u001E\u0005(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0002\u0088((object) this.\u0007))
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0007, true);
      \u0007 obj1 = new \u0007(\u008E\u0086.\u0099\u0086((object) this));
      try
      {
        \u0003 obj2 = new \u0003(this.\u0001);
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) != DialogResult.OK)
            return;
          this.\u001E\u0005();
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
      if (this.\u0001.GardenFlowers == \u0099\u0082.\u007E\u0002\u0088((object) this.\u0005))
        return;
      this.\u0001.GardenFlowers = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0005);
      this.\u0080\u0005();
      this.\u001E\u0005();
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      if (this.\u0001.GardenTrees == \u0099\u0082.\u007E\u0002\u0088((object) this.\u0006))
        return;
      this.\u0001.GardenTrees = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0006);
      this.\u0080\u0005();
      this.\u001E\u0005();
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      if (((\u0004) this.\u0001).Pick == \u0099\u0082.\u007E\u0002\u0088((object) this.\u0002))
        return;
      this.\u0001.Pick = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0002);
      this.\u001E\u0005();
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      if (((\u0004) this.\u0001).Plant == \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003))
        return;
      this.\u0001.Plant = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003);
      this.\u001E\u0005();
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      this.\u0080\u0005();
      if (this.\u0001.Water == \u0099\u0082.\u007E\u0002\u0088((object) this.\u0004))
        return;
      this.\u0001.Water = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0004);
      this.\u001E\u0005();
    }
  }
}
