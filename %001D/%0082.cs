// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using System.IO;

namespace \u001D
{
  internal sealed class \u0082 : \u0080
  {
    public string Panda3dPath { get; set; }

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
        return new byte[3]{ (byte) 77, (byte) 80, (byte) 83 };
      }
    }

    public \u0082()
    {
      this.Panda3dPath = string.Empty;
    }

    public \u0082(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.Panda3dPath = \u0002\u007F.\u007E\u0001\u009E((object) reader);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0092\u0081.\u007E\u001A\u009E((object) writer, this.Panda3dPath);
    }
  }
}
