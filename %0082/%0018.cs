// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0017;
using \u0018;
using \u001A;
using \u001D;
using \u001E;
using \u0084;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace \u0082
{
  internal sealed class \u0018 : \u0080
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private string \u0001;

    protected override int? Version
    {
      get
      {
        return new int?(3);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 3;
      }
    }

    protected override int MinimumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override byte[] Header
    {
      get
      {
        return new byte[2]{ (byte) 65, (byte) 83 };
      }
    }

    public bool UseVisualMode { get; set; }

    public bool HotkeysEnabled { get; set; }

    public Dictionary<\u0012, \u0081> Hotkeys { get; private set; }

    public \u000E UpdateType { get; set; }

    public string ScreenshotSaveDirectory
    {
      get
      {
        if (!\u008F\u0084.\u001D\u009E(this.\u0001))
          this.\u0001 = \u007F.ScreenshotSaveDirectory;
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
      }
    }

    public bool AcceptedContentPackAgreement { get; set; }

    public bool FirstTimeOpeningContentPacks { get; set; }

    public bool DisplayNotifyBalloon { get; set; }

    static \u0018()
    {
      \u0004.\u001D\u0005(typeof (\u0082.\u0018));
    }

    public \u0018()
    {
      this.Hotkeys = new Dictionary<\u0012, \u0081>();
      this.UpdateType = \u000E.\u0001;
      this.UseVisualMode = true;
      this.HotkeysEnabled = true;
      this.AcceptedContentPackAgreement = false;
      this.ScreenshotSaveDirectory = \u007F.ScreenshotSaveDirectory;
      this.FirstTimeOpeningContentPacks = true;
      this.DisplayNotifyBalloon = true;
      this.\u001D\u0005();
    }

    public \u0018(BinaryReader reader)
      : base(reader)
    {
    }

    public void \u001D\u0005()
    {
      this.Hotkeys.Clear();
      this.\u0081\u0005();
      this.\u0082\u0005();
      this.\u0080\u0005();
      this.\u001F\u0005();
      this.\u001E\u0005();
    }

    private void \u001E\u0005()
    {
      \u0081 obj = new \u0081();
      obj.Hotkey = new \u0012(Keys.NumPad8, Keys.None);
      obj.KeyToPress = Keys.Up;
      obj.HotkeyType = \u007F.\u0001;
      obj.KeyPressRepeatRate = 32;
      obj.RepeatKeyPress = true;
      obj.StopOtherHotkeys = true;
      obj.MoveMouse = false;
      obj.MoveMouseRate = 0;
      obj.ReleaseKey = false;
      obj.KeyReleaseDelay = 0;
      obj.Description = \u0082.\u0018.\u0001(99294);
      this.Hotkeys.Add(obj.Hotkey, obj);
    }

    private void \u001F\u0005()
    {
      \u0081 obj = new \u0081();
      obj.Hotkey = new \u0012(Keys.NumPad0, Keys.None);
      obj.KeyToPress = Keys.Up;
      obj.HotkeyType = \u007F.\u0001;
      obj.KeyPressRepeatRate = 32;
      obj.RepeatKeyPress = true;
      obj.StopOtherHotkeys = true;
      obj.MoveMouse = false;
      obj.MoveMouseRate = 0;
      obj.ReleaseKey = false;
      obj.KeyReleaseDelay = 0;
      obj.Description = \u0082.\u0018.\u0001(99294);
      this.Hotkeys.Add(obj.Hotkey, obj);
    }

    private \u0081 \u001D\u0005()
    {
      return new \u0081() { Hotkey = new \u0012(Keys.None, Keys.Alt), KeyToPress = Keys.Up, HotkeyType = \u007F.\u0001, KeyPressRepeatRate = 32, RepeatKeyPress = true, StopOtherHotkeys = true, MoveMouse = false, MoveMouseRate = 0, ReleaseKey = false, KeyReleaseDelay = 0, Description = \u0082.\u0018.\u0001(99294) };
    }

    private void \u007F\u0005()
    {
      \u0081 obj = this.\u001D\u0005();
      this.Hotkeys.Add(obj.Hotkey, obj);
    }

    private void \u0080\u0005()
    {
      \u0081 obj = new \u0081();
      obj.Hotkey = new \u0012(Keys.NumPad1, Keys.None);
      obj.KeyToPress = Keys.Control;
      obj.HotkeyType = \u007F.\u0001;
      obj.KeyPressRepeatRate = 32;
      obj.RepeatKeyPress = true;
      obj.StopOtherHotkeys = true;
      obj.MoveMouse = false;
      obj.MoveMouseRate = 0;
      obj.ReleaseKey = false;
      obj.KeyReleaseDelay = 0;
      obj.Description = \u0082.\u0018.\u0001(99347);
      this.Hotkeys.Add(obj.Hotkey, obj);
    }

    private void \u0081\u0005()
    {
      \u0081 obj = new \u0081();
      obj.Hotkey = new \u0012(Keys.F4, Keys.None);
      obj.KeyToPress = Keys.End;
      obj.HotkeyType = \u007F.\u0001;
      obj.KeyPressRepeatRate = 10000;
      obj.RepeatKeyPress = true;
      obj.StopOtherHotkeys = true;
      obj.MoveMouse = true;
      obj.MoveMouseRate = 30000;
      obj.ReleaseKey = true;
      obj.KeyReleaseDelay = 5000;
      obj.Description = \u0082.\u0018.\u0001(99400);
      this.Hotkeys.Add(obj.Hotkey, obj);
    }

    private void \u0082\u0005()
    {
      \u0081 obj = new \u0081();
      obj.Hotkey = new \u0012(Keys.F2, Keys.None);
      obj.KeyToPress = Keys.None;
      obj.HotkeyType = \u007F.\u0002;
      obj.RepeatKeyPress = false;
      obj.StopOtherHotkeys = false;
      obj.MoveMouse = false;
      obj.MoveMouseRate = 0;
      obj.ReleaseKey = false;
      obj.KeyReleaseDelay = 0;
      obj.Description = \u0082.\u0018.\u0001(99449);
      this.Hotkeys.Add(obj.Hotkey, obj);
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.Hotkeys = new Dictionary<\u0012, \u0081>();
      string str1 = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      \u0005 obj1 = new \u0005(\u001B\u001E.\u007E\u009C\u009D((object) reader));
      string str2 = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      reader.\u001D\u0005();
      this.UpdateType = (\u000E) \u0005\u0081.\u007E\u0099\u009D((object) reader);
      this.UseVisualMode = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.HotkeysEnabled = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.ScreenshotSaveDirectory = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      this.AcceptedContentPackAgreement = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.FirstTimeOpeningContentPacks = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      int num = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index = 0; index < num; ++index)
      {
        \u0081 obj2 = new \u0081(reader);
        this.Hotkeys.Add(obj2.Hotkey, obj2);
      }
      if (version == 1)
      {
        \u0081 first = this.\u001D\u0005();
        if (!this.Hotkeys.ContainsKey(first.Hotkey))
          return;
        \u0081 second = this.Hotkeys[first.Hotkey];
        if (!\u0082.\u0018.\u001D\u0005(first, second))
          return;
        this.Hotkeys.Remove(first.Hotkey);
      }
      else if (version > 2)
        this.DisplayNotifyBalloon = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      else
        this.DisplayNotifyBalloon = true;
    }

    private static bool \u001D\u0005(\u0081 first, \u0081 second)
    {
      if (\u0008\u001F.\u009A\u0092(first.Description, second.Description) && (first.HotkeyType == second.HotkeyType && (first.InputEventFlags == second.InputEventFlags && first.KeyPressRepeatRate == second.KeyPressRepeatRate) && (first.KeyReleaseDelay == second.KeyReleaseDelay && first.KeyToPress == second.KeyToPress && (first.MoveMouse == second.MoveMouse && first.MoveMouseRate == second.MoveMouseRate)) && (first.ReleaseKey == second.ReleaseKey && first.RepeatKeyPress == second.RepeatKeyPress)))
        return first.StopOtherHotkeys == second.StopOtherHotkeys;
      return false;
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0092\u0081.\u007E\u001A\u009E((object) writer, string.Empty);
      \u000F\u0082.\u007E\u0018\u009E((object) writer, \u0005.\u001D\u0005(\u0005.\u0001));
      \u0092\u0081.\u007E\u001A\u009E((object) writer, string.Empty);
      writer.\u001D\u0005(\u001D\u0082.\u0011\u0094());
      \u0011\u001F.\u007E\u0015\u009E((object) writer, (int) this.UpdateType);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.UseVisualMode);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.HotkeysEnabled);
      \u0092\u0081.\u007E\u001A\u009E((object) writer, this.ScreenshotSaveDirectory);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.AcceptedContentPackAgreement);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.FirstTimeOpeningContentPacks);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.Hotkeys.Count);
      foreach (\u0080 obj in this.Hotkeys.Values)
        obj.\u001E\u0005(writer);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.DisplayNotifyBalloon);
    }
  }
}
