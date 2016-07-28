// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0015;
using \u0018;
using \u001A;
using \u001C;
using \u001D;
using \u001E;
using \u007F;
using \u0080;
using \u0081;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace \u0016
{
  internal class \u001A : \u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    protected \u0080.\u0018 \u0001;
    protected \u0083.\u0014 \u0001;
    protected readonly IntPtr \u0001;
    protected readonly ManualResetEventSlim \u0001;
    protected readonly \u0080.\u0014 \u0001;
    private bool \u0001;
    private IContainer \u0001;
    private System.Windows.Forms.Timer \u0001;
    private \u0012 \u0001;
    private Button \u0001;

    protected bool CanContinue
    {
      get
      {
        if (\u0099\u0082.\u007E\u009E\u0098((object) this.\u0001))
          return false;
        return this.\u0001.ToonTownProcess.ProcessOpen;
      }
    }

    public event EventHandler OnStartRunning;

    static \u001A()
    {
      \u0004.\u001D\u0005(typeof (\u0016.\u001A));
      \u0016.\u001A.\u0001 = \u0016.\u001A.\u0001(24748);
      \u0016.\u001A.\u0002 = \u0016.\u001A.\u0001(24777);
      \u0016.\u001A.\u0003 = \u0016.\u001A.\u0001(24963);
      \u0016.\u001A.\u0004 = \u0016.\u001A.\u0001(25000);
      \u0016.\u001A.\u0005 = \u0016.\u001A.\u0001(25073);
      \u0016.\u001A.\u0006 = \u0016.\u001A.\u0001(25098);
    }

    private \u001A()
    {
      this.\u0081\u0005();
      // ISSUE: method pointer
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler((object) this, __methodptr(\u001E\u0005)));
    }

    public \u001A(IntPtr hWnd)
      : this()
    {
      \u0013.\u001D\u0005(\u0016.\u001A.\u0001, new object[1]{ (object) hWnd });
      this.\u0001 = new ManualResetEventSlim(false);
      this.\u0001 = hWnd;
      this.\u0001.\u001D\u0005(Keys.Escape, Keys.None, false);
      Size size = new Size(1024, 768);
      this.\u0001 = \u0080.\u0014.\u001D\u0005(new Point(50, 720), new Point(size.Width, size.Height));
    }

    protected void \u001D\u0005(DialogResult result = DialogResult.None)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001E\u0005(new MethodInvoker((object) new \u0016.\u001A.\u0001()
      {
        \u0001 = result,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    protected void \u001D\u0005(MethodInvoker del)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001E\u0005(new MethodInvoker((object) new \u0016.\u001A.\u0002()
      {
        \u0001 = del,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    protected T \u001D\u0005<T>(Func<T> del)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      return \u001F.\u001A.\u001D\u0005<T>(this, new Func<T>((object) new \u0016.\u001A.\u0003<T>() { \u0001 = (\u0016.\u001A) del, \u0001 = this }, __methodptr(\u001D\u0005)));
    }

    protected bool \u001D\u0005(int milliseconds)
    {
      int num = \u0095\u0081.\u007E\u0006\u0099((object) this.\u0001, milliseconds) ? 1 : 0;
      return !\u0099\u0082.\u007E\u009E\u0098((object) this.\u0001);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
    }

    private void \u001D\u0005(object sender, \u0018.\u0014 e)
    {
      this.\u001E\u0005();
    }

    protected override void \u001D\u0005(\u0018.\u0015 e)
    {
      e.Cancel = true;
      e.CancelReason = \u0016.\u001A.\u0006;
      this.\u001E\u0005();
      base.\u001D\u0005(e);
    }

    private void \u001E\u0005(object sender, FormClosingEventArgs e)
    {
      if (\u009A\u001E.\u007E\u009D\u008B((object) e) == CloseReason.WindowsShutDown || this.\u0001)
        return;
      \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
      this.\u001E\u0005();
    }

    private void \u001E\u0005()
    {
      // ISSUE: method pointer
      \u001F.\u001A.\u001D\u0005(this, new MethodInvoker((object) this, __methodptr(\u0082\u0005)));
    }

    protected void \u001F\u0005()
    {
      \u0013.\u001D\u0005((object) this, this.\u0001);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (\u0099\u0082.\u0081\u0001\u0002((object) this))
        return;
      if (!\u0080.\u0018.\u001D\u0005(this.\u0001, out this.\u0001))
      {
        this.\u0001 = \u0080.\u0018.\u001D\u0005(this.\u0001, \u0080.\u0001.\u0001, (string) null);
        if (!this.\u0001.\u0080\u0005())
        {
          \u001A\u001E.\u0001\u0086((object) this);
          \u0017.\u001E\u0005(\u0016.\u001A.\u0002, \u0016.\u001A.\u0003);
          this.\u0001 = true;
          \u0089\u001C.\u0015\u008B((object) this, DialogResult.Abort);
          \u001A\u001E.\u0092\u008B((object) this);
          return;
        }
      }
      if (this.\u0001.Playground == \u0019.\u0001)
      {
        \u001A\u001E.\u0001\u0086((object) this);
        \u0017.\u001D\u0005(\u0016.\u001A.\u0004, \u0016.\u001A.\u0005);
        this.\u0001 = true;
        \u0089\u001C.\u0015\u008B((object) this, DialogResult.Abort);
        \u001A\u001E.\u0092\u008B((object) this);
      }
      else
      {
        this.\u0001 = new \u0083.\u0014(this.\u0001);
        this.\u007F\u0005();
        \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
        if (this.\u0001 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
      }
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      if (\u0099\u0082.\u0081\u0001\u0002((object) this))
        return;
      this.\u007F\u0005();
    }

    private void \u007F\u0005()
    {
      if (!this.\u0001.ToonTownProcess.ProcessOpen)
        return;
      Point point;
      try
      {
        Rectangle rec = \u0013.\u001E\u0005(this.\u0001);
        point = new Point(rec.\u001D\u0005() - \u0005\u0081.\u0083\u0084((object) this) / 2, rec.Bottom - \u0005\u0081.\u0098\u0083((object) this));
      }
      catch (Win32Exception ex)
      {
        return;
      }
      if (!\u001D\u0081.\u007F\u0080(\u008E\u0084.\u0017\u008B((object) this), point))
        return;
      \u0096\u0086.\u0018\u008B((object) this, point);
    }

    protected void \u0080\u0005()
    {
      if (!this.\u001D\u0005(250))
        return;
      this.\u001D\u0005(this.\u0001);
      this.\u001D\u0005(250);
    }

    protected void \u001D\u0005(\u0080.\u0014 pnt)
    {
      Rectangle window_bounds = \u0013.\u001E\u0005(this.\u0001);
      this.\u001D\u0005(window_bounds, pnt.\u001D\u0005(new Point(window_bounds.Width, window_bounds.Height)));
    }

    protected void \u001D\u0005(\u0013 bounds)
    {
      this.\u001D\u0005(\u0013.\u001E\u0005(this.\u0001), bounds);
    }

    protected void \u001D\u0005(Rectangle window_bounds, \u0013 bounds)
    {
      this.\u001D\u0005(window_bounds, bounds.\u001D\u0005(window_bounds.Size).\u001D\u0005());
    }

    protected void \u001D\u0005(Rectangle window_bounds, Point p)
    {
      \u000E.\u001D\u0005(window_bounds, p);
    }

    protected void \u001D\u0005(Point p)
    {
      this.\u001D\u0005(\u0013.\u001E\u0005(this.\u0001), p);
    }

    protected void \u001D\u0005(Rectangle window_bounds, Rectangle bounds)
    {
      this.\u001D\u0005(window_bounds, bounds.\u001D\u0005());
    }

    protected void \u001D\u0005(Point p, \u0005 settings)
    {
      this.\u001F\u0005();
      this.\u001D\u0005(p);
      int num = \u0095\u0081.\u007E\u0006\u0099((object) this.\u0001, settings.AfterMoveBeforeClickDelay) ? 1 : 0;
      this.\u001D\u0005(settings);
    }

    protected void \u001D\u0005(\u0013 bounds, \u0005 settings)
    {
      this.\u001F\u0005();
      this.\u001D\u0005(bounds);
      int num = \u0095\u0081.\u007E\u0006\u0099((object) this.\u0001, settings.AfterMoveBeforeClickDelay) ? 1 : 0;
      this.\u001D\u0005(settings);
    }

    protected void \u001D\u0005(\u0005 settings)
    {
      \u000E.\u001D\u0005(MouseButtons.Left, settings.ButtonClickDelay, this.\u0001);
    }

    protected \u001B \u001D\u0005(int interval, int timeout, \u0083.\u0018 original_capture, \u0013 bounds, \u0005 settings)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0016.\u001A.\u0004 obj1 = new \u0016.\u001A.\u0004();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = timeout;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0016.\u001A.\u0005 obj2 = new \u0016.\u001A.\u0005();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new ManualResetEventSlim(false);
      try
      {
        // ISSUE: reference to a compiler-generated method
        Task task = new Task(new Action(obj2.\u001D\u0005));
        try
        {
          try
          {
            \u001A\u001E.\u007E\u0017\u0099((object) task);
            // ISSUE: reference to a compiler-generated field
            return this.\u001D\u0005(interval, original_capture, bounds, settings, obj2.\u0001);
          }
          finally
          {
            // ISSUE: reference to a compiler-generated field
            \u001A\u001E.\u007E\u0002\u0099((object) obj2.\u0001);
            \u001A\u001E.\u007E\u001B\u0099((object) task);
          }
        }
        finally
        {
          if (task != null)
            \u001A\u001E.\u007E\u0094\u0092((object) task);
        }
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj2.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj2.\u0001);
        }
      }
    }

    protected \u001B \u001D\u0005(int interval, \u0083.\u0018 original_capture, \u0013 bounds, \u0005 settings, ManualResetEventSlim waitHandle = null)
    {
      while (!\u0099\u0082.\u007E\u009E\u0098((object) this.\u0001) && (waitHandle == null || !\u0099\u0082.\u007E\u009E\u0098((object) waitHandle)))
      {
        this.\u001F\u0005();
        switch (\u0004.\u001D\u0005(this.\u0001.ToonTownProcess, original_capture, bounds, settings))
        {
          case \u001B.\u0001:
            return \u001B.\u0001;
          case \u001B.\u0002:
            if (waitHandle == null)
            {
              int num = \u0095\u0081.\u007E\u0006\u0099((object) this.\u0001, interval) ? 1 : 0;
              continue;
            }
            WaitHandle[] waitHandleArray = new WaitHandle[2]{ \u001B\u001F.\u007E\u009D\u0098((object) this.\u0001), \u001B\u001F.\u007E\u009D\u0098((object) waitHandle) };
            int num1 = \u0008\u001E.\u001C\u0098(waitHandleArray, interval);
            continue;
          case \u001B.\u0003:
            return \u001B.\u0003;
          default:
            continue;
        }
      }
      return \u001B.\u0002;
    }

    protected unsafe bool \u001D\u0005(ManualResetEventSlim waitHandle = null)
    {
      int num1 = 0;
      do
      {
        Size size = new Size(20, 20);
        Bitmap source = \u0012.\u001D\u0005(this.\u0001, new Rectangle(Point.Empty, size));
        try
        {
          \u0082 owner = new \u0082(source, false);
          try
          {
            \u0082.\u0002 obj = new \u0082.\u0002(owner);
            try
            {
              \u001D.\u0015* pBase = owner.pBase;
              \u001D.\u0015 right = new \u001D.\u0015((byte) 0, (byte) 0, (byte) 0, byte.MaxValue);
              for (int index1 = 0; index1 < \u0083\u001E.\u0081\u008B((object) this).Height; ++index1)
              {
                for (int index2 = 0; index2 < \u0083\u001E.\u0081\u008B((object) this).Width; ++index2)
                {
                  if (\u001D.\u0015.\u001E\u0005(*pBase, right))
                    return true;
                  ++pBase;
                }
              }
            }
            finally
            {
              if (obj != null)
                \u001A\u001E.\u007E\u0094\u0092((object) obj);
            }
          }
          finally
          {
            if (owner != null)
              \u001A\u001E.\u007E\u0094\u0092((object) owner);
          }
        }
        finally
        {
          if (source != null)
            \u001A\u001E.\u007E\u0094\u0092((object) source);
        }
        if (waitHandle != null)
        {
          int num2 = \u0095\u0081.\u007E\u0006\u0099((object) waitHandle, 100) ? 1 : 0;
        }
        else
          \u001E\u001E.\u008F\u0098(100);
        ++num1;
      }
      while (num1 < 100 && (waitHandle == null || !\u0099\u0082.\u007E\u009E\u0098((object) waitHandle)));
      return false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u0007\u0099((object) this.\u0001);
      if (this.\u0001 != null)
        goto label_6;
label_3:
      base.Dispose(disposing);
      return;
label_6:
      this.\u0001.Dispose();
      goto label_3;
    }

    private void \u0081\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new System.Windows.Forms.Timer(this.\u0001);
      this.\u0001 = new \u0012(this.\u0001);
      this.\u0001 = new Button();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 1000);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      this.\u0001.HotkeyActivated += new EventHandler<\u0018.\u0014>(this.\u001D\u0005);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0001, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(203, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u001A.\u0001(24676));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0016.\u001A.\u0001(24693));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(286, 40));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0099\u001F.\u001E\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0016.\u001A.\u0001(24702));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0016.\u001A.\u0001(24719));
      \u0099\u001F.\u0086\u008B((object) this, true);
      \u0087\u007F.\u008E\u008B((object) this, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
