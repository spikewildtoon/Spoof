// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0083;
using System;

namespace \u0083
{
  internal static class \u0005
  {
    public static int \u001D\u0005(this IntPtr ptr, IntPtr ptr2)
    {
      if (\u0005.\u001D\u0005(ptr) > \u0005.\u001D\u0005(ptr2))
        return 1;
      return \u0005.\u001D\u0005(ptr) < \u0005.\u001D\u0005(ptr2) ? -1 : 0;
    }

    public static int \u001D\u0005(this IntPtr ptr, int ptr2)
    {
      return \u0005.\u001D\u0005(ptr, (uint) ptr2);
    }

    public static int \u001D\u0005(this IntPtr ptr, uint ptr2)
    {
      if (\u0005.\u001D\u0005(ptr) > (ulong) ptr2)
        return 1;
      return \u0005.\u001D\u0005(ptr) < (ulong) ptr2 ? -1 : 0;
    }

    public static IntPtr \u001D\u0005(this IntPtr ptr, IntPtr ptr2)
    {
      if (\u0006\u0083.\u0088\u0096() == 4)
        return new IntPtr(ptr.ToInt32() - ptr2.ToInt32());
      return new IntPtr(ptr.ToInt64() - ptr2.ToInt64());
    }

    public static IntPtr \u001D\u0005(this IntPtr ptr, int value)
    {
      return ptr.\u001E\u0005(-value);
    }

    public static IntPtr \u001D\u0005(this IntPtr ptr, long value)
    {
      return ptr.\u001E\u0005(-value);
    }

    public static bool \u001D\u0005(this IntPtr ptr, IntPtr ptr2)
    {
      return \u0008\u0081.\u0086\u0096(ptr, ptr2);
    }

    public static bool \u001D\u0005(this IntPtr ptr, int value)
    {
      return ptr.ToInt32() == value;
    }

    public static bool \u001D\u0005(this IntPtr ptr, uint value)
    {
      return (int) \u0005.\u001D\u0005(ptr) == (int) value;
    }

    public static bool \u001D\u0005(this IntPtr ptr, long value)
    {
      return ptr.ToInt64() == value;
    }

    public static bool \u001D\u0005(this IntPtr ptr, ulong value)
    {
      return (long) \u0005.\u001D\u0005(ptr) == (long) value;
    }

    public static IntPtr \u001E\u0005(this IntPtr ptr, int value)
    {
      if (\u0006\u0083.\u0088\u0096() == 4)
        return new IntPtr(ptr.ToInt32() + value);
      return new IntPtr(ptr.ToInt64() + (long) value);
    }

    public static IntPtr \u001E\u0005(this IntPtr ptr, long value)
    {
      if (\u0006\u0083.\u0088\u0096() == 4)
        return new IntPtr((int) ((long) ptr.ToInt32() + value));
      return new IntPtr(ptr.ToInt64() + value);
    }

    public static IntPtr \u001E\u0005(this IntPtr ptr, IntPtr ptr2)
    {
      if (\u0006\u0083.\u0088\u0096() == 4)
        return new IntPtr(ptr.ToInt32() + ptr2.ToInt32());
      return new IntPtr(ptr.ToInt64() + ptr2.ToInt64());
    }

    public static IntPtr \u001D\u0005<T>(this IntPtr ptr)
    {
      // ISSUE: type reference
      return ptr.\u001E\u0005(\u0082\u001D.\u0005\u009D(\u009C\u0082.\u0016\u0097(__typeref (T))));
    }

    public static T \u001D\u0005<T>(this IntPtr ptr, int index)
    {
      // ISSUE: type reference
      int num1 = \u0082\u001D.\u0005\u009D(\u009C\u0082.\u0016\u0097(__typeref (T))) * index;
      IntPtr num2 = ptr.\u001E\u0005(num1);
      // ISSUE: type reference
      return (T) \u000F\u001E.\u0014\u009D(num2, \u009C\u0082.\u0016\u0097(__typeref (T)));
    }

    public static unsafe uint \u001D\u0005(this IntPtr ptr)
    {
      return (uint) \u008D\u0080.\u0083\u0096(ptr);
    }

    public static unsafe ulong \u001D\u0005(this IntPtr ptr)
    {
      return (ulong) \u008D\u0080.\u0083\u0096(ptr);
    }

    public static IntPtr \u001D\u0005(this int value)
    {
      return new IntPtr(value);
    }

    public static IntPtr \u001D\u0005(this uint value)
    {
      return new IntPtr((int) value);
    }

    public static IntPtr \u001D\u0005(this long value)
    {
      if (value > 0L && value <= (long) uint.MaxValue)
        return new IntPtr((int) value);
      return new IntPtr(value);
    }

    public static IntPtr \u001D\u0005(this ulong value)
    {
      return \u0005.\u001D\u0005((long) value);
    }

    public static bool \u001E\u0005(this IntPtr ptr, IntPtr ptr2)
    {
      return \u0005.\u001D\u0005(ptr, ptr2) >= 0;
    }

    public static bool \u001F\u0005(this IntPtr ptr, IntPtr ptr2)
    {
      return \u0005.\u001D\u0005(ptr, ptr2) <= 0;
    }

    public static IntPtr \u001F\u0005(this IntPtr ptr, int value)
    {
      if (\u0006\u0083.\u0088\u0096() == 4)
        return new IntPtr(ptr.ToInt32() & value);
      return new IntPtr(ptr.ToInt64() & (long) value);
    }

    public static IntPtr \u001F\u0005(this IntPtr ptr, IntPtr value)
    {
      if (\u0006\u0083.\u0088\u0096() == 4)
        return new IntPtr(ptr.ToInt32() & value.ToInt32());
      return new IntPtr(ptr.ToInt64() & value.ToInt64());
    }

    public static IntPtr \u001D\u0005(this IntPtr ptr)
    {
      if (\u0006\u0083.\u0088\u0096() == 4)
        return new IntPtr(~ptr.ToInt32());
      return new IntPtr(~ptr.ToInt64());
    }

    public static IntPtr \u007F\u0005(this IntPtr ptr, IntPtr value)
    {
      if (\u0006\u0083.\u0088\u0096() == 4)
        return new IntPtr(ptr.ToInt32() | value.ToInt32());
      return new IntPtr(ptr.ToInt64() | value.ToInt64());
    }

    public static IntPtr \u0080\u0005(this IntPtr ptr, IntPtr value)
    {
      if (\u0006\u0083.\u0088\u0096() == 4)
        return new IntPtr(ptr.ToInt32() ^ value.ToInt32());
      return new IntPtr(ptr.ToInt64() ^ value.ToInt64());
    }
  }
}
