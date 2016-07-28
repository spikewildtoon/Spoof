// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u007F;
using System.IO;

namespace \u007F
{
  internal abstract class \u0005 : \u0080
  {
    public static readonly int \u0001 = 50;
    public static readonly int \u0002 = 50;
    public static readonly float \u0001 = 0.5f;
    public static readonly float \u0002 = 1f;

    public int MaxColorRange { get; set; }

    public int AfterMoveBeforeClickDelay { get; set; }

    public int ButtonClickDelay { get; set; }

    public float TargetRange { get; set; }

    public float IntermediateTargetRange { get; set; }

    protected \u0005()
    {
      this.AfterMoveBeforeClickDelay = \u0005.\u0002;
      this.ButtonClickDelay = \u0005.\u0001;
      this.TargetRange = \u0005.\u0001;
      this.IntermediateTargetRange = \u0005.\u0002;
    }

    protected \u0005(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.MaxColorRange = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      this.AfterMoveBeforeClickDelay = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      this.ButtonClickDelay = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      this.TargetRange = \u0094\u0084.\u007E\u009D\u009D((object) reader);
      this.IntermediateTargetRange = \u0094\u0084.\u007E\u009D\u009D((object) reader);
      base.\u001D\u0005(reader, version);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.MaxColorRange);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.AfterMoveBeforeClickDelay);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.ButtonClickDelay);
      \u0082\u001E.\u007E\u0019\u009E((object) writer, this.TargetRange);
      \u0082\u001E.\u007E\u0019\u009E((object) writer, this.IntermediateTargetRange);
      base.\u001D\u0005(writer);
    }
  }
}
