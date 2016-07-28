// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0018;
using \u001D;
using \u001E;
using \u001F;
using \u007F;
using \u0083;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0015
{
  internal sealed class \u0004 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private Bitmap \u0001;
    private Rectangle \u0001;
    private bool \u0001;
    private \u001C \u0001;
    private IContainer \u0001;
    private \u0003 \u0001;
    private ContextMenuStrip \u0001;
    private ToolStripMenuItem \u0001;
    private ToolStripMenuItem \u0002;
    private ToolTip \u0001;

    public Size MinimumSelectionSize { get; set; }

    public string LockedMessage
    {
      get
      {
        return this.\u0001.LockedMessage;
      }
      set
      {
        this.\u0001.LockedMessage = value;
      }
    }

    public string MovableMessage
    {
      get
      {
        return this.\u0001.MovableMessage;
      }
      set
      {
        this.\u0001.MovableMessage = value;
      }
    }

    public string MovableResizeMessage
    {
      get
      {
        return this.\u0001.MovableResizeMessage;
      }
      set
      {
        this.\u0001.MovableResizeMessage = value;
      }
    }

    public bool FullScreenCapture { get; set; }

    public bool FullSize { get; set; }

    public bool FullSelect { get; set; }

    public \u0019 RegionSelectorType { get; set; }

    public Rectangle SelectedRegion { get; set; }

    public Rectangle SelectionBounds { get; set; }

    public \u0082 SelectedBitmap
    {
      get
      {
        Rectangle selectedRegion = this.\u0001.SelectedRegion;
        if (\u0010\u007F.\u0006\u0081(selectedRegion.Size, Size.Empty))
          goto label_13;
label_12:
        return (\u0082) null;
label_13:
        Bitmap screenCapture = this.\u0001.ScreenCapture;
        if (screenCapture == null)
        {
          \u0017.\u001E\u0005(\u0004.\u0003, \u0004.\u0002);
          goto label_12;
        }
        else
        {
          \u0082 result = (\u0082) null;
          try
          {
            \u0082 obj = new \u0082(screenCapture);
            try
            {
              obj.\u001D\u0005(this.\u0001.SelectedRegion, out result);
            }
            finally
            {
              if (obj != null)
                \u001A\u001E.\u007E\u0094\u0092((object) obj);
            }
          }
          catch (Exception ex)
          {
            if (result != null)
              result.Dispose();
            result = (\u0082) null;
            \u0017.\u001E\u0005(\u0004.\u0001, \u0004.\u0002);
            ex.\u001D\u0005();
          }
          return result;
        }
      }
    }

    static \u0004()
    {
      \u0004.\u001D\u0005(typeof (\u0004));
      \u0004.\u0001 = \u0004.\u0001(12454);
      \u0004.\u0002 = \u0004.\u0001(12555);
      \u0004.\u0003 = \u0004.\u0001(12604);
      \u0004.\u0004 = \u0004.\u0001(12673);
      \u0004.\u0005 = \u0004.\u0001(12690);
    }

    public \u0004()
    {
      this.\u0001 = false;
      this.\u0001 = new \u001C();
      this.\u001F\u0005();
    }

    public \u0004(IntPtr hWnd)
      : this()
    {
      this.\u0001 = \u0008\u0081.\u0087\u0096(hWnd, IntPtr.Zero);
      this.\u0001.MainWindowHandle = hWnd;
    }

    private void \u001D\u0005()
    {
      \u0017.\u001E\u0005(\u0004.\u0001(12123), \u0004.\u0001(12232));
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001.BackgroundOverlayColor = \u008D\u001E.\u0016\u007F(180, \u009A\u0080.\u0090\u001F());
      this.\u0001.BorderColor = \u008D\u001E.\u0016\u007F((int) byte.MaxValue, \u009A\u0080.\u0005\u007F());
      this.\u0001.WindowRegionOverlayColor = \u001B\u001C.\u0015\u007F(90, (int) byte.MaxValue, 128, 64);
      this.\u0001.CloseMessageTextColor = \u008D\u001E.\u0016\u007F(200, \u009A\u0080.\u0005\u007F());
      this.\u0001.CloseMessageBorderTextColor = \u008D\u001E.\u0016\u007F(200, \u009A\u0080.\u0090\u001F());
      this.\u0001.SelectorType = this.RegionSelectorType;
      this.\u0001.FullScreen = this.FullScreenCapture;
      if (this.\u0001 && !this.\u0001.ProcessOpen)
      {
        this.\u001D\u0005();
      }
      else
      {
        IntPtr mainWindowHandle = this.\u0001.MainWindowHandle;
        if (this.FullScreenCapture)
        {
          try
          {
            this.\u0001.ScreenCapture = this.\u0001 = \u0012.\u001D\u0005();
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005();
            this.\u001D\u0005();
            return;
          }
          if (!this.\u0001)
          {
            this.\u0001.SelectionBounds = !this.FullSize ? this.SelectionBounds : new Rectangle(Point.Empty, \u0097\u0080.\u001E\u008F().Size);
            this.\u0001.SelectedRegion = !this.FullSelect ? this.SelectedRegion.\u001D\u0005(this.\u0001.SelectionBounds) : new Rectangle(Point.Empty, this.\u0001.SelectionBounds.Size).\u001D\u0005(this.\u0001.SelectionBounds);
          }
          else
          {
            try
            {
              this.\u0001 = \u0013.\u001E\u0005(mainWindowHandle);
            }
            catch (Exception ex)
            {
              ex.\u001D\u0005();
              this.\u001D\u0005();
              return;
            }
            if (\u0097\u0080.\u001E\u008F().X < 0)
              this.\u0001.X -= \u0097\u0080.\u001E\u008F().X;
            if (\u0097\u0080.\u001E\u008F().Y < 0)
              this.\u0001.Y -= \u0097\u0080.\u001E\u008F().Y;
            this.\u0001.SelectionBounds = !this.FullSize ? new Rectangle(this.SelectionBounds.Location.\u001E\u0005(this.\u0001.Location), this.SelectionBounds.Size) : this.\u0001;
            this.\u0001.SelectedRegion = !this.FullSelect ? new Rectangle(this.SelectedRegion.Location.\u001E\u0005(this.\u0001.Location), this.SelectedRegion.Size).\u001D\u0005(this.\u0001.SelectionBounds) : this.\u0001.SelectionBounds;
          }
          \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.None);
          \u0096\u0086.\u0018\u008B((object) this, \u0097\u0080.\u001E\u008F().Location);
          \u000E\u001F.\u0082\u008B((object) this, \u0097\u0080.\u001E\u008F().Size);
        }
        else if (!this.\u0001)
        {
          if (this.FullSize)
          {
            try
            {
              this.\u0001.ScreenCapture = this.\u0001 = \u0012.\u001D\u0005();
            }
            catch (Exception ex)
            {
              ex.\u001D\u0005();
              this.\u001D\u0005();
              return;
            }
            this.\u0001.SelectionBounds = this.SelectionBounds;
            \u000E\u001F.\u0082\u008B((object) this, \u0097\u0080.\u001E\u008F().Size);
          }
          else
          {
            try
            {
              this.\u0001.ScreenCapture = this.\u0001 = \u0012.\u001D\u0005(this.SelectionBounds.\u001D\u0005());
            }
            catch (Exception ex)
            {
              ex.\u001D\u0005();
              this.\u001D\u0005();
              return;
            }
            this.\u0001.SelectionBounds = new Rectangle(Point.Empty, this.SelectionBounds.Size);
            \u000E\u001F.\u0082\u008B((object) this, this.SelectionBounds.Size);
          }
          this.\u0001.SelectedRegion = !this.FullSelect ? new Rectangle(this.SelectedRegion.Location.\u001F\u0005(this.SelectionBounds.Location), this.SelectedRegion.Size).\u001D\u0005(this.\u0001.SelectionBounds) : new Rectangle(Point.Empty, this.\u0001.SelectionBounds.Size);
          \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.Fixed3D);
          \u001A\u001E.\u0094\u008B((object) this);
        }
        else
        {
          if (this.FullSize)
          {
            try
            {
              this.\u0001.ScreenCapture = this.\u0001 = \u0012.\u001D\u0005(mainWindowHandle);
              this.\u0001.SelectionBounds = new Rectangle(Point.Empty, \u0013.\u001D\u0005(mainWindowHandle));
            }
            catch (Exception ex)
            {
              ex.\u001D\u0005();
              this.\u001D\u0005();
              return;
            }
            \u000E\u001F.\u0082\u008B((object) this, this.\u0001.SelectionBounds.Size);
            \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.Fixed3D);
            try
            {
              \u0096\u0086.\u0018\u008B((object) this, \u0013.\u001D\u0005(mainWindowHandle).Location);
            }
            catch (Exception ex)
            {
              ex.\u001D\u0005();
              this.\u001D\u0005();
              return;
            }
          }
          else
          {
            try
            {
              this.\u0001.ScreenCapture = this.\u0001 = \u0012.\u001D\u0005(mainWindowHandle, this.SelectionBounds);
            }
            catch (Exception ex)
            {
              ex.\u001D\u0005();
              this.\u001D\u0005();
              return;
            }
            this.\u0001.SelectionBounds = new Rectangle(Point.Empty, this.SelectionBounds.Size);
            \u000E\u001F.\u0082\u008B((object) this, this.SelectionBounds.Size);
            \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.Fixed3D);
            try
            {
              \u0096\u0086.\u0018\u008B((object) this, \u0013.\u001D\u0005(mainWindowHandle).Location.\u001E\u0005(this.SelectionBounds.Location));
            }
            catch (Exception ex)
            {
              ex.\u001D\u0005();
              this.\u001D\u0005();
              return;
            }
          }
          this.\u0001.SelectedRegion = !this.FullSelect ? new Rectangle(this.SelectedRegion.Location.\u001F\u0005(this.SelectionBounds.Location), this.SelectedRegion.Size) : new Rectangle(Point.Empty, this.\u0001.SelectionBounds.Size);
        }
        \u0099\u001F.\u0086\u008B((object) this, true);
        \u001A\u001E.\u009B\u0084((object) this);
        \u001A\u001E.\u0091\u008B((object) this);
        switch (this.RegionSelectorType)
        {
          case \u0019.\u0001:
            \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0001, this.MovableResizeMessage);
            break;
          case \u0019.\u0002:
            \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0001, this.MovableMessage);
            break;
          case \u0019.\u0003:
            \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0001, this.LockedMessage);
            break;
        }
        int num = \u0099\u0082.\u007E\u009E\u0084((object) this.\u0001) ? 1 : 0;
      }
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }

    private void \u001D\u0005(object sender, KeyEventArgs e)
    {
      this.\u001D\u0005(e);
    }

    private void \u001D\u0005(KeyEventArgs e)
    {
      if (\u007F\u0081.\u007E\u0013\u008C((object) e) == Keys.Escape)
      {
        \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
        \u001A\u001E.\u0092\u008B((object) this);
      }
      else
        this.\u001E\u0005();
    }

    private void \u001E\u0005()
    {
      if (this.\u0001.SelectedRegion.Width < this.MinimumSelectionSize.Width || this.\u0001.SelectedRegion.Height < this.MinimumSelectionSize.Width)
      {
        \u0017.\u001D\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0004.\u0005, new object[2]
        {
          (object) this.MinimumSelectionSize,
          (object) this.\u0001.SelectedRegion.Size
        }), \u0004.\u0004);
      }
      else
      {
        this.SelectedRegion = !this.FullScreenCapture ? (this.\u0001 ? new Rectangle(this.\u0001.SelectedRegion.Location.\u001E\u0005(this.SelectionBounds.Location), this.\u0001.SelectedRegion.Size) : new Rectangle(this.\u0001.SelectedRegion.Location.\u001E\u0005(this.SelectionBounds.Location), this.\u0001.SelectedRegion.Size)) : (this.\u0001 ? new Rectangle(this.\u0001.SelectedRegion.Location.\u001F\u0005(this.\u0001.Location), this.\u0001.SelectedRegion.Size) : this.\u0001.SelectedRegion);
        \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u001D\u001F((object) this.\u0001);
      this.\u0001.Dispose();
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001F\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0004)));
      this.\u0001 = new ContextMenuStrip(this.\u0001);
      this.\u0001 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripMenuItem();
      this.\u0001 = new ToolTip(this.\u0001);
      this.\u0001 = new \u0003();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[2]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0002
      });
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0004.\u0001(12253));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(112, 48));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0004.\u0001(12270));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(111, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0004.\u0001(12287));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0004.\u0001(12300));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(111, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0004.\u0001(12317));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u0086\u001C.\u007E\u0099\u0090((object) this.\u0001, ToolTipIcon.Info);
      \u0092\u0081.\u007E\u009A\u0090((object) this.\u0001, \u0004.\u0001(12330));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0016\u0081());
      \u001E\u0082.\u007E\u0086\u0083((object) this.\u0001, this.\u0001);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0004.\u0001(5856), 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0004.\u0001(12351));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(852, 445));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0087\u0086.\u007E\u008D\u0084((object) this.\u0001, new KeyEventHandler(this.\u001D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(852, 445));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.None);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0004.\u0001(5399)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0099\u001F.\u001E\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0004.\u0001(12380));
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0004.\u0001(12401));
      \u0087\u007F.\u008E\u008B((object) this, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
