// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0081;
using System;
using System.Security.Permissions;
using System.Windows.Forms;

namespace \u0084
{
  internal sealed class \u0018 : NativeWindow, IDisposable
  {
    public event EventHandler<\u000F> HotkeyPressed;

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public \u0018()
    {
      \u0082\u001C.\u007E\u008A\u0086((object) this, new CreateParams());
    }

    ~\u0018()
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
      if (m.Msg == 786 && this.\u0001 != null)
        goto label_2;
label_1:
      \u0015\u0084.\u008C\u0086((object) this, ref m);
      return;
label_2:
      this.\u0001((object) this, new \u000F(m.WParam.ToInt32()));
      goto label_1;
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
