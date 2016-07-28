// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0016;
using \u0017;
using \u0080;
using System;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;

namespace \u0080
{
  internal sealed class \u0006 : NativeWindow, IDisposable
  {
    public event EventHandler<\u0012> DataReceived;

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public \u0006()
    {
      \u0082\u001C.\u007E\u008A\u0086((object) this, new CreateParams());
    }

    ~\u0006()
    {
      try
      {
        this.\u001D\u0005(false);
      }
      finally
      {
        \u001A\u001E.\u0088\u0086((object) this);
      }
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected override void WndProc(ref Message m)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0006.\u0001 obj1 = new \u0006.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      if (m.Msg == 74)
      {
        // ISSUE: type reference
        \u0003 obj2 = (\u0003) \u000F\u001E.\u0014\u009D(m.LParam, \u009C\u0082.\u0016\u0097(__typeref (\u0003)));
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = \u0006\u0080.\u0004\u009D(obj2.\u0002);
        if (this.\u0001 != null)
        {
          \u0015\u0084.\u008C\u0086((object) this, ref m);
          // ISSUE: reference to a compiler-generated method
          int num = \u001E\u001F.\u009A\u0098(new WaitCallback(obj1.\u001D\u0005), (object) null) ? 1 : 0;
          return;
        }
      }
      \u0015\u0084.\u008C\u0086((object) this, ref m);
    }

    public void Dispose()
    {
      this.\u001D\u0005(true);
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    private void \u001D\u0005(bool disposing)
    {
      if (!disposing || !\u0008\u0081.\u0087\u0096(\u0088\u0086.\u0089\u0086((object) this), IntPtr.Zero))
        return;
      \u001A\u001E.\u007E\u008B\u0086((object) this);
    }
  }
}
