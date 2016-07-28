// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0004;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0004
{
  [Guid("10A13217-23A7-439B-B1C0-D847C79B7774")]
  [TypeLibType(4160)]
  [ComImport]
  public interface \u0019
  {
    [DispId(552)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001E \u0005([MarshalAs(UnmanagedType.BStr), In] string bstrName);

    [DispId(553)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001A \u0001();

    [DispId(554)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001A \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrName);

    [DispId(556)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0003([MarshalAs(UnmanagedType.Interface), In] \u001E pItem);

    [DispId(560)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([MarshalAs(UnmanagedType.Interface), In] \u001E pItem, [In] bool varfIsDeleted);

    [DispId(561)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool \u0003([MarshalAs(UnmanagedType.Interface), In] \u001E pItem);

    [DispId(562)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001E \u0001([MarshalAs(UnmanagedType.Interface), In] \u001E pItem);
  }
}
