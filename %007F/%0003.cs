// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u007F;
using System;
using System.Collections;
using System.Collections.Generic;

namespace \u007F
{
  internal sealed class \u0003 : IComparer<string>, IComparer
  {
    private static readonly Lazy<\u0003> \u0001 = new Lazy<\u0003>((Func<\u0003>) (() => new \u0003()));
    private static readonly Lazy<\u0003> \u0002 = new Lazy<\u0003>((Func<\u0003>) (() => new \u0003(true)));
    private bool \u0001;

    public static \u0003 Default
    {
      get
      {
        return \u0003.\u0001.Value;
      }
    }

    public static \u0003 DefaultZeroesFirst
    {
      get
      {
        return \u0003.\u0002.Value;
      }
    }

    private \u0003()
    {
    }

    private \u0003(bool zeroesFirst)
    {
      this.\u0001 = zeroesFirst;
    }

    int IComparer.\u001D\u0005(object x, object y)
    {
      if (x == null && y == null)
        return 0;
      if (x == null)
        return -1;
      if (y == null)
        return 1;
      string s1 = x as string;
      string s2 = y as string;
      switch (s1)
      {
        case null:
          return \u0086\u0086.\u007E\u0091\u0099((object) Comparer.Default, x, y);
        default:
          if (s2 != null)
            return \u0003.\u001D\u0005(s1, s2, this.\u0001);
          goto case null;
      }
    }

    public int Compare(string x, string y)
    {
      switch (x)
      {
        case null:
          switch (y)
          {
            case null:
              return 0;
          }
      }
      switch (x)
      {
        case null:
          return -1;
        default:
          switch (y)
          {
            case null:
              return 1;
            default:
              return \u0003.\u001D\u0005(x, y, this.\u0001);
          }
      }
    }

    private static int \u001D\u0005(string s1, string s2, bool zeroesFirst)
    {
      switch (s1)
      {
        case null:
          switch (s2)
          {
            case null:
              return 0;
            default:
              if (\u0005\u0081.\u007E\u0001\u0093((object) s2) != 0)
                return -1;
              goto case null;
          }
        default:
          if (\u0005\u0081.\u007E\u0001\u0093((object) s1) != 0)
          {
            switch (s2)
            {
              case null:
                return 1;
              default:
                if (\u0005\u0081.\u007E\u0001\u0093((object) s2) != 0)
                {
                  int s1Length = \u0005\u0081.\u007E\u0001\u0093((object) s1);
                  int s2Length = \u0005\u0081.\u007E\u0001\u0093((object) s2);
                  bool flag1 = \u0095\u0080.\u0011\u0095(\u008C\u0086.\u007E\u009C\u0092((object) s1, 0));
                  bool flag2 = \u0095\u0080.\u0011\u0095(\u008C\u0086.\u007E\u009C\u0092((object) s2, 0));
                  if (flag1 && !flag2)
                    return 1;
                  if (!flag1 && flag2)
                    return -1;
                  int i1 = 0;
                  int i2 = 0;
                  do
                  {
                    char ch1 = \u008C\u0086.\u007E\u009C\u0092((object) s1, i1);
                    char ch2 = \u008C\u0086.\u007E\u009C\u0092((object) s2, i2);
                    bool flag3 = \u0095\u0080.\u0008\u0095(ch1);
                    bool flag4 = \u0095\u0080.\u0008\u0095(ch2);
                    if (!flag3 && !flag4)
                    {
                      if ((int) ch1 != (int) ch2)
                      {
                        bool flag5 = \u0095\u0080.\u000E\u0095(ch1);
                        bool flag6 = \u0095\u0080.\u000E\u0095(ch2);
                        if (flag5 && flag6)
                        {
                          int num = (int) \u0005\u0084.\u0012\u0095(ch1) - (int) \u0005\u0084.\u0012\u0095(ch2);
                          if (num != 0)
                            return num;
                        }
                        else if (!flag5 && !flag6)
                        {
                          int num = (int) ch1 - (int) ch2;
                          if (num != 0)
                            return num;
                        }
                        else
                        {
                          if (flag5)
                            return 1;
                          if (flag6)
                            return -1;
                        }
                      }
                    }
                    else if (flag3 && flag4)
                    {
                      int num = \u0003.\u001D\u0005(ref s1, ref s1Length, ref i1, ref s2, ref s2Length, ref i2, zeroesFirst);
                      if (num != 0)
                        return num;
                    }
                    else
                    {
                      if (flag3)
                        return -1;
                      if (flag4)
                        return 1;
                    }
                    ++i1;
                    ++i2;
                    if (i1 >= s1Length)
                      return i2 >= s2Length ? 0 : -1;
                  }
                  while (i2 < s2Length);
                  return 1;
                }
                goto case null;
            }
          }
          else
            goto case null;
      }
    }

    private static int \u001D\u0005(ref string s1, ref int s1Length, ref int i1, ref string s2, ref int s2Length, ref int i2, bool zeroesFirst)
    {
      int nzStart1 = i1;
      int nzStart2 = i2;
      int end1 = i1;
      int end2 = i2;
      \u0003.\u001D\u0005(ref s1, ref s1Length, i1, ref nzStart1, ref end1);
      \u0003.\u001D\u0005(ref s2, ref s2Length, i2, ref nzStart2, ref end2);
      int num1 = i1;
      i1 = end1 - 1;
      int num2 = i2;
      i2 = end2 - 1;
      if (zeroesFirst)
      {
        int num3 = nzStart1 - num1;
        int num4 = nzStart2 - num2;
        if (num3 > num4)
          return -1;
        if (num3 < num4)
          return 1;
      }
      int num5 = end2 - nzStart2;
      int num6 = end1 - nzStart1;
      if (num5 == num6)
      {
        int num3 = nzStart1;
        int num4 = nzStart2;
        while (num3 <= i1)
        {
          int num7 = (int) \u008C\u0086.\u007E\u009C\u0092((object) s1, num3) - (int) \u008C\u0086.\u007E\u009C\u0092((object) s2, num4);
          if (num7 != 0)
            return num7;
          ++num3;
          ++num4;
        }
        num5 = end1 - num1;
        num6 = end2 - num2;
        if (num5 == num6)
          return 0;
      }
      return num5 > num6 ? -1 : 1;
    }

    private static void \u001D\u0005(ref string s, ref int length, int start, ref int nzStart, ref int end)
    {
      nzStart = start;
      end = start;
      bool flag = true;
      char ch = \u008C\u0086.\u007E\u009C\u0092((object) s, end);
      do
      {
        if (flag)
        {
          if (48 == (int) ch)
            ++nzStart;
          else
            flag = false;
        }
        ++end;
        if (end >= length)
          break;
        ch = \u008C\u0086.\u007E\u009C\u0092((object) s, end);
      }
      while (\u0095\u0080.\u0008\u0095(ch));
    }
  }
}
