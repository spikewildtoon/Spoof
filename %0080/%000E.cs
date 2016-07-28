// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0018;
using \u0019;
using \u001A;
using \u001D;
using \u001E;
using \u0080;
using \u0082;
using \u0083;
using \u0084;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0080
{
  internal sealed class \u000E : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private \u0082.\u0018 \u0001;
    private bool \u0001;
    private \u001D.\u0001 \u0001;
    private int \u0001;
    private IContainer \u0001;
    private \u0019.\u0080 \u0001;
    private GroupBox \u0001;
    private \u0010 \u0001;
    private Button \u0001;
    private Button \u0002;
    private \u001A.\u0082 \u0001;
    private Label \u0001;
    private CheckBox \u0001;
    private CheckBox \u0002;
    private CheckBox \u0003;
    private RadioButton \u0001;
    private RadioButton \u0002;
    private CheckBox \u0004;
    private \u0010 \u0002;
    private \u0010 \u0003;
    private \u0019.\u0080 \u0002;
    private Label \u0002;
    private TextBox \u0001;
    private Button \u0003;
    private Button \u0004;
    private StatusStrip \u0001;
    private ToolStripStatusLabel \u0001;
    private Label \u0003;
    private Label \u0004;
    private Label \u0005;
    private Panel \u0001;
    private Button \u0005;
    private TabControl \u0001;
    private TabPage \u0001;
    private TabPage \u0002;
    private GroupBox \u0002;
    private RadioButton \u0003;
    private RadioButton \u0004;
    private RadioButton \u0005;
    private RadioButton \u0006;
    private Label \u0006;
    private \u0010 \u0004;
    private GroupBox \u0003;
    private GroupBox \u0004;
    private Button \u0006;
    private Button \u0007;
    private Label \u0007;
    private TextBox \u0002;
    private FolderBrowserDialog \u0001;
    private PictureBox \u0001;
    private \u001D.\u0080 \u0001;
    private Label \u0008;
    private GroupBox \u0005;
    private Label \u000E;
    private \u0010 \u0005;
    private Label \u000F;
    private Button \u0008;
    private TextBox \u0003;

    static \u000E()
    {
      \u0004.\u001D\u0005(typeof (\u000E));
    }

    public \u000E()
    {
      this.\u007F\u0005();
      \u0080\u0086.\u0016\u008B((object) this, \u0013.GenericSettings_Icon);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0001, (Image) \u0013.Cancel_16x16);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0002, (Image) \u0013.Checkmark_16x16);
      this.\u0001 = \u0081.\u0080.Instance.ApplicationSettings;
      this.\u0001 = \u0081.\u0080.Instance.ConnectSettings;
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u001A.\u007F.CommonApplicationDataDirectory);
      this.\u001D\u0005();
      this.\u001D\u0005(false);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.\u0001.HotkeysEnabled)
        \u0007.\u0001.\u001E\u0005();
      this.\u001E\u0005();
      switch (this.\u0001.UpdateType)
      {
        case \u000E.\u0001:
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0006, true);
          break;
        case \u000E.\u0002:
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0005, true);
          break;
        case \u000E.\u0003:
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0004, true);
          break;
        case \u000E.\u0004:
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0003, true);
          break;
      }
      this.\u0004.Value = this.\u0001.PatchServerPort;
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, this.\u0001.ScreenshotSaveDirectory);
      this.\u0005.Value = this.\u0001.MaximumSimultaneousDownloads;
    }

    private void \u001D\u0005(object sender, FormClosedEventArgs e)
    {
      if (!this.\u0001.HotkeysEnabled)
        return;
      \u0007.\u0001.\u001D\u0005();
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (\u0013\u0080.\u0089\u0091((object) this.\u0001, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83266));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0002, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83379));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0001, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83436));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0001, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83489));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0004, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83586));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0003, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83627));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0001, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83708));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0002, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83761));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0001, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83846));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0002, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83895));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0002, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(83940));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0004, sender) || \u0013\u0080.\u0089\u0091((object) this.\u0001, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84009));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0001, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84114));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0003, sender) || \u0013\u0080.\u0089\u0091((object) this.\u0003, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84171));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0003, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84268));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0005, sender) || \u0013\u0080.\u0089\u0091((object) this.\u0002, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84337));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0004, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84438));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0006, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84547));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0005, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84656));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0004, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84781));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0003, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84906));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0004, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(84987));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0002, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(85100));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0006, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(85185));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0008, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(85306));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0003, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(85407));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0007, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(85472));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0005, sender))
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(85557));
      else if (\u0013\u0080.\u0089\u0091((object) this.\u0001, sender))
      {
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(85594));
      }
      else
      {
        if (!\u0013\u0080.\u0089\u0091((object) this.\u0005, sender))
          return;
        \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(85627));
      }
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005();
      this.\u0001 = 0;
    }

    private void \u001D\u0005()
    {
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(85752));
    }

    private void \u001E\u0005()
    {
      \u001A\u001E.\u007E\u001F\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001));
      foreach (\u0012 key in this.\u0001.Hotkeys.Keys)
      {
        int num = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) key);
      }
    }

    private void \u001D\u0005(bool enable)
    {
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, enable);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, enable);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, enable);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, enable);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, enable);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (\u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) == null)
        return;
      \u0012 obj = (\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001);
      this.\u0001 = true;
      this.\u0001.Hotkey = obj;
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, false);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, false);
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      this.\u0002.Enabled = this.\u0001.Key != Keys.None || this.\u0001.Modifiers != Keys.None;
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      \u0012 hotkey = this.\u0001.Hotkey;
      if (!this.\u001D\u0005(hotkey))
        return;
      if (this.\u0001)
      {
        \u0012 key = (\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001);
        \u0014.\u0081 obj = this.\u0001.Hotkeys[key];
        this.\u0001.Hotkeys.Remove(key);
        obj.Hotkey = hotkey;
        this.\u0001.Hotkeys.Add(hotkey, obj);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, true);
        \u008C\u0080.\u007E\u001E\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), \u0005\u0081.\u007E\u0008\u0088((object) this.\u0001), (object) hotkey);
        this.\u0001.\u0087\u0002(\u0005\u0081.\u007E\u0008\u0088((object) this.\u0001));
        this.\u0001.Hotkey = new \u0012();
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, true);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, true);
        this.\u0001 = false;
      }
      else if (\u0013\u0080.\u007E\u007F\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) hotkey))
      {
        \u0018.\u0017.\u001D\u0005(\u000E.\u0001(85809), \u000E.\u0001(85926));
      }
      else
      {
        this.\u0001.Hotkeys.Add(hotkey, new \u0014.\u0081()
        {
          Hotkey = hotkey
        });
        int num = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) hotkey);
        \u008E\u007F.\u007E\u0013\u0088((object) this.\u0001, (object) hotkey);
        this.\u0001.Hotkey = new \u0012();
      }
    }

    private bool \u001D\u0005(\u0012 hotkey)
    {
      if (hotkey.Key == Keys.Escape || hotkey.Key == Keys.Oemplus && (hotkey.Modifier == Keys.Control || hotkey.Modifier == (Keys.Shift | Keys.Control)))
      {
        \u0018.\u0017.\u001D\u0005(\u000E.\u0001(85955), \u000E.\u0001(86085));
        return false;
      }
      if (!\u000E.\u001D\u0005(\u0088\u0086.\u0097\u0083((object) this), 49151, hotkey.NativeModifier, hotkey.Key))
      {
        \u0018.\u0017.\u001E\u0005(\u000E.\u0001(86106), \u000E.\u0001(86288));
        return false;
      }
      \u000E.\u001D\u0005(\u0088\u0086.\u0097\u0083((object) this), 49151);
      return true;
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.\u0001.Hotkey = new \u0012();
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, true);
      this.\u0001 = false;
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      bool flag = \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) != null;
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, flag);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, flag);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, flag);
      this.\u0004.Enabled = flag && !this.\u0001;
      if (flag)
      {
        \u0014.\u0081 obj = this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)];
        \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, obj.HotkeyType == \u0018.\u007F.\u0001);
        \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, obj.HotkeyType == \u0018.\u007F.\u0002);
        this.\u0002.Hotkey = !\u0095\u001C.\u0099\u0091((object) obj.KeyToPress, (Enum) Keys.Control) ? (!\u0095\u001C.\u0099\u0091((object) obj.KeyToPress, (Enum) Keys.Alt) ? (!\u0095\u001C.\u0099\u0091((object) obj.KeyToPress, (Enum) Keys.Shift) ? new \u0012(obj.KeyToPress, Keys.None) : new \u0012(Keys.None, Keys.Shift)) : new \u0012(Keys.None, Keys.Alt)) : new \u0012(Keys.None, Keys.Control);
        this.\u0002.Value = obj.MoveMouseRate;
        this.\u0001.Value = obj.KeyPressRepeatRate;
        this.\u0003.Value = obj.KeyReleaseDelay;
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0003, obj.MoveMouse);
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, obj.ReleaseKey);
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, obj.RepeatKeyPress);
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0004, obj.StopOtherHotkeys);
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, obj.Description);
        this.\u001D\u0005(obj.HotkeyType == \u0018.\u007F.\u0001);
      }
      else
      {
        this.\u001D\u0005(false);
        \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, false);
        \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, false);
        this.\u0002.Hotkey = new \u0012();
        this.\u0002.Value = 0;
        this.\u0001.Value = 0;
        this.\u0003.Value = 0;
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0003, false);
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, false);
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, false);
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0004, false);
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, string.Empty);
      }
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      if (\u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) == null || !\u0099\u0082.\u007E\u0090\u008E((object) this.\u0002))
        return;
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].HotkeyType = \u0018.\u007F.\u0002;
      this.\u001D\u0005(false);
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      if (\u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) == null || !\u0099\u0082.\u007E\u0090\u008E((object) this.\u0001))
        return;
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].HotkeyType = \u0018.\u007F.\u0001;
      this.\u001D\u0005(true);
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      if (\u0099\u0082.\u007E\u008E\u0083((object) this.\u0002) && \u0099\u0082.\u007E\u0002\u0088((object) this.\u0002))
      {
        \u0099\u001F obj = \u0099\u001F.\u007E\u008F\u0083;
        Label label = this.\u0004;
        bool flag;
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, flag = true);
        int num = flag ? 1 : 0;
        obj((object) label, num != 0);
      }
      else
      {
        \u0099\u001F obj = \u0099\u001F.\u007E\u008F\u0083;
        Label label = this.\u0004;
        bool flag;
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, flag = false);
        int num = flag ? 1 : 0;
        obj((object) label, num != 0);
      }
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      if (\u0099\u0082.\u007E\u008E\u0083((object) this.\u0001) && \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001))
      {
        \u0099\u001F obj = \u0099\u001F.\u007E\u008F\u0083;
        Label label = this.\u0003;
        bool flag;
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, flag = true);
        int num = flag ? 1 : 0;
        obj((object) label, num != 0);
      }
      else
      {
        \u0099\u001F obj = \u0099\u001F.\u007E\u008F\u0083;
        Label label = this.\u0003;
        bool flag;
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, flag = false);
        int num = flag ? 1 : 0;
        obj((object) label, num != 0);
      }
    }

    private void \u0089\u0005(object sender, EventArgs e)
    {
      this.\u0003.Enabled = this.\u0003.Enabled = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001) && \u0099\u0082.\u007E\u008E\u0083((object) this.\u0001);
      if (!\u0099\u0082.\u007E\u008E\u0083((object) this.\u0001))
        return;
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].ReleaseKey = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001);
    }

    private void \u008A\u0005(object sender, EventArgs e)
    {
      if (\u0099\u0082.\u007E\u008E\u0083((object) this.\u0003) && \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003))
      {
        \u0099\u001F obj = \u0099\u001F.\u007E\u008F\u0083;
        Label label = this.\u0005;
        bool flag;
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, flag = true);
        int num = flag ? 1 : 0;
        obj((object) label, num != 0);
      }
      else
      {
        \u0099\u001F obj = \u0099\u001F.\u007E\u008F\u0083;
        Label label = this.\u0005;
        bool flag;
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, flag = false);
        int num = flag ? 1 : 0;
        obj((object) label, num != 0);
      }
    }

    private void \u008B\u0005(object sender, EventArgs e)
    {
      this.\u0001.Enabled = this.\u0004.Enabled = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0002) && \u0099\u0082.\u007E\u008E\u0083((object) this.\u0002);
      if (!\u0099\u0082.\u007E\u008E\u0083((object) this.\u0002))
        return;
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].RepeatKeyPress = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0002);
    }

    private void \u008C\u0005(object sender, EventArgs e)
    {
      this.\u0002.Enabled = this.\u0005.Enabled = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003) && \u0099\u0082.\u007E\u008E\u0083((object) this.\u0003);
      if (!\u0099\u0082.\u007E\u008E\u0083((object) this.\u0003))
        return;
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].MoveMouse = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003);
    }

    private void \u008D\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u008E\u0083((object) this.\u0001))
        return;
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].KeyPressRepeatRate = this.\u0001.Value;
    }

    private void \u008E\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u008E\u0083((object) this.\u0003))
        return;
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].KeyReleaseDelay = this.\u0003.Value;
    }

    private void \u008F\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u008E\u0083((object) this.\u0002))
        return;
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].MoveMouseRate = this.\u0002.Value;
    }

    private void \u0090\u0005(object sender, EventArgs e)
    {
      if (\u0099\u0082.\u007E\u008E\u0083((object) this.\u0002))
        goto label_2;
label_1:
      this.\u001F\u0005();
      return;
label_2:
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].KeyToPress = this.\u0002.Modifiers != Keys.None ? (!\u0095\u001C.\u0099\u0091((object) this.\u0002.Modifiers, (Enum) Keys.Control) ? (!\u0095\u001C.\u0099\u0091((object) this.\u0002.Modifiers, (Enum) Keys.Alt) ? (!\u0095\u001C.\u0099\u0091((object) this.\u0002.Modifiers, (Enum) Keys.Shift) ? this.\u0002.Key : Keys.Shift) : Keys.Alt) : Keys.Control) : this.\u0002.Key;
      goto label_1;
    }

    private void \u0091\u0005(object sender, EventArgs e)
    {
      this.\u001F\u0005();
    }

    private void \u001F\u0005()
    {
      if (!\u0099\u0082.\u007E\u008E\u0083((object) this.\u0002))
      {
        \u0099\u001F obj = \u0099\u001F.\u007E\u008F\u0083;
        CheckBox checkBox = this.\u0001;
        bool flag;
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, flag = false);
        int num = flag ? 1 : 0;
        obj((object) checkBox, num != 0);
      }
      else
      {
        \u0014.\u0081 obj = this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)];
        this.\u0001.Enabled = this.\u0002.Enabled = obj.KeyToPress != Keys.None && obj.HotkeyType == \u0018.\u007F.\u0001;
      }
    }

    private void \u0092\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u008E\u0083((object) this.\u0004))
        return;
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].StopOtherHotkeys = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0004);
    }

    private void \u0093\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u008E\u0083((object) this.\u0001))
        return;
      this.\u0001.Hotkeys[(\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001)].Description = \u0002\u007F.\u007E\u001C\u0084((object) this.\u0001);
    }

    private void \u0094\u0005(object sender, EventArgs e)
    {
      this.\u0001.Hotkeys.Remove((\u0012) \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001));
      \u0011\u001F.\u007E\u0083\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), \u0005\u0081.\u007E\u0008\u0088((object) this.\u0001));
    }

    private void \u0095\u0005(object sender, EventArgs e)
    {
      \u0011\u001F.\u007E\u000E\u0088((object) this.\u0001, -1);
      this.\u0001.\u001D\u0005();
      this.\u001E\u0005();
    }

    private void \u0096\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u0006))
        return;
      this.\u0001.UpdateType = \u000E.\u0001;
    }

    private void \u0097\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u0005))
        return;
      this.\u0001.UpdateType = \u000E.\u0002;
    }

    private void \u0098\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u0004))
        return;
      this.\u0001.UpdateType = \u000E.\u0003;
    }

    private void \u0099\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u0003))
        return;
      this.\u0001.UpdateType = \u000E.\u0004;
    }

    private void \u009A\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001D\u0005(object sender, FormClosingEventArgs e)
    {
      if (this.\u0004.Value != this.\u0001.PatchServerPort)
        goto label_3;
label_2:
      this.\u0001.MaximumSimultaneousDownloads = this.\u0005.Value;
      return;
label_3:
      if (!\u001C.CanChangeVirtualServerPort)
      {
        this.\u0004.Value = this.\u0001.PatchServerPort;
        goto label_2;
      }
      else
      {
        this.\u0001.PatchServerPort = this.\u0004.Value;
        goto label_2;
      }
    }

    private void \u009B\u0005(object sender, EventArgs e)
    {
      \u0003.\u001D\u0005(\u001A.\u007F.CommonApplicationDataDirectory);
    }

    private void \u009C\u0005(object sender, EventArgs e)
    {
      if (!\u001C.CanChangeScreenshotDirectory)
        return;
      \u0092\u0081.\u007E\u0002\u008B((object) this.\u0001, this.\u0001.ScreenshotSaveDirectory);
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK)
        return;
      string screenshotSaveDirectory = this.\u0001.ScreenshotSaveDirectory;
      string destinationDirectory = \u0002\u007F.\u007E\u0001\u008B((object) this.\u0001);
      if (!\u008F\u0084.\u009E\u0092(screenshotSaveDirectory) && \u008F\u0084.\u001D\u009E(screenshotSaveDirectory))
      {
        string[] files = \u0012.\u001D\u0005(screenshotSaveDirectory, \u000E.\u0001(36937), \u000E.\u0001(44929));
        if (files.Length > 0)
        {
          switch (\u0018.\u0017.\u001E\u0005(\u000E.\u0001(86309), \u000E.\u0001(86406), \u0016.\u0006, \u0016.\u0007, \u0016.\u0002))
          {
            case DialogResult.Cancel:
              return;
            case DialogResult.Yes:
              \u0002.\u001D\u0005(files, destinationDirectory);
              break;
          }
        }
      }
      this.\u0001.ScreenshotSaveDirectory = destinationDirectory;
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, destinationDirectory);
    }

    private void \u009D\u0005(object sender, EventArgs e)
    {
      \u0003.\u001D\u0005(this.\u0001.ScreenshotSaveDirectory);
    }

    private void \u009E\u0005(object sender, EventArgs e)
    {
      switch (this.\u0001)
      {
        case 0:
          \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(86435));
          break;
        case 1:
          \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(86460));
          break;
        case 2:
          \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(86485));
          break;
        case 3:
          \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(86510));
          break;
        case 6:
          \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u000E.\u0001(86535));
          this.\u0001.Enabled = true;
          break;
      }
      ++this.\u0001;
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u000F);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u007F\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u000E)));
      this.\u0001 = new GroupBox();
      this.\u0001 = new Panel();
      this.\u0001 = new TextBox();
      this.\u0003 = new Label();
      this.\u0004 = new Label();
      this.\u0005 = new Label();
      this.\u0004 = new CheckBox();
      this.\u0002 = new RadioButton();
      this.\u0001 = new RadioButton();
      this.\u0001 = new Label();
      this.\u0003 = new CheckBox();
      this.\u0001 = new CheckBox();
      this.\u0002 = new CheckBox();
      this.\u0003 = new Button();
      this.\u0004 = new Button();
      this.\u0002 = new Label();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0001 = new StatusStrip();
      this.\u0001 = new ToolStripStatusLabel();
      this.\u0005 = new Button();
      this.\u0001 = new TabControl();
      this.\u0001 = new TabPage();
      this.\u0005 = new GroupBox();
      this.\u000E = new Label();
      this.\u0001 = new PictureBox();
      this.\u0003 = new GroupBox();
      this.\u0006 = new Button();
      this.\u0007 = new Button();
      this.\u0007 = new Label();
      this.\u0002 = new TextBox();
      this.\u0004 = new GroupBox();
      this.\u0006 = new Label();
      this.\u0002 = new GroupBox();
      this.\u0003 = new RadioButton();
      this.\u0004 = new RadioButton();
      this.\u0005 = new RadioButton();
      this.\u0006 = new RadioButton();
      this.\u0002 = new TabPage();
      this.\u0001 = new FolderBrowserDialog();
      this.\u0008 = new Label();
      this.\u000F = new Label();
      this.\u0003 = new TextBox();
      this.\u0008 = new Button();
      this.\u0005 = new \u0010();
      this.\u0004 = new \u0010();
      this.\u0002 = new \u0019.\u0080();
      this.\u0001 = new \u0010();
      this.\u0003 = new \u0010();
      this.\u0002 = new \u0010();
      this.\u0001 = new \u001A.\u0082();
      this.\u0001 = new \u0019.\u0080();
      this.\u0001 = new \u001D.\u0080(this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0005);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0003);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0004);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0002);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0002);
      \u001A\u001E.\u0084\u0086((object) this);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(6, 7));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(86552));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(487, 294));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u0001\u008C((object) this.\u0001, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u000E.\u0001(86573));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(190, 44));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(86590));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(288, 241));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 14);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(2, 2));
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0001, 999);
      \u0099\u001F.\u007E\u0017\u008A((object) this.\u0001, true);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(86615));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(284, 42));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 11);
      \u0087\u007F.\u007E\u001E\u0084((object) this.\u0001, new EventHandler(this.\u0093\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(115, 152));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u000E.\u0001(86640));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(37, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u000E.\u0001(86669));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(139, 129));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u000E.\u0001(86678));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(33, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u000E.\u0001(86711));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0005, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(117, 175));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u000E.\u0001(86720));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(33, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u000E.\u0001(86711));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(31, 197));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u000E.\u0001(86745));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(254, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u000E.\u0001(86778));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0004, new EventHandler(this.\u0092\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0004, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0004, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(2, 50));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u000E.\u0001(86843));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(181, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 0);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0002, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u000E.\u0001(86884));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0002, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(2, 73));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(86925));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(197, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u000E.\u0001(86958));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0001, new EventHandler(this.\u0086\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(28, 105));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(87007));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(68, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 7);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u000E.\u0001(87028));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(31, 174));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u000E.\u0001(87049));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(90, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 7);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u000E.\u0001(87074));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0003, new EventHandler(this.\u008C\u0005));
      \u0087\u007F.\u007E\u0090\u0083((object) this.\u0003, new EventHandler(this.\u008A\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0003, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(31, 151));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(87091));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(88, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u000E.\u0001(87116));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0001, new EventHandler(this.\u0089\u0005));
      \u0087\u007F.\u007E\u0090\u0083((object) this.\u0001, new EventHandler(this.\u0088\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(31, 128));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u000E.\u0001(87133));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(112, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u000E.\u0001(87166));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0002, new EventHandler(this.\u008B\u0005));
      \u0087\u007F.\u007E\u0090\u0083((object) this.\u0002, new EventHandler(this.\u0087\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(82, 264));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u000E.\u0001(87191));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(104, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u000E.\u0001(87208));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u0095\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0003, new EventHandler(this.\u001F\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(9, 264));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u000E.\u0001(87229));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(67, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u000E.\u0001(34302));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u0094\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0004, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0004, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u000E.\u0001(11489), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(282, 20));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u000E.\u0001(78640));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(105, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u000E.\u0001(87246));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(160, 16));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(87267));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(26, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(131, 16));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u000E.\u0001(87292));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(26, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u0081\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0001
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 379));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(87317));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(524, 22));
      \u0099\u001F.\u007E\u001A\u008F((object) this.\u0001, false);
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u000E.\u0001(36959));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u000E.\u0001(20519));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(0, 17));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(437, 349));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u000E.\u0001(11171));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u000E.\u0001(19330));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0005, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0005, new EventHandler(this.\u009A\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0005, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0005, new EventHandler(this.\u001F\u0005));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(9, 12));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(87338));
      \u0011\u001F.\u007E\u0084\u008F((object) this.\u0001, 0);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(507, 331));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0008\u007F());
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u0096\u0086.\u007E\u0099\u008F((object) this.\u0001, new Point(4, 22));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(87363));
      \u0001\u001F.\u007E\u0089\u0084((object) this.\u0001, new Padding(3));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(499, 305));
      \u0011\u001F.\u007E\u009A\u008F((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u000E.\u0001(87396));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0005), (Control) this.\u0005);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(305, 201));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u000E.\u0001(87425));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(137, 70));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 6);
      \u0099\u001F.\u007E\u0001\u008C((object) this.\u0005, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u000E.\u0001(87454));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000E, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(11, 20));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u000E.\u0001(87471));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(115, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u000E.\u0001(87504));
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u000E.\u0001(87533)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(445, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(87558));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(48, 48));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 5);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u009E\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0002);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(56, 31));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u000E.\u0001(87575));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(266, 114));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 4);
      \u0099\u001F.\u007E\u0001\u008C((object) this.\u0003, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u000E.\u0001(87608));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(192, 36));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u000E.\u0001(87625));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(63, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u000E.\u0001(87658));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0006, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0006, new EventHandler(this.\u009D\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0006, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0006, new EventHandler(this.\u001F\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(164, 36));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u000E.\u0001(87675));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(25, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u000E.\u0001(6890));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0007, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0007, new EventHandler(this.\u009C\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0007, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0007, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0007, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(11, 20));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u000E.\u0001(8777));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(137, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u000E.\u0001(87716));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(14, 37));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u000E.\u0001(87753));
      \u0099\u001F.\u007E\u0019\u008A((object) this.\u0002, true);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(147, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 0);
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0004), (Control) this.\u0004);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(339, 120));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u000E.\u0001(87786));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(103, 70));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 3);
      \u0099\u001F.\u007E\u0001\u008C((object) this.\u0004, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u000E.\u0001(87815));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0006, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(11, 20));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u000E.\u0001(87828));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(58, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u000E.\u0001(87849));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0006);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(56, 154));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u000E.\u0001(87866));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(219, 117));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 0);
      \u0099\u001F.\u007E\u0001\u008C((object) this.\u0002, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u000E.\u0001(87899));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(6, 88));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u000E.\u0001(87924));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(183, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 0);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0003, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u000E.\u0001(87949));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0003, new EventHandler(this.\u0099\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0003, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(6, 65));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u000E.\u0001(87994));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(201, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 0);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0004, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u000E.\u0001(88027));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0004, new EventHandler(this.\u0098\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0004, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0004, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(6, 42));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u000E.\u0001(88076));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(204, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 0);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0005, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u000E.\u0001(88117));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0005, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0005, new EventHandler(this.\u0097\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0005, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0005, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0006, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(6, 19));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u000E.\u0001(88166));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(160, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 0);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0006, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u000E.\u0001(88207));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0006, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0006, new EventHandler(this.\u0096\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0006, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0006, new EventHandler(this.\u001F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u0008\u007F());
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0001);
      \u0096\u0086.\u007E\u0099\u008F((object) this.\u0002, new Point(4, 22));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u000E.\u0001(88248));
      \u0001\u001F.\u007E\u0089\u0084((object) this.\u0002, new Padding(3));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(499, 305));
      \u0011\u001F.\u007E\u009A\u008F((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u000E.\u0001(86573));
      \u0089\u007F.\u007E\u0003\u008B((object) this.\u0001, Environment.SpecialFolder.MyComputer);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0008, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0008, new Font(\u000E.\u0001(8384), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(1, 364));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u000E.\u0001(10747));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 23);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u000E.\u0001(10772));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000F, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(11, 63));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u000E.\u0001(8727));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(106, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u000E.\u0001(88269));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(14, 80));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u000E.\u0001(88298));
      \u0099\u001F.\u007E\u0019\u008A((object) this.\u0003, true);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(175, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 0);
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0003, new EventHandler(this.\u001F\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(192, 78));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u000E.\u0001(88327));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(63, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u000E.\u0001(87658));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0008, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0008, new EventHandler(this.\u009B\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0008, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0008, new EventHandler(this.\u001F\u0005));
      this.\u0005.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(14, 37));
      this.\u0005.MaximumValue = 3;
      this.\u0005.MinimumValue = 1;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u000E.\u0001(88356));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(77, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u000E.\u0001(8431));
      this.\u0005.Value = 3;
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0005, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0005, new EventHandler(this.\u001F\u0005));
      this.\u0004.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(14, 37));
      this.\u0004.MaximumValue = (int) ushort.MaxValue;
      this.\u0004.MinimumValue = 256;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u000E.\u0001(88393));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(77, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u000E.\u0001(88410));
      this.\u0004.Value = 3000;
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0004, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0004, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      this.\u0002.Key = Keys.None;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(102, 102));
      this.\u0002.Modifiers = Keys.None;
      this.\u0002.MultipleKeys = false;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u000E.\u0001(88419));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(120, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u000E.\u0001(30955));
      \u0087\u007F.\u007E\u0090\u0083((object) this.\u0002, new EventHandler(this.\u0091\u0005));
      \u0087\u007F.\u007E\u001E\u0084((object) this.\u0002, new EventHandler(this.\u0090\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      this.\u0001.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(178, 126));
      this.\u0001.MaximumValue = 99999999;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0001, 8);
      this.\u0001.MinimumValue = 0;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(88440));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(59, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      this.\u0001.Value = 0;
      \u0087\u007F.\u007E\u001E\u0084((object) this.\u0001, new EventHandler(this.\u008D\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, false);
      this.\u0003.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(158, 149));
      this.\u0003.MaximumValue = 99999999;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0003, 8);
      this.\u0003.MinimumValue = 0;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u000E.\u0001(88469));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(59, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 6);
      this.\u0003.Value = 0;
      \u0087\u007F.\u007E\u001E\u0084((object) this.\u0003, new EventHandler(this.\u008E\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0003, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      this.\u0002.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(156, 172));
      this.\u0002.MaximumValue = 99999999;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0002, 8);
      this.\u0002.MinimumValue = 0;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u000E.\u0001(88494));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(59, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 8);
      this.\u0002.Value = 0;
      \u0087\u007F.\u007E\u001E\u0084((object) this.\u0002, new EventHandler(this.\u008F\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(9, 46));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(88519));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(177, 212));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0087\u007F.\u007E\u0016\u0088((object) this.\u0001, new EventHandler(this.\u0083\u0005));
      \u0087\u007F.\u007E\u008B\u0084((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      this.\u0001.Key = Keys.None;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(9, 20));
      this.\u0001.Modifiers = Keys.None;
      this.\u0001.MultipleKeys = true;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u000E.\u0001(88540));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(120, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u000E.\u0001(30955));
      \u0087\u007F.\u007E\u001E\u0084((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      this.\u0001.ContractDistance = 2;
      this.\u0001.ContractedDelay = 2000;
      this.\u0001.ContractRate = 10;
      this.\u0001.ControlToSlide = (Control) this.\u0001;
      this.\u0001.Enabled = false;
      this.\u0001.EndPosition = 305;
      this.\u0001.ExpandDistance = 6;
      this.\u0001.ExpandedDelay = 20000;
      this.\u0001.ExpandRate = 10;
      this.\u0001.RunOnce = true;
      this.\u0001.SlideDirection = \u007F.\u0081.\u0004;
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(524, 401));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u000E.\u0001(63937));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u000E.\u0001(88553));
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler(this.\u001D\u0005));
      \u0096\u001C.\u008D\u008B((object) this, new FormClosedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u008E\u008B((object) this, new EventHandler(this.\u001D\u0005));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0005, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0005);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0003, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0003);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0004, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0004);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0002, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0002);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0002, false);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
