// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u007F;
using \u0080;
using System;
using System.Collections.Generic;
using System.IO;

namespace \u007F
{
  internal sealed class \u0004 : \u0014.\u0080, IDisposable
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;

    protected override int? Version
    {
      get
      {
        return new int?(2);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 2;
      }
    }

    protected override int MinimumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override byte[] Header
    {
      get
      {
        return new byte[4]{ (byte) 74, (byte) 70, (byte) 68, (byte) 83 };
      }
    }

    public List<\u0003> Docks { get; private set; }

    static \u0004()
    {
      \u0004.\u001D\u0005(typeof (\u0004));
      \u0004.\u0001 = \u0004.\u0001(75323);
      \u0004.\u0002 = \u0004.\u0001(75565);
    }

    public \u0004()
    {
      this.Docks = new List<\u0003>();
    }

    public \u0004(string filePath)
      : base(filePath)
    {
    }

    ~\u0004()
    {
      try
      {
        this.\u001D\u0005(false);
      }
      finally
      {
        \u001A\u001E.\u008C\u0091((object) this);
      }
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.Docks = new List<\u0003>();
      int num = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      if (version > 1)
      {
        for (int index = 0; index < num; ++index)
        {
          \u0003 obj = new \u0003(reader);
          if (obj.PondCapture != null)
            this.Docks.Add(obj);
          else
            obj.Dispose();
        }
      }
      else
      {
        for (int index = 0; index < num; ++index)
          new \u0003(reader).Dispose();
        \u0017.\u001D\u0005(\u0004.\u0001, \u009E\u0081.\u001F\u0093(\u0004.\u0002, (object) num));
      }
      base.\u001D\u0005(reader, version);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.Docks.Count);
      foreach (\u0003 dock in this.Docks)
      {
        if (dock.PondCapture != null)
          dock.\u001E\u0005(writer);
      }
      base.\u001D\u0005(writer);
    }

    private void \u001D\u0005(bool disposing)
    {
      if (!disposing)
        return;
      foreach (\u0003 dock in this.Docks)
        dock.Dispose();
      this.Docks.Clear();
    }

    public void Dispose()
    {
      this.\u001D\u0005(true);
    }
  }
}
