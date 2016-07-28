// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u001A;
using \u001E;
using \u0084;
using System;
using System.Diagnostics;
using System.Security.Permissions;

namespace \u001F
{
  internal sealed class \u001C : \u0016
  {
    private Process \u0001;
    private bool \u0001;

    public Process Process
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (this.\u0001 == value)
          return;
        this.\u001D\u0005(value, true);
        this.\u0001 = false;
      }
    }

    internal IntPtr MainWindowHandle
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        if (this.\u0001 == null)
          return IntPtr.Zero;
        \u001A\u001E.\u007E\u0015\u0004\u0002((object) this.\u0001);
        return this.\u0001.\u001D\u0005();
      }
      set
      {
        if (!\u0008\u0081.\u0087\u0096(this.MainWindowHandle, value))
          return;
        if (!\u0008\u0081.\u0086\u0096(value, IntPtr.Zero))
        {
          try
          {
            this.\u001D\u0005(\u000E.\u001D\u0005(value), true);
            this.\u0001 = true;
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005();
            this.Process = (Process) null;
          }
        }
        else
          this.Process = (Process) null;
      }
    }

    public string MainWindowTitle
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        if (this.\u0001 == null)
          return string.Empty;
        \u001A\u001E.\u007E\u0015\u0004\u0002((object) this.\u0001);
        return this.\u0001.\u001D\u0005();
      }
    }

    public bool ProcessOpen
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        if (this.\u0001 == null)
          return false;
        return !\u0099\u0082.\u007E\u009D\u0003\u0002((object) this.\u0001);
      }
    }

    public event EventHandler ProcessExited;

    public \u001C(Process p, bool ownsProcess, bool isOpen = true)
    {
      this.\u001D\u0005(p, isOpen);
      this.\u0001 = ownsProcess;
    }

    public \u001C()
    {
    }

    internal \u001C(IntPtr hWnd)
    {
      this.MainWindowHandle = hWnd;
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    private void \u001D\u0005(Process p, bool isOpen = true)
    {
      if (this.\u0001 && this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (p != null)
      {
        \u0099\u001F.\u007E\u000F\u0004\u0002((object) p, true);
        p.Exited += (EventHandler) ((obj, e) =>
        {
          if (this.\u0001 != (Process) obj)
            return;
          this.Process = (Process) null;
          this.\u0081\u0005();
        });
        if (isOpen && \u0099\u0082.\u007E\u009D\u0003\u0002((object) p))
        {
          this.Process = (Process) null;
          this.\u0081\u0005();
        }
      }
      this.\u0001 = p;
    }

    private void \u0081\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    protected override void \u001D\u0005()
    {
      if (this.\u0001 && this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      base.\u001D\u0005();
    }
  }
}
