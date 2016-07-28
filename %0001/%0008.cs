// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace \u0001
{
  internal sealed class \u0008
  {
    private static Assembly \u0001 = (Assembly) null;
    private static string[] \u0001 = new string[0];

    internal static void \u001D\u0005()
    {
      try
      {
        AppDomain.CurrentDomain.ResourceResolve += new ResolveEventHandler(\u0008.\u001D\u0005);
      }
      catch (Exception ex)
      {
      }
    }

    internal static Assembly \u001D\u0005([In] object obj0, [In] ResolveEventArgs obj1)
    {
      if (\u0008.\u0001 == null)
      {
        lock (\u0008.\u0001)
        {
          \u0008.\u0001 = Assembly.Load(\u0006.\u001D\u0005(172));
          if (\u0008.\u0001 != null)
            \u0008.\u0001 = \u0008.\u0001.GetManifestResourceNames();
        }
      }
      string name = obj1.Name;
      for (int index = 0; index < \u0008.\u0001.Length; ++index)
      {
        if (\u0008.\u0001[index] == name)
          return \u0008.\u0001;
      }
      return (Assembly) null;
    }
  }
}
