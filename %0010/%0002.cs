﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u000F;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0010
{
  [Guid("5F0248C1-62B3-42D7-B927-029119E6AD14")]
  [TypeLibType(4160)]
  [ComImport]
  public interface \u0002 : \u001E
  {
    [DispId(10005)]
    string version { [DispId(10005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10012)]
    string appColorLight { [DispId(10012), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10018)]
    object OnColorChange { [DispId(10018), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(10013)]
    string appColorMedium { [DispId(10013), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10014)]
    string appColorDark { [DispId(10014), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10015)]
    string appColorButtonHighlight { [DispId(10015), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10016)]
    string appColorButtonShadow { [DispId(10016), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10017)]
    string appColorButtonHoverFace { [DispId(10017), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10027)]
    string SelectedTaskPane { [DispId(10027), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(10027), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(10026)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0004([MarshalAs(UnmanagedType.BStr), In] string bstrKeyName, [MarshalAs(UnmanagedType.BStr), In] string bstrTaskPane, [MarshalAs(UnmanagedType.BStr), In] string bstrParams);

    [DispId(10004)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0019\u0003([MarshalAs(UnmanagedType.BStr), In] string bstrURL);
  }
}