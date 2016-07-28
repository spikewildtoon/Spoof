// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0017;
using \u001A;
using \u001E;
using \u001F;
using \u007F;
using \u0080;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace \u0015
{
  internal sealed class \u000E : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Timer \u0001;
    private static HashSet<int> \u0001;
    private FormWindowState \u0001;
    private bool \u0001;
    private bool \u0002;

    public event EventHandler OnResizeStarted;

    public event EventHandler OnResizeEnded;

    public event EventHandler WindowStateChanged;

    public event EventHandler OnCloseClicked;

    static \u000E()
    {
      \u0004.\u001D\u0005(typeof (\u000E));
      \u000E.\u0001 = new HashSet<int>();
    }

    public \u000E()
    {
      this.\u001D\u0005();
      this.\u0001 = FormWindowState.Normal;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new Timer(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 1000);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u009A\u0080.\u0090\u001F());
      \u000E\u001F.\u0010\u008B((object) this, new Size(518, 353));
      \u0092\u0081.\u0010\u0084((object) this, \u000E.\u0001(14540));
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u000E.\u0001(14565));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    public static bool \u001D\u0005(\u001C process)
    {
      // ISSUE: unable to decompile the method.
    }

    public static bool \u001D\u0005(\u001C process, Form owner)
    {
      if (\u000E.\u001D\u0005(process))
        return true;
      return process.\u001D\u0005(owner, (EventHandler<\u0080.\u0017>) null);
    }

    public static \u000E \u001D\u0005(Form parent)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u000E.\u0001 obj1 = new \u000E.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = parent;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = new \u001C();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (\u000E.\u001D\u0005(obj1.\u0001, obj1.\u0001))
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u000E.\u0002 obj2 = new \u000E.\u0002();
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = obj1;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = obj1.\u0001.MainWindowHandle;
        // ISSUE: reference to a compiler-generated field
        \u0014 obj3 = (\u0014) \u000E.\u001D\u0005(obj2.\u0001, \u0012.\u0004);
        if (!\u0095\u001C.\u0099\u0091((object) obj3, (Enum) \u0014.\u0019) || !\u0095\u001C.\u0099\u0091((object) obj3, (Enum) \u0014.\u0014) || !\u0095\u001C.\u0099\u0091((object) obj3, (Enum) \u0014.\u000F))
        {
          \u0018.\u0017.\u001D\u0005(\u000E.\u0001(14675), \u000E.\u0001(14837));
        }
        else
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          \u000E.\u0003 obj4 = new \u000E.\u0003();
          // ISSUE: reference to a compiler-generated field
          obj4.\u0001 = obj2;
          // ISSUE: reference to a compiler-generated field
          obj4.\u0001 = obj1;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          obj4.\u0001 = \u0005\u0081.\u007E\u009F\u0003\u0002((object) obj1.\u0001.Process);
          // ISSUE: reference to a compiler-generated field
          \u000E.\u0001.Add(obj4.\u0001);
          Rectangle normalRect;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          FormWindowState state = \u0013.\u001D\u0005(new HandleRef((object) obj1.\u0001, obj2.\u0001), out normalRect);
          \u0014 obj5 = (obj3 & ~\u0014.\u0019 & ~\u0014.\u0014 | \u0014.\u0003) & ~\u0014.\u0002 & ~\u0014.\u000F;
          // ISSUE: reference to a compiler-generated field
          \u000E.\u001D\u0005(obj2.\u0001, \u0012.\u0004, (int) obj5);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          IntPtr num = \u000E.\u001E\u0005(new HandleRef((object) obj1.\u0001, obj2.\u0001), \u0012.\u0006);
          Icon icon = \u001A\u0084.\u000F\u0080(num);
          // ISSUE: reference to a compiler-generated field
          obj4.\u0001 = new \u000E();
          // ISSUE: reference to a compiler-generated field
          \u0080\u0086.\u007E\u0016\u008B((object) obj4.\u0001, icon);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0001 = new Func<bool>(obj2.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0002 = new Func<bool>(obj4.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0001 = new Action(obj4.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0001 = new Action<Action>(obj4.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0002 = new Action(obj4.\u001E\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0003 = new Action(obj4.\u001F\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0004 = new Action(obj4.\u007F\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0005 = new Action(obj4.\u0080\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0006 = new Action(obj4.\u0081\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0007 = new Action(obj4.\u0082\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0001 = new Action<IntPtr?, Rectangle>(obj4.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0002 = new Action<IntPtr?, Rectangle>(obj4.\u001E\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0001.OnResizeStarted += new EventHandler(obj4.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0001.OnResizeEnded += new EventHandler(obj4.\u001E\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          \u0087\u007F.\u007E\u008C\u0084((object) obj4.\u0001, new EventHandler(obj4.\u001F\u0005));
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0001.WindowStateChanged += new EventHandler(obj4.\u007F\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj1.\u0001.ProcessExited += new EventHandler(obj4.\u0080\u0005);
          if (\u0095\u001C.\u0099\u0091((object) state, (Enum) FormWindowState.Maximized))
          {
            if (\u0095\u001C.\u0099\u0091((object) state, (Enum) FormWindowState.Minimized))
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              \u0013.\u001D\u0005(new HandleRef((object) obj1.\u0001, obj2.\u0001), FormWindowState.Minimized, new Rectangle?());
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              \u0013.\u001D\u0005(new HandleRef((object) obj1.\u0001, obj2.\u0001), FormWindowState.Normal, new Rectangle?());
            }
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          obj4.\u0001 = \u000E.\u001F\u0005(obj2.\u0001, \u0088\u0086.\u007E\u0097\u0083((object) obj4.\u0001));
          // ISSUE: reference to a compiler-generated field
          \u009C\u001C.\u007E\u0084\u008B((object) obj4.\u0001, FormStartPosition.Manual);
          // ISSUE: reference to a compiler-generated field
          \u000E\u0080.\u007E\u0081\u0083((object) obj4.\u0001, normalRect);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          obj4.\u0002(new IntPtr?(\u0088\u0086.\u007E\u0097\u0083((object) obj4.\u0001)), \u008D\u0084.\u007E\u0082\u0083((object) obj4.\u0001));
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          \u0013.\u001D\u0005(new HandleRef((object) obj1.\u0001, \u0088\u0086.\u007E\u0097\u0083((object) obj4.\u0001)), state, new Rectangle?());
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          \u0098\u001C.\u007E\u008B\u008B((object) obj4.\u0001, new FormClosingEventHandler(obj4.\u001D\u0005));
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj4.\u0001.OnCloseClicked += new EventHandler(obj4.\u0081\u0005);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          \u0087\u007F.\u007E\u009D\u008F((object) obj4.\u0001.\u0001, new EventHandler(obj4.\u0082\u0005));
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          \u0087\u007F.\u007E\u008F\u008B((object) obj4.\u0001, new EventHandler(obj4.\u0083\u0005));
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0083\u0086((object) obj4.\u0001);
          // ISSUE: reference to a compiler-generated field
          return obj4.\u0001;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001.Dispose();
      }
      return (\u000E) null;
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      if (\u0098\u001E.\u0087\u008B((object) this) != this.\u0001)
        goto label_3;
label_2:
      \u0088\u001C.\u0018\u0086((object) this, e);
      return;
label_3:
      this.\u0001 = \u0098\u001E.\u0087\u008B((object) this);
      if (this.\u0003 != null)
      {
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0003, (object) this, EventArgs.Empty);
        goto label_2;
      }
      else
        goto label_2;
    }

    protected override void WndProc(ref Message m)
    {
      \u001B obj = (\u001B) m.Msg;
      if (obj > \u001B.\u0093\u0002)
        goto label_12;
      else
        goto label_10;
label_9:
      \u0015\u0084.\u009B\u008B((object) this, ref m);
      return;
label_10:
      switch (obj - 6)
      {
        case \u001B.\u0001:
          if (\u0012\u0081.\u0084\u0096(m.WParam) == 0)
          {
            \u0088\u001C.\u007E\u0011\u0086((object) this, EventArgs.Empty);
            goto label_9;
          }
          else
            goto label_9;
        case \u001B.\u0002:
          goto label_9;
        case \u001B.\u0003:
          if (this.\u0002)
            return;
          goto label_9;
        default:
          if (obj == \u001B.\u0093\u0002 && (\u0012\u0081.\u0084\u0096(m.WParam) == 61536 && this.\u0004 != null))
          {
            \u0095\u001E.\u007E\u009E\u0095((object) this.\u0004, (object) this, EventArgs.Empty);
            return;
          }
          goto label_9;
      }
label_12:
      if (obj == \u001B.\u001D\u0003)
      {
        if (this.\u0001 != null)
        {
          \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
          this.\u0001 = true;
          goto label_9;
        }
        else
          goto label_9;
      }
      else if (obj == \u001B.\u008D\u0003 && (this.\u0001 && this.\u0002 != null))
      {
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
        goto label_9;
      }
      else
        goto label_9;
    }
  }
}
