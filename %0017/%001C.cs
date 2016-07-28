// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0017;
using \u0018;
using \u0019;
using \u001A;
using \u001B;
using \u001F;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace \u0017
{
  internal sealed class \u001C : \u0014.\u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    private static readonly string \u0007;
    private static readonly string \u0008;
    private static readonly string \u000E;
    private static readonly string \u000F;
    private static readonly string \u0010;
    private static readonly string \u0011;
    private static readonly string \u0012;
    private static readonly string \u0013;
    private static readonly string \u0014;
    private static readonly string \u0015;
    private static readonly string \u0016;
    private static readonly string \u0017;
    private static readonly string \u0018;
    private static readonly string \u0019;
    private \u0003 \u0001;
    private Dictionary<string, string> \u0001;
    private \u001D.\u0017 \u0001;
    private string \u001A;
    private \u0080.\u0018 \u0001;
    private \u001B.\u0019 \u0001;
    private long? \u0001;
    private long? \u0002;
    private long? \u0003;
    private DateTime? \u0001;
    private int \u0001;
    private int \u0002;
    private readonly object \u0001;
    private int \u0003;
    private IContainer \u0001;
    private ProgressBar \u0001;
    private Button \u0001;
    private Label \u0001;
    private \u001C \u0001;
    private Label \u0002;
    private Timer \u0001;
    private Timer \u0002;

    public \u0080.\u0001 ServerType { get; private set; }

    public \u0004 InstallerResult { get; private set; }

    static \u001C()
    {
      \u0004.\u001D\u0005(typeof (\u001C));
      \u001C.\u0001 = \u001C.\u0001(29647);
      \u001C.\u0002 = \u001C.\u0001(29708);
      \u001C.\u0003 = \u001C.\u0001(29733);
      \u001C.\u0004 = \u001C.\u0001(29887);
      \u001C.\u0005 = \u001C.\u0001(29936);
      \u001C.\u0006 = \u001C.\u0001(30082);
      \u001C.\u0007 = \u001C.\u0001(30111);
      \u001C.\u0008 = \u001C.\u0001(30136);
      \u001C.\u000E = \u001C.\u0001(30169);
      \u001C.\u000F = \u001C.\u0001(30194);
      \u001C.\u0010 = \u001C.\u0001(30223);
      \u001C.\u0011 = \u001C.\u0001(30252);
      \u001C.\u0012 = \u001C.\u0001(30273);
      \u001C.\u0013 = \u001C.\u0001(30290);
      \u001C.\u0014 = \u001C.\u0001(30323);
      \u001C.\u0015 = \u001C.\u0001(30376);
      \u001C.\u0016 = \u001C.\u0001(30421);
      \u001C.\u0017 = \u001C.\u0001(30454);
      \u001C.\u0018 = \u001C.\u0001(30495);
      \u001C.\u0019 = \u001C.\u0001(30524);
    }

    public \u001C(\u001B.\u0019 patchData, \u0080.\u0001 type, string username, Dictionary<string, string> variables)
    {
      this.\u0001 = new object();
      this.InstallerResult = \u0004.\u0001;
      this.\u0001 = patchData;
      this.\u001A = username;
      this.\u0001 = variables;
      this.ServerType = type;
      this.\u007F\u0005();
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler(this.\u001E\u0005));
    }

    private void \u001E\u0005(object sender, FormClosingEventArgs e)
    {
      if (\u009A\u001E.\u007E\u009D\u008B((object) e) == CloseReason.WindowsShutDown || this.InstallerResult != \u0004.\u0001)
        return;
      \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
      this.\u001E\u0005();
    }

    private void \u001E\u0005()
    {
      if (6 != (int) \u0018.\u0017.\u001E\u0005(\u001C.\u0001, \u001C.\u0002, \u0018.\u0016.\u0006, \u0018.\u0016.\u0007))
        return;
      this.\u0080\u0005(false);
    }

    protected override void \u001D\u0005(\u0015 e)
    {
      e.Cancel = true;
      e.CancelReason = \u001C.\u0014;
      this.\u0080\u0005(true);
      base.\u001D\u0005(e);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
    }

    private void \u0080\u0005(bool internalCancel)
    {
      this.\u0001.\u0080\u0005(internalCancel);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001C.\u0012);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      this.EnableCloseButton = false;
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u0001 = new \u0003(this.\u0001, this.ServerType, this.ServerType == \u0080.\u0001.\u0002 && \u0081.\u0080.Instance.ConnectSettings.SpoofedToonTownEnabled);
      this.\u0001.InstallerStateChanged += new EventHandler<\u001F.\u001F>(this.\u001D\u0005);
      this.\u0001.VersionMismatch += new EventHandler<\u0081.\u0019>(this.\u001D\u0005);
      this.\u0001.DownloadProgressChanged += new EventHandler<\u0006>(this.\u001D\u0005);
      this.\u0001.ResetCounters += new EventHandler(this.\u001F\u0005);
      this.\u0001.ProgressChanged += new EventHandler<\u0005>(this.\u001D\u0005);
      this.\u0001.\u0081\u0005();
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) this, __methodptr(\u0080\u0005)));
    }

    private void \u001F\u0005()
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        this.\u0003 = new long?();
        this.\u0002 = new long?();
        this.\u0001 = new long?();
        this.\u0001 = new DateTime?();
        this.\u0001 = -1;
        this.\u0002 = -1;
        \u0011\u001F.\u007E\u0089\u008E((object) this.\u0001, 0);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        switch (this.\u0001)
        {
          case \u001D.\u0017.\u0002:
          case \u001D.\u0017.\u0008:
            if (this.\u0003.HasValue)
            {
              string str1 = (string) null;
              string str2 = \u0008\u0082.\u0082\u0093((IFormatProvider) \u001B.\u0081.\u0001, \u001C.\u0001(29451), new object[1]{ (object) this.\u0003.Value });
              switch (this.\u0001)
              {
                case \u001D.\u0017.\u0002:
                  str1 = \u009E\u0081.\u001F\u0093(\u001C.\u0019, (object) str2);
                  break;
                case \u001D.\u0017.\u0008:
                  str1 = \u009E\u0081.\u001F\u0093(\u001C.\u0017, (object) str2);
                  break;
              }
              string str3;
              if (this.\u0001.HasValue && this.\u0001.HasValue && (this.\u0002.HasValue && this.\u0002.Value > this.\u0001.Value))
              {
                long num = (long) ((double) (this.\u0002.Value - this.\u0001.Value) / \u001B\u0082.\u001F\u0094(\u001D\u0082.\u0011\u0094(), this.\u0001.Value).TotalMilliseconds * 1000.0);
                str3 = \u0081\u0086.\u0086\u0093(str1, \u0008\u0082.\u0082\u0093((IFormatProvider) \u001B.\u0081.\u0001, \u001C.\u0001(29456), new object[1]{ (object) num }));
              }
              else
                str3 = \u0081\u0086.\u0086\u0093(str1, \u001C.\u0001(29469));
              \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, str3);
            }
            this.\u0001 = new DateTime?(\u001D\u0082.\u0011\u0094());
            this.\u0001 = this.\u0002;
            this.\u0002 = new long?();
            break;
          default:
            \u0099\u001F.\u007E\u009F\u008F((object) this.\u0002, false);
            break;
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u001D\u0005(object sender, \u0005 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001C.\u0001 obj1 = new \u001C.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = e;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      bool flag = false;
      object obj2;
      try
      {
        \u0098\u0082.\u0081\u0098(obj2 = this.\u0001, ref flag);
        // ISSUE: reference to a compiler-generated field
        if (this.\u0002 == obj1.\u0001.PercentComplete)
          return;
        // ISSUE: reference to a compiler-generated field
        this.\u0002 = obj1.\u0001.PercentComplete;
        // ISSUE: reference to a compiler-generated method
        this.\u001D\u0005(new MethodInvoker(obj1.\u001D\u0005));
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj2);
      }
    }

    private void \u001D\u0005(object sender, \u0006 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001C.\u0002 obj1 = new \u001C.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = e;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      bool flag = false;
      object obj2;
      try
      {
        \u0098\u0082.\u0081\u0098(obj2 = this.\u0001, ref flag);
        // ISSUE: reference to a compiler-generated field
        this.\u0002 = new long?(obj1.\u0001.TotalCompleted);
        // ISSUE: reference to a compiler-generated field
        this.\u0003 = new long?(obj1.\u0001.TotalRemaining);
        // ISSUE: reference to a compiler-generated field
        if (this.\u0001 == obj1.\u0001.PercentComplete)
          return;
        // ISSUE: reference to a compiler-generated field
        this.\u0001 = obj1.\u0001.PercentComplete;
        // ISSUE: reference to a compiler-generated method
        this.\u001D\u0005(new MethodInvoker(obj1.\u001D\u0005));
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj2);
      }
    }

    private void \u001D\u0005(object sender, \u0081.\u0019 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u001C.\u0003()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(ProgressBarStyle style)
    {
      if (\u001F\u007F.\u007E\u0087\u008E((object) this.\u0001) == style)
        return;
      \u0091\u001C.\u007E\u0088\u008E((object) this.\u0001, style);
    }

    private void \u001D\u0005(object sender, \u001F.\u001F e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u001C.\u0004()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u001C.\u0005 obj1 = new \u001C.\u0005();
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = this.\u0001.ToonTownProcess;
        if (!this.\u0001.ToonTownProcess.ProcessOpen)
        {
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          this.InstallerResult = \u0004.\u0006;
          \u001A\u001E.\u0092\u008B((object) this);
        }
        else
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          \u001C.\u0006 obj2 = new \u001C.\u0006();
          // ISSUE: reference to a compiler-generated field
          obj2.\u0001 = obj1;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          obj2.\u0001 = !\u008F\u0084.\u009E\u0092(obj1.\u0001.MainWindowTitle) || \u0008\u0081.\u0087\u0096(obj1.\u0001.MainWindowHandle, IntPtr.Zero);
          // ISSUE: reference to a compiler-generated field
          if (!obj2.\u0001)
          {
            // ISSUE: reference to a compiler-generated field
            Process p = \u009E\u0082.\u0012\u0004\u0002(\u0005\u0081.\u007E\u009F\u0003\u0002((object) obj1.\u0001.Process));
            try
            {
              // ISSUE: reference to a compiler-generated field
              obj2.\u0001 = !\u008F\u0084.\u009E\u0092(\u0084.\u001D.\u001D\u0005(p)) || \u0008\u0081.\u0087\u0096(\u0084.\u001D.\u001D\u0005(p), IntPtr.Zero);
            }
            finally
            {
              if (p != null)
                \u001A\u001E.\u007E\u0094\u0092((object) p);
            }
          }
          // ISSUE: reference to a compiler-generated field
          if (!obj2.\u0001)
          {
            if (this.\u0003 > 6)
            {
              try
              {
                // ISSUE: reference to a compiler-generated method
                \u000E.\u001D\u0005(new \u000E.\u0001(obj2.\u001D\u0005), IntPtr.Zero);
              }
              catch (Exception ex)
              {
                \u001E.\u001D.\u001D\u0005(ex);
              }
            }
          }
          // ISSUE: reference to a compiler-generated field
          if (obj2.\u0001)
          {
            \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
            int num = (1 << \u0006\u0083.\u0095\u0095()) - 1;
            try
            {
              // ISSUE: reference to a compiler-generated field
              \u0007\u001C.\u007E\u0005\u0004\u0002((object) obj1.\u0001.Process, new IntPtr(num));
            }
            catch (Exception ex)
            {
              ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u001C.\u0013, (object) num));
            }
            if (this.\u0001 != null)
              this.\u0001.\u0082\u0005();
            this.InstallerResult = \u0004.\u0003;
            \u001A\u001E.\u0092\u008B((object) this);
          }
        }
        ++this.\u0003;
      }
      catch (Exception ex)
      {
        \u001E.\u001D.\u001D\u0005(ex);
        \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
        this.InstallerResult = \u0004.\u0005;
        \u001A\u001E.\u0092\u008B((object) this);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u007F\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001C)));
      this.\u0001 = new ProgressBar();
      this.\u0001 = new Button();
      this.\u0001 = new Label();
      this.\u0001 = new \u001C();
      this.\u0002 = new Label();
      this.\u0001 = new Timer(this.\u0001);
      this.\u0002 = new Timer(this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(15, 60));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(29474));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(260, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(281, 60));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(29491));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001C.\u0001(29504));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001C.\u0001(5250), 8.25f));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 44));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(29513));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(114, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001C.\u0001(29526));
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(224, 224, 224);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.ImageBounds = new Rectangle(0, 0, 0, 0);
      this.\u0001.ImageLocation = new Point(0, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(29555));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(364, 92));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001C.\u0001(8355), 12f, FontStyle.Bold));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(10, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001C.\u0001(5551));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(146, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001C.\u0001(29572));
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 500);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0002, 1000);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0002, new EventHandler(this.\u007F\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u000E\u001F.\u0010\u008B((object) this, new Size(372, 100));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001C.\u0001(6372)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u001C.\u0001(29601));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001C.\u0001(29618));
      \u0099\u001F.\u0086\u008B((object) this, true);
      \u0087\u007F.\u008E\u008B((object) this, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
