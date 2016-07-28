// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001E;
using System;
using TSN.Native;
using TSN.Native.Enums;

namespace \u001E
{
  internal static class \u001C
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u001C()
    {
      \u0004.\u001D\u0005(typeof (\u001C));
    }

    public static string \u001D\u0005(this NtStatus status)
    {
      string str = \u000E.\u001D\u0005(\u000E.\u001D\u0005(\u001C.\u0001(66822)), 11, \u0005\u0081.\u007E\u0012\u009C((object) \u0018\u0081.\u007E\u0092\u0098((object) \u007F\u0080.\u0090\u0098())), (int) status);
      switch (str)
      {
        case null:
          return str;
        default:
          if (\u0016\u001D.\u007E\u0017\u0093((object) str, \u001C.\u0001(63903)))
          {
            string[] strArray = \u009D\u001F.\u007E\u0002\u0093((object) str, new char[1]{ '\n' });
            if (strArray.Length > 1)
            {
              str = strArray[1];
              goto case null;
            }
            else
              goto case null;
          }
          else
            goto case null;
      }
    }

    public static bool \u001D\u0005(this NtStatus status)
    {
      if (status < NtStatus.Error)
        return false;
      return status <= NtStatus.MaximumNtStatus;
    }

    public static bool \u001E\u0005(this NtStatus status)
    {
      if (status < NtStatus.Informational)
        return false;
      return status < NtStatus.Warning;
    }

    public static bool \u001F\u0005(this NtStatus status)
    {
      if (status < NtStatus.Success)
        return false;
      return status < NtStatus.Informational;
    }

    public static bool \u007F\u0005(this NtStatus status)
    {
      if (status < NtStatus.Warning)
        return false;
      return status < NtStatus.Error;
    }

    public static void \u001D\u0005(this NtStatus status)
    {
      throw new WindowsException(status);
    }

    public static void \u001E\u0005(this NtStatus status)
    {
      if (!\u001C.\u001D\u0005(status) && !status.\u007F\u0005())
        return;
      \u001C.\u001D\u0005(status);
    }

    public static Win32Error \u001D\u0005(this NtStatus status)
    {
      return \u000E.\u001D\u0005(status);
    }
  }
}
