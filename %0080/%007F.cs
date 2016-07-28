// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0017;
using \u001A;
using \u0080;
using \u0082;
using \u0083;
using \u0084;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;
using System.Windows.Forms;

namespace \u0080
{
  internal static class \u007F
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u007F()
    {
      \u0004.\u001D\u0005(typeof (\u007F));
    }

    public static \u0008 \u001D\u0005(EventHandler<\u0080.\u0017> e = null)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u007F.\u0001 obj1 = new \u007F.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = e;
      \u0008 obj2 = (\u0008) null;
      try
      {
        obj2 = new \u0008();
        obj2.LabelMessage = \u007F.\u0001(93162);
        obj2.SelectedHandleChanging += new EventHandler<\u0080.\u0017>(\u007F.\u001D\u0005);
        // ISSUE: reference to a compiler-generated field
        if (obj1.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated method
          obj2.SelectedHandleChanging += new EventHandler<\u0080.\u0017>(obj1.\u001D\u0005);
        }
        return obj2;
      }
      catch
      {
        if (obj2 != null)
          \u001A\u001E.\u007E\u007F\u0001\u0002((object) obj2);
        throw;
      }
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static void \u001D\u0005(object sender, \u0080.\u0017 e)
    {
      Process process = \u000E.\u001D\u0005(((\u0008) e).Handle);
      try
      {
        if (!\u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0019\u0093((object) \u0002\u007F.\u007E\u0004\u0004\u0002((object) process)), \u0010.\u000F))
          return;
        e.IsValid = true;
      }
      catch (Exception ex)
      {
        e.IsValid = false;
      }
      finally
      {
        if (process != null)
          \u001A\u001E.\u007E\u0094\u0092((object) process);
      }
    }

    public static bool \u001D\u0005(out \u001B selectedFile)
    {
      \u0004 obj1 = new \u0004();
      try
      {
        obj1.InputLabelMessage = \u007F.\u0001(23808);
        obj1.InputText = \u007F.\u0001(23881);
        obj1.FileInfo = \u0081.\u0080.Instance.JoeFishSettings.JoeFishCaptureSettings.Files.ToArray();
        obj1.Filter = \u007F.\u0001(93231);
        obj1.InstallFolder = \u007F.JoeFishCaptureSettingsDirectory;
        obj1.FileExtension = \u007F.\u0001(21709);
        obj1.InputValidating += (EventHandler<\u0011<string>>) ((obj, args) =>
        {
          if (\u008F\u0084.\u009E\u0092(args.\u0001))
          {
            \u0018.\u0017.\u001D\u0005(\u007F.\u0001(93399), \u007F.\u0001(93428));
            args.IsValid = false;
          }
          else
            args.IsValid = true;
        });
        selectedFile = \u0097\u001E.\u007E\u0099\u008B((object) obj1) != DialogResult.OK ? (\u001B) null : obj1.SelectedFileInfo;
        \u0081.\u0080.Instance.JoeFishSettings.JoeFishCaptureSettings.Files.Clear();
        \u0081.\u0080.Instance.JoeFishSettings.JoeFishCaptureSettings.Files.AddRange((IEnumerable<\u001B>) obj1.FileInfo);
        \u0081.\u0080.\u001D\u0005();
        return \u001B.\u001E\u0005(selectedFile, (object) null);
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    public static bool \u001E\u0005(out \u001B selectedFile)
    {
      \u0004 obj1 = new \u0004();
      try
      {
        obj1.InputLabelMessage = \u007F.\u0001(23808);
        obj1.InputText = \u007F.\u0001(71906);
        obj1.FileInfo = \u0081.\u0080.Instance.GardenerFloraSettings.GardenerFloraCaptureFiles.Files.ToArray();
        obj1.Filter = \u007F.\u0001(93276);
        obj1.InstallFolder = \u007F.GardenerFloraCaptureSettingsDirectory;
        obj1.FileExtension = \u007F.\u0001(70661);
        obj1.InputValidating += (EventHandler<\u0011<string>>) ((obj, args) =>
        {
          if (\u008F\u0084.\u009E\u0092(args.\u0001))
          {
            \u0018.\u0017.\u001D\u0005(\u007F.\u0001(93399), \u007F.\u0001(93428));
            args.IsValid = false;
          }
          else
            args.IsValid = true;
        });
        selectedFile = \u0097\u001E.\u007E\u0099\u008B((object) obj1) != DialogResult.OK ? (\u001B) null : obj1.SelectedFileInfo;
        \u0081.\u0080.Instance.GardenerFloraSettings.GardenerFloraCaptureFiles.Files.Clear();
        \u0081.\u0080.Instance.GardenerFloraSettings.GardenerFloraCaptureFiles.Files.AddRange((IEnumerable<\u001B>) obj1.FileInfo);
        \u0081.\u0080.\u001D\u0005();
        return \u001B.\u001E\u0005(selectedFile, (object) null);
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    public static bool \u001F\u0005(out \u001B selectedFile)
    {
      \u0004 obj1 = new \u0004();
      try
      {
        obj1.InputLabelMessage = \u007F.\u0001(25971);
        obj1.InputText = \u007F.\u0001(26040);
        obj1.FileInfo = \u0081.\u0080.Instance.GardenerFloraSettings.GardenerFloraFiles.Files.ToArray();
        obj1.Filter = \u007F.\u0001(93329);
        obj1.InstallFolder = \u007F.GardenerFloraEstateSettings;
        obj1.FileExtension = \u007F.\u0001(26105);
        obj1.InputValidating += (EventHandler<\u0011<string>>) ((obj, args) =>
        {
          if (\u008F\u0084.\u009E\u0092(args.\u0001))
          {
            \u0018.\u0017.\u001D\u0005(\u007F.\u0001(93399), \u007F.\u0001(93428));
            args.IsValid = false;
          }
          else
            args.IsValid = true;
        });
        selectedFile = \u0097\u001E.\u007E\u0099\u008B((object) obj1) != DialogResult.OK ? (\u001B) null : obj1.SelectedFileInfo;
        \u0081.\u0080.Instance.GardenerFloraSettings.GardenerFloraFiles.Files.Clear();
        \u0081.\u0080.Instance.GardenerFloraSettings.GardenerFloraFiles.Files.AddRange((IEnumerable<\u001B>) obj1.FileInfo);
        \u0081.\u0080.\u001D\u0005();
        return \u001B.\u001E\u0005(selectedFile, (object) null);
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    public static bool \u007F\u0005(out \u001B selectedFile)
    {
      \u0004 obj1 = new \u0004();
      try
      {
        obj1.InputLabelMessage = \u007F.\u0001(10084);
        obj1.InputText = \u007F.\u0001(10161);
        obj1.FileInfo = \u0081.\u0080.Instance.RaceTrackFileIndex.Files.ToArray();
        obj1.Filter = \u007F.\u0001(93366);
        obj1.InstallFolder = \u007F.RaceTrackSettingsDirectory;
        obj1.FileExtension = \u007F.\u0001(10222);
        obj1.InputValidating += (EventHandler<\u0011<string>>) ((obj, args) =>
        {
          if (\u008F\u0084.\u009E\u0092(args.\u0001))
          {
            \u0018.\u0017.\u001D\u0005(\u007F.\u0001(93399), \u007F.\u0001(93428));
            args.IsValid = false;
          }
          else
            args.IsValid = true;
        });
        selectedFile = \u0097\u001E.\u007E\u0099\u008B((object) obj1) != DialogResult.OK ? (\u001B) null : obj1.SelectedFileInfo;
        \u0081.\u0080.Instance.RaceTrackFileIndex.Files.Clear();
        \u0081.\u0080.Instance.RaceTrackFileIndex.Files.AddRange((IEnumerable<\u001B>) obj1.FileInfo);
        \u0081.\u0080.\u001D\u0005();
        return \u001B.\u001E\u0005(selectedFile, (object) null);
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }
  }
}
