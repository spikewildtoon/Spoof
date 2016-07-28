// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0018;
using \u0084;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace \u0084
{
  internal struct \u0006
  {
    public static readonly \u0006 \u0001 = new \u0006(0.0f, 0.0f, 0.0f, 0.0f);
    public readonly float \u0001;
    public readonly float \u0002;
    public readonly float \u0003;
    public readonly float \u0004;

    public PointF Location
    {
      get
      {
        return new PointF(this.\u0001, this.\u0002);
      }
    }

    public bool IsDock
    {
      get
      {
        if ((double) this.\u0001 != 0.0)
          return false;
        return (double) this.\u0002 == 0.0;
      }
    }

    public \u0006(float x, float y, float z, float h)
    {
      this.\u0001 = x;
      this.\u0002 = y;
      this.\u0003 = z;
      this.\u0004 = h;
    }

    [SpecialName]
    public static bool \u001D\u0005(\u0006 a, \u0006 b)
    {
      if ((double) a.\u0004 == (double) b.\u0004 && (double) a.\u0001 == (double) b.\u0001 && (double) a.\u0002 == (double) b.\u0002)
        return (double) a.\u0003 == (double) b.\u0003;
      return false;
    }

    [SpecialName]
    public static bool \u001E\u0005(\u0006 a, \u0006 b)
    {
      return !\u0006.\u001D\u0005(a, b);
    }

    public override bool Equals(object obj)
    {
      if (!(obj is \u0006))
        return false;
      return \u0006.\u001D\u0005(this, (\u0006) obj);
    }

    public override int GetHashCode()
    {
      return \u001F.\u001D\u0005(14, 15, (object) this.\u0004, (object) this.\u0001, (object) this.\u0002, (object) this.\u0003);
    }

    public float \u001D\u0005(PointF targetPosition)
    {
      double num1 = \u0090\u007F.\u008F\u0096((double) targetPosition.Y - (double) this.\u0002, (double) targetPosition.X - (double) this.\u0001);
      double num2 = (num1 <= 0.0 ? num1 * 180.0 / Math.PI + 270.0 : num1 * 180.0 / Math.PI - 90.0) % 360.0;
      if (num2 < 0.0)
        num2 += 360.0;
      return (float) num2;
    }
  }
}
