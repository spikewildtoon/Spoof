﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0005;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0005
{
  [TypeLibType(4160)]
  [Guid("8BA957F5-FD8C-4791-B82D-F840401EE474")]
  [ComImport]
  public interface \u0011 : \u0082
  {
    [DispId(452)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001F \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrURL);

    [DispId(453)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001E \u0002();

    [DispId(454)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001E \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrName);

    [DispId(455)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001E \u0002([MarshalAs(UnmanagedType.BStr), In] string bstrGenre);

    [DispId(456)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001E \u0003([MarshalAs(UnmanagedType.BStr), In] string bstrAuthor);

    [DispId(457)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001E \u0004([MarshalAs(UnmanagedType.BStr), In] string bstrAlbum);

    [DispId(458)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001E \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr), In] string bstrValue);

    [DispId(459)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([MarshalAs(UnmanagedType.Interface), In] \u001F pItem, [In] bool varfDeleteFile);

    [DispId(461)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u0002.\u0001 \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr), In] string bstrMediaType);

    [DispId(470)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrItemName);

    [DispId(471)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0002([MarshalAs(UnmanagedType.Interface), In] \u001F pItem, [In] bool varfIsDeleted);

    [DispId(472)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool \u0002([MarshalAs(UnmanagedType.Interface), In] \u001F pItem);

    [DispId(1401)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u0012 \u0001();

    [DispId(1402)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001E \u0001([MarshalAs(UnmanagedType.Interface), In] \u0012 pQuery, [MarshalAs(UnmanagedType.BStr), In] string bstrMediaType, [MarshalAs(UnmanagedType.BStr), In] string bstrSortAttribute, [In] bool fSortAscending);

    [DispId(1403)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u0002.\u0001 \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrAttribute, [MarshalAs(UnmanagedType.Interface), In] \u0012 pQuery, [MarshalAs(UnmanagedType.BStr), In] string bstrMediaType, [MarshalAs(UnmanagedType.BStr), In] string bstrSortAttribute, [In] bool fSortAscending);

    [DispId(1404)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u001E \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr), In] string bstrValue, [MarshalAs(UnmanagedType.BStr), In] string bstrMediaType);
  }
}