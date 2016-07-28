// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u000F
{
  [Guid("6B550945-018F-11D3-B14A-00C04F79FAA6")]
  [TypeLibType(4160)]
  [ComConversionLoss]
  [ComImport]
  public interface \u0016
  {
    [DispId(8151)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] int lGraphState);

    [DispId(8173)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0002([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] int lGraphState);

    [DispId(8153)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] double dRate);

    [DispId(8157)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [MarshalAs(UnmanagedType.BStr)] string bstrQueuedUrl, [ComAliasName("WMPLib.ULONG_PTR")] uint dwCurrentContext);

    [DispId(8156)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0003([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph);

    [DispId(8158)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [MarshalAs(UnmanagedType.BStr), In] string bstrCommand, [MarshalAs(UnmanagedType.BStr), In] string bstrParam);

    [DispId(8172)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [MarshalAs(UnmanagedType.BStr), In] string bstrCommand, [MarshalAs(UnmanagedType.BStr), In] string bstrParam, [In] double dTime);

    [DispId(8159)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0003([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] int lMarker);

    [DispId(8160)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] int lErrMajor, [In] int lErrMinor, [In] int lCondition, [MarshalAs(UnmanagedType.BStr), In] string bstrInfo, [MarshalAs(UnmanagedType.IUnknown), In] object punkGraphData);

    [DispId(8161)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [MarshalAs(UnmanagedType.BStr), In] string bstrRealm, [MarshalAs(UnmanagedType.BStr), In] string bstrSite, [In, Out] IntPtr bstrUser, [In, Out] IntPtr bstrPassword, [In, Out] ref uint pdwFlags, out bool pfCancel);

    [DispId(8178)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [MarshalAs(UnmanagedType.BStr), In] string bstrURL, out bool pfCancel);

    [DispId(8162)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [MarshalAs(UnmanagedType.BStr), In] string bstrURL, [MarshalAs(UnmanagedType.BStr), In] string bstrContent, [In] ref byte pPostData, [In] uint dwPostDataSize, [In] int lResult);

    [DispId(8163)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, out bool pfResult);

    [DispId(8165)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0004([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph);

    [DispId(8166)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0005([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph);

    [DispId(8167)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0004([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] int lResult);

    [DispId(8168)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] int fStarted, [In] int lResult);

    [DispId(8169)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] bool fDelay);

    [DispId(8170)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] int lEventCode, [In] int lParam1, [In] int lParam2);

    [DispId(8171)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] uint dwAction);

    [DispId(8174)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0006([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph);

    [DispId(8177)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0007([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph);

    [DispId(8179)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0008([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph);

    [DispId(8180)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0002([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] uint dwBitrate);

    [DispId(8181)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [ComAliasName("WMPLib.ULONG_PTR"), In] uint punkFilterGraph, [ComAliasName("WMPLib.ULONG_PTR"), In] uint punkCardeaEncConfig, [ComAliasName("WMPLib.ULONG_PTR"), In] uint phrContinue, [ComAliasName("WMPLib.ULONG_PTR"), In] uint hEventToSet);

    [DispId(8182)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [ComAliasName("WMPLib.ULONG_PTR"), In] uint punkFilterGraph, [ComAliasName("WMPLib.ULONG_PTR"), In] uint phrContinue, [ComAliasName("WMPLib.ULONG_PTR"), In] uint hEventToSet);

    [DispId(8186)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0005([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [In] int EventCode);

    [DispId(8183)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0002([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, out bool pfResult);

    [DispId(8184)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph, [ComAliasName("WMPLib.ULONG_PTR"), In] uint phWnd, [ComAliasName("WMPLib.ULONG_PTR"), In] uint hIndivEvent, out bool pfCancel, out bool pfResult);

    [DispId(8185)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u000E([ComAliasName("WMPLib.ULONG_PTR"), In] uint punkGraph);
  }
}
