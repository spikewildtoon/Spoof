// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u001A;
using \u001E;
using \u001F;
using \u0080;
using \u0081;
using \u0082;
using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace \u0082
{
  internal sealed class \u007F : \u0016
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly int \u0001;
    private FileStream \u0001;
    private SafeFileHandle \u0001;
    private Task \u0001;

    public bool Connected { get; private set; }

    public string PipeName { get; private set; }

    public event EventHandler<\u0004> MessageReceived;

    public event EventHandler ServerDisconnected;

    static \u007F()
    {
      \u0004.\u001D\u0005(typeof (\u007F));
      \u007F.\u0001 = 4096;
    }

    public void \u001E\u0005(string pipename)
    {
      if (this.Connected)
        throw new Exception(\u007F.\u0001(100140));
      this.PipeName = pipename;
      this.\u0001 = \u000E.\u001D\u0005(this.PipeName, \u001B.\u0015.\u0003 | \u001B.\u0015.\u0004, \u0018.\u0001, IntPtr.Zero, \u0013.\u0003, \u0083.\u0001.\u0013, IntPtr.Zero);
      if (\u0099\u0082.\u007E\u0095\u0097((object) this.\u0001))
      {
        try
        {
          throw new Win32Exception();
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005();
        }
        \u001A\u001E.\u007E\u0097\u0097((object) this.\u0001);
        this.\u0001 = (SafeFileHandle) null;
        this.PipeName = (string) null;
      }
      else
      {
        this.\u0001 = new FileStream(this.\u0001, FileAccess.ReadWrite, \u007F.\u0001, true);
        this.Connected = true;
        this.\u0001 = new Task(new Action(this.\u0082\u0005));
        \u001A\u001E.\u007E\u0017\u0099((object) this.\u0001);
      }
    }

    public void \u0081\u0005()
    {
      if (!this.Connected)
        return;
      this.Connected = false;
      this.PipeName = (string) null;
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0084\u009D((object) this.\u0001);
        \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
        this.\u0001 = (FileStream) null;
      }
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0096\u0097((object) this.\u0001);
        \u001A\u001E.\u007E\u0097\u0097((object) this.\u0001);
        this.\u0001 = (SafeFileHandle) null;
      }
      if (this.\u0001 == null)
        return;
      \u001A\u001E.\u007E\u001B\u0099((object) this.\u0001);
      \u001A\u001E.\u007E\u001A\u0099((object) this.\u0001);
      this.\u0001 = (Task) null;
    }

    protected override void \u001D\u0005()
    {
      this.\u0081\u0005();
      base.\u001D\u0005();
    }

    private void \u0082\u0005()
    {
      byte[] numArray = new byte[\u007F.\u0001];
      MemoryStream memoryStream = new MemoryStream();
      try
      {
        while (true)
        {
          do
          {
            \u0012\u0080.\u007E\u008C\u009D((object) memoryStream, 0L);
            int num1 = 0;
            try
            {
              if (\u0080\u0081.\u007E\u008D\u009D((object) this.\u0001, numArray, 0, 4) != 0)
              {
                int num2 = \u0014\u001E.\u0001\u0095(numArray, 0);
                do
                {
                  int num3 = \u0080\u0081.\u007E\u008D\u009D((object) this.\u0001, numArray, 0, \u0099\u0081.\u009F\u0096(num2 - num1, \u007F.\u0001));
                  \u0016\u0086.\u007E\u008F\u009D((object) memoryStream, numArray, 0, num3);
                  num1 += num3;
                }
                while (num1 < num2);
              }
              else
                goto label_13;
            }
            catch
            {
              goto label_13;
            }
            if (num1 == 0)
              goto label_13;
          }
          while (this.\u0001 == null);
          this.\u0001((object) this, new \u0004(\u0086\u0083.\u007E\u0003\u009F((object) memoryStream)));
        }
      }
      finally
      {
        if (memoryStream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
      }
label_13:
      if (!this.Connected)
        return;
      int num = \u001E\u001F.\u009A\u0098((WaitCallback) (_ =>
      {
        this.\u0081\u0005();
        if (this.\u0001 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
      }), (object) null) ? 1 : 0;
    }

    public bool \u001D\u0005(byte[] message)
    {
      try
      {
        \u0016\u0086.\u007E\u008F\u009D((object) this.\u0001, \u001B\u0086.\u009C\u0094(message.Length), 0, 4);
        \u0016\u0086.\u007E\u008F\u009D((object) this.\u0001, message, 0, message.Length);
        \u001A\u001E.\u007E\u0088\u009D((object) this.\u0001);
        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}
