// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0019;
using \u001D;
using \u001E;
using \u0082;
using \u0084;
using System;
using System.Collections.Generic;
using System.IO;

namespace \u0082
{
  internal static class \u0015
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0015()
    {
      \u0004.\u001D\u0005(typeof (\u0015));
    }

    public static bool \u001D\u0005(EventHandler<\u0005> progressChanged, string installPath)
    {
      string str1 = \u0081\u0086.\u0011\u009F(installPath, \u0015.\u0001(98757));
      string str2 = \u0081\u0086.\u0011\u009F(installPath, \u0015.\u0001(98774));
      try
      {
        Stream str3 = (Stream) \u008F\u001C.\u0093\u009E(str1, FileMode.Open, FileAccess.Read, FileShare.None);
        try
        {
          Stream str4 = (Stream) \u008F\u001C.\u0093\u009E(str2, FileMode.Open, FileAccess.Read, FileShare.None);
          try
          {
            \u007F mf1 = new \u007F(str3);
            try
            {
              \u007F mf2 = new \u007F(str4);
              try
              {
                mf1.\u0082\u0005();
                mf2.\u0082\u0005();
                \u0018 index1 = mf1.\u001D\u0005(\u0015.\u0001(98791));
                \u0018 index2 = mf2.\u001D\u0005(\u0015.\u0001(98816));
                int total = index1.Files.Count + index2.Files.Count;
                int count = 0;
                if (progressChanged != null)
                  progressChanged((object) null, new \u0005((long) count, (long) total));
                \u0015.\u001D\u0005(progressChanged, installPath, mf1, index1, total, ref count);
                \u0015.\u001D\u0005(progressChanged, installPath, mf2, index2, total, ref count);
              }
              finally
              {
                if (mf2 != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) mf2);
              }
            }
            finally
            {
              if (mf1 != null)
                \u001A\u001E.\u007E\u0094\u0092((object) mf1);
            }
          }
          finally
          {
            if (str4 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) str4);
          }
        }
        finally
        {
          if (str3 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) str3);
        }
        return true;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        return false;
      }
    }

    private static void \u001D\u0005(EventHandler<\u0005> progressChanged, string installPath, \u007F mf, \u0018 index, int total, ref int count)
    {
      IEnumerator<KeyValuePair<string, \u0018.\u0001>> enumerator = index.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          KeyValuePair<string, \u0018.\u0001> current = enumerator.Current;
          string str = \u0081\u0086.\u0011\u009F(installPath, current.Key);
          if (!\u008F\u0084.\u0092\u009E(str) || (\u0012.\u001D\u0005(str) != current.Value.ExpectedSize || \u0080.\u0016.\u001E\u0005(\u0004.\u001D\u0005(str), current.Value.ExpectedHash)))
          {
            if (mf.\u007F\u0005(current.Key))
            {
              \u001B obj = mf[current.Key];
              mf.\u001D\u0005(obj);
              obj.\u001D\u0005(str);
              obj.Data = (byte[]) null;
              \u0081.\u0080.Instance.CreatedFileArchive.\u001E\u0005(str);
            }
            ++count;
            if (progressChanged != null)
              progressChanged((object) null, new \u0005((long) count, (long) total));
          }
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
    }
  }
}
