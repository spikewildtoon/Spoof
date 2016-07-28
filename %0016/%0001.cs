// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Diagnostics;
using System.Security.Permissions;

namespace \u0016
{
  internal static class \u0001
  {
    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static string \u001D\u0005()
    {
      Process process = \u000F\u001F.\u0014\u0004\u0002();
      try
      {
        return \u0002\u007F.\u007E\u001E\u0004\u0002((object) \u001D\u007F.\u007E\u0003\u0004\u0002((object) process));
      }
      finally
      {
        if (process != null)
          \u001A\u001E.\u007E\u0094\u0092((object) process);
      }
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static int \u001D\u0005()
    {
      Process process = \u000F\u001F.\u0014\u0004\u0002();
      try
      {
        return \u0005\u0081.\u007E\u009F\u0003\u0002((object) process);
      }
      finally
      {
        if (process != null)
          \u001A\u001E.\u007E\u0094\u0092((object) process);
      }
    }

    public static int \u001D\u0005(string processName)
    {
      // ISSUE: unable to decompile the method.
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static Process[] \u001D\u0005(string processName)
    {
      // ISSUE: unable to decompile the method.
    }
  }
}
