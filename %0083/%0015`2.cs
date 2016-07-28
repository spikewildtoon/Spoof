// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0083;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace \u0083
{
  internal sealed class \u0015<Key, Value> : IEnumerable<KeyValuePair<Key, Value>>, IEnumerable, ICollection<KeyValuePair<Key, Value>>, IDictionary<Key, Value>
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IEqualityComparer<Key> \u0001;
    private int \u0001;
    private List<KeyValuePair<Key, Value>> \u0001;
    private Dictionary<Key, Value> \u0001;
    private bool \u0001;

    public bool IsReadOnly
    {
      [DebuggerStepThrough] get
      {
        return (bool) this.\u0001;
      }
    }

    public KeyValuePair<Key, Value> this[int index]
    {
      [DebuggerStepThrough] get
      {
        return this.objectsArray[index];
      }
      [DebuggerStepThrough] set
      {
        this.\u001D\u0005();
        if (index < 0 || index >= this.objectsArray.Count)
          throw new ArgumentOutOfRangeException(\u0006.\u001D\u0005(96813));
        this.objectsTable.Remove(this.objectsArray[index].Key);
        this.objectsArray[index] = value;
        this.objectsTable.Add(value.Key, value.Value);
      }
    }

    public Value this[Key key]
    {
      [DebuggerStepThrough] get
      {
        return this.objectsTable[key];
      }
      [DebuggerStepThrough] set
      {
        this.\u001D\u0005();
        if (!this.objectsTable.ContainsKey(key))
        {
          this.Add(key, value);
        }
        else
        {
          this.objectsTable[key] = value;
          this.objectsArray[this.\u001D\u0005(key)] = new KeyValuePair<Key, Value>(key, value);
        }
      }
    }

    private List<KeyValuePair<Key, Value>> objectsArray
    {
      [DebuggerStepThrough] get
      {
        if (this.\u0001 == null)
          goto label_2;
label_1:
        return (List<KeyValuePair<Key, Value>>) this.\u0001;
label_2:
        this.\u0001 = (\u0002) new List<KeyValuePair<Key, Value>>((int) this.\u0001);
        goto label_1;
      }
    }

    private Dictionary<Key, Value> objectsTable
    {
      [DebuggerStepThrough] get
      {
        if (this.\u0001 == null)
          goto label_2;
label_1:
        return (Dictionary<Key, Value>) this.\u0001;
label_2:
        this.\u0001 = (\u0002) new Dictionary<Key, Value>((int) this.\u0001, (IEqualityComparer<Key>) this.\u0001);
        goto label_1;
      }
    }

    public ICollection<Key> Keys
    {
      [DebuggerStepThrough] get
      {
        List<KeyValuePair<Key, Value>> objectsArray = this.objectsArray;
        if (\u0015<Key, Value>.\u0001 == null)
          \u0015<Key, Value>.\u0001 = (\u0002) (item => item.Key);
        \u0002 obj = \u0015<Key, Value>.\u0001;
        return (ICollection<Key>) objectsArray.Select<KeyValuePair<Key, Value>, Key>((Func<KeyValuePair<Key, Value>, Key>) obj).ToArray<Key>();
      }
    }

    public ICollection<Value> Values
    {
      [DebuggerStepThrough] get
      {
        List<KeyValuePair<Key, Value>> objectsArray = this.objectsArray;
        if (\u0015<Key, Value>.\u0001 == null)
          \u0015<Key, Value>.\u0001 = (\u0002) (item => item.Value);
        \u0002 obj = \u0015<Key, Value>.\u0001;
        return (ICollection<Value>) objectsArray.Select<KeyValuePair<Key, Value>, Value>((Func<KeyValuePair<Key, Value>, Value>) obj).ToArray<Value>();
      }
    }

    public int Count
    {
      [DebuggerStepThrough] get
      {
        return this.objectsArray.Count;
      }
    }

    static \u0015()
    {
      \u0004.\u001D\u0005(typeof (\u0015<,>));
    }

    [DebuggerStepThrough]
    public \u0015()
      : this(0)
    {
    }

    [DebuggerStepThrough]
    public \u0015(IEqualityComparer<Key> comparer)
      : this(0, comparer)
    {
    }

    [DebuggerStepThrough]
    private \u0015(\u0015<Key, Value> dictionary)
    {
      if (dictionary == null)
        throw new ArgumentNullException(\u0006.\u001D\u0005(96741));
      this.\u0001 = (\u0002) 1;
      this.\u0001 = dictionary.\u0001;
      this.\u0001 = dictionary.\u0001;
      this.\u0001 = dictionary.\u0001;
      this.\u0001 = dictionary.\u0001;
    }

    [DebuggerStepThrough]
    public \u0015(int capacity)
      : this(capacity, (IEqualityComparer<Key>) null)
    {
    }

    [DebuggerStepThrough]
    public \u0015(int capacity, IEqualityComparer<Key> comparer)
    {
      this.\u0001 = (\u0002) capacity;
      this.\u0001 = (\u0002) comparer;
    }

    [DebuggerStepThrough]
    public void Add(Key key, Value value)
    {
      this.\u001D\u0005();
      this.objectsTable.Add(key, value);
      this.objectsArray.Add(new KeyValuePair<Key, Value>(key, value));
    }

    [DebuggerStepThrough]
    public void Add(KeyValuePair<Key, Value> item)
    {
      this.\u001D\u0005();
      this.objectsTable.Add(item.Key, item.Value);
      this.objectsArray.Add(item);
    }

    [DebuggerStepThrough]
    public bool Contains(KeyValuePair<Key, Value> item)
    {
      return this.objectsTable.ContainsKey(item.Key) && this.objectsTable[item.Key].Equals((object) item.Value);
    }

    [DebuggerStepThrough]
    public bool ContainsKey(Key key)
    {
      return this.objectsTable.ContainsKey(key);
    }

    [DebuggerStepThrough]
    public bool \u001D\u0005(Value value)
    {
      return this.objectsTable.ContainsValue(value);
    }

    [DebuggerStepThrough]
    private int \u001D\u0005(Value value)
    {
      for (int index = 0; index < this.objectsArray.Count; ++index)
      {
        if (this.objectsArray[index].Value.Equals((object) value))
          return index;
      }
      return -1;
    }

    [DebuggerStepThrough]
    private int \u001D\u0005(Key key)
    {
      for (int index = 0; index < this.objectsArray.Count; ++index)
      {
        KeyValuePair<Key, Value> keyValuePair = this.objectsArray[index];
        if (this.\u0001 == null)
        {
          if (keyValuePair.Key.Equals((object) key))
            return index;
          continue;
        }
        if (((IEqualityComparer<Key>) this.\u0001).Equals(keyValuePair.Key, key))
          return index;
      }
      return -1;
    }

    public int \u001E\u0005(Key key)
    {
      return this.\u001D\u0005(key);
    }

    [DebuggerStepThrough]
    public bool Remove(KeyValuePair<Key, Value> item)
    {
      this.\u001D\u0005();
      if (!this.ContainsKey(item.Key) || !this.objectsTable[item.Key].Equals((object) item.Value))
        return false;
      this.Remove(item.Key);
      return true;
    }

    [DebuggerStepThrough]
    public bool Remove(Key key)
    {
      this.\u001D\u0005();
      if ((object) key == null)
        throw new ArgumentNullException(\u0006.\u001D\u0005(96799));
      int index = this.\u001D\u0005(key);
      if (index < 0)
        return false;
      this.objectsTable.Remove(key);
      this.objectsArray.RemoveAt(index);
      return true;
    }

    [DebuggerStepThrough]
    public bool Remove(Value value)
    {
      this.\u001D\u0005();
      if ((object) value == null)
        throw new ArgumentNullException(\u0006.\u001D\u0005(96804));
      int index = this.\u001D\u0005(value);
      if (index < 0)
        return false;
      this.objectsTable.Remove(this.objectsArray[index].Key);
      this.objectsArray.RemoveAt(index);
      return true;
    }

    [DebuggerStepThrough]
    public void \u001D\u0005(int index)
    {
      this.\u001D\u0005();
      if (index >= this.Count || index < 0)
        throw new ArgumentOutOfRangeException(\u0006.\u001D\u0005(96813));
      KeyValuePair<Key, Value> keyValuePair = this.objectsArray[index];
      this.objectsArray.RemoveAt(index);
      this.objectsTable.Remove(keyValuePair.Key);
    }

    [DebuggerStepThrough]
    public IEnumerator<KeyValuePair<Key, Value>> GetEnumerator()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator<KeyValuePair<Key, Value>>) new \u0015<Key, Value>.\u0001(0)
      {
        \u0001 = (KeyValuePair<Key, Value>) this
      };
    }

    [DebuggerStepThrough]
    IEnumerator IEnumerable.\u001D\u0005()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    [DebuggerStepThrough]
    private void \u001D\u0005()
    {
      if (this.\u0001 != null)
        throw new NotSupportedException(\u0006.\u001D\u0005(96822));
    }

    [DebuggerStepThrough]
    public \u0015<Key, Value> \u001D\u0005()
    {
      return new \u0015<Key, Value>(this);
    }

    [DebuggerStepThrough]
    public void Clear()
    {
      this.\u001D\u0005();
      this.objectsTable.Clear();
      this.objectsArray.Clear();
    }

    [DebuggerStepThrough]
    public bool TryGetValue(Key key, out Value value)
    {
      return this.objectsTable.TryGetValue(key, out value);
    }

    [DebuggerStepThrough]
    public void \u001D\u0005(int index, Key key, Value value)
    {
      this.\u001D\u0005();
      if ((object) key == null)
        throw new ArgumentNullException(\u0006.\u001D\u0005(96799));
      if (index > this.Count || index < 0)
        throw new ArgumentOutOfRangeException(\u0006.\u001D\u0005(96813));
      this.objectsArray.Insert(index, new KeyValuePair<Key, Value>(key, value));
      this.objectsTable.Add(key, value);
    }

    [DebuggerStepThrough]
    void ICollection<KeyValuePair<Key, Value>>.\u001D\u0005(KeyValuePair<Key, Value>[] array, int arrayIndex)
    {
      if (array == null)
        throw new ArgumentNullException(\u0006.\u001D\u0005(96855));
      if (arrayIndex < 0 || arrayIndex > array.Length)
        throw new IndexOutOfRangeException(\u0006.\u001D\u0005(96864));
      if (array.Length - arrayIndex < this.Count)
        throw new ArgumentException(\u0006.\u001D\u0005(96913));
      int count = this.Count;
      List<KeyValuePair<Key, Value>> keyValuePairList = (List<KeyValuePair<Key, Value>>) this.\u0001;
      for (int index = 0; index < count; ++index)
        array[arrayIndex++] = keyValuePairList[index];
    }
  }
}
