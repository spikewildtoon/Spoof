// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u000E;
using \u000F;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u000E
{
  [ComVisible(false)]
  [TypeLibType(16)]
  internal interface \u000E
  {
    event \u000E.\u000F OpenStateChange;

    event \u0010 PlayStateChange;

    event \u0011 AudioLanguageChange;

    event \u0012 StatusChange;

    event \u0013 ScriptCommand;

    event \u0014 NewStream;

    event \u0015 Disconnect;

    event \u0016 Buffering;

    event \u0017 Error;

    event \u0018 Warning;

    event \u0019 EndOfStream;

    event \u001A PositionChange;

    event \u001B MarkerHit;

    event \u001C DurationUnitChange;

    event \u001D CdromMediaChange;

    event \u001E PlaylistChange;

    event \u001F CurrentPlaylistChange;

    event \u007F CurrentPlaylistItemAvailable;

    event \u0080 MediaChange;

    event \u0081 CurrentMediaItemAvailable;

    event \u0082 CurrentItemChange;

    event \u0001 MediaCollectionChange;

    event \u0002 MediaCollectionAttributeStringAdded;

    event \u0003 MediaCollectionAttributeStringRemoved;

    event \u0004 MediaCollectionAttributeStringChanged;

    event \u0005 PlaylistCollectionChange;

    event \u0006 PlaylistCollectionPlaylistAdded;

    event \u0007 PlaylistCollectionPlaylistRemoved;

    event \u0008 PlaylistCollectionPlaylistSetAsDeleted;

    event \u000F.\u000E ModeChange;

    event \u000F.\u000F MediaError;

    event \u0010 OpenPlaylistSwitch;

    event \u0011 DomainChange;

    event \u0012 StringCollectionChange;

    event \u0013 MediaCollectionMediaAdded;

    event \u0014 MediaCollectionMediaRemoved;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OpenStateChange([In] \u000E.\u000F obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OpenStateChange([In] \u000E.\u000F obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PlayStateChange([In] \u0010 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PlayStateChange([In] \u0010 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_AudioLanguageChange([In] \u0011 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_AudioLanguageChange([In] \u0011 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_StatusChange([In] \u0012 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_StatusChange([In] \u0012 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ScriptCommand([In] \u0013 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ScriptCommand([In] \u0013 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NewStream([In] \u0014 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NewStream([In] \u0014 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_Disconnect([In] \u0015 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_Disconnect([In] \u0015 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_Buffering([In] \u0016 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_Buffering([In] \u0016 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_Error([In] \u0017 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_Error([In] \u0017 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_Warning([In] \u0018 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_Warning([In] \u0018 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_EndOfStream([In] \u0019 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_EndOfStream([In] \u0019 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PositionChange([In] \u001A obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PositionChange([In] \u001A obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_MarkerHit([In] \u001B obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_MarkerHit([In] \u001B obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DurationUnitChange([In] \u001C obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DurationUnitChange([In] \u001C obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CdromMediaChange([In] \u001D obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CdromMediaChange([In] \u001D obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PlaylistChange([In] \u001E obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PlaylistChange([In] \u001E obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CurrentPlaylistChange([In] \u001F obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CurrentPlaylistChange([In] \u001F obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CurrentPlaylistItemAvailable([In] \u007F obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CurrentPlaylistItemAvailable([In] \u007F obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_MediaChange([In] \u0080 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_MediaChange([In] \u0080 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CurrentMediaItemAvailable([In] \u0081 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CurrentMediaItemAvailable([In] \u0081 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CurrentItemChange([In] \u0082 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CurrentItemChange([In] \u0082 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_MediaCollectionChange([In] \u0001 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_MediaCollectionChange([In] \u0001 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_MediaCollectionAttributeStringAdded([In] \u0002 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_MediaCollectionAttributeStringAdded([In] \u0002 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_MediaCollectionAttributeStringRemoved([In] \u0003 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_MediaCollectionAttributeStringRemoved([In] \u0003 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_MediaCollectionAttributeStringChanged([In] \u0004 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_MediaCollectionAttributeStringChanged([In] \u0004 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PlaylistCollectionChange([In] \u0005 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PlaylistCollectionChange([In] \u0005 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PlaylistCollectionPlaylistAdded([In] \u0006 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PlaylistCollectionPlaylistAdded([In] \u0006 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PlaylistCollectionPlaylistRemoved([In] \u0007 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PlaylistCollectionPlaylistRemoved([In] \u0007 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PlaylistCollectionPlaylistSetAsDeleted([In] \u0008 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PlaylistCollectionPlaylistSetAsDeleted([In] \u0008 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ModeChange([In] \u000F.\u000E obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ModeChange([In] \u000F.\u000E obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_MediaError([In] \u000F.\u000F obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_MediaError([In] \u000F.\u000F obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OpenPlaylistSwitch([In] \u0010 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OpenPlaylistSwitch([In] \u0010 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DomainChange([In] \u0011 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DomainChange([In] \u0011 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_StringCollectionChange([In] \u0012 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_StringCollectionChange([In] \u0012 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_MediaCollectionMediaAdded([In] \u0013 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_MediaCollectionMediaAdded([In] \u0013 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_MediaCollectionMediaRemoved([In] \u0014 obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_MediaCollectionMediaRemoved([In] \u0014 obj0);
  }
}
