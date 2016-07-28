// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using System;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace \u0018
{
  internal static class \u001F
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public static readonly int[] \u0001;

    static \u001F()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u001F)));
      \u001F.\u0001 = new int[72]
      {
        3,
        7,
        11,
        17,
        23,
        29,
        37,
        47,
        59,
        71,
        89,
        107,
        131,
        163,
        197,
        239,
        293,
        353,
        431,
        521,
        631,
        761,
        919,
        1103,
        1327,
        1597,
        1931,
        2333,
        2801,
        3371,
        4049,
        4861,
        5839,
        7013,
        8419,
        10103,
        12143,
        14591,
        17519,
        21023,
        25229,
        30293,
        36353,
        43627,
        52361,
        62851,
        75431,
        90523,
        108631,
        130363,
        156437,
        187751,
        225307,
        270371,
        324449,
        389357,
        467237,
        560689,
        672827,
        807403,
        968897,
        1162687,
        1395263,
        1674319,
        2009191,
        2411033,
        2893249,
        3471899,
        4166287,
        4999559,
        5999471,
        7199369
      };
    }

    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    public static int \u001D\u0005(int min)
    {
      if (min < 0)
        throw new ArgumentException(\u001F.\u0001(38813));
      for (int index = 0; index < \u001F.\u0001.Length; ++index)
      {
        int num = \u001F.\u0001[index];
        if (num >= min)
          return num;
      }
      int candidate = min | 1;
      while (candidate < int.MaxValue)
      {
        if (\u001F.\u001D\u0005(candidate))
          return candidate;
        candidate += 2;
      }
      return min;
    }

    [SecuritySafeCritical]
    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    public static bool \u001D\u0005(int candidate)
    {
      if ((candidate & 1) == 0)
        return candidate == 2;
      int num1 = (int) \u0007\u0081.\u0099\u0096((double) candidate);
      int num2 = 3;
      while (num2 <= num1)
      {
        if (candidate % num2 == 0)
          return false;
        num2 += 2;
      }
      return true;
    }

    public static int \u001D\u0005(int coprime_a, int coprime_b, params object[] objects)
    {
      // ISSUE: unable to decompile the method.
    }
  }
}
