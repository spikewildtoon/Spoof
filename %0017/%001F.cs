// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using System;

namespace \u0017
{
  internal sealed class \u001F : ICustomFormatter, IFormatProvider
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly double \u0001;
    private static readonly double \u0002;
    private static readonly double \u0003;
    private static readonly double \u0004;

    static \u001F()
    {
      \u0004.\u001D\u0005(typeof (\u001F));
      \u001F.\u0001 = 1.0;
      \u001F.\u0002 = 1024.0 * \u001F.\u0001;
      \u001F.\u0003 = 1024.0 * \u001F.\u0002;
      \u001F.\u0004 = 1024.0 * \u001F.\u0003;
    }

    object IFormatProvider.\u001D\u0005(Type formatType)
    {
      // ISSUE: type reference
      if (!\u0091\u001F.\u001A\u0097(formatType, \u009C\u0082.\u0016\u0097(__typeref (ICustomFormatter))))
        return (object) null;
      return (object) this;
    }

    string ICustomFormatter.\u001D\u0005(string format, object arg, IFormatProvider formatProvider)
    {
      if (!(arg is long))
        goto label_10;
      else
        goto label_9;
label_2:
      long num1;
      if ((double) num1 > \u001F.\u0004)
      {
        double num2 = \u0010\u001C.\u0098\u0096((double) num1 / \u001F.\u0004, 2, MidpointRounding.AwayFromZero);
        return \u0081\u0086.\u0086\u0093(num2.ToString(), \u001F.\u0001(30857));
      }
      if ((double) num1 > \u001F.\u0003)
      {
        double num2 = \u0010\u001C.\u0098\u0096((double) num1 / \u001F.\u0003, 2, MidpointRounding.AwayFromZero);
        return \u0081\u0086.\u0086\u0093(num2.ToString(), \u001F.\u0001(30862));
      }
      if ((double) num1 > \u001F.\u0002)
      {
        double num2 = \u0010\u001C.\u0098\u0096((double) num1 / \u001F.\u0002, 2, MidpointRounding.AwayFromZero);
        return \u0081\u0086.\u0086\u0093(num2.ToString(), \u001F.\u0001(30867));
      }
      double num3 = \u0010\u001C.\u0098\u0096((double) num1 / \u001F.\u0001, 2, MidpointRounding.AwayFromZero);
      return \u0081\u0086.\u0086\u0093(num3.ToString(), \u001F.\u0001(30872));
label_9:
      num1 = (long) arg;
      goto label_2;
label_10:
      if (!(arg is int))
        throw new NotSupportedException(\u009E\u0081.\u001F\u0093(\u001F.\u0001(30808), (object) \u0002\u007F.\u007E\u0017\u0097((object) \u009C\u0083.\u007E\u008B\u0091(arg))));
      num1 = (long) (int) arg;
      goto label_2;
    }
  }
}
