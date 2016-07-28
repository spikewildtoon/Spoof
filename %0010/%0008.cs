// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0010
{
  [Guid("4E195DB1-9E29-47FC-9CE1-DE9937D32925")]
  [TypeLibType(4160)]
  [ComImport]
  public interface \u0008
  {
    [DispId(1)]
    string TransportState { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(2)]
    string TransportStatus { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(3)]
    string PlaybackStorageMedium { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(4)]
    string RecordStorageMedium { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(5)]
    string PossiblePlaybackStorageMedia { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(6)]
    string PossibleRecordStorageMedia { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(7)]
    string CurrentPlayMode { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(8)]
    string TransportPlaySpeed { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(9)]
    string RecordMediumWriteStatus { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10)]
    string CurrentRecordQualityMode { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(11)]
    string PossibleRecordQualityModes { [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(12)]
    uint NumberOfTracks { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(13)]
    uint CurrentTrack { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(14)]
    string CurrentTrackDuration { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(15)]
    string CurrentMediaDuration { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(16)]
    string CurrentTrackMetaData { [DispId(16), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(17)]
    string CurrentTrackURI { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(18)]
    string AVTransportURI { [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(19)]
    string AVTransportURIMetaData { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(20)]
    string NextAVTransportURI { [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(21)]
    string NextAVTransportURIMetaData { [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(22)]
    string RelativeTimePosition { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(23)]
    string AbsoluteTimePosition { [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(24)]
    int RelativeCounterPosition { [DispId(24), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(25)]
    int AbsoluteCounterPosition { [DispId(25), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(26)]
    string CurrentTransportActions { [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(27)]
    string LastChange { [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(28)]
    string A_ARG_TYPE_SeekMode { [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(29)]
    string A_ARG_TYPE_SeekTarget { [DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(30)]
    uint A_ARG_TYPE_InstanceID { [DispId(30), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(45)]
    string CurrentProtocolInfo { [DispId(45), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(31)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([MarshalAs(UnmanagedType.IUnknown), In] object punkRemoteEndpointInfo, [In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr), In] string bstrCurrentURI, [MarshalAs(UnmanagedType.BStr), In] string bstrCurrentURIMetaData);

    [DispId(33)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] uint ulInstanceID, out uint pulNumTracks, [MarshalAs(UnmanagedType.BStr)] out string pbstrMediaDuration, [MarshalAs(UnmanagedType.BStr)] out string pbstrCurrentURI, [MarshalAs(UnmanagedType.BStr)] out string pbstrCurrentURIMetaData, [MarshalAs(UnmanagedType.BStr)] out string pbstrNextURI, [MarshalAs(UnmanagedType.BStr)] out string pNextURIMetaData, [MarshalAs(UnmanagedType.BStr)] out string pbstrPlayMedium, [MarshalAs(UnmanagedType.BStr)] out string pbstrRecordMedium, [MarshalAs(UnmanagedType.BStr)] out string pbstrWriteStatus);

    [DispId(34)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] out string pbstrCurrentTransportState, [MarshalAs(UnmanagedType.BStr)] out string pbstrCurrentTransportStatus, [MarshalAs(UnmanagedType.BStr)] out string pbstrCurrentSpeed);

    [DispId(35)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] uint ulInstanceID, out uint pTrack, [MarshalAs(UnmanagedType.BStr)] out string pbstrTrackDuration, [MarshalAs(UnmanagedType.BStr)] out string pbstrTrackMetaData, [MarshalAs(UnmanagedType.BStr)] out string pbstrTrackURI, [MarshalAs(UnmanagedType.BStr)] out string pbstrRelTime, [MarshalAs(UnmanagedType.BStr)] out string pbstrAbsTime, out int plRelCount, out int plAbsCount);

    [DispId(36)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0002([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] out string pbstrPlayMedia, [MarshalAs(UnmanagedType.BStr)] out string pbstrRecMedia, [MarshalAs(UnmanagedType.BStr)] out string pbstrRecQualityModes);

    [DispId(37)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] out string pbstrPlayMode, [MarshalAs(UnmanagedType.BStr)] out string pbstrRecQualityMode);

    [DispId(38)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u000F([In] uint ulInstanceID);

    [DispId(39)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr), In] string bstrSpeed);

    [DispId(40)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0010([In] uint ulInstanceID);

    [DispId(41)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0002([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr), In] string bstrUnit, [MarshalAs(UnmanagedType.BStr), In] string bstrTarget);

    [DispId(42)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0011([In] uint ulInstanceID);

    [DispId(43)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0012([In] uint ulInstanceID);

    [DispId(44)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr), In, Out] ref string pbstrActions);
  }
}
