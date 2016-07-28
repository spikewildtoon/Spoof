// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0010
{
  [Guid("FF4B1BDA-19F0-42CF-8DDA-19162950C543")]
  [TypeLibType(4160)]
  [ComImport]
  public interface \u000F
  {
    [DispId(1)]
    string LastChange { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(2)]
    string PresetNameList { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(3)]
    bool mute { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(4)]
    ushort volume { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(5)]
    string A_ARG_TYPE_Channel { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(6)]
    uint A_ARG_TYPE_InstanceID { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(7)]
    string A_ARG_TYPE_PresetName { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(8)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0002([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr), In, Out] ref string pbstrCurrentPresetList);

    [DispId(9)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0002([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr), In] string bstrPresetName);

    [DispId(10)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0002([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr), In] string bstrChannel, [In, Out] ref bool pbCurrentMute);

    [DispId(11)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr), In] string bstrChannel, [In] bool bDesiredMute);

    [DispId(12)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr), In] string bstrChannel, [In, Out] ref ushort puiCurrentVolume);

    [DispId(13)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr), In] string bstrChannel, [In] ushort uiDesiredVolume);
  }
}
