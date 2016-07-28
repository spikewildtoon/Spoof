// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0018;
using \u001B;
using \u001C;
using \u001E;
using \u0081;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;

namespace \u001C
{
  internal sealed class \u0012 : Component
  {
    private readonly Dictionary<int, \u0012.\u0001> \u0001 = new Dictionary<int, \u0012.\u0001>();
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0084.\u0018 \u0001;
    private static readonly Dictionary<int, \u0012.\u0001> \u0002;
    private static readonly object \u0001;
    private static int \u0001;

    public static ReadOnlyCollection<\u0011> AllHotkeys
    {
      get
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = \u0012.\u0001, ref flag);
          return \u0012.\u0002.Values.Cast<\u0011>().ToList<\u0011>().AsReadOnly();
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
    }

    public event EventHandler<\u0014> HotkeyActivated;

    static \u0012()
    {
      \u0004.\u001D\u0005(typeof (\u0012));
      \u0012.\u0001 = 0;
      \u0012.\u0001 = new object();
      \u0012.\u0002 = new Dictionary<int, \u0012.\u0001>();
    }

    public \u0012()
    {
      this.\u001D\u0005();
      this.\u001E\u0005();
    }

    public \u0012(IContainer container)
    {
      \u0007\u0083.\u007E\u008B\u0001\u0002((object) container, (IComponent) this);
      this.\u001D\u0005();
      this.\u001E\u0005();
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
    }

    public static bool \u001D\u0005(\u0012 hotkey)
    {
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0012.\u0001, ref flag);
        foreach (\u0011 obj2 in \u0012.\u0002.Values)
        {
          if (\u0012.\u001D\u0005(obj2.Hotkey, hotkey))
            return true;
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
      return false;
    }

    public static bool \u001D\u0005(Keys key, Keys modifier)
    {
      return \u0012.\u001D\u0005(new \u0012(key, modifier));
    }

    private void \u001E\u0005()
    {
      this.\u0001 = new \u0084.\u0018();
      // ISSUE: method pointer
      this.\u0001.HotkeyPressed += new EventHandler<\u000F>((object) this, __methodptr(\u001D\u0005));
    }

    private void \u001D\u0005(object sender, \u000F e)
    {
      \u0012.\u0001 obj1 = (\u0012.\u0001) null;
      bool flag1 = false;
      object obj2;
      try
      {
        \u0098\u0082.\u0081\u0098(obj2 = \u0012.\u0001, ref flag1);
        obj1 = this.\u0001[e.HotkeyID];
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj2);
      }
      bool flag2 = ((\u0011) obj1).AllowRepeat || \u001D\u0082.\u0011\u0094().Subtract(obj1.LastTime).TotalMilliseconds > 1000.0;
      obj1.LastTime = \u001D\u0082.\u0011\u0094();
      if (!flag2)
        return;
      \u0014 e1 = new \u0014((\u0011) obj1);
      if (this.\u0001 != null)
        this.\u0001((object) this, e1);
      if (obj1.Callback == null)
        return;
      obj1.Callback((object) this, e1);
    }

    private bool \u001D\u0005(int id)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0012.\u0001, ref flag);
        return this.\u0001.ContainsKey(id);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    public bool \u001D\u0005(\u0012 hotkey, out \u0011 state)
    {
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0012.\u0001, ref flag);
        foreach (\u0012.\u0001 obj2 in this.\u0001.Values)
        {
          if (\u0012.\u001D\u0005(((\u0011) obj2).Hotkey, hotkey))
          {
            state = (\u0011) obj2;
            return true;
          }
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
      state = (\u0011) null;
      return false;
    }

    public \u0011 \u001D\u0005(Keys key, Keys modifier, bool allow_repeat)
    {
      return this.\u001D\u0005(key, modifier, allow_repeat, (object) null);
    }

    public \u0011 \u001D\u0005(Keys key, Keys modifier, bool allow_repeat, object state)
    {
      return this.\u001D\u0005(key, modifier, allow_repeat, state, (EventHandler<\u0014>) null);
    }

    public \u0011 \u001D\u0005(Keys key, Keys modifier, bool allow_repeat, EventHandler<\u0014> callback)
    {
      return this.\u001D\u0005(key, modifier, allow_repeat, (object) null, callback);
    }

    public \u0011 \u001D\u0005(Keys key, Keys modifier, bool allow_repeat, object state, EventHandler<\u0014> callback)
    {
      return this.\u001D\u0005(new \u0012(key, modifier), allow_repeat, state, callback);
    }

    public \u0011 \u001D\u0005(\u0012 hotkey, bool allow_repeat, object state, EventHandler<\u0014> callback)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0012.\u0001, ref flag);
        int num = \u0012.\u0001++;
        if (\u0012.\u0001 > 49151)
          \u0012.\u0001 = 0;
        \u0012.\u0001 hotkey1 = new \u0012.\u0001(this, num, hotkey, allow_repeat, state, callback);
        if (this.\u001D\u0005(hotkey1))
        {
          this.\u0001.Add(num, hotkey1);
          \u0012.\u0002.Add(num, hotkey1);
          return (\u0011) hotkey1;
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
      return (\u0011) null;
    }

    public bool \u001D\u0005(\u0011 state)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0012.\u0001, ref flag);
        \u0012.\u0001 hotkey = state as \u0012.\u0001;
        if (!this.\u0001.ContainsKey(hotkey.ID))
          throw new ArgumentException(\u0012.\u0001(59323));
        this.\u0001.Remove(hotkey.ID);
        \u0012.\u0002.Remove(hotkey.ID);
        return this.\u001E\u0005(hotkey);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    public bool \u001E\u0005(Keys key, Keys modifier)
    {
      \u0011 state;
      if (!this.\u001D\u0005(new \u0012(key, modifier), out state))
        return false;
      return this.\u001D\u0005(state);
    }

    public bool \u001E\u0005(\u0012 hotkey)
    {
      return this.\u001E\u0005(hotkey.Key, hotkey.Modifier);
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    private bool \u001D\u0005(\u0012.\u0001 hotkey)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0012.\u0001, ref flag);
        try
        {
          \u0012.\u001D\u0005(\u0088\u0086.\u007E\u0089\u0086((object) this.\u0001), hotkey.ID, ((\u0011) hotkey).Hotkey.NativeModifier, ((\u0011) hotkey).Hotkey.Key);
          return true;
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005((object) \u0081\u0086.\u0086\u0093(\u0012.\u0001(59396), \u0002\u007F.\u007E\u0087\u0091((object) hotkey)));
          return false;
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    private bool \u001E\u0005(\u0012.\u0001 hotkey)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0012.\u0001, ref flag);
        try
        {
          \u0012.\u001D\u0005(\u0088\u0086.\u007E\u0089\u0086((object) this.\u0001), hotkey.ID);
          return true;
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005((object) \u0081\u0086.\u0086\u0093(\u0012.\u0001(59437), \u0002\u007F.\u007E\u0087\u0091((object) hotkey)));
          return false;
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    protected override void Dispose(bool disposing)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0012.\u0001, ref flag);
        foreach (\u0012.\u0001 hotkey in this.\u0001.Values)
          this.\u001E\u0005(hotkey);
        \u0012.\u0002.\u001D\u0005<int, \u0012.\u0001>((IEnumerable<int>) this.\u0001.Keys);
        this.\u0001.Clear();
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
      if (disposing)
      {
        this.\u0001.Dispose();
        if (this.\u0001 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      }
      \u0099\u001F.\u0080\u0001\u0002((object) this, disposing);
    }

    private sealed class \u0001 : \u0011
    {
      public EventHandler<\u0014> Callback { get; private set; }

      public int ID { get; private set; }

      public DateTime LastTime { get; set; }

      public \u0001(\u0012 owner, int id, \u0012 hotkey, bool allow_repeat, object state, EventHandler<\u0014> callback)
        : base(owner, hotkey, allow_repeat, state)
      {
        this.ID = id;
        this.Callback = callback;
        this.LastTime = DateTime.MinValue;
      }

      public \u0001(\u0012 owner, int id, Keys key, Keys modifier, bool allow_repeat, object state, EventHandler<\u0014> callback)
        : this(owner, id, new \u0012(key, modifier), allow_repeat, state, callback)
      {
      }
    }
  }
}
