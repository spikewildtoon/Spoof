// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001B;
using \u001D;
using System;
using System.Collections;
using System.Collections.Generic;

namespace \u001D
{
  internal sealed class \u007F<TObjectType, TOwnerType> : IEnumerable, ICollection<TObjectType>, IEnumerable<TObjectType>, ICollection, IList<TObjectType>, IList where TObjectType : \u001F<TObjectType>, new() where TOwnerType : \u0014.\u001D<TObjectType>
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private List<TObjectType> \u0001;
    private readonly TOwnerType \u0001;

    public TObjectType this[int index]
    {
      get
      {
        return ((List<TObjectType>) this.\u0001)[index];
      }
      set
      {
        if (((List<TObjectType>) this.\u0001)[index].Equals((object) value))
          return;
        TObjectType objectType = ((List<TObjectType>) this.\u0001)[index];
        ((TOwnerType) this.\u0001).\u0002(objectType);
        ((List<TObjectType>) this.\u0001)[index] = value;
        value.Owner = (\u0014.\u001D<TObjectType>) this.\u0001;
        objectType.Owner = (\u0014.\u001D<TObjectType>) null;
        ((TOwnerType) this.\u0001).\u0001(((List<TObjectType>) this.\u0001)[index]);
      }
    }

    object IList.this[int index]
    {
      get
      {
        return (object) this[index];
      }
      set
      {
        this[index] = (TObjectType) value;
      }
    }

    int ICollection.Count
    {
      get
      {
        return this.Count;
      }
    }

    public int Count
    {
      get
      {
        return ((List<TObjectType>) this.\u0001).Count;
      }
    }

    int ICollection<TObjectType>.Count
    {
      get
      {
        return this.Count;
      }
    }

    bool ICollection<TObjectType>.IsReadOnly
    {
      get
      {
        return this.IsReadOnly;
      }
    }

    public bool IsReadOnly
    {
      get
      {
        return false;
      }
    }

    bool IList.IsReadOnly
    {
      get
      {
        return false;
      }
    }

    bool IList.IsFixedSize
    {
      get
      {
        return false;
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
        return \u0005\u007F.\u007E\u0016\u0092((object) this.\u0001);
      }
    }

    static \u007F()
    {
      \u0004.\u001D\u0005(typeof (\u007F<,>));
    }

    public \u007F(TOwnerType owner)
    {
      this.\u0001 = (\u0002) new List<TObjectType>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      if ((object) owner == null)
        throw new ArgumentNullException(\u0006.\u001D\u0005(60566));
      this.\u0001 = (\u0002) owner;
    }

    public int IndexOf(TObjectType item)
    {
      return ((List<TObjectType>) this.\u0001).IndexOf(item);
    }

    int IList.\u001D\u0005(object value)
    {
      return this.IndexOf((TObjectType) value);
    }

    public void Insert(int index, TObjectType item)
    {
      ((List<TObjectType>) this.\u0001).Insert(index, item);
      item.Owner = (\u0014.\u001D<TObjectType>) this.\u0001;
    }

    void IList.\u001D\u0005(int index, object value)
    {
      this.Insert(index, (TObjectType) value);
    }

    public void RemoveAt(int index)
    {
      TObjectType objectType = ((List<TObjectType>) this.\u0001)[index];
      ((List<TObjectType>) this.\u0001).RemoveAt(index);
      objectType.Owner = (\u0014.\u001D<TObjectType>) null;
    }

    void IList.\u001D\u0005(int index)
    {
      this.RemoveAt(index);
    }

    public void Add(TObjectType item)
    {
      ((List<TObjectType>) this.\u0001).Add(item);
      item.Owner = (\u0014.\u001D<TObjectType>) this.\u0001;
      ((TOwnerType) this.\u0001).\u0001(item);
    }

    int IList.\u001E\u0005(object item)
    {
      this.Add((TObjectType) item);
      return ((List<TObjectType>) this.\u0001).Count - 1;
    }

    void ICollection<TObjectType>.\u001D\u0005(TObjectType item)
    {
      this.Add(item);
    }

    void IList.\u001D\u0005()
    {
      this.Clear();
    }

    void ICollection<TObjectType>.\u001E\u0005()
    {
      this.Clear();
    }

    public void Clear()
    {
      TObjectType[] array = new TObjectType[((List<TObjectType>) this.\u0001).Count];
      ((List<TObjectType>) this.\u0001).CopyTo(array);
      ((List<TObjectType>) this.\u0001).Clear();
      foreach (TObjectType objectType in array)
      {
        objectType.Owner = (\u0014.\u001D<TObjectType>) null;
        ((TOwnerType) this.\u0001).\u0002(objectType);
      }
    }

    public bool Remove(TObjectType item)
    {
      if (!((List<TObjectType>) this.\u0001).Remove(item))
        return false;
      ((TOwnerType) this.\u0001).\u0002(item);
      return true;
    }

    bool ICollection<TObjectType>.\u001D\u0005(TObjectType item)
    {
      return this.Remove(item);
    }

    void IList.\u001D\u0005(object value)
    {
      this.Remove((TObjectType) value);
    }

    public bool Contains(TObjectType item)
    {
      return ((List<TObjectType>) this.\u0001).Contains(item);
    }

    bool ICollection<TObjectType>.\u001E\u0005(TObjectType item)
    {
      return this.Contains(item);
    }

    bool IList.\u001D\u0005(object value)
    {
      return this.Contains((TObjectType) value);
    }

    void ICollection<TObjectType>.\u001D\u0005(TObjectType[] array, int arrayIndex)
    {
      ((List<TObjectType>) this.\u0001).CopyTo(array, arrayIndex);
    }

    void ICollection.\u001D\u0005(Array array, int index)
    {
      \u0083\u0081.\u007E\u008C\u0092((object) ((List<TObjectType>) this.\u0001).ToArray(), array, index);
    }

    public IEnumerator<TObjectType> GetEnumerator()
    {
      return (IEnumerator<TObjectType>) ((List<TObjectType>) this.\u0001).GetEnumerator();
    }

    IEnumerator IEnumerable.\u001D\u0005()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    IEnumerator<TObjectType> IEnumerable<TObjectType>.\u001D\u0005()
    {
      return this.GetEnumerator();
    }
  }
}
