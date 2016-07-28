// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u001A;
using \u001B;
using \u001F;
using \u0081;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001F
{
  internal sealed class \u0002 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u001C \u0001;
    private Label \u0001;
    private Button \u0001;
    private Button \u0002;
    private Button \u0003;
    private \u0082 \u0001;

    public \u0003 SelectedAccount { get; private set; }

    static \u0002()
    {
      \u0004.\u001D\u0005(typeof (\u0002));
    }

    public \u0002()
    {
      this.\u001D\u0005();
      this.\u001E\u0005();
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
      this.\u0001 = new \u001C();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0003 = new Button();
      this.\u0001 = new \u0082();
      this.\u0001 = new Label();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(224, 224, 224);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.ImageBounds = new Rectangle(0, 0, 0, 0);
      this.\u0001.ImageLocation = new Point(0, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0002.\u0001(10509));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(331, 229));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0001, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(248, 197));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0002.\u0001(9823));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0002.\u0001(38088));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(167, 197));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0002.\u0001(68036));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0002.\u0001(68049));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001D\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(12, 197));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0002.\u0001(68058));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0002.\u0001(68075));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u001F\u0005));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0002.\u0001(9219), 9.75f));
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0001, true);
      \u0011\u001F.\u007E\u0010\u0088((object) this.\u0001, 16);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 43));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0002.\u0001(68088));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(311, 148));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0087\u007F.\u007E\u0016\u0088((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0087\u007F.\u007E\u008B\u0084((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0002.\u0001(10745), 12f, FontStyle.Bold));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(95, 95, 95));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(8, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0002.\u0001(10758));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(186, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0002.\u0001(68105));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0002);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0001);
      \u000E\u001F.\u0010\u008B((object) this, new Size(339, 237));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0002.\u0001(8762)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0002.\u0001(68138));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0002.\u0001(68159));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001E\u0005()
    {
      \u001A\u001E.\u007E\u0017\u0088((object) this.\u0001);
      \u001A\u001E.\u007E\u001F\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001));
      \u0003\u0083.\u007E\u001D\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object[]) \u0080.Instance.ConnectSettings.ToonTownAccounts.ToArray());
      \u001A\u001E.\u007E\u0018\u0088((object) this.\u0001);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (\u0005\u0081.\u007E\u0084\u0088((object) \u0004\u0083.\u007E\u0014\u0088((object) this.\u0001)) <= 0)
        return;
      this.SelectedAccount = \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) as \u0003;
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      \u001C obj = new \u001C();
      try
      {
        int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj);
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
      \u0080.\u001D\u0005();
      this.\u001E\u0005();
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, \u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) > -1);
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      if (\u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) <= -1)
        return;
      this.SelectedAccount = \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) as \u0003;
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
    }
  }
}
