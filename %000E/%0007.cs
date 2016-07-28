// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0002;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u000E
{
  [InterfaceType(2)]
  [Guid("D84CCA96-CCE2-11D2-9ECC-0000F8085981")]
  [TypeLibType(4112)]
  [ComImport]
  public interface \u0007
  {
    [DispId(5001)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OpenStateChange([In] int NewState);

    [DispId(5101)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlayStateChange([In] int NewState);

    [DispId(5102)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AudioLanguageChange([In] int LangID);

    [DispId(5002)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StatusChange();

    [DispId(5301)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ScriptCommand([MarshalAs(UnmanagedType.BStr), In] string scType, [MarshalAs(UnmanagedType.BStr), In] string Param);

    [DispId(5403)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NewStream();

    [DispId(5401)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Disconnect([In] int Result);

    [DispId(5402)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Buffering([In] bool Start);

    [DispId(5501)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Error();

    [DispId(5601)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Warning([In] int WarningType, [In] int Param, [MarshalAs(UnmanagedType.BStr), In] string Description);

    [DispId(5201)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void EndOfStream([In] int Result);

    [DispId(5202)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PositionChange([In] double oldPosition, [In] double newPosition);

    [DispId(5203)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MarkerHit([In] int MarkerNum);

    [DispId(5204)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DurationUnitChange([In] int NewDurationUnit);

    [DispId(5701)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromMediaChange([In] int CdromNum);

    [DispId(5801)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlaylistChange([MarshalAs(UnmanagedType.IDispatch), In] object Playlist, [In] \u0014 change);

    [DispId(5804)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CurrentPlaylistChange([In] \u0014 change);

    [DispId(5805)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CurrentPlaylistItemAvailable([MarshalAs(UnmanagedType.BStr), In] string bstrItemName);

    [DispId(5802)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaChange([MarshalAs(UnmanagedType.IDispatch), In] object Item);

    [DispId(5803)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CurrentMediaItemAvailable([MarshalAs(UnmanagedType.BStr), In] string bstrItemName);

    [DispId(5806)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CurrentItemChange([MarshalAs(UnmanagedType.IDispatch), In] object pdispMedia);

    [DispId(5807)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionChange();

    [DispId(5808)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionAttributeStringAdded([MarshalAs(UnmanagedType.BStr), In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr), In] string bstrAttribVal);

    [DispId(5809)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionAttributeStringRemoved([MarshalAs(UnmanagedType.BStr), In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr), In] string bstrAttribVal);

    [DispId(5820)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionAttributeStringChanged([MarshalAs(UnmanagedType.BStr), In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr), In] string bstrOldAttribVal, [MarshalAs(UnmanagedType.BStr), In] string bstrNewAttribVal);

    [DispId(5810)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlaylistCollectionChange();

    [DispId(5811)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlaylistCollectionPlaylistAdded([MarshalAs(UnmanagedType.BStr), In] string bstrPlaylistName);

    [DispId(5812)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlaylistCollectionPlaylistRemoved([MarshalAs(UnmanagedType.BStr), In] string bstrPlaylistName);

    [DispId(5818)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlaylistCollectionPlaylistSetAsDeleted([MarshalAs(UnmanagedType.BStr), In] string bstrPlaylistName, [In] bool varfIsDeleted);

    [DispId(5819)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ModeChange([MarshalAs(UnmanagedType.BStr), In] string ModeName, [In] bool NewValue);

    [DispId(5821)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaError([MarshalAs(UnmanagedType.IDispatch), In] object pMediaObject);

    [DispId(5823)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OpenPlaylistSwitch([MarshalAs(UnmanagedType.IDispatch), In] object pItem);

    [DispId(5822)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DomainChange([MarshalAs(UnmanagedType.BStr), In] string strDomain);

    [DispId(5824)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StringCollectionChange([MarshalAs(UnmanagedType.IDispatch), In] object pdispStringCollection, [In] \u0003 change, [In] int lCollectionIndex);

    [DispId(5825)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionMediaAdded([MarshalAs(UnmanagedType.IDispatch), In] object pdispMedia);

    [DispId(5826)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionMediaRemoved([MarshalAs(UnmanagedType.IDispatch), In] object pdispMedia);
  }
}
