// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0004
{
  [TypeLibType(4160)]
  [Guid("EC21B779-EDEF-462D-BBA4-AD9DDE2B29A7")]
  [ComImport]
  public interface \u001B
  {
    [DispId(801)]
    int bandWidth { [DispId(801), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(802)]
    int recoveredPackets { [DispId(802), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(803)]
    string sourceProtocol { [DispId(803), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(804)]
    int receivedPackets { [DispId(804), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(805)]
    int lostPackets { [DispId(805), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(806)]
    int receptionQuality { [DispId(806), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(807)]
    int bufferingCount { [DispId(807), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(808)]
    int bufferingProgress { [DispId(808), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(809)]
    int bufferingTime { [DispId(809), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(809), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(810)]
    int frameRate { [DispId(810), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(811)]
    int maxBitRate { [DispId(811), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(812)]
    int bitRate { [DispId(812), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(823)]
    int maxBandwidth { [DispId(823), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(823), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(824)]
    int downloadProgress { [DispId(824), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(825)]
    int encodedFrameRate { [DispId(825), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(826)]
    int framesSkipped { [DispId(826), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(813)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int \u0002([MarshalAs(UnmanagedType.BStr), In] string bstrProtocol);

    [DispId(814)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrProtocol, [In] int lProxySetting);

    [DispId(815)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string \u0002([MarshalAs(UnmanagedType.BStr), In] string bstrProtocol);

    [DispId(816)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0005([MarshalAs(UnmanagedType.BStr), In] string bstrProtocol, [MarshalAs(UnmanagedType.BStr), In] string bstrProxyName);

    [DispId(817)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int \u0003([MarshalAs(UnmanagedType.BStr), In] string bstrProtocol);

    [DispId(818)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0002([MarshalAs(UnmanagedType.BStr), In] string bstrProtocol, [In] int lProxyPort);

    [DispId(819)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string \u0003([MarshalAs(UnmanagedType.BStr), In] string bstrProtocol);

    [DispId(820)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0006([MarshalAs(UnmanagedType.BStr), In] string bstrProtocol, [MarshalAs(UnmanagedType.BStr), In] string pbstrExceptionList);

    [DispId(821)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool \u0005([MarshalAs(UnmanagedType.BStr), In] string bstrProtocol);

    [DispId(822)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0004([MarshalAs(UnmanagedType.BStr), In] string bstrProtocol, [In] bool fBypassForLocal);
  }
}
