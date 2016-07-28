// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0016;
using \u001A;
using \u007F;
using \u0082;
using \u0083;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace \u0016
{
  internal sealed class \u001D : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Button \u0001;
    private Label \u0001;
    private Label \u0002;
    private Label \u0003;
    private PictureBox \u0001;
    private Label \u0004;
    private \u000E \u0001;
    private \u001C \u0001;
    private static \u0017 \u0001;
    private static \u0002 \u0001;

    static \u001D()
    {
      \u0004.\u001D\u0005(typeof (\u001D));
      \u001D.\u0001 = \u0017.\u001D\u0005(new Size(12, 430), new Size(800, 600));
      \u001D.\u0001 = \u0002.\u001D\u0005(32, 600);
    }

    public \u001D()
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001D)));
      this.\u0001 = new Button();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0003 = new Label();
      this.\u0001 = new PictureBox();
      this.\u0004 = new Label();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(17, 75));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001D.\u0001(25494));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(214, 33));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001D.\u0001(25523));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(10, 39));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001D.\u0001(5354));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(228, 36));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001D.\u0001(25548));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001D.\u0001(8066), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(7, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001D.\u0001(25665));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(203, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001D.\u0001(25698));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u001D.\u0001(4961), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(10, 115));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001D.\u0001(5304));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(231, 29));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u001D.\u0001(25731));
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001D.\u0001(5615)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(248, 14));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001D.\u0001(5640));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(52, 120));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 11);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u001D.\u0001(4961), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(10, 144));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u001D.\u0001(5262));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(290, 30));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u001D.\u0001(25824));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(305, 176));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001D.\u0001(6083)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u001D.\u0001(25998));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001D.\u0001(26015));
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler(this.\u001D\u0005));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001 = \u000E.\u001D\u0005((Form) this);
      if (this.\u0001 == null)
        return;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001D.\u0001 obj1 = new \u001D.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      \u001A\u001E.\u0001\u0086((object) this);
      this.\u0001 = new \u001C();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = (Action) (() => \u000E\u001F.\u007E\u0082\u008B((object) this.\u0001, \u001D.\u0001.\u001D\u0005(\u0083\u001E.\u007E\u000F\u008B((object) this.\u0001))));
      // ISSUE: reference to a compiler-generated field
      obj1.\u0002 = (Action) (() =>
      {
        Rectangle rectangle = \u0013.\u001E\u0005(\u0088\u0086.\u007E\u0097\u0083((object) this.\u0001));
        \u0096\u0086.\u007E\u0018\u008B((object) this.\u0001, new Point(rectangle.Location.X + (rectangle.Width / 2 - \u0005\u0081.\u007E\u0083\u0084((object) this.\u0001) / 2), rectangle.Location.Y + \u001D.\u0001.\u001D\u0005(rectangle.Height)));
      });
      // ISSUE: reference to a compiler-generated field
      obj1.\u0003 = (Action) (() => \u000E.\u001D\u0005(new HandleRef((object) this, \u0088\u0086.\u007E\u0097\u0083((object) this.\u0001)), \u0006.\u0011));
      // ISSUE: reference to a compiler-generated field
      obj1.\u0004 = (Action) (() => \u000E.\u001D\u0005(new HandleRef((object) this, \u0088\u0086.\u007E\u0097\u0083((object) this.\u0001)), \u0006.\u0002));
      this.\u0001.FormClosed += (FormClosedEventHandler) ((obj, args) => \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001));
      // ISSUE: reference to a compiler-generated method
      \u0087\u007F.\u007E\u0001\u0084((object) this.\u0001, new EventHandler(obj1.\u001D\u0005));
      // ISSUE: reference to a compiler-generated method
      \u0087\u007F.\u007E\u0019\u0084((object) this.\u0001, new EventHandler(obj1.\u001E\u0005));
      // ISSUE: reference to a compiler-generated method
      this.\u0001.OnResizeStarted += new EventHandler(obj1.\u001F\u0005);
      // ISSUE: reference to a compiler-generated method
      this.\u0001.OnResizeEnded += new EventHandler(obj1.\u007F\u0005);
      // ISSUE: reference to a compiler-generated method
      this.\u0001.WindowStateChanged += new EventHandler(obj1.\u0080\u0005);
      this.\u0001.FormClosing += (FormClosingEventHandler) ((obj, args) =>
      {
        \u001A\u001E.\u0092\u008B((object) this);
        \u001A\u001E.\u007E\u0092\u008B((object) this.\u0001);
      });
      this.\u0001.FormClosed += (FormClosedEventHandler) ((obj, args) => \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001));
      // ISSUE: reference to a compiler-generated method
      \u0087\u007F.\u007E\u008C\u0084((object) this.\u0001, new EventHandler(obj1.\u0081\u0005));
      // ISSUE: reference to a compiler-generated method
      \u0087\u007F.\u007E\u0090\u0084((object) this.\u0001, new EventHandler(obj1.\u0082\u0005));
      // ISSUE: reference to a compiler-generated field
      \u001A\u001E.\u007E\u0003\u0092((object) obj1.\u0001);
      // ISSUE: reference to a compiler-generated field
      \u001A\u001E.\u007E\u0003\u0092((object) obj1.\u0002);
      \u0099\u001F.\u007E\u0086\u008B((object) this.\u0001, true);
      \u001A\u001E.\u007E\u0083\u0086((object) this.\u0001);
    }

    private void \u001D\u0005(object sender, FormClosingEventArgs e)
    {
      if (this.\u0001 == null)
        return;
      \u001A\u001E.\u007E\u0092\u008B((object) this.\u0001);
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u0081);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }
  }
}
