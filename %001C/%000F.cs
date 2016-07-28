// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u001A;
using \u001C;
using \u0081;
using \u0083;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace \u001C
{
  internal sealed class \u000F
  {
    public static readonly int \u0001 = \u0082\u001D.\u0005\u009D(\u009C\u0082.\u0016\u0097(__typeref (\u0007)));
    private List<\u0007> \u0001;

    public int Count
    {
      get
      {
        return this.\u0001.Count;
      }
    }

    public \u000F()
    {
      this.\u0001 = new List<\u0007>();
    }

    public \u0007[] \u001D\u0005()
    {
      return this.\u0001.ToArray();
    }

    public \u000F \u001D\u0005(Keys key)
    {
      this.\u0001.Add(new \u0007()
      {
        \u0001 = \u001D.\u0002,
        \u0001 = {
          \u0001 = {
            \u0001 = (ushort) key,
            \u0001 = \u000E.\u0080\u0005(),
            \u0001 = 0U,
            \u0002 = (ushort) 0
          }
        }
      });
      return this;
    }

    public \u000F \u001E\u0005(Keys key)
    {
      this.\u0001.Add(new \u0007()
      {
        \u0001 = \u001D.\u0002,
        \u0001 = {
          \u0001 = {
            \u0001 = (ushort) key,
            \u0001 = \u0011.\u0002,
            \u0001 = \u000E.\u0080\u0005(),
            \u0001 = 0U,
            \u0002 = (ushort) 0
          }
        }
      });
      return this;
    }

    public \u000F \u001F\u0005(Keys key)
    {
      this.\u001D\u0005(key);
      this.\u001E\u0005(key);
      return this;
    }

    public \u000F \u001D\u0005(Keys modifierKeyCode, Keys keyCode)
    {
      this.\u001D\u0005(modifierKeyCode);
      this.\u001F\u0005(keyCode);
      this.\u001E\u0005(modifierKeyCode);
      return this;
    }

    public \u000F \u001D\u0005(Point p)
    {
      this.\u0001.Add(new \u0007()
      {
        \u0001 = \u001D.\u0001,
        \u0001 = {
          \u0001 = {
            \u0001 = \u0080.\u0001 | \u0080.\u0011,
            \u0001 = p.X,
            \u0002 = p.Y
          }
        }
      });
      return this;
    }

    public \u000F \u001D\u0005(MouseButtons button)
    {
      \u0007 obj1 = new \u0007();
      obj1.\u0001 = \u001D.\u0001;
      \u0080 obj2 = button.\u001D\u0005(true);
      obj1.\u0001.\u0001.\u0001 = obj2;
      switch (button)
      {
        case MouseButtons.XButton1:
          obj1.\u0001.\u0001.\u0001 = 1U;
          break;
        case MouseButtons.XButton2:
          obj1.\u0001.\u0001.\u0001 = 2U;
          break;
      }
      this.\u0001.Add(obj1);
      return this;
    }

    public \u000F \u001E\u0005(MouseButtons button)
    {
      \u0007 obj1 = new \u0007();
      obj1.\u0001 = \u001D.\u0001;
      \u0080 obj2 = button.\u001D\u0005(false);
      obj1.\u0001.\u0001.\u0001 = obj2;
      switch (button)
      {
        case MouseButtons.XButton1:
          obj1.\u0001.\u0001.\u0001 = 1U;
          break;
        case MouseButtons.XButton2:
          obj1.\u0001.\u0001.\u0001 = 2U;
          break;
      }
      this.\u0001.Add(obj1);
      return this;
    }
  }
}
