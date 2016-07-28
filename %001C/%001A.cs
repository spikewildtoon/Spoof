// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u001D;
using \u001E;
using \u0081;
using \u0082;
using \u0083;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using TheToonTownSpoofer.IO.Archive;
using TSN.IO;

namespace \u001C
{
  internal sealed class \u001A : \u0015.\u0016
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly int \u0001;
    private static byte[] \u0001;
    public static byte[] \u0002;
    private static \u0080.\u0016 \u0001;
    private MemoryStream \u0001;

    public \u001E.\u0081 Type { get; private set; }

    public Guid ID { get; private set; }

    public \u0080.\u0016 DataHash { get; private set; }

    public Uri UpdateUri { get; set; }

    public string Name { get; set; }

    public string Author { get; set; }

    public string Description { get; set; }

    public Version Version { get; set; }

    public string Password { get; set; }

    public bool LoaderPack { get; set; }

    public Bitmap Icon { get; private set; }

    public Version MinimumVersion { get; set; }

    public \u007F Data { get; private set; }

    public \u0080.\u0016 PasswordHash { get; set; }

    public Dictionary<string, \u0080.\u0016> ItemIndex { get; private set; }

    public Uri ObsoleteDownloadURL { get; private set; }

    static \u001A()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u001C.\u001A)));
      \u001C.\u001A.\u0001 = 2;
      \u001C.\u001A.\u0001 = new byte[3]
      {
        (byte) 67,
        (byte) 80,
        (byte) 67
      };
      \u001C.\u001A.\u0002 = new byte[3]
      {
        (byte) 84,
        (byte) 84,
        (byte) 80
      };
      \u001C.\u001A.\u0001 = new \u0080.\u0016(\u001C.\u001A.\u0001(60807));
    }

    public \u001A()
    {
      this.ItemIndex = new Dictionary<string, \u0080.\u0016>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      this.ID = \u009E\u0080.\u000F\u0096();
      this.Data = new \u007F();
      this.UpdateUri = (Uri) null;
      this.Name = string.Empty;
      this.Author = string.Empty;
      this.Description = string.Empty;
      this.Password = string.Empty;
      this.LoaderPack = false;
      this.MinimumVersion = \u0008.Current.AssemblyVersion;
      this.PasswordHash = \u0080.\u0016.\u0001;
      this.Version = new Version(1, 0, 0, 0);
      this.DataHash = \u0080.\u0016.\u0001;
      this.Type = \u001E.\u0081.\u0002;
      this.ObsoleteDownloadURL = (Uri) null;
    }

    public \u001A(string filename, bool loadIcon, bool populateData)
    {
      this.ItemIndex = new Dictionary<string, \u0080.\u0016>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      Stream stream = (Stream) \u008F\u001C.\u0093\u009E(filename, FileMode.Open, FileAccess.Read, FileShare.None);
      try
      {
        BinaryReader reader = new BinaryReader(stream);
        try
        {
          byte[] actualHeader = \u0004\u0086.\u007E\u0003\u009E((object) reader, \u001C.\u001A.\u0001.Length);
          if (((IEnumerable<byte>) actualHeader).\u001D\u0005<byte>((IEnumerable<byte>) \u001C.\u001A.\u0001))
          {
            int actualVersion = \u0005\u0081.\u007E\u0099\u009D((object) reader);
            if (actualVersion < 2 || actualVersion > \u001C.\u001A.\u0001)
              throw new InvalidFileVersion<int>(2, \u001C.\u001A.\u0001, actualVersion);
            this.ObsoleteDownloadURL = (Uri) null;
            this.Type = \u001E.\u0081.\u0002;
            this.\u001D\u0005(stream, reader, loadIcon, populateData);
          }
          else
          {
            if (!((IEnumerable<byte>) actualHeader).\u001D\u0005<byte>((IEnumerable<byte>) \u001C.\u001A.\u0002))
              throw new InvalidFileType(\u001C.\u001A.\u0001, actualHeader);
            this.Type = \u001E.\u0081.\u0001;
            this.Version = new Version(0, 0, 0, 0);
            this.\u001E\u0005(stream, reader, loadIcon, populateData);
          }
        }
        finally
        {
          if (reader != null)
            \u001A\u001E.\u007E\u0094\u0092((object) reader);
        }
      }
      finally
      {
        if (stream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) stream);
      }
    }

    internal void \u001E\u0005(Guid id)
    {
      this.ID = id;
    }

    public void \u001D\u0005(Stream str)
    {
      if (this.Icon != null)
      {
        \u001A\u001E.\u007E\u001D\u001F((object) this.Icon);
        this.Icon = (Bitmap) null;
      }
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
        this.\u0001 = (MemoryStream) null;
      }
      if (str == null)
        return;
      this.\u0001 = new MemoryStream();
      \u0091\u0080.\u007E\u0083\u009D((object) str, (Stream) this.\u0001);
      \u0012\u0080.\u007E\u0082\u009D((object) this.\u0001, 0L);
      this.Icon = (Bitmap) \u0099\u001C.\u001C\u001F((Stream) this.\u0001);
    }

    protected override void \u001D\u0005()
    {
      if (this.Icon != null)
        \u001A\u001E.\u007E\u001D\u001F((object) this.Icon);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
      if (this.Data != null)
        this.Data.Dispose();
      this.ItemIndex.Clear();
      base.\u001D\u0005();
    }

    public static bool \u001D\u0005(Stream file_stream, out byte[] header, out int version)
    {
      long num1 = \u001F\u001E.\u007E\u0081\u009D((object) file_stream);
      header = new byte[\u001C.\u001A.\u0001.Length];
      int num2 = \u0080\u0081.\u007E\u008D\u009D((object) file_stream, header, 0, \u001C.\u001A.\u0001.Length);
      byte[] numArray = new byte[4];
      int num3 = \u0080\u0081.\u007E\u008D\u009D((object) file_stream, numArray, 0, 4);
      version = \u0014\u001E.\u0001\u0095(numArray, 0);
      \u0012\u0080.\u007E\u0082\u009D((object) file_stream, num1);
      if (((IEnumerable<byte>) header).\u001D\u0005<byte>((IEnumerable<byte>) \u001C.\u001A.\u0001))
        return version == \u001C.\u001A.\u0001;
      return false;
    }

    public static bool \u001D\u0005(Stream file_stream1, Stream file_stream2)
    {
      byte[] header1;
      int version1;
      byte[] header2;
      int version2;
      if (!\u001C.\u001A.\u001D\u0005(file_stream1, out header1, out version1) || !\u001C.\u001A.\u001D\u0005(file_stream2, out header2, out version2) || !((IEnumerable<byte>) header1).\u001D\u0005<byte>((IEnumerable<byte>) header2))
        return false;
      return version1 == version2;
    }

    public static void \u001D\u0005(\u001C.\u0016 pd, BinaryWriter write_stream, uint offset_orig, uint offset_new, Stream stream_orig, Stream stream_new)
    {
      \u0010 obj1 = new \u0010(stream_orig);
      try
      {
        \u0010 obj2 = new \u0010(stream_new);
        try
        {
          uint index1;
          uint data_length1;
          \u001C.\u001A.\u001D\u0005((Stream) obj1, out index1, out data_length1);
          uint index2;
          uint data_length2;
          \u001C.\u001A.\u001D\u0005((Stream) obj2, out index2, out data_length2);
          \u0010 obj3 = new \u0010((Stream) obj1, 0L, (long) index1);
          try
          {
            \u0010 obj4 = new \u0010((Stream) obj2, 0L, (long) index2);
            try
            {
              \u001A.\u0080.\u001D\u0005(pd, \u001E.\u0080.\u0001, write_stream, offset_orig, offset_new, (Stream) obj3, (Stream) obj4);
            }
            finally
            {
              if (obj4 != null)
                \u001A\u001E.\u007E\u0094\u0092((object) obj4);
            }
          }
          finally
          {
            if (obj3 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj3);
          }
          \u0010 obj5 = new \u0010((Stream) obj1, (long) index1, (long) (index1 + data_length1));
          try
          {
            \u0010 obj4 = new \u0010((Stream) obj2, (long) index2, (long) (index2 + data_length2));
            try
            {
              \u007F.\u001D\u0005(pd, write_stream, offset_orig + index1, offset_new + index2, (Stream) obj5, (Stream) obj4);
            }
            finally
            {
              if (obj4 != null)
                \u001A\u001E.\u007E\u0094\u0092((object) obj4);
            }
          }
          finally
          {
            if (obj5 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj5);
          }
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    private static void \u001D\u0005(Stream stream, out uint index, out uint data_length)
    {
      \u0010 obj1 = new \u0010(stream);
      try
      {
        BinaryReader reader = new BinaryReader((Stream) obj1);
        try
        {
          byte[] numArray = \u0004\u0086.\u007E\u0003\u009E((object) reader, \u001C.\u001A.\u0001.Length);
          int num1 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
          reader.\u001D\u0005();
          if (\u0080.\u0016.\u001D\u0005(reader.\u001D\u0005(), \u0080.\u0016.\u0001))
            throw new LoaderPackNotSupported();
          if (\u0099\u0082.\u007E\u0095\u009D((object) reader))
          {
            string str1 = \u0002\u007F.\u007E\u0001\u009E((object) reader);
          }
          string str2 = \u0002\u007F.\u007E\u0001\u009E((object) reader);
          string str3 = \u0002\u007F.\u007E\u0001\u009E((object) reader);
          string str4 = \u0002\u007F.\u007E\u0001\u009E((object) reader);
          reader.\u001D\u0005();
          reader.\u001D\u0005();
          reader.\u001D\u0005();
          int num2 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
          \u0012\u0080 obj2 = \u0012\u0080.\u007E\u0082\u009D;
          Stream stream1 = stream;
          long num3 = stream1.Position + (long) num2;
          obj2((object) stream1, num3);
          int num4 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
          for (int index1 = 0; index1 < num4; ++index1)
          {
            string str5 = \u0002\u007F.\u007E\u0001\u009E((object) reader);
            reader.\u001D\u0005();
          }
          data_length = (uint) \u0005\u0081.\u007E\u0099\u009D((object) reader);
          index = (uint) \u001F\u001E.\u007E\u0081\u009D((object) stream);
        }
        finally
        {
          if (reader != null)
            \u001A\u001E.\u007E\u0094\u0092((object) reader);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    private void \u001D\u0005(Stream file_stream, BinaryReader reader, bool loadIcon, bool populateData)
    {
      this.ID = reader.\u001D\u0005();
      this.DataHash = reader.\u001D\u0005();
      this.LoaderPack = \u0080.\u0016.\u001D\u0005(this.DataHash, \u0080.\u0016.\u0001);
      this.UpdateUri = reader.\u001D\u0005();
      this.Name = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      this.Author = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      this.Description = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      this.Version = reader.\u001D\u0005();
      this.MinimumVersion = reader.\u001D\u0005();
      this.PasswordHash = reader.\u001D\u0005();
      int num1 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      if (num1 > 0)
      {
        if (loadIcon)
        {
          \u0010 obj = new \u0010(file_stream, \u001F\u001E.\u007E\u0081\u009D((object) file_stream), (long) num1 + \u001F\u001E.\u007E\u0081\u009D((object) file_stream));
          try
          {
            this.\u0001 = new MemoryStream();
            \u0091\u0080.\u007E\u0083\u009D((object) obj, (Stream) this.\u0001);
            this.Icon = (Bitmap) \u0099\u001C.\u001C\u001F((Stream) this.\u0001);
          }
          finally
          {
            if (obj != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj);
          }
        }
        else
        {
          \u0012\u0080 obj = \u0012\u0080.\u007E\u0082\u009D;
          Stream stream = file_stream;
          long num2 = stream.Position + (long) num1;
          obj((object) stream, num2);
        }
      }
      if (this.LoaderPack)
      {
        if (!populateData)
          return;
        this.Data = new \u007F();
      }
      else
      {
        int num2 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
        for (int index = 0; index < num2; ++index)
          this.ItemIndex.Add(\u0002\u007F.\u007E\u0001\u009E((object) reader), reader.\u001D\u0005());
        int num3 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
        if (populateData)
        {
          \u0010 obj = new \u0010(file_stream, \u001F\u001E.\u007E\u0081\u009D((object) file_stream), (long) num3 + \u001F\u001E.\u007E\u0081\u009D((object) file_stream));
          try
          {
            this.Data = new \u007F((Stream) obj);
            this.Data.\u0084\u0005();
          }
          finally
          {
            if (obj != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj);
          }
        }
        else
        {
          \u0012\u0080 obj = \u0012\u0080.\u007E\u0082\u009D;
          Stream stream = file_stream;
          long num4 = stream.Position + (long) num3;
          obj((object) stream, num4);
        }
      }
    }

    private void \u001E\u0005(Stream file_stream, BinaryReader reader, bool loadIcon, bool populateData)
    {
      Encoding enc = \u0087\u001E.\u0015\u009C(1252);
      int actualVersion = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      if (actualVersion != 1)
        throw new InvalidFileVersion<int>(1, 1, actualVersion);
      Decimal num1 = \u008F\u007F.\u007E\u009F\u009D((object) reader);
      Decimal num2 = \u008F\u007F.\u007E\u009F\u009D((object) reader);
      int major = \u0093\u0081.\u0087\u0095(\u000E\u0084.\u0093\u0096(num1));
      this.MinimumVersion = new Version(major, \u0093\u0081.\u0087\u0095(\u000E\u0081.\u0089\u0095(\u000E\u0081.\u0088\u0095(num1, \u0084\u001C.\u0083\u0095(major)), new Decimal(100))), \u0093\u0081.\u0087\u0095(\u000E\u0081.\u0089\u0095(num2, new Decimal(100))), 0);
      this.Name = \u001C.\u001A.\u001D\u0005(reader, enc);
      this.Description = \u001C.\u001A.\u001D\u0005(reader, enc);
      this.Author = \u001C.\u001A.\u001D\u0005(reader, enc);
      this.PasswordHash = new \u0080.\u0016(\u001C.\u001A.\u001D\u0005(reader, enc));
      if (\u0080.\u0016.\u001D\u0005(this.PasswordHash, \u001C.\u001A.\u0001))
        this.PasswordHash = \u0080.\u0016.\u0001;
      \u001C.\u001A.\u001D\u0005(reader, enc);
      string uriString1 = \u001C.\u001A.\u001D\u0005(reader, enc);
      if (!\u008F\u0084.\u009E\u0092(uriString1))
        this.ObsoleteDownloadURL = new Uri(uriString1);
      string uriString2 = \u001C.\u001A.\u001D\u0005(reader, enc);
      if (!\u008F\u0084.\u009E\u0092(uriString2))
        this.UpdateUri = new Uri(uriString2);
      this.ID = new Guid(\u001C.\u001A.\u001D\u0005(reader, enc));
      this.DataHash = new \u0080.\u0016(\u001C.\u001A.\u001D\u0005(reader, enc));
      int num3 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      if (num3 > 0)
      {
        if (loadIcon)
        {
          \u0010 obj = new \u0010(file_stream, \u001F\u001E.\u007E\u0081\u009D((object) file_stream), \u001F\u001E.\u007E\u0081\u009D((object) file_stream) + (long) num3);
          try
          {
            this.\u0001 = new MemoryStream();
            \u0091\u0080.\u007E\u0083\u009D((object) obj, (Stream) this.\u0001);
            this.Icon = (Bitmap) \u0099\u001C.\u001C\u001F((Stream) this.\u0001);
          }
          finally
          {
            if (obj != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj);
          }
        }
        else
        {
          \u0012\u0080 obj = \u0012\u0080.\u007E\u0082\u009D;
          Stream stream = file_stream;
          long num4 = stream.Position + (long) num3;
          obj((object) stream, num4);
        }
      }
      this.LoaderPack = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      if (this.LoaderPack)
        this.DataHash = \u0080.\u0016.\u0001;
      if (this.LoaderPack)
      {
        if (!populateData)
          return;
        this.Data = new \u007F();
      }
      else
      {
        int num4 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
        for (int index = 0; index < num4; ++index)
          this.ItemIndex.Add(\u001C.\u001A.\u001D\u0005(reader, enc), new \u0080.\u0016(\u001C.\u001A.\u001D\u0005(reader, enc)));
        int num5 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
        if (populateData)
        {
          \u0010 obj = new \u0010(file_stream, \u001F\u001E.\u007E\u0081\u009D((object) file_stream), \u001F\u001E.\u007E\u0081\u009D((object) file_stream) + (long) num5);
          try
          {
            this.Data = new \u007F((Stream) obj);
            this.Data.\u0084\u0005();
          }
          finally
          {
            if (obj != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj);
          }
        }
        else
        {
          \u0012\u0080 obj = \u0012\u0080.\u007E\u0082\u009D;
          Stream stream = file_stream;
          long num6 = stream.Position + (long) num5;
          obj((object) stream, num6);
        }
      }
    }

    private static string \u001D\u0005(BinaryReader reader, Encoding enc)
    {
      int num = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      if (num > 0)
        return \u0099\u0084.\u007E\u0018\u009C((object) enc, \u0004\u0086.\u007E\u0003\u009E((object) reader, num));
      return string.Empty;
    }

    public void \u001D\u0005(string filename, \u0080.\u0016? passwordHash = null)
    {
      Stream stream1 = (Stream) \u008F\u001C.\u0093\u009E(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
      try
      {
        BinaryWriter writer1 = new BinaryWriter(stream1);
        try
        {
          \u0015\u001C.\u007E\u0010\u009E((object) writer1, \u001C.\u001A.\u0001);
          \u0011\u001F.\u007E\u0015\u009E((object) writer1, \u001C.\u001A.\u0001);
          writer1.\u001D\u0005(this.ID);
          long num1 = \u001F\u001E.\u007E\u0081\u009D((object) stream1);
          writer1.\u001D\u0005(\u0080.\u0016.\u0001);
          writer1.\u001D\u0005(this.UpdateUri);
          \u0092\u0081.\u007E\u001A\u009E((object) writer1, this.Name);
          \u0092\u0081.\u007E\u001A\u009E((object) writer1, this.Author);
          \u0092\u0081.\u007E\u001A\u009E((object) writer1, this.Description);
          writer1.\u001D\u0005(this.Version);
          writer1.\u001D\u0005(this.MinimumVersion);
          if (passwordHash.HasValue)
            writer1.\u001D\u0005(passwordHash.Value);
          else if (\u008F\u0084.\u009E\u0092(this.Password))
            writer1.\u001D\u0005(\u0080.\u0016.\u0001);
          else
            writer1.\u001D\u0005(\u0094\u0082.\u007E\u0017\u009C((object) \u001D\u001F.\u001A\u009C(), this.Password).\u001D\u0005());
          long num2 = \u001F\u001E.\u007E\u0081\u009D((object) stream1);
          \u0011\u001F.\u007E\u0015\u009E((object) writer1, 0);
          if (this.Icon != null)
          {
            \u0008.\u001D\u0005(this.Icon, stream1, \u009A\u0080.\u0090\u001F(), 100);
            long num3 = \u001F\u001E.\u007E\u0081\u009D((object) stream1);
            \u0012\u0080.\u007E\u0082\u009D((object) stream1, num2);
            \u0011\u001F.\u007E\u0015\u009E((object) writer1, (int) (num3 - num2 - 4L));
            \u0012\u0080.\u007E\u0082\u009D((object) stream1, num3);
          }
          if (this.LoaderPack)
            return;
          \u0011\u001F.\u007E\u0015\u009E((object) writer1, this.Data.MultiFileData.Count);
          IEnumerator<KeyValuePair<string, \u001B>> enumerator = ((IEnumerable<KeyValuePair<string, \u001B>>) this.Data.MultiFileData).GetEnumerator();
          try
          {
            while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
            {
              KeyValuePair<string, \u001B> current = enumerator.Current;
              \u0092\u0081.\u007E\u001A\u009E((object) writer1, current.Key);
              writer1.\u001D\u0005(current.Value.Data.\u001D\u0005());
            }
          }
          finally
          {
            if (enumerator != null)
              \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
          }
          long num4 = \u001F\u001E.\u007E\u0081\u009D((object) stream1);
          \u0011\u001F.\u007E\u0015\u009E((object) writer1, 0);
          \u0010 stream2 = new \u0010(stream1, \u001F\u001E.\u007E\u0081\u009D((object) stream1));
          try
          {
            BinaryWriter writer2 = new BinaryWriter((Stream) stream2);
            try
            {
              this.Data.\u001D\u0005((Stream) stream2, writer2);
              this.DataHash = stream2.\u001D\u0005();
            }
            finally
            {
              if (writer2 != null)
                \u001A\u001E.\u007E\u0094\u0092((object) writer2);
            }
          }
          finally
          {
            if (stream2 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) stream2);
          }
          long num5 = \u001F\u001E.\u007E\u0081\u009D((object) stream1);
          \u0012\u0080.\u007E\u0082\u009D((object) stream1, num4);
          \u0011\u001F.\u007E\u0015\u009E((object) writer1, (int) (num5 - num4 - 4L));
          \u0012\u0080.\u007E\u0082\u009D((object) stream1, num5);
          long num6 = \u001F\u001E.\u007E\u0081\u009D((object) stream1);
          \u0012\u0080.\u007E\u0082\u009D((object) stream1, num1);
          writer1.\u001D\u0005(this.DataHash);
          \u0012\u0080.\u007E\u0082\u009D((object) stream1, num6);
        }
        finally
        {
          if (writer1 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) writer1);
        }
      }
      finally
      {
        if (stream1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) stream1);
      }
    }
  }
}
