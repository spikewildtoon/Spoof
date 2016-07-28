// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001C;
using \u0081;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001C
{
  internal sealed class \u001B : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u007F \u0001;
    private Button \u0001;
    private Button \u0002;

    public string Value
    {
      get
      {
        return this.\u0001.Rtf;
      }
      set
      {
        this.\u0001.Rtf = value;
      }
    }

    static \u001B()
    {
      \u0004.\u001D\u0005(typeof (\u001B));
    }

    public \u001B()
    {
      this.\u001D\u0005();
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001B)));
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0001 = new \u007F();
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0001, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(440, 241));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(8933));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u0001(14790));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(359, 241));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u0001(60874));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001B.\u0001(14760));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(11, 11));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(60887));
      this.\u0001.Rtf = \u001B.\u0001(60900);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(504, 224));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(527, 271));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001B.\u0001(7872)));
      \u0092\u0081.\u0010\u0084((object) this, \u001B.\u0001(61082));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001B.\u0001(61095));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
