// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u0083;
using System;

namespace \u0083
{
  internal static class \u001C
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static \u001C.\u0001 \u0001;

    public static bool MyGalleryOpen
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) \u001C.\u0001, (Enum) \u001C.\u0001.\u0005);
      }
      set
      {
        \u001C.\u001D\u0005(\u001C.\u0001.\u0005, value);
      }
    }

    public static bool ContentPacksOpen
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) \u001C.\u0001, (Enum) \u001C.\u0001.\u0002);
      }
      set
      {
        \u001C.\u001D\u0005(\u001C.\u0001.\u0002, value);
      }
    }

    public static bool MakePackageOpen
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) \u001C.\u0001, (Enum) \u001C.\u0001.\u0003);
      }
      set
      {
        \u001C.\u001D\u0005(\u001C.\u0001.\u0003, value);
      }
    }

    public static bool InstallingOrLoggingIn
    {
      get
      {
        return \u0095\u001C.\u0099\u0091((object) \u001C.\u0001, (Enum) \u001C.\u0001.\u0004);
      }
      set
      {
        if (!\u001C.\u001D\u0005(\u001C.\u0001.\u0004, value) || (value || \u001C.\u0001 == null))
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) \u001C.\u0001, (object) null, EventArgs.Empty);
      }
    }

    public static bool CanOpenContentPacksOrOpenDialog
    {
      get
      {
        if (\u001C.InstallingOrLoggingIn)
        {
          \u0017.\u001D\u0005(\u001C.\u0001(103057), \u001C.\u0001(103199));
          return false;
        }
        if (\u0016.\u0001.\u001D\u0005(\u001C.\u0001(19546)) <= 0)
          return true;
        \u0017.\u001D\u0005(\u001C.\u0001(103224), \u001C.\u0001(103297));
        return false;
      }
    }

    public static bool CanExitTheToonTownSpoofer
    {
      get
      {
        if (!\u001C.InstallingOrLoggingIn)
          return true;
        \u0017.\u001D\u0005(\u001C.\u0001(103326), \u001C.\u0001(103468));
        return false;
      }
    }

    public static bool CanOpenMakePackageOrDialog
    {
      get
      {
        if (\u001C.InstallingOrLoggingIn)
        {
          \u0017.\u001D\u0005(\u001C.\u0001(103497), \u001C.\u0001(103199));
          return false;
        }
        if (\u0016.\u0001.\u001D\u0005(\u001C.\u0001(19546)) <= 0)
          return true;
        \u0017.\u001D\u0005(\u001C.\u0001(103635), \u001C.\u0001(103297));
        return false;
      }
    }

    public static bool CanLoginToToonTownOrDialog
    {
      get
      {
        if (\u001C.MakePackageOpen)
        {
          \u0017.\u001D\u0005(\u001C.\u0001(103704), \u001C.\u0001(103817));
          return false;
        }
        if (!\u001C.ContentPacksOpen)
          return true;
        \u0017.\u001D\u0005(\u001C.\u0001(103850), \u001C.\u0001(103943));
        return false;
      }
    }

    public static bool CanChangeScreenshotDirectory
    {
      get
      {
        if (!\u001C.MyGalleryOpen)
          return true;
        \u0017.\u001D\u0005(\u001C.\u0001(103980), \u001C.\u0001(104085));
        return false;
      }
    }

    public static bool CanOpenUpdater
    {
      get
      {
        if (\u001C.InstallingOrLoggingIn)
        {
          \u0017.\u001D\u0005(\u001C.\u0001(104118), \u001C.\u0001(103468));
          return false;
        }
        if (\u001C.MyGalleryOpen)
        {
          \u0017.\u001D\u0005(\u001C.\u0001(104276), \u001C.\u0001(104085));
          return false;
        }
        if (\u001C.MakePackageOpen)
        {
          \u0017.\u001D\u0005(\u001C.\u0001(104377), \u001C.\u0001(103817));
          return false;
        }
        if (!\u001C.ContentPacksOpen)
          return true;
        \u0017.\u001D\u0005(\u001C.\u0001(104515), \u001C.\u0001(103943));
        return false;
      }
    }

    public static bool CanChangeVirtualServerPort
    {
      get
      {
        if (\u001C.InstallingOrLoggingIn)
        {
          \u0017.\u001D\u0005(\u001C.\u0001(104632), \u001C.\u0001(103468));
          return false;
        }
        if (\u0016.\u0001.\u001D\u0005(\u001C.\u0001(19546)) <= 0)
          return true;
        \u0017.\u001D\u0005(\u001C.\u0001(104806), \u001C.\u0001(103297));
        return false;
      }
    }

    public static event EventHandler InstallingOrLoggingInCompleted;

    static \u001C()
    {
      \u0004.\u001D\u0005(typeof (\u001C));
      \u001C.\u0001 = \u001C.\u0001.\u0001;
    }

    private static bool \u001D\u0005(\u001C.\u0001 comp, bool value)
    {
      if (value)
      {
        if (!\u0095\u001C.\u0099\u0091((object) \u001C.\u0001, (Enum) comp))
        {
          \u001C.\u0001 |= comp;
          return true;
        }
      }
      else if (\u0095\u001C.\u0099\u0091((object) \u001C.\u0001, (Enum) comp))
      {
        \u001C.\u0001 &= ~comp;
        return true;
      }
      return false;
    }

    [Flags]
    private enum \u0001
    {
      \u0001 = 0,
      \u0002 = 1,
      \u0003 = 2,
      \u0004 = 4,
      \u0005 = 8,
    }
  }
}
