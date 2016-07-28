// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u0019;
using \u001B;
using \u007F;
using \u0082;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace \u001B
{
  internal sealed class \u000F<T>
  {
    private EventHandler<\u001F<T>> \u0001;
    private EventHandler<\u000F> \u0001;
    private EventHandler<\u0010<T>> \u0001;
    private readonly Dictionary<T, \u000F<T>.\u0001> \u0001;
    private readonly List<T> \u0001;
    private readonly List<\u000F<T>.\u0001> \u0001;
    private readonly int \u0001;

    public IEnumerable<T> this[int group]
    {
      get
      {
        return ((List<\u000F<T>.\u0001>) this.\u0001)[group].\u0001.AsEnumerable<T>();
      }
    }

    public int Groups
    {
      get
      {
        return ((List<\u000F<T>.\u0001>) this.\u0001).Count;
      }
    }

    public int Elements
    {
      get
      {
        return ((List<T>) this.\u0001).Count;
      }
    }

    public event EventHandler<\u0005<T>> ItemAdded;

    public event EventHandler<\u001F<T>> ItemRemoved
    {
      add
      {
        EventHandler<\u001F<T>> eventHandler = (EventHandler<\u001F<T>>) this.\u0001;
        EventHandler<\u001F<T>> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<\u001F<T>>>((EventHandler<\u001F<T>>&) @this.\u0001, (EventHandler<\u001F<T>>) \u000F\u0084.\u009C\u0091((Delegate) comparand, (Delegate) value), comparand);
        }
        while (eventHandler != comparand);
      }
      remove
      {
        EventHandler<\u001F<T>> eventHandler = (EventHandler<\u001F<T>>) this.\u0001;
        EventHandler<\u001F<T>> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<\u001F<T>>>((EventHandler<\u001F<T>>&) @this.\u0001, (EventHandler<\u001F<T>>) \u000F\u0084.\u009D\u0091((Delegate) comparand, (Delegate) value), comparand);
        }
        while (eventHandler != comparand);
      }
    }

    public event EventHandler<\u000F> GroupCreated
    {
      add
      {
        EventHandler<\u000F> eventHandler = (EventHandler<\u000F>) this.\u0001;
        EventHandler<\u000F> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<\u000F>>((EventHandler<\u000F>&) @this.\u0001, (EventHandler<\u000F>) \u000F\u0084.\u009C\u0091((Delegate) comparand, (Delegate) value), comparand);
        }
        while (eventHandler != comparand);
      }
      remove
      {
        EventHandler<\u000F> eventHandler = (EventHandler<\u000F>) this.\u0001;
        EventHandler<\u000F> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<\u000F>>((EventHandler<\u000F>&) @this.\u0001, (EventHandler<\u000F>) \u000F\u0084.\u009D\u0091((Delegate) comparand, (Delegate) value), comparand);
        }
        while (eventHandler != comparand);
      }
    }

    public event EventHandler<\u000F> GroupDestroyed;

    public event EventHandler<\u0010<T>> ItemMoved
    {
      add
      {
        EventHandler<\u0010<T>> eventHandler = (EventHandler<\u0010<T>>) this.\u0001;
        EventHandler<\u0010<T>> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<\u0010<T>>>((EventHandler<\u0010<T>>&) @this.\u0001, (EventHandler<\u0010<T>>) \u000F\u0084.\u009C\u0091((Delegate) comparand, (Delegate) value), comparand);
        }
        while (eventHandler != comparand);
      }
      remove
      {
        EventHandler<\u0010<T>> eventHandler = (EventHandler<\u0010<T>>) this.\u0001;
        EventHandler<\u0010<T>> comparand;
        do
        {
          comparand = eventHandler;
          eventHandler = Interlocked.CompareExchange<EventHandler<\u0010<T>>>((EventHandler<\u0010<T>>&) @this.\u0001, (EventHandler<\u0010<T>>) \u000F\u0084.\u009D\u0091((Delegate) comparand, (Delegate) value), comparand);
        }
        while (eventHandler != comparand);
      }
    }

    public \u000F(int maxItemsPerGroup)
    {
      this.\u0001 = (EventHandler<\u0005<T>>) new List<\u000F<T>.\u0001>();
      this.\u0001 = (EventHandler<\u0005<T>>) new List<T>();
      this.\u0001 = (EventHandler<\u0005<T>>) new Dictionary<T, \u000F<T>.\u0001>();
      this.\u0001 = (EventHandler<\u0005<T>>) maxItemsPerGroup;
    }

    public void \u001D\u0005(T item)
    {
      \u000F<T>.\u0001 obj = (\u000F<T>.\u0001) null;
      bool flag = false;
      if (((List<\u000F<T>.\u0001>) this.\u0001).Count > 0)
        goto label_9;
label_3:
      if (obj == null)
      {
        obj = new \u000F<T>.\u0001();
        ((List<\u000F<T>.\u0001>) this.\u0001).Add(obj);
        flag = true;
      }
      int group = ((List<\u000F<T>.\u0001>) this.\u0001).Count - 1;
      obj.\u0001.Add(item);
      ((Dictionary<T, \u000F<T>.\u0001>) this.\u0001).Add(item, obj);
      ((List<T>) this.\u0001).Add(item);
      if (flag && this.\u0001 != null)
        ((EventHandler<\u000F>) this.\u0001)((object) this, new \u000F(group));
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0005<T>(item, group));
      return;
label_9:
      obj = ((IEnumerable<\u000F<T>.\u0001>) this.\u0001).Last<\u000F<T>.\u0001>();
      if (obj.\u0001.Count == this.\u0001)
      {
        obj = (\u000F<T>.\u0001) null;
        goto label_3;
      }
      else
        goto label_3;
    }

    public void \u001E\u0005(T item)
    {
      \u000F<T>.\u0001 obj1 = ((Dictionary<T, \u000F<T>.\u0001>) this.\u0001)[item];
      int removedIndex = ((List<T>) this.\u0001).IndexOf(item);
      ((Dictionary<T, \u000F<T>.\u0001>) this.\u0001).Remove(item);
      ((List<T>) this.\u0001).Remove(item);
      obj1.\u0001.Remove(item);
      int num = ((List<\u000F<T>.\u0001>) this.\u0001).IndexOf(obj1);
      int newGroup = num;
      for (int previousGroup = num + 1; previousGroup < ((List<\u000F<T>.\u0001>) this.\u0001).Count; ++previousGroup)
      {
        \u000F<T>.\u0001 obj2 = ((List<\u000F<T>.\u0001>) this.\u0001)[previousGroup];
        \u000F<T>.\u0001 obj3 = ((List<\u000F<T>.\u0001>) this.\u0001)[newGroup];
        T index = obj2.\u0001[0];
        obj2.\u0001.RemoveAt(0);
        obj3.\u0001.Add(index);
        ((Dictionary<T, \u000F<T>.\u0001>) this.\u0001)[index] = obj3;
        if (this.\u0001 != null)
          ((EventHandler<\u0010<T>>) this.\u0001)((object) this, new \u0010<T>(index, previousGroup, newGroup));
        ++newGroup;
      }
      if (this.\u0001 != null)
        ((EventHandler<\u001F<T>>) this.\u0001)((object) this, new \u001F<T>(item, removedIndex, num));
      \u000F<T>.\u0001 obj4 = ((IEnumerable<\u000F<T>.\u0001>) this.\u0001).Last<\u000F<T>.\u0001>();
      if (obj4.\u0001.Count != 0)
        return;
      ((List<\u000F<T>.\u0001>) this.\u0001).Remove(obj4);
      if (this.\u0002 == null)
        return;
      this.\u0002((object) this, new \u000F(num));
    }

    public int \u001D\u0005(T item)
    {
      return ((List<\u000F<T>.\u0001>) this.\u0001).IndexOf(((Dictionary<T, \u000F<T>.\u0001>) this.\u0001)[item]);
    }

    public int \u001E\u0005(T item)
    {
      return ((List<T>) this.\u0001).IndexOf(item);
    }

    public T \u001D\u0005(int index)
    {
      return ((List<T>) this.\u0001)[index];
    }

    private sealed class \u0001
    {
      public readonly List<T> \u0001;

      public \u0001()
      {
        this.\u0001 = new List<T>();
      }
    }
  }
}
