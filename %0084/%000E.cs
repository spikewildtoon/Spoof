// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001E;
using \u0081;
using \u0084;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Threading;

namespace \u0084
{
  internal static class \u000E
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static ManualResetEventSlim \u0001;
    private static Dictionary<Process, \u0008> \u0001;

    static \u000E()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u000E)));
      \u000E.\u0001 = new Dictionary<Process, \u0008>();
      \u009E\u001B.\u000E\u0083(new EventHandler(\u000E.\u001E\u0005));
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static void \u001D\u0005(\u0008 data)
    {
      if (data == null)
        throw new ArgumentNullException(\u000E.\u0001(49024));
      ProcessStartInfo processStartInfo = new ProcessStartInfo();
      \u0092\u0081.\u007E\u0086\u0004\u0002((object) processStartInfo, \u0080.Instance.MakePackageSettings.Panda3dPath);
      \u0092\u0081.\u007E\u0088\u0004\u0002((object) processStartInfo, \u009C\u0080.\u0005\u009F(\u0080.Instance.MakePackageSettings.Panda3dPath));
      \u0082\u0082.\u007E\u008A\u0004\u0002((object) processStartInfo, ProcessWindowStyle.Normal);
      \u0099\u001F.\u007E\u0084\u0004\u0002((object) processStartInfo, true);
      \u0092\u0081.\u007E\u0082\u0004\u0002((object) processStartInfo, \u009E\u0081.\u001F\u0093(\u000E.\u0001(106134), (object) data.ModelPath));
      \u0082\u0082.\u007E\u008A\u0004\u0002((object) processStartInfo, ProcessWindowStyle.Hidden);
      Process key = (Process) null;
      try
      {
        key = new Process();
        \u001E\u0083.\u007E\u0008\u0004\u0002((object) key, processStartInfo);
        \u0099\u001F.\u007E\u000F\u0004\u0002((object) key, true);
        \u0087\u007F.\u007E\u0010\u0004\u0002((object) key, new EventHandler(\u000E.\u001D\u0005));
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) \u000E.\u0001), ref flag);
          \u000E.\u0001.Add(key, data);
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
        int num = \u0099\u0082.\u007E\u0016\u0004\u0002((object) key) ? 1 : 0;
      }
      catch
      {
        if (key != null)
          \u001A\u001E.\u007E\u007F\u0001\u0002((object) key);
        throw;
      }
    }

    private static void \u001D\u0005(object sender, EventArgs e)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) \u000E.\u0001), ref flag);
        Process index = sender as Process;
        \u000E.\u001D\u0005(index, \u000E.\u0001[index]);
        \u000E.\u0001.Remove(index);
        if (\u000E.\u0001 == null || \u000E.\u0001.Count != 0)
          return;
        \u001A\u001E.\u007E\u0002\u0099((object) \u000E.\u0001);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private static void \u001D\u0005(Process p, \u0008 data)
    {
      \u001A\u001E.\u007E\u007F\u0001\u0002((object) p);
      foreach (string imagePath in data.ImagePaths)
        \u0019.\u007F\u0005(imagePath);
      foreach (string directory in data.Directories)
        \u0019.\u001D\u0005(directory);
    }

    private static void \u001E\u0005(object sender, EventArgs e)
    {
      bool flag1 = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) \u000E.\u0001), ref flag1);
        ManualResetEventSlim manualResetEventSlim = \u000E.\u0001 = new ManualResetEventSlim(false);
        try
        {
          bool flag2 = \u000E.\u0001.Count > 0;
          ((IEnumerable<Process>) \u000E.\u0001.Keys.ToArray<Process>()).\u001D\u0005<Process>((Action<Process>) (item =>
          {
            try
            {
              int num1 = \u0099\u0082.\u007E\u0011\u0004\u0002((object) item) ? 1 : 0;
              int num2 = \u0095\u0081.\u007E\u001B\u0004\u0002((object) item, 5000) ? 1 : 0;
            }
            catch (Exception ex)
            {
              ex.\u001D\u0005();
            }
          }));
          if (!flag2)
            return;
          int num = \u0095\u0081.\u007E\u0006\u0099((object) \u000E.\u0001, 10000) ? 1 : 0;
        }
        finally
        {
          if (manualResetEventSlim != null)
            \u001A\u001E.\u007E\u0094\u0092((object) manualResetEventSlim);
        }
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }
  }
}
