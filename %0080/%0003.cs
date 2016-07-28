// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u001A;
using \u001B;
using \u001D;
using \u0083;
using \u0084;
using System;
using System.Drawing;
using System.IO;

namespace \u0080
{
  internal sealed class \u0003 : \u0080, IDisposable
  {
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

    public \u0005<\u0002> PondCapture { get; set; }

    public Size WindowClientSize { get; private set; }

    public PointF DockLocation { get; private set; }

    public \u0019 Playground { get; private set; }

    public \u0018 DockReferenceCapture { get; private set; }

    public \u0003(\u0019 playground, PointF dockLocation, Size windowClientSize, \u0005<\u0002> pondCapture, \u0018 dockReferenceCapture)
    {
      this.Playground = playground;
      this.DockLocation = dockLocation;
      this.WindowClientSize = windowClientSize;
      this.PondCapture = pondCapture;
      this.DockReferenceCapture = dockReferenceCapture;
    }

    public \u0003(BinaryReader reader)
      : base(reader)
    {
    }

    ~\u0003()
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
      this.DockLocation = reader.\u001D\u0005();
      this.Playground = (\u0019) \u0095\u0084.\u007E\u0098\u009D((object) reader);
      this.WindowClientSize = reader.\u001D\u0005();
      this.PondCapture = reader.\u001D\u0005();
      if (version > 1)
        this.DockReferenceCapture = reader.\u001D\u0005();
      base.\u001D\u0005(reader, version);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      writer.\u001D\u0005(this.DockLocation);
      \u0087\u0083.\u007E\u0014\u009E((object) writer, (ushort) this.Playground);
      writer.\u001D\u0005(this.WindowClientSize);
      writer.\u001D\u0005(this.PondCapture);
      writer.\u001D\u0005(this.DockReferenceCapture);
      base.\u001D\u0005(writer);
    }

    private void \u001D\u0005(bool disposing)
    {
      if (!disposing || this.DockReferenceCapture == null)
        return;
      this.DockReferenceCapture.Dispose();
    }

    public void Dispose()
    {
      this.\u001D\u0005(true);
    }
  }
}
