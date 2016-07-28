// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u001F;
using \u0080;
using System;
using System.Threading;
using System.Timers;

namespace \u0083
{
  internal sealed class \u0014 : \u0016
  {
    private readonly object \u0001 = new object();
    private System.Timers.Timer \u0001;
    private \u0018 \u0001;
    private ManualResetEventSlim \u0001;

    public \u0014(\u0018 toontownWindow)
    {
      this.\u0001 = new ManualResetEventSlim();
      this.\u0001 = new System.Timers.Timer();
      \u0002\u001D.\u007E\u0096\u0003\u0002((object) this.\u0001, 200.0);
      // ISSUE: method pointer
      \u0010\u0081.\u007E\u0097\u0003\u0002((object) this.\u0001, new ElapsedEventHandler((object) this, __methodptr(\u001D\u0005)));
      this.\u0001 = toontownWindow;
      this.\u0001.ToonTownProcess.ProcessExited += (EventHandler) ((sender, e) =>
      {
        if (this.IsDisposingOrDisposed)
          return;
        \u001A\u001E.\u007E\u0002\u0099((object) this.\u0001);
        this.\u0082\u0005();
      });
    }

    protected override void \u001D\u0005()
    {
      \u001A\u001E.\u007E\u0002\u0099((object) this.\u0001);
      this.\u0082\u0005();
      \u001A\u001E.\u007E\u0007\u0099((object) this.\u0001);
      \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      base.\u001D\u0005();
    }

    public void \u0081\u0005()
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        if (\u0099\u0082.\u007E\u0094\u0003\u0002((object) this.\u0001))
          return;
        this.\u0001.LogMonitor.LogMonitoringPrecision = \u007F.\u0003;
        \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, true);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    public void \u0082\u0005()
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        if (!\u0099\u0082.\u007E\u0094\u0003\u0002((object) this.\u0001))
          return;
        \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
        this.\u0001.LogMonitor.LogMonitoringPrecision = \u007F.\u0002;
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.IsDisposingOrDisposed)
        return;
      IntPtr mainWindowHandle = this.\u0001.ToonTownProcess.MainWindowHandle;
      if (!this.\u0001.ToonTownProcess.ProcessOpen)
        return;
      \u001A.\u001A.\u001D\u0005(mainWindowHandle, this.\u0001);
    }
  }
}
