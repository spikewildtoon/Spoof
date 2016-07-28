// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001B;
using \u001E;
using \u0084;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace \u001F
{
  internal sealed class \u000E : \u0004
  {
    protected override int? Version
    {
      get
      {
        return new int?(2);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 2;
      }
    }

    protected override int MinimumVersion
    {
      get
      {
        return 1;
      }
    }

    public \u0014.\u007F HouseColor { get; set; }

    public bool Customized
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.State, (Enum) \u0013.\u0002);
      }
      set
      {
        if (this.Customized == value)
          return;
        if (value)
          this.State |= \u0013.\u0002;
        else
          this.State &= ~\u0013.\u0002;
      }
    }

    public bool GardenFlowers
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.State, (Enum) \u0013.\u0004);
      }
      set
      {
        if (this.GardenFlowers == value)
          return;
        if (value)
          this.State |= \u0013.\u0004;
        else
          this.State &= ~\u0013.\u0004;
      }
    }

    public bool GardenTrees
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.State, (Enum) \u0013.\u0003);
      }
      set
      {
        if (this.GardenTrees == value)
          return;
        if (value)
          this.State |= \u0013.\u0003;
        else
          this.State &= ~\u0013.\u0003;
      }
    }

    public KeyValuePair<\u007F.\u007F, \u0001>[] OrderedFlowers
    {
      get
      {
        return this.Flowers.OrderBy<KeyValuePair<\u007F.\u007F, \u0001>, \u007F.\u007F>((Func<KeyValuePair<\u007F.\u007F, \u0001>, \u007F.\u007F>) (f => f.Key)).ToArray<KeyValuePair<\u007F.\u007F, \u0001>>();
      }
    }

    public KeyValuePair<\u007F.\u007F, \u0080.\u001E>[] OrderedTrees
    {
      get
      {
        return this.Trees.OrderBy<KeyValuePair<\u007F.\u007F, \u0080.\u001E>, \u007F.\u007F>((Func<KeyValuePair<\u007F.\u007F, \u0080.\u001E>, \u007F.\u007F>) (t => t.Key)).ToArray<KeyValuePair<\u007F.\u007F, \u0080.\u001E>>();
      }
    }

    public Dictionary<\u007F.\u007F, \u0001> Flowers { get; private set; }

    public Dictionary<\u007F.\u007F, \u0080.\u001E> Trees { get; private set; }

    public \u0013 State { get; private set; }

    public ushort WaterCount { get; set; }

    public \u000E(\u0014.\u007F estateHome)
    {
      this.Flowers = new Dictionary<\u007F.\u007F, \u0001>();
      this.Trees = new Dictionary<\u007F.\u007F, \u0080.\u001E>();
      this.HouseColor = estateHome;
      this.GardenFlowers = true;
      this.GardenTrees = true;
      this.Pick = true;
      this.Plant = true;
      this.Water = true;
      this.Enabled = false;
      this.Customized = false;
      this.WaterCount = (ushort) 3;
      this.Flowers.Add(\u007F.\u007F.\u0006, new \u0001());
      this.Flowers.Add(\u007F.\u007F.\u0007, new \u0001());
      this.Flowers.Add(\u007F.\u007F.\u0008, new \u0001());
      this.Flowers.Add(\u007F.\u007F.\u000E, new \u0001());
      this.Flowers.Add(\u007F.\u007F.\u000F, new \u0001());
      this.Flowers.Add(\u007F.\u007F.\u0010, new \u0001());
      this.Flowers.Add(\u007F.\u007F.\u0011, new \u0001());
      this.Flowers.Add(\u007F.\u007F.\u0012, new \u0001());
      this.Flowers.Add(\u007F.\u007F.\u0013, new \u0001());
      this.Flowers.Add(\u007F.\u007F.\u0014, new \u0001());
      this.Trees.Add(\u007F.\u007F.\u0015, new \u0080.\u001E());
      this.Trees.Add(\u007F.\u007F.\u0016, new \u0080.\u001E());
      this.Trees.Add(\u007F.\u007F.\u0017, new \u0080.\u001E());
      this.Trees.Add(\u007F.\u007F.\u0018, new \u0080.\u001E());
      this.Trees.Add(\u007F.\u007F.\u0019, new \u0080.\u001E());
      this.Trees.Add(\u007F.\u007F.\u001A, new \u0080.\u001E());
      this.Trees.Add(\u007F.\u007F.\u001B, new \u0080.\u001E());
      this.Trees.Add(\u007F.\u007F.\u001C, new \u0080.\u001E());
    }

    public \u000E(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.Flowers = new Dictionary<\u007F.\u007F, \u0001>();
      this.Trees = new Dictionary<\u007F.\u007F, \u0080.\u001E>();
      this.HouseColor = (\u0014.\u007F) \u0001\u0081.\u007E\u0096\u009D((object) reader);
      this.State = (\u0013) \u0001\u0081.\u007E\u0096\u009D((object) reader);
      this.GardeningActions = (\u0017.\u007F) \u0001\u0081.\u007E\u0096\u009D((object) reader);
      int num1 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index = 0; index < num1; ++index)
      {
        \u007F.\u007F key = (\u007F.\u007F) \u0095\u0084.\u007E\u0098\u009D((object) reader);
        \u0001 obj = new \u0001(reader);
        if (!this.Flowers.ContainsKey(key))
          this.Flowers.Add(key, obj);
      }
      int num2 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index = 0; index < num2; ++index)
      {
        \u007F.\u007F key = (\u007F.\u007F) \u0095\u0084.\u007E\u0098\u009D((object) reader);
        \u0080.\u001E obj = new \u0080.\u001E(reader);
        if (!this.Trees.ContainsKey(key))
          this.Trees.Add(key, obj);
      }
      this.WaterCount = version <= 1 ? (ushort) 3 : \u0095\u0084.\u007E\u0098\u009D((object) reader);
      base.\u001D\u0005(reader, version);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) this.HouseColor);
      \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) this.State);
      \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) base.GardeningActions);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.Flowers.Count);
      foreach (KeyValuePair<\u007F.\u007F, \u0001> flower in this.Flowers)
      {
        \u0087\u0083.\u007E\u0014\u009E((object) writer, (ushort) flower.Key);
        flower.Value.\u001E\u0005(writer);
      }
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.Trees.Count);
      foreach (KeyValuePair<\u007F.\u007F, \u0080.\u001E> tree in this.Trees)
      {
        \u0087\u0083.\u007E\u0014\u009E((object) writer, (ushort) tree.Key);
        tree.Value.\u001E\u0005(writer);
      }
      \u0087\u0083.\u007E\u0014\u009E((object) writer, this.WaterCount);
      base.\u001D\u0005(writer);
    }
  }
}
