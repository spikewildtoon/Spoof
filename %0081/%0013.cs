// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0080;
using \u0081;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace \u0081
{
  internal struct \u0013
  {
    public static readonly \u0013 \u0001 = new \u0013(0.0, 0.0, 0.0, 0.0);
    public readonly double \u0001;
    public readonly double \u0002;
    public readonly double \u0003;
    public readonly double \u0004;

    public bool IsEmpty
    {
      get
      {
        if (this.\u0001 != 0.0 || this.\u0002 != 0.0 || this.\u0003 != 0.0)
          return false;
        return this.\u0004 == 0.0;
      }
    }

    public bool IsSizeEmpty
    {
      get
      {
        if (this.\u0003 == 0.0)
          return true;
        return this.\u0004 == 0.0;
      }
    }

    public \u0013(double width, double height)
    {
      this = new \u0013(0.0, 0.0, width, height);
    }

    public \u0013(double x, double y, double width, double height)
    {
      this.\u0001 = x;
      this.\u0002 = y;
      this.\u0003 = width;
      this.\u0004 = height;
    }

    public Rectangle \u001D\u0005(Size max_size)
    {
      return this.\u001D\u0005(new Rectangle(Point.Empty, max_size));
    }

    public Rectangle \u001D\u0005(Rectangle max_bounds)
    {
      max_bounds = max_bounds.\u001D\u0005();
      int num1 = max_bounds.Right - max_bounds.Left;
      int num2 = max_bounds.Bottom - max_bounds.Top;
      return new Rectangle((int) (this.\u0001 * (double) num1 + (double) max_bounds.X), (int) (this.\u0002 * (double) num2 + (double) max_bounds.Y), (int) (this.\u0003 * (double) num1), (int) (this.\u0004 * (double) num2));
    }

    [SpecialName]
    public static bool \u001D\u0005(\u0013 left, \u0013 right)
    {
      if (left.\u0001 == right.\u0001 && left.\u0002 == right.\u0002 && left.\u0003 == right.\u0003)
        return left.\u0004 == right.\u0004;
      return false;
    }

    [SpecialName]
    public static bool \u001E\u0005(\u0013 left, \u0013 right)
    {
      return !\u0013.\u001D\u0005(left, right);
    }

    public override int GetHashCode()
    {
      return (int) (uint) this.\u0001 ^ ((int) (uint) this.\u0002 << 13 | (int) ((uint) this.\u0002 >> 19)) ^ ((int) (uint) this.\u0003 << 26 | (int) ((uint) this.\u0003 >> 6)) ^ ((int) (uint) this.\u0004 << 7 | (int) ((uint) this.\u0004 >> 25));
    }

    public override bool Equals(object obj)
    {
      if (!(obj is \u0013))
        return false;
      \u0013 obj1 = (\u0013) obj;
      if (obj1.\u0001 == this.\u0001 && (obj1.\u0002 == this.\u0002 && obj1.\u0003 == this.\u0003))
        return obj1.\u0004 == this.\u0004;
      return false;
    }

    public static \u0013 \u001D\u0005(Rectangle bounds, Size size)
    {
      return \u0013.\u001D\u0005(bounds, new Rectangle(Point.Empty, size));
    }

    public static \u0013 \u001D\u0005(Rectangle bounds, Rectangle max_bounds)
    {
      bounds = bounds.\u001D\u0005(max_bounds);
      double width;
      double x;
      if ((double) max_bounds.Width > 0.0)
      {
        x = (double) bounds.X / (double) max_bounds.Width;
        width = (double) bounds.Width / (double) max_bounds.Width;
      }
      else
        width = x = 0.0;
      double y;
      double height;
      if ((double) max_bounds.Height > 0.0)
      {
        y = (double) bounds.Y / (double) max_bounds.Height;
        height = (double) bounds.Height / (double) max_bounds.Height;
      }
      else
        height = y = 0.0;
      return new \u0013(x, y, width, height);
    }
  }
}
