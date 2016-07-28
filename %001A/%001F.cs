// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u001A;
using \u001E;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace \u001A
{
  internal sealed class \u001F : \u0016
  {
    private static readonly IPAddress \u0001 = new IPAddress(2747615841L);
    private static readonly int \u0001 = 1024;
    private static readonly int \u0002 = 1024;
    private List<byte[]> \u0001 = new List<byte[]>();
    private Queue<byte[]> \u0002 = new Queue<byte[]>();
    private byte[] \u0002 = new byte[\u001F.\u0002];
    private int? \u0001 = new int?();
    private readonly object \u0001 = new object();
    private Socket \u0001;
    private IPEndPoint \u0001;
    private Queue<byte[]> \u0001;
    private byte[] \u0001;
    private int \u0003;
    private int \u0004;
    private int \u0005;
    private int \u0006;
    private int \u0007;
    private \u001F.\u0001 \u0001;

    public bool Connecting
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (System.Enum) \u001F.\u0001.\u0002);
      }
      private set
      {
        this.\u001D\u0005(\u001F.\u0001.\u0002, value);
      }
    }

    public bool Connected
    {
      get
      {
        return \u0099\u0082.\u007E\u0015\u0003\u0002((object) this.\u0001);
      }
    }

    public bool Disconnecting
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (System.Enum) \u001F.\u0001.\u0003);
      }
      private set
      {
        this.\u001D\u0005(\u001F.\u0001.\u0003, value);
      }
    }

    public bool WaitingForData
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (System.Enum) \u001F.\u0001.\u0004);
      }
      private set
      {
        this.\u001D\u0005(\u001F.\u0001.\u0004, value);
      }
    }

    public bool SendingData
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (System.Enum) \u001F.\u0001.\u0005);
      }
      private set
      {
        this.\u001D\u0005(\u001F.\u0001.\u0005, value);
      }
    }

    public event EventHandler ClientConnected;

    public event EventHandler ClientDisconnected;

    public event EventHandler ClientError;

    private \u001F()
    {
      this.\u0001 = new Queue<byte[]>();
      this.\u0001 = \u001F.\u0001.\u0001;
    }

    protected \u001F(int port)
      : this()
    {
      this.\u0001 = new IPEndPoint(\u001F.\u0001, port);
    }

    private void \u001D\u0005(\u001F.\u0001 state, bool value)
    {
      if (!value)
        this.\u0001 &= ~state;
      else
        this.\u0001 |= state;
    }

    protected override void \u001D\u0005()
    {
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0003\u0002((object) this.\u0001);
      base.\u001D\u0005();
    }

    private void \u0081\u0005()
    {
      if (this.\u0003 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0003, (object) this, EventArgs.Empty);
    }

    protected void \u001D\u0005(MethodInvoker del)
    {
      try
      {
        \u001A\u001E.\u007E\u0001\u008E((object) del);
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        this.\u0081\u0005();
      }
    }

    protected void \u001D\u0005(MethodInvoker del, MethodInvoker errorDel)
    {
      try
      {
        \u001A\u001E.\u007E\u0001\u008E((object) del);
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        \u001A\u001E.\u007E\u0001\u008E((object) errorDel);
        this.\u0081\u0005();
      }
    }

    public void \u0082\u0005()
    {
      base.\u0080\u0005();
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        if (this.\u0001 != \u001F.\u0001.\u0001)
          return;
        this.\u001D\u0005((MethodInvoker) (() =>
        {
          this.Connecting = true;
          this.\u0001 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
          // ISSUE: method pointer
          IAsyncResult asyncResult = \u001C\u007F.\u007E\u0016\u0003\u0002((object) this.\u0001, (EndPoint) this.\u0001, new AsyncCallback((object) this, __methodptr(\u001D\u0005)), (object) null);
        }), (MethodInvoker) (() => this.Connecting = false));
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u001D\u0005(IAsyncResult asyncResult)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u001F.\u0002()
      {
        \u0001 = asyncResult,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    protected void \u001E\u0005(byte[] data)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001F.\u0003 obj1 = new \u001F.\u0003();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = data;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      base.\u0080\u0005();
      bool flag = false;
      object obj2;
      try
      {
        \u0098\u0082.\u0081\u0098(obj2 = this.\u0001, ref flag);
        // ISSUE: reference to a compiler-generated method
        this.\u001D\u0005(new MethodInvoker(obj1.\u001D\u0005));
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj2);
      }
    }

    private void \u0083\u0005()
    {
      if (this.SendingData)
        return;
      if (this.\u0001 == null || this.\u0001.Length - this.\u0003 == 0)
        goto label_5;
label_3:
      this.SendingData = true;
      this.\u0004 = this.\u0001.Length - this.\u0003;
      this.\u0004 = this.\u0004 < \u001F.\u0001 ? this.\u0004 : \u001F.\u0001;
      this.\u001D\u0005((MethodInvoker) (() =>
      {
        if (\u0099\u0082.\u007E\u0015\u0003\u0002((object) this.\u0001))
        {
          // ISSUE: method pointer
          IAsyncResult asyncResult = \u009D\u0080.\u007E\u001A\u0003\u0002((object) this.\u0001, this.\u0001, this.\u0003, this.\u0004, SocketFlags.None, new AsyncCallback((object) this, __methodptr(\u001E\u0005)), (object) null);
        }
        else
          this.\u0081\u0005();
      }));
      return;
label_5:
      if (this.\u0001.Count != 0)
      {
        this.\u0001 = this.\u0001.Dequeue();
        this.\u0003 = 0;
        goto label_3;
      }
      else
      {
        this.\u0001 = (byte[]) null;
        this.\u0003 = 0;
        this.\u0004 = 0;
      }
    }

    private void \u001E\u0005(IAsyncResult asyncResult)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u001F.\u0004()
      {
        \u0001 = asyncResult,
        \u0001 = this,
        \u0001 = 0
      }, __methodptr(\u001D\u0005)));
    }

    public void \u0084\u0005()
    {
      base.\u0080\u0005();
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        this.\u001D\u0005((MethodInvoker) (() =>
        {
          if (!\u0099\u0082.\u007E\u0015\u0003\u0002((object) this.\u0001))
          {
            if (this.\u0002 == null)
              return;
            \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
          }
          else
          {
            if (this.Disconnecting)
              return;
            this.Disconnecting = true;
            // ISSUE: method pointer
            IAsyncResult asyncResult = \u0012\u001F.\u007E\u0017\u0003\u0002((object) this.\u0001, false, new AsyncCallback((object) this, __methodptr(\u001F\u0005)), (object) null);
          }
        }), (MethodInvoker) (() => this.Disconnecting = false));
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u001F\u0005(IAsyncResult asyncResult)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u001F.\u0005()
      {
        \u0001 = asyncResult,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u0086\u0005()
    {
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) this, __methodptr(\u008E\u0005)));
    }

    private void \u007F\u0005(IAsyncResult asyncResult)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u001F.\u0006()
      {
        \u0001 = asyncResult,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(out int? length)
    {
      byte[] data = (byte[]) null;
      try
      {
        this.\u001D\u0005(4, out data);
        if (data != null)
          length = new int?(\u0014\u001E.\u0001\u0095(data, 0));
        else
          length = new int?();
      }
      finally
      {
      }
    }

    private void \u001D\u0005(int iPacketLength, out byte[] data)
    {
      data = (byte[]) null;
      int num1 = 0;
      for (int index = this.\u0006; index < this.\u0001.Count; ++index)
      {
        if (index != this.\u0006)
        {
          num1 += this.\u0001[index].Length;
          continue;
        }
        num1 += this.\u0001[index].Length - this.\u0007;
      }
      if (num1 < iPacketLength)
        return;
      data = new byte[iPacketLength];
      int num2 = iPacketLength;
      do
      {
        int num3 = this.\u0001[this.\u0006].Length - this.\u0007;
        if (num3 >= num2)
        {
          \u0089\u0083.\u0084\u0092((Array) this.\u0001[this.\u0006], this.\u0007, (Array) data, iPacketLength - num2, num2);
          this.\u0007 += num2;
          num2 = 0;
        }
        else
        {
          \u0089\u0083.\u0084\u0092((Array) this.\u0001[this.\u0006], this.\u0007, (Array) data, iPacketLength - num2, num3);
          this.\u0007 += num3;
          num2 -= num3;
        }
        if (this.\u0007 == this.\u0001[this.\u0006].Length)
        {
          ++this.\u0006;
          this.\u0007 = 0;
        }
      }
      while (num2 != 0);
    }

    private void \u0087\u0005()
    {
      byte[] numArray = new byte[this.\u0005];
      \u0006\u001D.\u0083\u0092((Array) this.\u0002, (Array) numArray, this.\u0005);
      this.\u0001.Add(numArray);
      byte[] data = (byte[]) null;
      try
      {
        do
        {
          if (!this.\u0001.HasValue)
            this.\u001D\u0005(out this.\u0001);
          if (this.\u0001.HasValue)
          {
            this.\u001D\u0005(this.\u0001.Value, out data);
            if (data != null)
            {
              this.\u0002.Enqueue(data);
              this.\u0001 = new int?();
            }
          }
          else
            break;
        }
        while (data != null);
      }
      finally
      {
      }
      for (int index = 0; index < this.\u0006; ++index)
      {
        this.\u0001.RemoveAt(0);
        --this.\u0006;
      }
      this.\u0088\u0005();
    }

    private void \u0088\u0005()
    {
      byte[] numArray = (byte[]) null;
      try
      {
        for (int index = 0; index < this.\u0002.Count; int num = index++)
          this.\u001D\u0005(this.\u0002.Dequeue());
      }
      finally
      {
        numArray = (byte[]) null;
      }
    }

    protected virtual void \u001F\u0005()
    {
    }

    protected virtual void \u001D\u0005(byte[] data)
    {
    }

    protected virtual void \u007F\u0005()
    {
    }

    [System.Flags]
    private enum \u0001
    {
      \u0001 = 0,
      \u0002 = 1,
      \u0003 = 4,
      \u0004 = 8,
      \u0005 = 16,
    }
  }
}
