// Decompiled with JetBrains decompiler
// Type: TSN.Collections.ReadOnlyDictionary`2
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0084;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TSN.Collections
{
  [DebuggerDisplay("Count = {Count}")]
  [ComVisible(false)]
  [DebuggerTypeProxy(typeof (\u0012<,>))]
  [Serializable]
  public sealed class ReadOnlyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, ICollection, IEnumerable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private readonly IDictionary<TKey, TValue> m_dicSource;
    private object m_objSyncRoot;

    public int Count
    {
      get
      {
        return this.m_dicSource.Count;
      }
    }

    public ICollection<TKey> Keys
    {
      get
      {
        return this.m_dicSource.Keys;
      }
    }

    public ICollection<TValue> Values
    {
      get
      {
        return this.m_dicSource.Values;
      }
    }

    bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
    {
      get
      {
        return true;
      }
    }

    bool ICollection.IsSynchronized
    {
      get
      {
        return false;
      }
    }

    object ICollection.SyncRoot
    {
      get
      {
        if (this.m_objSyncRoot == null)
          goto label_3;
label_2:
        return this.m_objSyncRoot;
label_3:
        ICollection collection = this.m_dicSource as ICollection;
        if (collection == null)
        {
          object obj = \u001D\u001C.\u001F\u0098(ref this.m_objSyncRoot, new object(), (object) null);
          goto label_2;
        }
        else
        {
          this.m_objSyncRoot = \u0005\u007F.\u007E\u0016\u0092((object) collection);
          goto label_2;
        }
      }
    }

    public TValue this[TKey key]
    {
      get
      {
        return this.m_dicSource[key];
      }
      set
      {
        ReadOnlyDictionary<TKey, TValue>.\u001E\u0005();
      }
    }

    static ReadOnlyDictionary()
    {
      \u0004.\u001D\u0005(typeof (ReadOnlyDictionary<,>));
    }

    public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
    {
      if (dictionary == null)
        throw new ArgumentNullException(\u0006.\u001D\u0005(96741));
      this.m_dicSource = dictionary;
    }

    void IDictionary<TKey, TValue>.\u001D\u0005(TKey key, TValue value)
    {
      ReadOnlyDictionary<TKey, TValue>.\u001E\u0005();
    }

    public bool ContainsKey(TKey key)
    {
      return this.m_dicSource.ContainsKey(key);
    }

    bool IDictionary<TKey, TValue>.\u001D\u0005(TKey key)
    {
      ReadOnlyDictionary<TKey, TValue>.\u001E\u0005();
      return false;
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
      return this.m_dicSource.TryGetValue(key, out value);
    }

    void ICollection<KeyValuePair<TKey, TValue>>.\u001D\u0005(KeyValuePair<TKey, TValue> item)
    {
      ReadOnlyDictionary<TKey, TValue>.\u001E\u0005();
    }

    void ICollection<KeyValuePair<TKey, TValue>>.\u001D\u0005()
    {
      ReadOnlyDictionary<TKey, TValue>.\u001E\u0005();
    }

    bool ICollection<KeyValuePair<TKey, TValue>>.\u001D\u0005(KeyValuePair<TKey, TValue> item)
    {
      return this.m_dicSource.Contains(item);
    }

    void ICollection<KeyValuePair<TKey, TValue>>.\u001D\u0005(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
      this.m_dicSource.CopyTo(array, arrayIndex);
    }

    bool ICollection<KeyValuePair<TKey, TValue>>.\u001E\u0005(KeyValuePair<TKey, TValue> item)
    {
      ReadOnlyDictionary<TKey, TValue>.\u001E\u0005();
      return false;
    }

    IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.\u001D\u0005()
    {
      return this.m_dicSource.GetEnumerator();
    }

    IEnumerator IEnumerable.\u001D\u0005()
    {
      return (IEnumerator) this.m_dicSource.GetEnumerator();
    }

    void ICollection.\u001D\u0005(Array array, int index)
    {
      ICollection collection = (ICollection) new List<KeyValuePair<TKey, TValue>>((IEnumerable<KeyValuePair<TKey, TValue>>) this.m_dicSource);
      \u0083\u0081.\u007E\u0014\u0092((object) collection, array, index);
    }

    private static void \u001E\u0005()
    {
      throw new NotSupportedException(\u0006.\u001D\u0005(96758));
    }
  }
}
