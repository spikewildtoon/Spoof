// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace \u0015
{
  internal sealed class \u0017 : \u0016
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly Lazy<\u0017> \u0001;
    private RNGCryptoServiceProvider \u0001;

    public static \u0017 Instance
    {
      get
      {
        return \u0017.\u0001.Value;
      }
    }

    static \u0017()
    {
      \u0004.\u001D\u0005(typeof (\u0017));
      \u0017.\u0001 = new Lazy<\u0017>((Func<\u0017>) (() => new \u0017()));
    }

    public \u0017()
    {
      this.\u0001 = new RNGCryptoServiceProvider();
    }

    public int \u001D\u0005()
    {
      byte[] numArray = new byte[4];
      \u0015\u001C.\u007E\u008E\u009F((object) this.\u0001, numArray);
      return \u0014\u001E.\u0001\u0095(numArray, 0) & int.MaxValue;
    }

    [DebuggerStepThrough]
    public int \u001D\u0005(int maxValue)
    {
      return this.\u001D\u0005(0, maxValue);
    }

    [DebuggerStepThrough]
    public int \u001D\u0005(int minValue, int maxValue)
    {
      if (maxValue < minValue)
        throw new ArgumentException(\u0017.\u0001(14898));
      if (minValue < 0)
        throw new ArgumentOutOfRangeException(\u0017.\u0001(14959), (object) minValue, \u0017.\u0001(14972));
      if (maxValue < 0)
        throw new ArgumentOutOfRangeException(\u0017.\u0001(15005), (object) maxValue, \u0017.\u0001(14972));
      if (maxValue == minValue)
        return minValue;
      long num1 = (long) (maxValue - minValue);
      uint num2;
      long num3;
      long num4;
      do
      {
        byte[] numArray = new byte[4];
        \u0015\u001C.\u007E\u008E\u009F((object) this.\u0001, numArray);
        num2 = \u009E\u007F.\u0003\u0095(numArray, 0);
        num3 = 4294967296L;
        num4 = num3 % num1;
      }
      while ((long) num2 >= num3 - num4);
      return (int) ((long) minValue + (long) num2 % num1);
    }

    [DebuggerStepThrough]
    public void \u001D\u0005(byte[] buffer)
    {
      if (buffer == null)
        throw new ArgumentNullException(\u0017.\u0001(15018));
      \u0015\u001C.\u007E\u008E\u009F((object) this.\u0001, buffer);
    }

    [DebuggerStepThrough]
    public double \u001D\u0005()
    {
      byte[] numArray = new byte[4];
      \u0015\u001C.\u007E\u008E\u009F((object) this.\u0001, numArray);
      return (double) \u009E\u007F.\u0003\u0095(numArray, 0) / 4294967296.0;
    }

    protected override void \u001D\u0005()
    {
      \u001A\u001E.\u007E\u008D\u009F((object) this.\u0001);
      base.\u001D\u0005();
    }
  }
}
