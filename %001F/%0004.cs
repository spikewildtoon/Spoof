// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u001D;
using \u001F;
using \u0083;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace \u001F
{
  internal sealed class \u0004
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private \u0017 \u0001;
    private CancellationToken \u0001;
    private long \u0001;
    private \u0004.\u0001 \u0001;

    public event EventHandler<\u0019.\u0019> PacketReceived;

    static \u0004()
    {
      \u0004.\u001D\u0005(typeof (\u0004));
    }

    public \u0004(\u0004.\u0002 download, CancellationToken cancellationToken)
    {
      if (download == null)
        throw new ArgumentNullException(\u0004.\u0001(68336));
      this.\u0001 = (\u0004.\u0001) download;
      this.\u0001 = cancellationToken;
    }

    private void \u001D\u0005(\u0019.\u0019 e)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, e);
    }

    public \u0004.\u0003 \u001D\u0005(out long size)
    {
      if (this.\u0001.RemotePaths.Count == 0)
      {
        size = 0L;
        return \u0004.\u0003.\u0004;
      }
      this.\u001D\u0005();
      this.\u0001.\u001D\u0005((object) this.\u0001);
      if (this.\u0001.Initialized)
      {
        size = this.\u0001.TotalBytes;
        return \u0004.\u0003.\u0002;
      }
      if (!this.\u0001.Canceled)
        return this.\u001D\u0005(out size);
      size = 0L;
      return \u0004.\u0003.\u0003;
    }

    private void \u001D\u0005()
    {
      switch (this.\u0001.DownloadMethod)
      {
        case \u001A.\u0001:
          this.\u0001 = new \u0017(this.\u0001.RemotePaths.Dequeue(), this.\u0001.TargetFile, true);
          break;
        case \u001A.\u0002:
          this.\u0001 = new \u0017(this.\u0001.RemotePaths.Dequeue(), this.\u0001.TargetStream, true);
          break;
      }
    }

    public \u0004.\u0003 \u001D\u0005()
    {
      // ISSUE: method pointer
      this.\u0001.PacketReceived += new EventHandler<\u0019.\u0019>((object) this, __methodptr(\u001D\u0005));
      this.\u0001.\u001E\u0005((object) this.\u0001);
      if (this.\u0001.DownloadCompleted)
        return \u0004.\u0003.\u0002;
      if (this.\u0001.Canceled)
        return \u0004.\u0003.\u0003;
      if (this.\u0001.RemotePaths.Count == 0)
        return \u0004.\u0003.\u0004;
      if (this.\u0001 > 0L)
      {
        this.\u001D\u0005(new \u0019.\u0019(-this.\u0001));
        this.\u0001 = 0L;
      }
      this.\u001D\u0005();
      return this.\u001D\u0005();
    }

    private interface \u0001
    {
      \u001A DownloadMethod { get; }

      Queue<Uri> RemotePaths { get; set; }

      Stream TargetStream { get; }

      string TargetFile { get; }
    }

    internal class \u0002 : \u0016, \u0004.\u0001
    {
      [NonSerialized]
      internal static \u0002 \u0001;
      private \u0004.\u0001 \u0001;
      private string \u0001;
      private Stream \u0001;

      public \u001A DownloadMethod { get; private set; }

      public string TargetFile
      {
        get
        {
          if (this.DownloadMethod != \u001A.\u0001)
            throw new InvalidOperationException(\u0004.\u0002.\u0001(68355));
          return this.\u0001;
        }
        private set
        {
          this.\u0001 = value;
        }
      }

      public Stream TargetStream
      {
        get
        {
          if (this.DownloadMethod != \u001A.\u0002)
            throw new InvalidOperationException(\u0004.\u0002.\u0001(68400));
          return this.\u0001;
        }
        private set
        {
          this.\u0001 = value;
        }
      }

      Queue<Uri> \u0004.\u0001.TheToonTownSpoofer\u002ENet\u002EExtendedHTTPDownloader\u002EIDownloadData\u002ERemotePaths { get; set; }

      static \u0002()
      {
        \u0004.\u001D\u0005(typeof (\u0004.\u0002));
      }

      private \u0002(Queue<Uri> remotePaths)
      {
        this.\u0001 = (\u0004.\u0001) this;
        this.\u0001.RemotePaths = remotePaths;
      }

      public \u0002(Stream destinationStream, Queue<Uri> remotePaths)
        : this(remotePaths)
      {
        this.DownloadMethod = \u001A.\u0002;
        this.TargetStream = destinationStream;
      }

      public \u0002(string destinationPath, Queue<Uri> remotePaths)
        : this(remotePaths)
      {
        this.DownloadMethod = \u001A.\u0001;
        this.TargetFile = destinationPath;
      }

      protected override void \u001D\u0005()
      {
        if (this.DownloadMethod == \u001A.\u0002)
          \u001A\u001E.\u007E\u0086\u009D((object) this.TargetStream);
        base.\u001D\u0005();
      }
    }

    internal enum \u0003
    {
      \u0001,
      \u0002,
      \u0003,
      \u0004,
    }
  }
}
