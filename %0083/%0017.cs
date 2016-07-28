// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0017;
using \u001D;
using \u007F;
using System;
using System.IO;
using System.Net;
using System.Threading;

namespace \u0083
{
  internal sealed class \u0017
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    private \u0083.\u0017.\u0001 \u0001;
    private string \u0007;
    private Stream \u0001;

    public int DownloadAttempts { get; private set; }

    public int MaxDownloadAttempts { get; set; }

    public bool RequiresInitialization { get; set; }

    public bool Initialized
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (System.Enum) \u0083.\u0017.\u0001.\u0007);
      }
      set
      {
        if (this.Initialized == value)
          return;
        switch (value)
        {
          case false:
            this.\u0001 &= ~\u0083.\u0017.\u0001.\u0007;
            break;
          case true:
            this.\u0001 |= \u0083.\u0017.\u0001.\u0007;
            break;
        }
      }
    }

    public bool Initializing
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (System.Enum) \u0083.\u0017.\u0001.\u0006);
      }
      set
      {
        if (this.Initializing == value)
          return;
        switch (value)
        {
          case false:
            this.\u0001 &= ~\u0083.\u0017.\u0001.\u0006;
            break;
          case true:
            this.\u0001 |= \u0083.\u0017.\u0001.\u0006;
            break;
        }
      }
    }

    public bool DownloadFailed
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (System.Enum) \u0083.\u0017.\u0001.\u0004);
      }
      set
      {
        if (this.DownloadFailed == value)
          return;
        switch (value)
        {
          case false:
            this.\u0001 &= ~\u0083.\u0017.\u0001.\u0004;
            break;
          case true:
            this.\u0001 |= \u0083.\u0017.\u0001.\u0004;
            break;
        }
      }
    }

    public bool Canceled
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (System.Enum) \u0083.\u0017.\u0001.\u0005);
      }
      set
      {
        if (this.Canceled == value)
          return;
        switch (value)
        {
          case false:
            this.\u0001 &= ~\u0083.\u0017.\u0001.\u0005;
            break;
          case true:
            this.\u0001 |= \u0083.\u0017.\u0001.\u0005;
            break;
        }
      }
    }

    public bool DownloadStarted
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (System.Enum) \u0083.\u0017.\u0001.\u0002);
      }
      set
      {
        if (this.DownloadStarted == value)
          return;
        switch (value)
        {
          case false:
            this.\u0001 &= ~\u0083.\u0017.\u0001.\u0002;
            break;
          case true:
            this.\u0001 |= \u0083.\u0017.\u0001.\u0002;
            break;
        }
      }
    }

    public bool DownloadCompleted
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) this.\u0001, (System.Enum) \u0083.\u0017.\u0001.\u0003);
      }
      set
      {
        if (this.DownloadCompleted == value)
          return;
        switch (value)
        {
          case false:
            this.\u0001 &= ~\u0083.\u0017.\u0001.\u0003;
            break;
          case true:
            this.\u0001 |= \u0083.\u0017.\u0001.\u0003;
            break;
        }
      }
    }

    public string TargetFile
    {
      get
      {
        if (this.DownloadMethod != \u001A.\u0001)
          throw new InvalidOperationException(\u0083.\u0017.\u0005);
        return this.\u0007;
      }
    }

    public Stream TargetStream
    {
      get
      {
        if (this.DownloadMethod != \u001A.\u0002)
          throw new InvalidOperationException(\u0083.\u0017.\u0006);
        return this.\u0001;
      }
    }

    public \u001A DownloadMethod { get; private set; }

    public Uri Target { get; private set; }

    public int FailureDelay { get; set; }

    public bool AllowResuming { get; private set; }

    public long TotalBytes { get; private set; }

    public long BytesDownloaded { get; private set; }

    public event EventHandler<\u0006> ProgressChanged;

    public event EventHandler<\u0019.\u0019> PacketReceived;

    public event EventHandler<\u001C> DownloadError;

    public event EventHandler DownloadComplete;

    public event EventHandler<\u0015.\u0001> DownloadSizeAcquired;

    public event EventHandler DownloadInitialized;

    public event EventHandler<\u001C> DownloadInitializationFailed;

    public event EventHandler DownloadCanceled;

    public event EventHandler DownloadInititializationCanceled;

    static \u0017()
    {
      \u0004.\u001D\u0005(typeof (\u0083.\u0017));
      \u0083.\u0017.\u0001 = \u0083.\u0017.\u0001(77466);
      \u0083.\u0017.\u0002 = \u0083.\u0017.\u0001(102850);
      \u0083.\u0017.\u0003 = \u0083.\u0017.\u0001(102899);
      \u0083.\u0017.\u0004 = \u0083.\u0017.\u0001(102940);
      \u0083.\u0017.\u0005 = \u0083.\u0017.\u0001(69866);
      \u0083.\u0017.\u0006 = \u0083.\u0017.\u0001(69911);
    }

    private \u0017(Uri downloadFile, \u001A method, bool allowResuming)
    {
      method.\u001D\u0005();
      this.DownloadMethod = method;
      this.Target = downloadFile;
      this.AllowResuming = allowResuming;
      this.FailureDelay = 1000;
      this.DownloadAttempts = 3;
      this.RequiresInitialization = true;
    }

    public \u0017(Uri downloadFile, Stream destinationStream, bool allowResuming)
      : this(downloadFile, \u001A.\u0002, allowResuming)
    {
      if (\u008E\u0081.\u008A\u0002\u0002(downloadFile, (Uri) null))
        throw new ArgumentNullException(\u0083.\u0017.\u0001(102733));
      if (destinationStream == null)
        throw new ArgumentNullException(\u0083.\u0017.\u0001(102750));
      if (!\u0099\u0082.\u007E\u007F\u009D((object) destinationStream))
        throw new ArgumentException(\u0083.\u0017.\u0001(102775));
      this.\u0001 = destinationStream;
    }

    public \u0017(Uri downloadFile, string destinationFileName, bool allowResuming)
      : this(downloadFile, \u001A.\u0001, allowResuming)
    {
      if (\u008F\u0084.\u009E\u0092(destinationFileName))
        throw new ArgumentNullException(\u0083.\u0017.\u0001(102812));
      this.\u0007 = destinationFileName;
    }

    private void \u001D\u0005()
    {
      if (this.\u0003 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0003, (object) this, EventArgs.Empty);
    }

    private void \u001E\u0005()
    {
      if (this.\u0004 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0004, (object) this, EventArgs.Empty);
    }

    private void \u001F\u0005()
    {
      if (this.\u0002 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
    }

    private void \u001D\u0005(Exception ex)
    {
      if (this.\u0002 == null)
        return;
      this.\u0002((object) this, new \u001C(ex));
    }

    private void \u007F\u0005()
    {
      if (this.BytesDownloaded <= 0L || this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0006(this.BytesDownloaded, this.TotalBytes));
    }

    private void \u001F\u0005(long packetLength)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0019.\u0019(packetLength));
    }

    private void \u007F\u0005(long downloadSize)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0015.\u0001(downloadSize));
    }

    private void \u001E\u0005(Exception ex)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u001C(ex));
    }

    private void \u0080\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u0081\u0005()
    {
      switch (this.DownloadMethod)
      {
        case \u001A.\u0001:
          if (\u008F\u0084.\u0092\u009E(this.\u0007))
          {
            \u009C\u001F.\u0091\u009E(this.\u0007);
            break;
          }
          break;
        case \u001A.\u0002:
          long num = \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, 0L, SeekOrigin.Begin);
          \u0012\u0080.\u007E\u008C\u009D((object) this.\u0001, 0L);
          break;
      }
      this.BytesDownloaded = 0L;
    }

    public void \u001D\u0005(object obj)
    {
      if (obj == null)
        throw new ArgumentNullException(\u0083.\u0017.\u0001);
      if (!(obj is CancellationToken))
        throw new ArgumentException(\u0083.\u0017.\u0002, \u0083.\u0017.\u0001);
      CancellationToken cancellationToken = (CancellationToken) obj;
      if (this.Initializing)
        throw new NotSupportedException(\u0083.\u0017.\u0004);
      try
      {
        try
        {
          this.Initializing = true;
          HttpWebRequest httpWebRequest = (HttpWebRequest) null;
          try
          {
            cancellationToken.ThrowIfCancellationRequested();
            this.Initialized = false;
            httpWebRequest = this.Target.\u001D\u0005();
            HttpWebResponse httpWebResponse = \u000E\u0083.\u007E\u0093\u0002\u0002((object) httpWebRequest) as HttpWebResponse;
            try
            {
              if (this.TotalBytes == 0L)
              {
                try
                {
                  this.TotalBytes = \u001F\u001E.\u007E\u0097\u0002\u0002((object) httpWebResponse);
                }
                catch (NotSupportedException ex)
                {
                  this.TotalBytes = -1L;
                }
              }
              if (this.AllowResuming)
              {
                if (this.DownloadMethod == \u001A.\u0002)
                {
                  this.BytesDownloaded = \u001F\u001E.\u007E\u0080\u009D((object) this.\u0001);
                }
                else
                {
                  FileInfo fileInfo = new FileInfo(this.\u0007);
                  this.BytesDownloaded = !\u0099\u0082.\u007E\u0086\u009E((object) fileInfo) ? 0L : \u001F\u001E.\u007E\u0098\u009E((object) fileInfo);
                }
                if (this.BytesDownloaded > 0L)
                {
                  if (this.TotalBytes <= 0L || this.TotalBytes < this.BytesDownloaded)
                    this.\u0081\u0005();
                  else if (this.DownloadMethod == \u001A.\u0001)
                  {
                    DateTime universalTime = \u0008\u007F.\u007E\u009E\u0002\u0002((object) httpWebResponse).ToUniversalTime();
                    DateTime dateTime = \u0006\u001C.\u0094\u009E(this.\u0007);
                    if (\u0017\u0084.\u0081\u0094(universalTime, dateTime))
                      this.\u0081\u0005();
                  }
                  \u001A\u001E.\u007E\u0094\u0002\u0002((object) httpWebRequest);
                  \u001A\u001E.\u007E\u0096\u0002\u0002((object) httpWebResponse);
                  if (this.BytesDownloaded == this.TotalBytes)
                  {
                    this.DownloadCompleted = true;
                    return;
                  }
                }
              }
              else
              {
                this.\u0081\u0005();
                this.BytesDownloaded = 0L;
              }
            }
            finally
            {
              if (httpWebResponse != null)
                \u001A\u001E.\u007E\u0094\u0092((object) httpWebResponse);
            }
          }
          finally
          {
            if (httpWebRequest != null)
              \u001A\u001E.\u007E\u0094\u0002\u0002((object) httpWebRequest);
          }
        }
        finally
        {
          this.Initializing = false;
        }
        this.Initialized = true;
        this.\u007F\u0005(this.TotalBytes);
        this.\u001F\u0005();
      }
      catch (OperationCanceledException ex)
      {
        this.Canceled = true;
        this.\u001E\u0005();
      }
      catch (Exception ex)
      {
        this.DownloadFailed = true;
        this.\u001D\u0005(ex);
      }
    }

    public void \u001E\u0005(object obj)
    {
      if (obj == null)
        throw new ArgumentNullException(\u0083.\u0017.\u0001);
      if (!(obj is CancellationToken))
        throw new ArgumentException(\u0083.\u0017.\u0002, \u0083.\u0017.\u0001);
      CancellationToken cancellationToken = (CancellationToken) obj;
      if (this.DownloadStarted)
        throw new NotSupportedException(\u0083.\u0017.\u0003);
      try
      {
        try
        {
          this.DownloadStarted = true;
          this.DownloadAttempts = 0;
          while (true)
          {
            ++this.DownloadAttempts;
            try
            {
              cancellationToken.ThrowIfCancellationRequested();
              if (!this.Initialized && (this.RequiresInitialization || this.AllowResuming))
                this.\u001D\u0005((object) cancellationToken);
              cancellationToken.ThrowIfCancellationRequested();
              if (this.DownloadCompleted)
              {
                this.\u001F\u0005(this.BytesDownloaded);
                this.\u007F\u0005();
                return;
              }
              HttpWebRequest httpWebRequest = this.Target.\u001D\u0005();
              if (this.AllowResuming && this.BytesDownloaded > 0L)
              {
                \u0012\u0080.\u007E\u009D\u0002\u0002((object) httpWebRequest, this.BytesDownloaded);
              }
              else
              {
                this.\u0081\u0005();
                this.BytesDownloaded = 0L;
              }
              HttpWebResponse httpWebResponse = \u000E\u0083.\u007E\u0093\u0002\u0002((object) httpWebRequest) as HttpWebResponse;
              try
              {
                try
                {
                  if (this.AllowResuming && this.BytesDownloaded > 0L && \u0006\u0082.\u007E\u009F\u0002\u0002((object) httpWebResponse) != HttpStatusCode.PartialContent)
                    this.\u0081\u0005();
                  if (this.BytesDownloaded > 0L)
                  {
                    this.\u001F\u0005(this.BytesDownloaded);
                    this.\u007F\u0005();
                  }
                  Stream stream1 = \u009F\u001D.\u007E\u0098\u0002\u0002((object) httpWebResponse);
                  try
                  {
                    byte[] numArray = new byte[4096];
                    int num1;
                    if (this.DownloadMethod == \u001A.\u0002)
                    {
                      long num2 = \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, 0L, SeekOrigin.End);
                      while ((num1 = \u0080\u0081.\u007E\u008D\u009D((object) stream1, numArray, 0, numArray.Length)) > 0)
                      {
                        \u0016\u0086.\u007E\u008F\u009D((object) this.\u0001, numArray, 0, num1);
                        this.BytesDownloaded += (long) num1;
                        this.\u001F\u0005((long) num1);
                        this.\u007F\u0005();
                        cancellationToken.ThrowIfCancellationRequested();
                      }
                    }
                    else
                    {
                      Stream stream2 = (Stream) \u008F\u001C.\u0093\u009E(this.\u0007, FileMode.Append, FileAccess.Write, FileShare.None);
                      try
                      {
                        while ((num1 = \u0080\u0081.\u007E\u008D\u009D((object) stream1, numArray, 0, numArray.Length)) > 0)
                        {
                          \u0016\u0086.\u007E\u008F\u009D((object) stream2, numArray, 0, num1);
                          this.BytesDownloaded += (long) num1;
                          this.\u001F\u0005((long) num1);
                          this.\u007F\u0005();
                          cancellationToken.ThrowIfCancellationRequested();
                        }
                      }
                      finally
                      {
                        if (stream2 != null)
                          \u001A\u001E.\u007E\u0094\u0092((object) stream2);
                      }
                    }
                    if (num1 == 0)
                    {
                      this.DownloadCompleted = true;
                      break;
                    }
                    break;
                  }
                  finally
                  {
                    if (stream1 != null)
                      \u001A\u001E.\u007E\u0094\u0092((object) stream1);
                  }
                }
                finally
                {
                  \u001A\u001E.\u007E\u0094\u0002\u0002((object) httpWebRequest);
                  \u001A\u001E.\u007E\u0096\u0002\u0002((object) httpWebResponse);
                }
              }
              finally
              {
                if (httpWebResponse != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) httpWebResponse);
              }
            }
            catch (OperationCanceledException ex)
            {
              throw;
            }
            catch (Exception ex)
            {
              ex.\u001D\u0005((object) \u0081\u0086.\u0086\u0093(\u0083.\u0017.\u0001(102841), \u0002\u007F.\u007E\u0088\u0002\u0002((object) this.Target)));
              if (this.DownloadAttempts < this.MaxDownloadAttempts)
              {
                if (this.FailureDelay > 0)
                {
                  if (this.FailureDelay != -1)
                    \u001E\u001E.\u008F\u0098(this.FailureDelay);
                }
              }
              else
                throw;
            }
          }
        }
        finally
        {
          this.DownloadStarted = false;
        }
        this.\u0080\u0005();
      }
      catch (OperationCanceledException ex)
      {
        this.Canceled = true;
        this.\u001D\u0005();
      }
      catch (Exception ex)
      {
        this.DownloadFailed = true;
        this.\u001E\u0005(ex);
      }
    }

    [System.Flags]
    private enum \u0001
    {
      \u0001 = 0,
      \u0002 = 1,
      \u0003 = 2,
      \u0004 = 4,
      \u0005 = 8,
      \u0006 = 16,
      \u0007 = 32,
    }
  }
}
