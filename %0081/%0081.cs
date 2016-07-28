// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001D;
using \u007F;
using \u0082;
using \u0084;
using System.IO;

namespace \u0081
{
  internal sealed class \u0081 : \u0005
  {
    public new static readonly int \u0001 = 20;
    public new static readonly int \u0002 = 100;
    public static readonly int \u0003 = 5000;
    public static readonly bool \u0001 = true;
    public static readonly bool \u0002 = true;

    protected override int? Version
    {
      get
      {
        return new int?(4);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 4;
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
        return new byte[3]{ (byte) 74, (byte) 70, (byte) 83 };
      }
    }

    public \u001C JoeFishCaptureSettings { get; private set; }

    public string CustomCaptureFile { get; set; }

    public string CustomWayPointSettings { get; set; }

    public bool StopWhenNewSpecies { get; set; }

    public int CastDragDelay { get; set; }

    public int AfterCastDelay { get; set; }

    public \u001C JoeFishTotalRunStatistics { get; set; }

    public bool ShowStatisticsAfterRunning { get; set; }

    public bool RequireStableTarget { get; set; }

    public \u0081()
    {
      this.JoeFishTotalRunStatistics = \u001C.\u0001;
      this.JoeFishCaptureSettings = new \u001C();
      this.CustomWayPointSettings = (string) null;
      this.CustomCaptureFile = (string) null;
      this.CastDragDelay = \u0081.\u0081.\u0002;
      this.AfterCastDelay = \u0081.\u0081.\u0003;
      this.ShowStatisticsAfterRunning = true;
      this.StopWhenNewSpecies = \u0081.\u0081.\u0001;
      this.MaxColorRange = \u0081.\u0081.\u0001;
      this.RequireStableTarget = \u0081.\u0081.\u0002;
    }

    public \u0081(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.JoeFishCaptureSettings = new \u001C(reader);
      if (\u0099\u0082.\u007E\u0095\u009D((object) reader))
        goto label_6;
label_1:
      if (\u0099\u0082.\u007E\u0095\u009D((object) reader))
        this.CustomWayPointSettings = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      this.StopWhenNewSpecies = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.CastDragDelay = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      this.AfterCastDelay = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      this.ShowStatisticsAfterRunning = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.JoeFishTotalRunStatistics = reader.\u001D\u0005();
      if (version == 2)
      {
        double num1 = (double) \u0094\u0084.\u007E\u009D\u009D((object) reader);
        double num2 = (double) \u0094\u0084.\u007E\u009D\u009D((object) reader);
      }
      this.RequireStableTarget = version <= 3 ? \u0081.\u0081.\u0002 : \u0099\u0082.\u007E\u0095\u009D((object) reader);
      base.\u001D\u0005(reader, version);
      return;
label_6:
      this.CustomCaptureFile = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      goto label_1;
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      this.JoeFishCaptureSettings.\u001E\u0005(writer);
      switch (this.CustomCaptureFile)
      {
        case null:
          \u0099\u001F.\u007E\u000E\u009E((object) writer, false);
          break;
        default:
          \u0099\u001F.\u007E\u000E\u009E((object) writer, true);
          \u0092\u0081.\u007E\u001A\u009E((object) writer, this.CustomCaptureFile);
          break;
      }
      if (this.CustomWayPointSettings == null)
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, false);
      }
      else
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, true);
        \u0092\u0081.\u007E\u001A\u009E((object) writer, this.CustomWayPointSettings);
      }
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.StopWhenNewSpecies);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.CastDragDelay);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.AfterCastDelay);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.ShowStatisticsAfterRunning);
      writer.\u001D\u0005(this.JoeFishTotalRunStatistics);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.RequireStableTarget);
      base.\u001D\u0005(writer);
    }
  }
}
