// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u001B;
using \u001E;
using \u0081;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;

namespace \u0081
{
  internal sealed class \u001A : \u0016
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly int \u0001;
    private static readonly int \u0002;
    private TcpListener \u0001;
    private int \u0003;
    private bool \u0001;
    private List<\u001A.\u0001> \u0001;
    private System.Timers.Timer \u0001;
    private readonly object \u0001;
    private \u0019 \u0001;

    public string PANDA_DOWNLOAD_URL
    {
      get
      {
        return \u009E\u0081.\u001F\u0093(\u001A.\u0002, (object) this.\u0003);
      }
    }

    public bool Running
    {
      get
      {
        return this.\u0001;
      }
    }

    static \u001A()
    {
      \u0004.\u001D\u0005(typeof (\u001A));
      \u001A.\u0001 = \u001A.\u0001(95513);
      \u001A.\u0002 = \u001A.\u0001(95526);
      \u001A.\u0003 = \u001A.\u0001(95555);
      \u001A.\u0001 = 5000;
      \u001A.\u0002 = 5000;
    }

    public \u001A(int port, \u0019 patcher)
    {
      this.\u0001 = patcher;
      this.\u0001 = new object();
      this.\u0001 = new List<\u001A.\u0001>();
      this.\u0003 = port;
    }

    protected override void \u001D\u0005()
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        this.\u0082\u0005();
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
      base.\u001D\u0005();
    }

    private void \u001D\u0005(\u001A.\u0001 data)
    {
      try
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
          if (this.\u0001.Contains(data))
            goto label_5;
label_2:
          if (this.\u0001.Count != 0)
            return;
          \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
          return;
label_5:
          this.\u0001.Remove(data);
          goto label_2;
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
      }
    }

    private void \u001D\u0005(object sender, ElapsedEventArgs e)
    {
      \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        try
        {
          if (!this.\u0001)
            return;
          for (int index = this.\u0001.Count - 1; index >= 0; --index)
          {
            if (\u001B\u0082.\u001F\u0094(\u001D\u0082.\u0011\u0094(), this.\u0001[index].\u0001).TotalMilliseconds > (double) \u001A.\u0002)
              this.\u001F\u0005(this.\u0001[index]);
          }
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005();
        }
        if (this.\u0001.Count == 0)
          \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
        else
          \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, true);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    public void \u0081\u0005()
    {
      WaitCallback waitCallback = (WaitCallback) null;
      if (\u0081.\u0001.DesignMode)
        return;
      if (waitCallback == null)
        goto label_4;
label_1:
      int num = \u001E\u001F.\u009A\u0098(waitCallback, (object) null) ? 1 : 0;
      return;
label_4:
      // ISSUE: method pointer
      waitCallback = new WaitCallback((object) this, __methodptr(\u001D\u0005));
      goto label_1;
    }

    public void \u0082\u0005()
    {
      if (\u0081.\u0001.DesignMode)
        return;
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        if (!this.\u0001)
          return;
        this.\u0001 = false;
        \u001A\u001E.\u007E\u0082\u0003\u0002((object) this.\u0001);
        \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
        this.\u0084\u0005();
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u0083\u0005()
    {
      try
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
          if (!this.\u0001)
            return;
          // ISSUE: method pointer
          IAsyncResult asyncResult = \u0016\u001F.\u007E\u0083\u0003\u0002((object) this.\u0001, new AsyncCallback((object) this, __methodptr(\u001D\u0005)), (object) null);
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
      }
    }

    private void \u001D\u0005(IAsyncResult ar)
    {
      Socket clientSocket = (Socket) null;
      try
      {
        clientSocket = \u0011\u0080.\u007E\u0084\u0003\u0002((object) this.\u0001, ar);
      }
      catch (ObjectDisposedException ex)
      {
        if (base.IsDisposed || this.IsDisposing)
          return;
        if (!this.\u0001)
          return;
      }
      \u001A.\u0001 data = (\u001A.\u0001) null;
      try
      {
        data = new \u001A.\u0001(clientSocket);
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
          this.\u0001.Add(data);
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
        if (\u001A.\u001D\u0005(\u009E\u0083.\u007E\u0004\u0003\u0002((object) (IPEndPoint) \u001C\u001F.\u007E\u0014\u0003\u0002((object) clientSocket))))
          this.\u001E\u0005(data);
        else
          this.\u001F\u0005(data);
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        if (data != null)
          this.\u001F\u0005(data);
      }
      this.\u0083\u0005();
      bool flag1 = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = this.\u0001, ref flag1);
        if (\u0099\u0082.\u007E\u0094\u0003\u0002((object) this.\u0001))
          return;
        \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, true);
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    private void \u001E\u0005(\u001A.\u0001 data)
    {
      try
      {
        data.\u0001 = \u001D\u0082.\u0011\u0094();
        // ISSUE: method pointer
        IAsyncResult asyncResult = \u009D\u0080.\u007E\u001D\u0003\u0002((object) data.\u0001, data.\u0001, 0, \u001A.\u0001.\u0001, SocketFlags.None, new AsyncCallback((object) this, __methodptr(\u001E\u0005)), (object) data);
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        this.\u001F\u0005(data);
      }
    }

    private void \u001E\u0005(IAsyncResult ar)
    {
      \u001A.\u0001 data = \u0005\u007F.\u007E\u0010\u0096((object) ar) as \u001A.\u0001;
      if (((\u0016) data).IsDisposed || data.IsDisposing)
        return;
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        try
        {
          int num = \u0088\u0080.\u007E\u001E\u0003\u0002((object) data.\u0001, ar);
          if (\u0099\u0082.\u007E\u0015\u0003\u0002((object) data.\u0001))
          {
            if (num > 0)
            {
              StringBuilder stringBuilder = \u007F\u0083.\u007E\u009D\u0093((object) data.\u0001, \u001E\u007F.\u007E\u0019\u009C((object) \u001D\u001F.\u0016\u009C(), data.\u0001, 0, num));
              if (\u0005\u0081.\u007E\u009C\u0093((object) data.\u0001) <= 8190)
              {
                string receivedData = \u0002\u007F.\u007E\u0087\u0091((object) data.\u0001);
                if (\u0016\u001D.\u007E\u0011\u0093((object) receivedData, \u001A.\u0001(95197)))
                {
                  string requestedFile;
                  string response;
                  if (\u001A.\u001D\u0005(receivedData, out requestedFile) && this.\u001D\u0005(data, requestedFile, out response))
                  {
                    data.\u0001 = \u0094\u0082.\u007E\u0017\u009C((object) \u001D\u001F.\u0016\u009C(), response);
                    this.\u007F\u0005(data);
                  }
                  else
                    this.\u001F\u0005(data);
                }
                else
                  this.\u001E\u0005(data);
              }
              else
                this.\u001F\u0005(data);
            }
            else
              this.\u001F\u0005(data);
          }
          else
          {
            this.\u001D\u0005(data);
            data.Dispose();
          }
        }
        catch (Exception ex)
        {
          this.\u001D\u0005(data);
          data.Dispose();
          ex.\u001D\u0005();
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u0084\u0005()
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        for (int index = this.\u0001.Count - 1; index >= 0; --index)
          this.\u001F\u0005(this.\u0001[index]);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u001F\u0005(\u001A.\u0001 data)
    {
      this.\u001D\u0005(data);
      try
      {
        if (\u0099\u0082.\u007E\u0015\u0003\u0002((object) data.\u0001))
        {
          IAsyncResult asyncResult = \u0012\u001F.\u007E\u0017\u0003\u0002((object) data.\u0001, false, new AsyncCallback(\u001A.\u001F\u0005), (object) data);
        }
        else
          data.Dispose();
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        data.Dispose();
      }
    }

    private static void \u001F\u0005(IAsyncResult ar)
    {
      try
      {
        \u001A.\u0001 obj = \u0005\u007F.\u007E\u0010\u0096((object) ar) as \u001A.\u0001;
        \u008C\u007F.\u007E\u0019\u0003\u0002((object) obj.\u0001, ar);
        obj.Dispose();
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
      }
    }

    private void \u007F\u0005(\u001A.\u0001 data)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        int num = data.\u0001.Length - data.\u0002;
        data.\u0001 = \u001D\u0082.\u0011\u0094();
        if (num > 0)
          data.\u0001.BeginSend(data.\u0001, data.\u0002, num > \u001A.\u0001.\u0001 ? \u001A.\u0001.\u0001 : num, SocketFlags.None, new AsyncCallback(this.\u007F\u0005), (object) data);
        else
          this.\u001F\u0005(data);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u007F\u0005(IAsyncResult result)
    {
      \u001A.\u0001 data = \u0005\u007F.\u007E\u0010\u0096((object) result) as \u001A.\u0001;
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        data.\u0002 += \u0088\u0080.\u007E\u001B\u0003\u0002((object) data.\u0001, result);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
      this.\u007F\u0005(data);
    }

    private static bool \u001D\u0005(string receivedData, out string requestedFile)
    {
      requestedFile = (string) null;
      if (\u008F\u0084.\u009E\u0092(receivedData))
        return false;
      string[] strArray1 = \u0093\u0082.\u007E\u0003\u0093((object) receivedData, new char[2]{ '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
      if (strArray1.Length == 0)
        return false;
      for (int index = 0; index < strArray1.Length; ++index)
      {
        string[] strArray2 = \u0093\u0082.\u007E\u0003\u0093((object) strArray1[index], new char[1]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (index == 0)
        {
          string str;
          if ((str = strArray2[index]) == null || !\u0008\u001F.\u009A\u0092(str, \u001A.\u0001(95206)) && !\u0008\u001F.\u009A\u0092(str, \u001A.\u0001(95211)) || (strArray2.Length != 3 || \u008F\u0084.\u009E\u0092(strArray2[1]) || (\u0008\u001F.\u009A\u0092(strArray2[1], \u001A.\u0001(79704)) || \u0008\u001F.\u009A\u0092(strArray2[1], \u001A.\u0001(59219)))))
            return false;
          requestedFile = strArray2[1];
          return true;
        }
      }
      return false;
    }

    private bool \u001D\u0005(\u001A.\u0001 data, string requestedFile, out string response)
    {
      response = (string) null;
      Uri uri = new Uri(new Uri(\u0081\u0086.\u0086\u0093(\u001A.\u0001(95220), \u0002\u007F.\u007E\u0087\u0091((object) \u009E\u0083.\u007E\u0004\u0003\u0002((object) (IPEndPoint) \u001C\u001F.\u007E\u0013\u0003\u0002((object) data.\u0001))))), requestedFile);
      string str1 = \u009C\u0080.\u0008\u009F(\u0002\u007F.\u007E\u0086\u0002\u0002((object) uri));
      if (\u0008\u001F.\u009B\u0092(str1, \u001A.\u0003))
        return false;
      StringBuilder stringBuilder1 = new StringBuilder();
      StringBuilder stringBuilder2 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u001A.\u0001(95233));
      StringBuilder stringBuilder3 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001A.\u0001(95258), (object) \u001D\u0082.\u0012\u0094()));
      StringBuilder stringBuilder4 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001A.\u0001(95279), (object) \u001D\u0082.\u0012\u0094()));
      StringBuilder stringBuilder5 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u001A.\u0001(95312));
      StringBuilder stringBuilder6 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u001A.\u0001(95345));
      StringBuilder stringBuilder7 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u001A.\u0001(95374));
      string str2 = this.\u0001.\u001D\u0005(this.PANDA_DOWNLOAD_URL);
      StringBuilder stringBuilder8 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001A.\u0001(95439), (object) \u0005\u0081.\u007E\u0001\u0093((object) str2)));
      StringBuilder stringBuilder9 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u001A.\u0001(75700));
      StringBuilder stringBuilder10 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, str2);
      response = \u0002\u007F.\u007E\u0087\u0091((object) stringBuilder1);
      return true;
    }

    private static bool \u001D\u0005(IPAddress ipAddress)
    {
      // ISSUE: unable to decompile the method.
    }

    private sealed class \u0001 : \u0016
    {
      public static readonly int \u0001 = 2048;
      public byte[] \u0001 = new byte[\u001A.\u0001.\u0001];
      public DateTime \u0001 = DateTime.Now;
      public StringBuilder \u0001 = new StringBuilder();
      public Socket \u0001;
      public int \u0002;

      public \u0001(Socket clientSocket)
      {
        this.\u0001 = clientSocket;
      }

      protected override void \u001D\u0005()
      {
        if (this.\u0001 != null)
          \u001A\u001E.\u007E\u007F\u0003\u0002((object) this.\u0001);
        base.\u001D\u0005();
      }
    }
  }
}
