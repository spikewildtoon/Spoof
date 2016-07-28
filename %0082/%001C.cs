// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0082;
using \u0083;
using System;
using System.Runtime.CompilerServices;

namespace \u0082
{
  internal struct \u001C
  {
    public static readonly \u001C \u0001 = new \u001C(TimeSpan.Zero, 0U, 0U, 0U, 0U);

    public TimeSpan TotalRunTime { get; private set; }

    public uint TotalFishCaught { get; private set; }

    public uint TotalBootsCaught { get; private set; }

    public uint TotalBucketsSold { get; private set; }

    public uint TotalCasts { get; private set; }

    public \u001C(TimeSpan totalRunTime, uint totalFishCaught, uint totalBootsCaught, uint totalBucketsSold, uint totalCasts)
    {
      this = new \u001C();
      this.TotalRunTime = totalRunTime;
      this.TotalFishCaught = totalFishCaught;
      this.TotalBootsCaught = totalBootsCaught;
      this.TotalBucketsSold = totalBucketsSold;
      this.TotalCasts = totalCasts;
    }

    [SpecialName]
    public static \u001C \u001D\u0005(\u001C left, \u001A right)
    {
      return new \u001C(\u001C\u0083.\u0090\u0097(left.TotalRunTime, \u001B\u0082.\u001F\u0094(right.EndTime, right.StartTime)), left.TotalFishCaught + right.FishCaught, left.TotalBootsCaught + right.BootsCaught, left.TotalBucketsSold + right.BucketsSold, left.TotalCasts + right.Casts);
    }
  }
}
