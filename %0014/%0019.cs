// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u0015;
using \u0016;
using \u001A;
using \u001D;
using \u001E;
using \u007F;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace \u0014
{
  internal class \u0019 : Form
  {
    private static readonly \u0015.\u0015<\u0019> \u0001 = new \u0015.\u0015<\u0019>();
    private bool \u0001 = true;
    private bool \u0002;
    private bool \u0003;
    private Point \u0001;
    private bool \u0004;
    private bool \u0005;

    public bool EnableCloseButton
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (this.\u0001 == value)
          return;
        this.\u0001 = value;
        if (!\u0099\u0082.\u009A\u0083((object) this))
          return;
        IntPtr hMenu = \u000E.\u001D\u0005(\u0088\u0086.\u0097\u0083((object) this), false);
        \u0084.\u001A obj = \u0084.\u001A.\u0001;
        \u0084.\u001A uEnable = !this.\u0001 ? obj | \u0084.\u001A.\u0003 | \u0084.\u001A.\u0005 : obj;
        \u000E.\u001D\u0005(hMenu, \u0010.\u0001, uEnable);
      }
    }

    public virtual bool UseOpacity
    {
      get
      {
        return this.\u0004;
      }
      set
      {
        if (this.\u0004 == value)
          return;
        this.\u0004 = value;
        if (!\u0099\u0082.\u009A\u0083((object) this))
          return;
        \u001A\u001E.\u001D\u0086((object) this);
      }
    }

    public bool CustomPainting
    {
      get
      {
        return this.\u0005;
      }
      set
      {
        if (this.\u0005 == value)
          return;
        this.\u0005 = value;
        if (!\u0099\u0082.\u009A\u0083((object) this))
          return;
        \u001A\u001E.\u001D\u0086((object) this);
      }
    }

    public bool AllowFormDrag
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if (this.\u0002 == value)
          return;
        this.\u0002 = value;
        if (this.\u0002)
          return;
        this.\u0003 = false;
      }
    }

    protected override CreateParams CreateParams
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        CreateParams createParams1 = \u0005\u0086.\u0013\u008B((object) this);
        if (!this.EnableCloseButton)
        {
          \u0011\u001F obj = \u0011\u001F.\u007E\u009B\u0089;
          CreateParams createParams2 = createParams1;
          int num = createParams2.ClassStyle | 512;
          obj((object) createParams2, num);
        }
        if (!\u0099\u0082.\u0081\u0001\u0002((object) this) && this.UseOpacity)
        {
          \u0011\u001F obj = \u0011\u001F.\u007E\u0099\u0089;
          CreateParams createParams2 = createParams1;
          int num = createParams2.ExStyle | 524288;
          obj((object) createParams2, num);
        }
        if (\u0004\u0084.\u0007\u008B((object) this) == FormBorderStyle.None && \u0099\u0082.\u0011\u008B((object) this))
        {
          \u0011\u001F obj1 = \u0011\u001F.\u007E\u0097\u0089;
          CreateParams createParams2 = createParams1;
          int num1 = createParams2.Style | 34078720;
          obj1((object) createParams2, num1);
          if (\u0099\u0082.\u001D\u008B((object) this))
          {
            \u0011\u001F obj2 = \u0011\u001F.\u007E\u0097\u0089;
            CreateParams createParams3 = createParams1;
            int num2 = createParams3.Style | 131072;
            obj2((object) createParams3, num2);
          }
          else
          {
            \u0011\u001F obj2 = \u0011\u001F.\u007E\u0097\u0089;
            CreateParams createParams3 = createParams1;
            int num2 = createParams3.Style & -131073;
            obj2((object) createParams3, num2);
          }
          if (\u0099\u0082.\u001B\u008B((object) this))
          {
            \u0011\u001F obj2 = \u0011\u001F.\u007E\u0097\u0089;
            CreateParams createParams3 = createParams1;
            int num2 = createParams3.Style | 65536;
            obj2((object) createParams3, num2);
          }
          else
          {
            \u0011\u001F obj2 = \u0011\u001F.\u007E\u0097\u0089;
            CreateParams createParams3 = createParams1;
            int num2 = createParams3.Style & -65537;
            obj2((object) createParams3, num2);
          }
        }
        return createParams1;
      }
    }

    public \u0019(bool enableCloseButton)
    {
      this.EnableCloseButton = enableCloseButton;
    }

    public \u0019()
      : this(true)
    {
    }

    protected void \u001D\u0005()
    {
      \u001C obj = (\u001C) \u000E.\u001D\u0005(\u0088\u0086.\u0097\u0083((object) this), \u0012.\u0005);
      if (!\u0095\u001C.\u0099\u0091((object) obj, (Enum) \u001C.\u0008))
        \u000E.\u001D\u0005(\u0088\u0086.\u0097\u0083((object) this), \u0012.\u0005, (int) (obj | \u001C.\u0008));
      Bitmap bitmap = new Bitmap(\u0005\u0081.\u0083\u0084((object) this), \u0005\u0081.\u0098\u0083((object) this));
      try
      {
        Graphics gr = \u0005\u0087.\u001D\u007F((Image) bitmap);
        try
        {
          this.\u001D\u0005(gr);
        }
        finally
        {
          if (gr != null)
            \u001A\u001E.\u007E\u0094\u0092((object) gr);
        }
        \u0013.\u001D\u0005(\u0088\u0086.\u0097\u0083((object) this), \u008E\u0084.\u0017\u008B((object) this), \u0083\u001E.\u0081\u008B((object) this), bitmap);
      }
      finally
      {
        if (bitmap != null)
          \u001A\u001E.\u007E\u0094\u0092((object) bitmap);
      }
    }

    protected virtual void \u001D\u0005(Graphics gr)
    {
    }

    protected override void Dispose(bool disposing)
    {
      \u0019.\u0001.Remove(this);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    protected override void OnShown(EventArgs e)
    {
      \u0019.\u0001.Add(this);
      this.FormClosing += (FormClosingEventHandler) ((obj, args) =>
      {
        if (\u009A\u001E.\u007E\u009D\u008B((object) args) != CloseReason.WindowsShutDown || \u0099\u0082.\u007E\u0086\u0001\u0002((object) args) || \u0019.\u0080\u0005())
          return;
        \u0099\u001F.\u007E\u0087\u0001\u0002((object) args, true);
      });
      \u0088\u001C.\u0098\u008B((object) this, e);
    }

    private static bool \u0080\u0005()
    {
      \u0018.\u0015 e = new \u0018.\u0015();
      IEnumerator<\u0019> enumerator = \u0019.\u0001.LiveList.GetEnumerator();
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0019.\u0001 obj1 = new \u0019.\u0001();
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001 = enumerator.Current;
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001.\u001D\u0005(e);
          if (e.Cancel)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            \u0019.\u0002 obj2 = new \u0019.\u0002();
            // ISSUE: reference to a compiler-generated field
            obj2.\u0001 = obj1;
            \u0081 obj3 = \u0015\u007F.\u009A\u0095().\u001D\u0005();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            obj2.\u0001 = !\u008F\u0084.\u009E\u0092(e.CancelReason) && (obj3 <= \u0081.\u0001 || obj3 >= \u0081.\u0016) && \u000E.\u001D\u0005(\u0088\u0086.\u007E\u0097\u0083((object) obj1.\u0001), e.CancelReason);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            \u0096\u001C.\u007E\u008D\u008B((object) obj1.\u0001, new FormClosedEventHandler(obj2.\u001D\u0005));
            return false;
          }
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      return true;
    }

    protected virtual void \u001D\u0005(\u0018.\u0015 e)
    {
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      if (this.CustomPainting && this.UseOpacity && !\u0099\u0082.\u0081\u0001\u0002((object) this))
        goto label_2;
label_1:
      \u0088\u001C.\u0018\u0086((object) this, e);
      return;
label_2:
      this.\u001D\u0005();
      goto label_1;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      if (!this.CustomPainting)
        \u0092\u001C.\u0097\u008B((object) this, e);
      else if (this.UseOpacity && !\u0099\u0082.\u0081\u0001\u0002((object) this))
        this.\u001D\u0005();
      else
        this.\u001D\u0005(\u0004\u007F.\u007E\u0092\u0086((object) e));
    }

    protected override void OnLoad(EventArgs e)
    {
      if (this.UseOpacity && this.CustomPainting && !\u0099\u0082.\u0081\u0001\u0002((object) this))
        goto label_2;
label_1:
      \u0088\u001C.\u0096\u008B((object) this, e);
      return;
label_2:
      this.\u001D\u0005();
      goto label_1;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      if (this.\u0002 && !\u0099\u0082.\u0081\u0001\u0002((object) this))
        goto label_2;
label_1:
      \u001E\u001C.\u0012\u0086((object) this, e);
      return;
label_2:
      this.\u0003 = true;
      this.\u0001 = \u008E\u0084.\u007E\u0090\u008A((object) e);
      goto label_1;
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      if (this.\u0002)
        goto label_2;
label_1:
      \u001E\u001C.\u0016\u0086((object) this, e);
      return;
label_2:
      this.\u0003 = false;
      goto label_1;
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      if (this.\u0002 && this.\u0003)
        \u0096\u0086.\u0018\u008B((object) this, new Point(\u008E\u0084.\u0017\u008B((object) this).X + (\u0005\u0081.\u007E\u008D\u008A((object) e) - this.\u0001.X), \u008E\u0084.\u0017\u008B((object) this).Y + (\u0005\u0081.\u007E\u008E\u008A((object) e) - this.\u0001.Y)));
      \u001E\u001C.\u0015\u0086((object) this, e);
    }

    protected override void OnLostFocus(EventArgs e)
    {
      if (this.\u0002)
        goto label_2;
label_1:
      \u0088\u001C.\u0011\u0086((object) this, e);
      return;
label_2:
      this.\u0003 = false;
      goto label_1;
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected override void WndProc(ref Message m)
    {
      if (m.Msg == 126)
        \u001A\u001E.\u001D\u0086((object) this);
      \u0015\u0084.\u009B\u008B((object) this, ref m);
    }
  }
}
