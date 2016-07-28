// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001B;
using \u001C;
using \u0084;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace \u0084
{
  internal sealed class \u0015 : Component
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private Dictionary<System.Type, Form> \u0001;

    static \u0015()
    {
      \u0004.\u001D\u0005(typeof (\u0015));
    }

    public \u0015()
    {
      this.\u0001 = new Dictionary<System.Type, Form>();
    }

    public \u0015(IContainer container)
      : this()
    {
      if (container == null)
        throw new ArgumentNullException(\u0015.\u0001(66553));
      \u0007\u0083.\u007E\u008B\u0001\u0002((object) container, (IComponent) this);
    }

    protected override void Dispose(bool disposing)
    {
      // ISSUE: unable to decompile the method.
    }

    public bool \u001D\u0005<T>() where T : Form
    {
      // ISSUE: type reference
      return this.\u0001.ContainsKey(\u009C\u0082.\u0016\u0097(__typeref (T)));
    }

    public T \u001D\u0005<T>() where T : Form
    {
      // ISSUE: type reference
      System.Type key = \u009C\u0082.\u0016\u0097(__typeref (T));
      if (!this.\u0001.ContainsKey(key))
        throw new KeyNotFoundException(\u009E\u0081.\u001F\u0093(\u0015.\u0001(106292), (object) key));
      return (T) this.\u0001[key];
    }

    public T \u001D\u0005<T>(params object[] args) where T : Form
    {
      bool created;
      return this.\u001D\u0005<T>(out created, args);
    }

    public T \u001D\u0005<T>(out bool created, params object[] args) where T : Form
    {
      if (!this.\u001D\u0005<T>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0015.\u0001<T> obj = new \u0015.\u0001<T>();
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = (System.Type) this;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: type reference
        obj.\u0001 = \u009C\u0082.\u0016\u0097(__typeref (T));
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = (System.Type) (T) \u0003\u001C.\u0083\u0094(obj.\u0001, args);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        \u0096\u001C.\u007E\u008D\u008B((object) (T) obj.\u0001, new FormClosedEventHandler(obj.\u001D\u0005));
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.\u0001.Add(obj.\u0001, (Form) obj.\u0001);
        // ISSUE: reference to a compiler-generated field
        obj.\u0001.Show();
        created = true;
        // ISSUE: reference to a compiler-generated field
        return (T) obj.\u0001;
      }
      T obj1 = this.\u001D\u0005<T>();
      if (obj1.Visible)
      {
        if (obj1.WindowState == FormWindowState.Minimized)
        {
          \u0007 placement = new \u0007();
          // ISSUE: type reference
          placement.\u0001 = (uint) \u0082\u001D.\u0005\u009D(\u009C\u0082.\u0016\u0097(__typeref (\u0007)));
          \u000E.\u001D\u0005(new HandleRef((object) obj1, obj1.Handle), ref placement);
          obj1.WindowState = !\u0095\u001C.\u0099\u0091((object) placement.\u0001, (Enum) \u0013.\u0002) ? FormWindowState.Normal : FormWindowState.Maximized;
        }
        obj1.BringToFront();
        obj1.Activate();
      }
      created = false;
      return obj1;
    }
  }
}
