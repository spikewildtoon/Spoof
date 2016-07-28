// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001D;
using \u0080;
using \u0084;
using System;
using System.Collections.Generic;
using System.IO;
using TSN.IO;

namespace \u0084
{
  internal sealed class \u0007
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly int \u0001;
    private static readonly string \u0001;
    public readonly Dictionary<string, \u0016> \u0001;

    static \u0007()
    {
      \u0004.\u001D\u0005(typeof (\u0007));
      \u0007.\u0001 = 1;
      \u0007.\u0001 = \u0007.\u0001(106118);
    }

    public \u0007()
    {
      this.\u0001 = new Dictionary<string, \u0016>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
    }

    public void \u001D\u0005(BinaryWriter writer)
    {
      \u0092\u0081.\u007E\u001A\u009E((object) writer, \u0007.\u0001);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, \u0007.\u0001);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.\u0001.Count);
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) this.\u0001), ref flag);
        foreach (KeyValuePair<string, \u0016> keyValuePair in this.\u0001)
        {
          \u0092\u0081.\u007E\u001A\u009E((object) writer, keyValuePair.Key);
          writer.\u001D\u0005(keyValuePair.Value);
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    public static \u0007 \u001D\u0005(BinaryReader reader)
    {
      string actualHeader = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      if (\u0008\u001F.\u009B\u0092(actualHeader, \u0007.\u0001))
        throw new InvalidFileType(\u0007.\u0001, actualHeader);
      int actualVersion = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      if (actualVersion != 1)
        throw new InvalidFileVersion<int>(1, 1, actualVersion);
      \u0007 obj = new \u0007();
      int num = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index = 0; index < num; ++index)
        obj.\u0001.Add(\u0002\u007F.\u007E\u0001\u009E((object) reader), reader.\u001D\u0005());
      return obj;
    }
  }
}
