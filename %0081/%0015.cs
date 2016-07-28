// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0081;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace \u0081
{
  internal static class \u0015
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0015()
    {
      \u0004.\u001D\u0005(typeof (\u0015));
    }

    public static void \u001D\u0005<T>(this T[] values, int shift)
    {
      int length = values.Length;
      shift %= length;
      if (shift == 0)
        return;
      T[] objArray = new T[length];
      if (shift < 0)
        goto label_4;
label_2:
      int num = length - shift;
      \u0089\u0083.\u0084\u0092((Array) values, 0, (Array) objArray, shift, num);
      \u0089\u0083.\u0084\u0092((Array) values, num, (Array) objArray, 0, shift);
      \u0006\u001D.\u0083\u0092((Array) objArray, (Array) values, length);
      return;
label_4:
      shift = -shift;
      shift = length - shift;
      goto label_2;
    }

    public static void \u001D\u0005<T>(this List<T> list, int shift)
    {
      int count = list.Count;
      shift %= count;
      if (shift == 0)
        return;
      T[] array = list.ToArray();
      \u0015.\u001D\u0005<T>(array, shift);
      list.Clear();
      list.AddRange((IEnumerable<T>) array);
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005<TKey, TValue>(this Dictionary<TKey, TValue> dic, params TKey[] keys)
    {
      if (keys == null)
        throw new ArgumentNullException(\u0015.\u0001(94873));
      if (keys.Length == 0)
        throw new ArgumentException(\u0015.\u0001(94882));
      foreach (TKey key in keys)
      {
        if (!dic.ContainsKey(key))
          return false;
      }
      return true;
    }

    public static bool \u001D\u0005<TKey, TValue>(this Dictionary<TKey, TValue> dic, params TValue[] values)
    {
      if (values == null)
        throw new ArgumentNullException(\u0015.\u0001(94943));
      if (values.Length == 0)
        throw new ArgumentException(\u0015.\u0001(94952));
      List<TValue> objList = new List<TValue>((IEnumerable<TValue>) dic.Values);
      foreach (TValue obj in values)
      {
        if (!objList.Contains(obj))
          return false;
      }
      return true;
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, TValue value)
    {
      if (!dic.ContainsKey(key))
        return false;
      return dic[key].Equals((object) value);
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, Action<KeyValuePair<TKey, TValue>> del)
    {
      if (!dic.ContainsKey(key))
        return false;
      del(new KeyValuePair<TKey, TValue>(key, dic[key]));
      return true;
    }

    [DebuggerStepThrough]
    public static T[] \u001D\u0005<T>(this T[] arr, int startIndex)
    {
      T[] objArray = new T[arr.Length - startIndex];
      \u0089\u0083.\u0084\u0092((Array) arr, startIndex, (Array) objArray, 0, arr.Length - startIndex);
      return objArray;
    }

    [DebuggerStepThrough]
    public static void \u001D\u0005<T>(this IEnumerable<T> col, Action<T> del)
    {
      IEnumerator<T> enumerator = col.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          del(enumerator.Current);
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
    }

    [DebuggerStepThrough]
    public static void \u001D\u0005<T, T2>(this Dictionary<T, T2> dic, IEnumerable<T> items)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      items.\u001D\u0005<T>(new Action<T>((object) new \u0015.\u0001<T, T2>()
      {
        \u0001 = dic
      }, __methodptr(\u001D\u0005)));
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005<T>(this IEnumerable<T> enumeration1, IEnumerable<T> enumeration2)
    {
      IEnumerator<T> enumerator1 = enumeration1.GetEnumerator();
      try
      {
        IEnumerator<T> enumerator2 = enumeration2.GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator2))
          {
            if (!\u0099\u0082.\u007E\u0091\u0092((object) enumerator1) || !enumerator2.Current.Equals((object) enumerator1.Current))
              return false;
          }
          if (\u0099\u0082.\u007E\u0091\u0092((object) enumerator1))
            return false;
        }
        finally
        {
          if (enumerator2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator2);
        }
      }
      finally
      {
        if (enumerator1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator1);
      }
      return true;
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
      IEnumerator<T> enumerator = source.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          if (predicate(enumerator.Current))
            return true;
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      return false;
    }
  }
}
