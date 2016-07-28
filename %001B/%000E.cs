// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001B;
using System;

namespace \u001B
{
  internal sealed class \u000E
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private int[] \u0001;
    private int \u0001;
    private int \u0002;

    public bool this[int x, int y]
    {
      get
      {
        return this.\u001E\u0005(x, y);
      }
      set
      {
        this.\u001E\u0005(x, y, value);
      }
    }

    static \u000E()
    {
      \u0004.\u001D\u0005(typeof (\u000E));
    }

    public \u000E(int x, int y, bool defaultValue)
    {
      if (x < 0)
        throw new ArgumentOutOfRangeException(\u000E.\u0001(54531), \u000E.\u0001(54536));
      if (y < 0)
        throw new ArgumentOutOfRangeException(\u000E.\u0001(54577), \u000E.\u0001(54536));
      this.\u0001 = new int[\u000E.\u001D\u0005(x * y, 32)];
      this.\u0001 = x;
      this.\u0002 = y;
      int num = defaultValue ? -1 : 0;
      for (int index = 0; index < this.\u0001.Length; ++index)
        this.\u0001[index] = num;
    }

    public bool \u001E\u0005(int x, int y)
    {
      if (x < 0 || x >= this.\u0001)
        throw new ArgumentOutOfRangeException(\u000E.\u0001(54531), \u009E\u0081.\u001F\u0093(\u000E.\u0001(54582), (object) this.\u0001));
      if (y < 0 || y >= this.\u0002)
        throw new ArgumentOutOfRangeException(\u000E.\u0001(54577), \u009E\u0081.\u001F\u0093(\u000E.\u0001(54582), (object) this.\u0001));
      return this.\u001D\u0005(x * this.\u0001 + y);
    }

    private bool \u001D\u0005(int index)
    {
      return (this.\u0001[index / 32] & 1 << index % 32) != 0;
    }

    public void \u001E\u0005(int x, int y, bool value)
    {
      if (x < 0 || x >= this.\u0001)
        throw new ArgumentOutOfRangeException(\u000E.\u0001(54531), \u009E\u0081.\u001F\u0093(\u000E.\u0001(54582), (object) this.\u0001));
      if (y < 0 || y >= this.\u0002)
        throw new ArgumentOutOfRangeException(\u000E.\u0001(54577), \u009E\u0081.\u001F\u0093(\u000E.\u0001(54582), (object) this.\u0001));
      this.\u001D\u0005(x * this.\u0001 + y, value);
    }

    private void \u001D\u0005(int index, bool value)
    {
      if (!value)
        this.\u0001[index / 32] &= ~(1 << index % 32);
      else
        this.\u0001[index / 32] |= 1 << index % 32;
    }

    private static int \u001D\u0005(int n, int div)
    {
      if (n <= 0)
        return 0;
      return (n - 1) / div + 1;
    }
  }
}
