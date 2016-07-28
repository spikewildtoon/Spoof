// Decompiled with JetBrains decompiler
// Type: TheToonTownSpoofer.IO.Compression.BZip2.SharpZipBaseException
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Runtime.Serialization;

namespace TheToonTownSpoofer.IO.Compression.BZip2
{
  [Serializable]
  public class SharpZipBaseException : ApplicationException
  {
    protected SharpZipBaseException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public SharpZipBaseException()
    {
    }

    public SharpZipBaseException(string message)
      : base(message)
    {
    }

    public SharpZipBaseException(string message, Exception innerException)
      : base(message, innerException)
    {
    }
  }
}
