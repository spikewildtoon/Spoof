// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0016
{
  internal class \u0002 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Label \u0001;
    private Button \u0001;
    private Button \u0002;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string LabelMessage
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

    static \u0002()
    {
      \u0004.\u001D\u0005(typeof (\u0002));
    }

    public \u0002()
    {
      this.\u001D\u0005();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0002)));
      this.\u0001 = new Label();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0002.\u0001(15636));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(502, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleLeft);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0001, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(439, 35));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0002.\u0001(6890));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0002.\u0001(6903));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(358, 35));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0002.\u0001(6876));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0002.\u0001(15653));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0002);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0001);
      \u000E\u001F.\u0010\u008B((object) this, new Size(523, 68));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0002.\u0001(5829)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u000E\u001F.\u007E\u0007\u0084((object) this, new Size(6, 96));
      \u0092\u0081.\u0010\u0084((object) this, \u0002.\u0001(15658));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (!this.\u001D\u0005())
        return;
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
    }

    protected virtual bool \u001D\u0005()
    {
      return true;
    }
  }
}
