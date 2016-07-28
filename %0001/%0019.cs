// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0002;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0001
{
  [Guid("1F504270-A66B-4223-8E96-26A06C63D69F")]
  [InterfaceType(1)]
  [ComImport]
  public interface \u0019 : \u0015
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OpenStateChange([In] int NewState);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlayStateChange([In] int NewState);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AudioLanguageChange([In] int LangID);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StatusChange();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ScriptCommand([MarshalAs(UnmanagedType.BStr), In] string scType, [MarshalAs(UnmanagedType.BStr), In] string Param);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NewStream();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Disconnect([In] int Result);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Buffering([In] bool Start);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Error();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Warning([In] int WarningType, [In] int Param, [MarshalAs(UnmanagedType.BStr), In] string Description);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void EndOfStream([In] int Result);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PositionChange([In] double oldPosition, [In] double newPosition);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MarkerHit([In] int MarkerNum);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DurationUnitChange([In] int NewDurationUnit);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromMediaChange([In] int CdromNum);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlaylistChange([MarshalAs(UnmanagedType.IDispatch), In] object Playlist, [In] \u0014 change);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CurrentPlaylistChange([In] \u0014 change);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CurrentPlaylistItemAvailable([MarshalAs(UnmanagedType.BStr), In] string bstrItemName);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaChange([MarshalAs(UnmanagedType.IDispatch), In] object Item);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CurrentMediaItemAvailable([MarshalAs(UnmanagedType.BStr), In] string bstrItemName);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CurrentItemChange([MarshalAs(UnmanagedType.IDispatch), In] object pdispMedia);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionChange();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionAttributeStringAdded([MarshalAs(UnmanagedType.BStr), In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr), In] string bstrAttribVal);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionAttributeStringRemoved([MarshalAs(UnmanagedType.BStr), In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr), In] string bstrAttribVal);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionAttributeStringChanged([MarshalAs(UnmanagedType.BStr), In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr), In] string bstrOldAttribVal, [MarshalAs(UnmanagedType.BStr), In] string bstrNewAttribVal);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlaylistCollectionChange();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlaylistCollectionPlaylistAdded([MarshalAs(UnmanagedType.BStr), In] string bstrPlaylistName);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlaylistCollectionPlaylistRemoved([MarshalAs(UnmanagedType.BStr), In] string bstrPlaylistName);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlaylistCollectionPlaylistSetAsDeleted([MarshalAs(UnmanagedType.BStr), In] string bstrPlaylistName, [In] bool varfIsDeleted);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ModeChange([MarshalAs(UnmanagedType.BStr), In] string ModeName, [In] bool NewValue);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaError([MarshalAs(UnmanagedType.IDispatch), In] object pMediaObject);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OpenPlaylistSwitch([MarshalAs(UnmanagedType.IDispatch), In] object pItem);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DomainChange([MarshalAs(UnmanagedType.BStr), In] string strDomain);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SwitchedToPlayerApplication();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SwitchedToControl();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlayerDockedStateChange();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlayerReconnect();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Click([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DoubleClick([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void KeyDown([In] short nKeyCode, [In] short nShiftState);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void KeyPress([In] short nKeyAscii);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void KeyUp([In] short nKeyCode, [In] short nShiftState);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MouseDown([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MouseMove([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MouseUp([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceConnect([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceDisconnect([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceStatusChange([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice, [In] \u0017 NewStatus);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceSyncStateChange([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice, [In] \u0018 NewState);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceSyncError([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice, [MarshalAs(UnmanagedType.IDispatch), In] object pMedia);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CreatePartnershipComplete([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice, [MarshalAs(UnmanagedType.Error), In] int hrResult);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromRipStateChange([MarshalAs(UnmanagedType.Interface), In] \u001A pCdromRip, [In] \u001B wmprs);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromRipMediaError([MarshalAs(UnmanagedType.Interface), In] \u001A pCdromRip, [MarshalAs(UnmanagedType.IDispatch), In] object pMedia);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromBurnStateChange([MarshalAs(UnmanagedType.Interface), In] \u001C pCdromBurn, [In] \u007F wmpbs);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromBurnMediaError([MarshalAs(UnmanagedType.Interface), In] \u001C pCdromBurn, [MarshalAs(UnmanagedType.IDispatch), In] object pMedia);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromBurnError([MarshalAs(UnmanagedType.Interface), In] \u001C pCdromBurn, [MarshalAs(UnmanagedType.Error), In] int hrError);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LibraryConnect([MarshalAs(UnmanagedType.Interface), In] \u0080 pLibrary);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LibraryDisconnect([MarshalAs(UnmanagedType.Interface), In] \u0080 pLibrary);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void FolderScanStateChange([In] \u0002.\u0002 wmpfss);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StringCollectionChange([MarshalAs(UnmanagedType.IDispatch), In] object pdispStringCollection, [In] \u0003 change, [In] int lCollectionIndex);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionMediaAdded([MarshalAs(UnmanagedType.IDispatch), In] object pdispMedia);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MediaCollectionMediaRemoved([MarshalAs(UnmanagedType.IDispatch), In] object pdispMedia);
  }
}
