// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001A;
using \u007F;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace \u007F
{
  internal struct \u0017
  {
    public static readonly \u0017 \u0001 = new \u0017(0.0, 0.0);
    public readonly double \u0001;
    public readonly double \u0002;

    public bool IsEmpty
    {
      get
      {
        if (this.\u0001 != 0.0)
          return false;
        return this.\u0002 == 0.0;
      }
    }

    public \u0017(double width, double height)
    {
      this.\u0001 = width;
      this.\u0002 = height;
    }

    public Size \u001D\u0005(Size max_size)
    {
      return new Size((int) (this.\u0001 * (double) max_size.Width), (int) (this.\u0002 * (double) max_size.Height));
    }

    [SpecialName]
    public static bool \u001D\u0005(\u0017 left, \u0017 right)
    {
      if (left.\u0001 == right.\u0001)
        return left.\u0002 == right.\u0002;
      return false;
    }

    [SpecialName]
    public static bool \u001E\u0005(\u0017 left, \u0017 right)
    {
      return !\u0017.\u001D\u0005(left, right);
    }

    public override int GetHashCode()
    {
      return \u0005\u0081.\u0095\u0091((object) this);
    }

    public override bool Equals(object obj)
    {
      if (!(obj is \u0017))
        return false;
      \u0017 obj1 = (\u0017) obj;
      if (obj1.\u0001 == this.\u0001)
        return obj1.\u0002 == this.\u0002;
      return false;
    }

    public static \u0017 \u001D\u0005(Size bounds, Size max_bounds)
    {
      bounds = bounds.\u001D\u0005(max_bounds);
      return new \u0017((double) max_bounds.Width <= 0.0 ? 0.0 : (double) bounds.Width / (double) max_bounds.Width, (double) max_bounds.Height <= 0.0 ? 0.0 : (double) bounds.Height / (double) max_bounds.Height);
    }
  }
}
