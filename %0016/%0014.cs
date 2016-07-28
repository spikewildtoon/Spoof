// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u001E;
using \u001F;
using \u007F;
using \u0081;
using \u0082;
using \u0083;
using \u0084;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0016
{
  internal class \u0014 : \u0014.\u0017
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    protected \u001F.\u001C \u0001;
    protected \u0003 \u0001;
    protected \u001C.\u0001 \u0001;

    static \u0014()
    {
      \u0004.\u001D\u0005(typeof (\u0016.\u0014));
    }

    public \u0014()
    {
      this.\u0081\u0005();
      this.\u0001 = new \u001F.\u001C();
    }

    protected bool \u001D\u0005(string message, string question, \u0013 ratio, out \u0015.\u0082 bmp, out \u0013 resulting_ratio)
    {
      bmp = (\u0015.\u0082) null;
      resulting_ratio = new \u0013();
      if (!this.\u0001.ProcessOpen && !this.\u0001.\u001D\u0005((Form) this))
        return false;
      \u0007 obj1 = new \u0007((Form) this, true);
      try
      {
        \u0018.\u0017 obj2 = new \u0018.\u0017(question, \u0016.\u0014.\u0001(16091), \u001D.\u0001, (Font) null, 0 != 0, \u0012.\u0002, new \u0018.\u0016[2]{ \u0018.\u0016.\u0001, \u0018.\u0016.\u0002 });
        try
        {
          obj1.\u001D\u0005((Form) obj2, DialogResult.OK);
          if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) != DialogResult.OK)
            return false;
          obj1.\u001D\u0005();
          obj1.\u001E\u0005();
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
        if (this.\u0001.ProcessOpen)
        {
          \u0013.\u001D\u0005((object) this, this.\u0001.MainWindowHandle);
          \u0004 obj3 = new \u0004();
          try
          {
            obj1.\u001D\u0005((Form) obj3, DialogResult.OK);
            if (\u0097\u001E.\u007E\u0099\u008B((object) obj3) == DialogResult.OK)
            {
              obj1.\u001E\u0005();
              obj1.\u001D\u0005();
              if (this.\u0001.ProcessOpen)
              {
                \u0013.\u001D\u0005((object) this, this.\u0001.MainWindowHandle);
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                \u0016.\u0014.\u0001 obj4 = new \u0016.\u0014.\u0001();
                // ISSUE: reference to a compiler-generated field
                obj4.\u0001 = new \u0004(this.\u0001.MainWindowHandle);
                try
                {
                  // ISSUE: reference to a compiler-generated field
                  obj1.\u007F\u0005((Form) obj4.\u0001);
                  Rectangle rectangle = \u0013.\u001E\u0005(this.\u0001.MainWindowHandle);
                  // ISSUE: reference to a compiler-generated field
                  obj4.\u0001.SelectionBounds = Rectangle.Empty;
                  // ISSUE: reference to a compiler-generated field
                  obj4.\u0001.SelectedRegion = ratio.\u001D\u0005(rectangle.Size);
                  // ISSUE: reference to a compiler-generated field
                  obj4.\u0001.RegionSelectorType = \u0019.\u0001;
                  // ISSUE: reference to a compiler-generated field
                  obj4.\u0001.FullSelect = false;
                  // ISSUE: reference to a compiler-generated field
                  obj4.\u0001.FullSize = true;
                  // ISSUE: reference to a compiler-generated field
                  obj4.\u0001.FullScreenCapture = true;
                  // ISSUE: reference to a compiler-generated field
                  obj4.\u0001.MovableResizeMessage = \u0081\u0086.\u0086\u0093(message, \u0016.\u0014.\u0001(16112));
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  obj4.\u0001.Shown += new EventHandler(obj4.\u001D\u0005);
                  // ISSUE: reference to a compiler-generated field
                  if (\u0097\u001E.\u007E\u0099\u008B((object) obj4.\u0001) == DialogResult.OK)
                  {
                    // ISSUE: reference to a compiler-generated field
                    if (obj4.\u0001.SelectedRegion.\u001D\u0005())
                    {
                      // ISSUE: reference to a compiler-generated field
                      bmp = obj4.\u0001.SelectedBitmap;
                      // ISSUE: reference to a compiler-generated field
                      resulting_ratio = \u0013.\u001D\u0005(obj4.\u0001.SelectedRegion, new Rectangle(Point.Empty, rectangle.Size));
                      return true;
                    }
                  }
                }
                finally
                {
                  // ISSUE: reference to a compiler-generated field
                  if (obj4.\u0001 != null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    \u001A\u001E.\u007E\u0094\u0092((object) obj4.\u0001);
                  }
                }
              }
            }
          }
          finally
          {
            if (obj3 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj3);
          }
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
      return false;
    }

    protected static void \u001D\u0005(\u0083.\u0018 pix, \u0010 led)
    {
      if (pix != null)
        led.BaseColor = \u001B\u001C.\u0015\u007F((int) byte.MaxValue, 153, (int) byte.MaxValue, 54);
      else
        led.BaseColor = \u001B\u001C.\u0015\u007F((int) byte.MaxValue, (int) byte.MaxValue, 128, 128);
    }

    protected void \u001D\u0005(\u0083.\u0018 pix, Control ctr)
    {
      this.\u0080\u0005();
      this.\u0001 = new \u001C.\u0001(pix);
      this.\u0001 = new \u0003((Control) this.\u0001);
      this.\u0001.\u001E\u0005(ctr);
    }

    protected void \u0080\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      this.\u0001 = (\u001C.\u0001) null;
    }

    private void \u0081\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0016.\u0014)));
      \u001A\u001E.\u0084\u0086((object) this);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u000E\u001F.\u0010\u008B((object) this, new Size(284, 262));
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0016.\u0014.\u0001(5884)));
      \u0092\u0081.\u0010\u0084((object) this, \u0016.\u0014.\u0001(16173));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
