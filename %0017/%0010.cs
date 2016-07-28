// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0018;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace \u0017
{
  internal sealed class \u0010 : \u000F
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private int \u0001;
    private int \u0002;
    private bool \u0001;

    public override bool Multiline
    {
      get
      {
        return false;
      }
      set
      {
        \u0099\u001F.\u0084\u008A((object) this, false);
      }
    }

    [Category("Appearance")]
    public int Value
    {
      [DebuggerStepThrough] get
      {
        int num;
        if (\u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u001C\u0084((object) this), string.Empty) || \u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u001C\u0084((object) this), \u0010.\u0001(3576)) || !\u0090\u0081.\u001A\u0096(\u0002\u007F.\u007E\u001C\u0084((object) this), ref num))
          return 0;
        return num;
      }
      set
      {
        if (!this.\u001D\u0005(value))
          return;
        if (value == 0 && this.IfZeroDisplayEmpty)
          \u0092\u0081.\u0089\u008A((object) this, string.Empty);
        else
          \u0092\u0081.\u0089\u008A((object) this, value.ToString((IFormatProvider) \u0013.\u0001));
      }
    }

    [Category("Behavior")]
    public bool IfZeroDisplayEmpty
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
        if (!this.\u0001)
        {
          \u0092\u0081.\u0089\u008A((object) this, this.Value.ToString((IFormatProvider) \u0013.\u0001));
        }
        else
        {
          if (this.Value != 0)
            return;
          \u0092\u0081.\u0089\u008A((object) this, string.Empty);
        }
      }
    }

    [Category("Behavior")]
    public int MaximumValue
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
        if (this.Value <= this.\u0001)
          return;
        this.Value = this.\u0001;
      }
    }

    [Category("Behavior")]
    public int MinimumValue
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if (this.\u0002 == value)
          return;
        this.\u0002 = value;
        if (this.Value >= this.\u0002)
          return;
        this.Value = this.\u0002;
      }
    }

    [Category("Appearance")]
    [DefaultValue("0")]
    public override string Text
    {
      get
      {
        return \u0002\u007F.\u0088\u008A((object) this);
      }
      set
      {
        if (!\u0008\u001F.\u009B\u0092(\u0002\u007F.\u0088\u008A((object) this), value) || !this.\u001D\u0005(value))
          return;
        \u0092\u0081.\u0089\u008A((object) this, value);
      }
    }

    static \u0010()
    {
      \u0004.\u001D\u0005(typeof (\u0010));
    }

    public \u0010()
    {
      this.MaximumValue = int.MaxValue;
      this.MinimumValue = int.MinValue;
    }

    protected override bool \u001E\u0005()
    {
      return this.MinimumValue < 0;
    }

    protected override bool \u001D\u0005()
    {
      try
      {
        if (!\u000F\u0080.\u0086\u0088())
          return false;
        string str = \u008E\u001E.\u0087\u0088();
        switch (str)
        {
          case null:
            return false;
          default:
            return this.\u001D\u0005(\u0004\u001E.\u007E\u001C\u0093((object) \u0084\u0080.\u007E\u001E\u0093((object) \u0002\u007F.\u0088\u008A((object) this), \u0005\u0081.\u001C\u008A((object) this), \u0005\u0081.\u007E\u001B\u008A((object) this)), \u0005\u0081.\u001C\u008A((object) this), str));
        }
      }
      catch
      {
        return false;
      }
      finally
      {
      }
    }

    protected override bool \u001D\u0005(Keys key)
    {
      string input = \u0084\u0080.\u007E\u001E\u0093((object) \u0002\u007F.\u0088\u008A((object) this), \u0005\u0081.\u001C\u008A((object) this), \u0005\u0081.\u001B\u008A((object) this));
      if (key == Keys.Back)
      {
        if (\u0005\u0081.\u001C\u008A((object) this) > 0 && \u0005\u0081.\u001B\u008A((object) this) == 0)
          input = \u0084\u0080.\u007E\u001E\u0093((object) \u0002\u007F.\u0088\u008A((object) this), \u0005\u0081.\u001C\u008A((object) this) - 1, 1);
      }
      else if (key == Keys.Delete)
      {
        if (\u0005\u0081.\u001C\u008A((object) this) < \u0005\u0081.\u007E\u0001\u0093((object) \u0002\u007F.\u0088\u008A((object) this)) - 2 && \u0005\u0081.\u001B\u008A((object) this) == 0)
          input = \u0084\u0080.\u007E\u001E\u0093((object) \u0002\u007F.\u0088\u008A((object) this), \u0005\u0081.\u001C\u008A((object) this), 1);
      }
      else
      {
        string str = (string) null;
        switch (key)
        {
          case Keys.D0:
          case Keys.NumPad0:
            str = \u0010.\u0001(2893);
            break;
          case Keys.D1:
          case Keys.NumPad1:
            str = \u0010.\u0001(2898);
            break;
          case Keys.D2:
          case Keys.NumPad2:
            str = \u0010.\u0001(5146);
            break;
          case Keys.D3:
          case Keys.NumPad3:
            str = \u0010.\u0001(5151);
            break;
          case Keys.D4:
          case Keys.NumPad4:
            str = \u0010.\u0001(5156);
            break;
          case Keys.D5:
          case Keys.NumPad5:
            str = \u0010.\u0001(27645);
            break;
          case Keys.D6:
          case Keys.NumPad6:
            str = \u0010.\u0001(27650);
            break;
          case Keys.D7:
          case Keys.NumPad7:
            str = \u0010.\u0001(27655);
            break;
          case Keys.D8:
          case Keys.NumPad8:
            str = \u0010.\u0001(27660);
            break;
          case Keys.D9:
          case Keys.NumPad9:
            str = \u0010.\u0001(27665);
            break;
          case Keys.Subtract:
          case Keys.OemMinus:
            str = \u0010.\u0001(3576);
            break;
        }
        if (!\u008F\u0084.\u009E\u0092(str))
          input = \u0004\u001E.\u007E\u001C\u0093((object) input, \u0005\u0081.\u001C\u008A((object) this), str);
      }
      if (\u0008\u001F.\u009A\u0092(input, string.Empty))
        input = \u0010.\u0001(2893);
      else if (\u0008\u001F.\u009A\u0092(input, \u0010.\u0001(3576)))
        input = \u0010.\u0001(27670);
      return this.\u001D\u0005(input);
    }

    private bool \u001D\u0005(string input)
    {
      int num;
      if (\u008F\u0084.\u009E\u0092(input) || !\u0090\u0081.\u001A\u0096(input, ref num))
        return false;
      return this.\u001D\u0005(num);
    }

    private bool \u001D\u0005(int value)
    {
      return value <= this.MaximumValue && value >= this.MinimumValue;
    }
  }
}
