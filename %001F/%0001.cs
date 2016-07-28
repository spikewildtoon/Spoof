// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u001A;
using \u001D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace \u001F
{
  internal sealed class \u0001 : \u0080
  {
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
        return new byte[3]{ (byte) 87, (byte) 80, (byte) 83 };
      }
    }

    public Dictionary<\u0019, Dictionary<PointF, \u007F.\u007F>> WayPoints { get; private set; }

    public \u0001(string filePath)
      : base(filePath)
    {
    }

    public \u0001()
    {
      this.WayPoints = new Dictionary<\u0019, Dictionary<PointF, \u007F.\u007F>>();
    }

    public \u0001(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.WayPoints = new Dictionary<\u0019, Dictionary<PointF, \u007F.\u007F>>();
      ushort num1 = \u0095\u0084.\u007E\u0098\u009D((object) reader);
      for (int index1 = 0; index1 < (int) num1; ++index1)
      {
        \u0019 key1 = (\u0019) \u0095\u0084.\u007E\u0098\u009D((object) reader);
        Dictionary<PointF, \u007F.\u007F> dictionary = new Dictionary<PointF, \u007F.\u007F>();
        ushort num2 = \u0095\u0084.\u007E\u0098\u009D((object) reader);
        for (ushort index2 = 0; (int) index2 < (int) num2; ++index2)
        {
          PointF key2 = reader.\u001D\u0005();
          \u007F.\u007F obj = (\u007F.\u007F) \u0095\u0084.\u007E\u0098\u009D((object) reader);
          if (!dictionary.ContainsKey(key2))
            dictionary.Add(key2, obj);
        }
        if (!this.WayPoints.ContainsKey(key1))
          this.WayPoints.Add(key1, dictionary);
      }
      base.\u001D\u0005(reader, version);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      IEnumerable<KeyValuePair<\u0019, Dictionary<PointF, \u007F.\u007F>>> source = this.WayPoints.Where<KeyValuePair<\u0019, Dictionary<PointF, \u007F.\u007F>>>((Func<KeyValuePair<\u0019, Dictionary<PointF, \u007F.\u007F>>, bool>) (item => item.Value.Count != 0));
      \u0087\u0083.\u007E\u0014\u009E((object) writer, (ushort) source.Count<KeyValuePair<\u0019, Dictionary<PointF, \u007F.\u007F>>>());
      IEnumerator<KeyValuePair<\u0019, Dictionary<PointF, \u007F.\u007F>>> enumerator = source.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          KeyValuePair<\u0019, Dictionary<PointF, \u007F.\u007F>> current = enumerator.Current;
          \u0087\u0083.\u007E\u0014\u009E((object) writer, (ushort) current.Key);
          \u0087\u0083.\u007E\u0014\u009E((object) writer, (ushort) current.Value.Count);
          foreach (KeyValuePair<PointF, \u007F.\u007F> keyValuePair in current.Value)
          {
            writer.\u001D\u0005(keyValuePair.Key);
            \u0087\u0083.\u007E\u0014\u009E((object) writer, (ushort) keyValuePair.Value);
          }
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      base.\u001D\u0005(writer);
    }
  }
}
