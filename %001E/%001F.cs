// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Collections.Generic;
using System.Threading;

namespace \u001E
{
  internal sealed class \u001F
  {
    private List<KeyValuePair<Action<object>, object>> \u0001;
    private volatile bool \u0001;
    private readonly object \u0001;

    public event EventHandler Started;

    public event EventHandler Stopped;

    public \u001F()
    {
      this.\u0001 = new object();
      this.\u0001 = new List<KeyValuePair<Action<object>, object>>();
      this.\u0001 = false;
    }

    private void \u001D\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u001E\u0005()
    {
      if (this.\u0002 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
    }

    public void \u001D\u0005(Action<object> action)
    {
      this.\u001D\u0005(action, (object) null);
    }

    public void \u001D\u0005(Action<object> action, object state)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        this.\u0001.Add(new KeyValuePair<Action<object>, object>(action, state));
        if (this.\u0001)
          return;
        this.\u0001 = true;
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
      this.\u001D\u0005();
      int num = \u001E\u0086.\u0099\u0098(new WaitCallback(this.\u001D\u0005)) ? 1 : 0;
    }

    public void \u001E\u0005(Action<object> action)
    {
      this.\u001E\u0005(action, (object) null);
    }

    public void \u001E\u0005(Action<object> action, object state)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        this.\u0001.Insert(0, new KeyValuePair<Action<object>, object>(action, state));
        if (this.\u0001)
          return;
        this.\u0001 = true;
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
      this.\u001D\u0005();
      int num = \u001E\u0086.\u0099\u0098(new WaitCallback(this.\u001D\u0005)) ? 1 : 0;
    }

    private void \u001D\u0005(object state)
    {
      bool flag1;
      try
      {
        bool flag2 = false;
        object obj;
        KeyValuePair<Action<object>, object> keyValuePair;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag2);
          keyValuePair = this.\u0001[0];
          this.\u0001.RemoveAt(0);
        }
        finally
        {
          if (flag2)
            \u001A\u001E.\u0082\u0098(obj);
        }
        keyValuePair.Key(keyValuePair.Value);
      }
      finally
      {
        bool flag2 = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag2);
          if (this.\u0001.Count == 0)
          {
            this.\u0001 = false;
            this.\u001E\u0005();
            flag1 = false;
          }
          else
            flag1 = true;
        }
        finally
        {
          if (flag2)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
      if (!flag1)
        return;
      this.\u001D\u0005(state);
    }
  }
}
