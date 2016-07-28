// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u0019;
using \u001A;
using \u001F;
using \u0080;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u0005 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private readonly \u0003 \u0001;
    private readonly \u0005 \u0001;
    private readonly TaskFactory \u0001;
    private readonly object \u0001;
    private readonly Control \u0001;
    private int \u0001;
    private int \u0002;
    private \u001C \u0001;
    private IContainer \u0001;
    private FileSystemWatcher \u0001;
    private \u001B.\u0082 \u0001;
    private StatusStrip \u0001;
    private ToolStripStatusLabel \u0001;
    private ToolStripStatusLabel \u0002;

    static \u0005()
    {
      \u0004.\u001D\u0005(typeof (\u0005));
    }

    public \u0005()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.\u0001 = new object();
      this.\u001E\u0005();
      this.\u0001 = new Control();
      Control control = this.\u0001;
      if (eventHandler1 == null)
        goto label_2;
label_1:
      EventHandler eventHandler2 = eventHandler1;
      control.LostFocus += eventHandler2;
      this.\u0001.PreviewKeyDown += (PreviewKeyDownEventHandler) ((obj, arg) =>
      {
        switch (\u007F\u0081.\u007E\u0082\u008E((object) arg))
        {
          case Keys.Tab:
          case Keys.Left:
          case Keys.Right:
            \u0099\u001F.\u007E\u0083\u008E((object) arg, true);
            break;
        }
      });
      this.\u0001.KeyDown += (KeyEventHandler) ((obj, arg) =>
      {
        switch (\u007F\u0081.\u007E\u0013\u008C((object) arg))
        {
          case Keys.Left:
            this.\u0001.\u001F\u0005();
            break;
          case Keys.Right:
            this.\u0001.\u001E\u0005();
            break;
        }
      });
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), this.\u0001);
      int num1;
      this.Activated += (EventHandler) ((obj, arg) => num1 = \u0099\u0082.\u007E\u009E\u0084((object) this.\u0001) ? 1 : 0);
      int num2 = \u0099\u0082.\u007E\u009E\u0084((object) this.\u0001) ? 1 : 0;
      this.\u0001 = \u0081.\u0080.Instance.MyGallerySettings;
      Rectangle rectangle = \u0097\u007F.\u0018\u008F(\u0098\u0080.\u009F\u0089());
      \u0011\u001F.\u0084\u0084((object) this, (int) ((double) rectangle.Width * 0.899999976158142));
      \u0096\u0086.\u0018\u008B((object) this, new Point(rectangle.Width / 2 - \u0005\u0081.\u0083\u0084((object) this) / 2 + rectangle.X, (int) ((double) rectangle.Height * 0.98) - \u0005\u0081.\u0098\u0083((object) this) + rectangle.Y));
      this.\u0001 = new \u0005(1);
      this.\u0001 = new TaskFactory((TaskScheduler) this.\u0001);
      return;
label_2:
      // ISSUE: method pointer
      eventHandler1 = new EventHandler((object) this, __methodptr(\u001E\u0005));
      goto label_1;
    }

    private void \u001D\u0005()
    {
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u009E\u0081.\u001F\u0093(\u0005.\u0001(33832), (object) this.\u0001));
      if (this.\u0001 != 0)
        return;
      this.\u0001.Text += \u0005.\u0001(33901);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0005.\u0001 obj1 = new \u0005.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = new \u0014.\u001A();
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        obj1.\u0001.Shown += new EventHandler(obj1.\u001D\u0005);
        // ISSUE: reference to a compiler-generated field
        \u009C\u001C.\u007E\u0084\u008B((object) obj1.\u0001, FormStartPosition.CenterScreen);
        // ISSUE: reference to a compiler-generated field
        int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj1.\u0001);
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj1.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj1.\u0001);
        }
      }
      \u0092\u0081.\u007E\u008E\u0003\u0002((object) this.\u0001, \u0081.\u0080.Instance.ApplicationSettings.ScreenshotSaveDirectory);
      \u0098\u001C.\u008B\u008B((object) this, (FormClosingEventHandler) ((obj, arg) => \u0099\u001F.\u007E\u008C\u0003\u0002((object) this.\u0001, false)));
      \u0099\u001F.\u007E\u008C\u0003\u0002((object) this.\u0001, true);
    }

    private void \u001D\u0005(\u0006 data)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0005.\u0002 obj1 = new \u0005.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = data;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      bool flag = false;
      object obj2;
      try
      {
        \u0098\u0082.\u0081\u0098(obj2 = this.\u0001, ref flag);
        ++this.\u0002;
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj2);
      }
      // ISSUE: reference to a compiler-generated method
      Task task = \u0003\u0082.\u007E\u007F\u0099((object) this.\u0001, new Action(obj1.\u001D\u0005));
    }

    private void \u001D\u0005(string filePath, DateTime dateCreated, DateTime timeStamp)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0005.\u0003 obj1 = new \u0005.\u0003();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = filePath;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = dateCreated;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0002 = timeStamp;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      bool flag = false;
      object obj2;
      try
      {
        \u0098\u0082.\u0081\u0098(obj2 = this.\u0001, ref flag);
        ++this.\u0002;
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj2);
      }
      // ISSUE: reference to a compiler-generated method
      Task task = \u0003\u0082.\u007E\u007F\u0099((object) this.\u0001, new Action(obj1.\u001D\u0005));
    }

    private void \u001D\u0005(object sender, FileSystemEventArgs e)
    {
      if (\u008C\u001E.\u007E\u0088\u0003\u0002((object) e) != WatcherChangeTypes.Created)
        return;
      this.\u001D\u0005(\u0002\u007F.\u007E\u0089\u0003\u0002((object) e), \u0012.\u001D\u0005(\u0002\u007F.\u007E\u0089\u0003\u0002((object) e)), \u001D\u0082.\u0011\u0094());
    }

    private void \u001E\u0005(object sender, FileSystemEventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      this.\u001D\u0005(new MethodInvoker((object) new \u0005.\u0004()
      {
        \u0001 = e,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u000E);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        goto label_6;
label_5:
      \u0099\u001F.\u0093\u008B((object) this, disposing);
      return;
label_6:
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
        goto label_5;
      }
      else
        goto label_5;
    }

    private void \u001E\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0005)));
      this.\u0001 = new FileSystemWatcher();
      this.\u0001 = new StatusStrip();
      this.\u0002 = new ToolStripStatusLabel();
      this.\u0001 = new ToolStripStatusLabel();
      this.\u0001 = new \u001B.\u0082();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u008C\u0003\u0002((object) this.\u0001, true);
      \u0092\u0081.\u007E\u008D\u0003\u0002((object) this.\u0001, \u0005.\u0001(33978));
      \u0019\u0081.\u007E\u008F\u0003\u0002((object) this.\u0001, (ISynchronizeInvoke) this);
      \u0087\u0084.\u007E\u0090\u0003\u0002((object) this.\u0001, new FileSystemEventHandler(this.\u001D\u0005));
      \u0087\u0084.\u007E\u0091\u0003\u0002((object) this.\u0001, new FileSystemEventHandler(this.\u001E\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[2]
      {
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0001
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 186));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(33987));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(606, 22));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(34000));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0005.\u0001(7788));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(132, 17));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0005.\u0001(7813));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0005.\u0001(34017));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(0, 17));
      \u0012\u0082.\u007E\u009D\u0090((object) this.\u0001, BorderStyle.Fixed3D);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(34042));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(606, 186));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(606, 208));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0005.\u0001(6547)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u000E\u001F.\u007E\u0005\u0084((object) this, new Size(2800, 246));
      \u000E\u001F.\u007E\u0007\u0084((object) this, new Size(240, 246));
      \u0092\u0081.\u0010\u0084((object) this, \u0005.\u0001(34059));
      \u009A\u001C.\u0083\u008B((object) this, SizeGripStyle.Hide);
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.Manual);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0005.\u0001(34072));
      \u0087\u007F.\u008E\u008B((object) this, new EventHandler(this.\u001D\u0005));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
