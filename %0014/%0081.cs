// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0017;
using \u0018;
using \u0080;
using \u0084;
using System;
using System.IO;
using System.Windows.Forms;

namespace \u0014
{
  internal sealed class \u0081 : \u0014.\u0080
  {
    private \u001D \u0001;
    private \u007F \u0001;

    protected override int? Version
    {
      get
      {
        return new int?(1);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 1;
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
        return new byte[3]{ (byte) 72, (byte) 75, (byte) 83 };
      }
    }

    public \u0012 Hotkey { get; set; }

    public Keys KeyToPress { get; set; }

    public \u001D InputEventFlags
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        value.\u001D\u0005();
        this.\u0001 = value;
      }
    }

    public \u007F HotkeyType
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        value.\u001D\u0005();
        this.\u0001 = value;
      }
    }

    public int KeyPressRepeatRate { get; set; }

    public int KeyReleaseDelay { get; set; }

    public int MoveMouseRate { get; set; }

    public bool RepeatKeyPress
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.InputEventFlags, (Enum) \u001D.\u0002);
      }
      set
      {
        if (value == this.RepeatKeyPress)
          return;
        switch (value)
        {
          case false:
            this.InputEventFlags &= ~\u001D.\u0002;
            break;
          case true:
            this.InputEventFlags |= \u001D.\u0002;
            break;
        }
      }
    }

    public bool ReleaseKey
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.InputEventFlags, (Enum) \u001D.\u0003);
      }
      set
      {
        if (value == this.ReleaseKey)
          return;
        switch (value)
        {
          case false:
            this.InputEventFlags &= ~\u001D.\u0003;
            break;
          case true:
            this.InputEventFlags |= \u001D.\u0003;
            break;
        }
      }
    }

    public bool MoveMouse
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.InputEventFlags, (Enum) \u001D.\u0004);
      }
      set
      {
        if (value == this.MoveMouse)
          return;
        switch (value)
        {
          case false:
            this.InputEventFlags &= ~\u001D.\u0004;
            break;
          case true:
            this.InputEventFlags |= \u001D.\u0004;
            break;
        }
      }
    }

    public bool StopOtherHotkeys
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.InputEventFlags, (Enum) \u001D.\u0005);
      }
      set
      {
        if (value == this.StopOtherHotkeys)
          return;
        switch (value)
        {
          case false:
            this.InputEventFlags &= ~\u001D.\u0005;
            break;
          case true:
            this.InputEventFlags |= \u001D.\u0005;
            break;
        }
      }
    }

    public string Description { get; set; }

    public \u0081()
    {
      this.HotkeyType = \u007F.\u0001;
      this.InputEventFlags = \u001D.\u0001;
      this.Description = string.Empty;
    }

    public \u0081(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.Hotkey = new \u0012((Keys) \u0005\u0081.\u007E\u0099\u009D((object) reader), (Keys) \u0005\u0081.\u007E\u0099\u009D((object) reader));
      this.HotkeyType = (\u007F) \u0011\u001C.\u007E\u0097\u009D((object) reader);
      if (this.HotkeyType == \u007F.\u0001)
      {
        this.InputEventFlags = (\u001D) \u0011\u001C.\u007E\u0097\u009D((object) reader);
        this.KeyToPress = (Keys) \u0005\u0081.\u007E\u0099\u009D((object) reader);
        if (this.RepeatKeyPress)
          this.KeyPressRepeatRate = \u0005\u0081.\u007E\u0099\u009D((object) reader);
        if (this.ReleaseKey)
          this.KeyReleaseDelay = \u0005\u0081.\u007E\u0099\u009D((object) reader);
        if (this.MoveMouse)
          this.MoveMouseRate = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      }
      this.Description = \u0002\u007F.\u007E\u0001\u009E((object) reader);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0011\u001F.\u007E\u0015\u009E((object) writer, (int) this.Hotkey.Key);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, (int) this.Hotkey.Modifier);
      \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.HotkeyType);
      if (this.HotkeyType == \u007F.\u0001)
      {
        \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.InputEventFlags);
        \u0011\u001F.\u007E\u0015\u009E((object) writer, (int) this.KeyToPress);
        if (this.RepeatKeyPress)
          \u0011\u001F.\u007E\u0015\u009E((object) writer, this.KeyPressRepeatRate);
        if (this.ReleaseKey)
          \u0011\u001F.\u007E\u0015\u009E((object) writer, this.KeyReleaseDelay);
        if (this.MoveMouse)
          \u0011\u001F.\u007E\u0015\u009E((object) writer, this.MoveMouseRate);
      }
      \u0092\u0081.\u007E\u001A\u009E((object) writer, this.Description);
    }
  }
}
