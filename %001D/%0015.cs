// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0019;
using \u001D;
using \u0084;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u001D
{
  [StructLayout(LayoutKind.Explicit)]
  internal struct \u0015 : \u0013
  {
    public static readonly \u0015 \u0001 = new \u0015((byte) 0, (byte) 0, (byte) 0, (byte) 0);
    [FieldOffset(0)]
    private byte \u0001;
    [FieldOffset(1)]
    private byte \u0002;
    [FieldOffset(2)]
    private byte \u0003;
    [FieldOffset(3)]
    private byte \u0004;
    [FieldOffset(0)]
    private int \u0001;

    public byte B
    {
      [DebuggerStepThrough] get
      {
        return this.\u0001;
      }
      [DebuggerStepThrough] set
      {
        this.\u0001 = value;
      }
    }

    public byte G
    {
      [DebuggerStepThrough] get
      {
        return this.\u0002;
      }
      [DebuggerStepThrough] set
      {
        this.\u0002 = value;
      }
    }

    public byte R
    {
      [DebuggerStepThrough] get
      {
        return this.\u0003;
      }
      [DebuggerStepThrough] set
      {
        this.\u0003 = value;
      }
    }

    public byte A
    {
      [DebuggerStepThrough] get
      {
        return this.\u0004;
      }
      [DebuggerStepThrough] set
      {
        this.\u0004 = value;
      }
    }

    public \u0015(byte r, byte g, byte b)
    {
      this = new \u0015();
      this.R = r;
      this.G = g;
      this.B = b;
      this.A = byte.MaxValue;
    }

    public \u0015(byte r, byte g, byte b, byte a)
    {
      this = new \u0015();
      this.R = r;
      this.G = g;
      this.B = b;
      this.A = a;
    }

    [SpecialName]
    public static Color \u001D\u0005(\u0015 c)
    {
      return \u001B\u001C.\u0015\u007F((int) c.A, (int) c.R, (int) c.G, (int) c.B);
    }

    [SpecialName]
    public static \u0015 \u001D\u0005(Color c)
    {
      return new \u0015(c.R, c.G, c.B, c.A);
    }

    [SpecialName]
    public static \u0015 \u001D\u0005(\u0002 c)
    {
      return new \u0015(c.R, c.G, c.B, byte.MaxValue);
    }

    public override int GetHashCode()
    {
      return this.\u0001;
    }

    public override bool Equals(object obj)
    {
      if (!(obj is \u0015))
        return \u0013\u0080.\u0094\u0091((object) this, obj);
      return this.\u0001 == ((\u0015) obj).\u0001;
    }

    [SpecialName]
    public static bool \u001D\u0005(\u0015 left, \u0015 right)
    {
      return left.\u0001 == right.\u0001;
    }

    [SpecialName]
    public static bool \u001E\u0005(\u0015 left, \u0015 right)
    {
      return !\u0015.\u001D\u0005(left, right);
    }
  }
}
