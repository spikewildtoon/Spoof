// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using System;
using System.IO;

namespace \u0015
{
  internal static class \u0013
  {
    public static void \u001D\u0005(Stream fs, byte flag, int num)
    {
      \u0095\u001F.\u007E\u0090\u009D((object) fs, flag);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(4), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(num), 0, 4);
    }

    public static void \u001D\u0005(Stream fs, byte flag, bool val)
    {
      \u0013.\u001D\u0005(fs, flag, val ? 1 : 0);
    }

    public static void \u001D\u0005(Stream fs, byte flag, long val)
    {
      \u0095\u001F.\u007E\u0090\u009D((object) fs, flag);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(8), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u008D\u0086.\u009D\u0094(val), 0, 8);
    }

    public static void \u001D\u0005(Stream fs, byte flag, short val)
    {
      \u0095\u001F.\u007E\u0090\u009D((object) fs, flag);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(2), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u009D\u001E.\u009B\u0094(val), 0, 2);
    }

    public static void \u001D\u0005(Stream fs, byte flag, DateTime dt)
    {
      \u0095\u001F.\u007E\u0090\u009D((object) fs, flag);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(24), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(dt.Year), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(dt.Month), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(dt.Day), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(dt.Hour), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(dt.Minute), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(dt.Second), 0, 4);
    }

    public static void \u001D\u0005(Stream fs, byte flag, string text)
    {
      switch (text)
      {
        case null:
          text = string.Empty;
          break;
      }
      byte[] numArray = \u0094\u0082.\u007E\u0017\u009C((object) \u001D\u001F.\u001B\u009C(), text);
      \u0095\u001F.\u007E\u0090\u009D((object) fs, flag);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(numArray.Length), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, numArray, 0, numArray.Length);
    }

    public static void \u001E\u0005(Stream fs, byte flag, string text)
    {
      switch (text)
      {
        case null:
          text = string.Empty;
          break;
      }
      byte[] numArray1 = \u0094\u0082.\u007E\u0017\u009C((object) \u001D\u001F.\u001B\u009C(), text);
      byte[] numArray2 = \u001B\u0086.\u009C\u0094(numArray1.Length);
      \u0095\u001F.\u007E\u0090\u009D((object) fs, flag);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, \u001B\u0086.\u009C\u0094(numArray1.Length + 4), 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, numArray2, 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, numArray1, 0, numArray1.Length);
    }

    public static void \u001D\u0005(Stream fs, byte flag, byte[] arr)
    {
      byte[] numArray = \u001B\u0086.\u009C\u0094(arr.Length);
      \u0095\u001F.\u007E\u0090\u009D((object) fs, flag);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, numArray, 0, 4);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, arr, 0, arr.Length);
    }

    public static void \u001D\u0005(Stream fs, string Header)
    {
      byte[] numArray = \u0094\u0082.\u007E\u0017\u009C((object) \u001D\u001F.\u001B\u009C(), Header);
      \u0016\u0086.\u007E\u008F\u009D((object) fs, numArray, 0, numArray.Length);
    }
  }
}
