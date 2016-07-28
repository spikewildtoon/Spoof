// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u001C;
using \u001F;
using \u0081;
using \u0083;
using System.Collections.Generic;
using System.IO;
using TSN.Collections;

namespace \u0083
{
  internal sealed class \u0016 : \u0080
  {
    public static readonly byte[] \u0001 = new byte[4]
    {
      (byte) 71,
      (byte) 70,
      (byte) 69,
      (byte) 83
    };

    protected override int? Version
    {
      get
      {
        return new int?(1);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override int MinimumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override byte[] Header
    {
      get
      {
        return \u0016.\u0001;
      }
    }

    public Dictionary<\u007F, \u000E> EstatePlantSettings { get; private set; }

    public List<\u0018> BeanCombinations { get; private set; }

    public \u001E PlantMethod { get; set; }

    public \u0016()
    {
      this.EstatePlantSettings = new Dictionary<\u007F, \u000E>();
      this.EstatePlantSettings.Add(\u007F.\u0004, new \u000E(\u007F.\u0004));
      this.EstatePlantSettings.Add(\u007F.\u0002, new \u000E(\u007F.\u0002));
      this.EstatePlantSettings.Add(\u007F.\u0005, new \u000E(\u007F.\u0005));
      this.EstatePlantSettings.Add(\u007F.\u0003, new \u000E(\u007F.\u0003));
      this.EstatePlantSettings.Add(\u007F.\u0001, new \u000E(\u007F.\u0001));
      this.EstatePlantSettings.Add(\u007F.\u0006, new \u000E(\u007F.\u0006));
      this.BeanCombinations = new List<\u0018>();
      this.PlantMethod = \u001E.\u0001;
    }

    public \u0016(string fileName)
      : base(fileName)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.EstatePlantSettings = new Dictionary<\u007F, \u000E>();
      this.BeanCombinations = new List<\u0018>();
      int num1 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index = 0; index < num1; ++index)
      {
        \u007F key = (\u007F) \u0001\u0081.\u007E\u0096\u009D((object) reader);
        \u000E obj = new \u000E(reader);
        if (!this.EstatePlantSettings.ContainsKey(key))
          this.EstatePlantSettings.Add(key, obj);
      }
      this.PlantMethod = (\u001E) \u0001\u0081.\u007E\u0096\u009D((object) reader);
      int num2 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      ReadOnlyDictionary<int, \u0018> readOnlyDictionary = \u0018.\u0001;
      for (int index = 0; index < num2; ++index)
      {
        int key = \u0005\u0081.\u007E\u0099\u009D((object) reader);
        if (readOnlyDictionary.ContainsKey(key))
          this.BeanCombinations.Add(readOnlyDictionary[key]);
      }
      base.\u001D\u0005(reader, version);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.EstatePlantSettings.Count);
      foreach (KeyValuePair<\u007F, \u000E> estatePlantSetting in this.EstatePlantSettings)
      {
        \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) estatePlantSetting.Key);
        estatePlantSetting.Value.\u001E\u0005(writer);
      }
      \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) this.PlantMethod);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.BeanCombinations.Count);
      foreach (\u0018 beanCombination in this.BeanCombinations)
        \u0011\u001F.\u007E\u0015\u009E((object) writer, beanCombination.NumericCombination);
      base.\u001D\u0005(writer);
    }
  }
}
