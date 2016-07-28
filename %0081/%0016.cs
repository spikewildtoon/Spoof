// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Collections.Generic;

namespace \u0081
{
  internal static class \u0016
  {
    public static void \u001D\u0005<T>(this T[] source, T[] destination, ref int startIndex)
    {
      \u0089\u0083.\u0084\u0092((Array) source, 0, (Array) destination, startIndex, source.Length);
      startIndex += source.Length;
    }

    public static void \u001D\u0005<T>(this IEnumerable<T> array) where T : IDisposable
    {
      IEnumerator<T> enumerator = array.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          T current = enumerator.Current;
          if ((object) current != null)
            current.Dispose();
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
    }
  }
}
