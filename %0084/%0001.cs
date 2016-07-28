// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.Collections;
using System.ComponentModel;

namespace \u0084
{
  internal static class \u0001
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0001()
    {
      \u0004.\u001D\u0005(typeof (\u0084.\u0001));
    }

    public static void \u001D\u0005(this Enum value)
    {
      if (!\u0084.\u0001.\u001D\u0005(value))
        throw \u0084.\u0001.\u001D\u0005(value);
    }

    public static InvalidEnumArgumentException \u001D\u0005(this Enum value)
    {
      return new InvalidEnumArgumentException(\u0084.\u0001.\u0001(102672), \u0005\u0081.\u0017\u0095((object) value), \u009C\u0083.\u007E\u008B\u0091((object) value));
    }

    public static bool \u001D\u0005(this Enum value)
    {
      if (value.\u001E\u0005())
        return value.\u007F\u0005();
      return value.\u001F\u0005();
    }

    public static bool \u001E\u0005(this Enum value)
    {
      // ISSUE: type reference
      return \u008D\u001D.\u007E\u0011\u0097((object) \u009C\u0083.\u007E\u008B\u0091((object) value), \u009C\u0082.\u0016\u0097(__typeref (FlagsAttribute)), false).Length > 0;
    }

    private static bool \u001F\u0005(this Enum value)
    {
      return \u009F\u0086.\u0098\u0091(\u009C\u0083.\u007E\u008B\u0091((object) value), (object) value);
    }

    private static bool \u007F\u0005(this Enum value)
    {
      Type type = \u009C\u0083.\u007E\u008B\u0091((object) value);
      TypeCode typeCode = \u008A\u001C.\u007E\u009A\u0091((object) value);
      switch (typeCode)
      {
        case TypeCode.SByte:
        case TypeCode.Int16:
        case TypeCode.Int32:
        case TypeCode.Int64:
          long num1 = \u001F\u001E.\u001C\u0095((object) value);
          IEnumerator enumerator1 = \u0015\u0082.\u007E\u008D\u0092((object) \u009D\u0081.\u0097\u0091(type));
          try
          {
            while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator1))
            {
              object obj = \u0005\u007F.\u007E\u0092\u0092((object) enumerator1);
              long num2 = \u001F\u001E.\u001C\u0095(obj);
              if (num2 == num1)
                return true;
              num1 &= ~num2;
            }
            break;
          }
          finally
          {
            IDisposable disposable = enumerator1 as IDisposable;
            if (disposable != null)
              \u001A\u001E.\u007E\u0094\u0092((object) disposable);
          }
        case TypeCode.Byte:
        case TypeCode.UInt16:
        case TypeCode.UInt32:
        case TypeCode.UInt64:
          ulong num3 = \u001B\u001E.\u001D\u0095((object) value);
          IEnumerator enumerator2 = \u0015\u0082.\u007E\u008D\u0092((object) \u009D\u0081.\u0097\u0091(type));
          try
          {
            while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator2))
            {
              object obj = \u0005\u007F.\u007E\u0092\u0092((object) enumerator2);
              ulong num2 = \u001B\u001E.\u001D\u0095(obj);
              if ((long) num2 == (long) num3)
                return true;
              num3 &= ~num2;
            }
            break;
          }
          finally
          {
            IDisposable disposable = enumerator2 as IDisposable;
            if (disposable != null)
              \u001A\u001E.\u007E\u0094\u0092((object) disposable);
          }
        default:
          throw new ArgumentException(\u0014\u0084.\u007F\u0093(\u0084.\u0001.\u0001(105448), (object) type, (object) typeCode));
      }
      return false;
    }
  }
}
