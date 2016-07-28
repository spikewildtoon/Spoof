// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u0017;
using System;
using System.IO;

namespace \u0080
{
  internal sealed class \u001E : \u0080
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

    public \u007F GardeningActions { get; set; }

    public int WaterCount { get; set; }

    public bool Water
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.GardeningActions, (Enum) \u007F.\u0005);
      }
      set
      {
        if (this.Water == value)
          return;
        switch (value)
        {
          case false:
            this.GardeningActions &= ~\u007F.\u0005;
            break;
          case true:
            this.GardeningActions |= \u007F.\u0005;
            break;
        }
      }
    }

    public bool Enabled
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.GardeningActions, (Enum) \u007F.\u0002);
      }
      set
      {
        if (this.Enabled == value)
          return;
        switch (value)
        {
          case false:
            this.GardeningActions &= ~\u007F.\u0002;
            break;
          case true:
            this.GardeningActions |= \u007F.\u0002;
            break;
        }
      }
    }

    public \u001E()
    {
      this.GardeningActions = \u007F.\u0002 | \u007F.\u0005;
      this.WaterCount = 3;
    }

    public \u001E(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.GardeningActions = (\u007F) \u0001\u0081.\u007E\u0096\u009D((object) reader);
      this.WaterCount = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      base.\u001D\u0005(reader, version);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) this.GardeningActions);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.WaterCount);
      base.\u001D\u0005(writer);
    }
  }
}
