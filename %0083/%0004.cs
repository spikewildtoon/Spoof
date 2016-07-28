// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;

namespace \u0083
{
  internal static class \u0004
  {
    public static TResult \u001D\u0005<T, TResult>(this T obj, Func<T, TResult> eval) where T : class where TResult : class
    {
      if (\u0013\u0080.\u0089\u0091((object) obj, (object) null))
        return default (TResult);
      return eval(obj);
    }

    public static TResult \u001D\u0005<T, TResult>(this T obj, Func<T, TResult> eval, TResult failureValue) where T : class
    {
      if (\u0013\u0080.\u0089\u0091((object) obj, (object) null))
        return failureValue;
      return eval(obj);
    }
  }
}
