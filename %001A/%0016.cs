// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001A;
using System;

namespace \u001A
{
  internal static class \u0016
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0016()
    {
      \u0004.\u001D\u0005(typeof (\u0016));
    }

    public static string \u001D\u0005(string path, string fileNameFormat)
    {
      if (\u008F\u0084.\u009F\u0092(path))
        throw new ArgumentNullException(\u0016.\u0001(49679));
      if (\u008F\u0084.\u009F\u0092(fileNameFormat))
        throw new ArgumentNullException(\u0016.\u0001(49688));
      int num = 0;
      string str1;
      while (true)
      {
        string str2 = \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, fileNameFormat, new object[1]{ (object) num });
        str1 = \u0081\u0086.\u0011\u009F(path, str2);
        if (!\u0003\u0084.\u007E\u0098\u0092((object) str2, fileNameFormat, StringComparison.OrdinalIgnoreCase))
        {
          if (\u008F\u0084.\u0092\u009E(str1))
            ++num;
          else
            goto label_9;
        }
        else
          break;
      }
      throw new ArgumentException(\u0016.\u0001(49709));
label_9:
      return str1;
    }

    public static string \u001D\u0005(string directory, string fileNameFormat, string appendFormat)
    {
      if (\u008F\u0084.\u009F\u0092(directory))
        throw new ArgumentNullException(\u0016.\u0001(49679));
      if (\u008F\u0084.\u009F\u0092(fileNameFormat))
        throw new ArgumentNullException(\u0016.\u0001(49688));
      if (\u008F\u0084.\u009F\u0092(appendFormat))
        throw new ArgumentNullException(\u0016.\u0001(49778));
      int num = 0;
      string str1;
      while (true)
      {
        if (num == 0)
        {
          str1 = \u0081\u0086.\u0011\u009F(directory, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, fileNameFormat, new object[1]
          {
            (object) string.Empty
          }));
        }
        else
        {
          string str2 = \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, fileNameFormat, new object[1]{ (object) \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, appendFormat, new object[1]{ (object) num }) });
          if (!\u0003\u0084.\u007E\u0098\u0092((object) str2, fileNameFormat, StringComparison.OrdinalIgnoreCase))
            str1 = \u0081\u0086.\u0011\u009F(directory, str2);
          else
            break;
        }
        if (\u008F\u0084.\u0092\u009E(str1))
          ++num;
        else
          goto label_14;
      }
      throw new ArgumentException(\u0016.\u0001(49709));
label_14:
      return str1;
    }

    public static string \u001E\u0005(string directory, string extension)
    {
      string str1;
      do
      {
        \u0081\u0086 obj = \u0081\u0086.\u0011\u009F;
        string str2 = directory;
        Guid guid = \u009E\u0080.\u000F\u0096();
        string str3 = \u0081\u0086.\u0086\u0093(guid.ToString(), extension);
        str1 = obj(str2, str3);
      }
      while (\u008F\u0084.\u0092\u009E(str1));
      return str1;
    }
  }
}
