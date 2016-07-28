// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u0017;
using System;
using System.IO;

namespace \u001B
{
  internal abstract class \u0004 : \u0080
  {
    public bool Pick
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.GardeningActions, (Enum) \u007F.\u0003);
      }
      set
      {
        if (this.Pick == value)
          return;
        if (value)
          this.GardeningActions |= \u007F.\u0003;
        else
          this.GardeningActions &= ~\u007F.\u0003;
      }
    }

    public bool Plant
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.GardeningActions, (Enum) \u007F.\u0004);
      }
      set
      {
        if (this.Plant == value)
          return;
        if (value)
          this.GardeningActions |= \u007F.\u0004;
        else
          this.GardeningActions &= ~\u007F.\u0004;
      }
    }

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
        if (value)
          this.GardeningActions |= \u007F.\u0005;
        else
          this.GardeningActions &= ~\u007F.\u0005;
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
        if (value)
          this.GardeningActions |= \u007F.\u0002;
        else
          this.GardeningActions &= ~\u007F.\u0002;
      }
    }

    public \u007F GardeningActions { get; set; }

    protected \u0004(BinaryReader reader)
      : base(reader)
    {
    }

    protected \u0004()
    {
    }
  }
}
