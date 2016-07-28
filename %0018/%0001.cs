// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001A;
using \u001F;
using \u0080;
using \u0082;
using \u0084;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u0001 : \u0014.\u0017
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private IContainer \u0001;
    private Button \u0001;
    private Label \u0001;
    private ComboBox \u0001;
    private ListView \u0001;
    private ColumnHeader \u0001;
    private ColumnHeader \u0002;
    private ContextMenu \u0001;
    private \u0005 \u0001;
    private MenuItem \u0001;
    private MenuItem \u0002;
    private ListView \u0002;
    private ColumnHeader \u0003;
    private ComboBox \u0002;
    private Button \u0002;
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
    private \u001C \u0001;
    private \u0080.\u0018 \u0001;
    private \u001F.\u0001 \u0001;
    private Dictionary<\u001A.\u0019, \u0018.\u0001.\u0002> \u0001;

    static \u0001()
    {
      \u0004.\u001D\u0005(typeof (\u0018.\u0001));
    }

    public \u0001(\u001F.\u0001 settings)
      : this(false)
    {
      \u0099\u001F obj1 = \u0099\u001F.\u007E\u0018\u0087;
      ToolStripMenuItem toolStripMenuItem1 = this.\u0002;
      \u0099\u001F obj2 = \u0099\u001F.\u007E\u0018\u0087;
      ToolStripMenuItem toolStripMenuItem2 = this.\u0003;
      \u0099\u001F obj3 = \u0099\u001F.\u007E\u0018\u0087;
      ToolStripSeparator toolStripSeparator1 = this.\u0001;
      \u0099\u001F obj4 = \u0099\u001F.\u007E\u0018\u0087;
      ToolStripMenuItem toolStripMenuItem3 = this.\u0004;
      \u0099\u001F obj5 = \u0099\u001F.\u007E\u0018\u0087;
      ToolStripMenuItem toolStripMenuItem4 = this.\u0005;
      \u0099\u001F obj6 = \u0099\u001F.\u007E\u0018\u0087;
      ToolStripSeparator toolStripSeparator2 = this.\u0002;
      \u0099\u001F obj7 = \u0099\u001F.\u007E\u0083\u0087;
      ToolStripMenuItem toolStripMenuItem5 = this.\u0002;
      \u0099\u001F obj8 = \u0099\u001F.\u007E\u0083\u0087;
      ToolStripMenuItem toolStripMenuItem6 = this.\u0003;
      \u0099\u001F obj9 = \u0099\u001F.\u007E\u0083\u0087;
      ToolStripSeparator toolStripSeparator3 = this.\u0001;
      \u0099\u001F obj10 = \u0099\u001F.\u007E\u0083\u0087;
      ToolStripMenuItem toolStripMenuItem7 = this.\u0004;
      \u0099\u001F obj11 = \u0099\u001F.\u007E\u0083\u0087;
      ToolStripMenuItem toolStripMenuItem8 = this.\u0005;
      bool flag1;
      \u0099\u001F.\u007E\u0083\u0087((object) this.\u0002, flag1 = false);
      int num1;
      bool flag2 = (num1 = flag1 ? 1 : 0) != 0;
      obj11((object) toolStripMenuItem8, num1 != 0);
      int num2;
      bool flag3 = (num2 = flag2 ? 1 : 0) != 0;
      obj10((object) toolStripMenuItem7, num2 != 0);
      int num3;
      bool flag4 = (num3 = flag3 ? 1 : 0) != 0;
      obj9((object) toolStripSeparator3, num3 != 0);
      int num4;
      bool flag5 = (num4 = flag4 ? 1 : 0) != 0;
      obj8((object) toolStripMenuItem6, num4 != 0);
      int num5;
      bool flag6 = (num5 = flag5 ? 1 : 0) != 0;
      obj7((object) toolStripMenuItem5, num5 != 0);
      int num6;
      bool flag7 = (num6 = flag6 ? 1 : 0) != 0;
      obj6((object) toolStripSeparator2, num6 != 0);
      int num7;
      bool flag8 = (num7 = flag7 ? 1 : 0) != 0;
      obj5((object) toolStripMenuItem4, num7 != 0);
      int num8;
      bool flag9 = (num8 = flag8 ? 1 : 0) != 0;
      obj4((object) toolStripMenuItem3, num8 != 0);
      int num9;
      bool flag10 = (num9 = flag9 ? 1 : 0) != 0;
      obj3((object) toolStripSeparator1, num9 != 0);
      int num10;
      bool flag11 = (num10 = flag10 ? 1 : 0) != 0;
      obj2((object) toolStripMenuItem2, num10 != 0);
      int num11 = flag11 ? 1 : 0;
      obj1((object) toolStripMenuItem1, num11 != 0);
      this.CanSave = false;
      this.\u0001 = settings;
      this.\u0081\u0005();
    }

    public \u0001(bool joeFish)
    {
      this.\u0080\u0005();
      this.\u0001 = new Dictionary<\u001A.\u0019, \u0018.\u0001.\u0002>();
      \u0019.\u007F obj1 = new \u0019.\u007F();
      \u0081\u001D.\u007E\u008E\u008C((object) this.\u0002, (IComparer) obj1);
      \u0082\u0080.\u007E\u0092\u008C((object) this.\u0002, SortOrder.Ascending);
      obj1.Order = SortOrder.Ascending;
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler(((\u0014.\u0017) this).\u001D\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(((\u0014.\u0017) this).\u001E\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(((\u0014.\u0017) this).\u007F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(((\u0014.\u0017) this).\u001F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(((\u0014.\u0017) this).\u0080\u0005));
      this.\u0001 = new \u001C();
      this.\u0002.Format += (ListControlConvertEventHandler) ((obj, e) => \u008E\u007F.\u007E\u0095\u0089((object) e, (object) ((\u001A.\u0019) \u0005\u007F.\u007E\u0083\u008C((object) e)).\u001D\u0005()));
      // ISSUE: type reference
      Array array = \u009D\u0081.\u0097\u0091(\u009C\u0082.\u0016\u0097(__typeref (\u001A.\u0019)));
      object[] objArray = new object[\u0005\u0081.\u007E\u0089\u0092((object) array)];
      \u0083\u0081.\u007E\u008C\u0092((object) array, (Array) objArray, 0);
      List<object> list = ((IEnumerable<object>) objArray).ToList<object>();
      list.Remove((object) \u001A.\u0019.\u0001);
      \u0003\u0083.\u007E\u0004\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0002), list.ToArray());
      this.\u0001.Format += (ListControlConvertEventHandler) ((obj, e) => \u008E\u007F.\u007E\u0095\u0089((object) e, (object) ((\u007F.\u007F) \u0005\u007F.\u007E\u0083\u008C((object) e)).\u001D\u0005()));
      int num1 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0001);
      if (joeFish)
      {
        int num2 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0002);
        this.\u001E\u0005();
      }
      else
      {
        int num2 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0006);
        int num3 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0007);
        int num4 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0008);
        int num5 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u000E);
        int num6 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u000F);
        int num7 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0010);
        int num8 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0011);
        int num9 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0012);
        int num10 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0013);
        int num11 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0014);
        int num12 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0015);
        int num13 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0016);
        int num14 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0017);
        int num15 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0018);
        int num16 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u0019);
        int num17 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u001A);
        int num18 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u001B);
        int num19 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u001C);
        int num20 = \u007F\u001F.\u007E\u0003\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), (object) \u007F.\u007F.\u001D);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u0080\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0018.\u0001)));
      this.\u0001 = new Button();
      this.\u0001 = new Label();
      this.\u0001 = new ComboBox();
      this.\u0001 = new ListView();
      this.\u0001 = new ColumnHeader();
      this.\u0002 = new ColumnHeader();
      this.\u0001 = new ContextMenu();
      this.\u0001 = new MenuItem();
      this.\u0002 = new MenuItem();
      this.\u0001 = new \u0005();
      this.\u0002 = new ListView();
      this.\u0003 = new ColumnHeader();
      this.\u0002 = new ComboBox();
      this.\u0002 = new Button();
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
      \u001A\u001E.\u0084\u0086((object) this);
      \u0092\u0081.\u007E\u0095\u008A((object) base.\u0001, \u0018.\u0001.\u0001(31186));
      \u0092\u0081.\u007E\u0095\u008A((object) base.\u0001, \u0018.\u0001.\u0001(31186));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(397, 219));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0001.\u0001(31219));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0018.\u0001.\u0001(31240));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0087\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(7, 250));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0001.\u0001(17587));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(609, 57));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 34);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0090\u0083.\u007E\u001F\u009C((object) componentResourceManager, \u0018.\u0001.\u0001(17608)));
      \u0019\u001D.\u007E\u009B\u0088((object) this.\u0001, ComboBoxStyle.DropDownList);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(516, 220));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0001.\u0001(31249));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(100, 21));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 6);
      \u0087\u007F.\u007E\u009C\u0088((object) this.\u0001, new EventHandler(this.\u008A\u0005));
      \u0006\u0084.\u007E\u0001\u008D((object) \u009B\u0082.\u007E\u0088\u008C((object) this.\u0001), new ColumnHeader[2]
      {
        this.\u0001,
        this.\u0002
      });
      \u0099\u001F.\u007E\u0089\u008C((object) this.\u0001, true);
      \u0080\u0082.\u007E\u008B\u008C((object) this.\u0001, ColumnHeaderStyle.Nonclickable);
      \u0099\u001F.\u007E\u008C\u008C((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(316, 31));
      \u0099\u001F.\u007E\u008F\u008C((object) this.\u0001, false);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0001.\u0001(31278));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(300, 183));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0099\u001F.\u007E\u0093\u008C((object) this.\u0001, false);
      \u0017\u0080.\u007E\u0094\u008C((object) this.\u0001, View.Details);
      \u0087\u007F.\u007E\u0095\u008C((object) this.\u0001, new EventHandler(this.\u0089\u0005));
      \u0092\u0081.\u007E\u008E\u0088((object) this.\u0001, \u0018.\u0001.\u0001(31295));
      \u0011\u001F.\u007E\u0090\u0088((object) this.\u0001, 160);
      \u0092\u0081.\u007E\u008E\u0088((object) this.\u0002, \u0018.\u0001.\u0001(31304));
      \u0011\u001F.\u007E\u0090\u0088((object) this.\u0002, 110);
      \u0081\u001E.\u007E\u0010\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0001), new MenuItem[2]
      {
        this.\u0001,
        this.\u0002
      });
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0001, \u0018.\u0001.\u0001(31313));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0001, new EventHandler(this.\u0084\u0005));
      \u0099\u001F.\u007E\u0095\u008D((object) this.\u0002, false);
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0002, \u0018.\u0001.\u0001(31338));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0002, new EventHandler(this.\u0083\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(316, 219));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0001.\u0001(31355));
      this.\u0001.ShowSplit = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      this.\u0001.SplitMenu = this.\u0001;
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0018.\u0001.\u0001(31372));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0086\u0005));
      \u0006\u0084.\u007E\u0001\u008D((object) \u009B\u0082.\u007E\u0088\u008C((object) this.\u0002), new ColumnHeader[1]
      {
        this.\u0003
      });
      \u0099\u001F.\u007E\u0089\u008C((object) this.\u0002, true);
      \u0080\u0082.\u007E\u008B\u008C((object) this.\u0002, ColumnHeaderStyle.Nonclickable);
      \u0099\u001F.\u007E\u008C\u008C((object) this.\u0002, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(10, 31));
      \u0099\u001F.\u007E\u008F\u008C((object) this.\u0002, false);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0018.\u0001.\u0001(31377));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(300, 183));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 0);
      \u0099\u001F.\u007E\u0093\u008C((object) this.\u0002, false);
      \u0017\u0080.\u007E\u0094\u008C((object) this.\u0002, View.Details);
      \u0087\u007F.\u007E\u0095\u008C((object) this.\u0002, new EventHandler(this.\u0088\u0005));
      \u0092\u0081.\u007E\u008E\u0088((object) this.\u0003, \u0018.\u0001.\u0001(31398));
      \u0011\u001F.\u007E\u0090\u0088((object) this.\u0003, 270);
      \u0019\u001D.\u007E\u009B\u0088((object) this.\u0002, ComboBoxStyle.DropDownList);
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0002, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(12, 220));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0018.\u0001.\u0001(31398));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(298, 21));
      \u0099\u001F.\u007E\u009A\u0088((object) this.\u0002, true);
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0087\u007F.\u007E\u009C\u0088((object) this.\u0002, new EventHandler(this.\u008B\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(478, 219));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0018.\u0001.\u0001(31415));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(32, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0018.\u0001.\u0001(3828));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u0082\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[3]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0007,
        (ToolStripItem) this.\u000E
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0001.\u0001(31440));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(623, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 35);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0018.\u0001.\u0001(6039));
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
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0018.\u0001.\u0001(21574));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(37, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0018.\u0001.\u0001(6069));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0018.\u0001.\u0001(21591));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0002, Keys.N | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0018.\u0001.\u0001(6087));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0018.\u0001.\u0001(21608));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0003, Keys.O | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0018.\u0001.\u0001(6109));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0018.\u0001.\u0001(21625));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0018.\u0001.\u0001(21650));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0004, Keys.S | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u0018.\u0001.\u0001(6160));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0018.\u0001.\u0001(6169));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0005, Keys.S | Keys.Shift | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u0018.\u0001.\u0001(6190));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0018.\u0001.\u0001(31465));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u0018.\u0001.\u0001(21696));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0006, Keys.W | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u0018.\u0001.\u0001(6253));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0007), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0008
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u0018.\u0001.\u0001(22221));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(63, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u0018.\u0001.\u0001(18168));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0008, \u0018.\u0001.\u0001(31494));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0008, new Size(213, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0008, \u0018.\u0001.\u0001(18210));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0008, new EventHandler(this.\u0081\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u000E), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u000F
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000E, \u0018.\u0001.\u0001(6388));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000E, new Size(44, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000E, \u0018.\u0001.\u0001(6405));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000F, \u0018.\u0001.\u0001(6414));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u000F, Keys.F1);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000F, new Size(124, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000F, \u0018.\u0001.\u0001(6435));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000F, new EventHandler(this.\u008C\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(623, 313));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0018.\u0001.\u0001(6444)));
      \u001A\u001D.\u0019\u008B((object) this, this.\u0001);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0018.\u0001.\u0001(31535));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0018.\u0001.\u0001(31556));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    protected override void \u001D\u0005(\u001B fileName, bool modified)
    {
      if (!base.CanSave)
        return;
      if (!modified)
      {
        if (\u001B.\u001D\u0005(fileName, (object) null))
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0018.\u0001.\u0001(31556));
        else
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0081\u0086.\u0086\u0093(\u0018.\u0001.\u0001(31667), \u009C\u0080.\u0008\u009F(fileName.\u0002)));
      }
      else if (\u001B.\u001D\u0005(fileName, (object) null))
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u0018.\u0001.\u0001(31593));
      else
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u009E\u0081.\u001F\u0093(\u0018.\u0001.\u0001(31634), (object) \u009C\u0080.\u0008\u009F(fileName.\u0002)));
    }

    protected override void \u001D\u0005()
    {
      this.\u0001 = new \u001F.\u0001();
      this.\u0081\u0005();
    }

    protected override bool \u001E\u0005(\u001B path)
    {
      try
      {
        this.\u0001 = new \u001F.\u0001(path.\u0002);
        this.\u0081\u0005();
        if (\u0005\u0081.\u007E\u0002\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0002)) > 0)
          \u0099\u001F.\u007E\u001E\u008D((object) \u008B\u0086.\u007E\u0003\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0002), 0), true);
        return true;
      }
      catch (Exception ex)
      {
        \u0018.\u0017.\u001D\u0005(ex, path.\u0002);
        return false;
      }
    }

    protected override bool \u001D\u0005(\u001B fileName)
    {
      try
      {
        this.\u0001.\u001D\u0005(fileName.\u0002);
        return true;
      }
      catch (Exception ex)
      {
        \u0018.\u0017.\u001D\u0005(ex, fileName.\u0002);
        return false;
      }
    }

    private void \u0081\u0005()
    {
      \u001A\u001E.\u007E\u0006\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0002));
      \u001A\u001E.\u007E\u0006\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001));
      this.\u0001.Clear();
      foreach (\u001A.\u0019 key in this.\u0001.WayPoints.Keys)
      {
        \u0018.\u0001.\u0002 obj = new \u0018.\u0001.\u0002(key);
        ListViewItem listViewItem = \u009C\u0081.\u007E\u0004\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0002), (ListViewItem) obj);
        this.\u0001.Add(key, obj);
      }
      \u001A\u001E.\u007E\u009A\u008C((object) this.\u0002);
      if (\u0005\u0081.\u007E\u0002\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0002)) <= 0)
        return;
      \u0099\u001F.\u007E\u001E\u008D((object) \u008B\u0086.\u007E\u0003\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0002), 0), true);
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      if (!this.\u0001.\u001D\u0005((Form) this, (EventHandler<\u0080.\u0017>) null))
        return;
      this.\u0082\u0005();
    }

    private void \u0082\u0005()
    {
      if (\u0080.\u0018.\u001D\u0005(this.\u0001.MainWindowHandle, out this.\u0001))
        return;
      this.\u0001 = \u0080.\u0018.\u001D\u0005(this.\u0001.MainWindowHandle, \u0080.\u0001.\u0001, (string) null);
      this.\u0001.\u0080\u0005();
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0018.\u0001.\u0003 obj1 = new \u0018.\u0001.\u0003();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0) as \u0018.\u0001.\u0001;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = (\u001A.\u0019) \u0005\u007F.\u007E\u0098\u0088((object) this.\u0002);
      \u0080.\u0080 obj2 = new \u0080.\u0080();
      try
      {
        // ISSUE: reference to a compiler-generated method
        obj2.ValueValidating += new EventHandler<\u0011<PointF>>(obj1.\u001D\u0005);
        // ISSUE: reference to a compiler-generated field
        obj2.SelectedPoint = obj1.\u0001.Point;
        // ISSUE: reference to a compiler-generated field
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) != DialogResult.OK || !\u0007\u0080.\u0086\u0082(obj1.\u0001.Point, obj2.SelectedPoint))
          return;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        \u007F.\u007F obj3 = this.\u0001.WayPoints[obj1.\u0001][obj1.\u0001.Point];
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.\u0001.WayPoints[obj1.\u0001].Remove(obj1.\u0001.Point);
        // ISSUE: reference to a compiler-generated field
        this.\u0001.WayPoints[obj1.\u0001].Add(obj2.SelectedPoint, obj3);
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001.Point = obj2.SelectedPoint;
        this.FileModified = true;
      }
      finally
      {
        if (obj2 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj2);
      }
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      \u0080.\u0080 obj1 = new \u0080.\u0080();
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0018.\u0001.\u0004 obj2 = new \u0018.\u0001.\u0004();
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = this;
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = (\u001A.\u0019) \u0005\u007F.\u007E\u0098\u0088((object) this.\u0002);
        // ISSUE: reference to a compiler-generated method
        obj1.ValueValidating += new EventHandler<\u0011<PointF>>(obj2.\u001D\u0005);
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj1) != DialogResult.OK)
          return;
        // ISSUE: reference to a compiler-generated field
        this.\u0001.WayPoints[obj2.\u0001].Add(obj1.SelectedPoint, \u007F.\u007F.\u0001);
        ListViewItem listViewItem = \u009C\u0081.\u007E\u0004\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001), (ListViewItem) new \u0018.\u0001.\u0001(obj1.SelectedPoint, \u007F.\u007F.\u0001));
        this.FileModified = true;
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      this.\u0083\u0005();
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      this.\u0083\u0005();
    }

    private void \u0083\u0005()
    {
      if (!this.\u0001.ProcessOpen)
      {
        if (!this.\u0001.\u001D\u0005((Form) this))
          return;
        this.\u0082\u0005();
      }
      \u001A.\u0019 playground = this.\u0001.Playground;
      if (playground == \u001A.\u0019.\u0001)
      {
        \u0018.\u0017.\u001D\u0005(\u0018.\u0001.\u0001(31696), \u0018.\u0001.\u0001(31801));
      }
      else
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0018.\u0001.\u0005 obj1 = new \u0018.\u0001.\u0005();
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = new \u0006?();
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0018.\u0001.\u0006 obj2 = new \u0018.\u0001.\u0006();
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = obj1;
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = this;
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
        if (obj1.\u0001.HasValue)
        {
          Dictionary<PointF, \u007F.\u007F> dictionary;
          \u0018.\u0001.\u0002 obj3;
          if (this.\u0001.WayPoints.ContainsKey(playground))
          {
            dictionary = this.\u0001.WayPoints[playground];
            obj3 = this.\u0001[playground];
          }
          else
          {
            dictionary = new Dictionary<PointF, \u007F.\u007F>();
            this.\u0001.WayPoints.Add(playground, dictionary);
            ListViewItem listViewItem = \u009C\u0081.\u007E\u0004\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0002), (ListViewItem) (obj3 = new \u0018.\u0001.\u0002(playground)));
            this.\u0001.Add(playground, obj3);
            \u001A\u001E.\u007E\u009A\u008C((object) this.\u0002);
          }
          \u001A\u001E.\u007E\u009E\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002));
          if (obj3 != null)
            \u0099\u001F.\u007E\u001E\u008D((object) obj3, true);
          // ISSUE: reference to a compiler-generated field
          PointF location = obj1.\u0001.Value.Location;
          \u0018.\u0001.\u0001 obj4 = (\u0018.\u0001.\u0001) null;
          if (dictionary.ContainsKey(location))
          {
            \u0018.\u0001.\u001D\u0005(location);
            IEnumerator enumerator = \u0015\u0082.\u007E\u0008\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001));
            try
            {
              while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
              {
                \u0018.\u0001.\u0001 obj5 = (\u0018.\u0001.\u0001) \u0005\u007F.\u007E\u0092\u0092((object) enumerator);
                if (\u0007\u0080.\u0084\u0082(obj5.Point, location))
                {
                  obj4 = obj5;
                  break;
                }
              }
            }
            finally
            {
              IDisposable disposable = enumerator as IDisposable;
              if (disposable != null)
                \u001A\u001E.\u007E\u0094\u0092((object) disposable);
            }
          }
          else
          {
            dictionary.Add(location, \u007F.\u007F.\u0001);
            ListViewItem listViewItem = \u009C\u0081.\u007E\u0004\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001), (ListViewItem) (obj4 = new \u0018.\u0001.\u0001(location, \u007F.\u007F.\u0001)));
            this.FileModified = true;
          }
          IEnumerator enumerator1 = \u0015\u0082.\u007E\u009F\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001));
          try
          {
            while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator1))
            {
              \u0018.\u0001.\u0001 obj5 = (\u0018.\u0001.\u0001) \u0005\u007F.\u007E\u0092\u0092((object) enumerator1);
              \u0099\u001F.\u007E\u001E\u008D((object) obj5, false);
            }
          }
          finally
          {
            IDisposable disposable = enumerator1 as IDisposable;
            if (disposable != null)
              \u001A\u001E.\u007E\u0094\u0092((object) disposable);
          }
          if (obj4 == null)
            return;
          \u0099\u001F.\u007E\u001E\u008D((object) obj4, true);
        }
        else
          \u0018.\u0017.\u001D\u0005(\u0018.\u0001.\u0001(31826), \u0018.\u0001.\u0001(32008));
      }
    }

    private static void \u001D\u0005(PointF p)
    {
      \u0018.\u0017.\u001D\u0005(\u009E\u0081.\u001F\u0093(\u0018.\u0001.\u0001(32049), (object) p), \u0018.\u0001.\u0001(32118));
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      \u0018.\u0001.\u0002 obj1 = \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0) as \u0018.\u0001.\u0002;
      \u0018.\u0001.\u0001 obj2 = \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0) as \u0018.\u0001.\u0001;
      int num1 = \u0096\u0081.\u007E\u009B\u008C((object) \u0086\u001F.\u007E\u0090\u008C((object) this.\u0001), 0);
      Dictionary<PointF, \u007F.\u007F> dictionary = this.\u0001.WayPoints[obj1.\u0001];
      dictionary.Remove(obj2.Point);
      \u0095\u0086.\u007E\u0010\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001), (ListViewItem) obj2);
      if (dictionary.Count == 0)
      {
        \u0095\u0086.\u007E\u0010\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0002), (ListViewItem) obj1);
        this.\u0001.WayPoints.Remove(obj1.\u0001);
        this.\u0001.Remove(obj1.\u0001);
      }
      int num2 = \u0005\u0081.\u007E\u0002\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001));
      if (num1 < num2)
        \u0099\u001F.\u007E\u001E\u008D((object) \u008B\u0086.\u007E\u0003\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001), num1), true);
      else if (num2 > 0)
        \u0099\u001F.\u007E\u001E\u008D((object) \u008B\u0086.\u007E\u0003\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001), num2 - 1), true);
      this.FileModified = true;
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u007E\u0006\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001));
      if (\u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002)) <= 0)
      {
        if (\u0005\u007F.\u007E\u0098\u0088((object) this.\u0002) != null)
          \u008E\u007F.\u007E\u0099\u0088((object) this.\u0002, (object) null);
      }
      else
        goto label_9;
label_8:
      this.\u0084\u0005();
      return;
label_9:
      foreach (KeyValuePair<PointF, \u007F.\u007F> keyValuePair in this.\u0001.WayPoints[(\u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0) as \u0018.\u0001.\u0002).\u0001])
      {
        ListViewItem listViewItem = \u009C\u0081.\u007E\u0004\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001), (ListViewItem) new \u0018.\u0001.\u0001(keyValuePair.Key, keyValuePair.Value));
      }
      \u008E\u007F.\u007E\u0099\u0088((object) this.\u0002, (object) (\u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0) as \u0018.\u0001.\u0002).\u0001);
      goto label_8;
    }

    private void \u0089\u0005(object sender, EventArgs e)
    {
      this.\u0084\u0005();
      if (\u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) > 0)
        \u008E\u007F.\u007E\u0099\u0088((object) this.\u0001, (object) (\u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0) as \u0018.\u0001.\u0001).WayPointType);
      else
        \u0011\u001F.\u007E\u000E\u0088((object) this.\u0001, -1);
    }

    private void \u008A\u0005(object sender, EventArgs e)
    {
      if (\u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) <= -1)
        return;
      \u0018.\u0001.\u0001 obj1 = \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0) as \u0018.\u0001.\u0001;
      \u0018.\u0001.\u0002 obj2 = \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0) as \u0018.\u0001.\u0002;
      \u007F.\u007F obj3 = (\u007F.\u007F) \u0005\u007F.\u007E\u0098\u0088((object) this.\u0001);
      if (obj1.WayPointType != obj3)
      {
        Dictionary<PointF, \u007F.\u007F> dictionary = this.\u0001.WayPoints[obj2.\u0001];
        if (obj3 == \u007F.\u007F.\u0002)
        {
          IEnumerator enumerator = \u0015\u0082.\u007E\u0008\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001));
          try
          {
            while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
            {
              \u0018.\u0001.\u0001 obj4 = (\u0018.\u0001.\u0001) \u0005\u007F.\u007E\u0092\u0092((object) enumerator);
              if (obj4.WayPointType == \u007F.\u007F.\u0002)
              {
                obj4.WayPointType = \u007F.\u007F.\u0001;
                dictionary[obj4.Point] = \u007F.\u007F.\u0001;
              }
            }
          }
          finally
          {
            IDisposable disposable = enumerator as IDisposable;
            if (disposable != null)
              \u001A\u001E.\u007E\u0094\u0092((object) disposable);
          }
        }
        obj1.WayPointType = obj3;
        dictionary[obj1.Point] = obj3;
      }
      this.FileModified = true;
    }

    private void \u0084\u0005()
    {
      \u0099\u001F obj1 = \u0099\u001F.\u007E\u008F\u0083;
      Button button = this.\u0002;
      \u0099\u001F obj2 = \u0099\u001F.\u007E\u008F\u0083;
      ComboBox comboBox = this.\u0001;
      bool flag1;
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, flag1 = \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) > 0);
      int num1;
      bool flag2 = (num1 = flag1 ? 1 : 0) != 0;
      obj2((object) comboBox, num1 != 0);
      int num2 = flag2 ? 1 : 0;
      obj1((object) button, num2 != 0);
      \u0099\u001F.\u007E\u0095\u008D((object) this.\u0002, \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002)) > 0);
    }

    private void \u008B\u0005(object sender, EventArgs e)
    {
      if (\u0005\u007F.\u007E\u0098\u0088((object) this.\u0002) == null)
        return;
      \u001A.\u0019 index = (\u001A.\u0019) \u0005\u007F.\u007E\u0098\u0088((object) this.\u0002);
      \u0018.\u0001.\u0002 obj;
      if (!this.\u0001.ContainsKey(index))
      {
        obj = new \u0018.\u0001.\u0002(index);
        this.\u0001.WayPoints.Add(index, new Dictionary<PointF, \u007F.\u007F>());
        ListViewItem listViewItem = \u009C\u0081.\u007E\u0004\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0002), (ListViewItem) obj);
        this.\u0001.Add(index, obj);
        \u0099\u001F.\u007E\u001E\u008D((object) obj, true);
        \u001A\u001E.\u007E\u009A\u008C((object) this.\u0002);
      }
      else
        goto label_6;
label_5:
      \u0011\u001F.\u007E\u0099\u008C((object) this.\u0002, \u0005\u0081.\u007E\u001C\u008D((object) obj));
      return;
label_6:
      obj = this.\u0001[index];
      if (!\u0099\u0082.\u007E\u001D\u008D((object) obj))
      {
        \u001A\u001E.\u007E\u009E\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002));
        \u0099\u001F.\u007E\u001E\u008D((object) this.\u0001[index], true);
        goto label_5;
      }
      else
        goto label_5;
    }

    private void \u008C\u0005(object sender, EventArgs e)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u0014);
    }

    private sealed class \u0001 : ListViewItem
    {
      private PointF \u0001;

      public \u007F.\u007F WayPointType
      {
        get
        {
          return (\u008B\u001F.\u007E\u0086\u008D((object) \u001D\u0080.\u001F\u008D((object) this), 1) as \u0018.\u0001.\u0001.\u0001).WayPointType;
        }
        set
        {
          (\u008B\u001F.\u007E\u0086\u008D((object) \u001D\u0080.\u001F\u008D((object) this), 1) as \u0018.\u0001.\u0001.\u0001).WayPointType = value;
        }
      }

      public PointF Point
      {
        get
        {
          return this.\u0001;
        }
        set
        {
          if (!\u0007\u0080.\u0086\u0082(this.\u0001, value))
            return;
          this.\u0001 = value;
          \u0092\u0081.\u0080\u008D((object) this, this.\u0001.ToString());
        }
      }

      public \u0001(PointF point, \u007F.\u007F type)
      {
        this.Point = point;
        \u0092\u0081.\u0080\u008D((object) this, point.ToString());
        ListViewItem.ListViewSubItem listViewSubItem = \u009A\u001F.\u007E\u0087\u008D((object) \u001D\u0080.\u001F\u008D((object) this), (ListViewItem.ListViewSubItem) new \u0018.\u0001.\u0001.\u0001(type));
      }

      private sealed class \u0001 : ListViewItem.ListViewSubItem
      {
        private \u007F.\u007F \u0001;

        public \u007F.\u007F WayPointType
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
            \u0092\u0081.\u0084\u008D((object) this, this.\u0001.\u001D\u0005());
          }
        }

        public \u0001(\u007F.\u007F type)
        {
          this.WayPointType = type;
          \u0092\u0081.\u0084\u008D((object) this, this.\u0001.\u001D\u0005());
        }
      }
    }

    private sealed class \u0002 : ListViewItem
    {
      public readonly \u001A.\u0019 \u0001;

      public \u0002(\u001A.\u0019 playground)
      {
        this.\u0001 = playground;
        \u0092\u0081.\u0080\u008D((object) this, this.\u0001.\u001D\u0005());
      }
    }
  }
}
