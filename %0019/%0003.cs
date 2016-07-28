// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0018;
using \u0019;
using \u001A;
using \u001D;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0019
{
  internal sealed class \u0003 : \u0002
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly int \u0001;
    private static readonly int \u0002;
    private \u0003 \u0001;
    private string \u0001;
    private \u0003.\u0001 \u0001;
    private Point? \u0001;
    private bool \u0001;
    private IContainer \u0001;
    private \u0006 \u0001;
    private ToolStrip \u0001;
    private ToolStripButton \u0001;
    private ToolStripButton \u0002;
    private ToolStripSeparator \u0001;
    private ToolStripButton \u0003;
    private ToolStripButton \u0004;
    private ToolStripSeparator \u0002;
    private ToolTip \u0001;
    private SaveFileDialog \u0001;
    private ToolStripDropDownButton \u0001;
    private ToolStripMenuItem \u0001;
    private ToolStripMenuItem \u0002;
    private ToolStripMenuItem \u0003;
    private ToolStripButton \u0005;
    private ToolStripSeparator \u0003;
    private ToolStripButton \u0006;
    private ToolStripButton \u0007;
    private Timer \u0001;
    private Timer \u0002;

    public event EventHandler ShowNextImage;

    public event EventHandler ShowPreviousImage;

    static \u0003()
    {
      \u0004.\u001D\u0005(typeof (\u0003));
      \u0003.\u0001 = 10;
      \u0003.\u0002 = 5000;
    }

    public \u0003()
    {
      this.\u0082\u0005();
      this.\u0001 = \u0081.\u0080.Instance.MyGallerySettings;
      int num1 = \u0005\u0081.\u0083\u0084((object) this) - \u0083\u001E.\u000F\u008B((object) this).Width;
      int num2 = \u0005\u0081.\u0098\u0083((object) this) - \u0083\u001E.\u000F\u008B((object) this).Height;
      Rectangle rectangle = \u0097\u007F.\u0018\u008F(\u0098\u0080.\u009F\u0089());
      int y = (int) ((double) rectangle.Height * 0.02) + rectangle.Y;
      int num3 = rectangle.Height - (int) ((double) rectangle.Height * 0.06) - 246;
      Size size = new Size((int) ((double) rectangle.Width * 0.875) - num1, num3 - num2);
      float num4 = (float) size.Width / (float) size.Height;
      float num5 = 1.333333f;
      if ((double) num4 > (double) num5)
      {
        \u0011\u001F.\u0099\u0083((object) this, size.Height + num2);
        \u0011\u001F.\u0084\u0084((object) this, (int) ((double) size.Height * (double) num5) + num1);
      }
      else
      {
        \u0011\u001F.\u0084\u0084((object) this, size.Width + num1);
        \u0011\u001F.\u0099\u0083((object) this, (int) ((double) size.Width / (double) num5) + num2);
      }
      \u0096\u0086.\u0018\u008B((object) this, new Point(rectangle.Width / 2 - \u0005\u0081.\u0083\u0084((object) this) / 2 + rectangle.X, y));
      this.\u001F\u0005();
      this.\u0001 = \u0003.\u0001.\u0005;
      this.\u001D\u0005(\u0003.\u0001.\u0001);
    }

    public void \u001D\u0005(string imagePath)
    {
      this.\u0001 = imagePath;
      \u0099\u001F obj = \u0099\u001F.\u007E\u0018\u0087;
      ToolStripButton toolStripButton = this.\u0004;
      bool flag;
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0003, flag = false);
      int num = flag ? 1 : 0;
      obj((object) toolStripButton, num != 0);
      if (\u008F\u0084.\u009E\u0092(imagePath))
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u0003.\u0001(43296));
      else
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u009E\u0081.\u001F\u0093(\u0003.\u0001(43321), (object) \u009C\u0080.\u0008\u009F(imagePath)));
      this.\u0001.\u001D\u0005(imagePath);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u0099\u001F obj = \u0099\u001F.\u007E\u0018\u0087;
      ToolStripButton toolStripButton = this.\u0004;
      bool flag;
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0003, flag = true);
      int num = flag ? 1 : 0;
      obj((object) toolStripButton, num != 0);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      bool flag = \u0099\u0082.\u007E\u009E\u008F((object) this.\u0002);
      if (flag)
        \u001A\u001E.\u007E\u0003\u0090((object) this.\u0002);
      \u0092\u0081.\u007E\u0093\u008A((object) this.\u0001, \u009C\u0080.\u0008\u009F(this.\u0001));
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) == DialogResult.OK)
      {
        if (\u0014.\u001D\u0005(this.\u0001, \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001)))
        {
          \u0017.\u001D\u0005(\u0003.\u0001(43354), \u0003.\u0001(43411));
        }
        else
        {
          try
          {
            \u0096\u0083.\u008F\u009E(this.\u0001, \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005((object) \u0014\u0084.\u007F\u0093(\u0003.\u0001(43436), (object) this.\u0001, (object) \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001)));
            \u0017.\u001D\u0005(ex, \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
          }
        }
      }
      if (!flag)
        return;
      \u001A\u001E.\u007E\u0002\u0090((object) this.\u0002);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      bool flag = \u0099\u0082.\u007E\u009E\u008F((object) this.\u0002);
      if (flag)
        \u001A\u001E.\u007E\u0003\u0090((object) this.\u0002);
      if (\u0017.\u001E\u0005(\u0003.\u0001(43469), \u0003.\u0001(43534), \u0018.\u0016.\u0006, \u0018.\u0016.\u0007) == DialogResult.Yes)
      {
        string path = this.\u0001;
        this.\u001D\u0005((string) null);
        try
        {
          \u009C\u001F.\u0091\u009E(path);
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005((object) path);
          \u0017.\u001D\u0005(ex, path);
        }
      }
      if (!flag)
        return;
      \u001A\u001E.\u007E\u0002\u0090((object) this.\u0002);
    }

    private void \u001D\u0005(object sender, PreviewKeyDownEventArgs e)
    {
      switch (\u007F\u0081.\u007E\u0082\u008E((object) e))
      {
        case Keys.Left:
        case Keys.Right:
          \u0099\u001F.\u007E\u0083\u008E((object) e, true);
          break;
      }
    }

    private void \u001D\u0005(object sender, KeyEventArgs e)
    {
      switch (\u007F\u0081.\u007E\u0013\u008C((object) e))
      {
        case Keys.Escape:
          \u001A\u001E.\u0092\u008B((object) this);
          break;
        case Keys.Left:
          this.\u001D\u0005();
          break;
        case Keys.Right:
          this.\u001E\u0005();
          break;
        case Keys.F12:
          this.\u001E\u0005(!base.FullScreen);
          \u0099\u001F.\u007E\u0082\u0090((object) this.\u0005, base.FullScreen);
          break;
      }
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      this.\u0002.\u001D\u0005();
      this.\u001D\u0005();
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      this.\u0002.\u001D\u0005();
      this.\u001E\u0005();
    }

    private void \u001D\u0005()
    {
      if (this.\u0002 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
    }

    private void \u001E\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      this.\u0001.ScreenshotScaling = \u0011.\u0001;
      this.\u001F\u0005();
      this.\u0001.\u0080\u0005();
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.\u0001.ScreenshotScaling = \u0011.\u0002;
      this.\u001F\u0005();
      this.\u0001.\u0080\u0005();
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      this.\u0001.ScreenshotScaling = \u0011.\u0003;
      this.\u001F\u0005();
      this.\u0001.\u0080\u0005();
    }

    private void \u001F\u0005()
    {
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0002, false);
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0001, false);
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0003, false);
      switch (this.\u0001.ScreenshotScaling)
      {
        case \u0011.\u0001:
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0001, true);
          break;
        case \u0011.\u0002:
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0002, true);
          break;
        case \u0011.\u0003:
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0003, true);
          break;
      }
    }

    private void \u007F\u0005()
    {
      if (!this.\u0001)
        return;
      \u0088\u0081.\u0004\u008A();
      this.\u0001 = false;
    }

    private void \u0080\u0005()
    {
      if (this.\u0001)
        return;
      \u0088\u0081.\u0003\u008A();
      this.\u0001 = true;
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005(\u0003.\u0001.\u0004);
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      if (\u008D\u0084.\u007E\u0082\u0083((object) this.\u0001).Contains(\u0098\u001B.\u007E\u001A\u0086((object) this.\u0001, \u0098\u0080.\u000F\u0084())) || \u008D\u0084.\u007E\u0082\u0083((object) this.\u0001).Contains(\u0098\u001B.\u007E\u001A\u0086((object) this.\u0001, \u0098\u0080.\u000F\u0084())))
        return;
      this.\u001D\u0005(\u0003.\u0001.\u0001);
      this.\u007F\u0005();
    }

    private void \u001D\u0005(object sender, MouseEventArgs e)
    {
      if (this.\u0001.HasValue)
        goto label_3;
label_2:
      this.\u0081\u0005();
      return;
label_3:
      Point? nullable = this.\u0001;
      Point point = \u0098\u0080.\u000F\u0084();
      if ((!nullable.HasValue ? 1 : (\u001D\u0081.\u007F\u0080(nullable.GetValueOrDefault(), point) ? 1 : 0)) != 0)
      {
        this.\u0001 = new Point?();
        goto label_2;
      }
      else
        goto label_2;
    }

    private void \u0081\u0005()
    {
      if (this.\u0001.HasValue)
        return;
      this.\u0001 = new Point?(\u0098\u0080.\u000F\u0084());
      switch (this.\u0001)
      {
        case \u0003.\u0001.\u0001:
        case \u0003.\u0001.\u0005:
          if (!\u008D\u0084.\u007E\u0082\u0083((object) this.\u0001).Contains(\u0098\u001B.\u007E\u001A\u0086((object) this.\u0001, \u0098\u0080.\u000F\u0084())))
            break;
          this.\u001D\u0005(\u0003.\u0001.\u0001);
          break;
        case \u0003.\u0001.\u0002:
        case \u0003.\u0001.\u0003:
          this.\u001D\u0005(\u0003.\u0001.\u0004);
          break;
      }
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      switch (this.\u0001)
      {
        case \u0003.\u0001.\u0001:
          this.\u001D\u0005(\u0003.\u0001.\u0002);
          break;
        case \u0003.\u0001.\u0002:
          if (\u0005\u0081.\u007E\u007F\u0083((object) this.\u0001) > 0)
          {
            \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, \u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).Y - 1));
            this.\u0001.\u001E\u0005();
            \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, \u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).Y - 1));
            \u0011\u001F obj1 = \u0011\u001F.\u007E\u0099\u0083;
            \u0006 obj2 = this.\u0001;
            int num = obj2.Height + 1;
            obj1((object) obj2, num);
            this.\u0001.\u001F\u0005();
            break;
          }
          this.\u001D\u0005(\u0003.\u0001.\u0003);
          break;
        case \u0003.\u0001.\u0004:
          if (\u0005\u0081.\u007E\u007F\u0083((object) this.\u0001) < \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001))
          {
            \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, \u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).Y + 1));
            this.\u0001.\u001E\u0005();
            \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, \u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).Y + 1));
            \u0011\u001F obj1 = \u0011\u001F.\u007E\u0099\u0083;
            \u0006 obj2 = this.\u0001;
            int num = obj2.Height - 1;
            obj1((object) obj2, num);
            this.\u0001.\u001F\u0005();
            break;
          }
          this.\u001D\u0005(\u0003.\u0001.\u0005);
          break;
        default:
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          break;
      }
    }

    private void \u001D\u0005(\u0003.\u0001 newState)
    {
      switch (newState)
      {
        case \u0003.\u0001.\u0001:
          switch (this.\u0001)
          {
            case \u0003.\u0001.\u0001:
              \u001A\u001E.\u007E\u0003\u0090((object) this.\u0001);
              \u001A\u001E.\u007E\u0002\u0090((object) this.\u0001);
              return;
            case \u0003.\u0001.\u0002:
              return;
            case \u0003.\u0001.\u0003:
              return;
            case \u0003.\u0001.\u0004:
              this.\u0001 = \u0003.\u0001.\u0002;
              \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, \u0003.\u0001);
              \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
              return;
            case \u0003.\u0001.\u0005:
              this.\u0001 = newState;
              \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, \u0003.\u0002);
              \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
              return;
            default:
              return;
          }
        case \u0003.\u0001.\u0002:
          switch (this.\u0001)
          {
            case \u0003.\u0001.\u0001:
            case \u0003.\u0001.\u0004:
            case \u0003.\u0001.\u0005:
              this.\u0001 = newState;
              \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, \u0003.\u0001);
              \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
              return;
            case \u0003.\u0001.\u0002:
              return;
            case \u0003.\u0001.\u0003:
              return;
            default:
              return;
          }
        case \u0003.\u0001.\u0003:
          if (this.\u0001 != \u0003.\u0001.\u0002)
            break;
          this.\u0001 = newState;
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          if (!\u008D\u0084.\u007E\u0082\u0083((object) this.\u0001).Contains(\u0098\u001B.\u007E\u001A\u0086((object) this.\u0001, \u0098\u0080.\u000F\u0084())))
            break;
          this.\u0080\u0005();
          break;
        case \u0003.\u0001.\u0004:
          switch (this.\u0001)
          {
            case \u0003.\u0001.\u0001:
              this.\u0001 = \u0003.\u0001.\u0005;
              \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
              return;
            case \u0003.\u0001.\u0002:
            case \u0003.\u0001.\u0003:
              this.\u007F\u0005();
              this.\u0001 = newState;
              \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, \u0003.\u0001);
              \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
              return;
            default:
              return;
          }
        case \u0003.\u0001.\u0005:
          if (this.\u0001 != \u0003.\u0001.\u0004)
            break;
          this.\u0001 = newState;
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          this.\u0001 = new Point?();
          this.\u0081\u0005();
          break;
      }
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      this.\u007F\u0005();
    }

    private void \u0089\u0005(object sender, EventArgs e)
    {
      this.\u007F\u0005();
    }

    private void \u008A\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005(!base.FullScreen);
      \u0099\u001F.\u007E\u0082\u0090((object) this.\u0005, base.FullScreen);
    }

    private void \u001E\u0005(object sender, MouseEventArgs e)
    {
      this.\u001E\u0005(!base.FullScreen);
      \u0099\u001F.\u007E\u0082\u0090((object) this.\u0005, base.FullScreen);
    }

    private void \u008B\u0005(object sender, EventArgs e)
    {
      this.\u001F\u0005(true);
    }

    private void \u008C\u0005(object sender, EventArgs e)
    {
      this.\u001F\u0005(false);
    }

    private void \u001F\u0005(bool enable)
    {
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0006, enable);
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0007, !enable);
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0002, enable);
    }

    private void \u008D\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u000E);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u0082\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0003)));
      this.\u0001 = new ToolStrip();
      this.\u0001 = new ToolStripButton();
      this.\u0002 = new ToolStripButton();
      this.\u0001 = new ToolStripSeparator();
      this.\u0003 = new ToolStripButton();
      this.\u0004 = new ToolStripButton();
      this.\u0002 = new ToolStripSeparator();
      this.\u0001 = new ToolStripDropDownButton();
      this.\u0001 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripMenuItem();
      this.\u0003 = new ToolStripMenuItem();
      this.\u0005 = new ToolStripButton();
      this.\u0003 = new ToolStripSeparator();
      this.\u0006 = new ToolStripButton();
      this.\u0007 = new ToolStripButton();
      this.\u0001 = new ToolTip(this.\u0001);
      this.\u0001 = new SaveFileDialog();
      this.\u0001 = new Timer(this.\u0001);
      this.\u0001 = new \u0006();
      this.\u0002 = new Timer(this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, false);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.None);
      \u0080\u001D.\u007E\u0007\u0087((object) this.\u0001, ToolStripGripStyle.Hidden);
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[11]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0005,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0006,
        (ToolStripItem) this.\u0007
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(43559));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(567, 25));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0001, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u0086\u0005));
      \u0088\u001D.\u007E\u0016\u0087((object) this.\u0001, ToolStripItemDisplayStyle.Image);
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(43580)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0001, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0003.\u0001(43617));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(23, 22));
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0001, \u0003.\u0001(43646));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0088\u001D.\u007E\u0016\u0087((object) this.\u0002, ToolStripItemDisplayStyle.Image);
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0002, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(43667)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0002, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0003.\u0001(43696));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(23, 22));
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0002, \u0003.\u0001(43717));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler(this.\u0080\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0003.\u0001(6514));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(6, 25));
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0003, false);
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0003, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(43734)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0003, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0003.\u0001(43763));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(55, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0003.\u0001(43784));
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0003, \u0003.\u0001(43793));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0004, false);
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0004, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(43842)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0004, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0003.\u0001(43875));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(60, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u0003.\u0001(43900));
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0004, \u0003.\u0001(43909));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(this.\u001F\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0003.\u0001(6603));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(6, 25));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0001), new ToolStripItem[3]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0003
      });
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(43934)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0001, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0003.\u0001(43971));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(90, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0003.\u0001(44000));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0003.\u0001(44013));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(253, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0003.\u0001(44034));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0001, new EventHandler(this.\u0081\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0003.\u0001(44047));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(253, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0003.\u0001(44084));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler(this.\u0082\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0003.\u0001(44113));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(253, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0003.\u0001(44166));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(this.\u0083\u0005));
      \u0099\u001F.\u007E\u0081\u0090((object) this.\u0005, true);
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0005, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(44211)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0005, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0003.\u0001(44244));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(84, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u0003.\u0001(44269));
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0005, \u0003.\u0001(44286));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(this.\u008A\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0003.\u0001(39190));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(6, 25));
      \u0088\u001D.\u007E\u0016\u0087((object) this.\u0006, ToolStripItemDisplayStyle.Image);
      \u0099\u001F.\u007E\u0018\u0087((object) this.\u0006, false);
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0006, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(44311)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0006, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u0003.\u0001(25485));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(23, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u0003.\u0001(25502));
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0006, \u0003.\u0001(44336));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(this.\u008C\u0005));
      \u0088\u001D.\u007E\u0016\u0087((object) this.\u0007, ToolStripItemDisplayStyle.Image);
      \u0087\u0081.\u007E\u0019\u0087((object) this.\u0007, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(44357)));
      \u0081\u0082.\u007E\u001A\u0087((object) this.\u0007, \u009A\u0080.\u0001\u007F());
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u0003.\u0001(44382));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(23, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u0003.\u0001(44399));
      \u0092\u0081.\u007E\u0082\u0087((object) this.\u0007, \u0003.\u0001(44408));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0007, new EventHandler(this.\u008B\u0005));
      \u0092\u0081.\u007E\u0095\u008A((object) this.\u0001, \u0003.\u0001(44429));
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 5000);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler(this.\u0087\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0090\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 25));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(44466));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(567, 318));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      this.\u0001.ImageLoaded += new EventHandler(this.\u001D\u0005);
      \u0087\u0086.\u007E\u008D\u0084((object) this.\u0001, new KeyEventHandler(this.\u001D\u0005));
      \u000F\u0086.\u007E\u0091\u0084((object) this.\u0001, new MouseEventHandler(this.\u001E\u0005));
      \u0087\u007F.\u007E\u0093\u0084((object) this.\u0001, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u0086\u0005));
      \u000F\u0086.\u007E\u0096\u0084((object) this.\u0001, new MouseEventHandler(this.\u001D\u0005));
      \u0086\u001D.\u007E\u0098\u0084((object) this.\u0001, new PreviewKeyDownEventHandler(this.\u001D\u0005));
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0002, 4000);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0002, new EventHandler(this.\u008D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u009A\u0080.\u0090\u001F());
      \u000E\u001F.\u0010\u008B((object) this, new Size(567, 343));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(6840)));
      \u0092\u0081.\u0010\u0084((object) this, \u0003.\u0001(44487));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.Manual);
      \u0087\u007F.\u008A\u008B((object) this, new EventHandler(this.\u0088\u0005));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0087\u0086.\u008D\u0084((object) this, new KeyEventHandler(this.\u001D\u0005));
      \u0086\u001D.\u0098\u0084((object) this, new PreviewKeyDownEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u0099\u0084((object) this, new EventHandler(this.\u0089\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
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
