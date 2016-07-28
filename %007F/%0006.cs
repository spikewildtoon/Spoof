// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u001E;
using \u007F;
using \u0081;
using \u0084;
using System;
using System.Collections.Generic;
using System.IO;

namespace \u007F
{
  internal sealed class \u0006 : \u0005
  {
    public new static readonly int \u0001 = 25;
    public new static readonly int \u0002 = 10;

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
        return new byte[3]{ (byte) 71, (byte) 70, (byte) 83 };
      }
    }

    public \u001C GardenerFloraFiles { get; private set; }

    public \u001C GardenerFloraCaptureFiles { get; private set; }

    public string CustomCaptureFile { get; set; }

    public string CustomWayPointSettings { get; set; }

    public \u0006()
    {
      this.GardenerFloraFiles = new \u001C();
      this.GardenerFloraCaptureFiles = new \u001C();
      this.MaxColorRange = \u0006.\u0001;
    }

    public \u0006(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.GardenerFloraFiles = new \u001C(reader);
      this.GardenerFloraCaptureFiles = new \u001C(reader);
      if (\u0099\u0082.\u007E\u0095\u009D((object) reader))
        this.CustomCaptureFile = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      if (\u0099\u0082.\u007E\u0095\u009D((object) reader))
        this.CustomWayPointSettings = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      base.\u001D\u0005(reader, version);
      if (version != 1)
        return;
      if (this.MaxColorRange == \u0006.\u0002)
        this.MaxColorRange = \u0006.\u0001;
      foreach (\u001B obj in this.GardenerFloraFiles.Files.ToArray())
      {
        bool flag = false;
        try
        {
          Stream input = (Stream) \u008F\u001C.\u0093\u009E(obj.\u0002, FileMode.Open, FileAccess.Read, FileShare.None);
          try
          {
            BinaryReader binaryReader = new BinaryReader(input);
            try
            {
              flag = ((IEnumerable<byte>) \u0004\u0086.\u007E\u0003\u009E((object) binaryReader, \u0082.\u0001.Length)).\u001D\u0005<byte>((IEnumerable<byte>) \u0082.\u0001);
            }
            finally
            {
              if (binaryReader != null)
                \u001A\u001E.\u007E\u0094\u0092((object) binaryReader);
            }
          }
          finally
          {
            if (input != null)
              \u001A\u001E.\u007E\u0094\u0092((object) input);
          }
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005((object) obj.\u0002);
          flag = true;
        }
        if (flag)
        {
          try
          {
            \u009C\u001F.\u0091\u009E(obj.\u0002);
            this.GardenerFloraFiles.Files.Remove(obj);
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005((object) obj.\u0002);
          }
        }
      }
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      this.GardenerFloraFiles.\u001E\u0005(writer);
      this.GardenerFloraCaptureFiles.\u001E\u0005(writer);
      if (\u008F\u0084.\u009E\u0092(this.CustomCaptureFile))
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, false);
      }
      else
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, true);
        \u0092\u0081.\u007E\u001A\u009E((object) writer, this.CustomCaptureFile);
      }
      if (\u008F\u0084.\u009E\u0092(this.CustomWayPointSettings))
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, false);
      }
      else
      {
        \u0099\u001F.\u007E\u000E\u009E((object) writer, true);
        \u0092\u0081.\u007E\u001A\u009E((object) writer, this.CustomWayPointSettings);
      }
      base.\u001D\u0005(writer);
    }
  }
}
