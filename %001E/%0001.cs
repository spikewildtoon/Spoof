// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0017;
using \u001B;
using \u001C;
using System.IO;
using TSN.Collections;

namespace \u001E
{
  internal sealed class \u0001 : \u0004
  {
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

    public \u0018 BeanCombination { get; set; }

    public int WaterCount { get; set; }

    public \u0001()
    {
      this.GardeningActions = \u007F.\u0002 | \u007F.\u0003 | \u007F.\u0004 | \u007F.\u0005;
      this.WaterCount = 3;
    }

    public \u0001(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.GardeningActions = (\u007F) \u0001\u0081.\u007E\u0096\u009D((object) reader);
      int key = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      ReadOnlyDictionary<int, \u0018> readOnlyDictionary = \u0018.\u0001;
      this.BeanCombination = !readOnlyDictionary.ContainsKey(key) ? (\u0018) null : readOnlyDictionary[key];
      this.WaterCount = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      base.\u001D\u0005(reader, version);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) base.GardeningActions);
      if (this.BeanCombination == null)
        \u0011\u001F.\u007E\u0015\u009E((object) writer, 0);
      else
        \u0011\u001F.\u007E\u0015\u009E((object) writer, this.BeanCombination.NumericCombination);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.WaterCount);
      base.\u001D\u0005(writer);
    }
  }
}
