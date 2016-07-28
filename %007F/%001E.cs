// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0017;
using \u0019;
using \u001A;
using \u001B;
using \u001F;
using \u007F;
using \u0082;
using \u0083;
using \u0084;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;
using TheToonTownSpoofer.IO.Archive;
using TSN.Controls;

namespace \u007F
{
  internal sealed class \u001E : \u0014.\u0017
  {
    private Dictionary<string, \u001E.\u007F> \u0001 = new Dictionary<string, \u001E.\u007F>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    private \u0015<ListViewItemState<string>, HashSet<ListViewItemState<string>>> \u0001 = new \u0015<ListViewItemState<string>, HashSet<ListViewItemState<string>>>((IEqualityComparer<ListViewItemState<string>>) \u007F.\u001A.\u0001);
    private \u0015<ListViewItemState<string>, HashSet<ListViewItemState<string>>> \u0002 = new \u0015<ListViewItemState<string>, HashSet<ListViewItemState<string>>>((IEqualityComparer<ListViewItemState<string>>) \u007F.\u001A.\u0001);
    private Dictionary<string, \u007F.\u001E.\u0001> \u0001 = new Dictionary<string, \u007F.\u001E.\u0001>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    private Dictionary<string, ListViewItemState<string>> \u0001 = new Dictionary<string, ListViewItemState<string>>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    [NonSerialized]
    internal new static \u0002 \u0001;
    private IContainer \u0001;
    private PropertyGrid \u0001;
    private MenuStrip \u0001;
    private ToolStripMenuItem \u0001;
    private ToolStripMenuItem \u0002;
    private ToolStripMenuItem \u0003;
    private ToolStripMenuItem \u0004;
    private ToolStripMenuItem \u0005;
    private ToolStrip \u0001;
    private ToolStripButton \u0001;
    private ToolStripButton \u0002;
    private ToolStripSeparator \u0001;
    private ToolStripLabel \u0001;
    private ToolStripTextBox \u0001;
    private ToolStripSeparator \u0002;
    private ToolStripButton \u0003;
    private PictureBox \u0001;
    private ToolStripButton \u0004;
    private ToolStripButton \u0005;
    private \u001C.\u001D \u0001;
    private PictureBox \u0002;
    private \u001C.\u001D \u0002;
    private Label \u0001;
    private Label \u0002;
    private Label \u0003;
    private Label \u0004;
    private Label \u0005;
    private StatusStrip \u0001;
    private ToolStripStatusLabel \u0001;
    private ToolStripProgressBar \u0001;
    private ToolStripSeparator \u0003;
    private ToolStripLabel \u0002;
    private ToolStripTextBox \u0002;
    private ToolStripButton \u0006;
    private ToolStripDropDownButton \u0001;
    private ToolStripMenuItem \u0006;
    private ToolStripMenuItem \u0007;
    private ToolStripStatusLabel \u0002;
    private ToolStripStatusLabel \u0003;
    private ListView \u0001;
    private ListView \u0002;
    private ColumnHeader \u0001;
    private ColumnHeader \u0002;
    private new OpenFileDialog \u0001;
    private Panel \u0001;
    private Panel \u0002;
    private FolderBrowserDialog \u0001;
    private CheckBox \u0001;
    private ToolStripDropDownButton \u0002;
    private ToolStripMenuItem \u0008;
    private ToolStripMenuItem \u000E;
    private PictureBox \u0003;
    private PictureBox \u0004;
    private new SaveFileDialog \u0001;
    private ToolStripDropDownButton \u0003;
    private ToolStripMenuItem \u000F;
    private ToolStripMenuItem \u0010;
    private ToolStripDropDownButton \u0004;
    private ToolStripMenuItem \u0011;
    private ToolStripMenuItem \u0012;
    private ToolStripMenuItem \u0013;
    private ToolStripMenuItem \u0014;
    private ToolStripSeparator \u0004;
    private ToolStripMenuItem \u0015;
    private ToolStripSeparator \u0005;
    private ToolStripMenuItem \u0016;
    private ToolStripMenuItem \u0017;
    private ToolStripMenuItem \u0018;
    private ToolStripMenuItem \u0019;
    private ToolStripMenuItem \u001A;
    private \u0012 \u0001;
    private \u001E.\u001F \u0001;
    private \u007F.\u001F \u0001;
    private \u001C.\u001A \u0001;
    private \u0007 \u0001;
    private \u0007 \u0002;
    private volatile bool \u0001;
    private volatile bool \u0002;

    static \u001E()
    {
      \u0004.\u001D\u0005(typeof (\u007F.\u001E));
    }

    public \u001E()
    {
      this.\u0080\u0005();
      \u0080\u0086.\u0016\u008B((object) this, \u0013.Content_Icon);
      this.\u0001 = new \u001E.\u001F();
      // ISSUE: method pointer
      this.\u0001.Started += new EventHandler((object) this, __methodptr(\u0081\u0005));
      this.\u0001.Stopped += new EventHandler(this.\u0082\u0005);
      this.\u001E\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    private void \u0080\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u007F.\u001E)));
      this.\u0001 = new PropertyGrid();
      this.\u0001 = new MenuStrip();
      this.\u0001 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripMenuItem();
      this.\u0003 = new ToolStripMenuItem();
      this.\u0004 = new ToolStripSeparator();
      this.\u0004 = new ToolStripMenuItem();
      this.\u0015 = new ToolStripMenuItem();
      this.\u0005 = new ToolStripSeparator();
      this.\u0005 = new ToolStripMenuItem();
      this.\u0013 = new ToolStripMenuItem();
      this.\u0014 = new ToolStripMenuItem();
      this.\u0017 = new ToolStripMenuItem();
      this.\u0018 = new ToolStripMenuItem();
      this.\u0019 = new ToolStripMenuItem();
      this.\u001A = new ToolStripMenuItem();
      this.\u0001 = new ToolStrip();
      this.\u0001 = new ToolStripButton();
      this.\u0003 = new ToolStripDropDownButton();
      this.\u0010 = new ToolStripMenuItem();
      this.\u000F = new ToolStripMenuItem();
      this.\u0002 = new ToolStripButton();
      this.\u0002 = new ToolStripDropDownButton();
      this.\u0008 = new ToolStripMenuItem();
      this.\u000E = new ToolStripMenuItem();
      this.\u0001 = new ToolStripDropDownButton();
      this.\u0007 = new ToolStripMenuItem();
      this.\u0006 = new ToolStripMenuItem();
      this.\u0001 = new ToolStripSeparator();
      this.\u0001 = new ToolStripLabel();
      this.\u0001 = new ToolStripTextBox();
      this.\u0003 = new ToolStripButton();
      this.\u0002 = new ToolStripSeparator();
      this.\u0004 = new ToolStripButton();
      this.\u0005 = new ToolStripButton();
      this.\u0003 = new ToolStripSeparator();
      this.\u0004 = new ToolStripDropDownButton();
      this.\u0016 = new ToolStripMenuItem();
      this.\u0011 = new ToolStripMenuItem();
      this.\u0012 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripLabel();
      this.\u0002 = new ToolStripTextBox();
      this.\u0006 = new ToolStripButton();
      this.\u0001 = new PictureBox();
      this.\u0002 = new PictureBox();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0003 = new Label();
      this.\u0004 = new Label();
      this.\u0005 = new Label();
      this.\u0001 = new StatusStrip();
      this.\u0001 = new ToolStripProgressBar();
      this.\u0001 = new ToolStripStatusLabel();
      this.\u0002 = new ToolStripStatusLabel();
      this.\u0003 = new ToolStripStatusLabel();
      this.\u0001 = new ListView();
      this.\u0001 = new ColumnHeader();
      this.\u0002 = new ListView();
      this.\u0002 = new ColumnHeader();
      this.\u0001 = new OpenFileDialog();
      this.\u0001 = new Panel();
      this.\u0003 = new PictureBox();
      this.\u0002 = new Panel();
      this.\u0004 = new PictureBox();
      this.\u0001 = new FolderBrowserDialog();
      this.\u0001 = new CheckBox();
      this.\u0001 = new SaveFileDialog();
      this.\u0002 = new \u001C.\u001D();
      this.\u0001 = new \u001C.\u001D();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0002);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0003);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0002);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0004);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(5, 98));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u001E.\u0001(76583));
      \u0093\u001C.\u007E\u008B\u008E((object) this.\u0001, PropertySort.Alphabetical);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(180, 264));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u008D\u008E((object) this.\u0001, false);
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[4]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0013,
        (ToolStripItem) this.\u0017,
        (ToolStripItem) this.\u0019
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u001E.\u0001(76616));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(1134, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u007F.\u001E.\u0001(8895));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0001), new ToolStripItem[7]
      {
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0015,
        (ToolStripItem) this.\u0005,
        (ToolStripItem) this.\u0005
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u007F.\u001E.\u0001(76629));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(37, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u007F.\u001E.\u0001(8925));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u007F.\u001E.\u0001(76642));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0002, Keys.N | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(186, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u007F.\u001E.\u0001(8943));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler(this.\u009D\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u007F.\u001E.\u0001(76651));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0003, Keys.O | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(186, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u007F.\u001E.\u0001(8965));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(this.\u009E\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u007F.\u001E.\u0001(76664));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(183, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u007F.\u001E.\u0001(76677));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0004, Keys.S | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(186, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u007F.\u001E.\u0001(9016));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(this.\u009F\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0015, \u007F.\u001E.\u0001(76690));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0015, Keys.S | Keys.Shift | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0015, new Size(186, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0015, \u007F.\u001E.\u0001(76703));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0015, new EventHandler(this.\u0001\u0006));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u007F.\u001E.\u0001(76716));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(183, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u007F.\u001E.\u0001(76729));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0005, Keys.W | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(186, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u007F.\u001E.\u0001(9109));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(this.\u008B\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0013), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0014
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0013, \u007F.\u001E.\u0001(76742));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0013, new Size(39, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0013, \u007F.\u001E.\u0001(76755));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0014, \u007F.\u001E.\u0001(76764));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0014, new Size(182, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0014, \u007F.\u001E.\u0001(76801));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0014, new EventHandler(this.\u009C\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0017), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0018
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0017, \u007F.\u001E.\u0001(76830));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0017, new Size(53, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0017, \u007F.\u001E.\u0001(76843));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0018, \u007F.\u001E.\u0001(76856));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0018, new Size(152, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0018, \u007F.\u001E.\u0001(76869));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0018, new EventHandler(this.\u0004\u0006));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0019), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u001A
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0019, \u007F.\u001E.\u0001(9244));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0019, new Size(44, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0019, \u007F.\u001E.\u0001(9261));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u001A, \u007F.\u001E.\u0001(9270));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u001A, Keys.F1);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u001A, new Size(152, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u001A, \u007F.\u001E.\u0001(9291));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u001A, new EventHandler(this.\u0005\u0006));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[17]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0005,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0006
      });
      \u0087\u001C.\u007E\u0010\u0087((object) this.\u0001, ToolStripLayoutStyle.HorizontalStackWithOverflow);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 24));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u001E.\u0001(76878));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(1134, 38));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u007F.\u001E.\u0001(76887));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(76904)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0001, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u007F.\u001E.\u0001(76929));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(54, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u007F.\u001E.\u0001(76946));
      \u0010\u001D.\u007E\u0081\u0087((object) this.\u0001, TextImageRelation.ImageAboveText);
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0001, \u007F.\u001E.\u0001(76959));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0001, new EventHandler(this.\u0092\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0003), new ToolStripItem[2]
      {
        (ToolStripItem) this.\u0010,
        (ToolStripItem) this.\u000F
      });
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0003, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(76996)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0003, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u007F.\u001E.\u0001(77025));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(84, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u007F.\u001E.\u0001(77046));
      \u0010\u001D.\u007E\u0081\u0087((object) this.\u0003, TextImageRelation.ImageAboveText);
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0003, \u007F.\u001E.\u0001(77063));
      \u0087\u007F.\u007E\u0089\u008D((object) this.\u0003, new EventHandler(this.\u0099\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0010, \u007F.\u001E.\u0001(77100));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0010, new Size(160, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0010, \u007F.\u001E.\u0001(77046));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0010, new EventHandler(this.\u0098\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000F, \u007F.\u001E.\u0001(77121));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000F, new Size(160, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000F, \u007F.\u001E.\u0001(77146));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000F, new EventHandler(this.\u0097\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0002, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(77171)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0002, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u007F.\u001E.\u0001(77196));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(69, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u007F.\u001E.\u0001(77213));
      \u0010\u001D.\u007E\u0081\u0087((object) this.\u0002, TextImageRelation.ImageAboveText);
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0002, \u007F.\u001E.\u0001(77230));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler(this.\u0093\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0002), new ToolStripItem[2]
      {
        (ToolStripItem) this.\u0008,
        (ToolStripItem) this.\u000E
      });
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0002, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(77279)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0002, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u007F.\u001E.\u0001(77304));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(55, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u007F.\u001E.\u0001(77321));
      \u0010\u001D.\u007E\u0081\u0087((object) this.\u0002, TextImageRelation.ImageAboveText);
      \u0087\u007F.\u007E\u0089\u008D((object) this.\u0002, new EventHandler(this.\u0094\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0008, \u007F.\u001E.\u0001(77334));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0008, new Size(153, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0008, \u007F.\u001E.\u0001(77363));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0008, new EventHandler(this.\u0095\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000E, \u007F.\u001E.\u0001(77376));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000E, new Size(153, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000E, \u007F.\u001E.\u0001(77413));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000E, new EventHandler(this.\u0096\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0001), new ToolStripItem[2]
      {
        (ToolStripItem) this.\u0007,
        (ToolStripItem) this.\u0006
      });
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(77434)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0001, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u007F.\u001E.\u0001(77455));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(48, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u007F.\u001E.\u0001(77468));
      \u0010\u001D.\u007E\u0081\u0087((object) this.\u0001, TextImageRelation.ImageAboveText);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u007F.\u001E.\u0001(77477));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(134, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u007F.\u001E.\u0001(77494));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0007, new EventHandler(this.\u0002\u0006));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u007F.\u001E.\u0001(77511));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(134, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u007F.\u001E.\u0001(77528));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(this.\u0003\u0006));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u007F.\u001E.\u0001(77545));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(6, 38));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u007F.\u001E.\u0001(77554));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(66, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u007F.\u001E.\u0001(77575));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u007F.\u001E.\u0001(77592));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(100, 38));
      \u0087\u007F.\u007E\u0080\u0087((object) this.\u0001, new EventHandler(this.\u0084\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0003, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(77613)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0003, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u007F.\u001E.\u0001(77646));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(38, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u007F.\u001E.\u0001(12238));
      \u0010\u001D.\u007E\u0081\u0087((object) this.\u0003, TextImageRelation.ImageAboveText);
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0003, \u007F.\u001E.\u0001(77671));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(this.\u0083\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u007F.\u001E.\u0001(77700));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(6, 38));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0004, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(77709)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0004, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u007F.\u001E.\u0001(77738));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(61, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u007F.\u001E.\u0001(77759));
      \u0010\u001D.\u007E\u0081\u0087((object) this.\u0004, TextImageRelation.ImageAboveText);
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0004, \u007F.\u001E.\u0001(77772));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(this.\u0090\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0005, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(77849)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0005, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u007F.\u001E.\u0001(77870));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(74, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u007F.\u001E.\u0001(77883));
      \u0010\u001D.\u007E\u0081\u0087((object) this.\u0005, TextImageRelation.ImageAboveText);
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0005, \u007F.\u001E.\u0001(77900));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(this.\u0091\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u007F.\u001E.\u0001(77965));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(6, 38));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0004), new ToolStripItem[3]
      {
        (ToolStripItem) this.\u0016,
        (ToolStripItem) this.\u0011,
        (ToolStripItem) this.\u0012
      });
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0004, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(77974)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0004, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u007F.\u001E.\u0001(77995));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(59, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u007F.\u001E.\u0001(78008));
      \u0010\u001D.\u007E\u0081\u0087((object) this.\u0004, TextImageRelation.ImageAboveText);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0016, \u007F.\u001E.\u0001(78017));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0016, new Size(236, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0016, \u007F.\u001E.\u0001(78042));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0016, new EventHandler(this.\u008A\u0005));
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0011, false);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0011, \u007F.\u001E.\u0001(78067));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0011, new Size(236, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0011, \u007F.\u001E.\u0001(78092));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0011, new EventHandler(this.\u009A\u0005));
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0012, false);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0012, \u007F.\u001E.\u0001(78125));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0012, new Size(236, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0012, \u007F.\u001E.\u0001(78158));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0012, new EventHandler(this.\u009B\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u007F.\u001E.\u0001(78195));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(82, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u007F.\u001E.\u0001(78216));
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0002, false);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u007F.\u001E.\u0001(78237));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(100, 38));
      \u0087\u007F.\u007E\u0080\u0087((object) this.\u0002, new EventHandler(this.\u0087\u0005));
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0006, false);
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0006, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(78258)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0006, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u007F.\u001E.\u0001(78295));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(38, 35));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u007F.\u001E.\u0001(12238));
      \u0010\u001D.\u007E\u0081\u0087((object) this.\u0006, TextImageRelation.ImageAboveText);
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(this.\u0086\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u000E\u001F.\u007E\u0005\u0084((object) this.\u0001, new Size(224, 224));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u001E.\u0001(51113));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(224, 224));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.StretchImage);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 6);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(0, 0));
      \u000E\u001F.\u007E\u0005\u0084((object) this.\u0002, new Size(224, 224));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u007F.\u001E.\u0001(78324));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(224, 224));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0002, PictureBoxSizeMode.StretchImage);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0002, 6);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0002, false);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u007F.\u001E.\u0001(11283), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(427, 69));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u001E.\u0001(78349));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(123, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u007F.\u001E.\u0001(78370));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Right);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u007F.\u001E.\u0001(11283), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(657, 69));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u007F.\u001E.\u0001(78387));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(171, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u007F.\u001E.\u0001(55252));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u007F.\u001E.\u0001(11283), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(186, 69));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u007F.\u001E.\u0001(78412));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(50, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u007F.\u001E.\u0001(78425));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u007F.\u001E.\u0001(11283), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(0, 69));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u007F.\u001E.\u0001(78434));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(99, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u007F.\u001E.\u0001(78455));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0005, AnchorStyles.Top | AnchorStyles.Right);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u007F.\u001E.\u0001(11283), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(887, 69));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u007F.\u001E.\u0001(78472));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(75, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u007F.\u001E.\u0001(78008));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[4]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0003
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 370));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u001E.\u0001(78485));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(1134, 22));
      \u0099\u001F.\u007E\u001A\u008F((object) this.\u0001, false);
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 11);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u007F.\u001E.\u0001(78494));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(100, 16));
      \u0091\u001C.\u007E\u0091\u0090((object) this.\u0001, ProgressBarStyle.Marquee);
      \u0099\u001F.\u007E\u0083\u0087((object) this.\u0001, false);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u007F.\u001E.\u0001(78511));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(0, 17));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u007F.\u001E.\u0001(78536));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(0, 17));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u007F.\u001E.\u0001(78557));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(0, 17));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0006\u0084.\u007E\u0001\u008D((object) \u009B\u0082.\u007E\u0088\u008C((object) this.\u0001), new ColumnHeader[1]
      {
        this.\u0001
      });
      \u0099\u001F.\u007E\u0089\u008C((object) this.\u0001, true);
      \u0080\u0082.\u007E\u008B\u008C((object) this.\u0001, ColumnHeaderStyle.Nonclickable);
      \u0099\u001F.\u007E\u008C\u008C((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(892, 98));
      \u0099\u001F.\u007E\u008F\u008C((object) this.\u0001, false);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u001E.\u0001(78582));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(235, 264));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 13);
      \u0099\u001F.\u007E\u0093\u008C((object) this.\u0001, false);
      \u0017\u0080.\u007E\u0094\u008C((object) this.\u0001, View.Details);
      \u0087\u007F.\u007E\u0095\u008C((object) this.\u0001, new EventHandler(this.\u008D\u0005));
      \u0087\u007F.\u007E\u008B\u0084((object) this.\u0001, new EventHandler(this.\u008F\u0005));
      \u0092\u0081.\u007E\u008E\u0088((object) this.\u0001, \u007F.\u001E.\u0001(6340));
      \u0011\u001F.\u007E\u0090\u0088((object) this.\u0001, 210);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      \u0006\u0084.\u007E\u0001\u008D((object) \u009B\u0082.\u007E\u0088\u008C((object) this.\u0002), new ColumnHeader[1]
      {
        this.\u0002
      });
      \u0099\u001F.\u007E\u0089\u008C((object) this.\u0002, true);
      \u0080\u0082.\u007E\u008B\u008C((object) this.\u0002, ColumnHeaderStyle.Nonclickable);
      \u0099\u001F.\u007E\u008C\u008C((object) this.\u0002, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(191, 98));
      \u0099\u001F.\u007E\u008F\u008C((object) this.\u0002, false);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u007F.\u001E.\u0001(47448));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(235, 264));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 13);
      \u0099\u001F.\u007E\u0093\u008C((object) this.\u0002, false);
      \u0017\u0080.\u007E\u0094\u008C((object) this.\u0002, View.Details);
      \u0087\u007F.\u007E\u0095\u008C((object) this.\u0002, new EventHandler(this.\u008C\u0005));
      \u0087\u007F.\u007E\u008B\u0084((object) this.\u0002, new EventHandler(this.\u008E\u0005));
      \u0092\u0081.\u007E\u008E\u0088((object) this.\u0002, \u007F.\u001E.\u0001(6340));
      \u0011\u001F.\u007E\u0090\u0088((object) this.\u0002, 210);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0012\u0082.\u007E\u009C\u008A((object) this.\u0001, BorderStyle.FixedSingle);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(662, 98));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u001E.\u0001(78595));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(224, 224));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 14);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0003, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(78620)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(87, 87));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u007F.\u001E.\u0001(78665));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(48, 48));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0003, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0003, 7);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0003, false);
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0003, false);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Right);
      \u0012\u0082.\u007E\u009C\u008A((object) this.\u0002, BorderStyle.FixedSingle);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0001);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(432, 98));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u007F.\u001E.\u0001(51018));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(224, 224));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 15);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0004, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u001E.\u0001(51039)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(87, 87));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u007F.\u001E.\u0001(51080));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(48, 48));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0004, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0004, 7);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0004, false);
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0004, false);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0016\u001E.\u007E\u0001\u0088((object) this.\u0001, ContentAlignment.MiddleRight);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u007F.\u001E.\u0001(6354), 8f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(303, 78));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u001E.\u0001(78702));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(123, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 16);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u007F.\u001E.\u0001(78731));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0001, new EventHandler(this.\u0088\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Right);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u0008\u007F());
      \u0012\u0082.\u007E\u009D\u0090((object) this.\u0002, BorderStyle.FixedSingle);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(662, 328));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u007F.\u001E.\u0001(78760));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(224, 34));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 7);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0008\u007F());
      \u0012\u0082.\u007E\u009D\u0090((object) this.\u0001, BorderStyle.FixedSingle);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(432, 328));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u001E.\u0001(51260));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(224, 34));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 7);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(1134, 392));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u001A\u001D.\u0019\u008B((object) this, this.\u0001);
      \u000E\u001F.\u007E\u0005\u0084((object) this, new Size(2200, 430));
      \u000E\u001F.\u007E\u0007\u0084((object) this, new Size(1150, 430));
      \u0092\u0081.\u0010\u0084((object) this, \u007F.\u001E.\u0001(78777));
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u007F.\u001E.\u0001(78794));
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler(this.\u001E\u0005));
      \u0087\u007F.\u008E\u008B((object) this, new EventHandler(this.\u0089\u0005));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0002);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0003);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0002, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0002);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0004);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    protected override void \u001D\u0005(\u0084.\u001B fileName, bool modified)
    {
      if (!\u0084.\u001B.\u001D\u0005(fileName, (object) null))
      {
        if (modified)
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u009E\u0081.\u001F\u0093(\u007F.\u001E.\u0001(78969), (object) \u009C\u0080.\u0008\u009F(fileName.\u0002)));
        else
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0081\u0086.\u0086\u0093(\u007F.\u001E.\u0001(79026), \u009C\u0080.\u0008\u009F(fileName.\u0002)));
      }
      else if (modified)
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u007F.\u001E.\u0001(78843));
      else
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u007F.\u001E.\u0001(78908));
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    private void \u001D\u0005(\u001C.\u001A cp)
    {
      this.\u0001 = cp;
      this.\u0001 = new \u0012(this.\u0001);
      // ISSUE: method pointer
      this.\u0001.ModifiedStateChanged += new EventHandler<\u000F>((object) this, __methodptr(\u001D\u0005));
      \u008E\u007F.\u007E\u008C\u008E((object) this.\u0001, (object) this.\u0001);
      \u001A\u001E.\u007E\u001E\u0086((object) this.\u0001);
      this.\u0081\u0005();
    }

    private void \u0081\u0005()
    {
      this.\u001D\u0005((IEnumerable<ListViewItemState<string>>) this.\u0001.Keys);
    }

    private void \u001D\u0005(IEnumerable<ListViewItemState<string>> files)
    {
      IEnumerator<ListViewItemState<string>> enumerator = files.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          this.\u001D\u0005(enumerator.Current);
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
    }

    private void \u001D\u0005(ListViewItemState<string> item)
    {
      bool flag1 = this.\u0001.ContainsKey(item.State);
      bool flag2 = this.\u0001.Data.MultiFileData.ContainsKey(item.State);
      if (flag1)
      {
        if (flag2)
          \u0081\u0082.\u007E\u0019\u008D((object) item, \u009A\u0080.\u0005\u007F());
        else
          \u0081\u0082.\u007E\u0019\u008D((object) item, \u009A\u0080.\u009E\u001F());
      }
      else if (flag2)
        \u0081\u0082.\u007E\u0019\u008D((object) item, \u009A\u0080.\u0090\u001F());
      else
        \u0081\u0082.\u007E\u0019\u008D((object) item, \u009A\u0080.\u0098\u001F());
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      // ISSUE: method pointer
      \u001F.\u001A.\u001D\u0005(this, new MethodInvoker((object) this, __methodptr(\u0084\u0005)));
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      // ISSUE: method pointer
      \u001F.\u001A.\u001D\u0005(this, new MethodInvoker((object) this, __methodptr(\u0086\u0005)));
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, string.Empty);
      this.\u007F\u0005(false);
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      this.\u007F\u0005(false);
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, string.Empty);
      this.\u007F\u0005(false);
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      this.\u007F\u0005(false);
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      this.\u007F\u0005(false);
    }

    private void \u007F\u0005(bool insert)
    {
      if (!insert)
      {
        this.\u0001.\u001D\u0005(new Action<object>(this.\u001D\u0005), (object) new KeyValuePair<string, string>(\u0002\u007F.\u007E\u001F\u0087((object) this.\u0001), \u0002\u007F.\u007E\u001F\u0087((object) this.\u0002)));
      }
      else
      {
        // ISSUE: method pointer
        this.\u0001.\u001E\u0005(new Action<object>((object) this, __methodptr(\u001D\u0005)), (object) new KeyValuePair<string, string>(\u0002\u007F.\u007E\u001F\u0087((object) this.\u0001), \u0002\u007F.\u007E\u001F\u0087((object) this.\u0002)));
      }
    }

    private void \u001D\u0005(object state)
    {
      KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>) state;
      string key = keyValuePair.Key;
      string str = keyValuePair.Value;
      if (\u008F\u0084.\u009E\u0092(key) && \u008F\u0084.\u009E\u0092(str))
      {
        this.\u0001.\u001E\u0005(new Action<object>(this.\u007F\u0005), (object) this.\u0001.Keys.ToArray<ListViewItemState<string>>());
        this.\u0001.\u001E\u0005(new Action<object>(this.\u0080\u0005), (object) this.\u0002.Keys.ToArray<ListViewItemState<string>>());
      }
      else
      {
        if (!\u008F\u0084.\u009E\u0092(key))
        {
          if (!\u0016\u001D.\u007E\u0017\u0093((object) key, \u007F.\u001E.\u0001(79079)))
            key = \u0081\u0086.\u0086\u0093(\u007F.\u001E.\u0001(79079), key);
          if (!\u0016\u001D.\u007E\u0011\u0093((object) key, \u007F.\u001E.\u0001(79079)))
            key = \u0081\u0086.\u0086\u0093(key, \u007F.\u001E.\u0001(79079));
        }
        if (!\u008F\u0084.\u009E\u0092(str))
        {
          if (!\u0016\u001D.\u007E\u0017\u0093((object) str, \u007F.\u001E.\u0001(79079)))
            str = \u0081\u0086.\u0086\u0093(\u007F.\u001E.\u0001(79079), str);
          if (!\u0016\u001D.\u007E\u0011\u0093((object) str, \u007F.\u001E.\u0001(79079)))
            str = \u0081\u0086.\u0086\u0093(str, \u007F.\u001E.\u0001(79079));
        }
        this.\u0001.\u001E\u0005(new Action<object>(this.\u001E\u0005), (object) new KeyValuePair<string, string>(key, str));
      }
    }

    private void \u001E\u0005(object state)
    {
      KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>) state;
      List<ListViewItemState<string>> listViewItemStateList1 = (List<ListViewItemState<string>>) null;
      ListViewItemState<string>[] array1 = (ListViewItemState<string>[]) null;
      List<ListViewItemState<string>> listViewItemStateList2 = new List<ListViewItemState<string>>();
      ListViewItemState<string>[] array2;
      if (\u008F\u0084.\u009E\u0092(keyValuePair.Value))
      {
        if (this.\u0002.Count > 0)
          listViewItemStateList1 = new List<ListViewItemState<string>>();
        IEnumerator<KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>>> enumerator = this.\u0001.GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>> current = enumerator.Current;
            if (current.Key.State.\u001E\u0005(keyValuePair.Key))
            {
              listViewItemStateList2.Add(current.Key);
              if (listViewItemStateList1 != null)
              {
                foreach (ListViewItemState<string> listViewItemState in current.Value)
                {
                  if (!listViewItemStateList1.Contains(listViewItemState))
                    listViewItemStateList1.Add(listViewItemState);
                }
              }
            }
          }
        }
        finally
        {
          if (enumerator != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
        }
        array2 = listViewItemStateList2.ToArray();
        if (listViewItemStateList1 != null)
        {
          array1 = listViewItemStateList1.ToArray();
          Array.Sort<ListViewItemState<string>>(array1, (IComparer<ListViewItemState<string>>) \u0019.\u0016.Default);
        }
      }
      else if (\u008F\u0084.\u009E\u0092(keyValuePair.Key))
      {
        List<ListViewItemState<string>> listViewItemStateList3 = new List<ListViewItemState<string>>();
        IEnumerator<KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>>> enumerator = this.\u0002.GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>> current = enumerator.Current;
            if (current.Key.State.\u001E\u0005(keyValuePair.Value))
            {
              listViewItemStateList3.Add(current.Key);
              foreach (ListViewItemState<string> listViewItemState in current.Value)
              {
                if (!listViewItemStateList2.Contains(listViewItemState))
                  listViewItemStateList2.Add(listViewItemState);
              }
            }
          }
        }
        finally
        {
          if (enumerator != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
        }
        array2 = listViewItemStateList2.ToArray();
        array1 = listViewItemStateList3.ToArray();
        Array.Sort<ListViewItemState<string>>(array2, (IComparer<ListViewItemState<string>>) \u0019.\u0016.Default);
      }
      else
      {
        List<ListViewItemState<string>> listViewItemStateList3 = new List<ListViewItemState<string>>();
        IEnumerator<KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>>> enumerator = this.\u0002.GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>> current = enumerator.Current;
            if (current.Key.State.\u001E\u0005(keyValuePair.Value))
            {
              listViewItemStateList3.Add(current.Key);
              foreach (ListViewItemState<string> listViewItemState in current.Value)
              {
                if (listViewItemState.State.\u001E\u0005(keyValuePair.Key) && !listViewItemStateList2.Contains(listViewItemState))
                  listViewItemStateList2.Add(listViewItemState);
              }
            }
          }
        }
        finally
        {
          if (enumerator != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
        }
        array2 = listViewItemStateList2.ToArray();
        array1 = listViewItemStateList3.ToArray();
        Array.Sort<ListViewItemState<string>>(array2, (IComparer<ListViewItemState<string>>) \u0019.\u0016.Default);
      }
      if (array1 == null)
        this.\u0001.\u001E\u0005(new Action<object>(this.\u0080\u0005), (object) this.\u0002.Keys.ToArray<ListViewItemState<string>>());
      else
        this.\u0001.\u001E\u0005(new Action<object>(this.\u0080\u0005), (object) array1);
      this.\u0001.\u001E\u0005(new Action<object>(this.\u007F\u0005), (object) array2);
    }

    private void \u0089\u0005(object sender, EventArgs e)
    {
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u001F\u0005)));
    }

    private void \u001F\u0005(object state)
    {
      string[] strArray = \u0012.\u001D\u0005(\u001A.\u007F.ToonTownOpenDataDirectory, \u007F.\u001E.\u0001(79084), \u007F.\u001E.\u0001(53416));
      \u001D.\u0001 connectSettings = \u0081.\u0080.Instance.ConnectSettings;
      foreach (string str1 in strArray)
      {
        string str2 = \u009C\u0080.\u000E\u009F(str1);
        if (\u001E.\u007F.\u001E\u0005(str2))
        {
          Stream str3 = (Stream) null;
          \u001E.\u007F obj = (\u001E.\u007F) null;
          string str4 = str1;
          if (connectSettings.SpoofedToonTownEnabled)
          {
            string str5 = \u0081\u0086.\u0086\u0093(str1, \u007F.\u001E.\u0001(57327));
            if (\u008F\u0084.\u0092\u009E(str5))
              str4 = str5;
          }
          try
          {
            str3 = (Stream) \u008F\u001C.\u0093\u009E(str4, FileMode.Open, FileAccess.Read, FileShare.None);
            obj = new \u001E.\u007F(str3);
            obj.\u0082\u0005();
            this.\u0001.Add(str2, obj);
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005((object) \u0081\u0086.\u0086\u0093(\u007F.\u001E.\u0001(79101), str4));
            if (str3 != null)
              \u001A\u001E.\u007E\u0086\u009D((object) str3);
            if (obj != null)
              obj.Dispose();
          }
        }
      }
      HashSet<string> source = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      foreach (\u001E.\u007F obj in this.\u0001.Values)
      {
        IEnumerator<string> enumerator = obj.MultiFileData.Keys.GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            string current = enumerator.Current;
            if (!source.Contains(current) && \u001E.\u007F.\u001F\u0005(current))
              source.Add(current);
          }
        }
        finally
        {
          if (enumerator != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
        }
      }
      string[] array = source.ToArray<string>();
      Array.Sort<string>(array, (IComparer<string>) \u0003.Default);
      foreach (string str in array)
      {
        ListViewItemState<string> key = new ListViewItemState<string>(str);
        this.\u0001.Add(str, key);
        this.\u0001.Add(key, new HashSet<ListViewItemState<string>>());
      }
      IEnumerator<ListViewItemState<string>> enumerator1 = this.\u0001.Keys.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator1))
          \u0081\u0082.\u007E\u0019\u008D((object) enumerator1.Current, \u009A\u0080.\u0098\u001F());
      }
      finally
      {
        if (enumerator1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator1);
      }
      this.\u0001.\u001E\u0005(new Action<object>(this.\u007F\u0005), (object) this.\u0001.Keys.ToArray<ListViewItemState<string>>());
    }

    private void \u007F\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) new \u007F.\u001E.\u0002()
      {
        \u0001 = this,
        \u0001 = (state as ListViewItemState<string>[])
      }, __methodptr(\u001D\u0005)));
    }

    private void \u0080\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) new \u007F.\u001E.\u0003()
      {
        \u0001 = this,
        \u0001 = (state as ListViewItemState<string>[])
      }, __methodptr(\u001D\u0005)));
    }

    private void \u008A\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0016, false);
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0081\u0005)));
    }

    private void \u0081\u0005(object state)
    {
      Dictionary<string, KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>>> dictionary = new Dictionary<string, KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>>>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      foreach (\u001E.\u007F obj in this.\u0001.Values)
      {
        IEnumerator<KeyValuePair<string, \u001D.\u001B>> enumerator = ((IEnumerable<KeyValuePair<string, \u001D.\u001B>>) obj.MultiFileData).GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            KeyValuePair<string, \u001D.\u001B> current = enumerator.Current;
            if (\u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0019\u0093((object) \u009C\u0080.\u0006\u009F(current.Key)), \u007F.\u001E.\u0001(79150)))
            {
              obj.\u001D\u0005(current.Value);
              HashSet<string> stringSet = \u0017.\u0017.\u001D\u0005(current.Value.Data);
              current.Value.Data = (byte[]) null;
              if (stringSet != null)
              {
                ListViewItemState<string> key1 = new ListViewItemState<string>(current.Key);
                HashSet<ListViewItemState<string>> listViewItemStateSet = new HashSet<ListViewItemState<string>>();
                foreach (string key2 in stringSet)
                {
                  if (this.\u0001.ContainsKey(key2))
                  {
                    ListViewItemState<string> index = this.\u0001[key2];
                    this.\u0001[index].Add(key1);
                    listViewItemStateSet.Add(index);
                  }
                }
                dictionary.Add(current.Key, new KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>>(key1, listViewItemStateSet));
              }
            }
          }
        }
        finally
        {
          if (enumerator != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
        }
      }
      string[] array = dictionary.Keys.ToArray<string>();
      Array.Sort<string>(array, (IComparer<string>) \u0003.Default);
      foreach (string index in array)
        this.\u0002.Add(dictionary[index]);
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, (MethodInvoker) (() => this.\u0001.\u001E\u0005(new Action<object>((object) this, __methodptr(\u001D\u0005)), (object) new KeyValuePair<string, string>(\u0002\u007F.\u007E\u001F\u0087((object) this.\u0001), \u0002\u007F.\u007E\u001F\u0087((object) this.\u0002)))));
    }

    private void \u008B\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001E\u0005(object sender, FormClosingEventArgs e)
    {
      if (\u0099\u0082.\u007E\u0086\u0001\u0002((object) e))
        return;
      this.PromptToSaveOnClose = false;
      if (this.\u0002)
      {
        \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, !this.\u0001);
      }
      else
      {
        this.\u0002 = true;
        \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
        this.\u0001.\u001D\u0005(new Action<object>(this.\u0082\u0005));
      }
    }

    private void \u0082\u0005(object state)
    {
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) this, __methodptr(\u0088\u0005)));
    }

    private void \u008C\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      this.\u0080\u0005(false);
    }

    private void \u008D\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      this.\u0082\u0005();
    }

    private void \u0082\u0005()
    {
      if (\u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) == 0)
      {
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, string.Empty);
        \u0099\u001F.\u007E\u0018\u0087((object) this.\u0012, false);
        \u0099\u001F.\u007E\u0018\u0087((object) this.\u0011, false);
      }
      else
      {
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u001F\u0082.\u0087\u0093(\u007F.\u001E.\u0001(79159), (\u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0) as ListViewItemState<string>).State, \u007F.\u001E.\u0001(32397)));
        \u0099\u001F.\u007E\u0018\u0087((object) this.\u0012, true);
        \u0099\u001F.\u007E\u0018\u0087((object) this.\u0011, true);
      }
    }

    private void \u0080\u0005(bool insert)
    {
      if (insert)
      {
        if (\u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002)) == 0)
        {
          // ISSUE: method pointer
          this.\u0001.\u001E\u0005(new Action<object>((object) this, __methodptr(\u0084\u0005)));
        }
        else
        {
          // ISSUE: method pointer
          this.\u0001.\u001E\u0005(new Action<object>((object) this, __methodptr(\u0084\u0005)), (object) (\u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0) as ListViewItemState<string>).State);
        }
      }
      else if (\u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002)) == 0)
        this.\u0001.\u001D\u0005(new Action<object>(this.\u0084\u0005));
      else
        this.\u0001.\u001D\u0005(new Action<object>(this.\u0084\u0005), (object) (\u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0) as ListViewItemState<string>).State);
    }

    private void \u0083\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) new \u007F.\u001E.\u0004()
      {
        \u0001 = this,
        \u0001 = (state as string)
      }, __methodptr(\u001D\u0005)));
    }

    private void \u0084\u0005(object state)
    {
      string index = state as string;
      // ISSUE: method pointer
      this.\u0001.\u001E\u0005(new Action<object>((object) this, __methodptr(\u0083\u0005)), state);
      if (!\u008F\u0084.\u009E\u0092(index))
      {
        byte[] numArray1 = this.\u001D\u0005(index);
        if (numArray1 == null)
          return;
        byte[] numArray2 = (byte[]) null;
        if (this.\u0001.Data.MultiFileData.ContainsKey(index))
          numArray2 = this.\u0001.Data.MultiFileData[index].Data;
        switch (\u001E.\u007F.\u001D\u0005(index))
        {
          case \u001C.\u0017.\u0002:
            if (numArray2 == null)
              this.\u0001.\u001E\u0005(new Action<object>(this.\u0086\u0005), (object) \u007F.\u001F.\u001D\u0005((byte[]) null, numArray1));
            else
              this.\u0001.\u001E\u0005(new Action<object>(this.\u0086\u0005), (object) \u007F.\u001F.\u001D\u0005(numArray2, numArray1));
            this.\u0001.\u001E\u0005(new Action<object>(this.\u0087\u0005));
            break;
          case \u001C.\u0017.\u0003:
            MemoryStream memoryStream1 = new MemoryStream(numArray1);
            try
            {
              if (numArray2 == null)
              {
                this.\u0001.\u001E\u0005(new Action<object>(this.\u0086\u0005), (object) new \u007F.\u001F((Bitmap) null, \u0082.\u0017.\u001D\u0005((Stream) memoryStream1)));
              }
              else
              {
                MemoryStream memoryStream2 = new MemoryStream(numArray2);
                try
                {
                  this.\u0001.\u001E\u0005(new Action<object>(this.\u0086\u0005), (object) new \u007F.\u001F(\u0082.\u0017.\u001D\u0005((Stream) memoryStream2), \u0082.\u0017.\u001D\u0005((Stream) memoryStream1)));
                }
                finally
                {
                  if (memoryStream2 != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) memoryStream2);
                }
              }
            }
            finally
            {
              if (memoryStream1 != null)
                \u001A\u001E.\u007E\u0094\u0092((object) memoryStream1);
            }
            this.\u0001.\u001E\u0005(new Action<object>(this.\u0087\u0005));
            break;
          case \u001C.\u0017.\u0004:
          case \u001C.\u0017.\u0005:
          case \u001C.\u0017.\u0006:
            this.\u0001.\u001E\u0005(new Action<object>(this.\u0087\u0005), (object) new \u001D.\u0081(index, numArray2, numArray1));
            this.\u0001.\u001E\u0005(new Action<object>(this.\u0086\u0005));
            break;
        }
      }
      else
      {
        this.\u0001.\u001E\u0005(new Action<object>(this.\u0087\u0005));
        this.\u0001.\u001E\u0005(new Action<object>(this.\u0086\u0005));
      }
    }

    private void \u0086\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) new \u007F.\u001E.\u0005()
      {
        \u0001 = this,
        \u0001 = (state as \u007F.\u001F)
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(\u007F.\u001F gr)
    {
      if (gr == null || gr.UserGraphicData == null)
      {
        \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) null);
      }
      else
      {
        \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) gr.UserGraphicData);
        \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, \u0083\u001E.\u007E\u001F\u001F((object) \u000E\u0086.\u007E\u001D\u008E((object) this.\u0001)).\u001D\u0005(224, 244));
      }
      if (gr == null || gr.ToonTownGraphicData == null)
      {
        \u0087\u0081.\u007E\u001E\u008E((object) this.\u0002, (Image) null);
      }
      else
      {
        \u0087\u0081.\u007E\u001E\u008E((object) this.\u0002, (Image) gr.ToonTownGraphicData);
        \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, \u0083\u001E.\u007E\u001F\u001F((object) \u000E\u0086.\u007E\u001D\u008E((object) this.\u0002)).\u001D\u0005(224, 244));
      }
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      this.\u0001 = gr;
    }

    private void \u0087\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) new \u007F.\u001E.\u0006()
      {
        \u0001 = this,
        \u0001 = (state as \u001D.\u0081)
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(\u001D.\u0081 audioData)
    {
      if (audioData != null)
      {
        if (audioData.UserAudioData == null)
          this.\u0001.\u001F\u0005();
        else
          this.\u0001.\u001D\u0005(audioData.AudioFile, audioData.UserAudioData);
        if (audioData.ToonTownAudioData == null)
          this.\u0002.\u001F\u0005();
        else
          this.\u0002.\u001D\u0005(audioData.AudioFile, audioData.ToonTownAudioData);
        \u0099\u001F.\u007E\u0082\u0084((object) this.\u0004, true);
        \u0099\u001F.\u007E\u0082\u0084((object) this.\u0003, true);
      }
      else
      {
        this.\u0001.\u001F\u0005();
        this.\u0002.\u001F\u0005();
        \u0099\u001F.\u007E\u0082\u0084((object) this.\u0004, false);
        \u0099\u001F.\u007E\u0082\u0084((object) this.\u0003, false);
      }
    }

    private \u001D.\u001B \u001D\u0005(string file)
    {
      string multifile_name;
      if (!\u001E.\u007F.\u001D\u0005(file, out multifile_name))
        return (\u001D.\u001B) null;
      if (!this.\u0001.ContainsKey(multifile_name))
        return (\u001D.\u001B) null;
      \u001E.\u007F obj = this.\u0001[multifile_name];
      if (!obj.MultiFileData.ContainsKey(file))
        return (\u001D.\u001B) null;
      \u001D.\u001B data = obj.MultiFileData[file];
      obj.\u001D\u0005(data);
      return data;
    }

    private byte[] \u001D\u0005(string file)
    {
      \u001D.\u001B obj = this.\u001D\u0005(file);
      if (obj == null)
        return (byte[]) null;
      byte[] data = obj.Data;
      obj.Data = (byte[]) null;
      return data;
    }

    private void \u008E\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 || \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002)) <= 0)
        return;
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, (\u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0) as ListViewItemState<string>).State);
    }

    private void \u008F\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 || \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) <= 0)
        return;
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, (\u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0) as ListViewItemState<string>).State);
    }

    private void \u0090\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0088\u0005)));
    }

    private void \u0088\u0005(object state)
    {
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) this, __methodptr(\u0089\u0005)));
    }

    private void \u0091\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0089\u0005)));
    }

    private void \u0089\u0005(object state)
    {
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) this, __methodptr(\u008A\u0005)));
    }

    private void \u0092\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 || \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002)) != 1)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u008A\u0005)), (object) \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0));
    }

    private void \u008A\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) new \u007F.\u001E.\u0007()
      {
        \u0001 = this,
        \u0001 = (state as ListViewItemState<string>)
      }, __methodptr(\u001D\u0005)));
    }

    private void \u0093\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u008B\u0005)));
    }

    private void \u008B\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u007F.\u001E.\u0008 obj1 = new \u007F.\u001E.\u0008();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = (string) null;
      // ISSUE: method pointer
      if (!this.\u001D\u0005<bool>(new Func<bool>((object) obj1, __methodptr(\u001D\u0005))))
        return;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u007F.\u001E.\u000E obj2 = new \u007F.\u001E.\u000E();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      DirectoryInfo directoryInfo1 = new DirectoryInfo(obj1.\u0001);
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new HashSet<ListViewItemState<string>>();
      if (\u001E.\u007F.\u001E\u0005(\u0002\u007F.\u007E\u0084\u009E((object) directoryInfo1)))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.\u001D\u0005(obj1.\u0001, \u0002\u007F.\u007E\u0084\u009E((object) directoryInfo1), obj2.\u0001);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        foreach (string str in \u009A\u0084.\u007F\u009E(obj1.\u0001))
        {
          DirectoryInfo directoryInfo2 = new DirectoryInfo(str);
          if (\u001E.\u007F.\u001E\u0005(\u0002\u007F.\u007E\u0084\u009E((object) directoryInfo2)))
          {
            // ISSUE: reference to a compiler-generated field
            this.\u001D\u0005(str, \u0002\u007F.\u007E\u0084\u009E((object) directoryInfo2), obj2.\u0001);
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker(obj2.\u001D\u0005));
    }

    private void \u001D\u0005(string parentFolder, string multiFileName, HashSet<ListViewItemState<string>> changedFiles)
    {
      string str = \u0081\u0086.\u0011\u009F(parentFolder, \u007F.\u001E.\u0001(31287));
      string folder1 = \u0081\u0086.\u0011\u009F(str, \u007F.\u001E.\u0001(31305));
      string folder2 = \u0081\u0086.\u0011\u009F(str, \u007F.\u001E.\u0001(31310));
      string folder3 = \u0081\u0086.\u0011\u009F(str, \u007F.\u001E.\u0001(31319));
      string folder4 = \u0081\u0086.\u0011\u009F(parentFolder, \u007F.\u001E.\u0001(31296));
      if (\u008F\u0084.\u001D\u009E(folder1))
        this.\u001E\u0005(folder1, \u0081\u0086.\u0011\u009F(\u0081\u0086.\u0011\u009F(multiFileName, \u007F.\u001E.\u0001(31287)), \u007F.\u001E.\u0001(31305)), changedFiles);
      if (\u008F\u0084.\u001D\u009E(folder2))
        this.\u001E\u0005(folder2, \u0081\u0086.\u0011\u009F(\u0081\u0086.\u0011\u009F(multiFileName, \u007F.\u001E.\u0001(31287)), \u007F.\u001E.\u0001(31310)), changedFiles);
      if (\u008F\u0084.\u001D\u009E(folder3))
        this.\u001E\u0005(folder3, \u0081\u0086.\u0011\u009F(\u0081\u0086.\u0011\u009F(multiFileName, \u007F.\u001E.\u0001(31287)), \u007F.\u001E.\u0001(31319)), changedFiles);
      if (!\u008F\u0084.\u001D\u009E(folder4))
        return;
      this.\u001E\u0005(folder4, \u0081\u0086.\u0011\u009F(multiFileName, \u007F.\u001E.\u0001(31296)), changedFiles);
    }

    private void \u001E\u0005(string folder, string relativeFolder, HashSet<ListViewItemState<string>> changedFiles)
    {
      // ISSUE: unable to decompile the method.
    }

    private void \u0094\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u000E, false);
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0008, false);
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u008C\u0005)));
    }

    private void \u008C\u0005(object state)
    {
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) this, __methodptr(\u008B\u0005)));
    }

    private void \u0095\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 || \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002)) <= 0)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u008D\u0005)), (object) \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0));
    }

    private void \u008D\u0005(object state)
    {
      ListViewItemState<string> listViewItemState = state as ListViewItemState<string>;
      if (!this.\u0001.Data.\u007F\u0005(listViewItemState.State))
        return;
      \u001D.\u001B obj = this.\u0001.Data[listViewItemState.State];
      this.\u001D\u0005(listViewItemState.State, obj.Data);
    }

    private void \u0096\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 || \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002)) <= 0)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u008E\u0005)), (object) \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0));
    }

    private void \u008E\u0005(object state)
    {
      ListViewItemState<string> listViewItemState = state as ListViewItemState<string>;
      byte[] data = this.\u001D\u0005(listViewItemState.State);
      if (data == null)
        return;
      this.\u001D\u0005(listViewItemState.State, data);
    }

    private void \u001D\u0005(string file, byte[] data)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u007F.\u001E.\u000F obj = new \u007F.\u001E.\u000F();
      // ISSUE: reference to a compiler-generated field
      obj.\u0002 = file;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = this;
      if (data == null)
        return;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = \u001E.\u007F.\u001D\u0005(obj.\u0002);
      // ISSUE: reference to a compiler-generated field
      if (obj.\u0001 == \u001C.\u0017.\u0001)
        return;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = (string) null;
      // ISSUE: reference to a compiler-generated method
      if (!this.\u001D\u0005<bool>(new Func<bool>(obj.\u001D\u0005)))
        return;
      // ISSUE: reference to a compiler-generated field
      switch (obj.\u0001)
      {
        case \u001C.\u0017.\u0002:
        case \u001C.\u0017.\u0004:
        case \u001C.\u0017.\u0005:
        case \u001C.\u0017.\u0006:
          // ISSUE: reference to a compiler-generated field
          \u0012.\u001D\u0005(obj.\u0001, data);
          break;
        case \u001C.\u0017.\u0003:
          string str;
          // ISSUE: reference to a compiler-generated field
          if ((str = \u0002\u007F.\u007E\u0019\u0093((object) \u009C\u0080.\u0006\u009F(obj.\u0001))) != null)
          {
            if (!\u0008\u001F.\u009A\u0092(str, \u007F.\u001E.\u0001(44723)))
            {
              if (\u0008\u001F.\u009A\u0092(str, \u007F.\u001E.\u0001(79201)))
              {
                MemoryStream memoryStream = new MemoryStream(data);
                try
                {
                  Bitmap image = \u0082.\u0017.\u001D\u0005((Stream) memoryStream);
                  try
                  {
                    // ISSUE: reference to a compiler-generated field
                    Stream image_stream = (Stream) \u008F\u001C.\u0093\u009E(obj.\u0001, FileMode.Create, FileAccess.Write, FileShare.None);
                    try
                    {
                      \u0008.\u001D\u0005(image, image_stream, 100);
                      break;
                    }
                    finally
                    {
                      if (image_stream != null)
                        \u001A\u001E.\u007E\u0094\u0092((object) image_stream);
                    }
                  }
                  finally
                  {
                    if (image != null)
                      \u001A\u001E.\u007E\u0094\u0092((object) image);
                  }
                }
                finally
                {
                  if (memoryStream != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
                }
              }
            }
            else
            {
              MemoryStream memoryStream = new MemoryStream(data);
              try
              {
                Bitmap image = \u0082.\u0017.\u001D\u0005((Stream) memoryStream);
                try
                {
                  // ISSUE: reference to a compiler-generated field
                  Stream image_stream = (Stream) \u008F\u001C.\u0093\u009E(obj.\u0001, FileMode.Create, FileAccess.Write, FileShare.None);
                  try
                  {
                    \u0008.\u001E\u0005(image, image_stream, 100);
                    break;
                  }
                  finally
                  {
                    if (image_stream != null)
                      \u001A\u001E.\u007E\u0094\u0092((object) image_stream);
                  }
                }
                finally
                {
                  if (image != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) image);
                }
              }
              finally
              {
                if (memoryStream != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
              }
            }
          }
          // ISSUE: reference to a compiler-generated field
          \u0012.\u001D\u0005(obj.\u0001, data);
          break;
      }
    }

    private void \u0097\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u008F\u0005)));
    }

    private void \u008F\u0005(object state)
    {
      if (this.\u001D\u0005<bool>((Func<bool>) (() => \u0018.\u0017.\u001E\u0005(\u007F.\u001E.\u0001(79697), \u007F.\u001E.\u0001(79790), \u0018.\u0016.\u0006, \u0018.\u0016.\u0007) == DialogResult.Yes)))
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u007F.\u001E.\u0010 obj1 = new \u007F.\u001E.\u0010();
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = this;
        string[] array = this.\u0001.Data.MultiFileData.Keys.ToArray<string>();
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = new HashSet<ListViewItemState<string>>();
        foreach (string name in array)
        {
          \u001D.\u001B obj2 = this.\u0001.Data[name];
          this.\u0001.Data.\u001D\u0005(name);
          obj2.Data = (byte[]) null;
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001.Add(this.\u0001[name]);
        }
        // ISSUE: reference to a compiler-generated field
        if (obj1.\u0001.Count > 0)
        {
          this.\u0001.Modified = true;
          // ISSUE: reference to a compiler-generated method
          \u001F.\u001A.\u001E\u0005(this, new MethodInvoker(obj1.\u001D\u0005));
        }
        \u001F.\u001A.\u001E\u0005(this, (MethodInvoker) (() => this.\u0080\u0005(true)));
      }
      this.\u007F\u0005(true);
    }

    private void \u0098\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 || \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002)) != 1)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0090\u0005)), (object) \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0002), 0));
    }

    private void \u0090\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) new \u007F.\u001E.\u0011()
      {
        \u0001 = state,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
      this.\u007F\u0005(true);
    }

    private void \u0099\u0005(object sender, EventArgs e)
    {
      \u0099\u001F obj = \u0099\u001F.\u007E\u0018\u0087;
      ToolStripMenuItem toolStripMenuItem = this.\u000F;
      bool flag;
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0010, flag = false);
      int num = flag ? 1 : 0;
      obj((object) toolStripMenuItem, num != 0);
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0091\u0005)));
    }

    private void \u0091\u0005(object state)
    {
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) this, __methodptr(\u008D\u0005)));
    }

    private void \u009A\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 || \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) <= 0)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0092\u0005)), (object) \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0));
    }

    private void \u0092\u0005(object state)
    {
      ListViewItemState<string> index = state as ListViewItemState<string>;
      // ISSUE: method pointer
      if (!this.\u001D\u0005<bool>(new Func<bool>((object) this, __methodptr(\u0084\u0005))))
        return;
      \u001D.\u001B mfd = this.\u001D\u0005(index.State);
      if (mfd == null)
        return;
      string str1 = \u0081\u0086.\u0011\u009F(\u001A.\u007F.ToonTownContent_TempFolder, \u009C\u0080.\u0008\u009F(index.State));
      HashSet<string> imagePaths = new HashSet<string>();
      HashSet<string> directories = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      imagePaths.Add(str1);
      mfd.\u001D\u0005(str1);
      foreach (ListViewItemState<string> listViewItemState in this.\u0002[index])
      {
        string path = \u0081\u0086.\u0011\u009F(\u001A.\u007F.ToonTownContent_TempFolder, listViewItemState.State);
        string str2 = \u009C\u0080.\u0005\u009F(path);
        if (!directories.Contains(str2))
          directories.Add(str2);
        imagePaths.Add(path);
        (!this.\u0001.Data.\u007F\u0005(listViewItemState.State) ? this.\u001D\u0005(listViewItemState.State) : this.\u0001.Data[listViewItemState.State]).\u001D\u0005(path);
      }
      \u000E.\u001D\u0005(new \u0008(str1, imagePaths, directories));
    }

    private void \u009B\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 || \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) <= 0)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0093\u0005)), (object) \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0));
    }

    private void \u0093\u0005(object state)
    {
      ListViewItemState<string> index = state as ListViewItemState<string>;
      // ISSUE: method pointer
      if (!this.\u001D\u0005<bool>(new Func<bool>((object) this, __methodptr(\u0086\u0005))))
        return;
      \u001D.\u001B mfd = this.\u001D\u0005(index.State);
      if (mfd == null)
        return;
      string str1 = \u0081\u0086.\u0011\u009F(\u001A.\u007F.ToonTownContent_TempFolder, \u009C\u0080.\u0008\u009F(index.State));
      HashSet<string> imagePaths = new HashSet<string>();
      HashSet<string> directories = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      imagePaths.Add(str1);
      mfd.\u001D\u0005(str1);
      foreach (ListViewItemState<string> listViewItemState in this.\u0002[index])
      {
        string path = \u0081\u0086.\u0011\u009F(\u001A.\u007F.ToonTownContent_TempFolder, listViewItemState.State);
        string str2 = \u009C\u0080.\u0005\u009F(path);
        if (!directories.Contains(str2))
          directories.Add(str2);
        imagePaths.Add(path);
        this.\u001D\u0005(listViewItemState.State).\u001D\u0005(path);
      }
      \u000E.\u001D\u0005(new \u0008(str1, imagePaths, directories));
    }

    private void \u009C\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      this.\u0082\u0005();
    }

    private bool \u0081\u0005()
    {
      if (!\u008F\u0084.\u009E\u0092(\u0081.\u0080.Instance.MakePackageSettings.Panda3dPath) && \u008F\u0084.\u0092\u009E(\u0081.\u0080.Instance.MakePackageSettings.Panda3dPath))
        return true;
      return this.\u0082\u0005();
    }

    private bool \u0082\u0005()
    {
      \u0092\u0081.\u007E\u0099\u008A((object) this.\u0001, \u007F.\u001E.\u0001(79210));
      \u0092\u0081.\u007E\u0095\u008A((object) this.\u0001, \u007F.\u001E.\u0001(79279));
      \u0011\u001F.\u007E\u0097\u008A((object) this.\u0001, 1);
      if (\u008F\u0084.\u009E\u0092(\u0081.\u0080.Instance.MakePackageSettings.Panda3dPath))
      {
        \u0092\u0081.\u007E\u0093\u008A((object) this.\u0001, \u007F.\u001E.\u0001(79300));
      }
      else
      {
        \u0092\u0081.\u007E\u0098\u008A((object) this.\u0001, \u009C\u0080.\u0005\u009F(\u0081.\u0080.Instance.MakePackageSettings.Panda3dPath));
        \u0092\u0081.\u007E\u0093\u008A((object) this.\u0001, \u009C\u0080.\u0008\u009F(\u0081.\u0080.Instance.MakePackageSettings.Panda3dPath));
      }
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK)
        return false;
      \u0081.\u0080.Instance.MakePackageSettings.Panda3dPath = \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001);
      \u0081.\u0080.\u001D\u0005();
      return true;
    }

    private void \u009D\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0098\u0005)));
    }

    protected override void \u001D\u0005()
    {
      this.\u001D\u0005(new \u001C.\u001A());
      if (!\u0099\u0082.\u009A\u0083((object) this))
        return;
      this.\u007F\u0005(false);
    }

    private void \u009E\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0099\u0005)));
    }

    protected override bool \u001E\u0005(\u0084.\u001B fileName)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u007F.\u001E.\u0012 obj1 = new \u007F.\u001E.\u0012();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = (\u001C.\u001A) null;
      try
      {
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = new \u001C.\u001A(fileName.\u0002, true, true);
      }
      catch (Exception ex)
      {
        \u0018.\u0017.\u001D\u0005(ex, fileName.\u0002);
        return false;
      }
      // ISSUE: reference to a compiler-generated field
      if (\u0080.\u0016.\u001E\u0005(obj1.\u0001.PasswordHash, \u0080.\u0016.\u0001))
      {
        \u0008 obj2 = new \u0008();
        try
        {
          \u0092\u0081.\u007E\u001D\u0084((object) obj2, \u007F.\u001E.\u0001(79313));
          obj2.LabelMessage = \u007F.\u001E.\u0001(79334);
          obj2.PasswordTextBox = true;
          // ISSUE: reference to a compiler-generated method
          obj2.InputValidating += new EventHandler<\u0011<string>>(obj1.\u001D\u0005);
          if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) == DialogResult.OK)
          {
            // ISSUE: reference to a compiler-generated field
            obj1.\u0001.Password = obj2.Value;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            obj1.\u0001.Dispose();
            // ISSUE: reference to a compiler-generated field
            obj1.\u0001 = (\u001C.\u001A) null;
            return false;
          }
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      Dictionary<ListViewItemState<string>, \u001D.\u001B> data = new Dictionary<ListViewItemState<string>, \u001D.\u001B>((IEqualityComparer<ListViewItemState<string>>) \u007F.\u001A.\u0001);
      // ISSUE: reference to a compiler-generated field
      IEnumerator<string> enumerator = obj1.\u0001.Data.MultiFileData.Keys.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          string current = enumerator.Current;
          if (!this.\u0001.ContainsKey(current))
          {
            // ISSUE: reference to a compiler-generated field
            data.Add(new ListViewItemState<string>(current), obj1.\u0001.Data[current]);
          }
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      if (data.Count > 0)
      {
        \u0019.\u001B obj2 = new \u0019.\u001B(data);
        try
        {
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2);
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
        data.Clear();
      }
      // ISSUE: reference to a compiler-generated field
      this.\u001D\u0005(obj1.\u0001);
      this.\u007F\u0005(false);
      return true;
    }

    private void \u009F\u0005(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u009A\u0005)));
    }

    protected override bool \u001D\u0005(\u0084.\u001B fileName)
    {
      try
      {
        this.\u0001.\u001D\u0005(fileName.\u0002, new \u0080.\u0016?());
      }
      catch (Exception ex)
      {
        \u0018.\u0017.\u001D\u0005(ex, fileName.\u0002);
        return false;
      }
      this.\u0001.Modified = false;
      \u001A\u001E.\u007E\u001E\u0086((object) this.\u0001);
      return true;
    }

    private void \u0001\u0006(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u009B\u0005)));
    }

    private void \u0002\u0006(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0094\u0005)));
    }

    private void \u0094\u0005(object state)
    {
      // ISSUE: method pointer
      if (!this.\u001D\u0005<bool>(new Func<bool>((object) this, __methodptr(\u0087\u0005))))
        return;
      this.\u0083\u0005();
      foreach (KeyValuePair<string, \u0080.\u0016> keyValuePair in this.\u0002.\u0001)
      {
        if (this.\u0001.\u0001.ContainsKey(keyValuePair.Key))
        {
          if (\u0080.\u0016.\u001E\u0005(this.\u0001.\u0001[keyValuePair.Key], keyValuePair.Value))
            this.\u0001.Add(keyValuePair.Key, \u007F.\u001E.\u0001.\u0003);
        }
        else
          this.\u0001.Add(keyValuePair.Key, \u007F.\u001E.\u0001.\u0002);
      }
      foreach (KeyValuePair<string, \u0080.\u0016> keyValuePair in this.\u0001.\u0001)
      {
        if (!this.\u0002.\u0001.ContainsKey(keyValuePair.Key))
          this.\u0001.Add(keyValuePair.Key, \u007F.\u001E.\u0001.\u0001);
      }
      \u001F.\u001A.\u001E\u0005(this, (MethodInvoker) (() => this.\u0081\u0005()));
    }

    private void \u0003\u0006(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0095\u0005)));
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0096\u0005)));
    }

    private void \u0095\u0005(object state)
    {
      this.\u0083\u0005();
    }

    private void \u0083\u0005()
    {
      if (this.\u0001 != null)
        return;
      this.\u0001 = new \u0007();
      foreach (\u001E.\u007F obj1 in this.\u0001.Values)
      {
        IEnumerator<KeyValuePair<string, \u001D.\u001B>> enumerator = ((IEnumerable<KeyValuePair<string, \u001D.\u001B>>) obj1.MultiFileData).GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            KeyValuePair<string, \u001D.\u001B> current = enumerator.Current;
            if (\u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0019\u0093((object) \u009C\u0080.\u0006\u009F(current.Key)), \u007F.\u001E.\u0001(79150)) || \u001E.\u007F.\u001F\u0005(current.Key))
            {
              obj1.\u001D\u0005(current.Value);
              \u0080.\u0016 obj2 = \u0081.\u0014.\u001D\u0005(current.Value.Data);
              if (!this.\u0001.\u0001.ContainsKey(current.Key))
                this.\u0001.\u0001.Add(current.Key, obj2);
              current.Value.Data = (byte[]) null;
            }
          }
        }
        finally
        {
          if (enumerator != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
        }
      }
    }

    private void \u0096\u0005(object state)
    {
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) this, __methodptr(\u0093\u0005)));
    }

    private void \u0004\u0006(object sender, EventArgs e)
    {
      if (this.\u0002)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0097\u0005)));
    }

    private void \u0097\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u007F.\u001E.\u0013 obj1 = new \u007F.\u001E.\u0013();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = (string) null;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0002 = (string) null;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0003 = (string) null;
      // ISSUE: method pointer
      if (!this.\u001D\u0005<bool>(new Func<bool>((object) obj1, __methodptr(\u001D\u0005))))
        return;
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        \u001A.\u0080.\u001D\u0005(obj1.\u0001, obj1.\u0002, obj1.\u0003);
        \u001F.\u001A.\u001E\u0005(this, (MethodInvoker) (() => \u0018.\u0017.\u001D\u0005(\u007F.\u001E.\u0001(80084), \u007F.\u001E.\u0001(80121))));
      }
      catch (LoaderPackNotSupported ex)
      {
        \u001F.\u001A.\u001E\u0005(this, (MethodInvoker) (() => \u0018.\u0017.\u001E\u0005(\u007F.\u001E.\u0001(80134), \u007F.\u001E.\u0001(80199))));
      }
      catch (Exception ex)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u007F.\u001E.\u0014 obj2 = new \u007F.\u001E.\u0014();
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = obj1;
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = ex;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001.\u001D\u0005((object) \u0013\u001C.\u0080\u0093(\u007F.\u001E.\u0001(79371), (object) obj1.\u0001, (object) obj1.\u0002, (object) obj1.\u0003));
        // ISSUE: reference to a compiler-generated method
        \u001F.\u001A.\u001E\u0005(this, new MethodInvoker(obj2.\u001D\u0005));
      }
    }

    private void \u0005\u0006(object sender, EventArgs e)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u0013);
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u0013);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    private enum \u0001
    {
      \u0001,
      \u0002,
      \u0003,
    }
  }
}
