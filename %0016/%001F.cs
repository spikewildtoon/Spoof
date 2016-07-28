// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u001A;
using \u001C;
using \u007F;
using \u0081;
using \u0082;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace \u0016
{
  internal sealed class \u001F : \u0015.\u0016
  {
    private string \u0008 = \u0016.\u001F.\u0001(26045);
    private readonly object \u0001 = new object();
    private readonly Stack<\u0080> \u0001 = new Stack<\u0080>(2);
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly int \u0001;
    private static readonly int \u0002;
    private static readonly string \u0006;
    private Task \u0001;
    private string \u0007;
    private int \u0003;
    private \u0082.\u007F \u0001;
    private Process \u0001;

    public \u001F.\u0015 UpdateStep { get; private set; }

    public string UpdaterExitedPrematurely_Title { get; set; }

    public string UpdaterExitedPrematurely { get; set; }

    public string ExtraArguments { get; set; }

    public string wyUpdateLocation
    {
      get
      {
        return this.\u0008;
      }
      set
      {
        this.\u0008 = value;
        try
        {
          this.\u0007 = Path.GetFullPath(\u008F\u0084.\u0010\u009F(value) ? value : \u0081\u0086.\u0011\u009F(\u009C\u0080.\u0005\u009F(\u008E\u001E.\u0006\u0083()), value));
        }
        catch
        {
        }
      }
    }

    public event EventHandler<\u0005> UpdateStepMismatch;

    public event EventHandler<\u0003> ProgressChanged;

    public event EventHandler<\u0003> PipeServerDisconnected;

    public event EventHandler Canceled;

    static \u001F()
    {
      \u0004.\u001D\u0005(typeof (\u0016.\u001F));
      \u0016.\u001F.\u0001 = \u0016.\u001F.\u0001(26158);
      \u0016.\u001F.\u0002 = \u0016.\u001F.\u0001(26211);
      \u0016.\u001F.\u0003 = \u0016.\u001F.\u0001(26244);
      \u0016.\u001F.\u0004 = \u0016.\u001F.\u0001(26297);
      \u0016.\u001F.\u0005 = \u0016.\u001F.\u0001(26350);
      \u0016.\u001F.\u0001 = 20;
      \u0016.\u001F.\u0002 = 250;
      \u0016.\u001F.\u0006 = \u0016.\u001F.\u0001(26367);
    }

    public \u001F()
    {
      this.UpdateStep = \u001F.\u0015.\u0001;
      try
      {
        this.\u0007 = Path.GetFullPath(\u008F\u0084.\u0010\u009F(this.\u0008) ? this.\u0008 : \u0081\u0086.\u0011\u009F(\u009C\u0080.\u0005\u009F(\u008E\u001E.\u0006\u0083()), this.\u0008));
      }
      catch
      {
      }
      this.\u0081\u0005();
    }

    protected override void \u001D\u0005()
    {
      Task task = this.\u0001;
      if (task != null)
      {
        try
        {
          \u001A\u001E.\u007E\u001B\u0099((object) task);
        }
        catch (AggregateException ex)
        {
        }
        catch (ObjectDisposedException ex)
        {
        }
      }
      if (this.\u0001 != null)
      {
        this.\u0001.Dispose();
        this.\u0001 = (\u0082.\u007F) null;
      }
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
        this.\u0001 = (Process) null;
      }
      base.\u001D\u0005();
    }

    private void \u0081\u0005()
    {
      if (this.\u0001 != null)
        goto label_2;
label_1:
      this.\u0001 = new \u0082.\u007F();
      this.\u0001.MessageReceived += new EventHandler<\u0004>(this.\u001D\u0005);
      this.\u0001.ServerDisconnected += new EventHandler(this.\u001D\u0005);
      return;
label_2:
      // ISSUE: method pointer
      this.\u0001.MessageReceived -= new EventHandler<\u0004>((object) this, __methodptr(\u001D\u0005));
      // ISSUE: method pointer
      this.\u0001.ServerDisconnected -= new EventHandler((object) this, __methodptr(\u001D\u0005));
      this.\u0001.Dispose();
      this.\u0001 = (\u0082.\u007F) null;
      goto label_1;
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
        this.\u0001 = (Process) null;
      }
      if (this.\u0002 == null)
        return;
      this.\u0002((object) this, new \u0003(new \u0080(\u0080.\u0001, this.UpdateStep, this.UpdaterExitedPrematurely_Title, this.UpdaterExitedPrematurely)));
    }

    private void \u001D\u0005(object sender, \u0004 e)
    {
      \u0080 updateHelperData = \u0080.\u001D\u0005(e.Message);
      switch (updateHelperData.Action)
      {
        case \u0010.\u0002:
          this.\u0001 = \u009E\u0082.\u0012\u0004\u0002(updateHelperData.ProcessID);
          break;
        case \u0010.\u0004:
          this.\u0001.\u0081\u0005();
          this.\u0081\u0005();
          this.\u0001 = \u009E\u0082.\u0012\u0004\u0002(updateHelperData.ProcessID);
          this.\u0080\u0005(updateHelperData.ExtraData[0]);
          if (!this.\u0001.Connected && this.\u0002 != null)
            this.\u0002((object) this, new \u0003(new \u0080(\u0080.\u0001, this.UpdateStep, this.UpdaterExitedPrematurely_Title, \u0016.\u001F.\u0001(26062))));
          this.\u001D\u0005(new \u0080(this.UpdateStep));
          break;
        default:
          if (updateHelperData.UpdateStep != this.UpdateStep)
          {
            \u001F.\u0015 updateStep = this.UpdateStep;
            this.UpdateStep = updateHelperData.UpdateStep;
            if (this.\u0001 != null)
              this.\u0001((object) this, new \u0005(updateHelperData.ResponseType, updateStep));
          }
          if (updateHelperData.Action == \u0010.\u0001 && updateHelperData.UpdateStep == \u001F.\u0015.\u0005)
            this.\u0003 = updateHelperData.ProcessID;
          if (updateHelperData.ResponseType == \u0080.\u0002 || this.\u0001 == null)
            break;
          this.\u0001((object) this, new \u0003(updateHelperData));
          break;
      }
    }

    private void \u0080\u0005(string pipename)
    {
      for (int index = 0; !this.\u0001.Connected && index < 120; ++index)
      {
        this.\u0001.\u001E\u0005(pipename);
        if (this.\u0001.Connected)
          continue;
        if (this.\u0001 == null || \u0099\u0082.\u007E\u009D\u0003\u0002((object) this.\u0001))
        {
          this.\u0001 = (Process) null;
          break;
        }
        \u001E\u001E.\u008F\u0098(250);
      }
      if (this.\u0001.Connected)
        return;
      if (this.\u0001 == null)
        return;
      try
      {
        \u001A\u001E.\u007E\u001A\u0004\u0002((object) this.\u0001);
      }
      catch
      {
      }
      this.\u0001 = (Process) null;
    }

    public static string \u001D\u0005(string filename)
    {
      string str = \u0002\u007F.\u007E\u0019\u0093((object) \u008B\u0080.\u007E\u001D\u0093((object) filename, \u0016.\u001F.\u0001(26135), \u0016.\u001F.\u0001(3136)));
      int num = \u0005\u0081.\u007E\u0001\u0093((object) str);
      return \u0081\u0086.\u0086\u0093(\u0016.\u001F.\u0001(26140), \u0084\u0080.\u007E\u0006\u0093((object) str, \u0099\u0081.\u009E\u0096(0, num - 246), \u0099\u0081.\u009F\u0096(246, num)));
    }

    private bool \u001D\u0005(byte[] message)
    {
      bool flag;
      for (int index = 0; (flag = !this.\u0001.\u001D\u0005(message)) && (index < \u0016.\u001F.\u0001 && this.\u0001.Connected); ++index)
        \u001E\u001E.\u008F\u0098(\u0016.\u001F.\u0002);
      if (!this.\u0001.Connected)
        return true;
      return !flag;
    }

    private bool \u007F\u0005()
    {
      if (\u008F\u0084.\u009E\u0092(this.\u0007))
        throw new Exception(\u0016.\u001F.\u0006);
      string pipename = \u0016.\u001F.\u001D\u0005(this.\u0007);
      if (!this.\u0001.Connected)
        goto label_12;
label_2:
      if (this.\u0001.Connected)
      {
        if (!this.\u001D\u0005(new \u0080(\u0010.\u0002).\u001D\u0005()))
          throw new Exception(\u0016.\u001F.\u0004);
        return true;
      }
      if (!\u008F\u0084.\u0092\u009E(this.\u0007))
        throw new FileNotFoundException(\u0016.\u001F.\u0003, this.\u0007);
      this.\u0001 = new Process();
      \u001E\u0083.\u007E\u0008\u0004\u0002((object) this.\u0001, new ProcessStartInfo(this.\u0007, \u0016.\u001F.\u0005));
      \u0082\u0082.\u007E\u008A\u0004\u0002((object) \u001F\u001C.\u007E\u0007\u0004\u0002((object) this.\u0001), ProcessWindowStyle.Hidden);
      if (!\u008F\u0084.\u009E\u0092(this.ExtraArguments))
      {
        ProcessStartInfo processStartInfo = \u001F\u001C.\u007E\u0007\u0004\u0002((object) this.\u0001);
        string str = processStartInfo.Arguments + \u0016.\u001F.\u0001(26153) + this.ExtraArguments;
        processStartInfo.Arguments = str;
      }
      int num1 = \u0099\u0082.\u007E\u0016\u0004\u0002((object) this.\u0001) ? 1 : 0;
      int num2 = \u0095\u0081.\u007E\u001C\u0004\u0002((object) this.\u0001, 5000) ? 1 : 0;
      this.\u0080\u0005(pipename);
      return this.\u0001.Connected;
label_12:
      this.\u0001.\u001E\u0005(pipename);
      goto label_2;
    }

    private void \u0082\u0005()
    {
      // ISSUE: method pointer
      this.\u0001 = new Task(new Action((object) this, __methodptr(\u008A\u0005)));
      \u001A\u001E.\u007E\u0017\u0099((object) this.\u0001);
    }

    public void \u0083\u0005()
    {
      this.\u001D\u0005(new \u0080(\u001F.\u0015.\u0002));
    }

    public void \u0084\u0005()
    {
      this.\u001D\u0005(new \u0080(\u001F.\u0015.\u0001));
    }

    public void \u0086\u0005()
    {
      this.\u001D\u0005(new \u0080(\u001F.\u0015.\u0003));
    }

    public void \u0087\u0005()
    {
      this.\u001D\u0005(new \u0080(\u001F.\u0015.\u0004));
    }

    public void \u001D\u0005(string fileToExecute, string autoUpdateID, string argumentsForFiles, bool isAService)
    {
      \u0080 uhd = new \u0080(\u001F.\u0015.\u0005);
      uhd.ExtraData.Add(fileToExecute);
      uhd.ExtraDataIsRTF.Add(isAService);
      if (!\u008F\u0084.\u009E\u0092(autoUpdateID))
      {
        uhd.ExtraData.Add(autoUpdateID);
        uhd.ExtraDataIsRTF.Add(false);
        if (!\u008F\u0084.\u009E\u0092(argumentsForFiles))
        {
          uhd.ExtraData.Add(argumentsForFiles);
          uhd.ExtraDataIsRTF.Add(false);
        }
      }
      this.\u001D\u0005(uhd);
    }

    public void \u0088\u0005()
    {
      \u000E.\u001D\u0005(new HandleRef((object) this, new IntPtr(this.\u0003)), \u0006.\u0005);
      \u000E.\u0081\u0005(new IntPtr(this.\u0003));
      this.\u001D\u0005(new \u0080(\u001F.\u0015.\u0006));
    }

    public void \u0089\u0005()
    {
      this.\u001D\u0005(new \u0080(\u0010.\u0003));
    }

    private void \u001D\u0005(\u0080 uhd)
    {
      bool flag = false;
      \u0098\u0082.\u0081\u0098(this.\u0001, ref flag);
      this.\u0001.Push(uhd);
      if (this.\u0001 == null)
      {
        this.UpdateStep = uhd.UpdateStep == \u001F.\u0015.\u0002 ? \u001F.\u0015.\u0001 : uhd.UpdateStep;
        this.\u0082\u0005();
      }
      if (!flag)
        return;
      \u001A\u001E.\u0082\u0098(this.\u0001);
      flag = false;
    }
  }
}
