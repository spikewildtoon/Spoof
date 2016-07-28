// Decompiled with JetBrains decompiler
// Type: .
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

namespace \u001E
{
  internal sealed class \u001E : \u000F
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private float \u0001;
    private float \u0002;

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
    public float Value
    {
      [DebuggerStepThrough] get
      {
        float num;
        if (\u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u001C\u0084((object) this), string.Empty) || \u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u001C\u0084((object) this), \u001E.\u001E.\u0001(6068)) || (\u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u001C\u0084((object) this), \u001E.\u001E.\u0001(66837)) || !\u001C\u001E.\u0080\u0097(\u0002\u007F.\u007E\u001C\u0084((object) this), ref num)))
          return 0.0f;
        return num;
      }
      set
      {
        if (!this.\u001D\u0005(value))
          return;
        \u0092\u0081.\u0089\u008A((object) this, value.ToString((IFormatProvider) \u0013.\u0001));
      }
    }

    [Category("Behavior")]
    public float MaximumValue
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if ((double) this.\u0001 == (double) value)
          return;
        this.\u0001 = value;
        if ((double) this.Value <= (double) this.\u0001)
          return;
        this.Value = this.\u0001;
      }
    }

    [Category("Behavior")]
    public float MinimumValue
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if ((double) this.\u0002 == (double) value)
          return;
        this.\u0002 = value;
        if ((double) this.Value >= (double) this.\u0002)
          return;
        this.Value = this.\u0002;
      }
    }

    [DefaultValue("0")]
    [Category("Appearance")]
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

    static \u001E()
    {
      \u0004.\u001D\u0005(typeof (\u001E.\u001E));
    }

    public \u001E()
    {
      this.MaximumValue = float.MaxValue;
      this.MinimumValue = float.MinValue;
    }

    protected override bool \u001E\u0005()
    {
      return (double) this.MinimumValue < 0.0;
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
            str = \u001E.\u001E.\u0001(5385);
            break;
          case Keys.D1:
          case Keys.NumPad1:
            str = \u001E.\u001E.\u0001(5390);
            break;
          case Keys.D2:
          case Keys.NumPad2:
            str = \u001E.\u001E.\u0001(7638);
            break;
          case Keys.D3:
          case Keys.NumPad3:
            str = \u001E.\u001E.\u0001(7643);
            break;
          case Keys.D4:
          case Keys.NumPad4:
            str = \u001E.\u001E.\u0001(7648);
            break;
          case Keys.D5:
          case Keys.NumPad5:
            str = \u001E.\u001E.\u0001(30137);
            break;
          case Keys.D6:
          case Keys.NumPad6:
            str = \u001E.\u001E.\u0001(30142);
            break;
          case Keys.D7:
          case Keys.NumPad7:
            str = \u001E.\u001E.\u0001(30147);
            break;
          case Keys.D8:
          case Keys.NumPad8:
            str = \u001E.\u001E.\u0001(30152);
            break;
          case Keys.D9:
          case Keys.NumPad9:
            str = \u001E.\u001E.\u0001(30157);
            break;
          case Keys.Subtract:
          case Keys.OemMinus:
            str = \u001E.\u001E.\u0001(6068);
            break;
          case Keys.Decimal:
          case Keys.OemPeriod:
            str = \u001E.\u001E.\u0001(66837);
            break;
        }
        if (!\u008F\u0084.\u009E\u0092(str))
          input = \u0004\u001E.\u007E\u001C\u0093((object) input, \u0005\u0081.\u001C\u008A((object) this), str);
      }
      if (\u0008\u001F.\u009A\u0092(input, string.Empty))
        input = \u001E.\u001E.\u0001(5385);
      else if (\u0008\u001F.\u009A\u0092(input, \u001E.\u001E.\u0001(6068)))
        input = \u001E.\u001E.\u0001(30162);
      return this.\u001D\u0005(input);
    }

    private bool \u001D\u0005(string input)
    {
      float num;
      if (\u008F\u0084.\u009E\u0092(input) || !\u001C\u001E.\u0080\u0097(input, ref num))
        return false;
      return this.\u001D\u0005(num);
    }

    private bool \u001D\u0005(float value)
    {
      return (double) value <= (double) this.MaximumValue && (double) value >= (double) this.MinimumValue;
    }
  }
}
