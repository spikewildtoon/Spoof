// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0017;
using \u001D;
using \u001F;
using \u0080;
using \u0083;
using System;
using System.Windows.Forms;

namespace \u0017
{
  internal static class \u0081
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;

    static \u0081()
    {
      \u0004.\u001D\u0005(typeof (\u0081));
      \u0081.\u0001 = \u0081.\u0001(30971);
      \u0081.\u0002 = \u0081.\u0001(31032);
      \u0081.\u0003 = \u0081.\u0001(31065);
      \u0081.\u0004 = \u0081.\u0001(31110);
    }

    public static bool \u001D\u0005(this \u001C process)
    {
      return \u0081.\u001D\u0005(\u0010.\u000F, process);
    }

    public static bool \u001D\u0005(this \u001C process, Form owner)
    {
      if (\u0081.\u001D\u0005(process))
        return true;
      return process.\u001D\u0005(owner, (EventHandler<\u0080.\u0017>) null);
    }

    public static bool \u001D\u0005(this \u001C process, Form owner, EventHandler<\u0080.\u0017> e = null)
    {
      \u0007 obj1 = new \u0007(owner);
      try
      {
        \u0008 obj2 = \u007F.\u001D\u0005(e);
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) == DialogResult.OK)
          {
            \u0013.\u001D\u0005(\u0081.\u0002, new object[1]
            {
              (object) obj2.SelectedHandle
            });
            process.MainWindowHandle = obj2.SelectedHandle;
            \u0013.\u001D\u0005(\u0081.\u0001, new object[1]
            {
              (object) process.MainWindowHandle
            });
            return true;
          }
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
      return false;
    }

    public static bool \u001D\u0005(string processName, \u001C process)
    {
      // ISSUE: unable to decompile the method.
    }
  }
}
