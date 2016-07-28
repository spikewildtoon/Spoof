// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001B;
using \u001D;
using \u001E;
using \u001F;
using \u007F;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001D
{
  internal sealed class \u0016 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Button \u0001;
    private Label \u0001;
    private Label \u0002;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private bool \u0001;
    private \u0016 \u0001;
    private List<KeyValuePair<IntPtr, Rectangle>> \u0001;
    private \u001C \u0001;
    private IntPtr \u0001;

    public int ResourceNumber { get; set; }

    public string LabelMessage
    {
      get
      {
        return \u0002\u007F.\u007E\u001C\u0084((object) this.\u0002);
      }
      set
      {
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, value);
      }
    }

    public IntPtr SelectedWindow
    {
      get
      {
        return this.\u0001.MainWindowHandle;
      }
      set
      {
        if (!\u0008\u0081.\u0087\u0096(this.\u0001.MainWindowHandle, value))
          return;
        this.\u0001.MainWindowHandle = value;
        this.\u001E\u0005((MethodInvoker) (() => \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, this.\u0001.MainWindowTitle)));
        this.\u001E\u0005(value);
      }
    }

    public event EventHandler<\u000E> SelectedHandleChanged;

    public event EventHandler BeginSelecting;

    public event EventHandler EndSelecting;

    public event EventHandler<\u0080.\u0017> SelectedHandleChanging;

    static \u0016()
    {
      \u0004.\u001D\u0005(typeof (\u0016));
      \u0016.\u0001 = \u0016.\u0001(63896);
      \u0016.\u0002 = \u0016.\u0001(63961);
      \u0016.\u0003 = \u0016.\u0001(64018);
      \u0016.\u0004 = \u0016.\u0001(64051);
      \u0016.\u0005 = \u0016.\u0001(64104);
    }

    public \u0016()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.\u001D\u0005();
      this.\u0001 = new \u001C();
      \u001C obj = this.\u0001;
      if (eventHandler1 == null)
      {
        // ISSUE: method pointer
        eventHandler1 = new EventHandler((object) this, __methodptr(\u001D\u0005));
      }
      EventHandler eventHandler2 = eventHandler1;
      obj.ProcessExited += eventHandler2;
    }

    private void \u001D\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0016)));
      this.\u0001 = new Label();
      this.\u0001 = new Button();
      this.\u0002 = new Label();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(69, 18));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0001(63812));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(219, 34));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0016.\u0001(63833)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(2, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u0001(63858));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(56, 56));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u000F\u0086.\u007E\u0092\u0084((object) this.\u0001, new MouseEventHandler(this.\u001F\u0005));
      \u000F\u0086.\u007E\u0096\u0084((object) this.\u0001, new MouseEventHandler(this.\u001D\u0005));
      \u000F\u0086.\u007E\u0097\u0084((object) this.\u0001, new MouseEventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0016.\u0001(8897), 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(62, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0016.\u0001(63533));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(202, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0016.\u0001(17271));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0016.\u0001(63875));
      \u000E\u001F.\u0018\u0084((object) this, new Size(305, 60));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private bool \u001D\u0005(IntPtr hWnd)
    {
      if (this.\u0001 == null)
        return true;
      \u0080.\u0017 e = new \u0080.\u0017(hWnd);
      this.\u0001((object) this, e);
      return e.IsValid;
    }

    private void \u001E\u0005(IntPtr hWnd)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u000E(hWnd));
    }

    protected override void OnLoad(EventArgs e)
    {
      if (!\u0099\u0082.\u0081\u0001\u0002((object) this))
      {
        try
        {
          this.\u0001 = new \u0016(this.ResourceNumber, \u0016.\u0005);
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005();
          this.\u0001 = (\u0016) null;
        }
      }
      \u0088\u001C.\u009E\u0090((object) this, e);
    }

    protected override void Dispose(bool disposing)
    {
      \u0011\u007F.\u009E\u0089(\u009B\u0086.\u0007\u008A());
      this.\u001E\u0005();
      this.\u0001.Dispose();
      if (this.\u0001 != null)
        goto label_6;
label_1:
      if (this.\u0001 != null)
      {
        this.\u0001.Clear();
        this.\u0001 = (List<KeyValuePair<IntPtr, Rectangle>>) null;
      }
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
      return;
label_6:
      this.\u0001.Dispose();
      this.\u0001 = (\u0016) null;
      goto label_1;
    }

    private void \u001D\u0005(object sender, MouseEventArgs e)
    {
      if (\u0094\u0080.\u007E\u008C\u008A((object) e) != MouseButtons.Left || this.\u0001 == null)
        return;
      for (int index = 0; index < this.\u0001.Count; ++index)
      {
        KeyValuePair<IntPtr, Rectangle> keyValuePair = this.\u0001[index];
        if (keyValuePair.Value.Contains(\u0098\u0080.\u009F\u0089()))
        {
          if (!\u0008\u0081.\u0087\u0096(keyValuePair.Key, this.\u0001))
            break;
          this.\u001E\u0005();
          if (\u0080\u0083.\u009F\u0084(keyValuePair.Key) == null && this.\u001D\u0005(keyValuePair.Key))
          {
            \u0013.\u001D\u0005(\u0016.\u0001, new object[1]
            {
              (object) keyValuePair.Key
            });
            this.SelectedWindow = keyValuePair.Key;
            \u0013.\u001D\u0005(\u0016.\u0002, new object[1]
            {
              (object) this.SelectedWindow
            });
            this.\u001F\u0005(keyValuePair.Key);
            break;
          }
          this.SelectedWindow = IntPtr.Zero;
          break;
        }
      }
    }

    private void \u001F\u0005(IntPtr hWnd)
    {
      this.\u0001 = hWnd;
      \u0011.\u001D\u0005(this.\u0001);
      this.\u0001 = true;
    }

    private void \u001E\u0005()
    {
      if (!this.\u0001 || !\u0008\u0081.\u0087\u0096(this.\u0001, IntPtr.Zero))
        return;
      \u0011.\u001E\u0005(this.\u0001);
      this.\u0001 = false;
      this.\u0001 = IntPtr.Zero;
    }

    private void \u001E\u0005(object sender, MouseEventArgs e)
    {
      if (\u0094\u0080.\u007E\u008C\u008A((object) e) != MouseButtons.Left)
        return;
      if (this.\u0002 != null)
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
      \u0011\u007F.\u009E\u0089(\u009B\u0086.\u0007\u008A());
      this.\u001E\u0005();
      \u0013.\u001D\u0005(\u0016.\u0004, new object[1]
      {
        (object) this.SelectedWindow
      });
    }

    private void \u001F\u0005(object sender, MouseEventArgs e)
    {
      if (\u0094\u0080.\u007E\u008C\u008A((object) e) != MouseButtons.Left)
        return;
      \u0013.\u001D\u0005(\u0016.\u0003, true);
      if (this.\u0001 != null)
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
      if (this.\u0001 == null)
        \u0011\u007F.\u009E\u0089(\u009B\u0086.\u0006\u008A());
      else
        \u0011\u007F.\u009E\u0089(this.\u0001.Cursor);
      this.SelectedWindow = IntPtr.Zero;
      this.\u001E\u0005();
      if (this.\u0001 == null)
        this.\u0001 = new List<KeyValuePair<IntPtr, Rectangle>>();
      \u0013.\u001D\u0005(this.\u0001);
    }
  }
}
