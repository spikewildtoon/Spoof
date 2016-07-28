// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0019;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0019
{
  internal class \u0014 : \u0002
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private IContainer \u0001;
    private TextBox \u0001;
    private static readonly string \u0001;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int MaxLength
    {
      get
      {
        return \u0005\u0081.\u007E\u0014\u008A((object) this.\u0001);
      }
      set
      {
        \u0011\u001F.\u007E\u0015\u008A((object) this.\u0001, value);
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool PasswordTextBox
    {
      get
      {
        return (int) \u0096\u0084.\u007E\u0086\u008A((object) this.\u0001) != 0;
      }
      set
      {
        if (value)
          \u0090\u001E.\u007E\u0087\u008A((object) this.\u0001, '*');
        else
          \u0090\u001E.\u007E\u0087\u008A((object) this.\u0001, char.MinValue);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public string Value
    {
      get
      {
        return \u0002\u007F.\u007E\u001C\u0084((object) this.\u0001);
      }
      set
      {
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, value);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public event EventHandler<\u0011<string>> InputValidating;

    static \u0014()
    {
      \u0004.\u001D\u0005(typeof (\u0014));
      \u0014.\u0001 = \u0014.\u0001(45041);
    }

    public \u0014()
    {
      this.\u001E\u0005();
      this.LabelMessage = \u0014.\u0001;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u001E\u0005()
    {
      this.\u0001 = new TextBox();
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(15, 37));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0014.\u0001(16784));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(337, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(523, 68));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0014.\u0001(45012));
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0014.\u0001(16830));
      \u0015\u0081.\u007E\u0091\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001, 0);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    protected override bool \u001D\u0005()
    {
      if (this.\u0001 == null)
        return base.\u001D\u0005();
      \u0011<string> e = new \u0011<string>(\u0002\u007F.\u007E\u001C\u0084((object) this.\u0001));
      this.\u0001((object) this, e);
      return e.IsValid;
    }
  }
}
