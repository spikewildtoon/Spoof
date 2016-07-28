// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001B;
using \u0080;
using \u0081;
using \u0083;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;

namespace \u0014
{
  internal static class \u0014
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    private static readonly string \u0007;
    private static readonly string \u0008;
    private static readonly string \u000E;
    private static readonly string \u000F;
    private static readonly string \u0010;
    private static readonly string \u0011;
    private static readonly string \u0012;
    private static readonly string \u0013;
    private static readonly string \u0014;
    private static readonly string \u0015;
    private static readonly string \u0016;
    private static readonly string \u0017;
    private static readonly string \u0018;
    private static readonly string \u0019;
    private static readonly string \u001A;
    private static readonly string \u001B;
    private static readonly string \u001C;
    private static readonly string \u001D;
    private static readonly string \u001E;
    private static readonly string \u001F;

    static \u0014()
    {
      \u0004.\u001D\u0005(typeof (\u0014.\u0014));
      \u0014.\u0014.\u0001 = \u0014.\u0014.\u0001(1295);
      \u0014.\u0014.\u0002 = \u0014.\u0014.\u0001(1316);
      \u0014.\u0014.\u0003 = \u0014.\u0014.\u0001(1337);
      \u0014.\u0014.\u0004 = \u0014.\u0014.\u0001(1366);
      \u0014.\u0014.\u0005 = \u0014.\u0014.\u0001(1411);
      \u0014.\u0014.\u0006 = \u0014.\u0014.\u0001(1440);
      \u0014.\u0014.\u0007 = \u0014.\u0014.\u0001(1469);
      \u0014.\u0014.\u0008 = \u0014.\u0014.\u0001(1498);
      \u0014.\u0014.\u000E = \u0014.\u0014.\u0001(1527);
      \u0014.\u0014.\u000F = \u0014.\u0014.\u0001(1556);
      \u0014.\u0014.\u0010 = \u0014.\u0014.\u0001(1585);
      \u0014.\u0014.\u0011 = \u0014.\u0014.\u0001(1610);
      \u0014.\u0014.\u0012 = \u0014.\u0014.\u0001(1627);
      \u0014.\u0014.\u0013 = \u0014.\u0014.\u0001(1648);
      \u0014.\u0014.\u0014 = \u0014.\u0014.\u0001(1665);
      \u0014.\u0014.\u0015 = \u0014.\u0014.\u0001(1686);
      \u0014.\u0014.\u0016 = \u0014.\u0014.\u0001(1703);
      \u0014.\u0014.\u0017 = \u0014.\u0014.\u0001(1732);
      \u0014.\u0014.\u0018 = \u0014.\u0014.\u0001(1757);
      \u0014.\u0014.\u0019 = \u0014.\u0014.\u0001(1770);
      \u0014.\u0014.\u001A = \u0014.\u0014.\u0001(1775);
      \u0014.\u0014.\u001B = \u0014.\u0014.\u0001(1780);
      \u0014.\u0014.\u001C = \u0014.\u0014.\u0001(1853);
      \u0014.\u0014.\u001D = \u0014.\u0014.\u0001(1910);
      \u0014.\u0014.\u001E = \u0014.\u0014.\u0001(1967);
      \u0014.\u0014.\u001F = \u0014.\u0014.\u0001(2032);
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static bool \u001D\u0005(\u0080.\u0001 type, string username, Dictionary<string, string> variables, out \u0018 toontownWindow)
    {
      toontownWindow = (\u0018) null;
      Process p = (Process) null;
      try
      {
        \u0019 toonTownVersionData;
        switch (type)
        {
          case \u0080.\u0001.\u0002:
            \u001D.\u0001 connectSettings = \u0081.\u0080.Instance.ConnectSettings;
            if (connectSettings.SpoofedToonTownEnabled)
            {
              toonTownVersionData = \u0081.\u0080.Instance.ConnectSettings.SpoofedToonTownVersionData;
              \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0001, connectSettings.PatchServer.PANDA_DOWNLOAD_URL);
            }
            else
            {
              toonTownVersionData = \u0081.\u0080.Instance.ConnectSettings.ActualToonTownVersionData;
              \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0001, toonTownVersionData.Properties.PANDA_DOWNLOAD_URL);
            }
            \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0002, \u0014.\u0014.\u0019);
            \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0003, \u0014.\u0014.\u001F);
            break;
          case \u0080.\u0001.\u0003:
            toonTownVersionData = \u0081.\u0080.Instance.ConnectSettings.ActualTestToonTownVersionData;
            \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0001, toonTownVersionData.Properties.PANDA_DOWNLOAD_URL);
            \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0002, \u0014.\u0014.\u001A);
            \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0003, \u0014.\u0014.\u001E);
            break;
          default:
            throw new NotSupportedException(\u0014.\u0014.\u0004);
        }
        \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0005, string.Empty);
        \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0006, string.Empty);
        \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0007, \u0014.\u0014.\u001C);
        \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0008, \u0014.\u0014.\u001D);
        \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u000E, string.Empty);
        \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u000F, \u0014.\u0014.\u001B);
        \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0010, toonTownVersionData.Properties.GAME_VERSION_TEXT);
        \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0011, toonTownVersionData.Properties.GAME_SERVER);
        \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0012, toonTownVersionData.Properties.ACCOUNT_SERVER);
        variables.\u001D\u0005<string, string>(\u0014.\u0014.\u0013, (Action<KeyValuePair<string, string>>) (args =>
        {
          \u0014.\u0014.\u001D\u0005(args.Key, args.Value);
          \u0014.\u0014.\u001D\u0005(\u0014.\u0014.\u0018, args.Value);
        }));
        variables.\u001D\u0005<string, string>(\u0014.\u0014.\u0014, (Action<KeyValuePair<string, string>>) (args => \u0014.\u0014.\u001D\u0005(args.Key, args.Value)));
        variables.\u001D\u0005<string, string>(\u0014.\u0014.\u0015, (Action<KeyValuePair<string, string>>) (args => \u0014.\u0014.\u001D\u0005(args.Key, args.Value)));
        variables.\u001D\u0005<string, string>(\u0014.\u0014.\u0016, (Action<KeyValuePair<string, string>>) (args => \u0014.\u0014.\u001D\u0005(args.Key, args.Value)));
        variables.\u001D\u0005<string, string>(\u0014.\u0014.\u0017, (Action<KeyValuePair<string, string>>) (args => \u0014.\u0014.\u001D\u0005(args.Key, args.Value)));
        p = new Process();
        \u0099\u001F.\u007E\u000F\u0004\u0002((object) p, true);
        ProcessStartInfo processStartInfo = new ProcessStartInfo();
        switch (type)
        {
          case \u0080.\u0001.\u0003:
            \u0092\u0081.\u007E\u0088\u0004\u0002((object) processStartInfo, \u007F.ToonTownTestDataDirectory);
            \u0092\u0081.\u007E\u0086\u0004\u0002((object) processStartInfo, \u0081\u0086.\u0011\u009F(\u007F.ToonTownTestDataDirectory, \u0010.\u000E));
            break;
          default:
            \u0092\u0081.\u007E\u0088\u0004\u0002((object) processStartInfo, \u007F.ToonTownOpenDataDirectory);
            \u0092\u0081.\u007E\u0086\u0004\u0002((object) processStartInfo, \u0081\u0086.\u0011\u009F(\u007F.ToonTownOpenDataDirectory, \u0010.\u000E));
            break;
        }
        \u0099\u001F.\u007E\u0083\u0004\u0002((object) processStartInfo, true);
        \u0082\u0082.\u007E\u008A\u0004\u0002((object) processStartInfo, ProcessWindowStyle.Hidden);
        \u0092\u0081.\u007E\u0082\u0004\u0002((object) processStartInfo, string.Empty);
        \u0099\u001F.\u007E\u0084\u0004\u0002((object) processStartInfo, true);
        \u001E\u0083.\u007E\u0008\u0004\u0002((object) p, processStartInfo);
        toontownWindow = \u0018.\u001D\u0005(p, type, username, false);
        int num = \u0099\u0082.\u007E\u0016\u0004\u0002((object) p) ? 1 : 0;
        return true;
      }
      catch (Exception ex)
      {
        if (p != null)
          \u001A\u001E.\u007E\u007F\u0001\u0002((object) p);
        ex.\u001D\u0005();
        return false;
      }
    }

    private static void \u001D\u0005(string variable, string value)
    {
      \u001F\u0086.\u0096\u0095(variable, value, EnvironmentVariableTarget.Process);
    }
  }
}
