// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace \u0082
{
  internal sealed class \u0005 : System.Windows.Forms.Button
  {
    private static readonly int \u0001 = 14;
    private static readonly int \u0002 = \u008F\u0080.\u001D\u008F().Width * 2;
    private PushButtonState \u0001;
    private bool \u0001;
    private Rectangle \u0001;
    private bool \u0002;
    private bool \u0003;
    private ContextMenuStrip \u0001;
    private ContextMenu \u0001;
    private TextFormatFlags \u0001;
    private bool \u0004;

    [Browsable(false)]
    public override ContextMenuStrip ContextMenuStrip
    {
      get
      {
        return this.SplitMenuStrip;
      }
      set
      {
        this.SplitMenuStrip = value;
      }
    }

    [DefaultValue(null)]
    public ContextMenu SplitMenu
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (this.\u0001 != null)
          \u0087\u007F.\u007E\u0014\u0089((object) this.\u0001, new EventHandler((object) this, __methodptr(\u001D\u0005)));
        if (value == null)
          this.ShowSplit = false;
        else
          goto label_5;
label_3:
        this.\u0001 = value;
        return;
label_5:
        this.ShowSplit = true;
        \u0087\u007F.\u007E\u0013\u0089((object) value, new EventHandler((object) this, __methodptr(\u001D\u0005)));
        goto label_3;
      }
    }

    [DefaultValue(null)]
    public ContextMenuStrip SplitMenuStrip
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (this.\u0001 != null)
        {
          \u001F\u001D.\u007E\u001A\u0089((object) this.\u0001, new ToolStripDropDownClosingEventHandler((object) this, __methodptr(\u001D\u0005)));
          \u0016\u007F.\u007E\u001C\u0089((object) this.\u0001, new CancelEventHandler((object) this, __methodptr(\u001D\u0005)));
        }
        if (value == null)
          this.ShowSplit = false;
        else
          goto label_5;
label_3:
        this.\u0001 = value;
        return;
label_5:
        this.ShowSplit = true;
        \u001F\u001D.\u007E\u0019\u0089((object) value, new ToolStripDropDownClosingEventHandler(this.\u001D\u0005));
        \u0016\u007F.\u007E\u001B\u0089((object) value, new CancelEventHandler(this.\u001D\u0005));
        goto label_3;
      }
    }

    [DefaultValue(false)]
    public bool ShowSplit
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if (value == this.\u0002)
          return;
        this.\u0002 = value;
        \u001A\u001E.\u0004\u0086((object) this);
        if (\u0003\u001E.\u0011\u0084((object) this) == null)
          return;
        \u001A\u001E.\u007E\u0019\u0086((object) \u0003\u001E.\u0011\u0084((object) this));
      }
    }

    [DefaultValue(PushButtonState.Normal)]
    private PushButtonState State
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (\u0013\u0080.\u007E\u0088\u0091((object) this.\u0001, (object) value))
          return;
        this.\u0001 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public \u0005()
    {
      \u0099\u001F.\u007E\u001B\u0083((object) this, true);
    }

    protected override bool IsInputKey(Keys keyData)
    {
      if (\u0013\u0080.\u007E\u0088\u0091((object) keyData, (object) Keys.Down) && this.\u0002)
        return true;
      return \u0012\u001D.\u0007\u0086((object) this, keyData);
    }

    protected override void OnGotFocus(EventArgs e)
    {
      if (!this.\u0002)
      {
        \u0088\u001C.\u008F\u0087((object) this, e);
      }
      else
      {
        if (\u0013\u0080.\u007E\u0088\u0091((object) this.State, (object) PushButtonState.Pressed) || \u0013\u0080.\u007E\u0088\u0091((object) this.State, (object) PushButtonState.Disabled))
          return;
        this.State = PushButtonState.Default;
      }
    }

    protected override void OnKeyDown(KeyEventArgs kevent)
    {
      if (this.\u0002)
      {
        if (!\u0013\u0080.\u007E\u0088\u0091((object) \u007F\u0081.\u007E\u0013\u008C((object) kevent), (object) Keys.Down) || this.\u0003)
        {
          if (\u0013\u0080.\u007E\u0088\u0091((object) \u007F\u0081.\u007E\u0013\u008C((object) kevent), (object) Keys.Space) && \u007F\u0081.\u007E\u0014\u008C((object) kevent) == Keys.None)
            this.State = PushButtonState.Pressed;
        }
        else
          this.\u001D\u0005();
      }
      \u0084\u0086.\u0094\u0087((object) this, kevent);
    }

    protected override void OnKeyUp(KeyEventArgs kevent)
    {
      if (\u0013\u0080.\u007E\u0088\u0091((object) \u007F\u0081.\u007E\u0013\u008C((object) kevent), (object) Keys.Space))
      {
        if (\u0091\u0086.\u000E\u0084() == MouseButtons.None)
          this.State = PushButtonState.Normal;
      }
      else if (\u0013\u0080.\u007E\u0088\u0091((object) \u007F\u0081.\u007E\u0013\u008C((object) kevent), (object) Keys.Apps) && \u0091\u0086.\u000E\u0084() == MouseButtons.None && !this.\u0003)
        this.\u001D\u0005();
      \u0084\u0086.\u0095\u0087((object) this, kevent);
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
      this.State = \u0099\u0082.\u008E\u0083((object) this) ? PushButtonState.Normal : PushButtonState.Disabled;
      \u0088\u001C.\u0093\u0087((object) this, e);
    }

    protected override void OnLostFocus(EventArgs e)
    {
      if (!this.\u0002)
      {
        \u0088\u001C.\u0090\u0087((object) this, e);
      }
      else
      {
        if (\u0013\u0080.\u007E\u0088\u0091((object) this.State, (object) PushButtonState.Pressed) || \u0013\u0080.\u007E\u0088\u0091((object) this.State, (object) PushButtonState.Disabled))
          return;
        this.State = PushButtonState.Normal;
      }
    }

    protected override void OnMouseEnter(EventArgs e)
    {
      if (!this.\u0002)
      {
        \u0088\u001C.\u009A\u0087((object) this, e);
      }
      else
      {
        this.\u0004 = true;
        if (\u0013\u0080.\u007E\u0088\u0091((object) this.State, (object) PushButtonState.Pressed) || \u0013\u0080.\u007E\u0088\u0091((object) this.State, (object) PushButtonState.Disabled))
          return;
        this.State = PushButtonState.Hot;
      }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      if (!this.\u0002)
      {
        \u0088\u001C.\u009B\u0087((object) this, e);
      }
      else
      {
        this.\u0004 = false;
        if (\u0013\u0080.\u007E\u0088\u0091((object) this.State, (object) PushButtonState.Pressed) || \u0013\u0080.\u007E\u0088\u0091((object) this.State, (object) PushButtonState.Disabled))
          return;
        this.State = \u0099\u0082.\u007E\u0091\u0083((object) this) ? PushButtonState.Default : PushButtonState.Normal;
      }
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      if (!this.\u0002)
      {
        \u001E\u001C.\u0091\u0087((object) this, e);
      }
      else
      {
        if (this.\u0001 != null && (\u0094\u0080.\u007E\u008C\u008A((object) e) == MouseButtons.Left && !this.\u0004))
          goto label_6;
label_2:
        if (this.\u0001.Contains(\u008E\u0084.\u007E\u0090\u008A((object) e)) && !this.\u0003 && \u0094\u0080.\u007E\u008C\u008A((object) e) == MouseButtons.Left)
        {
          this.\u001D\u0005();
          return;
        }
        this.State = PushButtonState.Pressed;
        return;
label_6:
        this.\u0001 = true;
        goto label_2;
      }
    }

    protected override void OnMouseUp(MouseEventArgs mevent)
    {
      if (!this.\u0002)
        \u001E\u001C.\u009C\u0087((object) this, mevent);
      else if (\u0094\u0080.\u007E\u008C\u008A((object) mevent) == MouseButtons.Right && (\u008D\u0084.\u0082\u0083((object) this).Contains(\u008E\u0084.\u007E\u0090\u008A((object) mevent)) && !this.\u0003))
      {
        this.\u001D\u0005();
      }
      else
      {
        if ((this.\u0001 != null || this.\u0001 != null) && this.\u0003)
          return;
        this.\u001E\u0005();
        if (!\u008D\u0084.\u0082\u0083((object) this).Contains(\u008E\u0084.\u007E\u0090\u008A((object) mevent)) || this.\u0001.Contains(\u008E\u0084.\u007E\u0090\u008A((object) mevent)))
          return;
        \u0088\u001C.\u007E\u000E\u0086((object) this, EventArgs.Empty);
      }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
      \u0092\u001C.\u0096\u0087((object) this, pevent);
      if (!this.\u0002)
        return;
      Graphics g = \u0004\u007F.\u007E\u0092\u0086((object) pevent);
      Rectangle rectangle1 = \u008D\u0084.\u0082\u0083((object) this);
      if (this.State != PushButtonState.Pressed && \u0099\u0082.\u0084\u0087((object) this) && !\u000F\u0080.\u0007\u0083())
      {
        Rectangle rectangle2 = rectangle1;
        rectangle2.Inflate(-1, -1);
        \u0087\u0082.\u009E\u0087(g, rectangle2, this.State);
        \u009A\u001B.\u007E\u008E\u007F((object) g, \u0012\u001E.\u001E\u0081(), 0, 0, rectangle1.Width - 1, rectangle1.Height - 1);
      }
      else
        \u0087\u0082.\u009E\u0087(g, rectangle1, this.State);
      this.\u0001 = new Rectangle(rectangle1.Right - \u0005.\u0001, 0, \u0005.\u0001, rectangle1.Height);
      int num = \u0005.\u0002;
      Rectangle rectangle3 = new Rectangle(num - 1, num - 1, rectangle1.Width - this.\u0001.Width - num, rectangle1.Height - num * 2 + 2);
      if (\u0011\u0086.\u007E\u0016\u0084((object) this) == RightToLeft.Yes)
      {
        this.\u0001.X = rectangle1.Left + 1;
        rectangle3.X = this.\u0001.Right;
        \u009A\u001B.\u007E\u008A\u007F((object) g, \u0012\u001E.\u001D\u0081(), rectangle1.Left + \u0005.\u0001, \u0005.\u0002, rectangle1.Left + \u0005.\u0001, rectangle1.Bottom - \u0005.\u0002);
        \u009A\u001B.\u007E\u008A\u007F((object) g, \u0012\u001E.\u001C\u0081(), rectangle1.Left + \u0005.\u0001 + 1, \u0005.\u0002, rectangle1.Left + \u0005.\u0001 + 1, rectangle1.Bottom - \u0005.\u0002);
      }
      else
      {
        \u009A\u001B.\u007E\u008A\u007F((object) g, \u0012\u001E.\u001D\u0081(), rectangle1.Right - \u0005.\u0001, \u0005.\u0002, rectangle1.Right - \u0005.\u0001, rectangle1.Bottom - \u0005.\u0002);
        \u009A\u001B.\u007E\u008A\u007F((object) g, \u0012\u001E.\u001C\u0081(), rectangle1.Right - \u0005.\u0001 - 1, \u0005.\u0002, rectangle1.Right - \u0005.\u0001 - 1, rectangle1.Bottom - \u0005.\u0002);
      }
      this.\u001E\u0005(g, this.\u0001);
      this.\u001D\u0005(g, new Rectangle(0, 0, \u008D\u0084.\u0082\u0083((object) this).Width - \u0005.\u0001, \u008D\u0084.\u0082\u0083((object) this).Height));
      if (this.State == PushButtonState.Pressed || !\u0099\u0082.\u007E\u0091\u0083((object) this) || !\u0099\u0082.\u007E\u0080\u0084((object) this))
        return;
      \u009C\u001D.\u0090\u0089(g, rectangle3);
    }

    private void \u001D\u0005(Graphics g, Rectangle bounds)
    {
      Rectangle textRectangle;
      Rectangle imageRectangle;
      this.\u001D\u0005(ref bounds, out textRectangle, out imageRectangle);
      if (\u000E\u0086.\u0087\u0087((object) this) != null)
      {
        if (\u0099\u0082.\u008E\u0083((object) this))
          \u009B\u001F.\u007E\u009F\u007F((object) g, \u000E\u0086.\u0087\u0087((object) this), imageRectangle.X, imageRectangle.Y, \u0005\u0081.\u007E\u007F\u001F((object) \u000E\u0086.\u0087\u0087((object) this)), \u0005\u0081.\u007E\u0080\u001F((object) \u000E\u0086.\u0087\u0087((object) this)));
        else
          \u0093\u001F.\u0091\u0089(g, \u000E\u0086.\u0087\u0087((object) this), imageRectangle.X, imageRectangle.Y, \u0091\u0084.\u007E\u001C\u0083((object) this));
      }
      if (!\u0099\u0082.\u008E\u0087((object) this))
        this.\u0001 = this.\u0001 | TextFormatFlags.NoPrefix;
      else if (!\u0099\u0082.\u007E\u007F\u0084((object) this))
        this.\u0001 = this.\u0001 | TextFormatFlags.HidePrefix;
      if (\u008F\u0084.\u009E\u0092(\u0002\u007F.\u007E\u001C\u0084((object) this)))
        return;
      if (\u0099\u0082.\u008E\u0083((object) this))
        \u0096\u0082.\u0010\u0091((IDeviceContext) g, \u0002\u007F.\u007E\u001C\u0084((object) this), \u0080\u0084.\u007E\u0092\u0083((object) this), textRectangle, \u0091\u0084.\u007E\u0094\u0083((object) this), this.\u0001);
      else
        \u001C\u0080.\u0093\u0089((IDeviceContext) g, \u0002\u007F.\u007E\u001C\u0084((object) this), \u0080\u0084.\u007E\u0092\u0083((object) this), \u0091\u0084.\u007E\u001C\u0083((object) this), textRectangle, this.\u0001);
    }

    private void \u001E\u0005(Graphics g, Rectangle dropDownRect)
    {
      Point point = new Point(\u000F\u0081.\u0018\u0095(dropDownRect.Left + dropDownRect.Width / 2), \u000F\u0081.\u0018\u0095(dropDownRect.Top + dropDownRect.Height / 2));
      point.X += dropDownRect.Width % 2;
      Point[] pointArray = new Point[3]{ new Point(point.X - 2, point.Y - 1), new Point(point.X + 3, point.Y - 1), new Point(point.X, point.Y + 2) };
      if (\u0099\u0082.\u008E\u0083((object) this))
        \u0005\u001F.\u007E\u0095\u007F((object) g, \u0017\u001E.\u0014\u0081(), pointArray);
      else
        \u0005\u001F.\u007E\u0095\u007F((object) g, \u0017\u001E.\u0013\u0081(), pointArray);
    }

    public override Size GetPreferredSize(Size proposedSize)
    {
      Size size = \u009A\u0082.\u0092\u0087((object) this, proposedSize);
      if (this.\u0002)
      {
        if (\u0099\u0082.\u007E\u001A\u0083((object) this))
          return this.\u001D\u0005();
        if (!\u008F\u0084.\u009E\u0092(\u0002\u007F.\u007E\u001C\u0084((object) this)) && \u0098\u001D.\u0011\u0091(\u0002\u007F.\u007E\u001C\u0084((object) this), \u0080\u0084.\u007E\u0092\u0083((object) this)).Width + \u0005.\u0001 > size.Width)
          return \u0003\u0086.\u0003\u0081(size, new Size(\u0005.\u0001 + \u0005.\u0002 * 2, 0));
      }
      return size;
    }

    private Size \u001D\u0005()
    {
      Size size1 = Size.Empty;
      Size size2 = \u0098\u001D.\u0011\u0091(\u0002\u007F.\u007E\u001C\u0084((object) this), \u0080\u0084.\u007E\u0092\u0083((object) this));
      Size size3 = \u000E\u0086.\u0087\u0087((object) this) == null ? Size.Empty : \u0083\u001E.\u007E\u001F\u001F((object) \u000E\u0086.\u0087\u0087((object) this));
      if (\u0005\u0081.\u007E\u0001\u0093((object) \u0002\u007F.\u007E\u001C\u0084((object) this)) != 0)
      {
        size2.Height += 4;
        size2.Width += 4;
      }
      switch (\u0094\u001F.\u008D\u0087((object) this))
      {
        case TextImageRelation.Overlay:
          size1.Height = Math.Max(\u0005\u0081.\u007E\u0001\u0093((object) \u0002\u007F.\u007E\u001C\u0084((object) this)) == 0 ? 0 : size2.Height, size3.Height);
          size1.Width = \u0099\u0081.\u009E\u0096(size2.Width, size3.Width);
          break;
        case TextImageRelation.ImageAboveText:
        case TextImageRelation.TextAboveImage:
          size1.Height = size2.Height + size3.Height;
          size1.Width = \u0099\u0081.\u009E\u0096(size2.Width, size3.Width);
          break;
        case TextImageRelation.ImageBeforeText:
        case TextImageRelation.TextBeforeImage:
          size1.Height = \u0099\u0081.\u009E\u0096(size2.Height, size3.Height);
          size1.Width = size2.Width + size3.Width;
          break;
      }
      size1.Height += \u0097\u0086.\u0088\u0084((object) this).Vertical + 6;
      size1.Width += \u0097\u0086.\u0088\u0084((object) this).Horizontal + 6;
      if (this.\u0002)
        size1.Width += \u0005.\u0001;
      return size1;
    }

    private void \u001D\u0005(ref Rectangle content_rect, out Rectangle textRectangle, out Rectangle imageRectangle)
    {
      Size sizeOfObject1 = \u0083\u001F.\u0012\u0091(\u0002\u007F.\u007E\u001C\u0084((object) this), \u0080\u0084.\u007E\u0092\u0083((object) this), content_rect.Size, this.\u0001);
      Size sizeOfObject2 = \u000E\u0086.\u0087\u0087((object) this) == null ? Size.Empty : \u0083\u001E.\u007E\u001F\u001F((object) \u000E\u0086.\u0087\u0087((object) this));
      textRectangle = Rectangle.Empty;
      imageRectangle = Rectangle.Empty;
      switch (\u0094\u001F.\u008D\u0087((object) this))
      {
        case TextImageRelation.Overlay:
          textRectangle = \u0005.\u001D\u0005(ref content_rect, ref sizeOfObject1, \u0089\u001E.\u007E\u008B\u0087((object) this));
          if (this.\u0001 == PushButtonState.Pressed && !\u000F\u0080.\u0007\u0083())
            textRectangle.Offset(1, 1);
          if (\u000E\u0086.\u0087\u0087((object) this) == null)
            break;
          imageRectangle = \u0005.\u001D\u0005(ref content_rect, ref sizeOfObject2, \u0089\u001E.\u0089\u0087((object) this));
          break;
        case TextImageRelation.ImageAboveText:
          content_rect.Inflate(-4, -4);
          this.\u001E\u0005(content_rect, false, sizeOfObject1, sizeOfObject2, out textRectangle, out imageRectangle);
          break;
        case TextImageRelation.TextAboveImage:
          content_rect.Inflate(-4, -4);
          this.\u001E\u0005(content_rect, true, sizeOfObject1, sizeOfObject2, out textRectangle, out imageRectangle);
          break;
        case TextImageRelation.ImageBeforeText:
          content_rect.Inflate(-4, -4);
          this.\u001D\u0005(content_rect, false, sizeOfObject1, sizeOfObject2, out textRectangle, out imageRectangle);
          break;
        case TextImageRelation.TextBeforeImage:
          content_rect.Inflate(-4, -4);
          this.\u001D\u0005(content_rect, true, sizeOfObject1, sizeOfObject2, out textRectangle, out imageRectangle);
          break;
      }
    }

    private static Rectangle \u001D\u0005(ref Rectangle container, ref Size sizeOfObject, System.Drawing.ContentAlignment alignment)
    {
      int x;
      int y;
      switch (alignment)
      {
        case System.Drawing.ContentAlignment.BottomCenter:
          x = (container.Width - sizeOfObject.Width) / 2;
          y = container.Height - sizeOfObject.Height - 4;
          break;
        case System.Drawing.ContentAlignment.BottomRight:
          x = container.Width - sizeOfObject.Width - 4;
          y = container.Height - sizeOfObject.Height - 4;
          break;
        case System.Drawing.ContentAlignment.MiddleRight:
          x = container.Width - sizeOfObject.Width - 4;
          y = (container.Height - sizeOfObject.Height) / 2;
          break;
        case System.Drawing.ContentAlignment.BottomLeft:
          x = 4;
          y = container.Height - sizeOfObject.Height - 4;
          break;
        case System.Drawing.ContentAlignment.TopLeft:
          x = 4;
          y = 4;
          break;
        case System.Drawing.ContentAlignment.TopCenter:
          x = (container.Width - sizeOfObject.Width) / 2;
          y = 4;
          break;
        case System.Drawing.ContentAlignment.TopRight:
          x = container.Width - sizeOfObject.Width - 4;
          y = 4;
          break;
        case System.Drawing.ContentAlignment.MiddleLeft:
          x = 4;
          y = (container.Height - sizeOfObject.Height) / 2;
          break;
        case System.Drawing.ContentAlignment.MiddleCenter:
          x = (container.Width - sizeOfObject.Width) / 2;
          y = (container.Height - sizeOfObject.Height) / 2;
          break;
        default:
          x = 4;
          y = 4;
          break;
      }
      return new Rectangle(x, y, sizeOfObject.Width, sizeOfObject.Height);
    }

    private void \u001D\u0005(Rectangle totalArea, bool textFirst, Size textSize, Size imageSize, out Rectangle textRect, out Rectangle imageRect)
    {
      int num1 = 0;
      int num2 = textSize.Width + num1 + imageSize.Width;
      if (!textFirst)
        num1 += 2;
      if (num2 > totalArea.Width)
      {
        textSize.Width = totalArea.Width - num1 - imageSize.Width;
        num2 = totalArea.Width;
      }
      int num3 = totalArea.Width - num2;
      int num4 = 0;
      HorizontalAlignment horizontalAlignment1 = \u0005.\u001D\u0005(\u0089\u001E.\u007E\u008B\u0087((object) this));
      HorizontalAlignment horizontalAlignment2 = \u0005.\u001D\u0005(\u0089\u001E.\u0089\u0087((object) this));
      int num5 = horizontalAlignment2 != HorizontalAlignment.Left ? (horizontalAlignment2 != HorizontalAlignment.Right || horizontalAlignment1 != HorizontalAlignment.Right ? (horizontalAlignment2 != HorizontalAlignment.Center || horizontalAlignment1 != HorizontalAlignment.Left && horizontalAlignment1 != HorizontalAlignment.Center ? num4 + 2 * (num3 / 3) : num4 + num3 / 3) : num3) : 0;
      Rectangle rectangle1;
      Rectangle rectangle2;
      if (textFirst)
      {
        rectangle1 = new Rectangle(totalArea.Left + num5, \u0005.\u001D\u0005(totalArea, textSize, \u0089\u001E.\u007E\u008B\u0087((object) this)).Top, textSize.Width, textSize.Height);
        rectangle2 = new Rectangle(rectangle1.Right + num1, \u0005.\u001D\u0005(totalArea, imageSize, \u0089\u001E.\u0089\u0087((object) this)).Top, imageSize.Width, imageSize.Height);
      }
      else
      {
        rectangle2 = new Rectangle(totalArea.Left + num5, \u0005.\u001D\u0005(totalArea, imageSize, \u0089\u001E.\u0089\u0087((object) this)).Top, imageSize.Width, imageSize.Height);
        rectangle1 = new Rectangle(rectangle2.Right + num1, \u0005.\u001D\u0005(totalArea, textSize, \u0089\u001E.\u007E\u008B\u0087((object) this)).Top, textSize.Width, textSize.Height);
      }
      textRect = rectangle1;
      imageRect = rectangle2;
    }

    private void \u001E\u0005(Rectangle totalArea, bool textFirst, Size textSize, Size imageSize, out Rectangle textRect, out Rectangle imageRect)
    {
      int num1 = 0;
      int num2 = textSize.Height + num1 + imageSize.Height;
      if (textFirst)
        goto label_10;
label_1:
      if (textSize.Width > totalArea.Width)
        textSize.Width = totalArea.Width;
      if (num2 > totalArea.Height && textFirst)
      {
        imageSize = Size.Empty;
        num2 = totalArea.Height;
      }
      int num3 = totalArea.Height - num2;
      int num4 = 0;
      VerticalAlignment verticalAlignment1 = \u0005.\u001D\u0005(\u0089\u001E.\u007E\u008B\u0087((object) this));
      VerticalAlignment verticalAlignment2 = \u0005.\u001D\u0005(\u0089\u001E.\u0089\u0087((object) this));
      int num5 = verticalAlignment2 != VerticalAlignment.Top ? (verticalAlignment2 != VerticalAlignment.Bottom || verticalAlignment1 != VerticalAlignment.Bottom ? (verticalAlignment2 != VerticalAlignment.Center || verticalAlignment1 != VerticalAlignment.Top && verticalAlignment1 != VerticalAlignment.Center ? num4 + 2 * (num3 / 3) : num4 + num3 / 3) : num3) : 0;
      Rectangle rectangle1;
      Rectangle rectangle2;
      if (textFirst)
      {
        rectangle1 = new Rectangle(\u0005.\u001D\u0005(totalArea, textSize, \u0089\u001E.\u007E\u008B\u0087((object) this)).Left, totalArea.Top + num5, textSize.Width, textSize.Height);
        rectangle2 = new Rectangle(\u0005.\u001D\u0005(totalArea, imageSize, \u0089\u001E.\u0089\u0087((object) this)).Left, rectangle1.Bottom + num1, imageSize.Width, imageSize.Height);
      }
      else
      {
        rectangle2 = new Rectangle(\u0005.\u001D\u0005(totalArea, imageSize, \u0089\u001E.\u0089\u0087((object) this)).Left, totalArea.Top + num5, imageSize.Width, imageSize.Height);
        rectangle1 = new Rectangle(\u0005.\u001D\u0005(totalArea, textSize, \u0089\u001E.\u007E\u008B\u0087((object) this)).Left, rectangle2.Bottom + num1, textSize.Width, textSize.Height);
        if (rectangle1.Bottom > totalArea.Bottom)
          rectangle1.Y = totalArea.Top;
      }
      textRect = rectangle1;
      imageRect = rectangle2;
      return;
label_10:
      num1 += 2;
      goto label_1;
    }

    private static HorizontalAlignment \u001D\u0005(System.Drawing.ContentAlignment align)
    {
      switch (align)
      {
        case System.Drawing.ContentAlignment.BottomCenter:
        case System.Drawing.ContentAlignment.TopCenter:
        case System.Drawing.ContentAlignment.MiddleCenter:
          return HorizontalAlignment.Center;
        case System.Drawing.ContentAlignment.BottomRight:
        case System.Drawing.ContentAlignment.MiddleRight:
        case System.Drawing.ContentAlignment.TopRight:
          return HorizontalAlignment.Right;
        case System.Drawing.ContentAlignment.BottomLeft:
        case System.Drawing.ContentAlignment.TopLeft:
        case System.Drawing.ContentAlignment.MiddleLeft:
          return HorizontalAlignment.Left;
        default:
          return HorizontalAlignment.Left;
      }
    }

    private static VerticalAlignment \u001D\u0005(System.Drawing.ContentAlignment align)
    {
      System.Drawing.ContentAlignment contentAlignment = align;
      if (contentAlignment > System.Drawing.ContentAlignment.MiddleCenter)
        goto label_8;
      else
        goto label_6;
label_3:
      return VerticalAlignment.Center;
label_5:
      return VerticalAlignment.Top;
label_6:
      switch (contentAlignment - 1)
      {
        case (System.Drawing.ContentAlignment) 0:
        case System.Drawing.ContentAlignment.TopLeft:
        case System.Drawing.ContentAlignment.TopLeft | System.Drawing.ContentAlignment.TopCenter:
          return VerticalAlignment.Top;
        case System.Drawing.ContentAlignment.TopCenter:
          goto label_5;
        default:
          if (contentAlignment == System.Drawing.ContentAlignment.MiddleLeft || contentAlignment == System.Drawing.ContentAlignment.MiddleCenter)
            goto label_3;
          else
            goto label_5;
      }
label_8:
      if (contentAlignment > System.Drawing.ContentAlignment.BottomLeft)
      {
        if (contentAlignment != System.Drawing.ContentAlignment.BottomCenter && contentAlignment != System.Drawing.ContentAlignment.BottomRight)
          goto label_5;
      }
      else
        goto label_9;
label_4:
      return VerticalAlignment.Bottom;
label_9:
      if (contentAlignment != System.Drawing.ContentAlignment.MiddleRight)
      {
        if (contentAlignment == System.Drawing.ContentAlignment.BottomLeft)
          goto label_4;
        else
          goto label_5;
      }
      else
        goto label_3;
    }

    public static Rectangle \u001D\u0005(Rectangle outer, Size inner, System.Drawing.ContentAlignment align)
    {
      int x = 0;
      int y = 0;
      if (align == System.Drawing.ContentAlignment.BottomLeft || align == System.Drawing.ContentAlignment.MiddleLeft || align == System.Drawing.ContentAlignment.TopLeft)
        x = outer.X;
      else
        goto label_12;
label_5:
      if (align == System.Drawing.ContentAlignment.TopCenter || align == System.Drawing.ContentAlignment.TopLeft || align == System.Drawing.ContentAlignment.TopRight)
        y = outer.Y;
      else if (align == System.Drawing.ContentAlignment.MiddleCenter || align == System.Drawing.ContentAlignment.MiddleLeft || align == System.Drawing.ContentAlignment.MiddleRight)
        y = outer.Y + (outer.Height - inner.Height) / 2;
      else if (align == System.Drawing.ContentAlignment.BottomCenter || align == System.Drawing.ContentAlignment.BottomRight || align == System.Drawing.ContentAlignment.BottomLeft)
        y = outer.Bottom - inner.Height;
      return new Rectangle(x, y, \u0099\u0081.\u009F\u0096(inner.Width, outer.Width), \u0099\u0081.\u009F\u0096(inner.Height, outer.Height));
label_12:
      if (align == System.Drawing.ContentAlignment.BottomCenter || (align == System.Drawing.ContentAlignment.MiddleCenter || align == System.Drawing.ContentAlignment.TopCenter))
      {
        x = \u0099\u0081.\u009E\u0096(outer.X + (outer.Width - inner.Width) / 2, outer.Left);
        goto label_5;
      }
      else if (align == System.Drawing.ContentAlignment.BottomRight || align == System.Drawing.ContentAlignment.MiddleRight || align == System.Drawing.ContentAlignment.TopRight)
      {
        x = outer.Right - inner.Width;
        goto label_5;
      }
      else
        goto label_5;
    }

    private void \u001D\u0005()
    {
      if (this.\u0001)
      {
        this.\u0001 = false;
      }
      else
      {
        this.State = PushButtonState.Pressed;
        if (this.\u0001 != null)
        {
          \u008A\u001D.\u007E\u0015\u0089((object) this.\u0001, (Control) this, new Point(0, \u0005\u0081.\u0098\u0083((object) this)));
        }
        else
        {
          if (this.\u0001 == null)
            return;
          \u0094\u001D.\u007E\u008A\u0089((object) this.\u0001, (Control) this, new Point(0, \u0005\u0081.\u0098\u0083((object) this)), ToolStripDropDownDirection.BelowRight);
        }
      }
    }

    private void \u001D\u0005(object sender, CancelEventArgs e)
    {
      this.\u0003 = true;
    }

    private void \u001D\u0005(object sender, ToolStripDropDownClosingEventArgs e)
    {
      this.\u0003 = false;
      this.\u001E\u0005();
      if (\u0003\u0081.\u007E\u0086\u0090((object) e) != ToolStripDropDownCloseReason.AppClicked)
        return;
      this.\u0001 = this.\u0001.Contains(\u0098\u001B.\u001A\u0086((object) this, \u0098\u0080.\u009F\u0089())) && \u0091\u0086.\u000E\u0084() == MouseButtons.Left;
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0003 = true;
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected override void WndProc(ref Message m)
    {
      if (m.Msg == 530)
        goto label_2;
label_1:
      \u0015\u0084.\u009D\u0087((object) this, ref m);
      return;
label_2:
      this.\u0003 = false;
      this.\u001E\u0005();
      goto label_1;
    }

    private void \u001E\u0005()
    {
      if (!\u008D\u0084.\u0080\u0083((object) this).Contains(\u0098\u001B.\u007E\u001A\u0086((object) \u0003\u001E.\u0011\u0084((object) this), \u0098\u0080.\u009F\u0089())))
      {
        if (\u0099\u0082.\u007E\u0091\u0083((object) this))
          this.State = PushButtonState.Default;
        else if (!\u0099\u0082.\u008E\u0083((object) this))
          this.State = PushButtonState.Disabled;
        else
          this.State = PushButtonState.Normal;
      }
      else
        this.State = PushButtonState.Hot;
    }
  }
}
