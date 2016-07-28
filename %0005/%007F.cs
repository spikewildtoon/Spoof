// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0005
{
  [Guid("EF870383-83AB-4EA9-BE48-56FA4251AF10")]
  [TypeLibType(4160)]
  [ComImport]
  public interface \u007F
  {
    [DispId(8400)]
    string URL { [DispId(8400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(8400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(8401)]
    int status { [DispId(8401), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(8402)]
    int pendingDownloads { [DispId(8402), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(8410)]
    string baseURL { [DispId(8410), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(8414)]
    string fullURL { [DispId(8414), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(8411)]
    int secureLock { [DispId(8411), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(8412)]
    bool busy { [DispId(8412), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(8403)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0097([MarshalAs(UnmanagedType.BStr), In] string samiText);

    [DispId(8404)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0098([MarshalAs(UnmanagedType.BStr), In] string lyrics);

    [DispId(8405)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0099([MarshalAs(UnmanagedType.BStr), In] string pageName);

    [DispId(8406)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0015\u0002();

    [DispId(8407)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0016\u0002();

    [DispId(8408)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0083();

    [DispId(8409)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0017\u0002();

    [DispId(8413)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0018\u0002();
  }
}
