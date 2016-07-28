// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0004;
using \u0012;
using \u001C;
using \u001E;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace \u001C
{
  internal sealed class \u001D : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0010.\u001E \u0001;
    private \u0083.\u0013 \u0001;
    private Button \u0001;
    private Button \u0002;
    private Button \u0003;
    private Button \u0004;
    private Button \u0005;
    private Timer \u0001;
    private Label \u0001;
    private string \u0001;
    private bool \u0001;

    static \u001D()
    {
      \u0001.\u0004.\u001D\u0005(typeof (\u001D));
    }

    public \u001D()
    {
      this.\u001D\u0005();
      this.\u0001.\u001D\u0005().autoStart = false;
      this.\u0001.Value = (float) this.\u0001.\u001D\u0005().volume;
      this.\u0080\u0005();
      this.\u0081\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      this.\u007F\u0005();
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001D)));
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0003 = new Button();
      this.\u0004 = new Button();
      this.\u0005 = new Button();
      this.\u0001 = new Timer(this.\u0001);
      this.\u0001 = new Label();
      this.\u0001 = new \u0010.\u001E();
      this.\u0001 = new \u0083.\u0013();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.None);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001D.\u0001(61118)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(60, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001D.\u0001(61139));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(28, 28));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 10);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.None);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0002, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001D.\u0001(61152)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(60, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001D.\u0001(61173));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(28, 28));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 10);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0002, false);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0003, AnchorStyles.None);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0003, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001D.\u0001(61186)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(32, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001D.\u0001(61207));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(28, 28));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 11);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0003, false);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u0080\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0004, AnchorStyles.None);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0004, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001D.\u0001(61220)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(4, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u001D.\u0001(61241));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(28, 28));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 11);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0004, false);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u0081\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0005, AnchorStyles.None);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0005, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001D.\u0001(61254)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(4, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u001D.\u0001(61275));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(28, 28));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 12);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0005, false);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0005, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0005, new EventHandler(this.\u007F\u0005));
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 750);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler(this.\u0082\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.None);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(146, 10));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001D.\u0001(61288));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(60, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001D.\u0001(61301));
      \u0099\u001F.\u007E\u009F\u0086((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 100));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001D.\u0001(61318));
      \u009B\u001C.\u007E\u0001\u0087((object) this.\u0001, (AxHost.State) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001D.\u0001(61331)));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(224, 50));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
      this.\u0001.\u001D\u0005(new \u0082(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.None);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(89, 5));
      this.\u0001.MaxValue = 100f;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001D.\u0001(61356));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(51, 22));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 9);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001D.\u0001(61369));
      this.\u0001.TrackerColor = \u008E\u001D.\u0017\u007F(24, 130, 198);
      this.\u0001.TrackLineColor = \u008E\u001D.\u0017\u007F(90, 93, 90);
      this.\u0001.Value = 50f;
      this.\u0001.ValueChanged += new EventHandler(this.\u001D\u0005);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u009A\u0080.\u0008\u007F());
      \u0012\u0082.\u009D\u0090((object) this, BorderStyle.FixedSingle);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u0092\u0081.\u0010\u0084((object) this, \u001D.\u0001(61382));
      \u000E\u001F.\u0018\u0084((object) this, new Size(224, 34));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    public void \u001D\u0005(string fileName, byte[] data)
    {
      this.\u001F\u0005();
      \u0081\u0086 obj = \u0081\u0086.\u0011\u009F;
      string str1 = \u008E\u001E.\u000F\u009F();
      Guid guid = \u009E\u0080.\u000F\u0096();
      string str2 = \u0081\u0086.\u0086\u0093(guid.ToString(), \u009C\u0080.\u0006\u009F(fileName));
      this.\u0001 = obj(str1, str2);
      this.\u001D\u0005(data);
    }

    public void \u001E\u0005()
    {
      this.\u0001.\u001D\u0005(string.Empty);
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0005, false);
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0004, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, false);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, false);
    }

    public void \u001F\u0005()
    {
      this.\u001E\u0005();
      this.\u007F\u0005();
    }

    private void \u001D\u0005(byte[] data)
    {
      if (this.\u0001)
        return;
      bool flag = false;
      try
      {
        \u0019.\u0012.\u001D\u0005(data, this.\u0001);
        flag = true;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u001D.\u0001(61407), (object) this.\u0001));
      }
      if (flag)
      {
        this.\u0001 = true;
        this.\u0001.\u001D\u0005(this.\u0001);
      }
      else
        this.\u0001.\u001D\u0005(\u001D.\u0001(4918));
    }

    private void \u007F\u0005()
    {
      if (!this.\u0001)
        return;
      this.\u0001 = false;
      try
      {
        \u009C\u001F.\u0091\u009E(this.\u0001);
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u001D.\u0001(61440), (object) this.\u0001));
      }
    }

    private void \u0080\u0005()
    {
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0002, this.\u0001.\u001D\u0005().mute);
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, !this.\u0001.\u001D\u0005().mute);
    }

    private void \u0081\u0005()
    {
      switch (this.\u0001.\u001D\u0005())
      {
        case \u0016.\u0002:
        case \u0016.\u000E:
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, false);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0004, true);
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0005, false);
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          break;
        case \u0016.\u0003:
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0004, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0005, false);
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          break;
        case \u0016.\u0004:
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0004, false);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0005, true);
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
          break;
        case \u0016.\u0007:
        case \u0016.\u0008:
        case \u0016.\u000F:
        case \u0016.\u0010:
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, false);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0004, true);
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0005, false);
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          break;
        default:
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, false);
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, false);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0004, true);
          \u0099\u001F.\u007E\u0082\u0084((object) this.\u0005, false);
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          break;
      }
      this.\u0082\u0005();
    }

    private void \u0082\u0005()
    {
      try
      {
        if (this.\u0001.\u001D\u0005().currentItem == null)
        {
          \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001D.\u0001(61473));
        }
        else
        {
          \u0092\u0081 obj = \u0092\u0081.\u007E\u001D\u0084;
          Label label = this.\u0001;
          TimeSpan timeSpan = \u0003\u0080.\u008C\u0097(this.\u0001.\u001D\u0005().currentPosition);
          string str = \u001F\u0082.\u0087\u0093(timeSpan.ToString(\u001D.\u0001(61494)), \u001D.\u0001(61503), \u0003\u0080.\u008C\u0097(this.\u0001.\u001D\u0005().currentItem.duration).ToString(\u001D.\u0001(61494)));
          obj((object) label, str);
        }
      }
      catch (InvalidComObjectException ex)
      {
      }
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001D\u0005().volume = (int) this.\u0001.Value;
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001D\u0005().mute = true;
      this.\u0080\u0005();
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001D\u0005().mute = false;
      this.\u0080\u0005();
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001D\u0005().\u008F();
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001D\u0005().\u0083();
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001D\u0005().\u008E();
    }

    private void \u001D\u0005(object sender, \u0013.\u0001 e)
    {
      this.\u0081\u0005();
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.\u0082\u0005();
    }
  }
}
