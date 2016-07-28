// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u007F;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace \u0017
{
  internal struct \u0012
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private Keys \u0001;
    private Keys \u0002;

    public Keys Key
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (this.\u0001 == value)
          return;
        this.\u0001 = Keys.None;
        Keys keys = value;
        if (keys > Keys.RMenu)
        {
          if (keys == Keys.Shift || keys == Keys.Control || keys == Keys.Alt)
            return;
        }
        else
          goto label_11;
label_9:
        this.\u0001 = value;
        return;
label_11:
        switch (keys - 16)
        {
          case Keys.None:
            break;
          case Keys.LButton:
            break;
          case Keys.RButton:
            break;
          default:
            switch (keys - 91)
            {
              case Keys.None:
                return;
              case Keys.LButton:
                return;
              default:
                switch (keys - 160)
                {
                  case Keys.None:
                    return;
                  case Keys.LButton:
                    return;
                  case Keys.RButton:
                    return;
                  case Keys.Cancel:
                    return;
                  case Keys.MButton:
                    return;
                  case Keys.XButton1:
                    return;
                  default:
                    goto label_9;
                }
            }
        }
      }
    }

    public Keys Modifier
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if (this.\u0002 == value)
          return;
        this.\u0002 = Keys.None;
        if (\u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.Control) || (\u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.ControlKey) || (\u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.LControlKey) || \u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.RControlKey))))
          this.\u0002 |= Keys.Control;
        if (\u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.Shift) || \u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.ShiftKey) || (\u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.LShiftKey) || \u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.RShiftKey)))
          this.\u0002 |= Keys.Shift;
        if (!\u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.Alt) && !\u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.Menu) && (!\u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.LMenu) && !\u0095\u001C.\u0099\u0091((object) value, (Enum) Keys.RMenu)))
          return;
        this.\u0002 |= Keys.Alt;
      }
    }

    public \u0016 NativeModifier
    {
      get
      {
        \u0016 obj = \u0016.\u0001;
        if (\u0095\u001C.\u0099\u0091((object) this.\u0002, (Enum) Keys.Control))
          goto label_5;
label_1:
        if (\u0095\u001C.\u0099\u0091((object) this.\u0002, (Enum) Keys.Shift))
          goto label_6;
label_2:
        if (\u0095\u001C.\u0099\u0091((object) this.\u0002, (Enum) Keys.Alt))
          obj |= \u0016.\u0002;
        return obj;
label_6:
        obj |= \u0016.\u0004;
        goto label_2;
label_5:
        obj |= \u0016.\u0003;
        goto label_1;
      }
      set
      {
        this.\u0002 = Keys.None;
        if (\u0095\u001C.\u0099\u0091((object) value, (Enum) \u0016.\u0003))
          goto label_5;
label_1:
        if (\u0095\u001C.\u0099\u0091((object) value, (Enum) \u0016.\u0004))
          goto label_6;
label_3:
        if (!\u0095\u001C.\u0099\u0091((object) value, (Enum) \u0016.\u0002))
          return;
        this.\u0002 |= Keys.Alt;
        return;
label_6:
        this.\u0002 |= Keys.Shift;
        goto label_3;
label_5:
        this.\u0002 |= Keys.Control;
        goto label_1;
      }
    }

    static \u0012()
    {
      \u0004.\u001D\u0005(typeof (\u0012));
    }

    public \u0012(Keys key, Keys modifier)
    {
      this = new \u0012();
      this.Key = key;
      this.Modifier = modifier;
    }

    public \u0012(Keys key)
    {
      this = new \u0012(key, Keys.None);
    }

    [SpecialName]
    public static bool \u001D\u0005(\u0012 left, \u0012 right)
    {
      if (left.Key == right.Key)
        return left.Modifier == right.Modifier;
      return false;
    }

    [SpecialName]
    public static bool \u001E\u0005(\u0012 left, \u0012 right)
    {
      return !\u0012.\u001D\u0005(left, right);
    }

    public override bool Equals(object obj)
    {
      if (!(obj is \u0012) || !\u0013\u0080.\u0094\u0091((object) this, obj))
        return false;
      return \u0012.\u001D\u0005((\u0012) obj, this);
    }

    public override int GetHashCode()
    {
      return (71 * 83 + \u0005\u0081.\u007E\u008A\u0091((object) this.\u0001)) * 83 + \u0005\u0081.\u007E\u008A\u0091((object) this.\u0002);
    }

    public override string ToString()
    {
      if (this.\u0001 == Keys.None)
      {
        if (this.\u0002 == Keys.None)
          return \u0012.\u0001(27683);
        return \u0002\u007F.\u007E\u0087\u0091((object) this.\u0002);
      }
      if (this.\u0002 == Keys.None)
        return \u0002\u007F.\u007E\u0087\u0091((object) this.\u0001);
      return \u0014\u0084.\u007F\u0093(\u0012.\u0001(27692), (object) this.\u0002, (object) this.\u0001);
    }
  }
}
