// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001B;
using \u0080;
using \u0083;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0017
{
  internal sealed class \u001B : \u0017.\u001A
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private IContainer \u0001;
    private \u001C.\u0081 \u0001;

    static \u001B()
    {
      \u0004.\u001D\u0005(typeof (\u0017.\u001B));
    }

    public \u001B()
    {
      this.\u008A\u0005();
      this.\u0001 = \u0081.\u0080.Instance.RemoteControllerSettings;
      this.\u008B\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u008A\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0017.\u001B)));
      \u001A\u001E.\u0084\u0086((object) this);
      this.AllowFormDrag = true;
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      this.Background = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28443));
      this.BottomGreen_Image = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28468));
      this.BottomGreenBounds = new Rectangle(211, 76, 21, 20);
      \u000E\u001F.\u0010\u008B((object) this, new Size(320, 240));
      this.Close_Image = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28501));
      this.CloseBounds = new Rectangle(231, 150, 53, 58);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(6369)));
      this.LeftBlue_Image = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28526));
      this.LeftBlueBounds = new Rectangle(193, 58, 22, 19);
      this.LeftController_BottomImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28555));
      this.LeftController_BottomLeftImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28600));
      this.LeftController_BottomRightImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28649));
      this.LeftController_LeftImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28702));
      this.LeftController_RightImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28743));
      this.LeftController_TopImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28788));
      this.LeftController_TopLeftImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28829));
      this.LeftController_TopRightImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28874));
      this.LeftControllerBounds = new Rectangle(64, 42, 67, 60);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0017.\u001B.\u0001(28923));
      this.RightController_BottomImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28944));
      this.RightController_BottomLeftImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(28989));
      this.RightController_BottomRightImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(29042));
      this.RightController_LeftImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(29095));
      this.RightController_RightImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(29140));
      this.RightController_TopImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(29185));
      this.RightController_TopLeftImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(29226));
      this.RightController_TopRightImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(29275));
      this.RightControllerBounds = new Rectangle(133, 81, 137, 73);
      this.RightRed_Image = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(29324));
      this.RightRedBounds = new Rectangle(228, 64, 15, 15);
      this.Setup_Image = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(29353));
      this.SetupBounds = new Rectangle(39, 152, 53, 58);
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0017.\u001B.\u0001(29378));
      this.TopYellow_Image = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u001B.\u0001(29419));
      this.TopYellowBounds = new Rectangle(212, 47, 15, 15);
      this.SetupClicked += new EventHandler(this.\u0080\u0005);
      this.CloseClicked += new EventHandler(this.\u007F\u0005);
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u001D obj2 = new \u001D();
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          obj2.FirstSelectedWindow = this.FirstToonTownWindow;
          obj2.SecondSelectedWindow = this.SecondToonTownWindow;
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2);
          this.FirstToonTownWindow = obj2.FirstSelectedWindow;
          this.SecondToonTownWindow = obj2.SecondSelectedWindow;
          this.\u008B\u0005();
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    private void \u008B\u0005()
    {
      this.UseOpacity = this.\u0001.UseOpacity;
      this.AnimateController = this.\u0001.AnimateController;
      \u0099\u001F.\u0086\u008B((object) this, this.\u0001.TopMost);
      this.KeyboardLayout = this.\u0001.KeyboardLayout;
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0082.\u001D\u0005(\u0002.\u0011);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }
  }
}
