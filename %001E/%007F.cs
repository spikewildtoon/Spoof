// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0017;
using \u001C;
using \u001D;
using \u001E;
using \u0080;
using \u0081;
using \u0082;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TSN.Collections;
using TSN.IO;

namespace \u001E
{
  internal sealed class \u007F : \u0016, IEnumerable<KeyValuePair<string, \u001B>>, IEnumerable
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public static readonly DateTime \u0001;
    private static readonly byte[] \u0001;
    private ReadOnlyDictionary<string, \u001B> \u0001;
    private Dictionary<string, \u001B> \u0001;
    private short \u0001;
    private short \u0002;
    private uint \u0001;
    private uint \u0002;
    private Stream \u0001;
    private BinaryReader \u0001;
    private BinaryWriter \u0001;
    private bool \u0001;

    public ReadOnlyDictionary<string, \u001B> MultiFileData
    {
      get
      {
        if (this.\u0001 == null)
          goto label_2;
label_1:
        return this.\u0001;
label_2:
        this.\u0001 = new ReadOnlyDictionary<string, \u001B>((IDictionary<string, \u001B>) this.\u0001);
        goto label_1;
      }
    }

    public short MajorVersion
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
      }
    }

    public short MinorVersion
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        this.\u0002 = value;
      }
    }

    public uint Scale
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
      }
    }

    public DateTime TimeStamp
    {
      get
      {
        return \u007F.\u0001.AddSeconds((double) this.\u0002).ToLocalTime();
      }
      set
      {
        this.\u0002 = (uint) value.ToUniversalTime().Subtract(\u007F.\u0001).TotalSeconds;
      }
    }

    public \u001B this[string name]
    {
      get
      {
        return this.\u0001[name];
      }
    }

    static \u007F()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u007F)));
      \u007F.\u0001 = new DateTime(1970, 1, 1, 0, 0, 0, 0);
      \u007F.\u0001 = new byte[6]
      {
        (byte) 112,
        (byte) 109,
        (byte) 102,
        (byte) 0,
        (byte) 10,
        (byte) 13
      };
    }

    public \u007F(Stream str)
    {
      if (str == null)
        throw new ArgumentNullException(\u007F.\u0001(65265));
      this.\u0001 = str;
      this.\u0001 = new Dictionary<string, \u001B>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
    }

    public \u007F()
    {
      this.Scale = 1U;
      this.MajorVersion = (short) 1;
      this.MinorVersion = (short) 1;
      this.TimeStamp = \u001D\u0082.\u0011\u0094();
      this.\u0001 = new Dictionary<string, \u001B>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      this.\u0001 = true;
    }

    public static void \u001D\u0005(\u0016 pd, BinaryWriter write_stream, uint offset_orig, uint offset_new, Stream stream_orig, Stream stream_new)
    {
      \u0010 obj1 = new \u0010(stream_orig);
      try
      {
        \u0010 obj2 = new \u0010(stream_new);
        try
        {
          \u007F obj3 = new \u007F((Stream) obj1);
          try
          {
            \u007F obj4 = new \u007F((Stream) obj2);
            try
            {
              List<KeyValuePair<string, \u007F.\u0001>> sortedCollection1 = new List<KeyValuePair<string, \u007F.\u0001>>();
              List<KeyValuePair<string, \u007F.\u0001>> sortedCollection2 = (List<KeyValuePair<string, \u007F.\u0001>>) null;
              long endOfIndex1;
              obj4.\u001D\u0005(ref sortedCollection1, out endOfIndex1);
              long endOfIndex2;
              obj3.\u001D\u0005(ref sortedCollection2, out endOfIndex2);
              \u0010 obj5 = new \u0010((Stream) obj1, 0L, endOfIndex2);
              try
              {
                \u0010 obj6 = new \u0010((Stream) obj2, 0L, endOfIndex1);
                try
                {
                  \u001A.\u0080.\u001D\u0005(pd, \u001E.\u0080.\u0001, write_stream, offset_orig, offset_new, (Stream) obj5, (Stream) obj6);
                }
                finally
                {
                  if (obj6 != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) obj6);
                }
              }
              finally
              {
                if (obj5 != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) obj5);
              }
              foreach (KeyValuePair<string, \u007F.\u0001> keyValuePair in sortedCollection1)
              {
                if (obj3.\u007F\u0005(keyValuePair.Key))
                {
                  \u007F.\u0001 obj6 = obj3[keyValuePair.Key] as \u007F.\u0001;
                  \u007F.\u001D\u0005(pd, write_stream, offset_orig, offset_new, keyValuePair.Key, (Stream) obj1, obj6.\u0002, obj6.\u0002 + obj6.DataLength, (Stream) obj2, keyValuePair.Value.\u0002, keyValuePair.Value.\u0002 + keyValuePair.Value.DataLength);
                }
                else
                {
                  obj4.\u001D\u0005((\u001B) keyValuePair.Value);
                  \u001A.\u0080.\u001D\u0005(pd, write_stream, keyValuePair.Value.DataLength, keyValuePair.Value.Data, 0U, 0U, 0U);
                }
              }
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

    private static void \u001D\u0005(\u0016 pd, BinaryWriter write_stream, uint offset_orig, uint offset_new, string filename, Stream stream_orig, uint orig_start, uint orig_end, Stream stream_new, uint new_start, uint new_end)
    {
      uint num = new_end - new_start;
      uint copy_length = orig_end - orig_start;
      \u0010 stream1 = new \u0010(stream_orig, (long) orig_start, (long) orig_end);
      try
      {
        \u0010 stream2 = new \u0010(stream_new, (long) new_start, (long) new_end);
        try
        {
          if ((int) num == (int) copy_length && \u0016.\u001D\u0005(stream1.\u001D\u0005(), stream2.\u001D\u0005()))
            \u001A.\u0080.\u001D\u0005(pd, write_stream, 0U, (byte[]) null, 0U, copy_length, offset_orig + orig_start);
          else
            \u001A.\u0080.\u001D\u0005(pd, \u001A.\u0080.\u001D\u0005(filename), write_stream, offset_orig + orig_start, offset_new + new_start, (Stream) stream1, (Stream) stream2);
        }
        finally
        {
          if (stream2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) stream2);
        }
      }
      finally
      {
        if (stream1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) stream1);
      }
    }

    private static bool \u001D\u0005(Stream file_stream, out byte[] header)
    {
      long num1 = \u001F\u001E.\u007E\u0081\u009D((object) file_stream);
      header = new byte[\u007F.\u0001.Length];
      int num2 = \u0080\u0081.\u007E\u008D\u009D((object) file_stream, header, 0, \u007F.\u0001.Length);
      \u0012\u0080.\u007E\u0082\u009D((object) file_stream, num1);
      return ((IEnumerable<byte>) header).\u001D\u0005<byte>((IEnumerable<byte>) \u007F.\u0001);
    }

    public static bool \u001D\u0005(Stream file_stream1, Stream file_stream2)
    {
      byte[] header1;
      byte[] header2;
      if (!\u007F.\u001D\u0005(file_stream1, out header1) || !\u007F.\u001D\u0005(file_stream2, out header2))
        return false;
      return ((IEnumerable<byte>) header1).\u001D\u0005<byte>((IEnumerable<byte>) header2);
    }

    public static \u001C.\u0017 \u001D\u0005(string file)
    {
      string str;
      if ((str = \u0002\u007F.\u007E\u0019\u0093((object) \u009C\u0080.\u0006\u009F(file))) != null)
      {
        if (\u0008\u001F.\u009A\u0092(str, \u007F.\u0001(44149)))
          return \u001C.\u0017.\u0002;
        if (\u0008\u001F.\u009A\u0092(str, \u007F.\u0001(66850)))
          return \u001C.\u0017.\u0003;
        if (\u0008\u001F.\u009A\u0092(str, \u007F.\u0001(66859)))
          return \u001C.\u0017.\u0004;
        if (\u0008\u001F.\u009A\u0092(str, \u007F.\u0001(66868)))
          return \u001C.\u0017.\u0005;
        if (\u0008\u001F.\u009A\u0092(str, \u007F.\u0001(66877)))
          return \u001C.\u0017.\u0006;
      }
      return \u001C.\u0017.\u0001;
    }

    public static bool \u001D\u0005(string file, out string multifile_name)
    {
      multifile_name = (string) null;
      int startIndex = 0;
      string multifile_name1;
      if (!file.\u001D\u0005('/', ref startIndex, out multifile_name1) || !\u007F.\u001E\u0005(multifile_name1))
        return false;
      multifile_name = multifile_name1;
      return true;
    }

    public static bool \u001D\u0005(string multifile_name)
    {
      int startIndex = 0;
      string str;
      Decimal num;
      if (!multifile_name.\u001D\u0005('_', ref startIndex, out str) || \u0008\u001F.\u009B\u0092(\u0002\u007F.\u007E\u0019\u0093((object) str), \u007F.\u0001(66886)) || (!multifile_name.\u001D\u0005(\u007F.\u0001(52842), ref startIndex, out str) || (!\u0016\u0084.\u0082\u0095(str, ref num) || !\u009F\u001B.\u008B\u0095(num, new Decimal(1))) || !\u009F\u001B.\u008B\u0095(num, new Decimal(2))))
        return false;
      return startIndex == \u0005\u0081.\u007E\u0001\u0093((object) multifile_name);
    }

    public static bool \u001E\u0005(string multifile_name)
    {
      int startIndex = 0;
      string str;
      Decimal num;
      if (!multifile_name.\u001D\u0005('_', ref startIndex, out str) || \u0008\u001F.\u009B\u0092(\u0002\u007F.\u007E\u0019\u0093((object) str), \u007F.\u0001(66886)) || (!multifile_name.\u001D\u0005(ref startIndex, out str) || (!\u0016\u0084.\u0082\u0095(str, ref num) || !\u009F\u001B.\u008B\u0095(num, new Decimal(1)))))
        return false;
      return \u009F\u001B.\u008B\u0095(num, new Decimal(2));
    }

    public static bool \u001F\u0005(string file)
    {
      if (\u008F\u0084.\u009E\u0092(file))
        return false;
      int startIndex = 0;
      string result;
      string str1;
      if (!file.\u001D\u0005('/', ref startIndex, out result) || !\u007F.\u001E\u0005(result) || (!file.\u001D\u0005('/', ref startIndex, out result) || (str1 = \u0002\u007F.\u007E\u0019\u0093((object) result)) == null))
        return false;
      if (!\u0008\u001F.\u009A\u0092(str1, \u007F.\u0001(30713)))
      {
        string str2;
        return \u0008\u001F.\u009A\u0092(str1, \u007F.\u0001(30722)) && file.\u001E\u0005('.', ref startIndex, out result) && (str2 = \u0002\u007F.\u007E\u0019\u0093((object) result)) != null && (\u0008\u001F.\u009A\u0092(str2, \u007F.\u0001(30765)) || \u0008\u001F.\u009A\u0092(str2, \u007F.\u0001(30770)));
      }
      string str3;
      string str4;
      return file.\u001D\u0005('/', ref startIndex, out result) && (str3 = \u0002\u007F.\u007E\u0019\u0093((object) result)) != null && (\u0008\u001F.\u009A\u0092(str3, \u007F.\u0001(30731)) || \u0008\u001F.\u009A\u0092(str3, \u007F.\u0001(30736)) || \u0008\u001F.\u009A\u0092(str3, \u007F.\u0001(30745))) && (file.\u001E\u0005('.', ref startIndex, out result) && (str4 = \u0002\u007F.\u007E\u0019\u0093((object) result)) != null && (\u0008\u001F.\u009A\u0092(str4, \u007F.\u0001(30750)) || \u0008\u001F.\u009A\u0092(str4, \u007F.\u0001(30755)) || \u0008\u001F.\u009A\u0092(str4, \u007F.\u0001(30760))));
    }

    protected override void \u001D\u0005()
    {
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0084\u009D((object) this.\u0001);
        \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
      }
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u009D((object) this.\u0001);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u0006\u009E((object) this.\u0001);
      base.\u001D\u0005();
    }

    public \u001B \u001E\u0005(string name)
    {
      if (this.\u0001.ContainsKey(name))
        throw new ArgumentException(\u009E\u0081.\u001F\u0093(\u007F.\u0001(66895), (object) name));
      \u007F.\u0001 obj = new \u007F.\u0001();
      obj.LoadedFromStream = false;
      this.\u0001.Add(name, (\u001B) obj);
      return (\u001B) obj;
    }

    public void \u001D\u0005(string name)
    {
      if (!this.\u0001.ContainsKey(name))
        throw new ArgumentException(\u009E\u0081.\u001F\u0093(\u007F.\u0001(66952), (object) name));
      this.\u0001.Remove(name);
    }

    public bool \u007F\u0005(string name)
    {
      return this.\u0001.ContainsKey(name);
    }

    public IEnumerator<KeyValuePair<string, \u001B>> GetEnumerator()
    {
      IEnumerator<KeyValuePair<string, \u001B>> enumerator = this.\u0001.Select<KeyValuePair<string, \u001B>, KeyValuePair<string, \u001B>>((Func<KeyValuePair<string, \u001B>, KeyValuePair<string, \u001B>>) (item => new KeyValuePair<string, \u001B>(item.Key, item.Value))).GetEnumerator();
      while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        yield return enumerator.Current;
      // ISSUE: reference to a compiler-generated method
      this.\u001F\u0005();
    }

    IEnumerator IEnumerable.\u001D\u0005()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    private void \u0081\u0005()
    {
      if (this.\u0001 == null)
        throw new NullReferenceException(\u007F.\u0001(67009));
    }

    public \u0018 \u001D\u0005(string indexName)
    {
      if (!this.\u007F\u0005(indexName))
        return (\u0018) null;
      \u0018 obj = new \u0018();
      \u001B data = this[indexName];
      this.\u001D\u0005(data);
      obj.\u001D\u0005(\u0099\u0084.\u007E\u0018\u009C((object) \u001D\u001F.\u0016\u009C(), data.Data));
      return obj;
    }

    private void \u001D\u0005(ref List<KeyValuePair<string, \u007F.\u0001>> sortedCollection, out long endOfIndex)
    {
      this.\u0081\u0005();
      if (this.\u0001 == null)
        this.\u0001 = new BinaryReader(this.\u0001);
      \u007F.\u001D\u0005(this.\u0001, this.\u0001, out this.\u0001, out this.\u0002, out this.\u0001, out this.\u0002, ref this.\u0001, ref sortedCollection);
      endOfIndex = \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001);
      this.\u0001 = true;
    }

    public void \u0082\u0005()
    {
      List<KeyValuePair<string, \u007F.\u0001>> sortedCollection = (List<KeyValuePair<string, \u007F.\u0001>>) null;
      long endOfIndex;
      this.\u001D\u0005(ref sortedCollection, out endOfIndex);
    }

    public void \u0083\u0005()
    {
      this.\u0081\u0005();
      if (!this.\u0001)
        throw new InvalidOperationException(\u007F.\u0001(67046));
      if (this.\u0001 == null)
        this.\u0001 = new BinaryReader(this.\u0001);
      \u007F.\u001D\u0005(this.\u0001, this.\u0001, this.\u0001);
    }

    public void \u0084\u0005()
    {
      this.\u0082\u0005();
      this.\u0083\u0005();
    }

    public void \u001D\u0005(IEnumerable<string> names)
    {
      this.\u0081\u0005();
      if (!this.\u0001)
        throw new InvalidOperationException(\u007F.\u0001(67046));
      if (this.\u0001 == null)
        this.\u0001 = new BinaryReader(this.\u0001);
      \u007F.\u001D\u0005(this.\u0001, this.\u0001, this.\u0001, names);
    }

    public void \u001E\u0005(IEnumerable<string> names)
    {
      this.\u0082\u0005();
      this.\u001D\u0005(names);
    }

    public void \u001D\u0005(\u001B data)
    {
      this.\u0081\u0005();
      if (data == null)
        throw new ArgumentNullException(\u007F.\u0001(47276));
      if (!this.\u0001)
        throw new InvalidOperationException(\u007F.\u0001(67046));
      \u007F.\u0001 mfd = data as \u007F.\u0001;
      if (mfd == null)
        throw new ArgumentException(\u007F.\u0001(67087));
      if (!this.\u0001.ContainsValue((\u001B) mfd))
        throw new ArgumentException(\u007F.\u0001(67132));
      \u007F.\u001D\u0005(this.\u0001, this.\u0001, mfd);
    }

    public void \u001D\u0005(IEnumerable<\u001B> data)
    {
      this.\u0081\u0005();
      if (data == null)
        throw new ArgumentNullException(\u007F.\u0001(47276));
      if (!this.\u0001)
        throw new InvalidOperationException(\u007F.\u0001(67046));
      IEnumerator<\u001B> enumerator = data.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          \u007F.\u0001 mfd = enumerator.Current as \u007F.\u0001;
          if (mfd == null)
            throw new ArgumentException(\u007F.\u0001(67193));
          if (!this.\u0001.ContainsValue((\u001B) mfd))
            throw new ArgumentException(\u007F.\u0001(67238));
          \u007F.\u001D\u0005(this.\u0001, this.\u0001, mfd);
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
    }

    public void \u001D\u0005(Stream str, BinaryWriter writer)
    {
      if (!this.\u0001)
        throw new InvalidOperationException(\u007F.\u0001(67046));
      if (\u009F\u001D.\u007E\u0007\u009E((object) writer) != str)
        throw new ArgumentException(\u007F.\u0001(67299));
      List<KeyValuePair<string, \u007F.\u0001>> list = this.\u0001.Select<KeyValuePair<string, \u001B>, KeyValuePair<string, \u007F.\u0001>>((Func<KeyValuePair<string, \u001B>, KeyValuePair<string, \u007F.\u0001>>) (item => new KeyValuePair<string, \u007F.\u0001>(item.Key, item.Value as \u007F.\u0001))).ToList<KeyValuePair<string, \u007F.\u0001>>();
      list.Sort((Comparison<KeyValuePair<string, \u007F.\u0001>>) ((x, y) => \u000F\u001D.\u000F\u0093(x.Key, y.Key)));
      \u007F.\u001D\u0005(str, writer, this.\u0001, this.\u0002, this.\u0001, this.\u0002, list);
    }

    public void \u0086\u0005()
    {
      this.\u0081\u0005();
      if (!this.\u0001)
        throw new InvalidOperationException(\u007F.\u0001(67046));
      if (this.\u0001 == null)
        this.\u0001 = new BinaryWriter(this.\u0001);
      \u0012\u0080.\u007E\u0082\u009D((object) this.\u0001, 0L);
      \u0012\u0080.\u007E\u008C\u009D((object) this.\u0001, 0L);
      this.\u001D\u0005(this.\u0001, this.\u0001);
    }

    private static void \u001D\u0005(Stream str, BinaryReader reader, out short majorVersion, out short minorVersion, out uint scale, out uint timeStamp, ref Dictionary<string, \u001B> data, ref List<KeyValuePair<string, \u007F.\u0001>> orderedData)
    {
      byte[] actualHeader = \u0004\u0086.\u007E\u0003\u009E((object) reader, \u007F.\u0001.Length);
      if (!((IEnumerable<byte>) actualHeader).\u001D\u0005<byte>((IEnumerable<byte>) \u007F.\u0001))
        throw new InvalidFileType(\u007F.\u0001, actualHeader);
      majorVersion = \u0011\u001C.\u007E\u0097\u009D((object) reader);
      minorVersion = \u0011\u001C.\u007E\u0097\u009D((object) reader);
      scale = \u0004\u0081.\u007E\u009A\u009D((object) reader);
      timeStamp = \u0004\u0081.\u007E\u009A\u009D((object) reader);
      if ((int) scale == 0)
        scale = 1U;
      while (true)
      {
        uint num1 = \u0004\u0081.\u007E\u009A\u009D((object) reader) * scale;
        if ((int) num1 != 0)
        {
          \u007F.\u0001 obj = new \u007F.\u0001();
          obj.LoadedFromStream = true;
          obj.\u0003 = num1;
          obj.\u0002 = \u0004\u0081.\u007E\u009A\u009D((object) reader) * scale;
          obj.DataLength = \u0004\u0081.\u007E\u009A\u009D((object) reader);
          obj.Flags = \u0095\u0084.\u007E\u0098\u009D((object) reader);
          obj.DecompressedLength = !obj.Compressed ? obj.DataLength : \u0004\u0081.\u007E\u009A\u009D((object) reader);
          obj.TimeStamp = \u0004\u0081.\u007E\u009A\u009D((object) reader);
          ushort num2 = \u0095\u0084.\u007E\u0098\u009D((object) reader);
          string key = \u007F.\u001D\u0005(\u0004\u0086.\u007E\u0003\u009E((object) reader, (int) num2));
          data.Add(key, (\u001B) obj);
          if (orderedData != null)
            orderedData.Add(new KeyValuePair<string, \u007F.\u0001>(key, obj));
          \u0012\u0080.\u007E\u0082\u009D((object) str, (long) num1);
        }
        else
          break;
      }
    }

    private static void \u001D\u0005(Stream str, BinaryReader reader, Dictionary<string, \u001B> data)
    {
      // ISSUE: unable to decompile the method.
    }

    private static void \u001D\u0005(Stream str, BinaryReader reader, \u007F.\u0001 mfd)
    {
      \u0012\u0080.\u007E\u0082\u009D((object) str, (long) mfd.\u0002);
      if (mfd.DataLength <= 0U)
        mfd.Data = new byte[0];
      else
        mfd.Data = \u0004\u0086.\u007E\u0003\u009E((object) reader, (int) mfd.DataLength);
    }

    private static void \u001D\u0005(Stream str, BinaryReader reader, Dictionary<string, \u001B> data, IEnumerable<string> names)
    {
      IEnumerator<string> enumerator = names.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          if (data.ContainsKey(enumerator.Current))
            \u007F.\u001D\u0005(str, reader, data[enumerator.Current] as \u007F.\u0001);
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
    }

    private static void \u001D\u0005(Stream str, BinaryWriter writer, short majorVersion, short minorVersion, uint scale, uint timeStamp, List<KeyValuePair<string, \u007F.\u0001>> data)
    {
      foreach (KeyValuePair<string, \u007F.\u0001> keyValuePair in data)
      {
        if (!((\u001B) keyValuePair.Value).Populated)
          throw new NotSupportedException(\u009E\u0081.\u001F\u0093(\u007F.\u0001(67364), (object) keyValuePair.Key));
      }
      \u0015\u001C.\u007E\u0010\u009E((object) writer, \u007F.\u0001);
      \u0010\u001E.\u007E\u0013\u009E((object) writer, majorVersion);
      \u0010\u001E.\u007E\u0013\u009E((object) writer, minorVersion);
      \u000F\u0083.\u007E\u0016\u009E((object) writer, scale);
      \u000F\u0083.\u007E\u0016\u009E((object) writer, timeStamp);
      \u007F.\u001D\u0005(str, scale);
      foreach (KeyValuePair<string, \u007F.\u0001> keyValuePair in data)
      {
        keyValuePair.Value.\u0001 = (uint) \u001F\u001E.\u007E\u0081\u009D((object) str);
        \u0011\u001F.\u007E\u0015\u009E((object) writer, 0);
        \u0011\u001F.\u007E\u0015\u009E((object) writer, 0);
        \u000F\u0083.\u007E\u0016\u009E((object) writer, keyValuePair.Value.DataLength);
        \u0087\u0083.\u007E\u0014\u009E((object) writer, keyValuePair.Value.Flags);
        if (keyValuePair.Value.Compressed)
          \u000F\u0083.\u007E\u0016\u009E((object) writer, keyValuePair.Value.DecompressedLength);
        \u000F\u0083.\u007E\u0016\u009E((object) writer, keyValuePair.Value.TimeStamp);
        \u0087\u0083.\u007E\u0014\u009E((object) writer, (ushort) \u0005\u0081.\u007E\u0001\u0093((object) keyValuePair.Key));
        \u0015\u001C.\u007E\u0010\u009E((object) writer, \u007F.\u001D\u0005(keyValuePair.Key));
        \u007F.\u001D\u0005(str, scale);
      }
      int num1 = (int) \u001F\u001E.\u007E\u0081\u009D((object) str);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, 0);
      \u007F.\u001D\u0005(str, scale);
      for (int index = 0; index < data.Count; ++index)
      {
        data[index].Value.\u0002 = (uint) \u001F\u001E.\u007E\u0081\u009D((object) str) / scale;
        \u0016\u0086.\u007E\u0011\u009E((object) writer, data[index].Value.Data, 0, (int) data[index].Value.DataLength);
        \u007F.\u001D\u0005(str, scale);
      }
      long num2 = \u001F\u001E.\u007E\u0081\u009D((object) str);
      for (int index = 0; index < data.Count; ++index)
      {
        \u0012\u0080.\u007E\u0082\u009D((object) str, (long) (data[index].Value.\u0001 / scale));
        data[index].Value.\u0003 = (uint) ((index < data.Count - 1 ? (ulong) (int) data[index + 1].Value.\u0001 : (ulong) num1) / (ulong) scale);
        \u000F\u0083.\u007E\u0016\u009E((object) writer, data[index].Value.\u0003);
        \u000F\u0083.\u007E\u0016\u009E((object) writer, data[index].Value.\u0002);
      }
      \u0012\u0080.\u007E\u0082\u009D((object) str, num2);
    }

    private static byte[] \u001D\u0005(string data)
    {
      byte[] numArray = new byte[\u0005\u0081.\u007E\u0001\u0093((object) data)];
      for (int index = 0; index < \u0005\u0081.\u007E\u0001\u0093((object) data); ++index)
        numArray[index] = (byte) ((int) \u008C\u0086.\u007E\u009C\u0092((object) data, index) ^ (int) byte.MaxValue);
      return numArray;
    }

    private static string \u001D\u0005(byte[] data)
    {
      string str = string.Empty;
      for (int index = 0; index < data.Length; ++index)
        str = \u0089\u001D.\u0083\u0093((object) str, (object) (char) ((uint) data[index] ^ (uint) byte.MaxValue));
      return str;
    }

    private static void \u001D\u0005(Stream str, uint scale)
    {
      if ((int) scale == 1)
        return;
      uint num = \u007F.\u001D\u0005((uint) \u001F\u001E.\u007E\u0081\u009D((object) str), scale);
      while (\u001F\u001E.\u007E\u0081\u009D((object) str) < (long) num)
        \u0095\u001F.\u007E\u0090\u009D((object) str, (byte) 0);
    }

    private static uint \u001D\u0005(uint position, uint scale)
    {
      if ((int) (position % scale) == 0)
        return position;
      return position - position % scale + scale;
    }

    private sealed class \u0001 : \u001B
    {
      public new uint \u0001;
      public new uint \u0002;
      public new uint \u0003;

      public bool LoadedFromStream
      {
        get
        {
          return base.\u0002;
        }
        set
        {
          base.\u0002 = value;
        }
      }

      public uint TimeStamp
      {
        get
        {
          return base.\u0002;
        }
        set
        {
          base.\u0002 = value;
        }
      }

      public uint DecompressedLength
      {
        get
        {
          return base.\u0001;
        }
        set
        {
          base.\u0001 = value;
        }
      }

      public uint DataLength
      {
        get
        {
          return base.\u0003;
        }
        set
        {
          base.\u0003 = value;
        }
      }

      public new byte[] Data
      {
        get
        {
          return base.\u0001;
        }
        set
        {
          base.\u0001 = value;
          base.\u0001 = base.\u0001 != null;
        }
      }

      public ushort Flags
      {
        get
        {
          return base.\u0001;
        }
        set
        {
          base.\u0001 = value;
        }
      }

      public new bool Compressed
      {
        get
        {
          return base.Compressed;
        }
      }
    }
  }
}
