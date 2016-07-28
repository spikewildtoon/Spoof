// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001F;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace \u001F
{
  internal static class \u001A
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u001A()
    {
      \u0004.\u001D\u0005(typeof (\u001A));
    }

    public static void \u001D\u0005(this ListView lv, ListViewItem lvi, bool up)
    {
      int num1 = \u009A\u0081.\u007E\u000E\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) lv), lvi);
      if (num1 == -1)
        throw new ArgumentException(\u001A.\u0001(74885), \u001A.\u0001(74918));
      int num2;
      if (up)
      {
        num2 = num1 - 1;
        if (num2 < 0)
          throw new ArgumentException(\u001A.\u0001(74923));
      }
      else
      {
        num2 = num1 + 1;
        if (num2 >= \u0005\u0081.\u007E\u0002\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) lv)))
          throw new ArgumentException(\u001A.\u0001(74972));
      }
      \u0095\u0086.\u007E\u0010\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) lv), lvi);
      ListViewItem listViewItem = \u000E\u0082.\u007E\u000F\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) lv), num2, lvi);
    }

    public static int \u001D\u0005(this ListView lv)
    {
      if (\u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) lv)) == 0)
        return -1;
      return \u0096\u0081.\u007E\u009B\u008C((object) \u0086\u001F.\u007E\u0090\u008C((object) lv), 0);
    }

    public static void \u001D\u0005(this Timer timer)
    {
      if (!\u0099\u0082.\u007E\u009E\u008F((object) timer))
        return;
      \u001A\u001E.\u007E\u0003\u0090((object) timer);
      \u001A\u001E.\u007E\u0002\u0090((object) timer);
    }

    public static void \u001D\u0005(this Control control, int minSize)
    {
      \u001A\u001E.\u007E\u0084\u0086((object) control);
      if (\u0005\u0081.\u007E\u0083\u0084((object) control) < minSize || \u0005\u0081.\u007E\u0098\u0083((object) control) < minSize)
        \u000E\u001F.\u007E\u0018\u0084((object) control, new Size(minSize, minSize));
      else if (\u0005\u0081.\u007E\u0083\u0084((object) control) < \u0005\u0081.\u007E\u0098\u0083((object) control))
        \u000E\u001F.\u007E\u0018\u0084((object) control, new Size(\u0005\u0081.\u007E\u0083\u0084((object) control), \u0005\u0081.\u007E\u0083\u0084((object) control)));
      else
        \u000E\u001F.\u007E\u0018\u0084((object) control, new Size(\u0005\u0081.\u007E\u0098\u0083((object) control), \u0005\u0081.\u007E\u0098\u0083((object) control)));
      \u001A\u001E.\u007E\u001F\u0086((object) control);
    }

    public static void \u001D\u0005(this Control sender, MethodInvoker del)
    {
      if (sender != null && \u0099\u0082.\u007E\u009B\u0083((object) sender))
      {
        IAsyncResult asyncResult = \u001C\u0084.\u007E\u009A\u0084((object) sender, (Delegate) del);
      }
      else
        \u001A\u001E.\u007E\u0001\u008E((object) del);
    }

    public static T \u001D\u0005<T>(this Control sender, Func<T> del)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u0001<T> obj = new \u001A.\u0001<T>();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = (T) del;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = default (T);
      if (sender != null && \u0099\u0082.\u007E\u009B\u0083((object) sender))
      {
        // ISSUE: reference to a compiler-generated method
        sender.Invoke((Delegate) new MethodInvoker(obj.\u001D\u0005));
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = ((Func<T>) obj.\u0001)();
      }
      // ISSUE: reference to a compiler-generated field
      return obj.\u0001;
    }

    public static void \u001E\u0005(this Control sender, MethodInvoker del)
    {
      if (sender != null && \u0099\u0082.\u007E\u009B\u0083((object) sender))
      {
        object obj = \u0012\u0084.\u007E\u0006\u0086((object) sender, (Delegate) del);
      }
      else
        \u001A\u001E.\u007E\u0001\u008E((object) del);
    }
  }
}
