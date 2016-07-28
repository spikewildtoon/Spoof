// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u000F;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u000F
{
  [TypeLibType(4160)]
  [Guid("0A319C7F-85F9-436C-B88E-82FD88000E1C")]
  [ComImport]
  public interface \u0080
  {
    [DispId(1201)]
    int ID { [DispId(1201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1202)]
    int count { [DispId(1202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1203)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u0081 \u0001([In] int lItem);

    [DispId(1204)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u0081 \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrSourceURL, [MarshalAs(UnmanagedType.BStr), In] string bstrType);

    [DispId(1205)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0084\u0002([In] int lItem);

    [DispId(1206)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u008C();
  }
}
