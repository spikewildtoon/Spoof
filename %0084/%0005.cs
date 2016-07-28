// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0084;
using System;
using System.Runtime.CompilerServices;

namespace \u0084
{
  internal struct \u0005 : IComparable<\u0005>, IEquatable<\u0005>, IComparable, IFormattable
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    public static readonly \u0005 \u0001;
    private readonly ulong \u0001;

    static \u0005()
    {
      \u0004.\u001D\u0005(typeof (\u0005));
      \u0005.\u0001 = \u0005.\u0001(105897);
      \u0005.\u0002 = \u0005.\u0001(7802);
      \u0005.\u0003 = \u0005.\u0001(105902);
      \u0005.\u0004 = \u0005.\u0001(105959);
      \u0005.\u0005 = \u0005.\u0001(106036);
      \u0005.\u0001 = new \u0005();
    }

    public \u0005(ulong code)
    {
      this.\u0001 = code;
    }

    public \u0005(string code)
    {
      this.\u0001 = \u0005.\u001D\u0005(code);
    }

    public override string ToString()
    {
      return this.ToString(\u0005.\u0001(106065), (IFormatProvider) null);
    }

    public string \u001D\u0005(string format)
    {
      return this.ToString(format, (IFormatProvider) null);
    }

    public string ToString(string format, IFormatProvider formatProvider)
    {
      return \u0005.\u001D\u0005(this.\u0001, format);
    }

    public int CompareTo(object value)
    {
      if (value == null)
        return 1;
      if (!(value is \u0005))
        throw new ArgumentException(\u0005.\u0005);
      return this.CompareTo((\u0005) value);
    }

    public int CompareTo(\u0005 value)
    {
      if ((long) value.\u0001 == (long) this.\u0001)
        return 0;
      return this.\u0001 < value.\u0001 ? -1 : 1;
    }

    public bool Equals(\u0005 code)
    {
      return (long) code.\u0001 == (long) this.\u0001;
    }

    public override bool Equals(object obj)
    {
      return obj != null && obj is \u0005 && (long) ((\u0005) obj).\u0001 == (long) this.\u0001;
    }

    public override int GetHashCode()
    {
      return 3723 + this.\u0001.GetHashCode();
    }

    [SpecialName]
    public static bool \u001D\u0005(\u0005 a, \u0005 b)
    {
      return (long) a.\u0001 == (long) b.\u0001;
    }

    [SpecialName]
    public static bool \u001E\u0005(\u0005 a, \u0005 b)
    {
      return !\u0005.\u001D\u0005(a, b);
    }

    [SpecialName]
    public static \u0005 \u001D\u0005(ulong l)
    {
      return new \u0005(l);
    }

    [SpecialName]
    public static \u0005 \u001D\u0005(string s)
    {
      return new \u0005(s);
    }

    [SpecialName]
    public static string \u001D\u0005(\u0005 c)
    {
      return c.ToString();
    }

    [SpecialName]
    public static ulong \u001D\u0005(\u0005 c)
    {
      return c.\u0001;
    }

    public static \u0005 \u001E\u0005(string input)
    {
      return new \u0005(\u0005.\u001D\u0005(input));
    }

    public static bool \u001D\u0005(string input, out \u0005 result)
    {
      switch (input)
      {
        case null:
          result = new \u0005();
          return false;
        default:
          if (\u0005\u0081.\u007E\u0001\u0093((object) input) == 16 && input.\u001E\u0005() || \u0005\u0081.\u007E\u0001\u0093((object) input) == 19 && input.\u001D\u0005())
          {
            result = \u0005.\u001D\u0005(input);
            return true;
          }
          result = new \u0005();
          return false;
      }
    }

    private static ulong \u001D\u0005(string input)
    {
      switch (input)
      {
        case null:
          return 0;
        default:
          if (\u0005\u0081.\u007E\u0001\u0093((object) input) == 16 && input.\u001E\u0005())
            return \u0080\u007F.\u0001\u0098(input);
          if (\u0005\u0081.\u007E\u0001\u0093((object) input) == 19 && input.\u001D\u0005())
            return \u0080\u007F.\u0001\u0098(\u008B\u001E.\u0088\u0093(\u0084\u0080.\u007E\u0006\u0093((object) input, 0, 4), \u0084\u0080.\u007E\u0006\u0093((object) input, 5, 4), \u0084\u0080.\u007E\u0006\u0093((object) input, 10, 4), \u0084\u0080.\u007E\u0006\u0093((object) input, 15, 4)));
          throw new FormatException(\u0005.\u0004);
      }
    }

    private static string \u001D\u0005(ulong input, string format)
    {
      switch (format)
      {
        case null:
          format = \u0005.\u0001(106065);
          break;
        default:
          if (\u0005\u0081.\u007E\u0001\u0093((object) format) != 0)
            break;
          goto case null;
      }
      if (\u0005\u0081.\u007E\u0001\u0093((object) format) != 1)
        throw new FormatException(\u009E\u0081.\u001F\u0093(\u0005.\u0003, (object) format));
      switch (\u008C\u0086.\u007E\u009C\u0092((object) format, 0))
      {
        case 'D':
          return \u0004\u001E.\u007E\u001C\u0093((object) \u0004\u001E.\u007E\u001C\u0093((object) \u0004\u001E.\u007E\u001C\u0093((object) input.ToString(\u0005.\u0001), 4, \u0005.\u0002), 9, \u0005.\u0002), 14, \u0005.\u0002);
        case 'N':
          return input.ToString(\u0005.\u0001);
        default:
          throw new FormatException(\u009E\u0081.\u001F\u0093(\u0005.\u0003, (object) format));
      }
    }
  }
}
