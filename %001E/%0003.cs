// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001D;
using \u001E;
using \u007F;
using \u0082;
using \u0083;
using \u0084;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace \u001E
{
  [ToolboxItem(false)]
  internal sealed class \u0003 : ToolStripDropDown
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private ToolStripControlHost \u0001;
    private Control \u0001;
    private \u0003 \u0001;
    private \u0003 \u0002;
    private bool \u0001;
    private bool \u0002;
    private bool \u0003;
    private bool \u0004;
    private bool \u0005;
    private VisualStyleRenderer \u0001;
    private IContainer \u0001;

    public Control Content { get; private set; }

    public \u0004 ShowingAnimation { get; set; }

    public \u0004 HidingAnimation { get; set; }

    public int AnimationDuration { get; set; }

    public bool FocusOnOpen { get; set; }

    public bool AcceptAlt { get; set; }

    public bool Resizable
    {
      get
      {
        if (!this.\u0004)
          return false;
        return !this.\u0003;
      }
      set
      {
        this.\u0004 = value;
      }
    }

    public bool NonInteractive
    {
      get
      {
        return this.\u0005;
      }
      set
      {
        if (value == this.\u0005)
          return;
        this.\u0005 = value;
        if (!\u0099\u0082.\u009A\u0083((object) this))
          return;
        \u001A\u001E.\u001D\u0086((object) this);
      }
    }

    public new Size MinimumSize { get; set; }

    public new Size MaximumSize { get; set; }

    protected override CreateParams CreateParams
    {
      [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        CreateParams createParams1 = \u0005\u0086.\u0017\u0089((object) this);
        \u0011\u001F obj1 = \u0011\u001F.\u007E\u0099\u0089;
        CreateParams createParams2 = createParams1;
        int num1 = createParams2.ExStyle | 134217728;
        obj1((object) createParams2, num1);
        if (this.NonInteractive)
        {
          \u0011\u001F obj2 = \u0011\u001F.\u007E\u0099\u0089;
          CreateParams createParams3 = createParams1;
          int num2 = createParams3.ExStyle | 524448;
          obj2((object) createParams3, num2);
        }
        return createParams1;
      }
    }

    static \u0003()
    {
      \u0004.\u001D\u0005(typeof (\u0003));
    }

    public \u0003(Control content)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0003.\u0001 obj1 = new \u0003.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = content;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      if (obj1.\u0001 == null)
        throw new ArgumentNullException(\u0003.\u0001(56585));
      // ISSUE: reference to a compiler-generated field
      this.Content = obj1.\u0001;
      this.FocusOnOpen = true;
      this.AcceptAlt = true;
      this.ShowingAnimation = \u0004.\u000F;
      this.HidingAnimation = \u0004.\u0001;
      this.AnimationDuration = 100;
      this.\u001E\u0005();
      \u0099\u001F.\u007E\u001B\u0083((object) this, false);
      \u0099\u001F.\u007E\u008D\u0083((object) this, true);
      \u0099\u001F.\u0014\u0084((object) this, true);
      // ISSUE: reference to a compiler-generated field
      this.\u0001 = new ToolStripControlHost(obj1.\u0001);
      \u0001\u001F obj2 = \u0001\u001F.\u0089\u0084;
      \u0001\u001F obj3 = \u0001\u001F.\u0003\u0084;
      \u0001\u001F obj4 = \u0001\u001F.\u007E\u001D\u0087;
      ToolStripControlHost stripControlHost = this.\u0001;
      Padding padding1;
      \u0001\u001F.\u007E\u001B\u0087((object) this.\u0001, padding1 = Padding.Empty);
      Padding padding2;
      Padding padding3 = padding2 = padding1;
      obj4((object) stripControlHost, padding2);
      Padding padding4;
      Padding padding5 = padding4 = padding3;
      obj3((object) this, padding4);
      Padding padding6 = padding5;
      obj2((object) this, padding6);
      if (\u0008.IsRunningOnMono)
      {
        // ISSUE: reference to a compiler-generated field
        \u0001\u001F.\u007E\u0003\u0084((object) obj1.\u0001, Padding.Empty);
      }
      // ISSUE: reference to a compiler-generated field
      this.MinimumSize = \u0083\u001E.\u007E\u0006\u0084((object) obj1.\u0001);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      \u000E\u001F.\u007E\u0007\u0084((object) obj1.\u0001, \u0083\u001E.\u007E\u0017\u0084((object) obj1.\u0001));
      // ISSUE: reference to a compiler-generated field
      this.MaximumSize = \u0083\u001E.\u007E\u0004\u0084((object) obj1.\u0001);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      \u000E\u001F.\u007E\u0005\u0084((object) obj1.\u0001, \u0083\u001E.\u007E\u0017\u0084((object) obj1.\u0001));
      // ISSUE: reference to a compiler-generated field
      \u000E\u001F.\u0018\u0084((object) this, \u0083\u001E.\u007E\u0017\u0084((object) obj1.\u0001));
      if (\u0008.IsRunningOnMono)
      {
        // ISSUE: reference to a compiler-generated field
        \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, \u0083\u001E.\u007E\u0017\u0084((object) obj1.\u0001));
      }
      \u0099\u001F obj5 = \u0099\u001F.\u0012\u0087;
      bool flag;
      // ISSUE: reference to a compiler-generated field
      \u0099\u001F.\u007E\u001B\u0084((object) obj1.\u0001, flag = true);
      int num1 = flag ? 1 : 0;
      obj5((object) this, num1 != 0);
      // ISSUE: reference to a compiler-generated field
      \u0096\u0086.\u007E\u009F\u0083((object) obj1.\u0001, Point.Empty);
      int num2 = \u0095\u007F.\u007E\u008C\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this), (ToolStripItem) this.\u0001);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      obj1.\u0001.Disposed += new EventHandler(obj1.\u001D\u0005);
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001.RegionChanged += (EventHandler) ((sender, e) => this.\u001D\u0005());
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001.Paint += (PaintEventHandler) ((sender, e) => this.\u001D\u0005(e));
      this.\u001D\u0005();
    }

    protected override void OnVisibleChanged(EventArgs e)
    {
      \u0088\u001C.\u0087\u0089((object) this, e);
      if (\u0008.IsRunningOnMono || \u0099\u0082.\u007F\u0089((object) this) && this.ShowingAnimation == \u0004.\u0001 || !\u0099\u0082.\u007F\u0089((object) this) && this.HidingAnimation == \u0004.\u0001)
        return;
      \u000F obj1 = \u0099\u0082.\u007F\u0089((object) this) ? \u000F.\u0001 : \u000F.\u0007;
      \u0004 obj2 = \u0099\u0082.\u007F\u0089((object) this) ? this.ShowingAnimation : this.HidingAnimation;
      if (obj2 == \u0004.\u000F)
        obj2 = !\u000F\u0080.\u007F\u008F() ? \u0004.\u0001 : (!\u000F\u0080.\u001F\u008F() ? (\u0004) (262144 | (\u0099\u0082.\u007F\u0089((object) this) ? 4 : 8)) : \u0004.\u0008);
      if ((obj2 & (\u0004.\u0006 | \u0004.\u0007 | \u0004.\u0008 | \u0004.\u000E)) == \u0004.\u0001)
        return;
      if (this.\u0001)
      {
        if ((obj2 & \u0004.\u0005) != \u0004.\u0001)
          obj2 = obj2 & ~\u0004.\u0005 | \u0004.\u0004;
        else if ((obj2 & \u0004.\u0004) != \u0004.\u0001)
          obj2 = obj2 & ~\u0004.\u0004 | \u0004.\u0005;
      }
      if (this.\u0002)
      {
        if ((obj2 & \u0004.\u0003) != \u0004.\u0001)
          obj2 = obj2 & ~\u0004.\u0003 | \u0004.\u0002;
        else if ((obj2 & \u0004.\u0002) != \u0004.\u0001)
          obj2 = obj2 & ~\u0004.\u0002 | \u0004.\u0003;
      }
      \u000F flags = obj1 | (\u000F) ((\u0004) 1048575 & obj2);
      \u0013.\u001D\u0005((Control) this);
      \u0013.\u001D\u0005((Control) this, this.AnimationDuration, flags);
    }

    [UIPermission(SecurityAction.LinkDemand, Window = UIPermissionWindow.AllWindows)]
    protected override bool ProcessDialogKey(Keys keyData)
    {
      if (this.AcceptAlt && (keyData & Keys.Alt) == Keys.Alt)
        goto label_6;
label_3:
      bool flag1 = \u0012\u001D.\u0088\u0089((object) this, keyData);
      if (!flag1 && (keyData == Keys.Tab || keyData == (Keys.Tab | Keys.Shift)))
      {
        bool flag2 = (keyData & Keys.Shift) == Keys.Shift;
        int num = \u0096\u001E.\u007E\u0081\u0086((object) this.Content, (Control) null, !flag2, true, true, true) ? 1 : 0;
      }
      return flag1;
label_6:
      if ((keyData & Keys.F4) != Keys.F4)
        return false;
      \u001A\u001E.\u0081\u0089((object) this);
      goto label_3;
    }

    protected void \u001D\u0005()
    {
      if (\u0006\u0086.\u001E\u0089((object) this) != null)
      {
        \u001A\u001E.\u007E\u009C\u0080((object) \u0006\u0086.\u001E\u0089((object) this));
        \u0081\u007F.\u001F\u0089((object) this, (Region) null);
      }
      if (\u0006\u0086.\u007E\u0012\u0084((object) this.Content) == null)
        return;
      \u0081\u007F.\u001F\u0089((object) this, \u0006\u0086.\u007E\u009B\u0080((object) \u0006\u0086.\u007E\u0012\u0084((object) this.Content)));
    }

    public void \u001E\u0005(Control control)
    {
      if (control == null)
        throw new ArgumentNullException(\u0003.\u0001(64868));
      this.\u001D\u0005(control, \u008D\u0084.\u007E\u0082\u0083((object) control));
    }

    public void \u001D\u0005(Rectangle area)
    {
      this.\u0001 = this.\u0002 = false;
      Point point = new Point(area.Left, area.Top + area.Height);
      Rectangle rectangle = \u008D\u0084.\u007E\u0015\u008F((object) \u0017\u0081.\u0017\u008F((Control) this));
      if (point.X + \u0083\u001E.\u0017\u0084((object) this).Width > rectangle.Left + rectangle.Width)
      {
        this.\u0002 = true;
        point.X = rectangle.Left + rectangle.Width - \u0083\u001E.\u0017\u0084((object) this).Width;
      }
      if (point.Y + \u0083\u001E.\u0017\u0084((object) this).Height > rectangle.Top + rectangle.Height)
      {
        this.\u0001 = true;
        point.Y -= \u0083\u001E.\u0017\u0084((object) this).Height + area.Height;
      }
      \u001D\u001D.\u008B\u0089((object) this, point, ToolStripDropDownDirection.BelowRight);
    }

    public void \u001D\u0005(Control control, Rectangle area)
    {
      if (control == null)
        throw new ArgumentNullException(\u0003.\u0001(64868));
      this.\u001F\u0005(control);
      this.\u0001 = this.\u0002 = false;
      Point point1 = \u0098\u001B.\u007E\u001B\u0086((object) control, new Point(area.Left, area.Top + area.Height));
      Rectangle rectangle = \u008D\u0084.\u007E\u0015\u008F((object) \u0017\u0081.\u0017\u008F(control));
      if (point1.X + \u0083\u001E.\u0017\u0084((object) this).Width > rectangle.Left + rectangle.Width)
      {
        this.\u0002 = true;
        point1.X = rectangle.Left + rectangle.Width - \u0083\u001E.\u0017\u0084((object) this).Width;
      }
      if (point1.Y + \u0083\u001E.\u0017\u0084((object) this).Height > rectangle.Top + rectangle.Height)
      {
        this.\u0001 = true;
        point1.Y -= \u0083\u001E.\u0017\u0084((object) this).Height + area.Height;
      }
      Point point2 = \u0098\u001B.\u007E\u001A\u0086((object) control, point1);
      \u0094\u001D.\u008A\u0089((object) this, control, point2, ToolStripDropDownDirection.BelowRight);
    }

    private void \u001F\u0005(Control control)
    {
      if (control == null)
        return;
      if (!(control is \u0003))
      {
        if (this.\u0001 == null)
          this.\u0001 = control;
        if (\u0003\u001E.\u007E\u0011\u0084((object) control) == null)
          return;
        this.\u001F\u0005(\u0003\u001E.\u007E\u0011\u0084((object) control));
      }
      else
      {
        \u0003 obj = control as \u0003;
        this.\u0001 = obj;
        this.\u0001.\u0002 = this;
        \u0004\u001D.\u001D\u0089((object) this, \u0013\u007F.\u007E\u008B\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) obj), 0));
      }
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      if (this.Content != null)
      {
        \u000E\u001F.\u007E\u0007\u0084((object) this.Content, \u0083\u001E.\u0017\u0084((object) this));
        \u000E\u001F.\u007E\u0005\u0084((object) this.Content, \u0083\u001E.\u0017\u0084((object) this));
        \u000E\u001F.\u007E\u0018\u0084((object) this.Content, \u0083\u001E.\u0017\u0084((object) this));
        \u0096\u0086.\u007E\u009F\u0083((object) this.Content, Point.Empty);
      }
      \u0088\u001C.\u0018\u0086((object) this, e);
    }

    protected override void OnLayout(LayoutEventArgs e)
    {
      if (!\u0008.IsRunningOnMono)
      {
        \u0007\u001D.\u0083\u0089((object) this, e);
      }
      else
      {
        Size size = \u009A\u0082.\u007E\u0096\u0083((object) this, Size.Empty);
        if (\u0099\u0082.\u007E\u001A\u0083((object) this) && \u0010\u007F.\u0006\u0081(size, \u0083\u001E.\u0017\u0084((object) this)))
          \u000E\u001F.\u0018\u0084((object) this, size);
        \u001A\u001E.\u007E\u0014\u0087((object) this);
        \u0088\u001C.\u007E\u0013\u0087((object) this, EventArgs.Empty);
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    protected override void OnOpening(CancelEventArgs e)
    {
      if (\u0099\u0082.\u007E\u008A\u0083((object) this.Content) || \u0099\u0082.\u007E\u008B\u0083((object) this.Content))
      {
        \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
      }
      else
      {
        this.\u001D\u0005();
        \u0002\u0083.\u0084\u0089((object) this, e);
      }
    }

    protected override void OnOpened(EventArgs e)
    {
      if (this.\u0001 != null)
        this.\u0001.\u0003 = true;
      if (this.FocusOnOpen)
      {
        int num = \u0099\u0082.\u007E\u009E\u0084((object) this.Content) ? 1 : 0;
      }
      \u0088\u001C.\u0086\u0089((object) this, e);
    }

    protected override void OnClosed(ToolStripDropDownClosedEventArgs e)
    {
      this.\u0001 = (Control) null;
      if (this.\u0001 != null)
        goto label_2;
label_1:
      \u0005\u001E.\u0082\u0089((object) this, e);
      return;
label_2:
      this.\u0001.\u0003 = false;
      goto label_1;
    }

    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected override void WndProc(ref Message m)
    {
      if (this.\u001D\u0005(ref m, false))
        return;
      \u0015\u0084.\u008C\u0089((object) this, ref m);
    }

    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public bool \u001D\u0005(ref Message m)
    {
      return this.\u001D\u0005(ref m, true);
    }

    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    private bool \u001D\u0005(ref Message m, bool contentControl)
    {
      if (m.Msg == 134 && (\u0008\u0081.\u0087\u0096(m.WParam, IntPtr.Zero) && this.\u0002 != null) && \u0099\u0082.\u007E\u007F\u0089((object) this.\u0002))
        \u001A\u001E.\u007E\u0001\u0086((object) this.\u0002);
      if (!this.Resizable && !this.NonInteractive)
        return false;
      switch (m.Msg)
      {
        case 36:
          return this.\u001E\u0005(ref m);
        case 132:
          return this.\u001E\u0005(ref m, contentControl);
        default:
          return false;
      }
    }

    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    private bool \u001E\u0005(ref Message m)
    {
      // ISSUE: type reference
      \u0081.\u0082 obj = (\u0081.\u0082) \u000F\u001E.\u0014\u009D(m.LParam, \u009C\u0082.\u0016\u0097(__typeref (\u0081.\u0082)));
      if (!this.MaximumSize.IsEmpty)
        obj.\u0003 = this.MaximumSize;
      obj.\u0002 = this.MinimumSize;
      \u0090\u0084.\u0013\u009D((object) obj, m.LParam, false);
      return true;
    }

    private bool \u001E\u0005(ref Message m, bool contentControl)
    {
      if (!this.NonInteractive)
      {
        int x = \u0098\u0080.\u009F\u0089().X;
        int y = \u0098\u0080.\u009F\u0089().Y;
        Point pt = \u0098\u001B.\u001A\u0086((object) this, new Point(x, y));
        \u0014 obj = new \u0014(contentControl ? \u008D\u0084.\u007E\u0082\u0083((object) this.Content) : \u008D\u0084.\u0082\u0083((object) this));
        IntPtr num = new IntPtr(-1);
        if (this.\u0001)
        {
          if (this.\u0002 && obj.TopLeft.Contains(pt))
          {
            m.Result = contentControl ? num : \u0098\u001F.\u0081\u0096(13L);
            return true;
          }
          if (!this.\u0002 && obj.TopRight.Contains(pt))
          {
            m.Result = contentControl ? num : \u0098\u001F.\u0081\u0096(14L);
            return true;
          }
          if (obj.Top.Contains(pt))
          {
            m.Result = contentControl ? num : \u0098\u001F.\u0081\u0096(12L);
            return true;
          }
        }
        else
        {
          if (this.\u0002 && obj.BottomLeft.Contains(pt))
          {
            m.Result = contentControl ? num : \u0098\u001F.\u0081\u0096(16L);
            return true;
          }
          if (!this.\u0002 && obj.BottomRight.Contains(pt))
          {
            m.Result = contentControl ? num : \u0098\u001F.\u0081\u0096(17L);
            return true;
          }
          if (obj.Bottom.Contains(pt))
          {
            m.Result = contentControl ? num : \u0098\u001F.\u0081\u0096(15L);
            return true;
          }
        }
        if (this.\u0002 && obj.Left.Contains(pt))
        {
          m.Result = contentControl ? num : \u0098\u001F.\u0081\u0096(10L);
          return true;
        }
        if (this.\u0002 || !obj.Right.Contains(pt))
          return false;
        m.Result = contentControl ? num : \u0098\u001F.\u0081\u0096(11L);
        return true;
      }
      m.Result = \u0098\u001F.\u0081\u0096(-1L);
      return true;
    }

    public void \u001D\u0005(PaintEventArgs e)
    {
      if (e == null || (\u0004\u007F.\u007E\u0092\u0086((object) e) == null || !this.\u0004))
        return;
      Size size = \u0083\u001E.\u007E\u0083\u0083((object) this.Content);
      Bitmap bitmap = new Bitmap(16, 16);
      try
      {
        Graphics graphics = \u0005\u0087.\u001D\u007F((Image) bitmap);
        try
        {
          if (\u000F\u0080.\u0007\u0083())
          {
            if (this.\u0001 == null)
              this.\u0001 = new VisualStyleRenderer(\u0017\u007F.\u0008\u0091());
            \u001F\u001F.\u007E\u000F\u0091((object) this.\u0001, (IDeviceContext) graphics, new Rectangle(0, 0, 16, 16));
          }
          else
            \u0014\u0081.\u0092\u0089(graphics, \u0091\u0084.\u007E\u001C\u0083((object) this.Content), 0, 0, 16, 16);
        }
        finally
        {
          if (graphics != null)
            \u001A\u001E.\u007E\u0094\u0092((object) graphics);
        }
        GraphicsState graphicsState = \u009E\u001E.\u007E\u0007\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e));
        \u001A\u001E.\u007E\u0086\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e));
        if (this.\u0001)
        {
          if (this.\u0002)
          {
            \u0082\u001E.\u007E\u0089\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), 180f);
            \u0014\u001F.\u007E\u0087\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (float) -size.Width, (float) -size.Height);
          }
          else
          {
            \u0014\u001F.\u007E\u0088\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), 1f, -1f);
            \u0014\u001F.\u007E\u0087\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), 0.0f, (float) -size.Height);
          }
        }
        else if (this.\u0002)
        {
          \u0014\u001F.\u007E\u0088\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), -1f, 1f);
          \u0014\u001F.\u007E\u0087\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (float) -size.Width, 0.0f);
        }
        \u009B\u001F.\u007E\u009F\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Image) bitmap, size.Width - 16, size.Height - 16 + 1, 16, 16);
        \u008A\u0084.\u007E\u0008\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e), graphicsState);
      }
      finally
      {
        if (bitmap != null)
          \u001A\u001E.\u007E\u0094\u0092((object) bitmap);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        goto label_3;
label_2:
      \u0099\u001F.\u0080\u0089((object) this, disposing);
      return;
label_3:
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      if (this.Content != null)
      {
        Control content = this.Content;
        this.Content = (Control) null;
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) content);
        goto label_2;
      }
      else
        goto label_2;
    }

    private void \u001E\u0005()
    {
      this.\u0001 = (IContainer) new Container();
    }
  }
}
