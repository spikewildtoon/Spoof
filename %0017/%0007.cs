// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001F;
using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace \u0017
{
  internal static class \u0007
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0007()
    {
      \u0004.\u001D\u0005(typeof (\u0007));
    }

    public static string \u001D\u0005(this string value)
    {
      switch (value)
      {
        case null:
          return (string) null;
        default:
          if (\u0008\u001F.\u009A\u0092(value, string.Empty))
            return string.Empty;
          while (\u0089\u0086.\u007E\u0014\u0093((object) value, \u0007.\u0001(27534)) > -1)
            value = \u008B\u0080.\u007E\u001D\u0093((object) value, \u0007.\u0001(27534), \u0007.\u0001(26268));
          return \u0002\u007F.\u007E\u001B\u0093((object) value);
      }
    }

    public static bool \u001D\u0005(this string data, char separator, out string key, out string value)
    {
      key = (string) null;
      value = (string) null;
      if (\u008F\u0084.\u009E\u0092(data))
        return false;
      int startIndex = 0;
      return data.\u001D\u0005(separator, ref startIndex, out key) && data.\u001D\u0005(ref startIndex, out value);
    }

    public static string \u001D\u0005(this string str, string value, out bool startsWith)
    {
      if (startsWith = \u0016\u001D.\u007E\u0017\u0093((object) str, value))
        return \u009C\u007F.\u007E\u0005\u0093((object) str, \u0005\u0081.\u007E\u0001\u0093((object) value));
      return str;
    }

    public static string[] \u001D\u0005(this string str, StringSplitOptions options, params char[] separator)
    {
      return \u0093\u0082.\u007E\u0003\u0093((object) str, separator, options);
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005(this string line, ref int startIndex, int length, out string value)
    {
      value = (string) null;
      if (\u0005\u0081.\u007E\u0001\u0093((object) line) < startIndex + length)
        return false;
      value = \u0084\u0080.\u007E\u0006\u0093((object) line, startIndex, length);
      startIndex += length;
      return true;
    }

    internal static bool \u001D\u0005(this string value)
    {
      switch (value)
      {
        case null:
          return false;
        default:
          if (\u0005\u0081.\u007E\u0001\u0093((object) value) != 19)
            return false;
          for (int index = 0; index < \u0005\u0081.\u007E\u0001\u0093((object) value); ++index)
          {
            char ch = \u008C\u0086.\u007E\u009C\u0092((object) value, index);
            switch (index)
            {
              case 4:
              case 9:
              case 14:
                if ((int) ch != 45)
                  return false;
                break;
              default:
                switch (ch)
                {
                  case '0':
                  case '1':
                  case '2':
                  case '3':
                  case '4':
                  case '5':
                  case '6':
                  case '7':
                  case '8':
                  case '9':
                    continue;
                  default:
                    return false;
                }
            }
          }
          return true;
      }
    }

    [DebuggerStepThrough]
    public static bool \u001E\u0005(this string value)
    {
      if (\u008F\u0084.\u009E\u0092(value))
        return false;
      string str = value;
      for (int index = 0; index < \u0005\u0081.\u007E\u0001\u0093((object) str); ++index)
      {
        switch (\u008C\u0086.\u007E\u009C\u0092((object) str, index))
        {
          case '0':
          case '1':
          case '2':
          case '3':
          case '4':
          case '5':
          case '6':
          case '7':
          case '8':
          case '9':
            goto case '0';
          default:
            return false;
        }
      }
      return true;
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005(this string line, ref int startIndex, out string value)
    {
      value = (string) null;
      if (\u0005\u0081.\u007E\u0001\u0093((object) line) <= startIndex)
        return false;
      value = \u009C\u007F.\u007E\u0005\u0093((object) line, startIndex);
      startIndex = \u0005\u0081.\u007E\u0001\u0093((object) line);
      return true;
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005(this string line, char c, ref int startIndex, out string value)
    {
      value = (string) null;
      if (\u0005\u0081.\u007E\u0001\u0093((object) line) <= startIndex)
        return false;
      int num = \u001C\u0081.\u007E\u0013\u0093((object) line, c, startIndex);
      if (num == -1)
        return false;
      value = \u0084\u0080.\u007E\u0006\u0093((object) line, startIndex, num - startIndex);
      startIndex = num + 1;
      return true;
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005(this string line, char c, ref int startIndex)
    {
      if (\u0005\u0081.\u007E\u0001\u0093((object) line) <= startIndex)
        return false;
      int num = \u001C\u0081.\u007E\u0013\u0093((object) line, c, startIndex);
      if (num == -1)
        return false;
      startIndex = num + 1;
      return true;
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005(this string line, string s, ref int startIndex)
    {
      if (\u0005\u0081.\u007E\u0001\u0093((object) line) < startIndex + \u0005\u0081.\u007E\u0001\u0093((object) s))
        return false;
      int num = \u001A\u0080.\u007E\u0015\u0093((object) line, s, startIndex);
      if (num == -1)
        return false;
      startIndex = num + \u0005\u0081.\u007E\u0001\u0093((object) s);
      return true;
    }

    public static bool \u001D\u0005(this string line, string s, ref int startIndex, out string value)
    {
      value = (string) null;
      if (\u0005\u0081.\u007E\u0001\u0093((object) line) < startIndex + \u0005\u0081.\u007E\u0001\u0093((object) s))
        return false;
      int num = \u001A\u0080.\u007E\u0015\u0093((object) line, s, startIndex);
      if (num == -1)
        return false;
      value = \u0084\u0080.\u007E\u0006\u0093((object) line, startIndex, num - startIndex);
      startIndex = num + \u0005\u0081.\u007E\u0001\u0093((object) s);
      return true;
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005(this string line, string s)
    {
      return \u0005\u0081.\u007E\u0001\u0093((object) line) >= \u0005\u0081.\u007E\u0001\u0093((object) s) && \u0089\u0086.\u007E\u0014\u0093((object) line, s) != -1;
    }

    [DebuggerStepThrough]
    public static bool \u001F\u0005(this string value)
    {
      switch (value)
      {
        case null:
          return false;
        default:
          int num = \u0005\u0081.\u007E\u0001\u0093((object) value);
          if (num != 32)
            return false;
          for (int index = 0; index < num; ++index)
          {
            if (!\u008C\u0086.\u007E\u009C\u0092((object) value, index).\u001D\u0005())
              return false;
          }
          return true;
      }
    }

    [DebuggerStepThrough]
    public static bool \u001E\u0005(this string value, char c, ref int startIndex, out string result)
    {
      int num = -1;
      for (int index = \u0005\u0081.\u007E\u0001\u0093((object) value) - 1; index >= startIndex; --index)
      {
        if ((int) \u008C\u0086.\u007E\u009C\u0092((object) value, index) == (int) c)
        {
          num = index;
          break;
        }
      }
      startIndex = num + 1;
      if (num == -1 || \u0005\u0081.\u007E\u0001\u0093((object) value) == startIndex)
      {
        result = (string) null;
        return false;
      }
      result = \u009C\u007F.\u007E\u0005\u0093((object) value, startIndex);
      return true;
    }

    [DebuggerStepThrough]
    public static bool \u001E\u0005(this string value, char c, ref int startIndex)
    {
      for (int index = \u0005\u0081.\u007E\u0001\u0093((object) value) - 1; index >= startIndex; --index)
      {
        if ((int) \u008C\u0086.\u007E\u009C\u0092((object) value, index) == (int) c)
        {
          startIndex = index + 1;
          return true;
        }
      }
      return false;
    }

    public static bool \u001D\u0005(this string value, char c, out string result)
    {
      int startIndex = 0;
      return value.\u001D\u0005(c, ref startIndex, out result);
    }

    public static string \u001D\u0005(this string value, int max_length)
    {
      switch (value)
      {
        case null:
          return value;
        default:
          if (\u0005\u0081.\u007E\u0001\u0093((object) value) > max_length)
            return \u0089\u001D.\u0083\u0093((object) \u0084\u0080.\u007E\u0006\u0093((object) value, 0, max_length - 1), (object) '…');
          goto case null;
      }
    }

    public static string \u001E\u0005(this string value, int count)
    {
      return string.Format(value, (object) count, count != 1 ? (object) \u0007.\u0001(27539) : (object) \u0007.\u0001(3251));
    }

    public static string \u001D\u0005(this object value)
    {
      if (value == null)
        return \u0007.\u0001(27544);
      ICollection collection = value as ICollection;
      if (collection == null)
        return \u001F\u0082.\u0087\u0093(\u0007.\u0001(27553), \u0002\u007F.\u001E\u0095(value), \u0007.\u0001(27553));
      StringBuilder stringBuilder1 = new StringBuilder(\u0007.\u0001(27558));
      IEnumerator enumerator = \u0015\u0082.\u007E\u0013\u0092((object) collection);
      int num = 0;
      while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
      {
        if (num > 0)
        {
          StringBuilder stringBuilder2 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0007.\u0001(27571));
        }
        StringBuilder stringBuilder3 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0005\u007F.\u007E\u0092\u0092((object) enumerator).\u001D\u0005());
        ++num;
      }
      StringBuilder stringBuilder4 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0007.\u0001(27576));
      return \u0002\u007F.\u007E\u0087\u0091((object) stringBuilder1);
    }

    public static unsafe bool \u001E\u0005(this string str, string match)
    {
      string str1 = match;
      IntPtr num1 = (IntPtr) str1;
      if (num1 != IntPtr.Zero)
      {
        int num2 = \u0006\u0083.\u001A\u009F();
        num1 += (IntPtr) num2;
      }
      char* chPtr1 = (char*) num1;
      string str2 = str;
      IntPtr num3 = (IntPtr) str2;
      if (num3 != IntPtr.Zero)
      {
        int num2 = \u0006\u0083.\u001A\u009F();
        num3 += (IntPtr) num2;
      }
      char* chPtr2 = (char*) num3;
      int index1 = 0;
      int index2 = 0;
      int num4 = 0;
      int num5 = 0;
      for (; (int) chPtr2[index2] != 0 && (int) chPtr1[index1] != 42; ++index2)
      {
        if ((int) chPtr1[index1] != (int) chPtr2[index2] && (int) chPtr1[index1] != 63)
          return false;
        ++index1;
      }
      while ((int) chPtr2[index2] != 0)
      {
        if ((int) chPtr1[index1] == 42)
        {
          if ((int) chPtr1[++index1] == 0)
            return true;
          num4 = index1;
          num5 = index2 + 1;
        }
        else if ((int) chPtr1[index1] == (int) chPtr2[index2] || (int) chPtr1[index1] == 63)
        {
          ++index1;
          ++index2;
        }
        else
        {
          index1 = num4;
          index2 = num5++;
        }
      }
      while ((int) chPtr1[index1] == 42)
        ++index1;
      return 0 == (int) chPtr1[index1];
    }
  }
}
