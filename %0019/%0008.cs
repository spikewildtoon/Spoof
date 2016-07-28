// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0019;
using System;
using System.Diagnostics;
using System.Drawing;

namespace \u0019
{
  internal struct \u0008
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public int \u0001;
    public int \u0002;
    public int \u0003;
    public int \u0004;

    public int X
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
      }
    }

    public int Y
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        this.\u0002 = value;
      }
    }

    public int Width
    {
      get
      {
        return this.\u0003 - this.\u0001;
      }
      set
      {
        this.\u0003 = this.\u0001 + value;
      }
    }

    public int Height
    {
      get
      {
        return this.\u0004 - this.\u0002;
      }
      set
      {
        this.\u0004 = this.\u0002 + value;
      }
    }

    static \u0008()
    {
      \u0004.\u001D\u0005(typeof (\u0008));
    }

    public \u0008(Rectangle rec)
    {
      this.\u0001 = rec.Left;
      this.\u0002 = rec.Top;
      this.\u0003 = rec.Right;
      this.\u0004 = rec.Bottom;
    }

    [DebuggerStepThrough]
    public \u0008(int left, int top, int right, int bottom)
    {
      this.\u0001 = left;
      this.\u0002 = top;
      this.\u0003 = right;
      this.\u0004 = bottom;
    }

    public Rectangle \u001D\u0005()
    {
      return new Rectangle(this.\u0001, this.\u0002, this.\u0003 - this.\u0001, this.\u0004 - this.\u0002);
    }

    public override string ToString()
    {
      return \u0007\u001E.\u0081\u0093(\u0008.\u0001(44567), new object[4]{ (object) this.X, (object) this.Y, (object) this.Width, (object) this.Height });
    }
  }
}
