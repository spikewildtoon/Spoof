// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0019;
using System;
using System.Windows.Forms;

namespace \u0019
{
  internal sealed class \u0080 : TextBox
  {
    private \u0012 \u0001 = new \u0012();
    private ContextMenu \u0001 = new ContextMenu();
    [NonSerialized]
    internal static \u0002 \u0001;
    private bool \u0001;

    public \u0012 Hotkey
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (!\u0012.\u001E\u0005(this.\u0001, value))
          return;
        this.\u0001 = value;
        this.\u001F\u0005();
      }
    }

    public Keys Key
    {
      get
      {
        return this.\u0001.Key;
      }
      set
      {
        this.\u0001.Key = value;
        this.\u001F\u0005();
      }
    }

    public Keys Modifiers
    {
      get
      {
        return this.\u0001.Modifier;
      }
      set
      {
        if (this.\u0001.Modifier == value)
          return;
        this.\u0001.Modifier = value;
        this.\u001F\u0005();
      }
    }

    public override ContextMenu ContextMenu
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        \u0015\u001E.\u0084\u0083((object) this, this.\u0001);
      }
    }

    public override bool Multiline
    {
      get
      {
        return \u0099\u0082.\u0083\u008A((object) this);
      }
      set
      {
        \u0099\u001F.\u0084\u008A((object) this, false);
      }
    }

    public override string Text
    {
      get
      {
        return \u0002\u007F.\u0088\u008A((object) this);
      }
      set
      {
        \u0092\u0081.\u0089\u008A((object) this, value);
        \u0011\u001F.\u001D\u008A((object) this, \u0005\u0081.\u007E\u0001\u0093((object) \u0002\u007F.\u007E\u001C\u0084((object) this)));
      }
    }

    public bool MultipleKeys
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
        this.\u001D\u0005();
        this.\u001F\u0005();
      }
    }

    static \u0080()
    {
      \u0004.\u001D\u0005(typeof (\u0080));
    }

    public \u0080()
    {
      \u0015\u001E.\u007E\u0084\u0083((object) this, this.\u0001);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0080.\u0001(28518));
      this.MultipleKeys = true;
      \u009F\u0083.\u008E\u0084((object) this, new KeyPressEventHandler(this.\u001D\u0005));
      \u0087\u0086.\u008D\u0084((object) this, new KeyEventHandler(this.\u001D\u0005));
    }

    private void \u001D\u0005()
    {
      if (this.MultipleKeys || this.\u0001.Modifier == Keys.None)
        return;
      if (!\u0095\u001C.\u0099\u0091((object) this.\u0001.Modifier, (Enum) Keys.Control))
      {
        if (\u0095\u001C.\u0099\u0091((object) this.\u0001.Modifier, (Enum) Keys.Alt))
        {
          this.\u0001.Modifier = Keys.Alt;
          this.\u0001.Key = Keys.None;
        }
        else
        {
          if (!\u0095\u001C.\u0099\u0091((object) this.\u0001.Modifier, (Enum) Keys.Shift))
            return;
          this.\u0001.Modifier = Keys.Shift;
          this.\u0001.Key = Keys.None;
        }
      }
      else
      {
        this.\u0001.Modifier = Keys.Control;
        this.\u0001.Key = Keys.None;
      }
    }

    public void \u001E\u0005()
    {
      this.Key = Keys.None;
      this.Modifiers = Keys.None;
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      if (keyData == Keys.Delete || keyData == (Keys.Delete | Keys.Control))
      {
        this.ResetHotkey();
        return true;
      }
      if (keyData == (Keys.Insert | Keys.Shift))
        return true;
      return \u008F\u001F.\u0010\u008A((object) this, ref msg, keyData);
    }

    private void \u001D\u0005(object sender, KeyEventArgs e)
    {
      if (\u007F\u0081.\u007E\u0013\u008C((object) e) == Keys.Back || \u007F\u0081.\u007E\u0013\u008C((object) e) == Keys.Delete)
      {
        this.ResetHotkey();
      }
      else
      {
        this.\u0001.Modifier = \u007F\u0081.\u007E\u0014\u008C((object) e);
        this.\u0001.Key = \u007F\u0081.\u007E\u0013\u008C((object) e);
        this.\u001D\u0005();
        this.\u001F\u0005();
      }
    }

    private void \u001D\u0005(object sender, KeyPressEventArgs e)
    {
      \u0099\u001F.\u007E\u0016\u008C((object) e, true);
    }

    public void ResetHotkey()
    {
      this.\u0001.Key = Keys.None;
      this.\u0001.Modifier = Keys.None;
      this.\u001F\u0005();
    }

    private void \u001F\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this, this.\u0001.ToString());
    }
  }
}
