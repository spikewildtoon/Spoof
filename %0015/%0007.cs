// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0017;
using \u001D;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0015
{
  internal class \u0007 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0016 \u0001;
    private Button \u0001;
    private Button \u0002;
    private Label \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;

    public IntPtr SelectedHandle
    {
      get
      {
        return this.\u0001.SelectedWindow;
      }
    }

    public string LabelMessage
    {
      get
      {
        return this.\u0001.LabelMessage;
      }
      set
      {
        this.\u0001.LabelMessage = value;
      }
    }

    public event EventHandler<\u0080.\u0017> SelectedHandleChanging
    {
      add
      {
        this.\u0001.SelectedHandleChanging += value;
      }
      remove
      {
        this.\u0001.SelectedHandleChanging -= value;
      }
    }

    static \u0007()
    {
      \u0004.\u001D\u0005(typeof (\u0007));
      \u0007.\u0001 = \u0007.\u0001(14381);
      \u0007.\u0002 = \u0007.\u0001(14422);
      \u0007.\u0003 = \u0007.\u0001(14459);
    }

    public \u0007()
    {
      this.\u001D\u0005();
      \u0013.\u001D\u0005(\u0007.\u0001, true);
      // ISSUE: method pointer
      this.\u0001.BeginSelecting += new EventHandler((object) this, __methodptr(\u001D\u0005));
      // ISSUE: method pointer
      this.\u0001.EndSelecting += new EventHandler((object) this, __methodptr(\u001E\u0005));
      this.\u0001.SelectedHandleChanged += new EventHandler<\u000E>(this.\u001D\u0005);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0007)));
      this.\u0001 = new \u0016();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0001 = new Label();
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      this.\u0001.LabelMessage = \u0007.\u0001(14294);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(6, 5));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0007.\u0001(14351));
      this.\u0001.ResourceNumber = 102;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(329, 60));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(260, 71));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0007.\u0001(7128));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0007.\u0001(6519));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Right);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0002, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(179, 71));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0007.\u0001(12851));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0007.\u0001(12381));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u007F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0007.\u0001(4341), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(2, 84));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0007.\u0001(6704));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 36);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0007.\u0001(6729));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0002);
      \u000E\u001F.\u0010\u008B((object) this, new Size(341, 98));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0007.\u0001(5463)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0007.\u0001(14364));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0007.\u0001(2503));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, \u000E e)
    {
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, \u0008\u0081.\u0087\u0096(e.Handle, IntPtr.Zero));
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005(0.8);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005(1.0);
    }

    private void \u001D\u0005(double value)
    {
      try
      {
        \u0002\u001D.\u001F\u008B((object) this, value);
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
      }
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      \u0013.\u001D\u0005(\u0007.\u0003, new object[1]
      {
        (object) this.SelectedHandle
      });
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      \u0013.\u001D\u0005(\u0007.\u0002, new object[1]
      {
        (object) this.SelectedHandle
      });
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }
  }
}
