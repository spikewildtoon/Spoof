// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u0018;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace \u0015
{
  internal sealed class \u0015<T> : IEnumerable<T>, IEnumerable, ICollection<T>, IDisposable, \u0014<T> where T : class
  {
    private List<\u0008<T>> \u0001;

    public IEnumerable<T> LiveList
    {
      get
      {
        List<T> objList = new List<T>(this.\u0001.Count);
        objList.AddRange(this.UnsafeLiveList);
        return (IEnumerable<T>) objList;
      }
    }

    public IEnumerable<T> CompleteList
    {
      get
      {
        List<\u0008<T>> source = this.\u0001;
        if (\u0015.\u0015<T>.\u0001 == null)
          \u0015.\u0015<T>.\u0001 = (List<\u0008<T>>) (x => x.Target);
        List<\u0008<T>> objList = \u0015.\u0015<T>.\u0001;
        return source.Select<\u0008<T>, T>((Func<\u0008<T>, T>) objList);
      }
    }

    public IEnumerable<T> LiveListWithoutPurge
    {
      get
      {
        IEnumerable<T> completeList = this.CompleteList;
        if (\u0015.\u0015<T>.\u0001 == null)
          \u0015.\u0015<T>.\u0001 = (List<\u0008<T>>) (x => (object) x != null);
        List<\u0008<T>> objList = \u0015.\u0015<T>.\u0001;
        return completeList.Where<T>((Func<T, bool>) objList);
      }
    }

    public int CompleteCount
    {
      get
      {
        return this.\u0001.Count;
      }
    }

    public int DeadCount
    {
      get
      {
        return this.CompleteList.Count<T>((Func<T, bool>) (x => (object) x == null));
      }
    }

    public int LiveCount
    {
      get
      {
        return this.UnsafeLiveList.Count<T>();
      }
    }

    public int LiveCountWithoutPurge
    {
      get
      {
        return this.CompleteList.Count<T>((Func<T, bool>) (x => (object) x != null));
      }
    }

    int ICollection<T>.Count
    {
      get
      {
        return this.LiveCount;
      }
    }

    bool ICollection<T>.IsReadOnly
    {
      get
      {
        return false;
      }
    }

    private IEnumerable<T> UnsafeLiveList
    {
      get
      {
        return (IEnumerable<T>) new \u0015.\u0015<T>.\u0001(-2) { \u0001 = (T) this };
      }
    }

    public \u0015()
    {
      this.\u0001 = new List<\u0008<T>>();
    }

    public void Add(T item)
    {
      this.\u0001.Add(new \u0008<T>(item));
    }

    public bool Remove(T item)
    {
      for (int index = 0; index != this.\u0001.Count; ++index)
      {
        \u0008<T> obj = this.\u0001[index];
        if ((object) obj.Target == (object) item)
        {
          this.\u0001.RemoveAt(index);
          obj.Dispose();
          return true;
        }
      }
      return false;
    }

    public void \u009C\u0002()
    {
      IEnumerator<T> enumerator = this.UnsafeLiveList.GetEnumerator();
      do
        ;
      while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator));
    }

    public void Dispose()
    {
      this.Clear();
    }

    public void Clear()
    {
      foreach (\u0008<T> obj in this.\u0001)
        obj.Dispose();
      this.\u0001.Clear();
    }

    bool ICollection<T>.\u001D\u0005(T item)
    {
      return this.LiveListWithoutPurge.Contains<T>(item);
    }

    void ICollection<T>.\u001D\u0005(T[] array, int arrayIndex)
    {
      List<T> objList = new List<T>(this.\u0001.Count);
      objList.AddRange(this.UnsafeLiveList);
      objList.CopyTo(array, arrayIndex);
    }

    IEnumerator<T> IEnumerable<T>.\u001D\u0005()
    {
      return this.LiveList.GetEnumerator();
    }

    IEnumerator IEnumerable.\u001D\u0005()
    {
      return (IEnumerator) ((IEnumerable<T>) this).GetEnumerator();
    }
  }
}
