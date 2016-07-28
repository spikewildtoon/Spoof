// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0081;
using \u0082;
using System;
using System.Collections.Generic;
using System.IO;
using TSN.IO;

namespace \u0014
{
  internal abstract class \u0080
  {
    protected virtual byte[] Header
    {
      get
      {
        return (byte[]) null;
      }
    }

    protected virtual int? Version
    {
      get
      {
        return new int?();
      }
    }

    protected virtual int MinimumVersion
    {
      get
      {
        throw new NotImplementedException();
      }
    }

    protected virtual int MaximumVersion
    {
      get
      {
        throw new NotImplementedException();
      }
    }

    public \u0080()
    {
    }

    public \u0080(BinaryReader reader)
    {
      this.\u001E\u0005(reader);
    }

    public \u0080(Stream stream)
    {
      \u0010 obj = new \u0010(stream);
      try
      {
        BinaryReader reader = new BinaryReader((Stream) obj);
        try
        {
          this.\u001E\u0005(reader);
        }
        finally
        {
          if (reader != null)
            \u001A\u001E.\u007E\u0094\u0092((object) reader);
        }
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
    }

    public \u0080(string fileName)
    {
      Stream input = (Stream) \u008F\u001C.\u0093\u009E(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
      try
      {
        BinaryReader reader = new BinaryReader(input);
        try
        {
          this.\u001E\u0005(reader);
        }
        finally
        {
          if (reader != null)
            \u001A\u001E.\u007E\u0094\u0092((object) reader);
        }
      }
      finally
      {
        if (input != null)
          \u001A\u001E.\u007E\u0094\u0092((object) input);
      }
    }

    private void \u001E\u0005(BinaryReader reader)
    {
      byte[] header = this.Header;
      if (header != null && header != null)
      {
        byte[] actualHeader = \u0004\u0086.\u007E\u0003\u009E((object) reader, header.Length);
        if (!((IEnumerable<byte>) actualHeader).\u001D\u0005<byte>((IEnumerable<byte>) header))
          throw new InvalidFileType(header, actualHeader);
      }
      if (this.Version.HasValue)
      {
        int num = \u0005\u0081.\u007E\u0099\u009D((object) reader);
        if (num < this.MinimumVersion || num > this.MaximumVersion)
          throw new InvalidFileVersion<int>(this.MinimumVersion, this.MaximumVersion, num);
        this.\u001D\u0005(reader, num);
      }
      else
        this.\u001D\u0005(reader);
    }

    public void \u001D\u0005(string fileName)
    {
      Stream output = (Stream) \u008F\u001C.\u0093\u009E(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
      try
      {
        BinaryWriter writer = new BinaryWriter(output);
        try
        {
          this.\u001E\u0005(writer);
        }
        finally
        {
          if (writer != null)
            \u001A\u001E.\u007E\u0094\u0092((object) writer);
        }
      }
      finally
      {
        if (output != null)
          \u001A\u001E.\u007E\u0094\u0092((object) output);
      }
    }

    public void \u001D\u0005(Stream stream)
    {
      \u0010 obj = new \u0010(stream);
      try
      {
        BinaryWriter writer = new BinaryWriter((Stream) obj);
        try
        {
          this.\u001E\u0005(writer);
        }
        finally
        {
          if (writer != null)
            \u001A\u001E.\u007E\u0094\u0092((object) writer);
        }
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
    }

    public void \u001E\u0005(BinaryWriter writer)
    {
      byte[] header = this.Header;
      if (header != null && header != null)
        \u0015\u001C.\u007E\u0010\u009E((object) writer, header);
      int? version = this.Version;
      if (version.HasValue)
        \u0011\u001F.\u007E\u0015\u009E((object) writer, version.Value);
      this.\u001D\u0005(writer);
    }

    protected virtual void \u001D\u0005(BinaryWriter writer)
    {
    }

    protected virtual void \u001D\u0005(BinaryReader reader)
    {
    }

    protected virtual void \u001D\u0005(BinaryReader reader, int version)
    {
    }
  }
}
