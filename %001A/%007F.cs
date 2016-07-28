// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001E;
using System;
using System.Diagnostics;
using System.IO;

namespace \u001A
{
  internal static class \u007F
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public static readonly string \u0001;
    public static readonly string \u0002;
    public static readonly string \u0003;
    public static readonly string \u0004;
    public static readonly string \u0005;
    public static readonly string \u0006;
    public static readonly string \u0007;
    public static readonly string \u0008;
    public static readonly string \u000E;
    public static readonly string \u000F;
    public static readonly string \u0010;
    public static readonly string \u0011;
    public static readonly string \u0012;
    public static readonly string \u0013;
    public static readonly string \u0014;
    public static readonly string \u0015;
    public static readonly string \u0016;
    public static readonly string \u0017;
    public static readonly string \u0018;
    public static readonly string \u0019;
    public static readonly string \u001A;
    public static readonly string \u001B;
    public static readonly string \u001C;
    public static readonly string \u001D;
    public static readonly string \u001E;
    public static readonly string \u001F;
    public static readonly string \u007F;

    public static string CommonApplicationTheSpoofNetDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0001))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0001, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0001;
      }
    }

    public static string CommonApplicationDataDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0002))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0002, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0002;
      }
    }

    public static string ScreenshotSaveDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0003))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0003, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0003;
      }
    }

    public static string RaceTrackSettingsDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0004))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0004, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0004;
      }
    }

    public static string ToonTownOpenDataDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0005))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0005, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0005;
      }
    }

    public static string ToonTownTestDataDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0006))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0006, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0006;
      }
    }

    public static string ContentPackDataDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0007))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0007, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0007;
      }
    }

    public static string JoeFishDataDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0008))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0008, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0008;
      }
    }

    public static string GardenerFloraDataDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u000E))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u000E, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u000E;
      }
    }

    public static string GardenerFloraEstateSettings
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u000F))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u000F, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u000F;
      }
    }

    public static string GardenerFloraCaptureSettingsDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0010))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0010, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0010;
      }
    }

    public static string JoeFishCaptureSettingsDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0011))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0011, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0011;
      }
    }

    public static string ToonTownContent_TempFolder
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0012))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0012, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0012;
      }
    }

    public static string DebugLogDirectory
    {
      [DebuggerStepThrough] get
      {
        if (!\u008F\u0084.\u001D\u009E(\u007F.\u0013))
        {
          DirectoryInfo directoryInfo = \u0010\u001F.\u001C\u009E(\u007F.\u0013, \u000F.GetDirectorySecurity);
        }
        return \u007F.\u0013;
      }
    }

    static \u007F()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u007F)));
      \u007F.\u0001 = \u0081\u0086.\u0011\u009F(\u0003\u001F.\u009C\u0095(Environment.SpecialFolder.CommonApplicationData), \u007F.\u0001(53060));
      \u007F.\u0002 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationTheSpoofNetDirectory, \u007F.\u0001(53081));
      \u007F.\u0003 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53110));
      \u007F.\u0004 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53127));
      \u007F.\u0005 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53144));
      \u007F.\u0006 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53157));
      \u007F.\u0007 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53178));
      \u007F.\u0008 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53199));
      \u007F.\u000E = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53220));
      \u007F.\u000F = \u0081\u0086.\u0011\u009F(\u007F.GardenerFloraDataDirectory, \u007F.\u0001(53249));
      \u007F.\u0010 = \u0081\u0086.\u0011\u009F(\u007F.GardenerFloraDataDirectory, \u007F.\u0001(53270));
      \u007F.\u0011 = \u0081\u0086.\u0011\u009F(\u007F.JoeFishDataDirectory, \u007F.\u0001(53270));
      \u007F.\u0012 = \u0081\u0086.\u0011\u009F(\u008E\u001E.\u000F\u009F(), \u007F.\u0001(53295));
      \u007F.\u0013 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53320));
      \u007F.\u0014 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53333));
      \u007F.\u0015 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53362));
      \u007F.\u0016 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53371));
      \u007F.\u0017 = \u0081\u0086.\u0011\u009F(\u007F.CommonApplicationDataDirectory, \u007F.\u0001(53388));
      \u007F.\u0018 = \u0081\u0086.\u0011\u009F(\u008E\u001E.\u0008\u0083(), \u007F.\u0001(53401));
      \u007F.\u0019 = \u0081\u0086.\u0011\u009F(\u008E\u001E.\u0008\u0083(), \u007F.\u0001(53426));
      \u007F.\u001A = \u0081\u0086.\u0011\u009F(\u008E\u001E.\u0008\u0083(), \u007F.\u0001(53471));
      \u007F.\u001B = \u0081\u0086.\u0011\u009F(\u008E\u001E.\u0008\u0083(), \u007F.\u0001(53508));
      \u007F.\u001C = \u0081\u0086.\u0011\u009F(\u008E\u001E.\u0008\u0083(), \u007F.\u0001(53557));
      \u007F.\u001D = \u0081\u0086.\u0011\u009F(\u007F.JoeFishDataDirectory, \u007F.\u0001(53594));
      \u007F.\u001E = \u0081\u0086.\u0011\u009F(\u008E\u001E.\u0008\u0083(), \u007F.\u0001(53619));
      \u007F.\u001F = \u0081\u0086.\u0011\u009F(\u008E\u001E.\u0008\u0083(), \u007F.\u0001(53656));
      \u007F.\u007F = \u0081\u0086.\u0011\u009F(\u008E\u001E.\u0008\u0083(), \u007F.\u0001(53689));
    }
  }
}
