// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001A;
using \u001D;
using \u001F;
using \u0080;
using \u0084;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace \u001B
{
  internal sealed class \u001D : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private \u001F.\u001C \u0001;
    private \u001F.\u001C \u0002;
    private \u001C.\u0081 \u0001;
    private IContainer \u0001;
    private \u0016 \u0001;
    private \u0016 \u0002;
    private \u001B.\u001C \u0001;
    private Label \u0001;
    private Label \u0002;
    private Button \u0001;
    private \u0010 \u0001;
    private Label \u0003;
    private CheckBox \u0001;
    private CheckBox \u0002;
    private CheckBox \u0003;
    private Label \u0004;
    private Panel \u0001;
    private RadioButton \u0001;
    private RadioButton \u0002;
    private RadioButton \u0003;
    private Label \u0005;

    public IntPtr FirstSelectedWindow
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        return this.\u0001.MainWindowHandle;
      }
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] set
      {
        if (!\u0008\u0081.\u0087\u0096(this.\u0001.MainWindowHandle, value))
          return;
        this.\u0001.MainWindowHandle = value;
        this.\u0001.SelectedWindow = value;
        this.\u001D\u0005();
      }
    }

    public IntPtr SecondSelectedWindow
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        return this.\u0002.MainWindowHandle;
      }
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] set
      {
        if (!\u0008\u0081.\u0087\u0096(this.\u0002.MainWindowHandle, value))
          return;
        this.\u0002.MainWindowHandle = value;
        this.\u0002.SelectedWindow = value;
        this.\u001D\u0005();
      }
    }

    static \u001D()
    {
      \u0004.\u001D\u0005(typeof (\u001B.\u001D));
    }

    public \u001D()
    {
      this.\u001E\u0005();
      this.\u0001 = \u0081.\u0080.Instance.RemoteControllerSettings;
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0003, this.\u0001.UseOpacity);
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, this.\u0001.TopMost);
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, this.\u0001.AnimateController);
      this.\u0001 = new \u001F.\u001C();
      this.\u0002 = new \u001F.\u001C();
      this.\u0001.ProcessExited += (EventHandler) ((obj, e) => this.\u001D\u0005());
      this.\u0002.ProcessExited += (EventHandler) ((obj, e) => this.\u001D\u0005());
      this.\u001D\u0005();
      switch (this.\u0001.KeyboardLayout)
      {
        case \u0007.\u0002:
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, true);
          break;
        case \u0007.\u0003:
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, true);
          break;
        default:
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0003, true);
          break;
      }
    }

    private void \u001D\u0005()
    {
      // ISSUE: method pointer
      this.\u001E\u0005(new MethodInvoker((object) this, __methodptr(\u001F\u0005)));
    }

    private void \u001D\u0005(object sender, \u0080.\u0017 e)
    {
      if (\u0008\u0081.\u0086\u0096(((\u0008) e).Handle, IntPtr.Zero))
      {
        e.IsValid = false;
      }
      else
      {
        Process process = \u000E.\u001D\u0005(((\u0008) e).Handle);
        try
        {
          e.IsValid = \u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0019\u0093((object) \u0002\u007F.\u007E\u0004\u0004\u0002((object) process)), \u001B.\u001D.\u0001(16698));
        }
        finally
        {
          if (process != null)
            \u001A\u001E.\u007E\u0094\u0092((object) process);
        }
      }
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001D\u0005(object sender, \u000E e)
    {
      this.FirstSelectedWindow = e.Handle;
      this.\u001D\u0005();
    }

    private void \u001E\u0005(object sender, \u000E e)
    {
      this.SecondSelectedWindow = e.Handle;
      this.\u001D\u0005();
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u0001.TopMost = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0002);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u0001.AnimateController = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      this.\u0001.UseOpacity = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003);
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0082.\u001D\u0005(\u0002.\u0011);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u0003))
        return;
      this.\u0001.KeyboardLayout = \u0007.\u0001;
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u0002))
        return;
      this.\u0001.KeyboardLayout = \u0007.\u0002;
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u0001))
        return;
      this.\u0001.KeyboardLayout = \u0007.\u0003;
    }

    protected override void Dispose(bool disposing)
    {
      this.\u0001.Dispose();
      this.\u0002.Dispose();
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001E\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001B.\u001D)));
      this.\u0001 = new Button();
      this.\u0001 = new \u001B.\u001C();
      this.\u0001 = new RadioButton();
      this.\u0002 = new RadioButton();
      this.\u0003 = new RadioButton();
      this.\u0003 = new CheckBox();
      this.\u0001 = new CheckBox();
      this.\u0002 = new CheckBox();
      this.\u0003 = new Label();
      this.\u0001 = new \u0010();
      this.\u0001 = new Label();
      this.\u0001 = new \u0016();
      this.\u0002 = new \u0016();
      this.\u0005 = new Label();
      this.\u0002 = new Label();
      this.\u0004 = new Label();
      this.\u0001 = new Panel();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(321, 378));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u001D.\u0001(33213));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u001D.\u0001(8566));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(224, 224, 224);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Top);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.ImageBounds = new Rectangle(0, 0, 0, 0);
      this.\u0001.ImageLocation = new Point(0, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u001D.\u0001(56809));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(395, 371));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(192, 342));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u001D.\u0001(56826));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(73, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 18);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u001D.\u0001(56839));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, false);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0001, new EventHandler(this.\u0082\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(118, 342));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u001D.\u0001(56848));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(68, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 18);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0002, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001B.\u001D.\u0001(56861));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, false);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0002, new EventHandler(this.\u0081\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(39, 342));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001B.\u001D.\u0001(56870));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(73, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 18);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0003, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u001B.\u001D.\u0001(56883));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, false);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0003, new EventHandler(this.\u0080\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(39, 289));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001B.\u001D.\u0001(56892));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(194, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 17);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u001B.\u001D.\u0001(56909));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, false);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0003, new EventHandler(this.\u007F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(39, 243));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u001D.\u0001(56958));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(292, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 17);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u001D.\u0001(56991));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, false);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(39, 266));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u001D.\u0001(10962));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(261, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 17);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001B.\u001D.\u0001(57068));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, false);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(45, 74));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001B.\u001D.\u0001(57137));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(338, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 16);
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0003, ContentAlignment.MiddleLeft);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      this.\u0001.BaseColor = \u009A\u0080.\u0008\u007F();
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(16, 74));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u001D.\u0001(57154));
      this.\u0001.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(23, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 15);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u001D.\u0001(17894));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001B.\u001D.\u0001(9493), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(10, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u001D.\u0001(18947));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(161, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 11);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u001D.\u0001(57167));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      this.\u0001.LabelMessage = \u001B.\u001D.\u0001(57196);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 103));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u001D.\u0001(57273));
      this.\u0001.ResourceNumber = 102;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(373, 60));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      this.\u0001.SelectedHandleChanged += new EventHandler<\u000E>(this.\u001D\u0005);
      this.\u0001.SelectedHandleChanging += new EventHandler<\u0080.\u0017>(this.\u001D\u0005);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      this.\u0002.LabelMessage = \u001B.\u001D.\u0001(57302);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(12, 169));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u001D.\u0001(57379));
      this.\u0002.ResourceNumber = 102;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(373, 60));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 0);
      this.\u0002.SelectedHandleChanged += new EventHandler<\u000E>(this.\u001E\u0005);
      this.\u0002.SelectedHandleChanging += new EventHandler<\u0080.\u0017>(this.\u001D\u0005);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0005, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(36, 326));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u001B.\u001D.\u0001(57408));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(87, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u001B.\u001D.\u0001(57437));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(11, 38));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u001D.\u0001(57458));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(370, 37));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001B.\u001D.\u0001(57467));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u001B.\u001D.\u0001(6388), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(4, 389));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u001B.\u001D.\u0001(8751));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 37);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u001B.\u001D.\u0001(8776));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0001, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u001D.\u0001(57597));
      \u0001\u001F.\u007E\u0089\u0084((object) this.\u0001, new Padding(4));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(403, 404));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 38);
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u000E\u001F.\u0010\u008B((object) this, new Size(403, 404));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001B.\u001D.\u0001(7510)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u001B.\u001D.\u0001(57606));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001B.\u001D.\u0001(57167));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
