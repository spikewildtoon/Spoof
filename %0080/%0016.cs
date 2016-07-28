// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0080;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace \u0080
{
  internal struct \u0016 : IComparable<\u0016>, IComparable, IEquatable<\u0016>
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public static readonly \u0016 \u0001;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint \u0001;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint \u0002;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint \u0003;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint \u0004;

    static \u0016()
    {
      \u0004.\u001D\u0005(typeof (\u0016));
      \u0016.\u0001 = new \u0016(\u0016.\u0001(88942));
    }

    [DebuggerStepThrough]
    public \u0016(string hash)
    {
      if (\u008F\u0084.\u009E\u0092(hash))
        throw new NullReferenceException(\u0016.\u0001(75566));
      hash = \u0002\u007F.\u007E\u0019\u0093((object) \u008B\u0080.\u007E\u001D\u0093((object) hash, \u0016.\u0001(6962), \u0016.\u0001(6652)));
      if (!hash.\u001F\u0005())
        throw new ArgumentException(\u009E\u0081.\u001F\u0093(\u0016.\u0001(88806), (object) hash), \u0016.\u0001(75566));
      \u0016.\u001D\u0005(hash, out this.\u0001, out this.\u0002, out this.\u0003, out this.\u0004);
    }

    [DebuggerStepThrough]
    public \u0016(uint val0, uint val1, uint val2, uint val3)
    {
      this.\u0001 = val0;
      this.\u0002 = val1;
      this.\u0003 = val2;
      this.\u0004 = val3;
    }

    [DebuggerStepThrough]
    public \u0016(byte[] bytes)
    {
      if (bytes == null)
        throw new ArgumentNullException(\u0016.\u0001(88867));
      if (bytes.Length != 16)
        throw new ArgumentException(\u009E\u0081.\u001F\u0093(\u0016.\u0001(88876), (object) bytes.Length), \u0016.\u0001(88867));
      this.\u0001 = \u009E\u007F.\u0003\u0095(bytes, 0);
      this.\u0002 = \u009E\u007F.\u0003\u0095(bytes, 4);
      this.\u0003 = \u009E\u007F.\u0003\u0095(bytes, 8);
      this.\u0004 = \u009E\u007F.\u0003\u0095(bytes, 12);
    }

    [DebuggerStepThrough]
    public byte[] \u001D\u0005()
    {
      byte[] numArray = new byte[16];
      \u0083\u0081.\u007E\u008C\u0092((object) \u009A\u0086.\u009E\u0094(this.\u0001), (Array) numArray, 0);
      \u0083\u0081.\u007E\u008C\u0092((object) \u009A\u0086.\u009E\u0094(this.\u0002), (Array) numArray, 4);
      \u0083\u0081.\u007E\u008C\u0092((object) \u009A\u0086.\u009E\u0094(this.\u0003), (Array) numArray, 8);
      \u0083\u0081.\u007E\u008C\u0092((object) \u009A\u0086.\u009E\u0094(this.\u0004), (Array) numArray, 12);
      return numArray;
    }

    [DebuggerStepThrough]
    public override string ToString()
    {
      char[] Result = new char[32];
      \u0016.\u001D\u0005(this.\u0001, ref Result, 0);
      \u0016.\u001D\u0005(this.\u0002, ref Result, 8);
      \u0016.\u001D\u0005(this.\u0003, ref Result, 16);
      \u0016.\u001D\u0005(this.\u0004, ref Result, 24);
      return new string(Result);
    }

    [DebuggerStepThrough]
    public static void \u001D\u0005(string hash, out uint val0, out uint val1, out uint val2, out uint val3)
    {
      char[] hash1 = \u0084\u001E.\u007E\u009D\u0092((object) hash);
      \u0016.\u001D\u0005(ref hash1, 0, out val0);
      \u0016.\u001D\u0005(ref hash1, 8, out val1);
      \u0016.\u001D\u0005(ref hash1, 16, out val2);
      \u0016.\u001D\u0005(ref hash1, 24, out val3);
    }

    [DebuggerStepThrough]
    private static void \u001D\u0005(ref char[] hash, int hashIndex, out uint val)
    {
      val = (uint) ((int) \u0016.\u001D\u0005(hash[hashIndex]) << 28 | (int) \u0016.\u001D\u0005(hash[1 + hashIndex]) << 24 | (int) \u0016.\u001D\u0005(hash[2 + hashIndex]) << 20 | (int) \u0016.\u001D\u0005(hash[3 + hashIndex]) << 16 | (int) \u0016.\u001D\u0005(hash[4 + hashIndex]) << 12 | (int) \u0016.\u001D\u0005(hash[5 + hashIndex]) << 8 | (int) \u0016.\u001D\u0005(hash[6 + hashIndex]) << 4) | \u0016.\u001D\u0005(hash[7 + hashIndex]);
    }

    [DebuggerStepThrough]
    private static void \u001D\u0005(uint number, ref char[] Result, int ResultIndex)
    {
      Result[ResultIndex] = \u0016.\u001D\u0005(number >> 28);
      Result[1 + ResultIndex] = \u0016.\u001D\u0005(number >> 24);
      Result[2 + ResultIndex] = \u0016.\u001D\u0005(number >> 20);
      Result[3 + ResultIndex] = \u0016.\u001D\u0005(number >> 16);
      Result[4 + ResultIndex] = \u0016.\u001D\u0005(number >> 12);
      Result[5 + ResultIndex] = \u0016.\u001D\u0005(number >> 8);
      Result[6 + ResultIndex] = \u0016.\u001D\u0005(number >> 4);
      Result[7 + ResultIndex] = \u0016.\u001D\u0005(number);
    }

    [DebuggerStepThrough]
    private static char \u001D\u0005(uint value)
    {
      value &= 15U;
      if (value < 10U)
        return (char) ((int) value + 48);
      return (char) ((int) value - 10 + 97);
    }

    [DebuggerStepThrough]
    private static uint \u001D\u0005(char digit)
    {
      if (!\u0095\u0080.\u0008\u0095(digit))
        return (uint) ((int) \u0005\u0084.\u0013\u0095(digit) - 97 + 10);
      return (uint) digit - 48U;
    }

    [DebuggerStepThrough]
    public override int GetHashCode()
    {
      return (((25 * 37 + this.\u0001.GetHashCode()) * 37 + this.\u0002.GetHashCode()) * 37 + this.\u0003.GetHashCode()) * 37 + this.\u0004.GetHashCode();
    }

    [DebuggerStepThrough]
    [SpecialName]
    public static bool \u001D\u0005(\u0016 val1, \u0016 val2)
    {
      return val1.Equals(val2);
    }

    [DebuggerStepThrough]
    [SpecialName]
    public static bool \u001E\u0005(\u0016 val1, \u0016 val2)
    {
      return !\u0016.\u001D\u0005(val1, val2);
    }

    [DebuggerStepThrough]
    public int CompareTo(object obj)
    {
      if (!(obj is \u0016))
        throw new ArgumentException(\u0016.\u0001(88921));
      return this.CompareTo((\u0016) obj);
    }

    [DebuggerStepThrough]
    public int CompareTo(\u0016 other)
    {
      if ((int) other.\u0001 != (int) this.\u0001)
        return \u0016.\u001D\u0005(this.\u0001, other.\u0001);
      if ((int) other.\u0002 != (int) this.\u0002)
        return \u0016.\u001D\u0005(this.\u0002, other.\u0002);
      if ((int) other.\u0003 != (int) this.\u0003)
        return \u0016.\u001D\u0005(this.\u0003, other.\u0003);
      if ((int) other.\u0004 != (int) this.\u0004)
        return \u0016.\u001D\u0005(this.\u0004, other.\u0004);
      return 0;
    }

    [DebuggerStepThrough]
    private static int \u001D\u0005(uint me, uint them)
    {
      return me < them ? -1 : 1;
    }

    [DebuggerStepThrough]
    public override bool Equals(object obj)
    {
      return this.Equals((\u0016) obj);
    }

    [DebuggerStepThrough]
    public bool Equals(\u0016 other)
    {
      if ((int) this.\u0001 != (int) other.\u0001 || (int) this.\u0002 != (int) other.\u0002 || (int) this.\u0003 != (int) other.\u0003)
        return false;
      return (int) this.\u0004 == (int) other.\u0004;
    }
  }
}
