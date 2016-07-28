// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u0016;
using System.IO;

namespace \u0082
{
  internal sealed class \u0003 : \u0080
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

    protected override byte[] Header
    {
      get
      {
        return new byte[3]{ (byte) 77, (byte) 71, (byte) 83 };
      }
    }

    public \u0011 ScreenshotScaling { get; set; }

    public \u0003()
    {
      this.ScreenshotScaling = \u0011.\u0003;
    }

    public \u0003(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.ScreenshotScaling = (\u0011) \u0001\u0081.\u007E\u0096\u009D((object) reader);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) this.ScreenshotScaling);
    }
  }
}
