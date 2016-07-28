// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0083;
using System;

namespace \u0083
{
  internal struct \u001A
  {
    public DateTime StartTime { get; private set; }

    public DateTime EndTime { get; private set; }

    public uint FishCaught { get; private set; }

    public uint BootsCaught { get; private set; }

    public uint BucketsSold { get; private set; }

    public uint Casts { get; private set; }

    public \u001A(DateTime startTime, DateTime endTime, uint fishCaught, uint bootsCaught, uint bucketsSold, uint casts)
    {
      this = new \u001A();
      this.StartTime = startTime;
      this.EndTime = endTime;
      this.FishCaught = fishCaught;
      this.BootsCaught = bootsCaught;
      this.BucketsSold = bucketsSold;
      this.Casts = casts;
    }
  }
}
