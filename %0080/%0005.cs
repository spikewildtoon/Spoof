// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0080;
using \u0083;
using System;
using System.Collections.Generic;

namespace \u0080
{
  internal static class \u0005
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    private static readonly string \u0007;
    private static readonly string \u0008;
    private static readonly string \u000E;
    private static readonly string \u000F;
    private static readonly string \u0010;
    private static readonly string \u0011;

    static \u0005()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u0005)));
      \u0005.\u0001 = \u0005.\u0001(80941);
      \u0005.\u0002 = \u0005.\u0001(80966);
      \u0005.\u0003 = \u001F\u0082.\u0087\u0093(\u0005.\u0001(81112), \u009C\u007F.\u007E\u0011\u0098((object) \u0008.Current.AssemblyVersion, 4), \u0005.\u0001(81161));
      \u0005.\u0004 = \u0005.\u0001(81299);
      \u0005.\u0005 = \u0005.\u0001(81340);
      \u0005.\u0006 = \u0005.\u0001(81353);
      \u0005.\u0007 = \u0005.\u0001(81362);
      \u0005.\u0008 = \u0005.\u0001(81353);
      \u0005.\u000E = \u0005.\u0001(81504);
      \u0005.\u000F = \u0005.\u0001(81353);
      \u0005.\u0010 = \u0005.\u0001(81533);
      \u0005.\u0011 = \u0005.\u0001(30845);
    }

    public static string \u001D\u0005(SortedList<DateTime, KeyValuePair<Version, string[]>> lst)
    {
      string[] strArray1 = new string[6]{ \u0005.\u0002, \u008E\u001E.\u0098\u0095(), \u0005.\u0006, \u008E\u001E.\u0098\u0095(), \u0005.\u0003, \u008E\u001E.\u0098\u0095() };
      string str1 = \u0007\u007F.\u0089\u0093(strArray1);
      if (lst != null)
      {
        IEnumerator<KeyValuePair<DateTime, KeyValuePair<Version, string[]>>> enumerator = lst.GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            \u0081\u0086 obj1 = \u0081\u0086.\u0086\u0093;
            string str2 = str1;
            \u0007\u001E obj2 = \u0007\u001E.\u0081\u0093;
            string str3 = \u0005.\u0001;
            object[] objArray1 = new object[5];
            objArray1[0] = (object) \u0005.\u0004;
            objArray1[1] = (object) enumerator.Current.Key.ToShortDateString();
            object[] objArray2 = objArray1;
            int index1 = 2;
            KeyValuePair<Version, string[]> keyValuePair = enumerator.Current.Value;
            string str4 = \u009C\u007F.\u007E\u0011\u0098((object) keyValuePair.Key, 4);
            objArray2[index1] = (object) str4;
            objArray1[3] = (object) \u0005.\u0005;
            objArray1[4] = (object) \u008E\u001E.\u0098\u0095();
            object[] objArray3 = objArray1;
            string str5 = obj2(str3, objArray3);
            str1 = obj1(str2, str5);
            for (int index2 = 0; index2 < enumerator.Current.Value.Value.Length; ++index2)
            {
              if (index2 == 0)
              {
                string[] strArray2 = new string[5]{ str1, \u0005.\u0007, enumerator.Current.Value.Value[index2], \u0005.\u0008, \u008E\u001E.\u0098\u0095() };
                str1 = \u0007\u007F.\u0089\u0093(strArray2);
              }
              else
              {
                string[] strArray2 = new string[5]{ str1, \u0005.\u000E, enumerator.Current.Value.Value[index2], \u0005.\u000F, \u008E\u001E.\u0098\u0095() };
                str1 = \u0007\u007F.\u0089\u0093(strArray2);
              }
            }
          }
        }
        finally
        {
          if (enumerator != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
        }
      }
      string str6 = \u001F\u0082.\u0087\u0093(str1, \u0005.\u0010, \u008E\u001E.\u0098\u0095());
      return \u0081\u0086.\u0086\u0093(str6, \u0005.\u0011);
    }
  }
}
