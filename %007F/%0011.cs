// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u007F;
using \u0081;
using \u0082;
using System;
using System.Collections.Generic;
using System.IO;
using TSN.Collections;
using TSN.IO;

namespace \u007F
{
  internal struct \u0011
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly int \u0001;
    private static readonly Dictionary<\u0016.\u0082, Dictionary<\u0006, Dictionary<uint, uint>>> \u0001;
    private static readonly Dictionary<\u0016.\u0082, Dictionary<uint, uint>> \u0001;
    private static readonly Dictionary<\u0016.\u0082, Dictionary<\u0006, Dictionary<uint, List<uint>>>> \u0001;
    private static readonly Dictionary<\u0016.\u0082, \u0011> \u0001;
    public static readonly ReadOnlyDictionary<\u0016.\u0082, \u0011> \u0001;
    public static readonly object \u0001;
    private static readonly byte[] \u0001;
    public readonly \u0006 \u0001;
    public readonly uint \u0001;
    public readonly bool \u0001;
    public readonly DateTime \u0001;
    public readonly DateTime? \u0001;
    public readonly uint? \u0001;

    static \u0011()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u0011)));
      \u0011.\u0001 = 10;
      \u0011.\u0001 = new Dictionary<\u0016.\u0082, Dictionary<\u0006, Dictionary<uint, uint>>>();
      \u0011.\u0001 = new Dictionary<\u0016.\u0082, Dictionary<uint, uint>>();
      \u0011.\u0001 = new Dictionary<\u0016.\u0082, Dictionary<\u0006, Dictionary<uint, List<uint>>>>();
      \u0011.\u0001 = new Dictionary<\u0016.\u0082, \u0011>();
      \u0011.\u0001 = new ReadOnlyDictionary<\u0016.\u0082, \u0011>((IDictionary<\u0016.\u0082, \u0011>) \u0011.\u0001);
      \u0011.\u0001 = new object();
      \u0011.\u0001 = new byte[3]
      {
        (byte) 73,
        (byte) 78,
        (byte) 86
      };
    }

    private \u0011(\u0006 cog, uint cogsRemaining, bool skelecog, DateTime startTime, uint? estimatedDuration)
    {
      if (cog == null)
        throw new ArgumentNullException(\u0011.\u0001(76031));
      this.\u0001 = cog;
      this.\u0001 = cogsRemaining;
      this.\u0001 = skelecog;
      this.\u0001 = startTime;
      this.\u0001 = estimatedDuration;
      if (estimatedDuration.HasValue)
        this.\u0001 = new DateTime?(\u009E\u0086.\u001D\u0094(startTime, new TimeSpan(0, 0, (int) estimatedDuration.Value)));
      else
        this.\u0001 = new DateTime?();
    }

    private static void \u001D\u0005(\u0016.\u0082 district, \u0011 invasion, DateTime? endTime)
    {
      if (endTime.HasValue)
        goto label_9;
label_8:
      \u0011.\u0001.Remove(district);
      return;
label_9:
      List<uint> timesCollection;
      Dictionary<uint, uint> invasionTime;
      Dictionary<uint, uint> invasionTimes;
      \u0011.\u001D\u0005(district, invasion.\u0001, invasion.\u0001, out timesCollection, out invasionTime, out invasionTimes);
      timesCollection.Add((uint) endTime.Value.ToUniversalTime().Subtract(invasion.\u0001).TotalSeconds);
      if (timesCollection.Count > \u0011.\u0001)
        timesCollection.RemoveAt(0);
      if (invasionTime.ContainsKey(invasion.\u0001))
        invasionTime[invasion.\u0001] = \u0011.\u001D\u0005(district, invasion.\u0001, invasion.\u0001);
      else
        invasionTime.Add(invasion.\u0001, \u0011.\u001D\u0005(district, invasion.\u0001, invasion.\u0001));
      if (invasionTimes.ContainsKey(invasion.\u0001))
      {
        invasionTimes[invasion.\u0001] = \u0011.\u001D\u0005(district, invasion.\u0001);
        goto label_8;
      }
      else
      {
        invasionTimes.Add(invasion.\u0001, \u0011.\u001D\u0005(district, invasion.\u0001));
        goto label_8;
      }
    }

    public static void \u001D\u0005(\u0016.\u0082 district, \u0006 cog, uint cogsRemaining, bool skelecog, DateTime startTime, out uint? estimatedDuration, out DateTime actualStartTime)
    {
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0011.\u0001, ref flag);
        if (\u0011.\u0001.ContainsKey(district))
        {
          if (\u0011.\u0001[district].\u0001 == cog)
          {
            actualStartTime = \u0011.\u0001[district].\u0001;
            estimatedDuration = \u0011.\u0001[district].\u0001;
            return;
          }
          \u0011.\u001D\u0005(district, \u0011.\u0001[district], new DateTime?());
        }
        \u0011 obj2 = new \u0011(cog, cogsRemaining, skelecog, startTime.ToUniversalTime(), estimatedDuration = \u0011.\u001D\u0005(district, cog, cogsRemaining));
        actualStartTime = obj2.\u0001;
        \u0011.\u0001.Add(district, obj2);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    public static void \u001D\u0005(\u0016.\u0082 district)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0011.\u0001, ref flag);
        if (!\u0011.\u0001.ContainsKey(district))
          return;
        \u0011.\u001D\u0005(district, \u0011.\u0001[district], new DateTime?());
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    public static void \u001E\u0005(\u0016.\u0082 district)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0011.\u0001, ref flag);
        if (!\u0011.\u0001.ContainsKey(district))
          return;
        \u0011.\u001D\u0005(district, \u0011.\u0001[district], new DateTime?(\u001D\u0082.\u0011\u0094()));
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private static void \u001D\u0005(\u0016.\u0082 district, uint cogsRemaining, \u0006 cog, out List<uint> timesCollection, out Dictionary<uint, uint> invasionTime, out Dictionary<uint, uint> invasionTimes)
    {
      Dictionary<\u0006, Dictionary<uint, uint>> dictionary1;
      if (\u0011.\u0001.ContainsKey(district))
        dictionary1 = \u0011.\u0001[district];
      else
        \u0011.\u0001.Add(district, dictionary1 = new Dictionary<\u0006, Dictionary<uint, uint>>());
      if (dictionary1.ContainsKey(cog))
        invasionTime = dictionary1[cog];
      else
        dictionary1.Add(cog, invasionTime = new Dictionary<uint, uint>());
      if (\u0011.\u0001.ContainsKey(district))
        invasionTimes = \u0011.\u0001[district];
      else
        \u0011.\u0001.Add(district, invasionTimes = new Dictionary<uint, uint>());
      Dictionary<\u0006, Dictionary<uint, List<uint>>> dictionary2;
      if (\u0011.\u0001.ContainsKey(district))
        dictionary2 = \u0011.\u0001[district];
      else
        \u0011.\u0001.Add(district, dictionary2 = new Dictionary<\u0006, Dictionary<uint, List<uint>>>());
      Dictionary<uint, List<uint>> dictionary3;
      if (dictionary2.ContainsKey(cog))
        dictionary3 = dictionary2[cog];
      else
        dictionary2.Add(cog, dictionary3 = new Dictionary<uint, List<uint>>());
      if (dictionary3.ContainsKey(cogsRemaining))
        timesCollection = dictionary3[cogsRemaining];
      else
        dictionary3.Add(cogsRemaining, timesCollection = new List<uint>());
    }

    private static uint \u001D\u0005(\u0016.\u0082 district, uint cogsRemaining, \u0006 cog)
    {
      uint num1 = 0;
      List<uint> uintList = \u0011.\u0001[district][cog][cogsRemaining];
      foreach (uint num2 in uintList)
        num1 += num2;
      return num1 / (uint) uintList.Count;
    }

    private static uint \u001D\u0005(\u0016.\u0082 district, uint cogsRemaining)
    {
      uint num1 = 0;
      uint num2 = 0;
      foreach (Dictionary<uint, List<uint>> dictionary in \u0011.\u0001[district].Values)
      {
        if (dictionary.ContainsKey(cogsRemaining))
        {
          foreach (uint num3 in dictionary[cogsRemaining])
          {
            num1 += num3;
            ++num2;
          }
        }
      }
      return num1 / num2;
    }

    private static uint? \u001D\u0005(\u0016.\u0082 district, \u0006 cog, uint cogsRemaining)
    {
      uint? estimatedDuration;
      if (\u0011.\u0001.ContainsKey(district))
      {
        if (\u0011.\u0001[district].ContainsKey(cogsRemaining))
        {
          estimatedDuration = new uint?(\u0011.\u0001[district][cogsRemaining]);
          uint? nullable1 = \u0011.\u001E\u0005(district, cog, cogsRemaining);
          if (nullable1.HasValue)
          {
            uint? nullable2 = estimatedDuration;
            uint num = nullable1.Value;
            estimatedDuration = nullable2.HasValue ? new uint?(nullable2.GetValueOrDefault() - num) : new uint?();
          }
        }
        else if (!\u0011.\u001D\u0005(\u0011.\u0001[district], cogsRemaining, out estimatedDuration))
          estimatedDuration = new uint?();
      }
      else
        estimatedDuration = new uint?();
      return estimatedDuration;
    }

    private static uint? \u001E\u0005(\u0016.\u0082 district, \u0006 cog, uint cogsRemaining)
    {
      if (!\u0011.\u0001.ContainsKey(district))
        return new uint?();
      Dictionary<\u0006, Dictionary<uint, uint>> dictionary1 = \u0011.\u0001[district];
      if (!dictionary1.ContainsKey(cog))
        return new uint?();
      Dictionary<uint, uint> dictionary2 = dictionary1[cog];
      if (!dictionary2.ContainsKey(cogsRemaining))
        return new uint?();
      uint num = dictionary2[cogsRemaining];
      if (!\u0011.\u0001.ContainsKey(district))
        return new uint?();
      Dictionary<uint, uint> dictionary3 = \u0011.\u0001[district];
      if (!dictionary3.ContainsKey(cogsRemaining))
        return new uint?();
      return new uint?(dictionary3[cogsRemaining] - num);
    }

    private static bool \u001D\u0005(Dictionary<uint, uint> dic, uint cogsRemaining, out uint? estimatedDuration)
    {
      estimatedDuration = new uint?();
      uint num1 = uint.MaxValue;
      foreach (uint key in dic.Keys)
      {
        uint num2 = (uint) \u000F\u0081.\u009B\u0096((int) key - (int) cogsRemaining);
        if (num1 > num2)
        {
          num1 = num2;
          estimatedDuration = new uint?(key);
        }
      }
      if (!estimatedDuration.HasValue)
        return false;
      estimatedDuration = new uint?((uint) ((double) cogsRemaining / (double) estimatedDuration.Value * (double) dic[estimatedDuration.Value]));
      return true;
    }

    public static bool \u001D\u0005(\u0016.\u0082 district, out \u0011? invasion)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0011.\u0001, ref flag);
        invasion = new \u0011?();
        if (!\u0011.\u0001.ContainsKey(district))
          return false;
        \u0011 invasion1 = \u0011.\u0001[district];
        if (invasion1.\u0001.HasValue)
        {
          DateTime dateTime = \u001D\u0082.\u0011\u0094();
          if (\u0017\u0084.\u0080\u0094(dateTime.ToUniversalTime(), invasion1.\u0001.Value))
          {
            \u0011.\u001D\u0005(district, invasion1, new DateTime?());
            return false;
          }
        }
        invasion = new \u0011?(invasion1);
        return true;
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private static void \u001D\u0005()
    {
      \u0011.\u0001.Clear();
      \u0011.\u0001.Clear();
      \u0011.\u0001.Clear();
      \u0011.\u0001.Clear();
    }

    public static void \u001D\u0005(Stream stream)
    {
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0011.\u0001, ref flag);
        \u0010 obj2 = new \u0010(stream);
        try
        {
          BinaryWriter binaryWriter = new BinaryWriter((Stream) obj2);
          try
          {
            \u0015\u001C.\u007E\u0010\u009E((object) binaryWriter, \u0011.\u0001);
            \u0011\u001F.\u007E\u0015\u009E((object) binaryWriter, \u0011.\u0001.Count);
            using (Dictionary<\u0016.\u0082, Dictionary<\u0006, Dictionary<uint, List<uint>>>>.Enumerator enumerator1 = \u0011.\u0001.GetEnumerator())
            {
              while (enumerator1.MoveNext())
              {
                \u000F\u0083.\u007E\u0016\u009E((object) binaryWriter, enumerator1.Current.Key.\u0001);
                \u0011\u001F.\u007E\u0015\u009E((object) binaryWriter, enumerator1.Current.Value.Count);
                using (Dictionary<\u0006, Dictionary<uint, List<uint>>>.Enumerator enumerator2 = enumerator1.Current.Value.GetEnumerator())
                {
                  while (enumerator2.MoveNext())
                  {
                    \u0092\u0081.\u007E\u001A\u009E((object) binaryWriter, enumerator2.Current.Key.\u0002);
                    \u0011\u001F.\u007E\u0015\u009E((object) binaryWriter, enumerator2.Current.Value.Count);
                    using (Dictionary<uint, List<uint>>.Enumerator enumerator3 = enumerator2.Current.Value.GetEnumerator())
                    {
                      while (enumerator3.MoveNext())
                      {
                        \u000F\u0083.\u007E\u0016\u009E((object) binaryWriter, enumerator3.Current.Key);
                        \u0011\u001F.\u007E\u0015\u009E((object) binaryWriter, enumerator3.Current.Value.Count);
                        foreach (uint num in enumerator3.Current.Value)
                          \u000F\u0083.\u007E\u0016\u009E((object) binaryWriter, num);
                      }
                    }
                  }
                }
              }
            }
          }
          finally
          {
            if (binaryWriter != null)
              \u001A\u001E.\u007E\u0094\u0092((object) binaryWriter);
          }
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    public static void \u001E\u0005(Stream stream)
    {
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0011.\u0001, ref flag);
        \u0011.\u001D\u0005();
        try
        {
          \u0010 obj2 = new \u0010(stream);
          try
          {
            BinaryReader binaryReader = new BinaryReader((Stream) obj2);
            try
            {
              byte[] actualHeader = \u0004\u0086.\u007E\u0003\u009E((object) binaryReader, \u0011.\u0001.Length);
              if (!((IEnumerable<byte>) actualHeader).\u001D\u0005<byte>((IEnumerable<byte>) \u0011.\u0001))
                throw new InvalidFileType(\u0011.\u0001, actualHeader);
              int num1 = \u0005\u0081.\u007E\u0099\u009D((object) binaryReader);
              for (int index1 = 0; index1 < num1; ++index1)
              {
                \u0016.\u0082 index2 = \u0016.\u0082.\u001D\u0005(\u0004\u0081.\u007E\u009A\u009D((object) binaryReader));
                int num2 = \u0005\u0081.\u007E\u0099\u009D((object) binaryReader);
                Dictionary<\u0006, Dictionary<uint, uint>> dictionary1;
                if (\u0011.\u0001.ContainsKey(index2))
                  dictionary1 = \u0011.\u0001[index2];
                else
                  \u0011.\u0001.Add(index2, dictionary1 = new Dictionary<\u0006, Dictionary<uint, uint>>());
                Dictionary<\u0006, Dictionary<uint, List<uint>>> dictionary2;
                if (\u0011.\u0001.ContainsKey(index2))
                  dictionary2 = \u0011.\u0001[index2];
                else
                  \u0011.\u0001.Add(index2, dictionary2 = new Dictionary<\u0006, Dictionary<uint, List<uint>>>());
                Dictionary<uint, uint> dictionary3;
                if (\u0011.\u0001.ContainsKey(index2))
                  dictionary3 = \u0011.\u0001[index2];
                else
                  \u0011.\u0001.Add(index2, dictionary3 = new Dictionary<uint, uint>());
                for (int index3 = 0; index3 < num2; ++index3)
                {
                  \u0006 key1 = \u0006.Cogs[\u0002\u007F.\u007E\u0001\u009E((object) binaryReader)];
                  int num3 = \u0005\u0081.\u007E\u0099\u009D((object) binaryReader);
                  Dictionary<uint, uint> dictionary4;
                  if (dictionary1.ContainsKey(key1))
                    dictionary4 = dictionary1[key1];
                  else
                    dictionary1.Add(key1, dictionary4 = new Dictionary<uint, uint>());
                  Dictionary<uint, List<uint>> dictionary5;
                  if (dictionary2.ContainsKey(key1))
                    dictionary5 = dictionary2[key1];
                  else
                    dictionary2.Add(key1, dictionary5 = new Dictionary<uint, List<uint>>());
                  for (int index4 = 0; index4 < num3; ++index4)
                  {
                    uint key2 = \u0004\u0081.\u007E\u009A\u009D((object) binaryReader);
                    int num4 = \u0005\u0081.\u007E\u0099\u009D((object) binaryReader);
                    List<uint> uintList;
                    if (dictionary5.ContainsKey(key2))
                      uintList = dictionary5[key2];
                    else
                      dictionary5.Add(key2, uintList = new List<uint>());
                    uint num5 = 0;
                    for (int index5 = 0; index5 < num4; ++index5)
                    {
                      uint num6 = \u0004\u0081.\u007E\u009A\u009D((object) binaryReader);
                      uintList.Add(num6);
                      num5 += num6;
                    }
                    uint num7 = num5 / (uint) num4;
                    dictionary4.Add(key2, num7);
                  }
                  foreach (uint key2 in dictionary5.Keys)
                  {
                    if (dictionary3.ContainsKey(key2))
                      dictionary3[key2] = \u0011.\u001D\u0005(index2, key2);
                    else
                      dictionary3.Add(key2, \u0011.\u001D\u0005(index2, key2));
                  }
                }
              }
            }
            finally
            {
              if (binaryReader != null)
                \u001A\u001E.\u007E\u0094\u0092((object) binaryReader);
            }
          }
          finally
          {
            if (obj2 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj2);
          }
        }
        catch
        {
          \u0011.\u001D\u0005();
          throw;
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }
  }
}
