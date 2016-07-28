// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0083;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace \u0083
{
  internal sealed class \u0008
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly Lazy<\u0008> \u0001;
    private static readonly string \u0001;
    private Assembly \u0001;
    private static bool? \u0001;

    public static \u0008 Current
    {
      get
      {
        return \u0008.\u0001.Value;
      }
    }

    public static bool IsRunningOnMono
    {
      get
      {
        if (!\u0008.\u0001.HasValue)
          \u0008.\u0001 = new bool?(\u0091\u001F.\u001B\u0097(\u0081\u0080.\u0013\u0097(\u0008.\u0001(100590)), (Type) null));
        return \u0008.\u0001.Value;
      }
    }

    public string Title
    {
      get
      {
        return \u0002\u007F.\u007E\u0091\u009B((object) this.\u001D\u0005<AssemblyTitleAttribute>());
      }
    }

    public string Description
    {
      get
      {
        return \u0002\u007F.\u007E\u008F\u009B((object) this.\u001D\u0005<AssemblyDescriptionAttribute>());
      }
    }

    public string CompanyName
    {
      get
      {
        return \u0002\u007F.\u007E\u008D\u009B((object) this.\u001D\u0005<AssemblyCompanyAttribute>());
      }
    }

    public string ProductName
    {
      get
      {
        return \u0002\u007F.\u007E\u008B\u009B((object) this.\u001D\u0005<AssemblyProductAttribute>());
      }
    }

    public string Copyright
    {
      get
      {
        return \u0002\u007F.\u007E\u0087\u009B((object) this.\u001D\u0005<AssemblyCopyrightAttribute>());
      }
    }

    public string Trademark
    {
      get
      {
        return \u0002\u007F.\u007E\u0089\u009B((object) this.\u001D\u0005<AssemblyTrademarkAttribute>());
      }
    }

    public Version AssemblyVersion
    {
      get
      {
        return \u000E\u001C.\u007E\u009A\u009B((object) \u0092\u0080.\u007E\u001F\u009B((object) this.\u0001));
      }
    }

    public Version FileVersion
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        return new Version(\u0002\u007F.\u007E\u0096\u009B((object) this.\u001D\u0005<AssemblyFileVersionAttribute>()));
      }
    }

    public string Guid
    {
      get
      {
        return \u0002\u007F.\u007E\u0090\u009C((object) this.\u001D\u0005<GuidAttribute>());
      }
    }

    public string OriginalFilename
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        FileVersionInfo fileVersionInfo = \u0008\u0086.\u009B\u0003\u0002(\u0002\u007F.\u007E\u0083\u009B((object) this.\u0001));
        return \u0002\u007F.\u007E\u009A\u0003\u0002((object) fileVersionInfo);
      }
    }

    public string FileName
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        FileVersionInfo fileVersionInfo = \u0008\u0086.\u009B\u0003\u0002(\u0002\u007F.\u007E\u0083\u009B((object) this.\u0001));
        return \u0002\u007F.\u007E\u0099\u0003\u0002((object) fileVersionInfo);
      }
    }

    public string InformationalVersion
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        return \u0002\u007F.\u007E\u0094\u009B((object) this.\u001D\u0005<AssemblyInformationalVersionAttribute>());
      }
    }

    static \u0008()
    {
      \u0004.\u001D\u0005(typeof (\u0008));
      \u0008.\u0001 = new Lazy<\u0008>((Func<\u0008>) (() => new \u0008()));
      \u0008.\u0001 = \u0008.\u0001(100607);
    }

    public \u0008(Type type)
    {
      if (\u0091\u001F.\u001A\u0097(type, (Type) null))
        throw new ArgumentNullException(\u0008.\u0001(100568));
      this.\u0001 = \u0094\u0086.\u0018\u009B(type);
    }

    public \u0008(Assembly assembly)
    {
      if (\u0006\u001F.\u0019\u009B(assembly, (Assembly) null))
        throw new ArgumentNullException(\u0008.\u0001(100577));
      this.\u0001 = assembly;
    }

    public \u0008()
      : this(Assembly.GetExecutingAssembly())
    {
    }

    private T \u001D\u0005<T>() where T : Attribute
    {
      // ISSUE: unable to decompile the method.
    }
  }
}
