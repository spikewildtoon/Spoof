// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0016;
using \u0018;
using \u0019;
using \u001A;
using \u001B;
using \u001E;
using \u0080;
using \u0084;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0014
{
  internal sealed class \u0018 : \u0017
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private IContainer \u0001;
    private TabControl \u0001;
    private TabPage \u0001;
    private PictureBox \u0001;
    private TabPage \u0002;
    private PictureBox \u0002;
    private Label \u0001;
    private Button \u0001;
    private Button \u0002;
    private Button \u0003;
    private Label \u0002;
    private Button \u0004;
    private Button \u0005;
    private Button \u0006;
    private Label \u0003;
    private Label \u0004;
    private TabPage \u0003;
    private PictureBox \u0003;
    private Label \u0005;
    private Button \u0007;
    private Button \u0008;
    private Button \u000E;
    private Label \u0006;
    private Button \u000F;
    private Button \u0010;
    private Button \u0011;
    private Label \u0007;
    private Label \u0008;
    private TabPage \u0004;
    private PictureBox \u0004;
    private Label \u000E;
    private Button \u0012;
    private Button \u0013;
    private Button \u0014;
    private Label \u000F;
    private Button \u0015;
    private Button \u0016;
    private Button \u0017;
    private Label \u0010;
    private Label \u0011;
    private TabPage \u0005;
    private PictureBox \u0005;
    private Button \u0018;
    private Button \u0019;
    private Button \u001A;
    private Label \u0012;
    private Label \u0013;
    private Label \u0014;
    private Button \u001B;
    private Button \u001C;
    private Button \u001D;
    private Label \u0015;
    private Button \u001E;
    private Button \u001F;
    private Button \u007F;
    private Label \u0016;
    private Label \u0017;
    private TabPage \u0006;
    private PictureBox \u0006;
    private ComboBox \u0001;
    private ComboBox \u0002;
    private Label \u0018;
    private Label \u0019;
    private Label \u001A;
    private Label \u001B;
    private ComboBox \u0003;
    private Label \u001C;
    private Label \u001D;
    private Label \u001E;
    private Label \u001F;
    private Label \u007F;
    private Label \u0080;
    private Label \u0081;
    private Label \u0082;
    private MenuStrip \u0001;
    private ToolStripMenuItem \u0001;
    private ToolStripMenuItem \u0002;
    private ToolStripMenuItem \u0003;
    private ToolStripMenuItem \u0004;
    private ToolStripMenuItem \u0005;
    private ToolStripMenuItem \u0006;
    private ToolStripSeparator \u0001;
    private ToolStripSeparator \u0002;
    private ToolStripMenuItem \u0007;
    private ToolStripMenuItem \u0008;
    private ToolStripMenuItem \u000E;
    private ToolStripMenuItem \u000F;
    private ToolStripMenuItem \u0010;
    private static readonly int \u0001;
    private static readonly int \u0002;
    private static readonly int \u0003;
    private static readonly int \u0004;
    private static readonly int \u0005;
    private static readonly int \u0006;
    private \u0002 \u0001;
    private \u001C \u0001;

    static \u0018()
    {
      \u0004.\u001D\u0005(typeof (\u0014.\u0018));
      \u0014.\u0018.\u0001 = 50;
      \u0014.\u0018.\u0002 = 75;
      \u0014.\u0018.\u0003 = 100;
      \u0014.\u0018.\u0004 = 150;
      \u0014.\u0018.\u0005 = 300;
      \u0014.\u0018.\u0006 = 400;
    }

    public \u0018()
    {
      this.\u0080\u0005();
      this.\u0001 = \u0081.\u0080.Instance.RaceTrackFileIndex;
      // ISSUE: method pointer
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler((object) this, __methodptr(\u001D\u0005)));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(((\u0017) this).\u001E\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(((\u0017) this).\u001F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(((\u0017) this).\u007F\u0005));
      this.\u0001 = new \u0002();
      this.\u0010.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.RuralTrackQualifies >= (int) ushort.MaxValue)
          return;
        ++this.\u0001.RuralTrackQualifies;
        this.\u0084\u0005();
        this.FileModified = true;
      };
      this.\u000F.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.RuralTrackQualifies <= 0)
          return;
        --this.\u0001.RuralTrackQualifies;
        this.\u0084\u0005();
        this.FileModified = true;
      };
      this.\u0011.Click += (EventHandler) ((sender, e) =>
      {
        this.\u0001.RuralTrackQualifies = this.\u001D\u0005(this.\u0001.RuralTrackQualifies);
        this.\u0084\u0005();
      });
      this.\u0007.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.RuralTrackWins >= (int) ushort.MaxValue)
          return;
        ++this.\u0001.RuralTrackWins;
        this.\u0086\u0005();
        if (this.\u0001.AutoUpdate)
        {
          ++this.\u0001.RuralTrackQualifies;
          this.\u0084\u0005();
        }
        this.FileModified = true;
      };
      this.\u0008.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.RuralTrackWins <= 0)
          return;
        --this.\u0001.RuralTrackWins;
        this.\u0086\u0005();
        if (this.\u0001.AutoUpdate)
        {
          --this.\u0001.RuralTrackQualifies;
          this.\u0084\u0005();
        }
        this.FileModified = true;
      };
      this.\u000E.Click += (EventHandler) ((sender, e) =>
      {
        this.\u0001.RuralTrackWins = this.\u001D\u0005(this.\u0001.RuralTrackWins);
        this.\u0086\u0005();
      });
      this.\u0016.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.UrbanTrackQualifies >= (int) ushort.MaxValue)
          return;
        ++this.\u0001.UrbanTrackQualifies;
        this.\u008A\u0005();
        this.FileModified = true;
      };
      this.\u0015.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.UrbanTrackQualifies <= 0)
          return;
        --this.\u0001.UrbanTrackQualifies;
        this.\u008A\u0005();
        this.FileModified = true;
      };
      this.\u0017.Click += (EventHandler) ((sender, e) =>
      {
        this.\u0001.UrbanTrackQualifies = this.\u001D\u0005(this.\u0001.UrbanTrackQualifies);
        this.\u008A\u0005();
      });
      this.\u0012.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.UrbanTrackWins >= (int) ushort.MaxValue)
          return;
        ++this.\u0001.UrbanTrackWins;
        this.\u008B\u0005();
        if (this.\u0001.AutoUpdate)
        {
          ++this.\u0001.UrbanTrackQualifies;
          this.\u008A\u0005();
        }
        this.FileModified = true;
      };
      this.\u0013.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.UrbanTrackWins <= 0)
          return;
        --this.\u0001.UrbanTrackWins;
        this.\u008B\u0005();
        if (this.\u0001.AutoUpdate)
        {
          --this.\u0001.UrbanTrackQualifies;
          this.\u008A\u0005();
        }
        this.FileModified = true;
      };
      this.\u0014.Click += (EventHandler) ((sender, e) =>
      {
        this.\u0001.UrbanTrackWins = this.\u001D\u0005(this.\u0001.UrbanTrackWins);
        this.\u008B\u0005();
      });
      this.\u0005.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.SpeedwayTrackQualifies >= (int) ushort.MaxValue)
          return;
        ++this.\u0001.SpeedwayTrackQualifies;
        this.\u008C\u0005();
        this.FileModified = true;
      };
      this.\u0004.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.SpeedwayTrackQualifies <= 0)
          return;
        --this.\u0001.SpeedwayTrackQualifies;
        this.\u008C\u0005();
        this.FileModified = true;
      };
      this.\u0006.Click += (EventHandler) ((sender, e) =>
      {
        this.\u0001.SpeedwayTrackQualifies = this.\u001D\u0005(this.\u0001.SpeedwayTrackQualifies);
        this.\u008C\u0005();
      });
      this.\u0001.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.SpeedwayTrackWins >= (int) ushort.MaxValue)
          return;
        ++this.\u0001.SpeedwayTrackWins;
        this.\u008D\u0005();
        if (this.\u0001.AutoUpdate)
        {
          ++this.\u0001.SpeedwayTrackQualifies;
          this.\u008C\u0005();
        }
        this.FileModified = true;
      };
      this.\u0002.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.SpeedwayTrackWins <= 0)
          return;
        --this.\u0001.SpeedwayTrackWins;
        this.\u008D\u0005();
        if (this.\u0001.AutoUpdate)
        {
          --this.\u0001.SpeedwayTrackQualifies;
          this.\u008C\u0005();
        }
        this.FileModified = true;
      };
      this.\u0003.Click += (EventHandler) ((sender, e) =>
      {
        this.\u0001.SpeedwayTrackWins = this.\u001D\u0005(this.\u0001.SpeedwayTrackWins);
        this.\u008D\u0005();
      });
      this.\u001F.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.TournamentQualifies >= (int) ushort.MaxValue)
          return;
        ++this.\u0001.TournamentQualifies;
        this.\u0088\u0005();
        this.FileModified = true;
      };
      this.\u001E.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.TournamentQualifies <= 0)
          return;
        --this.\u0001.TournamentQualifies;
        this.\u0088\u0005();
        this.FileModified = true;
      };
      this.\u007F.Click += (EventHandler) ((sender, e) =>
      {
        this.\u0001.TournamentQualifies = this.\u001D\u0005(this.\u0001.TournamentQualifies);
        this.\u0088\u0005();
      });
      this.\u001B.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.TournamentWins >= (int) ushort.MaxValue)
          return;
        ++this.\u0001.TournamentWins;
        this.\u0089\u0005();
        if (this.\u0001.AutoUpdate)
        {
          ++this.\u0001.TournamentQualifies;
          this.\u0088\u0005();
        }
        this.FileModified = true;
      };
      this.\u001C.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.TournamentWins <= 0)
          return;
        --this.\u0001.TournamentWins;
        this.\u0089\u0005();
        if (this.\u0001.AutoUpdate)
        {
          --this.\u0001.TournamentQualifies;
          this.\u0088\u0005();
        }
        this.FileModified = true;
      };
      this.\u001D.Click += (EventHandler) ((sender, e) =>
      {
        this.\u0001.TournamentWins = this.\u001D\u0005(this.\u0001.TournamentWins);
        this.\u0089\u0005();
      });
      this.\u0018.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.TournamentSwept >= (int) ushort.MaxValue)
          return;
        ++this.\u0001.TournamentSwept;
        this.\u0087\u0005();
        if (this.\u0001.AutoUpdate)
        {
          ++this.\u0001.TournamentWins;
          this.\u0089\u0005();
          ++this.\u0001.TournamentQualifies;
          this.\u0088\u0005();
        }
        this.FileModified = true;
      };
      this.\u0019.Click += (EventHandler) delegate
      {
        if ((int) this.\u0001.TournamentSwept <= 0)
          return;
        --this.\u0001.TournamentSwept;
        this.\u0087\u0005();
        if (this.\u0001.AutoUpdate)
        {
          --this.\u0001.TournamentWins;
          this.\u0089\u0005();
          --this.\u0001.TournamentQualifies;
          this.\u0088\u0005();
        }
        this.FileModified = true;
      };
      this.\u001A.Click += (EventHandler) ((sender, e) =>
      {
        this.\u0001.TournamentSwept = this.\u001D\u0005(this.\u0001.TournamentSwept);
        this.\u0087\u0005();
      });
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u0080\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0014.\u0018)));
      this.\u0001 = new TabControl();
      this.\u0001 = new TabPage();
      this.\u0001 = new PictureBox();
      this.\u0002 = new TabPage();
      this.\u0002 = new PictureBox();
      this.\u0001 = new Label();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0003 = new Button();
      this.\u0002 = new Label();
      this.\u0004 = new Button();
      this.\u0005 = new Button();
      this.\u0006 = new Button();
      this.\u0003 = new Label();
      this.\u0004 = new Label();
      this.\u0003 = new TabPage();
      this.\u0003 = new PictureBox();
      this.\u0005 = new Label();
      this.\u0007 = new Button();
      this.\u0008 = new Button();
      this.\u000E = new Button();
      this.\u0006 = new Label();
      this.\u000F = new Button();
      this.\u0010 = new Button();
      this.\u0011 = new Button();
      this.\u0007 = new Label();
      this.\u0008 = new Label();
      this.\u0004 = new TabPage();
      this.\u0004 = new PictureBox();
      this.\u000E = new Label();
      this.\u0012 = new Button();
      this.\u0013 = new Button();
      this.\u0014 = new Button();
      this.\u000F = new Label();
      this.\u0015 = new Button();
      this.\u0016 = new Button();
      this.\u0017 = new Button();
      this.\u0010 = new Label();
      this.\u0011 = new Label();
      this.\u0005 = new TabPage();
      this.\u0005 = new PictureBox();
      this.\u0018 = new Button();
      this.\u0019 = new Button();
      this.\u001A = new Button();
      this.\u0012 = new Label();
      this.\u0013 = new Label();
      this.\u0014 = new Label();
      this.\u001B = new Button();
      this.\u001C = new Button();
      this.\u001D = new Button();
      this.\u0015 = new Label();
      this.\u001E = new Button();
      this.\u001F = new Button();
      this.\u007F = new Button();
      this.\u0016 = new Label();
      this.\u0017 = new Label();
      this.\u0006 = new TabPage();
      this.\u0003 = new ComboBox();
      this.\u0002 = new ComboBox();
      this.\u001C = new Label();
      this.\u001D = new Label();
      this.\u0018 = new Label();
      this.\u0019 = new Label();
      this.\u001E = new Label();
      this.\u001F = new Label();
      this.\u007F = new Label();
      this.\u0080 = new Label();
      this.\u0081 = new Label();
      this.\u0082 = new Label();
      this.\u001A = new Label();
      this.\u001B = new Label();
      this.\u0001 = new ComboBox();
      this.\u0006 = new PictureBox();
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
      this.\u0010 = new ToolStripMenuItem();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0002);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0002);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0003);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0003);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0004);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0004);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0005);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0005);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0006);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0006);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0083\u0080.\u007E\u0081\u008F((object) this.\u0001, TabAlignment.Bottom);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0014.\u0018.\u0001(2200), 9f));
      \u0099\u001F.\u007E\u0082\u008F((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 24));
      \u0099\u001F.\u007E\u0083\u008F((object) this.\u0001, true);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0018.\u0001(2213));
      \u0011\u001F.\u007E\u0084\u008F((object) this.\u0001, 0);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(362, 208));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0096\u0086.\u007E\u0099\u008F((object) this.\u0001, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0018.\u0001(2226));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(354, 180));
      \u0011\u001F.\u007E\u009A\u008F((object) this.\u0001, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0014.\u0018.\u0001(2243));
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0018.\u0001(2256)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 14));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0018.\u0001(2281));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(354, 153));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0099\u001F.\u007E\u0081\u008E((object) this.\u0001, true);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0004);
      \u0096\u0086.\u007E\u0099\u008F((object) this.\u0002, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0014.\u0018.\u0001(2298));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(354, 180));
      \u0011\u001F.\u007E\u009A\u008F((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0014.\u0018.\u0001(2315));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.None);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0002, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0018.\u0001(2328)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(47, 11));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0014.\u0018.\u0001(2353));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(260, 50));
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0002, 41);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0002, false);
      \u0099\u001F.\u007E\u0081\u008E((object) this.\u0002, true);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0014.\u0018.\u0001(2370), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(45, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0018.\u0001(2379));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(88, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 11);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0014.\u0018.\u0001(2416));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(221, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0018.\u0001(2433));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0014.\u0018.\u0001(2458));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(253, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0014.\u0018.\u0001(2463));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0014.\u0018.\u0001(2496));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0003, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(285, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0014.\u0018.\u0001(2501));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0014.\u0018.\u0001(2530));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0014.\u0018.\u0001(2370), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(45, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0014.\u0018.\u0001(2535));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(88, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0014.\u0018.\u0001(2564));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0002, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0004, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(253, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0014.\u0018.\u0001(2573));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0014.\u0018.\u0001(2496));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0005, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(221, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0014.\u0018.\u0001(2614));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0014.\u0018.\u0001(2458));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0006, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0006, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(285, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0014.\u0018.\u0001(2647));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0014.\u0018.\u0001(2530));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0003, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0014.\u0018.\u0001(2370), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(133, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0014.\u0018.\u0001(2684));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(56, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 8);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0014.\u0018.\u0001(1813));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0003, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0004, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0014.\u0018.\u0001(2370), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(133, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0014.\u0018.\u0001(2705));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(56, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0014.\u0018.\u0001(1813));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0004, ContentAlignment.MiddleLeft);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0010);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0011);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0008);
      \u0096\u0086.\u007E\u0099\u008F((object) this.\u0003, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0014.\u0018.\u0001(2734));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(354, 180));
      \u0011\u001F.\u007E\u009A\u008F((object) this.\u0003, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0014.\u0018.\u0001(2747));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0003, AnchorStyles.None);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0003, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0018.\u0001(2756)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(47, 11));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0014.\u0018.\u0001(2777));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(260, 50));
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0003, 41);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0003, false);
      \u0099\u001F.\u007E\u0081\u008E((object) this.\u0003, true);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0005, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(45, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0014.\u0018.\u0001(2790));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(88, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0014.\u0018.\u0001(2416));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0005, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0007, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0007, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(221, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0014.\u0018.\u0001(2823));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u0014.\u0018.\u0001(2458));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0008, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0008, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(253, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0014.\u0018.\u0001(2844));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u0014.\u0018.\u0001(2496));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u000E, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000E, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(285, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0014.\u0018.\u0001(2873));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u0014.\u0018.\u0001(2530));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0006, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0006, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(45, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0014.\u0018.\u0001(2898));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(88, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 20);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0014.\u0018.\u0001(2564));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0006, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u000F, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000F, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(253, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u0014.\u0018.\u0001(2923));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u0014.\u0018.\u0001(2496));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0010, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0010, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0010, new Point(221, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0010, \u0014.\u0018.\u0001(2960));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0010, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0010, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, \u0014.\u0018.\u0001(2458));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0011, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0011, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0011, new Point(285, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0011, \u0014.\u0018.\u0001(2989));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0011, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0011, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, \u0014.\u0018.\u0001(2530));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0007, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0007, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(133, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0014.\u0018.\u0001(3022));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(56, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 18);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u0014.\u0018.\u0001(1813));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0007, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0008, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0008, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(133, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0014.\u0018.\u0001(3039));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(56, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 19);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u0014.\u0018.\u0001(1813));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0008, ContentAlignment.MiddleLeft);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0012);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0013);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0014);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0015);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0016);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0017);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0010);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0011);
      \u0096\u0086.\u007E\u0099\u008F((object) this.\u0004, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0014.\u0018.\u0001(3064));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(354, 180));
      \u0011\u001F.\u007E\u009A\u008F((object) this.\u0004, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0014.\u0018.\u0001(3077));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0004, AnchorStyles.None);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0004, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0018.\u0001(3086)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(47, 11));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0014.\u0018.\u0001(3107));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(260, 50));
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0004, 41);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0004, false);
      \u0099\u001F.\u007E\u0081\u008E((object) this.\u0004, true);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u000E, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000E, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(45, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0014.\u0018.\u0001(3120));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(88, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u0014.\u0018.\u0001(2416));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u000E, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0012, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0012, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0012, new Point(221, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0012, \u0014.\u0018.\u0001(3153));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0012, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0012, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0012, \u0014.\u0018.\u0001(2458));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0013, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0013, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0013, new Point(253, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0013, \u0014.\u0018.\u0001(3174));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0013, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0013, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0013, \u0014.\u0018.\u0001(2496));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0014, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0014, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0014, new Point(285, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0014, \u0014.\u0018.\u0001(3203));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0014, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0014, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0014, \u0014.\u0018.\u0001(2530));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u000F, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000F, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(45, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u0014.\u0018.\u0001(3228));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(88, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u0014.\u0018.\u0001(2564));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u000F, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0015, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0015, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0015, new Point(253, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0015, \u0014.\u0018.\u0001(3253));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0015, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0015, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0015, \u0014.\u0018.\u0001(2496));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0016, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0016, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0016, new Point(221, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0016, \u0014.\u0018.\u0001(3290));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0016, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0016, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u0014.\u0018.\u0001(2458));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0017, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0017, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0017, new Point(285, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0017, \u0014.\u0018.\u0001(3319));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0017, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0017, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0017, \u0014.\u0018.\u0001(2530));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0010, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0010, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0010, new Point(133, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0010, \u0014.\u0018.\u0001(3352));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0010, new Size(56, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0010, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, \u0014.\u0018.\u0001(1813));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0010, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0011, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0011, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0011, new Point(133, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0011, \u0014.\u0018.\u0001(3369));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0011, new Size(56, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0011, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, \u0014.\u0018.\u0001(1813));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0011, ContentAlignment.MiddleLeft);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u0018);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u0019);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u001A);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u0012);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u0013);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u0014);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u001B);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u001C);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u001D);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u0015);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u001E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u001F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u007F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u0016);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u0017);
      \u0096\u0086.\u007E\u0099\u008F((object) this.\u0005, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0014.\u0018.\u0001(3394));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(354, 180));
      \u0011\u001F.\u007E\u009A\u008F((object) this.\u0005, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0014.\u0018.\u0001(3415));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0005, AnchorStyles.None);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0005, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0018.\u0001(3432)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(47, 11));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0014.\u0018.\u0001(3461));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(260, 50));
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0005, 40);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0005, false);
      \u0099\u001F.\u007E\u0081\u008E((object) this.\u0005, true);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0018, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0018, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0018, new Point(221, 76));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0018, \u0014.\u0018.\u0001(3482));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0018, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0018, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0018, \u0014.\u0018.\u0001(2458));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0019, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0019, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0019, new Point(253, 76));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0019, \u0014.\u0018.\u0001(3511));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0019, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0019, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0019, \u0014.\u0018.\u0001(2496));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u001A, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001A, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001A, new Point(285, 76));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001A, \u0014.\u0018.\u0001(3548));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001A, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001A, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001A, \u0014.\u0018.\u0001(2530));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0012, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0012, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0012, new Point(45, 76));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0012, \u0014.\u0018.\u0001(3581));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0012, new Size(88, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0012, 39);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0012, \u0014.\u0018.\u0001(3614));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0012, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0013, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0013, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0013, new Point(133, 76));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0013, \u0014.\u0018.\u0001(3623));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0013, new Size(56, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0013, 38);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0013, \u0014.\u0018.\u0001(1813));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0013, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0014, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0014, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0014, new Point(45, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0014, \u0014.\u0018.\u0001(3648));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0014, new Size(88, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0014, 31);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0014, \u0014.\u0018.\u0001(2416));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0014, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u001B, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001B, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001B, new Point(221, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001B, \u0014.\u0018.\u0001(3685));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001B, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001B, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001B, \u0014.\u0018.\u0001(2458));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u001C, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001C, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001C, new Point(253, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001C, \u0014.\u0018.\u0001(3714));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001C, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001C, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001C, \u0014.\u0018.\u0001(2496));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u001D, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001D, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001D, new Point(285, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001D, \u0014.\u0018.\u0001(3751));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001D, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001D, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001D, \u0014.\u0018.\u0001(2530));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0015, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0015, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0015, new Point(45, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0015, \u0014.\u0018.\u0001(3784));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0015, new Size(88, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0015, 30);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0015, \u0014.\u0018.\u0001(2564));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0015, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u001E, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001E, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001E, new Point(253, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001E, \u0014.\u0018.\u0001(3817));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001E, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001E, 7);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001E, \u0014.\u0018.\u0001(2496));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u001F, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001F, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001F, new Point(221, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001F, \u0014.\u0018.\u0001(3858));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001F, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001F, 6);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001F, \u0014.\u0018.\u0001(2458));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u007F, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u007F, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u007F, new Point(285, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u007F, \u0014.\u0018.\u0001(3895));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u007F, new Size(24, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u007F, 8);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u007F, \u0014.\u0018.\u0001(2530));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0016, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0016, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0016, new Point(133, 108));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0016, \u0014.\u0018.\u0001(3936));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0016, new Size(56, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0016, 28);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u0014.\u0018.\u0001(1813));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0016, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0017, AnchorStyles.None);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0017, new Font(\u0014.\u0018.\u0001(2370), 12f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0017, new Point(133, 140));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0017, \u0014.\u0018.\u0001(3961));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0017, new Size(56, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0017, 29);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0017, \u0014.\u0018.\u0001(1813));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0017, ContentAlignment.MiddleLeft);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u009A\u0080.\u0016\u0081());
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u001C);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u001D);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u0018);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u0019);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u001E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u001F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u007F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u0080);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u0081);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u0082);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u001A);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u001B);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0006), (Control) this.\u0006);
      \u0096\u0086.\u007E\u0099\u008F((object) this.\u0006, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0014.\u0018.\u0001(3994));
      \u0001\u001F.\u007E\u0089\u0084((object) this.\u0006, new Padding(3));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(354, 180));
      \u0011\u001F.\u007E\u009A\u008F((object) this.\u0006, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0014.\u0018.\u0001(4011));
      \u0019\u001D.\u007E\u009B\u0088((object) this.\u0003, ComboBoxStyle.DropDownList);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0014.\u0018.\u0001(4024), 8.25f));
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0003, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(240, 87));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0014.\u0018.\u0001(4053));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(44, 21));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 2);
      \u0087\u007F.\u007E\u009C\u0088((object) this.\u0003, new EventHandler(this.\u0087\u0005));
      \u0019\u001D.\u007E\u009B\u0088((object) this.\u0002, ComboBoxStyle.DropDownList);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0014.\u0018.\u0001(4024), 8.25f));
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0002, true);
      \u0003\u0083.\u007E\u0004\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0002), new object[4]
      {
        (object) \u0014.\u0018.\u0001(1818),
        (object) \u0014.\u0018.\u0001(4066),
        (object) \u0014.\u0018.\u0001(4071),
        (object) \u0014.\u0018.\u0001(4076)
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(190, 87));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0014.\u0018.\u0001(4081));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(44, 21));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0087\u007F.\u007E\u009C\u0088((object) this.\u0002, new EventHandler(this.\u0086\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u001C, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001C, new Font(\u0014.\u0018.\u0001(2200), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001C, new Point(126, 156));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001C, \u0014.\u0018.\u0001(4094));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001C, new Size(13, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001C, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001C, \u0014.\u0018.\u0001(1813));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u001D, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001D, new Font(\u0014.\u0018.\u0001(2200), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001D, new Point(126, 136));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001D, \u0014.\u0018.\u0001(4127));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001D, new Size(13, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001D, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001D, \u0014.\u0018.\u0001(1813));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0018, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0018, new Font(\u0014.\u0018.\u0001(2200), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0018, new Point(126, 116));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0018, \u0014.\u0018.\u0001(4152));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0018, new Size(13, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0018, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0018, \u0014.\u0018.\u0001(1813));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0019, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0019, new Font(\u0014.\u0018.\u0001(2200), 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0019, new Point(187, 69));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0019, \u0014.\u0018.\u0001(4173));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0019, new Size(47, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0019, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0019, \u0014.\u0018.\u0001(4198));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u001E, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001E, new Font(\u0014.\u0018.\u0001(2200), 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001E, new Point(237, 69));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001E, \u0014.\u0018.\u0001(4211));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001E, new Size(39, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001E, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001E, \u0014.\u0018.\u0001(4232));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u001F, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001F, new Font(\u0014.\u0018.\u0001(2200), 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001F, new Point(58, 156));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001F, \u0014.\u0018.\u0001(4241));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001F, new Size(66, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001F, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001F, \u0014.\u0018.\u0001(4270));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u007F, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u007F, new Font(\u0014.\u0018.\u0001(2200), 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u007F, new Point(45, 136));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u007F, \u0014.\u0018.\u0001(4287));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u007F, new Size(79, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u007F, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u007F, \u0014.\u0018.\u0001(4308));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0080, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0080, new Font(\u0014.\u0018.\u0001(2200), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0080, new Point(172, 156));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0080, \u0014.\u0018.\u0001(4325));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0080, new Size(126, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0080, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0080, \u0014.\u0018.\u0001(4334));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0081, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0081, new Font(\u0014.\u0018.\u0001(2200), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0081, new Point(172, 136));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0081, \u0014.\u0018.\u0001(4367));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0081, new Size(155, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0081, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0081, \u0014.\u0018.\u0001(4376));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0082, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0082, new Font(\u0014.\u0018.\u0001(2200), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0082, new Point(172, 116));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0082, \u0014.\u0018.\u0001(4417));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0082, new Size(149, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0082, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0082, \u0014.\u0018.\u0001(4426));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u001A, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001A, new Font(\u0014.\u0018.\u0001(2200), 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001A, new Point(71, 116));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001A, \u0014.\u0018.\u0001(4463));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001A, new Size(53, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001A, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001A, \u0014.\u0018.\u0001(4488));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u001B, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u001B, new Font(\u0014.\u0018.\u0001(2200), 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u001B, new Point(60, 69));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u001B, \u0014.\u0018.\u0001(4501));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u001B, new Size(41, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u001B, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001B, \u0014.\u0018.\u0001(4522));
      \u0019\u001D.\u007E\u009B\u0088((object) this.\u0001, ComboBoxStyle.DropDownList);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0014.\u0018.\u0001(4024), 8.25f));
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0001, true);
      \u0003\u0083.\u007E\u0004\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), new object[6]
      {
        (object) \u0014.\u0018.\u0001(4531),
        (object) \u0014.\u0018.\u0001(4556),
        (object) \u0014.\u0018.\u0001(4581),
        (object) \u0014.\u0018.\u0001(4602),
        (object) \u0014.\u0018.\u0001(4623),
        (object) \u0014.\u0018.\u0001(4640)
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(63, 87));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0018.\u0001(4665));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(121, 21));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0087\u007F.\u007E\u009C\u0088((object) this.\u0001, new EventHandler(this.\u0084\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0006, AnchorStyles.None);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0006, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0018.\u0001(4678)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(47, 11));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0014.\u0018.\u0001(4703));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(260, 50));
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0006, 41);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0006, false);
      \u0099\u001F.\u007E\u0081\u008E((object) this.\u0006, true);
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[3]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0007,
        (ToolStripItem) this.\u000F
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0018.\u0001(4720));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(362, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0014.\u0018.\u0001(4741));
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
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0014.\u0018.\u0001(4758));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(37, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0014.\u0018.\u0001(4771));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0014.\u0018.\u0001(4780));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0002, Keys.N | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0014.\u0018.\u0001(4789));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0014.\u0018.\u0001(4798));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0003, Keys.O | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0014.\u0018.\u0001(4811));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0014.\u0018.\u0001(4820));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0014.\u0018.\u0001(4849));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0004, Keys.S | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u0014.\u0018.\u0001(4862));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0014.\u0018.\u0001(4871));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0005, Keys.S | Keys.Shift | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u0014.\u0018.\u0001(4892));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0014.\u0018.\u0001(4909));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u0014.\u0018.\u0001(4938));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0006, Keys.W | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u0014.\u0018.\u0001(4955));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(this.\u0081\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0007), new ToolStripItem[2]
      {
        (ToolStripItem) this.\u0008,
        (ToolStripItem) this.\u000E
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u0014.\u0018.\u0001(4964));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(61, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u0014.\u0018.\u0001(4985));
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0008, true);
      \u0014\u001D.\u007E\u008E\u008D((object) this.\u0008, CheckState.Checked);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0008, \u0014.\u0018.\u0001(4998));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0008, new Size(190, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0008, \u0014.\u0018.\u0001(5023));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0008, new EventHandler(this.\u0082\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000E, \u0014.\u0018.\u0001(5056));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000E, new Size(190, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000E, \u0014.\u0018.\u0001(5077));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000E, new EventHandler(this.\u0083\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u000F), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0010
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000F, \u0014.\u0018.\u0001(5090));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000F, new Size(44, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000F, \u0014.\u0018.\u0001(5107));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0010, \u0014.\u0018.\u0001(5116));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0010, Keys.F1);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0010, new Size(124, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0010, \u0014.\u0018.\u0001(5137));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0010, new EventHandler(this.\u0088\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(362, 232));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0014.\u0018.\u0001(5146)));
      \u001A\u001D.\u0019\u008B((object) this, this.\u0001);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0014.\u0018.\u0001(5163));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0014.\u0018.\u0001(5176));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0002, false);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0002);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0003, false);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0003);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0004, false);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0004);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0005, false);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0005);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0006, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0006);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0006);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u0081\u0005()
    {
      this.\u0082\u0005();
      this.\u0083\u0005();
      this.\u0084\u0005();
      this.\u0086\u0005();
      this.\u008C\u0005();
      this.\u008D\u0005();
      this.\u008A\u0005();
      this.\u008B\u0005();
      this.\u0088\u0005();
      this.\u0089\u0005();
      this.\u0087\u0005();
    }

    private void \u0082\u0005()
    {
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u000E, this.\u0001.TopMost);
      \u0099\u001F.\u0086\u008B((object) this, this.\u0001.TopMost);
    }

    private void \u0083\u0005()
    {
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0008, this.\u0001.AutoUpdate);
    }

    private void \u0084\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, this.\u0001.RuralTrackQualifies.ToString());
    }

    private void \u0086\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, this.\u0001.RuralTrackWins.ToString());
    }

    private void \u0087\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0013, this.\u0001.TournamentSwept.ToString());
    }

    private void \u0088\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0017, this.\u0001.TournamentQualifies.ToString());
    }

    private void \u0089\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, this.\u0001.TournamentWins.ToString());
    }

    private void \u008A\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, this.\u0001.UrbanTrackQualifies.ToString());
    }

    private void \u008B\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, this.\u0001.UrbanTrackWins.ToString());
    }

    private void \u008C\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, this.\u0001.SpeedwayTrackQualifies.ToString());
    }

    private void \u008D\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, this.\u0001.SpeedwayTrackWins.ToString());
    }

    private ushort \u001D\u0005(ushort value)
    {
      \u0082 obj = new \u0082();
      try
      {
        \u0092\u0081.\u007E\u001D\u0084((object) obj, \u0014.\u0018.\u0001(5205));
        obj.LabelMessage = \u0014.\u0018.\u0001(5270);
        obj.MaximumValue = (int) ushort.MaxValue;
        obj.MinimumValue = 0;
        obj.Value = (int) value;
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj) == DialogResult.OK)
        {
          this.FileModified = true;
          return (ushort) ((\u0003) obj).Value;
        }
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
      return value;
    }

    protected override void \u001D\u0005(\u0084.\u001B fileName, bool modified)
    {
      if (!\u0084.\u001B.\u001D\u0005(fileName, (object) null))
      {
        if (modified)
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u009E\u0081.\u001F\u0093(\u0014.\u0018.\u0001(5340), (object) fileName.\u0001));
        else
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0081\u0086.\u0086\u0093(\u0014.\u0018.\u0001(5365), fileName.\u0001));
      }
      else if (modified)
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u0014.\u0018.\u0001(5307));
      else
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u0014.\u0018.\u0001(5176));
    }

    protected override bool \u001E\u0005(out \u0084.\u001B fileName)
    {
      \u0084.\u001B selectedFile;
      bool flag = \u007F.\u007F\u0005(out selectedFile);
      fileName = !flag ? (\u0084.\u001B) null : selectedFile;
      return flag;
    }

    protected override bool \u001E\u0005(\u0084.\u001B fileName)
    {
      try
      {
        this.\u0001 = new \u0002(fileName.\u0002);
        return true;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u0014.\u0018.\u0001(5386), (object) fileName.\u0002));
        \u0017.\u001D\u0005(ex, fileName.\u0002);
        return false;
      }
    }

    protected override void \u001E\u0005(\u0084.\u001B fileName)
    {
      this.\u0081\u0005();
    }

    protected override void \u001D\u0005()
    {
      this.\u0001 = new \u0002();
      this.\u0081\u0005();
    }

    protected override bool \u001D\u0005(out \u0084.\u001B fileName)
    {
      \u0008 obj = new \u0008();
      try
      {
        obj.LabelMessage = \u0014.\u0018.\u0001(5423);
        \u0092\u0081.\u007E\u001D\u0084((object) obj, \u0014.\u0018.\u0001(5500));
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj) == DialogResult.OK)
        {
          fileName = new \u0084.\u001B(obj.Value, \u001A.\u0016.\u001E\u0005(\u007F.RaceTrackSettingsDirectory, \u0014.\u0018.\u0001(5561)));
          return true;
        }
        fileName = (\u0084.\u001B) null;
        return false;
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
    }

    protected override void \u001D\u0005(\u0084.\u001B fileName)
    {
      this.\u007F\u0005(fileName);
    }

    protected override bool \u001D\u0005(\u0084.\u001B fileName)
    {
      try
      {
        this.\u0001.\u001D\u0005(fileName.\u0002);
        this.\u007F\u0005(fileName);
        return true;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u0014.\u0018.\u0001(5386), (object) fileName.\u0002));
        \u0017.\u001D\u0005(ex, fileName.\u0002);
        return false;
      }
    }

    private void \u007F\u0005(\u0084.\u001B fileName)
    {
      if (this.\u0001.Files.Contains(fileName))
        return;
      this.\u0001.Files.Add(fileName);
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0008, !\u0099\u0082.\u007E\u008C\u008D((object) this.\u0008));
      this.\u0001.AutoUpdate = \u0099\u0082.\u007E\u008C\u008D((object) this.\u0008);
      this.FileModified = true;
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u000E, !\u0099\u0082.\u007E\u008C\u008D((object) this.\u000E));
      this.\u0001.TopMost = \u0099\u0082.\u007E\u008C\u008D((object) this.\u000E);
      \u0099\u001F.\u0086\u008B((object) this, this.\u0001.TopMost);
      this.FileModified = true;
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      this.\u008F\u0005();
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      this.\u008E\u0005();
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      this.\u008F\u0005();
    }

    private void \u008E\u0005()
    {
      \u001A\u001E.\u007E\u0005\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0003));
      switch (\u0005\u0081.\u007E\u0008\u0088((object) this.\u0002))
      {
        case 0:
          \u008C\u0080.\u007E\u0007\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0003), 0, (object) \u0014.\u0018.\u0001(5585));
          break;
        case 1:
          \u008C\u0080.\u007E\u0007\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0003), 0, (object) \u0014.\u0018.\u0001(5580));
          goto case 0;
        case 2:
          \u008C\u0080.\u007E\u0007\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0003), 0, (object) \u0014.\u0018.\u0001(5575));
          goto case 1;
        case 3:
          \u008C\u0080.\u007E\u0007\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0003), 0, (object) \u0014.\u0018.\u0001(5570));
          goto case 2;
      }
      \u0011\u001F.\u007E\u000E\u0088((object) this.\u0003, 0);
    }

    private void \u008F\u0005()
    {
      if (\u0005\u0081.\u007E\u0008\u0088((object) this.\u0002) == -1 || \u0005\u0081.\u007E\u0008\u0088((object) this.\u0003) == -1 || \u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) == -1)
      {
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0018, \u0014.\u0018.\u0001(1813));
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u001C, \u0014.\u0018.\u0001(1813));
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u001D, \u0014.\u0018.\u0001(1813));
      }
      else
      {
        switch (\u0005\u0081.\u007E\u0008\u0088((object) this.\u0001))
        {
          case 0:
            this.\u001D\u0005(\u0014.\u0018.\u0001);
            break;
          case 1:
            this.\u001D\u0005(\u0014.\u0018.\u0002);
            break;
          case 2:
            this.\u001D\u0005(\u0014.\u0018.\u0003);
            break;
          case 3:
            this.\u001D\u0005(\u0014.\u0018.\u0004);
            break;
          case 4:
            this.\u001D\u0005(\u0014.\u0018.\u0005);
            break;
          case 5:
            this.\u001D\u0005(\u0014.\u0018.\u0006);
            break;
        }
      }
    }

    private void \u001D\u0005(int deposit)
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0018, deposit.ToString());
      int num = 0;
      switch (\u0005\u0081.\u007E\u0008\u0088((object) this.\u0002) - \u0005\u0081.\u007E\u0008\u0088((object) this.\u0003))
      {
        case 0:
          num = deposit + (int) \u0007\u0081.\u0094\u0096((double) deposit * 0.150000005960464);
          break;
        case 1:
          num = deposit + (int) \u0007\u0081.\u0094\u0096((double) deposit * 0.5);
          break;
        case 2:
          num = deposit + (int) \u0007\u0081.\u0094\u0096((double) deposit * 1.0);
          break;
        case 3:
          num = deposit + (int) \u0007\u0081.\u0094\u0096((double) deposit * 3.0);
          break;
      }
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001D, num.ToString());
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u001C, (num - deposit).ToString());
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      \u0082.\u001D\u0005(\u0002.\u0010);
    }
  }
}
