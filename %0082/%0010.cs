// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0082;
using System;
using System.Diagnostics;
using System.IO;

namespace \u0082
{
  internal sealed class \u0010 : Stream
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private long \u0001;
    private long \u0002;
    private Stream \u0001;

    public override bool CanRead
    {
      [DebuggerStepThrough] get
      {
        return \u0099\u0082.\u007E\u001E\u009D((object) this.\u0001);
      }
    }

    public override bool CanSeek
    {
      [DebuggerStepThrough] get
      {
        return \u0099\u0082.\u007E\u001F\u009D((object) this.\u0001);
      }
    }

    public override bool CanWrite
    {
      [DebuggerStepThrough] get
      {
        return \u0099\u0082.\u007E\u007F\u009D((object) this.\u0001);
      }
    }

    public override long Length
    {
      [DebuggerStepThrough] get
      {
        if (this.\u0002 == -1L)
          return \u001F\u001E.\u007E\u0080\u009D((object) this.\u0001) - this.\u0001;
        return this.\u0002 - this.\u0001;
      }
    }

    public override long Position
    {
      [DebuggerStepThrough] get
      {
        return \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001) - this.\u0001;
      }
      [DebuggerStepThrough] set
      {
        \u0012\u0080.\u007E\u0082\u009D((object) this.\u0001, value + this.\u0001);
      }
    }

    static \u0010()
    {
      \u0004.\u001D\u0005(typeof (\u0010));
    }

    [DebuggerStepThrough]
    public \u0010(Stream baseStream)
      : this(baseStream, 0L)
    {
    }

    [DebuggerStepThrough]
    public \u0010(Stream baseStream, long startingPos)
      : this(baseStream, startingPos, -1L)
    {
    }

    [DebuggerStepThrough]
    public \u0010(Stream baseStream, long startingPos, long endPosition)
    {
      if (baseStream == null)
        throw new ArgumentNullException(\u0010.\u0001(97478));
      this.\u0002 = endPosition;
      this.\u0001 = startingPos;
      this.\u0001 = baseStream;
    }

    [DebuggerStepThrough]
    public override void Flush()
    {
      \u001A\u001E.\u007E\u0088\u009D((object) this.\u0001);
    }

    [DebuggerStepThrough]
    public override int Read(byte[] buffer, int offset, int count)
    {
      if (this.\u0002 != -1L && this.\u0002 < \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001) + (long) count)
        goto label_2;
label_1:
      return \u0080\u0081.\u007E\u008D\u009D((object) this.\u0001, buffer, offset, count);
label_2:
      count = (int) (this.\u0002 - \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001));
      goto label_1;
    }

    public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
    {
      if (this.\u0002 != -1L && this.\u0002 < \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001) + (long) count)
        goto label_2;
label_1:
      return \u0093\u001D.\u007E\u0089\u009D((object) this.\u0001, buffer, offset, count, callback, state);
label_2:
      count = (int) (this.\u0002 - \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001));
      goto label_1;
    }

    public override int EndRead(IAsyncResult asyncResult)
    {
      return \u0088\u0080.\u007E\u008A\u009D((object) this.\u0001, asyncResult);
    }

    [DebuggerStepThrough]
    public override long Seek(long offset, SeekOrigin origin)
    {
      switch (origin)
      {
        case SeekOrigin.Begin:
          if (offset < this.\u0001)
            return \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, this.\u0001, SeekOrigin.Begin);
          if (this.\u0002 != -1L && offset + this.\u0001 > this.\u0002)
            return \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, this.\u0002, SeekOrigin.Begin);
          return \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, offset + this.\u0001, SeekOrigin.Begin);
        case SeekOrigin.Current:
          if (\u001F\u001E.\u007E\u0081\u009D((object) this.\u0001) + offset < this.\u0001)
            return \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, this.\u0001, SeekOrigin.Begin);
          if (this.\u0002 != -1L && this.\u0002 < \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001) + offset)
            return \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, this.\u0002, SeekOrigin.Begin);
          return \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, offset, SeekOrigin.Current);
        case SeekOrigin.End:
          if (\u001F\u001E.\u007E\u0080\u009D((object) this.\u0001) + offset < this.\u0001)
            return \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, this.\u0001, SeekOrigin.Begin);
          if (this.\u0002 != -1L && \u001F\u001E.\u007E\u0080\u009D((object) this.\u0001) + offset > this.\u0002)
            return \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, this.\u0002, SeekOrigin.Begin);
          return \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, offset, SeekOrigin.End);
        default:
          throw new NotSupportedException(\u0010.\u0001(97495));
      }
    }

    [DebuggerStepThrough]
    public override void SetLength(long value)
    {
      if (this.\u0002 != -1L)
        throw new NotSupportedException(\u0010.\u0001(97552));
      \u0012\u0080.\u007E\u008C\u009D((object) this.\u0001, value + this.\u0001);
    }

    [DebuggerStepThrough]
    public override void Write(byte[] buffer, int offset, int count)
    {
      \u0016\u0086.\u007E\u008F\u009D((object) this.\u0001, buffer, offset, count);
    }

    [DebuggerStepThrough]
    public override void WriteByte(byte value)
    {
      \u0095\u001F.\u007E\u0090\u009D((object) this.\u0001, value);
    }
  }
}
