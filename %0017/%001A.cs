// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u001A;
using \u001F;
using \u0080;
using \u0081;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace \u0017
{
  internal class \u001A : \u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly float \u0001;
    private \u0019<Image> \u0001;
    private Timer \u0001;
    private IContainer \u0001;
    private \u0019<Rectangle> \u0001;
    private \u0016.\u0017 \u0001;
    private float \u0002;
    private bool \u0001;
    private bool \u0002;
    private \u001C \u0001;
    private \u001C \u0002;
    private \u0017.\u001A.\u0001 \u0001;
    private bool \u0003;

    public IntPtr FirstToonTownWindow
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        return this.\u0001.MainWindowHandle;
      }
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] set
      {
        if (!\u0008\u0081.\u0087\u0096(this.\u0001.MainWindowHandle, value))
          return;
        this.\u0087\u0005();
        this.\u0001.MainWindowHandle = value;
      }
    }

    public IntPtr SecondToonTownWindow
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        return this.\u0002.MainWindowHandle;
      }
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] set
      {
        if (!\u0008\u0081.\u0087\u0096(this.\u0002.MainWindowHandle, value))
          return;
        this.\u0088\u0005();
        this.\u0002.MainWindowHandle = value;
      }
    }

    [Description("The left controller image boundary.")]
    [Category("Bounds")]
    public Rectangle LeftControllerBounds
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0001];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0001] = value;
      }
    }

    [Category("Bounds")]
    [Description("The right controller image boundary.")]
    public Rectangle RightControllerBounds
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0002];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0002] = value;
      }
    }

    [Category("Bounds")]
    [Description("The left blue image boundary.")]
    public Rectangle LeftBlueBounds
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0003];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0003] = value;
      }
    }

    [Description("The top yellow image boundary.")]
    [Category("Bounds")]
    public Rectangle TopYellowBounds
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0004];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0004] = value;
      }
    }

    [Category("Bounds")]
    [Description("The bottom green image boundary.")]
    public Rectangle BottomGreenBounds
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0006];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0006] = value;
      }
    }

    [Description("The right red image boundary.")]
    [Category("Bounds")]
    public Rectangle RightRedBounds
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0005];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0005] = value;
      }
    }

    [Category("Bounds")]
    [Description("The setup image boundary.")]
    public Rectangle SetupBounds
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0007];
      }
      set
      {
        if (!\u0019\u007F.\u0095\u0080(this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0007], value))
          return;
        this.\u0084\u0005();
        this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0007] = value;
        this.\u0084\u0005();
      }
    }

    [Category("Bounds")]
    [Description("The close image boundary.")]
    public Rectangle CloseBounds
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0008];
      }
      set
      {
        if (!\u0019\u007F.\u0095\u0080(this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0008], value))
          return;
        this.\u0086\u0005();
        this.\u0001[(Enum) \u0017.\u001A.\u0003.\u0008] = value;
        this.\u0086\u0005();
      }
    }

    [DefaultValue(typeof (Image), null)]
    [Category("Images")]
    [Description("The left controller image pointing left.")]
    public Image LeftController_LeftImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0005];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0005] = value;
      }
    }

    [Category("Images")]
    [Description("The left controller image pointing up.")]
    [DefaultValue(typeof (Image), null)]
    public Image LeftController_TopImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0003];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0003] = value;
      }
    }

    [Description("The left controller image pointing to the top left.")]
    [Category("Images")]
    [DefaultValue(typeof (Image), null)]
    public Image LeftController_TopLeftImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0002];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0002] = value;
      }
    }

    [DefaultValue(typeof (Image), null)]
    [Description("The left controller image pointing to the top right.")]
    [Category("Images")]
    public Image LeftController_TopRightImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0004];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0004] = value;
      }
    }

    [Description("The left controller image pointing to the right.")]
    [DefaultValue(typeof (Image), null)]
    [Category("Images")]
    public Image LeftController_RightImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0006];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0006] = value;
      }
    }

    [Description("The left controller image pointing to the bottom left.")]
    [Category("Images")]
    [DefaultValue(typeof (Image), null)]
    public Image LeftController_BottomLeftImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0007];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0007] = value;
      }
    }

    [Description("The left controller image pointing to the bottom right.")]
    [DefaultValue(typeof (Image), null)]
    [Category("Images")]
    public Image LeftController_BottomRightImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u000E];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u000E] = value;
      }
    }

    [Description("The left controller image pointing to the bottom.")]
    [DefaultValue(typeof (Image), null)]
    [Category("Images")]
    public Image LeftController_BottomImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0008];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0008] = value;
      }
    }

    [Category("Images")]
    [DefaultValue(typeof (Image), null)]
    [Description("The right controller image pointing left.")]
    public Image RightController_LeftImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0012];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0012] = value;
      }
    }

    [Category("Images")]
    [DefaultValue(typeof (Image), null)]
    [Description("The right controller image pointing up.")]
    public Image RightController_TopImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0010];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0010] = value;
      }
    }

    [DefaultValue(typeof (Image), null)]
    [Description("The right controller image pointing to the top left.")]
    [Category("Images")]
    public Image RightController_TopLeftImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u000F];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u000F] = value;
      }
    }

    [Description("The right controller image pointing to the top right.")]
    [DefaultValue(typeof (Image), null)]
    [Category("Images")]
    public Image RightController_TopRightImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0011];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0011] = value;
      }
    }

    [Description("The right controller image pointing to the right.")]
    [Category("Images")]
    [DefaultValue(typeof (Image), null)]
    public Image RightController_RightImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0013];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0013] = value;
      }
    }

    [DefaultValue(typeof (Image), null)]
    [Description("The right controller image pointing to the bottom left.")]
    [Category("Images")]
    public Image RightController_BottomLeftImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0014];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0014] = value;
      }
    }

    [Category("Images")]
    [DefaultValue(typeof (Image), null)]
    [Description("The right controller image pointing to the bottom right.")]
    public Image RightController_BottomRightImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0016];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0016] = value;
      }
    }

    [Description("The right controller image pointing to the bottom.")]
    [Category("Images")]
    [DefaultValue(typeof (Image), null)]
    public Image RightController_BottomImage
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0015];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0015] = value;
      }
    }

    [Description("The top yellow down pressed.")]
    [DefaultValue(typeof (Image), null)]
    [Category("Images")]
    public Image TopYellow_Image
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0018];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0018] = value;
      }
    }

    [Category("Images")]
    [Description("The left blue down pressed.")]
    [DefaultValue(typeof (Image), null)]
    public Image LeftBlue_Image
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0017];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0017] = value;
      }
    }

    [Category("Images")]
    [Description("The right red down pressed.")]
    [DefaultValue(typeof (Image), null)]
    public Image RightRed_Image
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0019];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0019] = value;
      }
    }

    [Category("Images")]
    [Description("The bottom green down pressed.")]
    [DefaultValue(typeof (Image), null)]
    public Image BottomGreen_Image
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u001A];
      }
      set
      {
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u001A] = value;
      }
    }

    [Category("Images")]
    [DefaultValue(typeof (Image), null)]
    [Description("The setup button.")]
    public Image Setup_Image
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u001B];
      }
      set
      {
        if (this.\u0001[(Enum) \u0017.\u001A.\u0002.\u001B] == value)
          return;
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u001B] = value;
        this.\u0084\u0005();
      }
    }

    [Description("The close button.")]
    [Category("Images")]
    [DefaultValue(typeof (Image), null)]
    public Image Close_Image
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u001C];
      }
      set
      {
        if (this.\u0001[(Enum) \u0017.\u001A.\u0002.\u001C] == value)
          return;
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u001C] = value;
        this.\u0086\u0005();
      }
    }

    [Description("The background controller with opacity.")]
    [DefaultValue(typeof (Image), null)]
    [Category("Images")]
    public Image Background
    {
      get
      {
        return this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0001];
      }
      set
      {
        if (this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0001] == value)
          return;
        this.\u0001[(Enum) \u0017.\u001A.\u0002.\u0001] = value;
        if (value != null)
          \u000E\u001F.\u0010\u008B((object) this, \u0083\u001E.\u007E\u001F\u001F((object) value));
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    private bool ADown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0008);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0008))
            return;
          this.\u001D\u0005(true, Keys.Left);
          if (!this.\u0003)
            return;
          this.\u001F\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0008))
            return;
          this.\u001E\u0005(true, Keys.Left);
          if (!this.\u0003)
            return;
          this.\u001F\u0005();
        }
      }
    }

    private bool SpaceDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0006);
      }
      set
      {
        if (!value)
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0006))
            return;
          this.\u001E\u0005(true, Keys.ControlKey);
          this.\u001E\u0005(false, Keys.ControlKey);
          if (!this.\u0003)
            return;
          this.\u0083\u0005();
        }
        else
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0006))
            return;
          this.\u001D\u0005(true, Keys.ControlKey);
          this.\u001D\u0005(false, Keys.ControlKey);
          if (!this.\u0003)
            return;
          this.\u0083\u0005();
        }
      }
    }

    private bool ShiftDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0004);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0004))
            return;
          this.\u001D\u0005(true, Keys.ControlKey);
          if (!this.\u0003)
            return;
          this.\u0083\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0004))
            return;
          this.\u001E\u0005(true, Keys.ControlKey);
          if (!this.\u0003)
            return;
          this.\u0083\u0005();
        }
      }
    }

    private bool ControlDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0005);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0005))
            return;
          this.\u001D\u0005(false, Keys.ControlKey);
          if (!this.\u0003)
            return;
          this.\u0083\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0005))
            return;
          this.\u001E\u0005(false, Keys.ControlKey);
          if (!this.\u0003)
            return;
          this.\u0083\u0005();
        }
      }
    }

    private bool DDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u000F);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u000F))
            return;
          this.\u001D\u0005(true, Keys.Right);
          if (!this.\u0003)
            return;
          this.\u001F\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u000F))
            return;
          this.\u001E\u0005(true, Keys.Right);
          if (!this.\u0003)
            return;
          this.\u001F\u0005();
        }
      }
    }

    private bool WDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0007);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0007))
            return;
          this.\u001D\u0005(true, Keys.Up);
          if (!this.\u0003)
            return;
          this.\u001F\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0007))
            return;
          this.\u001E\u0005(true, Keys.Up);
          if (!this.\u0003)
            return;
          this.\u001F\u0005();
        }
      }
    }

    private bool SDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u000E);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u000E))
            return;
          this.\u001D\u0005(true, Keys.Down);
          if (!this.\u0003)
            return;
          this.\u001F\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u000E))
            return;
          this.\u001E\u0005(true, Keys.Down);
          if (!this.\u0003)
            return;
          this.\u001F\u0005();
        }
      }
    }

    private bool LeftDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0014);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0014))
            return;
          this.\u001D\u0005(false, Keys.Left);
          if (!this.\u0003)
            return;
          this.\u007F\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0014))
            return;
          this.\u001E\u0005(false, Keys.Left);
          if (!this.\u0003)
            return;
          this.\u007F\u0005();
        }
      }
    }

    private bool RightDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0016);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0016))
            return;
          this.\u001D\u0005(false, Keys.Right);
          if (!this.\u0003)
            return;
          this.\u007F\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0016))
            return;
          this.\u001E\u0005(false, Keys.Right);
          if (!this.\u0003)
            return;
          this.\u007F\u0005();
        }
      }
    }

    private bool UpDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0013);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0013))
            return;
          this.\u001D\u0005(false, Keys.Up);
          if (!this.\u0003)
            return;
          this.\u007F\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0013))
            return;
          this.\u001E\u0005(false, Keys.Up);
          if (!this.\u0003)
            return;
          this.\u007F\u0005();
        }
      }
    }

    private bool DownDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0015);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0015))
            return;
          this.\u001D\u0005(false, Keys.Down);
          if (!this.\u0003)
            return;
          this.\u007F\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0015))
            return;
          this.\u001E\u0005(false, Keys.Down);
          if (!this.\u0003)
            return;
          this.\u007F\u0005();
        }
      }
    }

    private bool XDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0011);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0011))
            return;
          this.\u001D\u0005(false, Keys.Escape);
          if (!this.\u0003)
            return;
          this.\u0080\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0011))
            return;
          this.\u001E\u0005(false, Keys.Escape);
          if (!this.\u0003)
            return;
          this.\u0080\u0005();
        }
      }
    }

    private bool ZDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0010);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0010))
            return;
          this.\u001D\u0005(true, Keys.Escape);
          if (!this.\u0003)
            return;
          this.\u0080\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0010))
            return;
          this.\u001E\u0005(true, Keys.Escape);
          if (!this.\u0003)
            return;
          this.\u0080\u0005();
        }
      }
    }

    private bool CDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0012);
      }
      set
      {
        if (!value)
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0012))
            return;
          this.\u001E\u0005(true, Keys.Escape);
          this.\u001E\u0005(false, Keys.Escape);
          if (!this.\u0003)
            return;
          this.\u0080\u0005();
        }
        else
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0012))
            return;
          this.\u001D\u0005(true, Keys.Escape);
          this.\u001D\u0005(false, Keys.Escape);
          if (!this.\u0003)
            return;
          this.\u0080\u0005();
        }
      }
    }

    private bool EVDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0002);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0002))
            return;
          this.\u001D\u0005(true, Keys.Delete);
          if (!this.\u0003)
            return;
          this.\u0081\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0002))
            return;
          this.\u001E\u0005(true, Keys.Delete);
          if (!this.\u0003)
            return;
          this.\u0081\u0005();
        }
      }
    }

    private bool NumPad0EndDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0003);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0003))
            return;
          this.\u001D\u0005(false, Keys.Delete);
          if (!this.\u0003)
            return;
          this.\u0081\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0003))
            return;
          this.\u001E\u0005(false, Keys.Delete);
          if (!this.\u0003)
            return;
          this.\u0081\u0005();
        }
      }
    }

    private bool QDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0017);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0017))
            return;
          this.\u001D\u0005(true, Keys.Home);
          if (!this.\u0003)
            return;
          this.\u0082\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0017))
            return;
          this.\u001E\u0005(true, Keys.Home);
          if (!this.\u0003)
            return;
          this.\u0082\u0005();
        }
      }
    }

    private bool ForwardSlashQuestionMarkDown
    {
      get
      {
        return this.\u001D\u0005(\u0017.\u001A.\u0001.\u0018);
      }
      set
      {
        if (value)
        {
          if (!this.\u001E\u0005(\u0017.\u001A.\u0001.\u0018))
            return;
          this.\u001D\u0005(false, Keys.Home);
          if (!this.\u0003)
            return;
          this.\u0082\u0005();
        }
        else
        {
          if (!this.\u001F\u0005(\u0017.\u001A.\u0001.\u0018))
            return;
          this.\u001E\u0005(false, Keys.Home);
          if (!this.\u0003)
            return;
          this.\u0082\u0005();
        }
      }
    }

    public bool AnimateController
    {
      get
      {
        return this.\u0003;
      }
      set
      {
        if (this.\u0003 == value)
          return;
        this.\u0003 = value;
        if (!base.UseOpacity || \u0099\u0082.\u0081\u0001\u0002((object) this))
          \u001A\u001E.\u0004\u0086((object) this);
        else
          base.\u001D\u0005();
      }
    }

    public override bool UseOpacity
    {
      get
      {
        return base.UseOpacity;
      }
      set
      {
        if (base.UseOpacity == value)
          return;
        base.UseOpacity = value;
        if (base.UseOpacity)
          \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.None);
        else
          \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      }
    }

    public \u0007 KeyboardLayout { get; set; }

    public event EventHandler SetupClicked;

    public event EventHandler CloseClicked;

    static \u001A()
    {
      \u0004.\u001D\u0005(typeof (\u0017.\u001A));
      \u0017.\u001A.\u0001 = 0.04f;
    }

    public \u001A()
    {
      this.\u001E\u0005();
      this.CustomPainting = true;
      this.\u0001 = new \u0019<Image>(23);
      this.\u0001 = new \u0019<Rectangle>(8);
      this.\u0001 = \u0016.\u0017.\u0001;
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      this.\u0001 = new \u001C();
      this.\u0001.ProcessExited += (EventHandler) ((obj, e) => this.\u0087\u0005());
      this.\u0002 = new \u001C();
      this.\u0002.ProcessExited += (EventHandler) ((obj, e) => this.\u0088\u0005());
    }

    protected override void Dispose(bool disposing)
    {
      this.\u0001.Dispose();
      this.\u0002.Dispose();
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u001E\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new Timer(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 10);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u000E\u001F.\u0010\u008B((object) this, new Size(284, 262));
      \u0092\u0081.\u0010\u0084((object) this, \u0017.\u001A.\u0001(28348));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private bool \u001D\u0005(\u0017.\u001A.\u0001 flag)
    {
      return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) flag);
    }

    private bool \u001E\u0005(\u0017.\u001A.\u0001 flag)
    {
      if (this.\u001D\u0005(flag))
        return false;
      this.\u0001 |= flag;
      return true;
    }

    private bool \u001F\u0005(\u0017.\u001A.\u0001 flag)
    {
      if (!this.\u001D\u0005(flag))
        return false;
      this.\u0001 &= ~flag;
      return true;
    }

    private void \u001F\u0005()
    {
      if (base.UseOpacity && !\u0099\u0082.\u0081\u0001\u0002((object) this))
      {
        base.\u001D\u0005();
      }
      else
      {
        if (!this.LeftControllerBounds.\u001D\u0005())
          return;
        \u000E\u0080.\u0005\u0086((object) this, this.LeftControllerBounds);
      }
    }

    private void \u007F\u0005()
    {
      if (base.UseOpacity && !\u0099\u0082.\u0081\u0001\u0002((object) this))
      {
        base.\u001D\u0005();
      }
      else
      {
        if (!this.RightControllerBounds.\u001D\u0005())
          return;
        \u000E\u0080.\u0005\u0086((object) this, this.RightControllerBounds);
      }
    }

    private void \u0080\u0005()
    {
      if (base.UseOpacity && !\u0099\u0082.\u0081\u0001\u0002((object) this))
      {
        base.\u001D\u0005();
      }
      else
      {
        if (!this.TopYellowBounds.\u001D\u0005())
          return;
        \u000E\u0080.\u0005\u0086((object) this, this.TopYellowBounds);
      }
    }

    private void \u0081\u0005()
    {
      if (base.UseOpacity && !\u0099\u0082.\u0081\u0001\u0002((object) this))
      {
        base.\u001D\u0005();
      }
      else
      {
        if (!this.RightRedBounds.\u001D\u0005())
          return;
        \u000E\u0080.\u0005\u0086((object) this, this.RightRedBounds);
      }
    }

    private void \u0082\u0005()
    {
      if (base.UseOpacity && !\u0099\u0082.\u0081\u0001\u0002((object) this))
      {
        base.\u001D\u0005();
      }
      else
      {
        if (!this.BottomGreenBounds.\u001D\u0005())
          return;
        \u000E\u0080.\u0005\u0086((object) this, this.BottomGreenBounds);
      }
    }

    private void \u0083\u0005()
    {
      if (base.UseOpacity && !\u0099\u0082.\u0081\u0001\u0002((object) this))
      {
        base.\u001D\u0005();
      }
      else
      {
        if (!this.LeftBlueBounds.\u001D\u0005())
          return;
        \u000E\u0080.\u0005\u0086((object) this, this.LeftBlueBounds);
      }
    }

    private void \u0084\u0005()
    {
      if (base.UseOpacity && !\u0099\u0082.\u0081\u0001\u0002((object) this))
      {
        base.\u001D\u0005();
      }
      else
      {
        if (!this.SetupBounds.\u001D\u0005())
          return;
        \u000E\u0080.\u0005\u0086((object) this, this.SetupBounds);
      }
    }

    private void \u0086\u0005()
    {
      if (base.UseOpacity && !\u0099\u0082.\u0081\u0001\u0002((object) this))
      {
        base.\u001D\u0005();
      }
      else
      {
        if (!this.CloseBounds.\u001D\u0005())
          return;
        \u000E\u0080.\u0005\u0086((object) this, this.CloseBounds);
      }
    }

    protected override void \u001D\u0005(Graphics gr)
    {
      if (this.Background != null)
        \u0004\u001F.\u007E\u009E\u007F((object) gr, this.Background, \u008D\u0084.\u0082\u0083((object) this));
      if (this.\u0003)
      {
        if (this.LeftControllerBounds.\u001D\u0005())
        {
          if (this.ADown && this.WDown)
          {
            if (this.LeftController_TopLeftImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.LeftController_TopLeftImage, this.LeftControllerBounds);
          }
          else if (this.DDown && this.WDown)
          {
            if (this.LeftController_TopRightImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.LeftController_TopRightImage, this.LeftControllerBounds);
          }
          else if (this.ADown && this.SDown)
          {
            if (this.LeftController_BottomLeftImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.LeftController_BottomLeftImage, this.LeftControllerBounds);
          }
          else if (this.DDown && this.SDown)
          {
            if (this.LeftController_BottomRightImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.LeftController_BottomRightImage, this.LeftControllerBounds);
          }
          else if (this.ADown)
          {
            if (this.LeftController_LeftImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.LeftController_LeftImage, this.LeftControllerBounds);
          }
          else if (this.DDown)
          {
            if (this.LeftController_RightImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.LeftController_RightImage, this.LeftControllerBounds);
          }
          else if (this.WDown)
          {
            if (this.LeftController_TopImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.LeftController_TopImage, this.LeftControllerBounds);
          }
          else if (this.SDown && this.LeftController_BottomImage != null)
            \u0004\u001F.\u007E\u009E\u007F((object) gr, this.LeftController_BottomImage, this.LeftControllerBounds);
        }
        if (this.RightControllerBounds.\u001D\u0005())
        {
          if (this.LeftDown && this.UpDown)
          {
            if (this.RightController_TopLeftImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.RightController_TopLeftImage, this.RightControllerBounds);
          }
          else if (this.RightDown && this.UpDown)
          {
            if (this.RightController_TopRightImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.RightController_TopRightImage, this.RightControllerBounds);
          }
          else if (this.LeftDown && this.DownDown)
          {
            if (this.RightController_BottomLeftImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.RightController_BottomLeftImage, this.RightControllerBounds);
          }
          else if (this.RightDown && this.DownDown)
          {
            if (this.RightController_BottomRightImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.RightController_BottomRightImage, this.RightControllerBounds);
          }
          else if (this.LeftDown)
          {
            if (this.RightController_LeftImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.RightController_LeftImage, this.RightControllerBounds);
          }
          else if (this.RightDown)
          {
            if (this.RightController_RightImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.RightController_RightImage, this.RightControllerBounds);
          }
          else if (this.UpDown)
          {
            if (this.RightController_TopImage != null)
              \u0004\u001F.\u007E\u009E\u007F((object) gr, this.RightController_TopImage, this.RightControllerBounds);
          }
          else if (this.DownDown && this.RightController_BottomImage != null)
            \u0004\u001F.\u007E\u009E\u007F((object) gr, this.RightController_BottomImage, this.RightControllerBounds);
        }
        if (this.TopYellowBounds.\u001D\u0005() && (this.ZDown || this.XDown || this.CDown) && this.TopYellow_Image != null)
          \u0004\u001F.\u007E\u009E\u007F((object) gr, this.TopYellow_Image, this.TopYellowBounds);
        if (this.LeftBlueBounds.\u001D\u0005() && (this.ShiftDown || this.ControlDown || this.SpaceDown) && this.LeftBlue_Image != null)
          \u0004\u001F.\u007E\u009E\u007F((object) gr, this.LeftBlue_Image, this.LeftBlueBounds);
        if (this.RightRedBounds.\u001D\u0005() && (this.EVDown || this.NumPad0EndDown) && this.RightRed_Image != null)
          \u0004\u001F.\u007E\u009E\u007F((object) gr, this.RightRed_Image, this.RightRedBounds);
        if (this.BottomGreenBounds.\u001D\u0005() && (this.QDown || this.ForwardSlashQuestionMarkDown) && this.BottomGreen_Image != null)
          \u0004\u001F.\u007E\u009E\u007F((object) gr, this.BottomGreen_Image, this.BottomGreenBounds);
      }
      if ((double) this.\u0002 <= 0.0)
        return;
      if (this.CloseBounds.\u001D\u0005() && this.Close_Image != null)
        gr.\u001D\u0005(this.Close_Image, this.CloseBounds, this.\u0002 + (this.\u0001 ? 0.5f : 0.0f));
      if (!this.SetupBounds.\u001D\u0005() || this.Setup_Image == null)
        return;
      gr.\u001D\u0005(this.Setup_Image, this.SetupBounds, this.\u0002 + (this.\u0002 ? 0.5f : 0.0f));
    }

    private void \u001D\u0005(bool leftController, Keys key)
    {
      IntPtr hWnd = leftController ? this.\u0001.MainWindowHandle : this.\u0002.MainWindowHandle;
      if (!\u0008\u0081.\u0087\u0096(hWnd, IntPtr.Zero))
        return;
      \u000E.\u001E\u0005(hWnd, key);
    }

    private void \u001E\u0005(bool leftController, Keys key)
    {
      IntPtr hWnd = leftController ? this.\u0001.MainWindowHandle : this.\u0002.MainWindowHandle;
      if (!\u0008\u0081.\u0087\u0096(hWnd, IntPtr.Zero))
        return;
      \u000E.\u001F\u0005(hWnd, key);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
      this.\u001D\u0005(true, e);
      \u0084\u0086.\u000F\u0086((object) this, e);
    }

    protected override void OnKeyUp(KeyEventArgs e)
    {
      this.\u001D\u0005(false, e);
      \u0084\u0086.\u0010\u0086((object) this, e);
    }

    private void \u0087\u0005()
    {
      this.ADown = false;
      this.WDown = false;
      this.DDown = false;
      this.SDown = false;
      this.ZDown = false;
      this.EVDown = false;
      this.ShiftDown = false;
      this.QDown = false;
      this.\u0089\u0005();
    }

    private void \u0088\u0005()
    {
      this.UpDown = false;
      this.LeftDown = false;
      this.RightDown = false;
      this.DownDown = false;
      this.XDown = false;
      this.ControlDown = false;
      this.NumPad0EndDown = false;
      this.ForwardSlashQuestionMarkDown = false;
      this.\u0089\u0005();
    }

    private void \u0089\u0005()
    {
      this.CDown = false;
      this.SpaceDown = false;
    }

    private Keys \u001D\u0005(Keys key)
    {
      switch (this.KeyboardLayout)
      {
        case \u0007.\u0002:
          Keys keys = key;
          if (keys > Keys.Q)
          {
            switch (keys)
            {
              case Keys.OemSemicolon:
                return Keys.OemCloseBrackets;
              case Keys.Oemcomma:
                return Keys.M;
              case Keys.OemPeriod:
                return Keys.Oemcomma;
              case Keys.OemQuestion:
                return Keys.OemPeriod;
              case Keys.Oemtilde:
                return Keys.OemQuotes;
              case Keys.OemCloseBrackets:
                return Keys.OemOpenBrackets;
              case Keys.Oem8:
                return Keys.OemQuestion;
              case Keys.W:
                return Keys.Z;
              case Keys.Z:
                return Keys.W;
            }
          }
          else
            goto label_26;
label_15:
          return key;
label_26:
          if (keys == Keys.A)
            return Keys.Q;
          if (keys == Keys.M)
            return Keys.OemSemicolon;
          if (keys == Keys.Q)
            return Keys.A;
          goto label_15;
        case \u0007.\u0003:
          switch (key)
          {
            case Keys.Y:
              return Keys.Z;
            case Keys.Z:
              return Keys.Y;
            case Keys.OemSemicolon:
              return Keys.OemOpenBrackets;
            case Keys.Oemplus:
              return Keys.OemCloseBrackets;
            case Keys.OemMinus:
              return Keys.OemQuestion;
            case Keys.Oemtilde:
              return Keys.OemSemicolon;
            default:
              return key;
          }
        default:
          return key;
      }
    }

    private void \u001D\u0005(bool keyDown, KeyEventArgs e)
    {
      Keys keys = this.\u001D\u0005(\u007F\u0081.\u007E\u0013\u008C((object) e));
      if (keys > Keys.E)
      {
        switch (keys)
        {
          case Keys.Q:
            if (!this.\u0001.ProcessOpen)
              return;
            this.QDown = keyDown;
            return;
          case Keys.R:
            return;
          case Keys.S:
            if (!this.\u0001.ProcessOpen)
              return;
            this.SDown = keyDown;
            return;
          case Keys.T:
            return;
          case Keys.U:
            return;
          case Keys.V:
            break;
          case Keys.W:
            if (!this.\u0001.ProcessOpen)
              return;
            this.WDown = keyDown;
            return;
          case Keys.X:
            if (!this.\u0002.ProcessOpen)
              return;
            this.XDown = keyDown;
            return;
          case Keys.Y:
            return;
          case Keys.Z:
            if (!this.\u0001.ProcessOpen)
              return;
            this.ZDown = keyDown;
            return;
          case Keys.NumPad0:
            goto label_41;
          case Keys.OemQuestion:
            if (!this.\u0002.ProcessOpen)
              return;
            this.ForwardSlashQuestionMarkDown = keyDown;
            return;
          default:
            return;
        }
      }
      else
        goto label_47;
label_39:
      if (!this.\u0001.ProcessOpen)
        return;
      this.EVDown = keyDown;
      return;
label_41:
      if (!this.\u0002.ProcessOpen)
        return;
      this.NumPad0EndDown = keyDown;
      return;
label_47:
      switch (keys - 16)
      {
        case Keys.None:
          if (!this.\u0001.ProcessOpen)
            break;
          this.ShiftDown = keyDown;
          break;
        case Keys.LButton:
          if (!this.\u0002.ProcessOpen)
            break;
          this.ControlDown = keyDown;
          break;
        default:
          switch (keys - 32)
          {
            case Keys.None:
              if (!this.\u0001.ProcessOpen && !this.\u0002.ProcessOpen)
                return;
              this.SpaceDown = keyDown;
              return;
            case Keys.LButton:
              return;
            case Keys.RButton:
              return;
            case Keys.Cancel:
              goto label_41;
            case Keys.MButton:
              return;
            case Keys.XButton1:
              if (!this.\u0002.ProcessOpen)
                return;
              this.LeftDown = keyDown;
              return;
            case Keys.XButton2:
              if (!this.\u0001.ProcessOpen)
                return;
              this.UpDown = keyDown;
              return;
            case Keys.Cancel | Keys.MButton:
              if (!this.\u0002.ProcessOpen)
                return;
              this.RightDown = keyDown;
              return;
            case Keys.Back:
              if (!this.\u0002.ProcessOpen)
                return;
              this.DownDown = keyDown;
              return;
            default:
              switch (keys - 65)
              {
                case Keys.None:
                  if (!this.\u0001.ProcessOpen)
                    return;
                  this.ADown = keyDown;
                  return;
                case Keys.LButton:
                  return;
                case Keys.RButton:
                  if (!this.\u0001.ProcessOpen && !this.\u0002.ProcessOpen)
                    return;
                  this.CDown = keyDown;
                  return;
                case Keys.Cancel:
                  if (!this.\u0001.ProcessOpen)
                    return;
                  this.DDown = keyDown;
                  return;
                case Keys.MButton:
                  goto label_39;
                default:
                  return;
              }
          }
      }
    }

    protected override void OnLostFocus(EventArgs e)
    {
      this.\u0087\u0005();
      this.\u0088\u0005();
      base.OnLostFocus(e);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      if (\u0099\u0082.\u0081\u0001\u0002((object) this))
        return;
      Screen screen = \u0017\u0081.\u0017\u008F((Control) this);
      \u0096\u0086.\u0018\u008B((object) this, new Point(\u008D\u0084.\u007E\u0015\u008F((object) screen).X + \u008D\u0084.\u007E\u0015\u008F((object) screen).Width / 2 - \u0005\u0081.\u0083\u0084((object) this) / 2, \u008D\u0084.\u007E\u0015\u008F((object) screen).Y + \u008D\u0084.\u007E\u0015\u008F((object) screen).Height - \u0005\u0081.\u0098\u0083((object) this)));
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      switch (this.\u0001)
      {
        case \u0016.\u0017.\u0002:
          this.\u0002 += \u0017.\u001A.\u0001;
          if ((double) this.\u0002 >= 0.5)
            goto label_11;
label_1:
          if (!base.UseOpacity || \u0099\u0082.\u0081\u0001\u0002((object) this))
          {
            this.\u0084\u0005();
            this.\u0086\u0005();
            break;
          }
          base.\u001D\u0005();
          break;
label_11:
          this.\u0002 = 0.5f;
          this.\u0001 = \u0016.\u0017.\u0004;
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          goto label_1;
        case \u0016.\u0017.\u0003:
          this.\u0002 -= \u0017.\u001A.\u0001;
          if ((double) this.\u0002 <= 0.0)
          {
            this.\u0002 = 0.0f;
            this.\u0001 = \u0016.\u0017.\u0001;
            \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          }
          if (!base.UseOpacity || \u0099\u0082.\u0081\u0001\u0002((object) this))
          {
            this.\u0084\u0005();
            this.\u0086\u0005();
            break;
          }
          base.\u001D\u0005();
          break;
        default:
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
          break;
      }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      switch (this.\u0001)
      {
        case \u0016.\u0017.\u0002:
        case \u0016.\u0017.\u0004:
          this.\u0001 = \u0016.\u0017.\u0003;
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
          break;
      }
      \u0088\u001C.\u0014\u0086((object) this, e);
    }

    protected override void OnMouseEnter(EventArgs e)
    {
      switch (this.\u0001)
      {
        case \u0016.\u0017.\u0001:
        case \u0016.\u0017.\u0003:
          this.\u0001 = \u0016.\u0017.\u0002;
          \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
          break;
      }
      \u0088\u001C.\u0013\u0086((object) this, e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      if (!this.SetupBounds.Contains(\u008E\u0084.\u007E\u0090\u008A((object) e)))
      {
        if (this.CloseBounds.Contains(\u008E\u0084.\u007E\u0090\u008A((object) e)))
        {
          if (!this.\u0001)
          {
            this.\u0001 = true;
            this.\u0086\u0005();
            \u0081\u001C.\u007E\u0088\u0083((object) this, \u009B\u0086.\u0008\u008A());
            if (this.\u0002)
            {
              this.\u0002 = false;
              this.\u0084\u0005();
            }
          }
        }
        else if (this.\u0001)
        {
          this.\u0001 = false;
          this.\u0086\u0005();
          \u0081\u001C.\u007E\u0088\u0083((object) this, \u009B\u0086.\u0007\u008A());
        }
        else if (this.\u0002)
        {
          this.\u0002 = false;
          this.\u0084\u0005();
          \u0081\u001C.\u007E\u0088\u0083((object) this, \u009B\u0086.\u0007\u008A());
        }
      }
      else
        goto label_11;
label_10:
      base.OnMouseMove(e);
      return;
label_11:
      if (!this.\u0002)
      {
        this.\u0002 = true;
        this.\u0084\u0005();
        \u0081\u001C.\u007E\u0088\u0083((object) this, \u009B\u0086.\u0008\u008A());
        if (this.\u0001)
        {
          this.\u0001 = false;
          this.\u0086\u0005();
          goto label_10;
        }
        else
          goto label_10;
      }
      else
        goto label_10;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      if (this.\u0002 || this.\u0001)
        return;
      base.OnMouseDown(e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      if (this.\u0002)
      {
        if (this.\u0001 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
      }
      else if (!this.\u0001)
      {
        base.OnMouseUp(e);
      }
      else
      {
        if (this.\u0002 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
      }
    }

    [Flags]
    private enum \u0001
    {
      \u0001 = 0,
      \u0002 = 1,
      \u0003 = 2,
      \u0004 = 4,
      \u0005 = 8,
      \u0006 = 16,
      \u0007 = 32,
      \u0008 = 64,
      \u000E = 128,
      \u000F = 256,
      \u0010 = 512,
      \u0011 = 1024,
      \u0012 = 2048,
      \u0013 = 4096,
      \u0014 = 8192,
      \u0015 = 16384,
      \u0016 = 32768,
      \u0017 = 65536,
      \u0018 = 131072,
    }

    private enum \u0002
    {
      \u0001,
      \u0002,
      \u0003,
      \u0004,
      \u0005,
      \u0006,
      \u0007,
      \u0008,
      \u000E,
      \u000F,
      \u0010,
      \u0011,
      \u0012,
      \u0013,
      \u0014,
      \u0015,
      \u0016,
      \u0017,
      \u0018,
      \u0019,
      \u001A,
      \u001B,
      \u001C,
    }

    private enum \u0003
    {
      \u0001,
      \u0002,
      \u0003,
      \u0004,
      \u0005,
      \u0006,
      \u0007,
      \u0008,
    }
  }
}
