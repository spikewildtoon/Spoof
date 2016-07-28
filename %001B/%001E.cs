// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0016;
using \u0019;
using \u001D;
using \u001E;
using \u001F;
using \u0080;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u001B
{
  internal sealed class \u001E : Control, \u0014.\u001D<\u001B.\u001E.\u0001>
  {
    private Dictionary<\u001B.\u001E.\u0001, Rectangle> \u0001;
    private \u0018.\u001B \u0001;
    private Font \u0001;
    private ToolTip \u0001;
    private IContainer \u0001;
    private \u001B.\u001E.\u0001 \u0001;
    private \u007F<\u001B.\u001E.\u0001, \u001B.\u001E> \u0001;

    [Editor(typeof (CollectionEditor), typeof (UITypeEditor))]
    [MergableProperty(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Category("Behavior")]
    [Description("Button Collection")]
    public \u007F<\u001B.\u001E.\u0001, \u001B.\u001E> Buttons
    {
      get
      {
        return this.\u0001;
      }
    }

    public \u0018.\u001B BackgroundPaint
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
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public bool ToolTipsEnabled
    {
      get
      {
        return \u0099\u0082.\u007E\u0096\u0090((object) this.\u0001);
      }
      set
      {
        if (\u0099\u0082.\u007E\u0096\u0090((object) this.\u0001) == value)
          return;
        \u0099\u001F.\u007E\u0097\u0090((object) this.\u0001, value);
        \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this, string.Empty);
      }
    }

    public Font TextFont
    {
      get
      {
        if (this.\u0001 == null)
          goto label_2;
label_1:
        return this.\u0001;
label_2:
        this.\u0001 = \u0080\u0084.\u007E\u0092\u0083((object) this);
        goto label_1;
      }
      set
      {
        if (this.\u0001 == value)
          return;
        this.\u0001 = value;
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public Color HoverStartColor { get; set; }

    public Color HoverEndColor { get; set; }

    public Color NormalStartColor { get; set; }

    public Color NormalEndColor { get; set; }

    public Color DisabledStartColor { get; set; }

    public Color DisabledEndColor { get; set; }

    public Color DownStartColor { get; set; }

    public Color DownEndColor { get; set; }

    public Color SelectedStartColor { get; set; }

    public Color SelectedEndColor { get; set; }

    public Color HoverRadialCenterColor { get; set; }

    public Color HoverRadialSurroundColor { get; set; }

    public Color SelectedRadialCenterColor { get; set; }

    public Color SelectedRadialSurroundColor { get; set; }

    public Color ButtonOutline { get; set; }

    public event EventHandler<\u0018.\u001D> ButtonClicked;

    public \u001E()
    {
      this.ButtonOutline = \u001B\u001C.\u0015\u007F(200, 0, 0, 0);
      this.HoverRadialCenterColor = \u008D\u001E.\u0016\u007F(200, \u009A\u0080.\u0005\u007F());
      this.HoverRadialSurroundColor = \u008D\u001E.\u0016\u007F(0, \u009A\u0080.\u0005\u007F());
      this.SelectedRadialCenterColor = \u008D\u001E.\u0016\u007F(200, \u009A\u0080.\u009F\u001F());
      this.SelectedRadialSurroundColor = \u008D\u001E.\u0016\u007F(0, \u009A\u0080.\u009F\u001F());
      this.HoverStartColor = \u008E\u001D.\u0017\u007F(248, 152, 152);
      this.HoverEndColor = \u008E\u001D.\u0017\u007F(157, 0, 18);
      this.NormalStartColor = \u008E\u001D.\u0017\u007F(76, 181, 248);
      this.NormalEndColor = \u008E\u001D.\u0017\u007F(1, 137, 224);
      this.DisabledStartColor = \u008E\u001D.\u0017\u007F(163, 163, 163);
      this.DisabledEndColor = \u008E\u001D.\u0017\u007F(37, 37, 37);
      this.DownStartColor = \u008E\u001D.\u0017\u007F(250, 102, 102);
      this.DownEndColor = \u008E\u001D.\u0017\u007F(111, 2, 14);
      this.SelectedStartColor = \u008E\u001D.\u0017\u007F(152, 248, 165);
      this.SelectedEndColor = \u008E\u001D.\u0017\u007F(0, 157, 0);
      this.\u0001 = new \u007F<\u001B.\u001E.\u0001, \u001B.\u001E>(this);
      this.\u0001 = new Dictionary<\u001B.\u001E.\u0001, Rectangle>();
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new ToolTip(this.\u0001);
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.UserMouse | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009D\u0084((object) this, disposing);
    }

    private void \u001D\u0005(Rectangle rec)
    {
      if (!rec.\u001D\u0005())
        return;
      \u000E\u0080.\u0005\u0086((object) this, rec.\u001F\u0005(2, 2));
    }

    private void \u001D\u0005(\u001B.\u001E.\u0001 btn, MouseButtons button)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0018.\u001D(btn, button));
    }

    private LinearGradientBrush \u001D\u0005(\u001B.\u001E.\u0001 btn)
    {
      Rectangle bounds = btn.Bounds;
      if (!btn.Enabled)
        return new LinearGradientBrush(bounds.Location, bounds.\u001E\u0005(), this.DisabledStartColor, this.DisabledEndColor);
      if (btn.Down && !btn.Selected)
        return new LinearGradientBrush(bounds.Location, bounds.\u001E\u0005(), this.DownStartColor, this.DownEndColor);
      if (btn.Selected)
        return new LinearGradientBrush(bounds.Location, bounds.\u001E\u0005(), this.SelectedStartColor, this.SelectedEndColor);
      if (btn.Hover)
        return new LinearGradientBrush(bounds.Location, bounds.\u001E\u0005(), this.HoverStartColor, this.HoverEndColor);
      return new LinearGradientBrush(bounds.Location, bounds.\u001E\u0005(), this.NormalStartColor, this.NormalEndColor);
    }

    private void \u001D\u0005(\u001B.\u001E.\u0001 sender, string text)
    {
      this.\u0001 = sender;
      if (!\u0099\u0082.\u007E\u0096\u0090((object) this.\u0001))
        return;
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this, text);
    }

    private void \u007F\u0005(\u001B.\u001E.\u0001 sender)
    {
      if (this.\u0001 != sender || !\u0099\u0082.\u007E\u0096\u0090((object) this.\u0001))
        return;
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this, string.Empty);
    }

    void \u0014.\u001D<\u001B.\u001E.\u0001>.\u001D\u0005(\u001B.\u001E.\u0001 obj)
    {
      this.\u0001.Add(obj, obj.Bounds);
      this.\u001D\u0005(this.\u0001[obj]);
    }

    void \u0014.\u001D<\u001B.\u001E.\u0001>.\u001E\u0005(\u001B.\u001E.\u0001 obj)
    {
      this.\u001D\u0005(this.\u0001[obj]);
      this.\u0001.Remove(obj);
    }

    void \u0014.\u001D<\u001B.\u001E.\u0001>.\u001F\u0005(\u001B.\u001E.\u0001 obj)
    {
      this.\u001D\u0005(this.\u0001[obj]);
      this.\u0001[obj] = obj.Bounds;
      this.\u001D\u0005(this.\u0001[obj]);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0015\u0083.\u007E\u0081\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), SmoothingMode.AntiAlias);
      if (this.\u0001 != null)
        goto label_9;
label_1:
      IEnumerator<\u001B.\u001E.\u0001> enumerator = this.Buttons.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          enumerator.Current.\u001D\u0005(e);
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      \u0092\u001C.\u0017\u0086((object) this, e);
      return;
label_9:
      this.\u0001.\u0001(new \u0082(\u0004\u007F.\u007E\u0092\u0086((object) e), \u008D\u0084.\u0082\u0083((object) this)));
      goto label_1;
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      IEnumerator<\u001B.\u001E.\u0001> enumerator = this.Buttons.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          enumerator.Current.\u0001(e);
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      \u001E\u001C.\u0015\u0086((object) this, e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      IEnumerator<\u001B.\u001E.\u0001> enumerator = this.Buttons.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          enumerator.Current.\u009D\u0002();
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      \u0088\u001C.\u0014\u0086((object) this, e);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      IEnumerator<\u001B.\u001E.\u0001> enumerator = this.Buttons.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          enumerator.Current.\u0001(\u0094\u0080.\u007E\u008C\u008A((object) e));
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      \u001E\u001C.\u0012\u0086((object) this, e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      IEnumerator<\u001B.\u001E.\u0001> enumerator = this.Buttons.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          enumerator.Current.\u0002(\u0094\u0080.\u007E\u008C\u008A((object) e));
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      \u001E\u001C.\u0016\u0086((object) this, e);
    }

    internal sealed class \u0001 : \u001B.\u001F<\u001B.\u001E.\u0001>, \u000F
    {
      private bool \u0001 = true;
      private \u001B.\u001E.\u0001.\u0001 \u0001;
      private Image \u0001;
      private Rectangle \u0001;
      private \u001B.\u001E.\u0001.\u0002 \u0001;
      private string \u0001;

      public Enum ButtonType { get; set; }

      public \u001B.\u001E.\u0001.\u0001 Overlay
      {
        get
        {
          return this.\u0001;
        }
        set
        {
          if (this.\u0001 == value)
            return;
          if (this.\u0001 != null)
            this.\u0001.Owner = (\u001B.\u001E.\u0001) null;
          this.\u0001 = value;
          if (this.\u0001 != null)
            goto label_6;
label_2:
          this.\u001C\u0007();
          return;
label_6:
          this.\u0001.Owner = this;
          goto label_2;
        }
      }

      public string Name { get; set; }

      public bool AcceptRightClick
      {
        get
        {
          return this.\u0001;
        }
        set
        {
          this.\u0001 = value;
        }
      }

      [Editor(typeof (MultilineStringEditor), typeof (UITypeEditor))]
      public string Text
      {
        get
        {
          return this.\u0001;
        }
        set
        {
          if (!\u0008\u001F.\u009B\u0092(this.\u0001, value))
            return;
          this.\u0001 = value;
          this.\u001C\u0007();
        }
      }

      public bool Hover
      {
        get
        {
          return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u001B.\u001E.\u0001.\u0002.\u0002);
        }
        private set
        {
          if (this.Hover == value)
            return;
          if (value)
            this.\u0001 |= \u001B.\u001E.\u0001.\u0002.\u0002;
          else
            this.\u0001 &= ~\u001B.\u001E.\u0001.\u0002.\u0002;
        }
      }

      public bool Down
      {
        get
        {
          return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u001B.\u001E.\u0001.\u0002.\u0003);
        }
        private set
        {
          if (this.Down == value)
            return;
          if (value)
            this.\u0001 |= \u001B.\u001E.\u0001.\u0002.\u0003;
          else
            this.\u0001 &= ~\u001B.\u001E.\u0001.\u0002.\u0003;
        }
      }

      public bool Enabled
      {
        get
        {
          return !\u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u001B.\u001E.\u0001.\u0002.\u0005);
        }
        set
        {
          if (this.Enabled == value)
            return;
          if (!value)
            goto label_5;
          else
            goto label_4;
label_2:
          this.\u001C\u0007();
          return;
label_4:
          this.\u0001 &= ~\u001B.\u001E.\u0001.\u0002.\u0005;
          goto label_2;
label_5:
          this.\u0001 |= \u001B.\u001E.\u0001.\u0002.\u0005;
          this.Hover = false;
          this.Down = false;
          goto label_2;
        }
      }

      public bool Selected
      {
        get
        {
          return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u001B.\u001E.\u0001.\u0002.\u0004);
        }
        set
        {
          if (this.Selected == value)
            return;
          if (value)
            this.\u0001 |= \u001B.\u001E.\u0001.\u0002.\u0004;
          else
            this.\u0001 &= ~\u001B.\u001E.\u0001.\u0002.\u0004;
          this.\u001C\u0007();
        }
      }

      [DefaultValue(typeof (Image), null)]
      public Image Icon
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
          this.\u001C\u0007();
        }
      }

      public Rectangle Bounds
      {
        get
        {
          return this.\u0001;
        }
        set
        {
          if (!\u0019\u007F.\u0095\u0080(this.\u0001, value))
            return;
          this.\u0001 = value;
          this.\u001B\u0007();
        }
      }

      protected \u001B.\u001E Owner { get; set; }

      \u0014.\u001D<\u001B.\u001E.\u0001> \u001B.\u001F<\u001B.\u001E.\u0001>.TheToonTownSpoofer\u002ECollections\u002EIObjectOwnable\u003CTheToonTownSpoofer\u002EControls\u002EButtonBoard\u002EButtonBoardButton\u003E\u002EOwner
      {
        get
        {
          return (\u0014.\u001D<\u001B.\u001E.\u0001>) this.Owner;
        }
        set
        {
          this.Owner = (\u001B.\u001E) value;
        }
      }

      public Font Font
      {
        get
        {
          if (this.Owner == null)
            return (Font) null;
          return \u0080\u0084.\u007E\u0092\u0083((object) this.Owner);
        }
      }

      public Font TextFont
      {
        get
        {
          if (this.Owner == null)
            return (Font) null;
          return this.Owner.TextFont;
        }
      }

      public Color ForeColor
      {
        get
        {
          if (this.Owner == null)
            return \u009A\u0080.\u0090\u001F();
          return \u0091\u0084.\u007E\u0094\u0083((object) this.Owner);
        }
      }

      public \u0001()
      {
        this.Name = string.Empty;
      }

      private void \u001B\u0007()
      {
        \u001B.\u001F<\u001B.\u001E.\u0001> obj = (\u001B.\u001F<\u001B.\u001E.\u0001>) this;
        if (obj.Owner == null)
          return;
        obj.Owner.\u0003(this);
      }

      public void \u001C\u0007()
      {
        \u001B.\u001F<\u001B.\u001E.\u0001> obj = (\u001B.\u001F<\u001B.\u001E.\u0001>) this;
        if (obj.Owner == null)
          return;
        ((\u001B.\u001E) obj.Owner).\u001D\u0005(this.Bounds);
      }

      public override string ToString()
      {
        return this.Name;
      }

      public void \u001D\u0005(PaintEventArgs e)
      {
        if (!this.Bounds.\u001D\u0005())
          return;
        GraphicsPath graphicsPath = \u0081.\u001F.\u001D\u0005(this.Bounds, 8, \u001A.\u0006);
        try
        {
          LinearGradientBrush linearGradientBrush = this.Owner.\u001D\u0005(this);
          try
          {
            \u0098\u0081.\u007E\u0098\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) linearGradientBrush, graphicsPath);
            \u0089\u0084.\u007E\u0005\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e), graphicsPath);
            if (this.\u0001 == \u001B.\u001E.\u0001.\u0002.\u0002 || this.Selected)
            {
              int num = 40;
              GraphicsPath path = \u001D.\u001F.\u001D\u0005(this.Bounds.\u007F\u0005().\u001D\u0005(num, num));
              try
              {
                PathGradientBrush pathGradientBrush = new PathGradientBrush(path);
                try
                {
                  if (this.\u0001 == \u001B.\u001E.\u0001.\u0002.\u0002)
                  {
                    \u0081\u0082.\u007E\u001B\u0082((object) pathGradientBrush, this.Owner.HoverRadialCenterColor);
                    \u008A\u0086.\u007E\u001C\u0082((object) pathGradientBrush, new Color[1]
                    {
                      this.Owner.HoverRadialSurroundColor
                    });
                  }
                  if (\u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u001B.\u001E.\u0001.\u0002.\u0004))
                  {
                    \u0081\u0082.\u007E\u001B\u0082((object) pathGradientBrush, this.Owner.SelectedRadialCenterColor);
                    \u008A\u0086.\u007E\u001C\u0082((object) pathGradientBrush, new Color[1]
                    {
                      this.Owner.SelectedRadialSurroundColor
                    });
                  }
                  \u0098\u0081.\u007E\u0098\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (Brush) pathGradientBrush, path);
                }
                finally
                {
                  if (pathGradientBrush != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) pathGradientBrush);
                }
              }
              finally
              {
                if (path != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) path);
              }
            }
            if (this.Icon != null)
              \u0004\u001F.\u007E\u009E\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.Icon, \u0083\u001E.\u007E\u001F\u001F((object) this.Icon).\u001D\u0005(this.Bounds.\u001F\u0005(-2, -2)));
            if (!\u008F\u0084.\u009E\u0092(this.\u0001) && this.TextFont != null)
            {
              SolidBrush solidBrush = new SolidBrush(this.ForeColor);
              try
              {
                StringFormat stringFormat = new StringFormat();
                try
                {
                  \u0014\u0083.\u007E\u009E\u0082((object) stringFormat, StringAlignment.Center);
                  \u0014\u0083.\u007E\u009F\u0082((object) stringFormat, StringAlignment.Center);
                  \u009F\u0084.\u007E\u009B\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0001, this.TextFont, (Brush) solidBrush, \u0013\u001F.\u0097\u0082(this.Bounds), stringFormat);
                }
                finally
                {
                  if (stringFormat != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) stringFormat);
                }
              }
              finally
              {
                if (solidBrush != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) solidBrush);
              }
            }
            if (this.\u0001 != null)
              this.\u0001.\u0001(new \u0082(\u0004\u007F.\u007E\u0092\u0086((object) e), this.Bounds));
            \u001A\u001E.\u007E\u0006\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e));
          }
          finally
          {
            if (linearGradientBrush != null)
              \u001A\u001E.\u007E\u0094\u0092((object) linearGradientBrush);
          }
          Pen pen = new Pen(this.Owner.ButtonOutline, 1f);
          try
          {
            \u008A\u0082.\u007E\u0090\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, graphicsPath);
          }
          finally
          {
            if (pen != null)
              \u001A\u001E.\u007E\u0094\u0092((object) pen);
          }
        }
        finally
        {
          if (graphicsPath != null)
            \u001A\u001E.\u007E\u0094\u0092((object) graphicsPath);
        }
      }

      public void \u0001(MouseEventArgs e)
      {
        if (!this.Enabled)
          return;
        if (!this.Hover)
        {
          if (!this.Bounds.Contains(\u008E\u0084.\u007E\u0090\u008A((object) e)))
            return;
          this.Hover = true;
          this.Owner.\u001D\u0005(this, this.Overlay.ToString());
          this.\u001C\u0007();
        }
        else
        {
          if (this.Bounds.Contains(\u008E\u0084.\u007E\u0090\u008A((object) e)))
            return;
          this.Hover = false;
          this.Owner.\u007F\u0005(this);
          this.\u001C\u0007();
        }
      }

      public void \u0001(MouseButtons button)
      {
        if (!this.Enabled || button == MouseButtons.Right && !this.\u0001)
          return;
        if (!this.Hover)
        {
          if (!this.Down)
            return;
          this.Down = false;
          this.\u001C\u0007();
        }
        else
        {
          this.Down = true;
          this.\u001C\u0007();
        }
      }

      public void \u0002(MouseButtons button)
      {
        if (!this.Enabled || button == MouseButtons.Right && !this.\u0001 || !this.Down)
          return;
        if (this.Hover)
          goto label_5;
label_3:
        this.Down = false;
        this.\u001C\u0007();
        return;
label_5:
        \u001B.\u001F<\u001B.\u001E.\u0001> obj = (\u001B.\u001F<\u001B.\u001E.\u0001>) this;
        if (obj.Owner != null)
        {
          ((\u001B.\u001E) obj.Owner).\u001D\u0005(this, button);
          goto label_3;
        }
        else
          goto label_3;
      }

      public void \u009D\u0002()
      {
        if (!this.Enabled || !this.Hover)
          return;
        this.Hover = false;
        this.Owner.\u007F\u0005(this);
        this.\u001C\u0007();
      }

      internal interface \u0001 : \u0018.\u001B
      {
        \u001B.\u001E.\u0001 Owner { get; set; }

        string ToString();
      }

      [Flags]
      internal enum \u0002
      {
        \u0001 = 0,
        \u0002 = 1,
        \u0003 = 2,
        \u0004 = 4,
        \u0005 = 8,
      }
    }
  }
}
