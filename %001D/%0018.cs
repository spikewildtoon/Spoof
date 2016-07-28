// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001D;
using \u0080;
using System;
using System.Collections;
using System.Collections.Generic;
using TSN.Collections;

namespace \u001D
{
  internal sealed class \u0018 : IEnumerable, IEnumerable<KeyValuePair<string, \u0018.\u0001>>
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private Dictionary<string, \u0018.\u0001> \u0001;
    private ReadOnlyDictionary<string, \u0018.\u0001> \u0001;

    public ReadOnlyDictionary<string, \u0018.\u0001> Files
    {
      get
      {
        if (this.\u0001 == null)
          goto label_2;
label_1:
        return this.\u0001;
label_2:
        this.\u0001 = new ReadOnlyDictionary<string, \u0018.\u0001>((IDictionary<string, \u0018.\u0001>) this.\u0001);
        goto label_1;
      }
    }

    static \u0018()
    {
      \u0004.\u001D\u0005(typeof (\u0018));
    }

    public \u0018()
    {
      this.\u0001 = new Dictionary<string, \u0018.\u0001>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
    }

    public void \u001D\u0005(string data)
    {
      \u0093\u0082 obj1 = \u0093\u0082.\u007E\u0003\u0093;
      string str = data;
      char[] chArray = new char[1]{ '\n' };
      int num = 1;
      foreach (string line in obj1((object) str, chArray, (StringSplitOptions) num))
      {
        string fileName;
        long expectedSize;
        \u0016 expectedHash;
        if (\u0018.\u001D\u0005(line, out fileName, out expectedSize, out expectedHash) && \u0018.\u001D\u0005(fileName))
        {
          \u0018.\u0001 obj2 = new \u0018.\u0001(expectedSize, expectedHash);
          if (this.\u0001.ContainsKey(fileName))
            this.\u0001[fileName] = obj2;
          else
            this.\u0001.Add(fileName, obj2);
        }
      }
    }

    private static bool \u001D\u0005(string line, out string fileName, out long expectedSize, out \u0016 expectedHash)
    {
      fileName = (string) null;
      expectedSize = 0L;
      expectedHash = new \u0016();
      int startIndex = 0;
      string str;
      string hash;
      long num;
      if (!line.\u001D\u0005(' ', ref startIndex, out str) || !line.\u001D\u0005(' ', ref startIndex, out hash) || (!\u0097\u001F.\u001B\u0096(hash, ref num) || !line.\u001D\u0005(ref startIndex, out hash) || !hash.\u001F\u0005()))
        return false;
      fileName = str;
      expectedSize = num;
      expectedHash = new \u0016(hash);
      return true;
    }

    private static bool \u001D\u0005(string fileName)
    {
      string str;
      return (str = \u0002\u007F.\u007E\u0019\u0093((object) \u009C\u0080.\u0006\u009F(fileName))) == null || !\u0008\u001F.\u009A\u0092(str, \u0018.\u0001(64152)) && !\u0008\u001F.\u009A\u0092(str, \u0018.\u0001(64161));
    }

    public IEnumerator<KeyValuePair<string, \u0018.\u0001>> GetEnumerator()
    {
      return (IEnumerator<KeyValuePair<string, \u0018.\u0001>>) this.\u0001.GetEnumerator();
    }

    IEnumerator IEnumerable.\u001D\u0005()
    {
      return (IEnumerator) this.\u0001.GetEnumerator();
    }

    internal struct \u0001
    {
      private long \u0001;
      private \u0016 \u0001;

      public long ExpectedSize
      {
        get
        {
          return this.\u0001;
        }
      }

      public \u0016 ExpectedHash
      {
        get
        {
          return this.\u0001;
        }
      }

      public \u0001(long expectedSize, \u0016 expectedHash)
      {
        this.\u0001 = expectedSize;
        this.\u0001 = expectedHash;
      }
    }
  }
}
