// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001B;
using \u001D;
using \u0080;
using \u0081;
using System.Collections.Generic;
using System.IO;

namespace \u001D
{
  internal sealed class \u0001 : \u0014.\u0080
  {
    private int \u0001;

    protected override int? Version
    {
      get
      {
        return new int?(3);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 3;
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
        return new byte[3]{ (byte) 68, (byte) 67, (byte) 83 };
      }
    }

    public bool SpoofedToonTownEnabled { get; set; }

    public \u001A NewsType { get; set; }

    public List<\u001F.\u0081> ContentPacks { get; private set; }

    public List<\u0003> ToonTownAccounts { get; private set; }

    public \u0019 ActualToonTownVersionData { get; private set; }

    public \u0019 SpoofedToonTownVersionData { get; private set; }

    public \u0019 ActualTestToonTownVersionData { get; set; }

    public \u001A PatchServer { get; private set; }

    public int PatchServerPort
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (this.\u0001 == value)
          return;
        if (this.PatchServer != null)
          goto label_7;
label_4:
        this.\u0001 = value;
        this.PatchServer = new \u001A(this.\u0001, this.SpoofedToonTownVersionData);
        if (!this.SpoofedToonTownEnabled)
          return;
        this.PatchServer.\u0081\u0005();
        return;
label_7:
        if (this.PatchServer.Running)
          goto label_8;
label_3:
        this.PatchServer.Dispose();
        goto label_4;
label_8:
        this.PatchServer.\u0082\u0005();
        goto label_3;
      }
    }

    public \u0001 SelectedServer { get; set; }

    public int MaximumSimultaneousDownloads { get; set; }

    public \u0001()
    {
      this.ActualToonTownVersionData = new \u0019();
      this.ActualTestToonTownVersionData = new \u0019();
      this.SpoofedToonTownVersionData = new \u0019();
      this.SpoofedToonTownEnabled = false;
      this.ToonTownAccounts = new List<\u0003>();
      this.ContentPacks = new List<\u001F.\u0081>();
      this.NewsType = \u001A.\u0001;
      this.PatchServerPort = 3000;
      this.SelectedServer = \u0001.\u0002;
      this.MaximumSimultaneousDownloads = 3;
    }

    public \u0001(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.ToonTownAccounts = new List<\u0003>();
      this.ContentPacks = new List<\u001F.\u0081>();
      this.ActualToonTownVersionData = \u0002.\u001D\u0005(reader);
      this.SpoofedToonTownVersionData = \u0002.\u001D\u0005(reader);
      this.ActualTestToonTownVersionData = \u0002.\u001D\u0005(reader);
      this.SpoofedToonTownEnabled = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      int num1 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index = 0; index < num1; ++index)
        this.ToonTownAccounts.Add(new \u0003(reader));
      int num2 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index = 0; index < num2; ++index)
        this.ContentPacks.Add(new \u001F.\u0081(reader));
      this.NewsType = (\u001A) \u0011\u001C.\u007E\u0097\u009D((object) reader);
      this.PatchServerPort = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      this.SelectedServer = version <= 1 ? \u0001.\u0002 : (\u0001) \u0001\u0081.\u007E\u0096\u009D((object) reader);
      if (version > 2)
        this.MaximumSimultaneousDownloads = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      else
        this.MaximumSimultaneousDownloads = 3;
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      writer.\u001D\u0005(this.ActualToonTownVersionData);
      writer.\u001D\u0005(this.SpoofedToonTownVersionData);
      writer.\u001D\u0005(this.ActualTestToonTownVersionData);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.SpoofedToonTownEnabled);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.ToonTownAccounts.Count);
      foreach (\u0014.\u0080 toonTownAccount in this.ToonTownAccounts)
        toonTownAccount.\u001E\u0005(writer);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.ContentPacks.Count);
      foreach (\u0014.\u0080 contentPack in this.ContentPacks)
        contentPack.\u001E\u0005(writer);
      \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.NewsType);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.PatchServerPort);
      \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) this.SelectedServer);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.MaximumSimultaneousDownloads);
    }
  }
}
