// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001E;
using \u0084;
using System;
using System.Diagnostics;
using System.Security.Permissions;

namespace \u0084
{
  internal static class \u0003
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0003()
    {
      \u0004.\u001D\u0005(typeof (\u0003));
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static void \u001D\u0005(string directory)
    {
      if (\u008F\u0084.\u009E\u0092(directory))
        return;
      try
      {
        ProcessStartInfo processStartInfo = new ProcessStartInfo(\u0003.\u0001(105548));
        \u0092\u0081.\u007E\u0082\u0004\u0002((object) processStartInfo, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0003.\u0001(105565), new object[1]
        {
          (object) directory
        }));
        Process process = \u0091\u001D.\u0019\u0004\u0002(processStartInfo);
        try
        {
        }
        finally
        {
          if (process != null)
            \u001A\u001E.\u007E\u0094\u0092((object) process);
        }
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0003.\u0001(105582), new object[1]
        {
          (object) directory
        }));
        \u0017.\u001E\u0005(\u0003.\u0001(105607), \u0003.\u0001(105708));
      }
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static void \u001E\u0005(string sFilePath)
    {
      if (\u008F\u0084.\u009E\u0092(sFilePath))
        return;
      try
      {
        ProcessStartInfo processStartInfo = new ProcessStartInfo(\u0003.\u0001(105548));
        \u0092\u0081.\u007E\u0082\u0004\u0002((object) processStartInfo, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0003.\u0001(105741), new object[1]
        {
          (object) sFilePath
        }));
        Process process = \u0091\u001D.\u0019\u0004\u0002(processStartInfo);
        try
        {
        }
        finally
        {
          if (process != null)
            \u001A\u001E.\u007E\u0094\u0092((object) process);
        }
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0003.\u0001(105762), new object[1]
        {
          (object) sFilePath
        }));
        \u0017.\u001E\u0005(\u0003.\u0001(105607), \u0003.\u0001(105708));
      }
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static void \u001F\u0005(string url)
    {
      try
      {
        Process process = \u008A\u007F.\u0017\u0004\u0002(url);
        try
        {
        }
        finally
        {
          if (process != null)
            \u001A\u001E.\u007E\u0094\u0092((object) process);
        }
      }
      catch (Exception ex1)
      {
        ex1.\u001D\u0005((object) \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0003.\u0001(105779), new object[1]{ (object) url }));
        try
        {
          Process process = \u009F\u0082.\u0018\u0004\u0002(\u0003.\u0001(105796), url);
        }
        catch (Exception ex2)
        {
          ex2.\u001D\u0005((object) \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0003.\u0001(105779), new object[1]{ (object) url }));
          \u0017.\u001E\u0005(\u009E\u0081.\u001F\u0093(\u0003.\u0001(105813), (object) url), \u0003.\u0001(105866));
        }
      }
    }
  }
}
