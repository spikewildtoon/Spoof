// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0016;
using \u0018;
using \u0019;
using \u007F;
using \u0081;
using \u0082;
using System;
using System.Diagnostics;
using System.IO;

namespace \u0081
{
  internal sealed class \u0080 : \u0080
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly Lazy<\u0080> \u0001;
    private static readonly object \u0001;

    public static \u0080 Instance
    {
      [DebuggerStepThrough] get
      {
        return \u0080.\u0001.Value;
      }
    }

    protected override int? Version
    {
      get
      {
        return new int?(1);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 1;
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
        return new byte[3]{ (byte) 77, (byte) 83, (byte) 70 };
      }
    }

    public \u0084.\u001C RaceTrackFileIndex { get; private set; }

    public \u0010 GagAMaticSettings { get; private set; }

    public \u001D.\u0082 MakePackageSettings { get; private set; }

    public \u001C.\u0081 RemoteControllerSettings { get; private set; }

    public \u001D.\u0001 ConnectSettings { get; private set; }

    public \u0081.\u0081 JoeFishSettings { get; private set; }

    public \u0006 GardenerFloraSettings { get; private set; }

    public \u0082.\u0018 ApplicationSettings { get; private set; }

    public \u0003 MyGallerySettings { get; private set; }

    public \u0084.\u001C CreatedFileArchive { get; private set; }

    static \u0080()
    {
      \u0004.\u001D\u0005(typeof (\u0080));
      \u0080.\u0001 = \u0080.\u0001(97223);
      \u0080.\u0001 = new Lazy<\u0080>(new Func<\u0080>(\u0080.\u001E\u0005));
      \u0080.\u0001 = new object();
    }

    private \u0080()
    {
      this.ConnectSettings = new \u001D.\u0001();
      this.MakePackageSettings = new \u001D.\u0082();
      this.GagAMaticSettings = new \u0010();
      this.RemoteControllerSettings = new \u001C.\u0081();
      this.RaceTrackFileIndex = new \u0084.\u001C();
      this.JoeFishSettings = new \u0081.\u0081();
      this.GardenerFloraSettings = new \u0006();
      this.ApplicationSettings = new \u0082.\u0018();
      this.MyGallerySettings = new \u0003();
      this.CreatedFileArchive = new \u0084.\u001C();
    }

    private \u0080(Stream stream)
      : base(stream)
    {
    }

    private static \u0080 \u001E\u0005()
    {
      if (\u008F\u0084.\u0092\u009E(\u001A.\u007F.\u0015))
      {
        try
        {
          Stream source = (Stream) \u008F\u001C.\u0093\u009E(\u001A.\u007F.\u0015, FileMode.Open, FileAccess.Read, FileShare.None);
          try
          {
            MemoryStream memoryStream = new MemoryStream();
            try
            {
              \u0017.\u001E\u0005(\u0080.\u0001, source, (Stream) memoryStream);
              \u0012\u0080.\u007E\u0082\u009D((object) memoryStream, 0L);
              return new \u0080((Stream) memoryStream);
            }
            finally
            {
              if (memoryStream != null)
                \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
            }
          }
          finally
          {
            if (source != null)
              \u001A\u001E.\u007E\u0094\u0092((object) source);
          }
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005((object) \u001A.\u007F.\u0015);
          \u0017.\u001D\u0005(ex, \u001A.\u007F.\u0015);
        }
      }
      return new \u0080();
    }

    public static bool \u001D\u0005()
    {
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0080.\u0001, ref flag);
        try
        {
          \u0081\u0086 obj2 = \u0081\u0086.\u0011\u009F;
          string applicationDataDirectory = \u001A.\u007F.CommonApplicationDataDirectory;
          Guid guid = \u009E\u0080.\u000F\u0096();
          string str = \u0081\u0086.\u0086\u0093(guid.ToString(), \u0080.\u0001(56801));
          string source_file = obj2(applicationDataDirectory, str);
          MemoryStream memoryStream = new MemoryStream();
          try
          {
            \u0080.Instance.\u001D\u0005((Stream) memoryStream);
            \u0012\u0080.\u007E\u0082\u009D((object) memoryStream, 0L);
            Stream destination = (Stream) \u008F\u001C.\u0093\u009E(source_file, FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
              \u0017.\u001D\u0005(\u0080.\u0001, (Stream) memoryStream, destination);
            }
            finally
            {
              if (destination != null)
                \u001A\u001E.\u007E\u0094\u0092((object) destination);
            }
          }
          finally
          {
            if (memoryStream != null)
              \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
          }
          \u0012.\u001D\u0005(source_file, \u001A.\u007F.\u0015, true);
          return true;
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005((object) \u001A.\u007F.\u0015);
          \u0017.\u001D\u0005(ex, \u001A.\u007F.\u0015);
          return false;
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.ApplicationSettings = new \u0082.\u0018(reader);
      this.ConnectSettings = new \u001D.\u0001(reader);
      this.MakePackageSettings = new \u001D.\u0082(reader);
      this.GagAMaticSettings = new \u0010(reader);
      this.RemoteControllerSettings = new \u001C.\u0081(reader);
      this.RaceTrackFileIndex = new \u0084.\u001C(reader);
      this.JoeFishSettings = new \u0081.\u0081(reader);
      this.GardenerFloraSettings = new \u0006(reader);
      this.CreatedFileArchive = new \u0084.\u001C(reader);
      this.MyGallerySettings = new \u0003(reader);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      this.ApplicationSettings.\u001E\u0005(writer);
      this.ConnectSettings.\u001E\u0005(writer);
      this.MakePackageSettings.\u001E\u0005(writer);
      this.GagAMaticSettings.\u001E\u0005(writer);
      this.RemoteControllerSettings.\u001E\u0005(writer);
      this.RaceTrackFileIndex.\u001E\u0005(writer);
      this.JoeFishSettings.\u001E\u0005(writer);
      this.GardenerFloraSettings.\u001E\u0005(writer);
      this.CreatedFileArchive.\u001E\u0005(writer);
      this.MyGallerySettings.\u001E\u0005(writer);
    }
  }
}
