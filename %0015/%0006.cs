// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0015;
using \u0018;
using \u0080;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0015
{
  internal sealed class \u0006 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0006 \u0001;
    private \u0006 \u0002;
    private \u0006 \u0003;
    private \u0006 \u0004;
    private \u0006 \u0005;
    private \u0006 \u0006;
    private Label \u0001;
    private Label \u0002;
    private Button \u0001;
    private \u0006 \u0007;
    private Dictionary<object, \u007F> \u0001;

    public event EventHandler ClosePopup;

    static \u0006()
    {
      \u0004.\u001D\u0005(typeof (\u0006));
    }

    public \u0006()
    {
      this.\u001D\u0005();
      this.\u0001 = new Dictionary<object, \u007F>();
      this.\u0001.Add((object) this.\u0001, \u007F.\u0001);
      this.\u0001.Add((object) this.\u0002, \u007F.\u0002);
      this.\u0001.Add((object) this.\u0003, \u007F.\u0003);
      this.\u0001.Add((object) this.\u0004, \u007F.\u0004);
      this.\u0001.Add((object) this.\u0005, \u007F.\u0005);
      this.\u0001.Add((object) this.\u0006, \u007F.\u0006);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0001 = new Button();
      this.\u0003 = new \u0006();
      this.\u0002 = new \u0006();
      this.\u0006 = new \u0006();
      this.\u0005 = new \u0006();
      this.\u0004 = new \u0006();
      this.\u0001 = new \u0006();
      this.\u0007 = new \u0006();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(8, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(13946));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(184, 33));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0006.\u0001(13971));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleCenter);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(-1, 135));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0006.\u0001(14056));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(202, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 2);
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0002, ContentAlignment.TopCenter);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0006.\u0001(4327), 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(179, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(14093));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(18, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0006.\u0001(14106));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u0004\u007F());
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0003, \u009B\u0086.\u0008\u008A());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(125, 40));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0006.\u0001(14111));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(40, 40));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 0);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u001D\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u0099\u001F());
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0002, \u009B\u0086.\u0008\u008A());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(80, 40));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0006.\u0001(14128));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(40, 40));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 0);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001D\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u009A\u0080.\u000F\u007F());
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0006, \u009B\u0086.\u0008\u008A());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(125, 86));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0006.\u0001(14145));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(40, 40));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 0);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0006, new EventHandler(this.\u001D\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u0003\u007F());
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0005, \u009B\u0086.\u0008\u008A());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(80, 86));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0006.\u0001(14162));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(40, 40));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 0);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0005, new EventHandler(this.\u001D\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u0091\u001F());
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0004, \u009B\u0086.\u0008\u008A());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(35, 86));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0006.\u0001(14175));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(40, 40));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 0);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u001D\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0005\u007F());
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0001, \u009B\u0086.\u0008\u008A());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(35, 40));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(14188));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(40, 40));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u009A\u0080.\u0096\u001F());
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0007, \u009B\u0086.\u0008\u008A());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(30, 36));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0006.\u0001(14201));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(140, 95));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 0);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0007, new EventHandler(this.\u001D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u009A\u0080.\u0016\u0081());
      \u0012\u0082.\u009D\u0090((object) this, BorderStyle.FixedSingle);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0006.\u0001(14222));
      \u000E\u001F.\u0018\u0084((object) this, new Size(200, 154));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (!this.\u0001.ContainsKey(sender))
        return;
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u009E\u0081.\u001F\u0093(\u0006.\u0001(14247), (object) this.\u0001[sender].\u001D\u0005()));
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }
  }
}
