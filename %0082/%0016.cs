// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0017;
using \u001B;
using \u007F;
using \u0082;
using \u0083;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace \u0082
{
  internal sealed class \u0016 : \u0015.\u0016
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private \u0083.\u0017 \u0001;
    private MemoryStream \u0001;
    private \u0080.\u0001 \u0001;
    private string \u0001;
    private string \u0002;
    private \u0019 \u0001;
    private CancellationTokenSource \u0001;
    private Task \u0001;

    public \u0019 PatchData
    {
      get
      {
        return this.\u0001;
      }
    }

    public event EventHandler<\u0014> AuthenticationComplete;

    public event EventHandler<\u0004> AuthenticationFailed;

    static \u0016()
    {
      \u0004.\u001D\u0005(typeof (\u0082.\u0016));
    }

    public \u0016(\u0080.\u0001 type, string username, string password)
    {
      type.\u001D\u0005();
      if (\u008F\u0084.\u009E\u0092(username))
        throw new ArgumentNullException(\u0082.\u0016.\u0001(98842));
      if (\u008F\u0084.\u009E\u0092(password))
        throw new ArgumentNullException(\u0082.\u0016.\u0001(98855));
      this.\u0001 = new MemoryStream();
      this.\u0001 = type;
      this.\u0001 = username;
      this.\u0002 = password;
      this.\u0001 = new CancellationTokenSource();
    }

    private void \u001D\u0005(bool newFormat, Dictionary<string, string> result)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0014(newFormat, result));
    }

    private void \u001D\u0005(Exception ex)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0004(ex));
    }

    protected override void \u001D\u0005()
    {
      \u001A\u001E.\u007E\u0010\u0099((object) this.\u0001);
      this.\u0081\u0005();
      \u001A\u001E.\u007E\u0011\u0099((object) this.\u0001);
      \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
      base.\u001D\u0005();
    }

    private void \u0081\u0005()
    {
      try
      {
        if (this.\u0001 == null)
          return;
        \u001A\u001E.\u007E\u001B\u0099((object) this.\u0001);
      }
      catch (AggregateException ex)
      {
      }
      finally
      {
        if (this.\u0001 != null)
        {
          \u001A\u001E.\u007E\u001A\u0099((object) this.\u0001);
          this.\u0001 = (Task) null;
        }
      }
    }

    public void \u0082\u0005()
    {
      this.\u0083\u0005();
    }

    private void \u0083\u0005()
    {
      switch (this.\u0001)
      {
        case \u0080.\u0001.\u0002:
          this.\u0001 = new \u0083.\u0017(new Uri(\u0010.\u0001), (Stream) this.\u0001, false);
          break;
        case \u0080.\u0001.\u0003:
          this.\u0001 = new \u0083.\u0017(new Uri(\u0010.\u0002), (Stream) this.\u0001, false);
          break;
      }
      this.\u0001.RequiresInitialization = false;
      this.\u0001.DownloadComplete += (EventHandler) ((sender, e) =>
      {
        try
        {
          this.\u0001 = new \u0019();
          long num1 = \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, 0L, SeekOrigin.Begin);
          \u0010 obj = new \u0010((Stream) this.\u0001);
          try
          {
            StreamReader streamReader = new StreamReader((Stream) obj);
            try
            {
              this.\u0001.\u001E\u0005(\u0002\u007F.\u007E\u0012\u009F((object) streamReader));
            }
            finally
            {
              if (streamReader != null)
                \u001A\u001E.\u007E\u0094\u0092((object) streamReader);
            }
          }
          finally
          {
            if (obj != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj);
          }
          int num2 = \u001E\u001F.\u009A\u0098((WaitCallback) (_ => this.\u0084\u0005()), (object) null) ? 1 : 0;
        }
        catch (Exception ex)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          int num = \u001E\u001F.\u0098\u0098(new WaitCallback(new \u0082.\u0016.\u0001() { \u0001 = ex, \u0001 = this }.\u001D\u0005), (object) null) ? 1 : 0;
        }
      });
      this.\u0086\u0005();
    }

    private void \u0084\u0005()
    {
      this.\u0081\u0005();
      \u0012\u0080.\u007E\u008C\u009D((object) this.\u0001, 0L);
      if (!\u008F\u0084.\u009E\u0092(this.\u0001.Properties.WEB_PAGE_LOGIN_RPC))
        this.\u0001 = new \u0083.\u0017(new Uri(\u0014\u0084.\u007F\u0093(\u0081\u0086.\u0086\u0093(this.\u0001.Properties.WEB_PAGE_LOGIN_RPC, \u0082.\u0016.\u0001(98868)), (object) this.\u0001, (object) this.\u0002)), (Stream) this.\u0001, false);
      else
        goto label_5;
label_4:
      this.\u0001.RequiresInitialization = false;
      this.\u0001.DownloadComplete += (EventHandler) ((obj, args) =>
      {
        try
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          \u0082.\u0016.\u0002 obj1 = new \u0082.\u0016.\u0002();
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001 = this;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001 = \u0082.\u0016.\u001D\u0005(\u0099\u0084.\u007E\u0018\u009C((object) \u001D\u001F.\u0016\u009C(), \u0086\u0083.\u007E\u0003\u009F((object) this.\u0001)), out obj1.\u0001);
          // ISSUE: reference to a compiler-generated field
          if (obj1.\u0001 == null)
          {
            int num1 = \u001E\u001F.\u0098\u0098((WaitCallback) (_ => this.\u001D\u0005((Exception) new NullReferenceException(\u0082.\u0016.\u0001(98927)))), (object) null) ? 1 : 0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (obj1.\u0001 && obj1.\u0001.\u001D\u0005<string, string>(\u0082.\u0016.\u0001(41109), \u0082.\u0016.\u0001(98918)))
            {
              \u001E\u001E.\u008F\u0098(1000);
              int num2 = \u001E\u001F.\u009A\u0098((WaitCallback) (_ => this.\u0084\u0005()), (object) null) ? 1 : 0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated method
              int num3 = \u001E\u001F.\u0098\u0098(new WaitCallback(obj1.\u001D\u0005), (object) null) ? 1 : 0;
            }
          }
        }
        catch (Exception ex)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          int num = \u001E\u001F.\u0098\u0098(new WaitCallback(new \u0082.\u0016.\u0003() { \u0001 = ex, \u0001 = this }.\u001D\u0005), (object) null) ? 1 : 0;
        }
      });
      this.\u0086\u0005();
      return;
label_5:
      switch (this.\u0001)
      {
        case \u0080.\u0001.\u0002:
          this.\u0001 = new \u0083.\u0017(new Uri(\u0014\u0084.\u007F\u0093(\u0010.\u0003, (object) this.\u0001, (object) this.\u0002)), (Stream) this.\u0001, false);
          goto label_4;
        case \u0080.\u0001.\u0003:
          this.\u0001 = new \u0083.\u0017(new Uri(\u0014\u0084.\u007F\u0093(\u0010.\u0004, (object) this.\u0001, (object) this.\u0002)), (Stream) this.\u0001, false);
          goto label_4;
        default:
          goto label_4;
      }
    }

    private void \u0086\u0005()
    {
      // ISSUE: method pointer
      this.\u0001.DownloadError += new EventHandler<\u001C>((object) this, __methodptr(\u001D\u0005));
      this.\u0001 = new Task(new Action<object>(this.\u0001.\u001E\u0005), (object) \u0092\u001D.\u007E\u000E\u0099((object) this.\u0001));
      \u001A\u001E.\u007E\u0017\u0099((object) this.\u0001);
    }

    private static Dictionary<string, string> \u001D\u0005(string response, out bool newFormat)
    {
      newFormat = false;
      if (\u008F\u0084.\u009E\u0092(response))
        return (Dictionary<string, string>) null;
      bool startsWith;
      response = response.\u001D\u0005(\u0082.\u0016.\u0001(98885), out startsWith);
      newFormat = !startsWith;
      Dictionary<string, string> dictionary = new Dictionary<string, string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      string str1 = response;
      int num = 1;
      char[] chArray = new char[1]{ '\n' };
      foreach (string data in str1.\u001D\u0005((StringSplitOptions) num, chArray))
      {
        string key;
        string str2;
        if (data.\u001D\u0005('=', out key, out str2))
          dictionary.Add(key, str2);
      }
      return dictionary;
    }
  }
}
