// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0017;
using \u001F;
using \u0081;
using System;
using System.Collections.Generic;
using System.IO;
using TSN.Collections;

namespace \u0017
{
  internal sealed class \u0080 : \u0080
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private Dictionary<\u0008, \u001F.\u0001> \u0001;

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
        return new byte[5]{ (byte) 71, (byte) 70, (byte) 87, (byte) 80, (byte) 83 };
      }
    }

    public \u001F.\u0001 this[\u0008 house]
    {
      get
      {
        house.\u001D\u0005();
        return this.\u0001[house];
      }
    }

    public bool HasCategories
    {
      get
      {
        return this.\u0001.\u001D\u0005<\u0008, \u001F.\u0001>(new \u0008[7]{ \u0008.\u0004, \u0008.\u0002, \u0008.\u0005, \u0008.\u0003, \u0008.\u0001, \u0008.\u0006, \u0008.\u0007 });
      }
    }

    public ReadOnlyDictionary<\u0008, \u001F.\u0001> WayPoints
    {
      get
      {
        return new ReadOnlyDictionary<\u0008, \u001F.\u0001>((IDictionary<\u0008, \u001F.\u0001>) this.\u0001);
      }
    }

    static \u0080()
    {
      \u0004.\u001D\u0005(typeof (\u0080));
    }

    public \u0080()
    {
      this.\u0001 = new Dictionary<\u0008, \u001F.\u0001>();
      this.\u0001.Add(\u0008.\u0004, new \u001F.\u0001());
      this.\u0001.Add(\u0008.\u0002, new \u001F.\u0001());
      this.\u0001.Add(\u0008.\u0005, new \u001F.\u0001());
      this.\u0001.Add(\u0008.\u0003, new \u001F.\u0001());
      this.\u0001.Add(\u0008.\u0001, new \u001F.\u0001());
      this.\u0001.Add(\u0008.\u0006, new \u001F.\u0001());
      this.\u0001.Add(\u0008.\u0007, new \u001F.\u0001());
    }

    public \u0080(string filePath)
      : base(filePath)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.\u0001 = new Dictionary<\u0008, \u001F.\u0001>();
      int num = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index = 0; index < num; ++index)
      {
        \u0008 key = (\u0008) \u0001\u0081.\u007E\u0096\u009D((object) reader);
        key.\u001D\u0005();
        \u001F.\u0001 obj = new \u001F.\u0001(reader);
        if (!this.\u0001.ContainsKey(key))
          this.\u0001.Add(key, obj);
      }
      if (!this.\u0001.\u001D\u0005<\u0008, \u001F.\u0001>(new \u0008[7]{ \u0008.\u0004, \u0008.\u0002, \u0008.\u0005, \u0008.\u0003, \u0008.\u0001, \u0008.\u0006, \u0008.\u0007 }))
        throw new InvalidDataException(\u0080.\u0001(30888));
      base.\u001D\u0005(reader, version);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.\u0001.Count);
      foreach (KeyValuePair<\u0008, \u001F.\u0001> keyValuePair in this.\u0001)
      {
        \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) keyValuePair.Key);
        keyValuePair.Value.\u001E\u0005(writer);
      }
    }
  }
}
