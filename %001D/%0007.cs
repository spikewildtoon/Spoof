// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0018;
using \u0019;
using \u001A;
using \u001C;
using \u001D;
using \u001F;
using \u007F;
using \u0080;
using \u0081;
using \u0084;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace \u001D
{
  internal sealed class \u0007 : ApplicationContext
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private NotifyIcon \u0001;
    private ContextMenuStrip \u0001;
    private ToolStripMenuItem \u0001;
    private ToolStripMenuItem \u0002;
    private ToolStripMenuItem \u0003;
    private ToolStripMenuItem \u0004;
    private ToolStripMenuItem \u0005;
    private ToolStripSeparator \u0001;
    private ToolStripMenuItem \u0006;
    private ToolStripMenuItem \u0007;
    private ToolStripMenuItem \u0008;
    private ToolStripMenuItem \u000E;
    private ToolStripMenuItem \u000F;
    private ToolStripMenuItem \u0010;
    private ToolStripMenuItem \u0011;
    private ToolStripSeparator \u0002;
    private ToolStripMenuItem \u0012;
    private ToolStripMenuItem \u0013;
    private ToolStripMenuItem \u0014;
    private ToolStripMenuItem \u0015;
    private ToolStripSeparator \u0003;
    private ToolStripMenuItem \u0016;
    private ToolStripSeparator \u0004;
    private ToolStripMenuItem \u0017;
    private \u0015 \u0001;
    private \u0012 \u0001;
    private FileSystemWatcher \u0001;
    private FileSystemWatcher \u0002;
    public static \u0004 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private \u001D.\u001C \u0001;
    private \u0082.\u0018 \u0001;
    private Control \u0001;
    private TaskFactory \u0001;
    private \u0005 \u0001;
    private readonly List<Form> \u0001;
    private readonly List<\u0016.\u001D> \u0001;

    static \u0007()
    {
      \u0004.\u001D\u0005(typeof (\u0007));
      \u0007.\u0001 = \u0007.\u0001(63042);
      \u0007.\u0002 = \u0007.\u0001(63063);
    }

    public \u0007()
    {
      this.\u001D\u0005();
      this.\u0001 = new List<\u0016.\u001D>();
      this.\u0001 = new List<Form>();
      this.\u0001 = new Control();
      \u001A\u001E.\u007E\u009C\u0084((object) this.\u0001);
      this.\u0001 = \u0081.\u0080.Instance.ApplicationSettings;
      this.\u0001 = new \u0005(2);
      this.\u0001 = new TaskFactory((TaskScheduler) this.\u0001);
      \u0087\u0084.\u007E\u0090\u0003\u0002((object) this.\u0001, new FileSystemEventHandler(this.\u001D\u0005));
      \u0087\u0084.\u007E\u0090\u0003\u0002((object) this.\u0002, new FileSystemEventHandler(this.\u001D\u0005));
      \u0099\u001F obj = \u0099\u001F.\u007E\u008C\u0003\u0002;
      FileSystemWatcher fileSystemWatcher = this.\u0001;
      bool flag;
      \u0099\u001F.\u007E\u008C\u0003\u0002((object) this.\u0002, flag = true);
      int num = flag ? 1 : 0;
      obj((object) fileSystemWatcher, num != 0);
      this.\u0001.\u001D\u0005(Keys.Oemplus, Keys.Control, false);
      this.\u0001.\u001D\u0005(Keys.Oemplus, Keys.Shift | Keys.Control, false);
      if (this.\u0001.HotkeysEnabled)
        \u0007.\u0001.\u001D\u0005();
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0015, this.\u001D\u0005());
      string str1 = \u0081\u0086.\u0011\u009F(\u001A.\u007F.ToonTownOpenDataDirectory, \u0007.\u0001);
      if (\u001E.\u0019.\u007F\u0005(str1))
        \u0081.\u0080.Instance.CreatedFileArchive.\u001E\u0005(str1);
      string str2 = \u0081\u0086.\u0011\u009F(\u001A.\u007F.ToonTownOpenDataDirectory, \u0007.\u0002);
      if (\u001E.\u0019.\u007F\u0005(str2))
        \u0081.\u0080.Instance.CreatedFileArchive.\u001E\u0005(str2);
      if (this.\u0001.UseVisualMode)
      {
        this.\u0088\u0005();
      }
      else
      {
        \u0099\u001F.\u007E\u000F\u008E((object) this.\u0001, true);
        this.\u0086\u0005();
      }
      \u001A.\u001C.\u001D\u0005(\u001A.\u007F.ToonTownOpenDataDirectory, 10);
      \u001A.\u001C.\u001D\u0005(\u001A.\u007F.ToonTownTestDataDirectory, 10);
      this.\u001D\u0005(\u0012.Current, false);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        goto label_66;
label_65:
      \u0099\u001F.\u009C\u0086((object) this, disposing);
      return;
label_66:
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      foreach (\u0016.\u001D obj in this.\u0001.ToArray())
        \u001A\u001E.\u007E\u0092\u008B((object) obj);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0002 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0002);
      if (this.\u0003 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0003);
      if (this.\u0004 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0004);
      if (this.\u0005 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0005);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0006 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0006);
      if (this.\u0007 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0007);
      if (this.\u0008 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0008);
      if (this.\u000E != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u000E);
      if (this.\u000F != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u000F);
      if (this.\u0010 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0010);
      if (this.\u0011 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0011);
      if (this.\u0002 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0002);
      if (this.\u0012 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0012);
      if (this.\u0013 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0013);
      if (this.\u0014 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0014);
      if (this.\u0015 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0015);
      if (this.\u0003 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0003);
      if (this.\u0016 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0016);
      if (this.\u0004 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0004);
      if (this.\u0017 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0017);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (\u0007.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) \u0007.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0002 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0002);
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
        goto label_65;
      }
      else
        goto label_65;
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new FileSystemWatcher();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      this.\u0002 = new FileSystemWatcher();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0002);
      this.\u0001 = new NotifyIcon(this.\u0001);
      this.\u0001 = new ContextMenuStrip(this.\u0001);
      this.\u0001 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripMenuItem();
      this.\u0003 = new ToolStripMenuItem();
      this.\u0004 = new ToolStripMenuItem();
      this.\u0005 = new ToolStripMenuItem();
      this.\u0001 = new ToolStripSeparator();
      this.\u0006 = new ToolStripMenuItem();
      this.\u0007 = new ToolStripMenuItem();
      this.\u0008 = new ToolStripMenuItem();
      this.\u000E = new ToolStripMenuItem();
      this.\u000F = new ToolStripMenuItem();
      this.\u0010 = new ToolStripMenuItem();
      this.\u0011 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripSeparator();
      this.\u0012 = new ToolStripMenuItem();
      this.\u0015 = new ToolStripMenuItem();
      this.\u0013 = new ToolStripMenuItem();
      this.\u0014 = new ToolStripMenuItem();
      this.\u0003 = new ToolStripSeparator();
      this.\u0016 = new ToolStripMenuItem();
      this.\u0004 = new ToolStripSeparator();
      this.\u0017 = new ToolStripMenuItem();
      this.\u0001 = new \u0015(this.\u0001);
      \u0007.\u0001 = new \u0004(this.\u0001);
      this.\u0001 = new \u0012(this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001E\u0082.\u007E\u0007\u008E((object) this.\u0001, this.\u0001);
      \u0092\u0081.\u007E\u000E\u008E((object) this.\u0001, \u0007.\u0001(53729));
      \u0080\u0086.\u007E\u0008\u008E((object) this.\u0001, \u001A.\u001D.Icon);
      \u0086\u001C.\u007E\u0005\u008E((object) this.\u0001, ToolTipIcon.Info);
      \u0092\u0081.\u007E\u0006\u008E((object) this.\u0001, \u0007.\u0001(62016));
      \u0092\u0081.\u007E\u0004\u008E((object) this.\u0001, \u0007.\u0001(62029));
      \u000E\u001F.\u007E\u0008\u0087((object) this.\u0001, new Size(20, 20));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[22]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0005,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0006,
        (ToolStripItem) this.\u0007,
        (ToolStripItem) this.\u0008,
        (ToolStripItem) this.\u000E,
        (ToolStripItem) this.\u000F,
        (ToolStripItem) this.\u0010,
        (ToolStripItem) this.\u0011,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0012,
        (ToolStripItem) this.\u0015,
        (ToolStripItem) this.\u0013,
        (ToolStripItem) this.\u0014,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0016,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0017
      });
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0007.\u0001(62255));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(196, 466));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0001, (Image) \u0082.\u001E.AboutMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0007.\u0001(62284));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0007.\u0001(62305));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0001, new EventHandler(this.\u0086\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0002, (Image) \u0082.\u001E.UpdatingMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0007.\u0001(62314));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0007.\u0001(62347));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler(this.\u0089\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0003, (Image) \u0082.\u001E.ReleaseNotesMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0007.\u0001(62372));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0007.\u0001(62401));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(this.\u0087\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0004, (Image) \u0082.\u001E.OptionsMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0007.\u0001(7809));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u0007.\u0001(62422));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(this.\u0088\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0005, (Image) \u0082.\u001E.GuideMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0007.\u0001(7961));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u0007.\u0001(62435));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(this.\u008C\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0007.\u0001(7665));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(192, 6));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0006, (Image) \u0082.\u001E.InvasionsMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u0007.\u0001(62444));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u0007.\u0001(62469));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(this.\u001E\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0007, (Image) \u0082.\u001E.JoeFishMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u0007.\u0001(62482));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u0007.\u0001(40184));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0007, new EventHandler(this.\u001F\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0008, (Image) \u0082.\u001E.GardenerFloraMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0008, \u0007.\u0001(62503));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0008, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0008, \u0007.\u0001(22614));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0008, new EventHandler(this.\u007F\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u000E, (Image) \u0082.\u001E.GagAMaticMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000E, \u0007.\u0001(62532));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000E, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000E, \u0007.\u0001(62557));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000E, new EventHandler(this.\u0080\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u000F, (Image) \u0082.\u001E.ParTeePuttMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000F, \u0007.\u0001(62574));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000F, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000F, \u0007.\u0001(27923));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000F, new EventHandler(this.\u0081\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0010, (Image) \u0082.\u001E.RaceTrackMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0010, \u0007.\u0001(62599));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0010, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0010, \u0007.\u0001(53775));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0010, new EventHandler(this.\u0082\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0011, (Image) \u0082.\u001E.RemoteControlMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0011, \u0007.\u0001(62624));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0011, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0011, \u0007.\u0001(62653));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0011, new EventHandler(this.\u0083\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0007.\u0001(7754));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(192, 6));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0012, (Image) \u0082.\u001E.ContentPacksMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0012, \u0007.\u0001(62674));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0012, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0012, \u0007.\u0001(53826));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0012, new EventHandler(this.\u008A\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0015, (Image) \u0082.\u001E.SwitchHotkeysMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0015, \u0007.\u0001(62703));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0015, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0015, \u0007.\u0001(62732));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0015, new EventHandler(this.\u008E\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0013, (Image) \u0082.\u001E.MyGalleryMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0013, \u0007.\u0001(62753));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0013, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0013, \u0007.\u0001(35516));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0013, new EventHandler(this.\u008B\u0005));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0014, (Image) \u0082.\u001E.SwitchToVisualModeMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0014, \u0007.\u0001(62778));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0014, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0014, \u0007.\u0001(62815));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0014, new EventHandler(this.\u0084\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0007.\u0001(40625));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(192, 6));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0016, (Image) \u0082.\u001E.ConnectMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0016, \u0007.\u0001(62844));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0016, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0016, \u0007.\u0001(38029));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0016, new EventHandler(this.\u001D\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0007.\u0001(40341));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(192, 6));
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0017, (Image) \u0082.\u001E.ExitMenuItem_Image);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0017, \u0007.\u0001(7783));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0017, new Size(195, 26));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0017, \u0007.\u0001(62865));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0017, new EventHandler(this.\u008D\u0005));
      this.\u0001.HotkeyActivated += new EventHandler<\u0018.\u0014>(this.\u001D\u0005);
      \u0099\u001F.\u007E\u008C\u0003\u0002((object) this.\u0001, false);
      \u0092\u0081.\u007E\u008D\u0003\u0002((object) this.\u0001, \u0007.\u0001(35422));
      \u0019\u0081.\u007E\u008F\u0003\u0002((object) this.\u0001, (ISynchronizeInvoke) null);
      \u0092\u0081.\u007E\u008E\u0003\u0002((object) this.\u0001, \u001A.\u007F.ToonTownOpenDataDirectory);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u008C\u0003\u0002((object) this.\u0002, false);
      \u0092\u0081.\u007E\u008D\u0003\u0002((object) this.\u0002, \u0007.\u0001(35422));
      \u0019\u0081.\u007E\u008F\u0003\u0002((object) this.\u0002, (ISynchronizeInvoke) null);
      \u0092\u0081.\u007E\u008E\u0003\u0002((object) this.\u0002, \u001A.\u007F.ToonTownTestDataDirectory);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0002);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
    }

    private void \u001D\u0005(object sender, FileSystemEventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0007.\u0001 obj = new \u0007.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = e;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      if (\u008C\u001E.\u007E\u0088\u0003\u0002((object) obj.\u0001) != WatcherChangeTypes.Created)
        return;
      // ISSUE: reference to a compiler-generated method
      this.\u0001.StartNew(new Action(obj.\u001D\u0005));
    }

    public void \u001D\u0005(\u0012 args)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new MethodInvoker((object) new \u0007.\u0002()
      {
        \u0001 = args,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(\u0012 args, bool invoked)
    {
      List<string> contentPackPaths = new List<string>();
      IEnumerator<string> enumerator = args.Values.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          string current = enumerator.Current;
          if (!\u008F\u0084.\u009E\u0092(current) && (\u0008\u001F.\u009A\u0092(\u009C\u0080.\u0006\u009F(current), \u0007.\u0001(54358)) && \u008F\u0084.\u0092\u009E(current)))
            contentPackPaths.Add(current);
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      if (contentPackPaths.Count > 0)
      {
        this.\u001D\u0005(contentPackPaths);
      }
      else
      {
        if (!invoked)
          return;
        if (this.\u0001.UseVisualMode)
        {
          \u001A\u001E.\u007E\u009B\u0084((object) this.\u0001);
          \u001A\u001E.\u007E\u0091\u008B((object) this.\u0001);
        }
        else
          this.\u0087\u0005();
      }
    }

    private void \u001D\u0005(object sender, \u0018.\u0014 e)
    {
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new MethodInvoker((object) this, __methodptr(\u0090\u0005)));
    }

    private string \u001D\u0005()
    {
      if (this.\u0001.HotkeysEnabled)
        return \u0007.\u0001(62874);
      return \u0007.\u0001(62899);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
    }

    private void \u001E\u0005()
    {
      bool created;
      this.\u001D\u0005((Form) this.\u0001.\u001D\u0005<\u0018.\u0019>(out created, new object[0]), created);
    }

    private void \u001D\u0005(Form f, bool created)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0007.\u0003 obj = new \u0007.\u0003();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = f;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = this;
      if (!created)
        return;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      obj.\u0001.FormClosed += new FormClosedEventHandler(obj.\u001D\u0005);
      // ISSUE: reference to a compiler-generated field
      this.\u0001.Add(obj.\u0001);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u001F\u0005();
    }

    private void \u001F\u0005()
    {
      bool created;
      this.\u001D\u0005((Form) this.\u0001.\u001D\u0005<\u007F.\u0080>(out created, new object[0]), created);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u007F\u0005();
    }

    private void \u007F\u0005()
    {
      bool created;
      this.\u001D\u0005((Form) this.\u0001.\u001D\u0005<\u0018.\u0080>(out created, new object[0]), created);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      this.\u0080\u0005();
    }

    private void \u0080\u0005()
    {
      bool created;
      this.\u001D\u0005((Form) this.\u0001.\u001D\u0005<\u0016.\u0016>(out created, new object[0]), created);
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      this.\u0081\u0005();
    }

    private void \u0081\u0005()
    {
      bool created;
      this.\u001D\u0005((Form) this.\u0001.\u001D\u0005<\u0014.\u001E>(out created, new object[0]), created);
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      this.\u0082\u0005();
    }

    private void \u0082\u0005()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0007.\u0004 obj1 = new \u0007.\u0004();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      if (this.\u0001.Count > 0)
        goto label_5;
label_4:
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = new \u0016.\u001D();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      obj1.\u0001.FormClosing += new FormClosingEventHandler(obj1.\u001D\u0005);
      // ISSUE: reference to a compiler-generated field
      this.\u0001.Add(obj1.\u0001);
      // ISSUE: reference to a compiler-generated field
      this.\u001D\u0005((Form) obj1.\u0001, true);
      // ISSUE: reference to a compiler-generated field
      \u001A\u001E.\u007E\u0083\u0086((object) obj1.\u0001);
      return;
label_5:
      \u0016.\u001D obj2;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = obj2 = this.\u0001.Last<\u0016.\u001D>();
      if (\u0099\u0082.\u007E\u0081\u0084((object) obj2))
      {
        // ISSUE: reference to a compiler-generated field
        if (\u0098\u001E.\u007E\u0087\u008B((object) obj1.\u0001) == FormWindowState.Minimized)
        {
          // ISSUE: reference to a compiler-generated field
          \u0097\u001C.\u007E\u0088\u008B((object) obj1.\u0001, FormWindowState.Normal);
        }
        // ISSUE: reference to a compiler-generated field
        \u001A\u001E.\u007E\u009B\u0084((object) obj1.\u0001);
        // ISSUE: reference to a compiler-generated field
        \u001A\u001E.\u007E\u0091\u008B((object) obj1.\u0001);
      }
      else
        goto label_4;
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.\u0083\u0005();
    }

    private void \u0083\u0005()
    {
      bool created;
      this.\u001D\u0005((Form) this.\u0001.\u001D\u0005<\u0014.\u0018>(out created, new object[0]), created);
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      this.\u0084\u0005();
    }

    private void \u0084\u0005()
    {
      bool created;
      this.\u001D\u0005((Form) this.\u0001.\u001D\u0005<\u001B>(out created, new object[0]), created);
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      this.\u0001.UseVisualMode = true;
      this.\u0088\u0005();
      \u0099\u001F.\u007E\u000F\u008E((object) this.\u0001, false);
    }

    private void \u0086\u0005()
    {
      if (!this.\u0001.DisplayNotifyBalloon)
        return;
      this.\u0087\u0005();
      this.\u0001.DisplayNotifyBalloon = false;
    }

    private void \u0087\u0005()
    {
      \u0011\u001F.\u007E\u0010\u008E((object) this.\u0001, 10000);
    }

    private void \u0088\u0005()
    {
      if (this.\u0001 == null)
      {
        this.\u0001 = new \u001D.\u001C(this.\u0001);
        \u0080\u0086.\u007E\u0016\u008B((object) this.\u0001, \u001A.\u001D.Icon);
        this.\u0001.MoveToNotificationArea += (EventHandler) ((obj, args) =>
        {
          this.\u0001.UseVisualMode = false;
          \u001A\u001E.\u007E\u0092\u008B((object) this.\u0001);
          \u0099\u001F.\u007E\u000F\u008E((object) this.\u0001, true);
          this.\u0086\u0005();
        });
        this.\u0001.FormClosed += (FormClosedEventHandler) ((obj, args) =>
        {
          if (this.\u0001.UseVisualMode)
            goto label_2;
label_1:
          \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
          this.\u0001 = (\u001D.\u001C) null;
          return;
label_2:
          this.\u008F\u0005();
          goto label_1;
        });
        this.\u0001.CheckForUpdatesLaunched += (EventHandler) ((obj, args) => this.\u008C\u0005());
        this.\u0001.MyGalleryLaunched += (EventHandler) ((obj, args) => this.\u008D\u0005());
        this.\u0001.ContentPacksLaunched += (EventHandler) ((obj, args) => this.\u001D\u0005((List<string>) null));
        this.\u0001.HotkeysLaunched += (EventHandler<\u001A.\u0001>) ((obj, args) =>
        {
          if (!this.\u001D\u0005())
            return;
          args.HotkeysEnabledStateChangedResult = true;
        });
        this.\u0001.GuideLaunched += (EventHandler) ((obj, args) => this.\u008E\u0005());
        this.\u0001.ReleaseNotesLaunched += (EventHandler) ((obj, args) => this.\u008A\u0005());
        this.\u0001.AboutLaunched += (EventHandler) ((obj, args) => this.\u0089\u0005());
        this.\u0001.OptionsLaunched += (EventHandler) ((obj, args) => this.\u008B\u0005());
        this.\u0001.RemoteControlLaunched += (EventHandler) ((obj, args) => this.\u0084\u0005());
        this.\u0001.RaceTrackLaunched += (EventHandler) ((obj, args) => this.\u0083\u0005());
        this.\u0001.GagAMaticLaunched += (EventHandler) ((obj, args) => this.\u0081\u0005());
        this.\u0001.GardenerFloraLaunched += (EventHandler) ((obj, args) => this.\u0080\u0005());
        this.\u0001.JoeFishLaunched += (EventHandler) ((obj, args) => this.\u007F\u0005());
        this.\u0001.InvasionsLaunched += (EventHandler) ((obj, args) => this.\u001F\u0005());
        this.\u0001.ConnectLaunched += (EventHandler) ((obj, args) => this.\u001E\u0005());
        this.\u0001.ParTeePuttLaunched += (EventHandler) ((obj, args) => this.\u0082\u0005());
        \u001A\u001E.\u007E\u0083\u0086((object) this.\u0001);
      }
      else
      {
        if (!\u0099\u0082.\u007E\u0081\u0084((object) this.\u0001))
          return;
        \u001A\u001E.\u007E\u009B\u0084((object) this.\u0001);
        \u001A\u001E.\u007E\u0091\u008B((object) this.\u0001);
      }
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      this.\u0089\u0005();
    }

    private void \u0089\u0005()
    {
      bool created;
      this.\u001D\u0005((Form) this.\u0001.\u001D\u0005<\u0006>(out created, new object[0]), created);
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      this.\u008A\u0005();
    }

    private void \u008A\u0005()
    {
      bool created;
      this.\u001D\u0005((Form) this.\u0001.\u001D\u0005<\u0080.\u0081>(out created, new object[0]), created);
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      this.\u008B\u0005();
    }

    private void \u008B\u0005()
    {
      bool created;
      this.\u001D\u0005((Form) this.\u0001.\u001D\u0005<\u000E>(out created, new object[0]), created);
    }

    private void \u0089\u0005(object sender, EventArgs e)
    {
      this.\u008C\u0005();
    }

    private void \u008C\u0005()
    {
      if (!\u0083.\u001C.CanOpenUpdater)
        return;
      bool flag = false;
      \u0082.\u0014 instance = \u0082.\u0014.Instance;
      DateTime dateTime = \u001D\u0082.\u0011\u0094();
      try
      {
        \u0008 obj = new \u0008(false);
        try
        {
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj);
          switch (obj.UpdateResult)
          {
            case \u0006.\u0005:
            case \u0006.\u0007:
              flag = true;
              break;
            case \u0006.\u0006:
              instance.UpdateStepOn = \u0002.\u0001;
              flag = true;
              this.\u008F\u0005();
              break;
          }
        }
        finally
        {
          if (obj != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj);
        }
      }
      finally
      {
        if (flag)
        {
          instance.LastCheckedForUpdate = dateTime;
          instance.\u001D\u0005();
        }
      }
    }

    private void \u008A\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005((List<string>) null);
    }

    private void \u001D\u0005(List<string> contentPackPaths = null)
    {
      if (!\u0083.\u001C.CanOpenContentPacksOrOpenDialog)
        return;
      if (!this.\u0001.AcceptedContentPackAgreement)
        goto label_13;
label_7:
      \u0083.\u001C.ContentPacksOpen = true;
      bool created;
      \u0019.\u001D obj1 = this.\u0001.\u001D\u0005<\u0019.\u001D>(out created, (object) contentPackPaths);
      if (created)
        obj1.FormClosed += (FormClosedEventHandler) ((obj, arg) => \u0083.\u001C.ContentPacksOpen = false);
      else if (contentPackPaths != null)
        obj1.\u001D\u0005(contentPackPaths);
      this.\u001D\u0005((Form) obj1, created);
      return;
label_13:
      \u001E.\u0082 obj2 = new \u001E.\u0082();
      try
      {
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) == DialogResult.OK)
          goto label_7;
      }
      finally
      {
        if (obj2 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj2);
      }
    }

    private void \u008B\u0005(object sender, EventArgs e)
    {
      this.\u008D\u0005();
    }

    private void \u008D\u0005()
    {
      \u0083.\u001C.MyGalleryOpen = true;
      bool created;
      Form f = (Form) this.\u0001.\u001D\u0005<\u0005>(out created, new object[0]);
      if (created)
        f.FormClosed += (FormClosedEventHandler) ((obj, arg) => \u0083.\u001C.MyGalleryOpen = false);
      this.\u001D\u0005(f, created);
    }

    private void \u008C\u0005(object sender, EventArgs e)
    {
      this.\u008E\u0005();
    }

    private void \u008E\u0005()
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u0001);
    }

    private void \u008D\u0005(object sender, EventArgs e)
    {
      if (!\u0083.\u001C.CanExitTheToonTownSpoofer)
        return;
      this.\u008F\u0005();
    }

    private void \u008F\u0005()
    {
      \u001A\u001E.\u009D\u0086((object) this);
    }

    private void \u008E\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005();
    }

    private bool \u001D\u0005()
    {
      if (this.\u0001.\u001D\u0005<\u000E>())
      {
        \u0018.\u0017.\u001D\u0005(\u0007.\u0001(62920), \u0007.\u0001(63013));
        return false;
      }
      if (this.\u0001.HotkeysEnabled = !this.\u0001.HotkeysEnabled)
        \u0007.\u0001.\u001D\u0005();
      else
        \u0007.\u0001.\u001E\u0005();
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0015, this.\u001D\u0005());
      return true;
    }
  }
}
