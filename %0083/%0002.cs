// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0083;
using System.Runtime.CompilerServices;

namespace \u0083
{
  internal struct \u0002
  {
    public static readonly \u0002 \u0001 = new \u0002(0.0);
    public readonly double \u0001;

    public bool IsEmpty
    {
      get
      {
        return this.\u0001 == 0.0;
      }
    }

    public \u0002(double value)
    {
      this.\u0001 = value;
    }

    public int \u001D\u0005(int max_value)
    {
      return (int) (this.\u0001 * (double) max_value);
    }

    [SpecialName]
    public static bool \u001D\u0005(\u0002 left, \u0002 right)
    {
      return left.\u0001 == right.\u0001;
    }

    [SpecialName]
    public static bool \u001E\u0005(\u0002 left, \u0002 right)
    {
      return !\u0002.\u001D\u0005(left, right);
    }

    public override int GetHashCode()
    {
      return \u0005\u0081.\u0095\u0091((object) this);
    }

    public override bool Equals(object obj)
    {
      if (!(obj is \u0002))
        return false;
      return ((\u0002) obj).\u0001 == this.\u0001;
    }

    public static \u0002 \u001D\u0005(int value, int max_value)
    {
      if (value > max_value)
        value = max_value;
      return new \u0002((double) max_value <= 0.0 ? 0.0 : (double) value / (double) max_value);
    }
  }
}
