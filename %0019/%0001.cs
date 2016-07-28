// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001F;
using \u0080;
using \u0083;
using \u0084;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0019
{
  internal sealed class \u0001 : \u0014.\u0017
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private \u0017.\u0080 \u0001;
    private Dictionary<object, \u0008> \u0001;
    private IContainer \u0001;
    private Button \u0001;
    private Button \u0002;
    private Button \u0003;
    private Button \u0004;
    private Button \u0005;
    private Button \u0006;
    private Button \u0007;
    private Label \u0001;
    private MenuStrip \u0001;
    private ToolStripMenuItem \u0001;
    private ToolStripMenuItem \u0002;
    private ToolStripMenuItem \u0003;
    private ToolStripMenuItem \u0004;
    private ToolStripMenuItem \u0005;
    private ToolStripMenuItem \u0006;
    private ToolStripMenuItem \u0007;
    private ToolStripMenuItem \u0008;
    private ToolStripSeparator \u0001;
    private ToolStripSeparator \u0002;

    static \u0001()
    {
      \u0004.\u001D\u0005(typeof (\u0019.\u0001));
    }

    public \u0001()
    {
      this.\u0080\u0005();
      this.\u001D\u0005();
      // ISSUE: method pointer
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler((object) this, __methodptr(\u001D\u0005)));
      // ISSUE: method pointer
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler((object) this, __methodptr(\u001E\u0005)));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(((\u0014.\u0017) this).\u007F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(((\u0014.\u0017) this).\u001F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(((\u0014.\u0017) this).\u0080\u0005));
      this.\u0001 = new Dictionary<object, \u0008>();
      this.\u0001.Add((object) this.\u0004, \u0008.\u0004);
      this.\u0001.Add((object) this.\u0007, \u0008.\u0007);
      this.\u0001.Add((object) this.\u0002, \u0008.\u0002);
      this.\u0001.Add((object) this.\u0005, \u0008.\u0005);
      this.\u0001.Add((object) this.\u0003, \u0008.\u0003);
      this.\u0001.Add((object) this.\u0001, \u0008.\u0001);
      this.\u0001.Add((object) this.\u0006, \u0008.\u0006);
    }

    protected override void \u001D\u0005(\u001B fileName, bool modified)
    {
      if (!modified)
      {
        if (\u001B.\u001D\u0005(fileName, (object) null))
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0019.\u0001.\u0001(42676));
        else
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0081\u0086.\u0086\u0093(\u0019.\u0001.\u0001(42733), \u009C\u0080.\u0008\u009F(fileName.\u0002)));
      }
      else if (\u001B.\u001D\u0005(fileName, (object) null))
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u0019.\u0001.\u0001(42562));
      else
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u009E\u0081.\u001F\u0093(\u0019.\u0001.\u0001(42623), (object) \u009C\u0080.\u0008\u009F(fileName.\u0002)));
    }

    protected override void \u001D\u0005()
    {
      this.\u0001 = new \u0017.\u0080();
    }

    protected override bool \u001E\u0005(\u001B path)
    {
      try
      {
        this.\u0001 = new \u0017.\u0080(path.\u0002);
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

    private void \u0081\u0005(object sender, EventArgs e)
    {
      if (!this.\u0001.ContainsKey(sender))
        return;
      \u0008 wayPointType = this.\u0001[sender];
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u0018.\u0001 obj2 = new \u0018.\u0001(this.\u0001[wayPointType]);
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          \u0092\u0081.\u007E\u001D\u0084((object) obj2, \u0081\u0086.\u0086\u0093(\u0019.\u0001.\u0001(42782), wayPointType.\u001D\u0005()));
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2);
          if (!obj2.FileModified)
            return;
          this.FileModified = true;
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

    private void \u0082\u0005(object sender, EventArgs e)
    {
      \u0082.\u001D\u0005(\u0002.\u0014);
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        this.\u0001.Clear();
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u0080\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0019.\u0001)));
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0003 = new Button();
      this.\u0004 = new Button();
      this.\u0005 = new Button();
      this.\u0006 = new Button();
      this.\u0007 = new Button();
      this.\u0001 = new Label();
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
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0092\u0081.\u007E\u0095\u008A((object) base.\u0001, \u0019.\u0001.\u0001(42807));
      \u0092\u0081.\u007E\u0095\u008A((object) base.\u0001, \u0019.\u0001.\u0001(42807));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(13, 55));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001.\u0001(42864));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(196, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u0001.\u0001(42881));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0081\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(13, 84));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0019.\u0001.\u0001(42894));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(196, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0019.\u0001.\u0001(42915));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u0081\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(13, 113));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0019.\u0001.\u0001(42932));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(196, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0019.\u0001.\u0001(42953));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u0081\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(13, 142));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0019.\u0001.\u0001(42970));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(196, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0019.\u0001.\u0001(42991));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u0081\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(13, 171));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0019.\u0001.\u0001(43008));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(196, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0019.\u0001.\u0001(43029));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0005, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0005, new EventHandler(this.\u0081\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(13, 200));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0019.\u0001.\u0001(43046));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(196, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0019.\u0001.\u0001(43067));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0006, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0006, new EventHandler(this.\u0081\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(13, 229));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0019.\u0001.\u0001(43084));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(196, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 6);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u0019.\u0001.\u0001(43113));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0007, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0007, new EventHandler(this.\u0081\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(10, 35));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001.\u0001(17956));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(196, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 35);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u0001.\u0001(43138));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[2]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0007
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0019.\u0001.\u0001(43187));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(223, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 36);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0019.\u0001.\u0001(6408));
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
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0019.\u0001.\u0001(21943));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(37, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0019.\u0001.\u0001(6438));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0019.\u0001.\u0001(21960));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0002, Keys.N | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0019.\u0001.\u0001(6456));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0019.\u0001.\u0001(21977));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0003, Keys.O | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0019.\u0001.\u0001(6478));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0019.\u0001.\u0001(6576));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0019.\u0001.\u0001(22019));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0004, Keys.S | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u0019.\u0001.\u0001(6529));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0019.\u0001.\u0001(6538));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0005, Keys.S | Keys.Shift | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u0019.\u0001.\u0001(6559));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0019.\u0001.\u0001(6487));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u0019.\u0001.\u0001(22065));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0006, Keys.W | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u0019.\u0001.\u0001(6622));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0007), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0008
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u0019.\u0001.\u0001(6757));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(44, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u0019.\u0001.\u0001(6774));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0008, \u0019.\u0001.\u0001(6783));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0008, Keys.F1);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0008, new Size(124, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0008, \u0019.\u0001.\u0001(6804));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0008, new EventHandler(this.\u0082\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(223, 263));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0019.\u0001.\u0001(6813)));
      \u001A\u001D.\u0019\u008B((object) this, this.\u0001);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0019.\u0001.\u0001(43232));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0019.\u0001.\u0001(42676));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
