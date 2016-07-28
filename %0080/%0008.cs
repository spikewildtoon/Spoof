// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001C;
using \u0080;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0080
{
  internal sealed class \u0008 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private CheckBox \u0001;
    private CheckBox \u0002;
    private CheckBox \u0003;
    private Button \u0001;
    private \u0010 \u0001;
    private Label \u0001;
    private \u007F \u0001;

    public \u007F FloraActions
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
        if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001) != this.Pick)
          \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, this.Pick);
        if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0002) != this.Plant)
          \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, this.Plant);
        if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0003) != this.Water)
          \u0099\u001F.\u007E\u0003\u0088((object) this.\u0003, this.Water);
        this.\u001E\u0005();
      }
    }

    public bool Pick
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u007F.\u0003);
      }
      set
      {
        if (this.Pick == value)
          return;
        if (!value)
          goto label_7;
        else
          goto label_6;
label_1:
        if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001) != value)
          \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, value);
        this.\u001E\u0005();
        return;
label_6:
        this.\u0001 |= \u007F.\u0003;
        goto label_1;
label_7:
        this.\u0001 &= ~\u007F.\u0003;
        goto label_1;
      }
    }

    public bool Plant
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u007F.\u0004);
      }
      set
      {
        if (this.Plant == value)
          return;
        if (!value)
          goto label_7;
        else
          goto label_6;
label_1:
        if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0002) != value)
          \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, value);
        this.\u001E\u0005();
        return;
label_6:
        this.\u0001 |= \u007F.\u0004;
        goto label_1;
label_7:
        this.\u0001 &= ~\u007F.\u0004;
        goto label_1;
      }
    }

    public bool Water
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u007F.\u0005);
      }
      set
      {
        if (this.Water == value)
          return;
        if (!value)
          goto label_7;
        else
          goto label_6;
label_1:
        if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0003) != value)
          \u0099\u001F.\u007E\u0003\u0088((object) this.\u0003, value);
        this.\u001E\u0005();
        return;
label_6:
        this.\u0001 |= \u007F.\u0005;
        goto label_1;
label_7:
        this.\u0001 &= ~\u007F.\u0005;
        goto label_1;
      }
    }

    public int WaterCount
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

    public event EventHandler<\u0002> GardenerActionsChanged;

    public event EventHandler ClosePopup;

    static \u0008()
    {
      \u0004.\u001D\u0005(typeof (\u0008));
    }

    public \u0008()
    {
      this.\u001D\u0005();
      this.FloraActions = \u007F.\u0003 | \u007F.\u0004 | \u007F.\u0005;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new CheckBox();
      this.\u0002 = new CheckBox();
      this.\u0003 = new CheckBox();
      this.\u0001 = new Button();
      this.\u0001 = new Label();
      this.\u0001 = new \u0010();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(5, 5));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0008.\u0001(83163));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(47, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0008.\u0001(63245));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(5, 24));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0008.\u0001(83180));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(50, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0008.\u0001(63271));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(5, 43));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0008.\u0001(83201));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(55, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0008.\u0001(60754));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0003, new EventHandler(this.\u001F\u0005));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0008.\u0001(8373), 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(64, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0008.\u0001(18139));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(18, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0008.\u0001(18152));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(59, 44));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0008.\u0001(60720));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(12, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0008.\u0001(56599));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(70, 41));
      this.\u0001.MaximumValue = 5;
      \u0011\u001F.\u007E\u0015\u008A((object) this.\u0001, 1);
      this.\u0001.MinimumValue = 0;
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0008.\u0001(60695));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(12, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      this.\u0001.Value = 0;
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u009A\u0080.\u0016\u0081());
      \u0012\u0082.\u009D\u0090((object) this, BorderStyle.FixedSingle);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0008.\u0001(83222));
      \u000E\u001F.\u0018\u0084((object) this, new Size(85, 62));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001E\u0005()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0002(this.\u0001));
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.Pick = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.Plant = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0002);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.Water = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }
  }
}
