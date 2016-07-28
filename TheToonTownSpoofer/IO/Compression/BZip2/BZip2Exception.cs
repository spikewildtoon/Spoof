// Decompiled with JetBrains decompiler
// Type: TheToonTownSpoofer.IO.Compression.BZip2.BZip2Exception
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Runtime.Serialization;

namespace TheToonTownSpoofer.IO.Compression.BZip2
{
  [Serializable]
  public sealed class BZip2Exception : SharpZipBaseException
  {
    protected BZip2Exception(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public BZip2Exception()
    {
    }

    public BZip2Exception(string message)
      : base(message)
    {
    }

    public BZip2Exception(string message, Exception exception)
      : base(message, exception)
    {
    }
  }
}
