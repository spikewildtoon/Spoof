// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using System.IO;

namespace \u0080
{
  internal sealed class \u0002 : \u0080
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
        return new byte[4]{ (byte) 82, (byte) 65, (byte) 67, (byte) 69 };
      }
    }

    public ushort UrbanTrackQualifies { get; set; }

    public ushort UrbanTrackWins { get; set; }

    public ushort RuralTrackQualifies { get; set; }

    public ushort RuralTrackWins { get; set; }

    public ushort SpeedwayTrackQualifies { get; set; }

    public ushort SpeedwayTrackWins { get; set; }

    public ushort TournamentQualifies { get; set; }

    public ushort TournamentWins { get; set; }

    public ushort TournamentSwept { get; set; }

    public bool AutoUpdate { get; set; }

    public bool TopMost { get; set; }

    public \u0002()
    {
      this.AutoUpdate = true;
    }

    public \u0002(string fileName)
      : base(fileName)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.SpeedwayTrackQualifies = \u0095\u0084.\u007E\u0098\u009D((object) reader);
      this.SpeedwayTrackWins = \u0095\u0084.\u007E\u0098\u009D((object) reader);
      this.UrbanTrackQualifies = \u0095\u0084.\u007E\u0098\u009D((object) reader);
      this.UrbanTrackWins = \u0095\u0084.\u007E\u0098\u009D((object) reader);
      this.RuralTrackQualifies = \u0095\u0084.\u007E\u0098\u009D((object) reader);
      this.RuralTrackWins = \u0095\u0084.\u007E\u0098\u009D((object) reader);
      this.TournamentQualifies = \u0095\u0084.\u007E\u0098\u009D((object) reader);
      this.TournamentWins = \u0095\u0084.\u007E\u0098\u009D((object) reader);
      this.TournamentSwept = \u0095\u0084.\u007E\u0098\u009D((object) reader);
      this.AutoUpdate = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.TopMost = \u0099\u0082.\u007E\u0095\u009D((object) reader);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0087\u0083.\u007E\u0014\u009E((object) writer, this.SpeedwayTrackQualifies);
      \u0087\u0083.\u007E\u0014\u009E((object) writer, this.SpeedwayTrackWins);
      \u0087\u0083.\u007E\u0014\u009E((object) writer, this.UrbanTrackQualifies);
      \u0087\u0083.\u007E\u0014\u009E((object) writer, this.UrbanTrackWins);
      \u0087\u0083.\u007E\u0014\u009E((object) writer, this.RuralTrackQualifies);
      \u0087\u0083.\u007E\u0014\u009E((object) writer, this.RuralTrackWins);
      \u0087\u0083.\u007E\u0014\u009E((object) writer, this.TournamentQualifies);
      \u0087\u0083.\u007E\u0014\u009E((object) writer, this.TournamentWins);
      \u0087\u0083.\u007E\u0014\u009E((object) writer, this.TournamentSwept);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.AutoUpdate);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.TopMost);
    }
  }
}
