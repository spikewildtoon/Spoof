// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using System;
using System.Diagnostics;
using System.Security.Permissions;
using System.Windows.Forms;

namespace \u0017
{
  internal abstract class \u000F : TextBox
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    private ContextMenu \u0001;
    private MenuItem \u0001;
    private MenuItem \u0002;
    private MenuItem \u0003;
    private MenuItem \u0004;
    private MenuItem \u0005;

    static \u000F()
    {
      \u0004.\u001D\u0005(typeof (\u000F));
      \u000F.\u0001 = \u000F.\u0001(27583);
      \u000F.\u0002 = \u000F.\u0001(27592);
      \u000F.\u0003 = \u000F.\u0001(27601);
      \u000F.\u0004 = \u000F.\u0001(27610);
      \u000F.\u0005 = \u000F.\u0001(27619);
      \u000F.\u0006 = \u000F.\u0001(3563);
    }

    public \u000F()
    {
      EventHandler eventHandler = (EventHandler) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.\u0001 = new ContextMenu();
      Menu.MenuItemCollection menuItemCollection = \u0018\u0084.\u007E\u000E\u0089((object) this.\u0001);
      string text = \u000F.\u0001;
      if (eventHandler == null)
      {
        // ISSUE: method pointer
        eventHandler = new EventHandler((object) this, __methodptr(\u001D\u0005));
      }
      EventHandler onClick = eventHandler;
      MenuItem menuItem = this.\u0001 = new MenuItem(text, onClick);
      menuItemCollection.Add(menuItem);
      int num1 = \u0004\u0082.\u007E\u000F\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0001), new MenuItem(\u000F.\u0006));
      int num2 = \u0004\u0082.\u007E\u000F\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0001), this.\u0002 = new MenuItem(\u000F.\u0002));
      \u0018\u0084.\u007E\u000E\u0089((object) this.\u0001).Add(this.\u0003 = new MenuItem(\u000F.\u0003, (EventHandler) ((obj, e) => \u001A\u001E.\u001E\u008A((object) this))));
      \u0018\u0084.\u007E\u000E\u0089((object) this.\u0001).Add(this.\u0004 = new MenuItem(\u000F.\u0004, (EventHandler) ((obj, e) => \u001A\u001E.\u007F\u008A((object) this))));
      int num3 = \u0004\u0082.\u007E\u000F\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0001), this.\u0005 = new MenuItem(\u000F.\u0005));
      this.\u0001.Popup += (EventHandler) ((obj, e) =>
      {
        \u0099\u001F.\u007E\u0095\u008D((object) this.\u0001, \u0099\u0082.\u0013\u008A((object) this));
        \u0099\u001F.\u007E\u0095\u008D((object) this.\u0002, false);
        \u0099\u001F.\u007E\u0095\u008D((object) this.\u0003, \u0008\u001F.\u009B\u0092(\u0002\u007F.\u007E\u001A\u008A((object) this), string.Empty));
        \u0099\u001F.\u007E\u0095\u008D((object) this.\u0004, this.\u001D\u0005());
        \u0099\u001F.\u007E\u0095\u008D((object) this.\u0005, false);
      });
      \u0015\u001E.\u0084\u0083((object) this, this.\u0001);
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public override bool PreProcessMessage(ref Message msg)
    {
      if (msg.Msg != 256)
        return \u0017\u0082.\u001C\u0086((object) this, ref msg);
      Keys key = (Keys) msg.WParam.ToInt32();
      switch (key)
      {
        case Keys.V:
          if (\u0018\u0083.\u0008\u0084() == Keys.Control)
            return !this.\u001D\u0005();
          return true;
        case Keys.X:
          return true;
        case Keys.Z:
          return \u0018\u0083.\u0008\u0084() != Keys.Control;
        case Keys.NumPad0:
        case Keys.NumPad1:
        case Keys.NumPad2:
        case Keys.NumPad3:
        case Keys.NumPad4:
        case Keys.NumPad5:
        case Keys.NumPad6:
        case Keys.NumPad7:
        case Keys.NumPad8:
        case Keys.NumPad9:
        case Keys.Back:
        case Keys.Delete:
        case Keys.D0:
        case Keys.D1:
        case Keys.D2:
        case Keys.D3:
        case Keys.D4:
        case Keys.D5:
        case Keys.D6:
        case Keys.D7:
        case Keys.D8:
        case Keys.D9:
          return !this.\u001D\u0005(key);
        case Keys.Subtract:
        case Keys.OemMinus:
          if (this.\u001E\u0005() && \u0005\u0081.\u001C\u008A((object) this) == 0 && \u0080\u001E.\u007E\u0012\u0093((object) \u0002\u007F.\u0088\u008A((object) this), '-') == -1)
            return !this.\u001D\u0005(key);
          return true;
        case Keys.Decimal:
        case Keys.OemPeriod:
          return true;
        case Keys.Control:
        case Keys.Tab:
        case Keys.Return:
        case Keys.Left:
        case Keys.Up:
        case Keys.Right:
        case Keys.Down:
          return false;
        case Keys.A:
        case Keys.C:
          return \u0018\u0083.\u0008\u0084() != Keys.Control;
        default:
          return true;
      }
    }

    [DebuggerStepThrough]
    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected override void WndProc(ref Message m)
    {
      switch (m.Msg)
      {
        case 768:
          break;
        case 770:
          if (this.\u001D\u0005())
          {
            \u0015\u0084.\u008B\u008A((object) this, ref m);
            break;
          }
          m.Result = \u001D\u001E.\u0080\u0096(0);
          break;
        case 771:
          break;
        default:
          \u0015\u0084.\u008B\u008A((object) this, ref m);
          break;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u008A\u008A((object) this, disposing);
    }

    protected virtual bool \u001D\u0005()
    {
      throw new NotImplementedException();
    }

    protected virtual bool \u001E\u0005()
    {
      throw new NotImplementedException();
    }

    protected virtual bool \u001D\u0005(Keys key)
    {
      throw new NotImplementedException();
    }
  }
}
