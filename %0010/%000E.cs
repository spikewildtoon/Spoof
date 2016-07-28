// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0010
{
  [Guid("FB61CD38-8DE7-4479-8B76-A8D097C20C70")]
  [TypeLibType(4160)]
  [ComImport]
  public interface \u000E
  {
    [DispId(1)]
    string SourceProtocolInfo { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(2)]
    string SinkProtocolInfo { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(3)]
    string CurrentConnectionIDs { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(4)]
    string A_ARG_TYPE_ConnectionStatus { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(5)]
    string A_ARG_TYPE_ConnectionManager { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(6)]
    string A_ARG_TYPE_Direction { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(7)]
    string A_ARG_TYPE_ProtocolInfo { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(8)]
    int A_ARG_TYPE_ConnectionID { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(9)]
    int A_ARG_TYPE_AVTransportID { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10)]
    int A_ARG_TYPE_RcsID { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(11)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([MarshalAs(UnmanagedType.BStr), In, Out] ref string pbstrSource, [MarshalAs(UnmanagedType.BStr), In, Out] ref string pbstrSink);

    [DispId(12)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0004([MarshalAs(UnmanagedType.BStr), In, Out] ref string pbstrConnectionIDs);

    [DispId(13)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] int lConnectionID, [In, Out] ref int plResID, [In, Out] ref int plAVTransportID, [MarshalAs(UnmanagedType.BStr), In, Out] ref string pbstrProtocolInfo, [MarshalAs(UnmanagedType.BStr), In, Out] ref string pbstrPeerConnectionManager, [In, Out] ref int plPeerConnectionID, [MarshalAs(UnmanagedType.BStr), In, Out] ref string pbstrDirection, [MarshalAs(UnmanagedType.BStr), In, Out] ref string pbstrStatus);
  }
}
