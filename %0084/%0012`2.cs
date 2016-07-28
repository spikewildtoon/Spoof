// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0084;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TSN.Collections;

namespace \u0084
{
  internal sealed class \u0012<TKey, TValue>
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IDictionary<TKey, TValue> \u0001;

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public KeyValuePair<TKey, TValue>[] Items
    {
      get
      {
        KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[((ICollection<KeyValuePair<TKey, TValue>>) this.\u0001).Count];
        ((ICollection<KeyValuePair<TKey, TValue>>) this.\u0001).CopyTo(array, 0);
        return array;
      }
    }

    static \u0012()
    {
      \u0004.\u001D\u0005(typeof (\u0012<,>));
    }

    public \u0012(ReadOnlyDictionary<TKey, TValue> dictionary)
    {
      if (dictionary == null)
        throw new ArgumentNullException(\u0006.\u001D\u0005(96741));
      this.\u0001 = (\u0002) dictionary;
    }
  }
}
