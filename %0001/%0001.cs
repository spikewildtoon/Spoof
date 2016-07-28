// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace \u0001
{
  internal sealed class \u0001
  {
    private long \u0001 = DateTime.Now.Ticks;
    private static \u0001.\u0001 \u0001;

    private \u0001()
    {
      // ISSUE: method pointer
      Application.Idle += new EventHandler((object) this, __methodptr(\u001D\u0005));
      this.\u001D\u0005();
    }

    [DllImport("kernel32", EntryPoint = "SetProcessWorkingSetSize")]
    private static extern int \u001D\u0005(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

    private void \u001D\u0005()
    {
      try
      {
        using (Process currentProcess = Process.GetCurrentProcess())
          \u0001.\u0001.\u001D\u0005(currentProcess.Handle, -1, -1);
      }
      catch
      {
      }
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      try
      {
        long ticks = DateTime.Now.Ticks;
        if (ticks - this.\u0001 <= 10000000L)
          return;
        this.\u0001 = ticks;
        this.\u001D\u0005();
      }
      catch
      {
      }
    }

    public static void \u001E\u0005()
    {
      try
      {
        if (Environment.OSVersion.Platform != PlatformID.Win32NT)
          return;
        \u0001.\u0001.\u0001 = new \u0001.\u0001();
      }
      catch
      {
      }
    }
  }
}
