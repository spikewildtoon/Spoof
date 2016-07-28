// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0019;
using \u001A;
using \u001D;
using \u001F;
using \u0080;
using \u0082;
using \u0084;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using TSN.IO;

namespace \u0080
{
  internal sealed class \u001C : \u0015.\u0016
  {
    private Dictionary<string, \u001C.\u0001> \u0001 = new Dictionary<string, \u001C.\u0001>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly byte[] \u0001;
    private Stream \u0001;
    private int \u0001;
    private \u0018 \u0001;

    private int? Version
    {
      get
      {
        return new int?(1);
      }
    }

    private int MaximumVersion
    {
      get
      {
        return 1;
      }
    }

    private int MinimumVersion
    {
      get
      {
        return 1;
      }
    }

    public Size ThumbnailSize { get; private set; }

    static \u001C()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u001C)));
      \u001C.\u0001 = new byte[5]
      {
        (byte) 77,
        (byte) 71,
        (byte) 84,
        (byte) 67,
        (byte) 83
      };
    }

    private \u001C()
    {
      this.\u0001 = \u0081.\u0080.Instance.ApplicationSettings;
      this.ThumbnailSize = new Size(170, 128);
    }

    public static \u001C \u001D\u0005()
    {
      \u001C obj = (\u001C) null;
      try
      {
        obj = new \u001C();
        if (\u008F\u0084.\u0092\u009E(\u007F.\u0014))
          obj.\u0081\u0005();
        else
          obj.\u0082\u0005();
      }
      catch (Exception ex)
      {
        if (obj != null)
          obj.Dispose();
        obj = (\u001C) null;
        ex.\u001D\u0005();
      }
      if (obj == null)
      {
        try
        {
          obj = new \u001C();
          obj.\u0082\u0005();
        }
        catch
        {
          if (obj != null)
            obj.Dispose();
          throw;
        }
      }
      return obj;
    }

    public List<\u0006> \u001D\u0005()
    {
      List<\u0006> objList = new List<\u0006>();
      foreach (KeyValuePair<string, \u001C.\u0001> keyValuePair in this.\u0001)
        objList.Add(keyValuePair.Value.\u0001);
      return objList;
    }

    public Bitmap \u001D\u0005(string filePath)
    {
      \u001C.\u0001 obj = this.\u001D\u0005(filePath);
      if (obj == null)
        return (Bitmap) null;
      if (obj.\u0001.\u0001 != null)
        return obj.\u0001.\u0001;
      obj.\u0001 = new MemoryStream();
      \u0012\u0080.\u007E\u0082\u009D((object) obj.\u0001, 0L);
      \u0091\u0080.\u007E\u0083\u009D((object) obj.\u0001, (Stream) obj.\u0001);
      long num = \u0002\u0086.\u007E\u008B\u009D((object) obj.\u0001, 0L, SeekOrigin.Begin);
      return obj.\u0001.\u0001 = (Bitmap) \u0099\u001C.\u001C\u001F((Stream) obj.\u0001);
    }

    private \u001C.\u0001 \u001D\u0005(string filePath)
    {
      string index = \u009C\u0080.\u0008\u009F(filePath);
      if (this.\u0001.ContainsKey(index))
        goto label_35;
label_3:
      \u001C.\u0001 obj1 = (\u001C.\u0001) null;
      try
      {
        obj1 = new \u001C.\u0001();
        obj1.\u0001 = \u0004.\u001D\u0005(filePath);
        DateTime createdDate;
        \u0012.\u001D\u0005(filePath, out obj1.\u0001, out createdDate);
        obj1.\u0001 = new \u0006(index, filePath, createdDate);
        MemoryStream memoryStream1 = new MemoryStream();
        try
        {
          BinaryWriter writer = new BinaryWriter((Stream) memoryStream1);
          try
          {
            Bitmap image = (Bitmap) \u0011\u0081.\u001B\u001F(filePath);
            try
            {
              \u0092\u0081.\u007E\u001A\u009E((object) writer, index);
              writer.\u001D\u0005(obj1.\u0001);
              \u0012\u0080.\u007E\u0017\u009E((object) writer, obj1.\u0001);
              \u0012\u0080.\u007E\u0017\u009E((object) writer, obj1.\u0001.DateCreated.ToBinary());
              MemoryStream memoryStream2 = new MemoryStream();
              try
              {
                \u0008.\u001E\u0005(image, (Stream) memoryStream2, 100, this.ThumbnailSize.Width, this.ThumbnailSize.Height);
                \u0012\u0080.\u007E\u0017\u009E((object) writer, \u001F\u001E.\u007E\u0080\u009D((object) memoryStream2));
                obj1.\u0002 = \u001F\u001E.\u007E\u0080\u009D((object) memoryStream2);
                long num = \u0002\u0086.\u007E\u008B\u009D((object) memoryStream2, 0L, SeekOrigin.Begin);
                \u0091\u0080.\u007E\u0083\u009D((object) memoryStream2, (Stream) memoryStream1);
              }
              finally
              {
                if (memoryStream2 != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) memoryStream2);
              }
              long num1 = \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, 0L, SeekOrigin.End);
              long num2 = \u0002\u0086.\u007E\u008B\u009D((object) memoryStream1, 0L, SeekOrigin.Begin);
              \u0091\u0080.\u007E\u0083\u009D((object) memoryStream1, this.\u0001);
            }
            finally
            {
              if (image != null)
                \u001A\u001E.\u007E\u0094\u0092((object) image);
            }
          }
          finally
          {
            if (writer != null)
              \u001A\u001E.\u007E\u0094\u0092((object) writer);
          }
        }
        finally
        {
          if (memoryStream1 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) memoryStream1);
        }
        long num3 = \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, -obj1.\u0002, SeekOrigin.Current);
        obj1.\u0001 = new \u0010(this.\u0001, \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001), \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001) + obj1.\u0002);
        this.\u0001.Add(index, obj1);
        long num4 = \u0002\u0086.\u007E\u008B\u009D((object) this.\u0001, (long) (\u001C.\u0001.Length + 4), SeekOrigin.Begin);
        \u0010 obj2 = new \u0010(this.\u0001);
        try
        {
          BinaryWriter binaryWriter = new BinaryWriter((Stream) obj2);
          try
          {
            \u0011\u001F.\u007E\u0015\u009E((object) binaryWriter, this.\u0001.Count);
          }
          finally
          {
            if (binaryWriter != null)
              \u001A\u001E.\u007E\u0094\u0092((object) binaryWriter);
          }
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
        return obj1;
      }
      catch (Exception ex)
      {
        if (obj1 != null)
          obj1.Dispose();
        ex.\u001D\u0005((object) filePath);
        return (\u001C.\u0001) null;
      }
label_35:
      long fileSize;
      DateTime createdDate1;
      \u0012.\u001D\u0005(filePath, out fileSize, out createdDate1);
      \u001C.\u0001 obj3 = this.\u0001[index];
      if (obj3.\u0001 == fileSize && \u0017\u0084.\u007F\u0094(obj3.\u0001.DateCreated, createdDate1))
        return obj3;
      obj3.Dispose();
      this.\u0001.Remove(index);
      ++this.\u0001;
      goto label_3;
    }

    public void \u0081\u0005()
    {
      foreach (KeyValuePair<string, \u001C.\u0001> keyValuePair in this.\u0001)
        keyValuePair.Value.Dispose();
      this.\u0001.Clear();
      this.\u0001 = (Stream) \u008F\u001C.\u0093\u009E(\u007F.\u0014, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
      \u0010 obj = new \u0010(this.\u0001);
      try
      {
        BinaryReader reader = new BinaryReader((Stream) obj);
        try
        {
          byte[] expectedHeader = \u001C.\u0001;
          byte[] actualHeader = \u0004\u0086.\u007E\u0003\u009E((object) reader, expectedHeader.Length);
          if (!((IEnumerable<byte>) actualHeader).\u001D\u0005<byte>((IEnumerable<byte>) expectedHeader))
            throw new InvalidFileType(expectedHeader, actualHeader);
          int num = \u0005\u0081.\u007E\u0099\u009D((object) reader);
          if (num < this.MinimumVersion || num > this.MaximumVersion)
            throw new InvalidFileVersion<int>(this.MinimumVersion, this.MaximumVersion, num);
          this.\u001D\u0005(this.\u0001, reader, num);
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
      foreach (string filePath in \u0012.\u001D\u0005(this.\u0001.ScreenshotSaveDirectory, \u001C.\u0001(37090), \u001C.\u0001(45082)))
        this.\u001D\u0005(filePath);
      if (this.\u0001 <= 10)
        return;
      this.\u0082\u0005();
    }

    public void \u0082\u0005()
    {
      \u0081\u0086 obj = \u0081\u0086.\u0011\u009F;
      string applicationDataDirectory = \u007F.CommonApplicationDataDirectory;
      Guid guid = \u009E\u0080.\u000F\u0096();
      string str = \u0081\u0086.\u0086\u0093(guid.ToString(), \u001C.\u0001(56431));
      string source_file = obj(applicationDataDirectory, str);
      Stream stream = (Stream) \u008F\u001C.\u0093\u009E(source_file, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
      try
      {
        BinaryWriter writer = new BinaryWriter(stream);
        try
        {
          byte[] numArray = \u001C.\u0001;
          if (numArray != null)
            \u0015\u001C.\u007E\u0010\u009E((object) writer, numArray);
          int? version = this.Version;
          \u0011\u001F.\u007E\u0015\u009E((object) writer, version.Value);
          this.\u001D\u0005(stream, writer);
        }
        finally
        {
          if (writer != null)
            \u001A\u001E.\u007E\u0094\u0092((object) writer);
        }
      }
      finally
      {
        if (stream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) stream);
      }
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0084\u009D((object) this.\u0001);
        \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
      }
      \u0012.\u001D\u0005(source_file, \u007F.\u0014, true);
      this.\u0001 = 0;
      this.\u0081\u0005();
    }

    private void \u001D\u0005(Stream stream, BinaryReader reader, int version)
    {
      int num1 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index1 = 0; index1 < num1; ++index1)
      {
        \u001C.\u0001 obj1 = (\u001C.\u0001) null;
        try
        {
          obj1 = new \u001C.\u0001();
          string index2 = \u0002\u007F.\u007E\u0001\u009E((object) reader);
          obj1.\u0001 = reader.\u001D\u0005();
          obj1.\u0001 = \u001F\u001E.\u007E\u009B\u009D((object) reader);
          string filePath = \u0081\u0086.\u0011\u009F(this.\u0001.ScreenshotSaveDirectory, index2);
          obj1.\u0001 = new \u0006(index2, filePath, \u0014\u0080.\u0006\u0094(\u001F\u001E.\u007E\u009B\u009D((object) reader)));
          obj1.\u0002 = \u001F\u001E.\u007E\u009B\u009D((object) reader);
          if (\u008F\u0084.\u0092\u009E(filePath))
          {
            obj1.\u0001 = new \u0010(stream, \u001F\u001E.\u007E\u0081\u009D((object) stream), \u001F\u001E.\u007E\u0081\u009D((object) stream) + obj1.\u0002);
            if (this.\u0001.ContainsKey(index2))
            {
              this.\u0001[index2].Dispose();
              this.\u0001.Remove(index2);
            }
            this.\u0001.Add(index2, obj1);
          }
          else
          {
            ++this.\u0001;
            obj1.Dispose();
          }
        }
        catch
        {
          if (obj1 != null)
            obj1.Dispose();
          throw;
        }
        \u0012\u0080 obj2 = \u0012\u0080.\u007E\u0082\u009D;
        Stream stream1 = stream;
        long num2 = stream1.Position + obj1.\u0002;
        obj2((object) stream1, num2);
      }
    }

    private void \u001D\u0005(Stream stream, BinaryWriter writer)
    {
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.\u0001.Count);
      foreach (KeyValuePair<string, \u001C.\u0001> keyValuePair in this.\u0001)
      {
        \u001C.\u0001 obj = keyValuePair.Value;
        \u0092\u0081.\u007E\u001A\u009E((object) writer, keyValuePair.Key);
        writer.\u001D\u0005(obj.\u0001);
        \u0012\u0080.\u007E\u0017\u009E((object) writer, obj.\u0001);
        writer.\u001D\u0005(obj.\u0001.DateCreated);
        \u0012\u0080.\u007E\u0017\u009E((object) writer, obj.\u0002);
        \u0012\u0080.\u007E\u0082\u009D((object) obj.\u0001, 0L);
        \u0091\u0080.\u007E\u0083\u009D((object) obj.\u0001, stream);
      }
    }

    protected override void \u001D\u0005()
    {
      foreach (KeyValuePair<string, \u001C.\u0001> keyValuePair in this.\u0001)
        keyValuePair.Value.Dispose();
      this.\u0001.Clear();
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0084\u009D((object) this.\u0001);
        \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
        this.\u0001 = (Stream) null;
      }
      base.\u001D\u0005();
    }

    private sealed class \u0001 : \u0015.\u0016
    {
      public \u0006 \u0001;
      public \u0080.\u0016 \u0001;
      public long \u0001;
      public long \u0002;
      public \u0010 \u0001;
      public MemoryStream \u0001;

      protected override void \u001D\u0005()
      {
        if (this.\u0001 != null)
          \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
        this.\u0001 = (\u0010) null;
        if (this.\u0001 != null)
          \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
        this.\u0001 = (MemoryStream) null;
        if (this.\u0001 != null)
          this.\u0001.Dispose();
        this.\u0001 = (\u0006) null;
        base.\u001D\u0005();
      }
    }
  }
}
