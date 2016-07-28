// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0016;

namespace \u0016
{
  internal sealed class \u0006 : \u0005
  {
    public long TotalDownloaded
    {
      get
      {
        return this.TotalCompleted;
      }
      protected set
      {
        this.TotalCompleted = value;
      }
    }

    public long TotalToDownload
    {
      get
      {
        return this.TotalToComplete;
      }
      protected set
      {
        this.TotalToComplete = value;
      }
    }

    public \u0006(long totalDownloaded, long totalToDownload)
      : base(totalDownloaded, totalToDownload)
    {
      this.TotalDownloaded = totalDownloaded;
      this.TotalToDownload = totalToDownload;
    }
  }
}
