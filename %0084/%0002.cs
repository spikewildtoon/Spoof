// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0019;
using \u001D;
using \u0084;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace \u0084
{
  internal struct \u0002 : \u0013
  {
    public byte B { get; set; }

    public byte G { get; set; }

    public byte R { get; set; }

    public \u0002(byte r, byte g, byte b)
    {
      this = new \u0002();
      this.R = r;
      this.G = g;
      this.B = b;
    }

    [SpecialName]
    public static Color \u001D\u0005(\u0002 c)
    {
      return \u001B\u001C.\u0015\u007F((int) byte.MaxValue, (int) c.R, (int) c.G, (int) c.B);
    }

    [SpecialName]
    public static \u0002 \u001D\u0005(Color c)
    {
      return new \u0002(c.R, c.G, c.B);
    }

    [SpecialName]
    public static \u0002 \u001D\u0005(\u0015 c)
    {
      return new \u0002(c.R, c.G, c.B);
    }
  }
}
