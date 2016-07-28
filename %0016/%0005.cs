// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0016;
using System;

namespace \u0016
{
  internal class \u0005 : EventArgs
  {
    public long TotalCompleted { get; protected set; }

    public long TotalToComplete { get; protected set; }

    public long TotalRemaining
    {
      get
      {
        return this.TotalToComplete - this.TotalCompleted;
      }
    }

    public int PercentComplete
    {
      get
      {
        return \u0005.\u001D\u0005(this.TotalCompleted, this.TotalToComplete);
      }
    }

    public \u0005(long totalCompleted, long totalToComplete)
    {
      this.TotalCompleted = totalCompleted;
      this.TotalToComplete = totalToComplete;
    }

    public static int \u001D\u0005(long totalCompleted, long totalToComplete)
    {
      if (totalToComplete <= 0L)
        return 100;
      return (int) (totalCompleted * 100L / totalToComplete);
    }
  }
}
