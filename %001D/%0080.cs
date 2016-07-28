// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001D;
using \u001F;
using \u007F;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace \u001D
{
  internal sealed class \u0080 : Component
  {
    private int \u0003 = 30;
    private int \u0004 = 10;
    private int \u0005 = 5000;
    private int \u0006 = 6000;
    private int \u0007 = 6;
    private int \u0008 = 2;
    [NonSerialized]
    internal static \u0002 \u0001;
    private Control \u0001;
    private System.Timers.Timer \u0001;
    private bool \u0001;
    private readonly object \u0001;
    private \u0080.\u0001 \u0001;
    private \u0081 \u0001;
    private int \u0001;
    private int \u0002;
    private bool \u0002;

    public int ExpandDistance
    {
      get
      {
        return this.\u0007;
      }
      set
      {
        \u0080.\u0002 obj = new \u0080.\u0002();
        obj.\u0001 = value;
        obj.\u0001 = this;
        if (obj.\u0001 <= 0)
          throw new ArgumentException(\u0080.\u0001(64541));
        if (this.\u0007 == obj.\u0001)
          return;
        this.\u001D\u0005(new MethodInvoker(obj.\u001D\u0005), (MethodInvoker) null);
      }
    }

    public int ContractDistance
    {
      get
      {
        return this.\u0008;
      }
      set
      {
        \u0080.\u0003 obj = new \u0080.\u0003();
        obj.\u0001 = value;
        obj.\u0001 = this;
        if (obj.\u0001 <= 0)
          throw new ArgumentException(\u0080.\u0001(64541));
        if (this.\u0008 == obj.\u0001)
          return;
        this.\u001D\u0005(new MethodInvoker(obj.\u001D\u0005), (MethodInvoker) null);
      }
    }

    public bool RunOnce
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        \u0080.\u0004 obj = new \u0080.\u0004();
        obj.\u0001 = value;
        obj.\u0001 = this;
        if (this.\u0002 == obj.\u0001)
          return;
        this.\u001D\u0005(new MethodInvoker(obj.\u001D\u0005), (MethodInvoker) null);
      }
    }

    public int ContractedDelay
    {
      get
      {
        return this.\u0005;
      }
      set
      {
        \u0080.\u0005 obj = new \u0080.\u0005();
        obj.\u0001 = value;
        obj.\u0001 = this;
        if (this.\u0005 == obj.\u0001)
          return;
        this.\u001D\u0005(new MethodInvoker(obj.\u001D\u0005), (MethodInvoker) null);
      }
    }

    public int ExpandedDelay
    {
      get
      {
        return this.\u0006;
      }
      set
      {
        \u0080.\u0006 obj = new \u0080.\u0006();
        obj.\u0001 = value;
        obj.\u0001 = this;
        if (this.\u0006 == obj.\u0001)
          return;
        this.\u001D\u0005(new MethodInvoker(obj.\u001D\u0005), (MethodInvoker) null);
      }
    }

    public bool Enabled
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (this.\u0001 == value)
          return;
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
          if (!\u0099\u0082.\u0081\u0001\u0002((object) this))
          {
            \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
            this.\u0001 = value;
            this.\u001D\u0005();
            if (this.\u0001 == null)
            {
              this.\u0001 = false;
              this.\u0001 = \u0080.\u0001.\u0001;
            }
            else
            {
              if (!this.\u0001)
                return;
              \u0002\u001D.\u007E\u0096\u0003\u0002((object) this.\u0001, (double) this.\u0005);
              \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, true);
            }
          }
          else
            this.\u0001 = value;
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
    }

    public \u0081 SlideDirection
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        \u0080.\u0007 obj = new \u0080.\u0007();
        obj.\u0001 = value;
        obj.\u0001 = this;
        if (this.\u0001 == obj.\u0001)
          return;
        this.\u001D\u0005(new MethodInvoker(obj.\u001D\u0005), (MethodInvoker) (() => this.\u001E\u0005()));
      }
    }

    public Control ControlToSlide
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        \u0080.\u0008 obj = new \u0080.\u0008();
        obj.\u0001 = value;
        obj.\u0001 = this;
        if (this.\u0001 == obj.\u0001)
          return;
        this.\u001D\u0005(new MethodInvoker(obj.\u001D\u0005), (MethodInvoker) (() => this.\u001E\u0005()));
      }
    }

    public int ContractRate
    {
      get
      {
        return this.\u0004;
      }
      set
      {
        \u0080.\u000E obj = new \u0080.\u000E();
        obj.\u0001 = value;
        obj.\u0001 = this;
        if (this.\u0004 == obj.\u0001)
          return;
        this.\u001D\u0005(new MethodInvoker(obj.\u001D\u0005), (MethodInvoker) null);
      }
    }

    public int ExpandRate
    {
      get
      {
        return this.\u0003;
      }
      set
      {
        \u0080.\u000F obj = new \u0080.\u000F();
        obj.\u0001 = value;
        obj.\u0001 = this;
        if (this.\u0003 == obj.\u0001)
          return;
        this.\u001D\u0005(new MethodInvoker(obj.\u001D\u0005), (MethodInvoker) null);
      }
    }

    public int EndPosition
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        \u0080.\u0010 obj = new \u0080.\u0010();
        obj.\u0001 = value;
        obj.\u0001 = this;
        if (this.\u0002 == obj.\u0001)
          return;
        this.\u001D\u0005(new MethodInvoker(obj.\u001D\u0005), (MethodInvoker) null);
      }
    }

    static \u0080()
    {
      \u0004.\u001D\u0005(typeof (\u0080));
    }

    public \u0080()
    {
      this.\u0001 = new System.Timers.Timer();
      // ISSUE: method pointer
      \u0010\u0081.\u007E\u0097\u0003\u0002((object) this.\u0001, new ElapsedEventHandler((object) this, __methodptr(\u001D\u0005)));
      this.\u0001 = new object();
    }

    public \u0080(IContainer container)
      : this()
    {
      if (container == null)
        throw new ArgumentNullException(\u0080.\u0001(64602));
      \u0007\u0083.\u007E\u008B\u0001\u0002((object) container, (IComponent) this);
    }

    private void \u001D\u0005(MethodInvoker del, MethodInvoker extraDel = null)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        if (\u0099\u0082.\u0081\u0001\u0002((object) this))
        {
          \u001A\u001E.\u007E\u0001\u008E((object) del);
        }
        else
        {
          bool enabled = this.Enabled;
          this.Enabled = false;
          this.\u001D\u0005();
          \u001A\u001E.\u007E\u0001\u008E((object) del);
          if (extraDel != null)
            \u001A\u001E.\u007E\u0001\u008E((object) extraDel);
          this.Enabled = enabled;
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
      if (this.\u0001 == null)
      {
        this.\u0001 = \u0080.\u0001.\u0001;
      }
      else
      {
        switch (this.\u0001)
        {
          case \u0080.\u0001.\u0002:
            if (!this.\u001D\u0005(this.\u0007))
            {
              \u0002\u001D.\u007E\u0096\u0003\u0002((object) this.\u0001, (double) this.\u0006);
              this.\u0001 = \u0080.\u0001.\u0003;
              break;
            }
            break;
          case \u0080.\u0001.\u0003:
            this.\u0001 = \u0080.\u0001.\u0004;
            \u0002\u001D.\u007E\u0096\u0003\u0002((object) this.\u0001, (double) this.\u0004);
            goto case \u0080.\u0001.\u0004;
          case \u0080.\u0001.\u0004:
            if (!this.\u001D\u0005(this.\u0008))
            {
              if (this.\u0002)
              {
                this.Enabled = false;
                return;
              }
              \u0002\u001D.\u007E\u0096\u0003\u0002((object) this.\u0001, (double) this.\u0005);
              this.\u0001 = \u0080.\u0001.\u0005;
              break;
            }
            break;
          case \u0080.\u0001.\u0005:
            this.\u0001 = \u0080.\u0001.\u0002;
            \u0002\u001D.\u007E\u0096\u0003\u0002((object) this.\u0001, (double) this.\u0003);
            goto case \u0080.\u0001.\u0002;
          default:
            \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
            break;
        }
        \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, true);
      }
    }

    private bool \u001D\u0005(int step)
    {
      switch (this.\u0001)
      {
        case \u0081.\u0001:
          if (this.\u0001 == \u0080.\u0001.\u0002)
            step = -step;
          return this.\u001D\u0005(\u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).X + step, this.\u0002, this.\u0001);
        case \u0081.\u0002:
          if (this.\u0001 == \u0080.\u0001.\u0004)
            step = -step;
          return this.\u001D\u0005(\u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).X + step, this.\u0001, this.\u0002);
        case \u0081.\u0003:
          if (this.\u0001 == \u0080.\u0001.\u0002)
            step = -step;
          return this.\u001D\u0005(\u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).Y + step, this.\u0002, this.\u0001);
        case \u0081.\u0004:
          if (this.\u0001 == \u0080.\u0001.\u0004)
            step = -step;
          return this.\u001D\u0005(\u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).Y + step, this.\u0001, this.\u0002);
        default:
          throw new InvalidOperationException(\u0080.\u0001(64615));
      }
    }

    private bool \u001D\u0005(int position, int minPos, int maxPos)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return this.\u0001.\u001D\u0005<bool>(new Func<bool>(new \u0080.\u0011() { \u0001 = position, \u0002 = minPos, \u0003 = maxPos, \u0001 = this }.\u001D\u0005));
    }

    protected override void Dispose(bool disposing)
    {
      this.Enabled = false;
      \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u0080\u0001\u0002((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      MethodInvoker methodInvoker = (MethodInvoker) null;
      if (this.\u0001 == null)
        return;
      switch (this.\u0001)
      {
        case \u0081.\u0001:
        case \u0081.\u0002:
          this.\u0001.\u001E\u0005((MethodInvoker) (() => \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(this.\u0001, \u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).Y))));
          break;
        case \u0081.\u0003:
        case \u0081.\u0004:
          Control sender = this.\u0001;
          if (methodInvoker == null)
            goto label_7;
label_2:
          MethodInvoker del = methodInvoker;
          sender.\u001E\u0005(del);
          break;
label_7:
          // ISSUE: method pointer
          methodInvoker = new MethodInvoker((object) this, __methodptr(\u0080\u0005));
          goto label_2;
      }
      this.\u0001 = \u0080.\u0001.\u0005;
    }

    private void \u001E\u0005()
    {
      if (this.\u0001 == null)
      {
        this.\u0001 = 0;
      }
      else
      {
        switch (this.\u0001)
        {
          case \u0081.\u0001:
          case \u0081.\u0002:
            this.\u0001 = \u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).X;
            break;
          case \u0081.\u0003:
          case \u0081.\u0004:
            this.\u0001 = \u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).Y;
            break;
        }
      }
    }

    private enum \u0001
    {
      \u0001,
      \u0002,
      \u0003,
      \u0004,
      \u0005,
    }
  }
}
