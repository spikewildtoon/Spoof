// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0002;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0002
{
  [TypeLibType(4112)]
  [InterfaceType(2)]
  [Guid("6BF52A51-394A-11D3-B153-00C04F79FAA6")]
  [ComImport]
  public interface \u0005
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

    [DispId(6501)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SwitchedToPlayerApplication();

    [DispId(6502)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SwitchedToControl();

    [DispId(6503)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlayerDockedStateChange();

    [DispId(6504)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PlayerReconnect();

    [DispId(6505)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Click([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

    [DispId(6506)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DoubleClick([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

    [DispId(6507)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void KeyDown([In] short nKeyCode, [In] short nShiftState);

    [DispId(6508)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void KeyPress([In] short nKeyAscii);

    [DispId(6509)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void KeyUp([In] short nKeyCode, [In] short nShiftState);

    [DispId(6510)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MouseDown([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

    [DispId(6511)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MouseMove([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

    [DispId(6512)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MouseUp([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

    [DispId(6513)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceConnect([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice);

    [DispId(6514)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceDisconnect([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice);

    [DispId(6515)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceStatusChange([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice, [In] \u0017 NewStatus);

    [DispId(6516)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceSyncStateChange([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice, [In] \u0018 NewState);

    [DispId(6517)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceSyncError([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice, [MarshalAs(UnmanagedType.IDispatch), In] object pMedia);

    [DispId(6518)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CreatePartnershipComplete([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice, [MarshalAs(UnmanagedType.Error), In] int hrResult);

    [DispId(6527)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeviceEstimation([MarshalAs(UnmanagedType.Interface), In] \u0016 pDevice, [MarshalAs(UnmanagedType.Error), In] int hrResult, [In] long qwEstimatedUsedSpace, [In] long qwEstimatedSpace);

    [DispId(6519)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromRipStateChange([MarshalAs(UnmanagedType.Interface), In] \u001A pCdromRip, [In] \u001B wmprs);

    [DispId(6520)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromRipMediaError([MarshalAs(UnmanagedType.Interface), In] \u001A pCdromRip, [MarshalAs(UnmanagedType.IDispatch), In] object pMedia);

    [DispId(6521)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromBurnStateChange([MarshalAs(UnmanagedType.Interface), In] \u001C pCdromBurn, [In] \u007F wmpbs);

    [DispId(6522)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromBurnMediaError([MarshalAs(UnmanagedType.Interface), In] \u001C pCdromBurn, [MarshalAs(UnmanagedType.IDispatch), In] object pMedia);

    [DispId(6523)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CdromBurnError([MarshalAs(UnmanagedType.Interface), In] \u001C pCdromBurn, [MarshalAs(UnmanagedType.Error), In] int hrError);

    [DispId(6524)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LibraryConnect([MarshalAs(UnmanagedType.Interface), In] \u0080 pLibrary);

    [DispId(6525)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LibraryDisconnect([MarshalAs(UnmanagedType.Interface), In] \u0080 pLibrary);

    [DispId(6526)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void FolderScanStateChange([In] \u0002.\u0002 wmpfss);

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
