// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001E;
using System;
using System.Collections.Generic;

namespace \u0017
{
  internal static class \u0017
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0017()
    {
      \u0004.\u001D\u0005(typeof (\u0017.\u0017));
    }

    public static HashSet<string> \u001D\u0005(byte[] buffer)
    {
      HashSet<string> stringSet = (HashSet<string>) null;
      string line = \u0099\u0084.\u007E\u0018\u009C((object) \u001D\u001F.\u0016\u009C(), buffer);
      int startIndex = 0;
      while (startIndex < \u0005\u0081.\u007E\u0001\u0093((object) line) && line.\u001D\u0005(\u0017.\u0017.\u0001(28268), ref startIndex))
      {
        int num = startIndex -= \u0005\u0081.\u007E\u0001\u0093((object) \u0017.\u0017.\u0001(28268));
        string str1;
        if (line.\u001D\u0005('/', ref startIndex, out str1))
        {
          if (!\u007F.\u001E\u0005(str1))
          {
            startIndex = num + \u0005\u0081.\u007E\u0001\u0093((object) \u0017.\u0017.\u0001(28268));
          }
          else
          {
            string str2;
            if (line.\u001D\u0005('/', ref startIndex, out str1) && (str2 = \u0002\u007F.\u007E\u0019\u0093((object) str1)) != null)
            {
              string str3;
              if (!\u0008\u001F.\u009A\u0092(str2, \u0017.\u0017.\u0001(28277)))
              {
                if (\u0008\u001F.\u009A\u0092(str2, \u0017.\u0017.\u0001(28286)))
                {
                  while (startIndex <= \u0005\u0081.\u007E\u0001\u0093((object) line))
                  {
                    if (line.\u001D\u0005('.', ref startIndex) && line.\u001D\u0005(ref startIndex, 3, out str1))
                    {
                      string str4;
                      if ((str4 = \u0002\u007F.\u007E\u0019\u0093((object) str1)) != null && (\u0008\u001F.\u009A\u0092(str4, \u0017.\u0017.\u0001(28329)) || \u0008\u001F.\u009A\u0092(str4, \u0017.\u0017.\u0001(28334))))
                      {
                        str3 = \u0084\u0080.\u007E\u0006\u0093((object) line, num, startIndex - num);
                        if (\u0017.\u0017.\u001D\u0005(str3))
                          goto label_18;
                        else
                          break;
                      }
                      else if (!\u0017.\u0017.\u001D\u0005(str1))
                        break;
                    }
                  }
                  continue;
                }
                continue;
              }
              string str5;
              if (line.\u001D\u0005('/', ref startIndex, out str1) && (str5 = \u0002\u007F.\u007E\u0019\u0093((object) str1)) != null && (\u0008\u001F.\u009A\u0092(str5, \u0017.\u0017.\u0001(28295)) || \u0008\u001F.\u009A\u0092(str5, \u0017.\u0017.\u0001(28300)) || \u0008\u001F.\u009A\u0092(str5, \u0017.\u0017.\u0001(28309))))
              {
                while (startIndex <= \u0005\u0081.\u007E\u0001\u0093((object) line))
                {
                  if (line.\u001D\u0005('.', ref startIndex) && line.\u001D\u0005(ref startIndex, 3, out str1))
                  {
                    string str4;
                    if ((str4 = \u0002\u007F.\u007E\u0019\u0093((object) str1)) != null && (\u0008\u001F.\u009A\u0092(str4, \u0017.\u0017.\u0001(28314)) || \u0008\u001F.\u009A\u0092(str4, \u0017.\u0017.\u0001(28319)) || \u0008\u001F.\u009A\u0092(str4, \u0017.\u0017.\u0001(28324))))
                    {
                      str3 = \u0084\u0080.\u007E\u0006\u0093((object) line, num, startIndex - num);
                      if (\u0017.\u0017.\u001D\u0005(str3))
                        goto label_18;
                      else
                        break;
                    }
                    else if (!\u0017.\u0017.\u001D\u0005(str1))
                      break;
                  }
                }
                continue;
              }
              continue;
label_18:
              if (stringSet == null)
                stringSet = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
              if (!stringSet.Contains(str3))
                stringSet.Add(str3);
            }
          }
        }
      }
      return stringSet;
    }

    private static bool \u001D\u0005(this string str)
    {
      string str1 = str;
      for (int index = 0; index < \u0005\u0081.\u007E\u0001\u0093((object) str1); ++index)
      {
        char ch = \u008C\u0086.\u007E\u009C\u0092((object) str1, index);
        if (!\u0095\u0080.\u0008\u0095(ch) && !\u0095\u0080.\u000E\u0095(ch) && ((int) ch != 95 && (int) ch != 45) && ((int) ch != 46 && (int) ch != 47))
          return false;
      }
      return true;
    }
  }
}
