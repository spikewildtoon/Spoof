// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using System.IO;

namespace \u0016
{
  internal sealed class \u0010 : \u0080
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
        return new byte[3]{ (byte) 71, (byte) 77, (byte) 83 };
      }
    }

    public bool TopMost { get; set; }

    public bool ShowToolTips { get; set; }

    public \u0010()
    {
      this.TopMost = false;
      this.ShowToolTips = true;
    }

    public \u0010(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.TopMost = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.ShowToolTips = \u0099\u0082.\u007E\u0095\u009D((object) reader);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.TopMost);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.ShowToolTips);
    }
  }
}
