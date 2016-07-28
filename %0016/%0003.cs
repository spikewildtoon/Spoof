// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0017;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0016
{
  internal class \u0003 : \u0002
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private static readonly string \u0001;
    private IContainer \u0001;
    private \u0010 \u0001;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int MaximumValue
    {
      get
      {
        return this.\u0001.MaximumValue;
      }
      set
      {
        this.\u0001.MaximumValue = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int MinimumValue
    {
      get
      {
        return this.\u0001.MinimumValue;
      }
      set
      {
        this.\u0001.MinimumValue = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int Value
    {
      get
      {
        return this.\u0001.Value;
      }
      set
      {
        this.\u0001.Value = value;
      }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
    public event EventHandler<\u0011<int>> InputValidating;

    static \u0003()
    {
      \u0004.\u001D\u0005(typeof (\u0003));
      \u0003.\u0001 = \u0003.\u0001(15739);
    }

    public \u0003()
    {
      this.\u001E\u0005();
      this.LabelMessage = \u0003.\u0001;
    }

    protected override bool \u001D\u0005()
    {
      if (this.\u0001 == null)
        return base.\u001D\u0005();
      \u0011<int> e = new \u0011<int>(this.\u0001.Value);
      this.\u0001((object) this, e);
      return e.IsValid;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u001E\u0005()
    {
      this.\u0001 = new \u0010();
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      this.\u0001.IfZeroDisplayEmpty = false;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(15, 37));
      this.\u0001.MaximumValue = int.MaxValue;
      this.\u0001.MinimumValue = int.MinValue;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(15684));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(337, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      this.\u0001.Value = 0;
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(523, 68));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0003.\u0001(15701));
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0003.\u0001(15730));
      \u0015\u0081.\u007E\u0091\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001, 0);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
