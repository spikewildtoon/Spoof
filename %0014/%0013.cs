// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0002;
using \u0010;
using \u0011;
using \u0012;
using \u0013;
using \u0014;
using System;
using System.Runtime.InteropServices;

namespace \u0014
{
  [ClassInterface(ClassInterfaceType.None)]
  internal sealed class \u0013 : \u0005
  {
    private \u001E \u0001;

    public \u0013([In] \u001E obj0)
    {
      this.\u0001 = obj0;
    }

    public virtual void CdromBurnError([In] \u001C obj0, [In] int obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u007F(obj0, obj1));
    }

    public virtual void LibraryConnect([In] \u0080 obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0081(obj0));
    }

    public virtual void LibraryDisconnect([In] \u0080 obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0011.\u0001(obj0));
    }

    public virtual void FolderScanStateChange([In] \u0002.\u0002 obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0003(obj0));
    }

    public virtual void StringCollectionChange([In] object obj0, [In] \u0003 obj1, [In] int obj2)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0005(obj0, obj1, obj2));
    }

    public virtual void MediaCollectionMediaAdded([In] object obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0007(obj0));
    }

    public virtual void MediaCollectionMediaRemoved([In] object obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u000E(obj0));
    }

    public virtual void PlaylistCollectionPlaylistSetAsDeleted([In] string obj0, [In] bool obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0011.\u0010(obj0, obj1));
    }

    public virtual void ModeChange([In] string obj0, [In] bool obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0011.\u0012(obj0, obj1));
    }

    public virtual void MediaError([In] object obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0011.\u0014(obj0));
    }

    public virtual void OpenPlaylistSwitch([In] object obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0016(obj0));
    }

    public virtual void DomainChange([In] string obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0018(obj0));
    }

    public virtual void SwitchedToPlayerApplication()
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new EventArgs());
    }

    public virtual void SwitchedToControl()
    {
      this.\u0001.\u001E\u0005((object) this.\u0001, new EventArgs());
    }

    public virtual void PlayerDockedStateChange()
    {
      this.\u0001.\u001F\u0005((object) this.\u0001, new EventArgs());
    }

    public virtual void PlayerReconnect()
    {
      this.\u0001.\u007F\u0005((object) this.\u0001, new EventArgs());
    }

    public virtual void Click([In] short obj0, [In] short obj1, [In] int obj2, [In] int obj3)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u001A(obj0, obj1, obj2, obj3));
    }

    public virtual void DoubleClick([In] short obj0, [In] short obj1, [In] int obj2, [In] int obj3)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u001C(obj0, obj1, obj2, obj3));
    }

    public virtual void KeyDown([In] short obj0, [In] short obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u001E(obj0, obj1));
    }

    public virtual void KeyPress([In] short obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u007F(obj0));
    }

    public virtual void KeyUp([In] short obj0, [In] short obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0081(obj0, obj1));
    }

    public virtual void MouseDown([In] short obj0, [In] short obj1, [In] int obj2, [In] int obj3)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0012.\u0001(obj0, obj1, obj2, obj3));
    }

    public virtual void MouseMove([In] short obj0, [In] short obj1, [In] int obj2, [In] int obj3)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0003(obj0, obj1, obj2, obj3));
    }

    public virtual void MouseUp([In] short obj0, [In] short obj1, [In] int obj2, [In] int obj3)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0005(obj0, obj1, obj2, obj3));
    }

    public virtual void DeviceConnect([In] \u0016 obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0007(obj0));
    }

    public virtual void DeviceDisconnect([In] \u0016 obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u000E(obj0));
    }

    public virtual void DeviceStatusChange([In] \u0016 obj0, [In] \u0017 obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0012.\u0010(obj0, obj1));
    }

    public virtual void DeviceSyncStateChange([In] \u0016 obj0, [In] \u0018 obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0012.\u0012(obj0, obj1));
    }

    public virtual void DeviceSyncError([In] \u0016 obj0, [In] object obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0012.\u0014(obj0, obj1));
    }

    public virtual void CreatePartnershipComplete([In] \u0016 obj0, [In] int obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0016(obj0, obj1));
    }

    public virtual void DeviceEstimation([In] \u0016 obj0, [In] int obj1, [In] long obj2, [In] long obj3)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0018(obj0, obj1, obj2, obj3));
    }

    public virtual void CdromRipStateChange([In] \u001A obj0, [In] \u001B obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u001A(obj0, obj1));
    }

    public virtual void CdromRipMediaError([In] \u001A obj0, [In] object obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u001C(obj0, obj1));
    }

    public virtual void CdromBurnStateChange([In] \u001C obj0, [In] \u007F obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u001E(obj0, obj1));
    }

    public virtual void CdromBurnMediaError([In] \u001C obj0, [In] object obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u007F(obj0, obj1));
    }

    public virtual void OpenStateChange([In] int obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0081(obj0));
    }

    public virtual void PlayStateChange([In] int obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0013.\u0001(obj0));
    }

    public virtual void AudioLanguageChange([In] int obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0003(obj0));
    }

    public virtual void StatusChange()
    {
      this.\u0001.\u0080\u0005((object) this.\u0001, new EventArgs());
    }

    public virtual void ScriptCommand([In] string obj0, [In] string obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0005(obj0, obj1));
    }

    public virtual void NewStream()
    {
      this.\u0001.\u0081\u0005((object) this.\u0001, new EventArgs());
    }

    public virtual void Disconnect([In] int obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0007(obj0));
    }

    public virtual void Buffering([In] bool obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u000E(obj0));
    }

    public virtual void Error()
    {
      this.\u0001.\u0082\u0005((object) this.\u0001, new EventArgs());
    }

    public virtual void Warning([In] int obj0, [In] int obj1, [In] string obj2)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0013.\u0010(obj0, obj1, obj2));
    }

    public virtual void EndOfStream([In] int obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0013.\u0012(obj0));
    }

    public virtual void PositionChange([In] double obj0, [In] double obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0013.\u0014(obj0, obj1));
    }

    public virtual void MarkerHit([In] int obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0016(obj0));
    }

    public virtual void DurationUnitChange([In] int obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0018(obj0));
    }

    public virtual void CdromMediaChange([In] int obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u001A(obj0));
    }

    public virtual void PlaylistChange([In] object obj0, [In] \u0001.\u0014 obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u001C(obj0, obj1));
    }

    public virtual void CurrentPlaylistChange([In] \u0001.\u0014 obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u001E(obj0));
    }

    public virtual void CurrentPlaylistItemAvailable([In] string obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u007F(obj0));
    }

    public virtual void MediaChange([In] object obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0081(obj0));
    }

    public virtual void CurrentMediaItemAvailable([In] string obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0014.\u0001(obj0));
    }

    public virtual void CurrentItemChange([In] object obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0003(obj0));
    }

    public virtual void MediaCollectionChange()
    {
      this.\u0001.\u0083\u0005((object) this.\u0001, new EventArgs());
    }

    public virtual void MediaCollectionAttributeStringAdded([In] string obj0, [In] string obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0005(obj0, obj1));
    }

    public virtual void MediaCollectionAttributeStringRemoved([In] string obj0, [In] string obj1)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0007(obj0, obj1));
    }

    public virtual void MediaCollectionAttributeStringChanged([In] string obj0, [In] string obj1, [In] string obj2)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u000E(obj0, obj1, obj2));
    }

    public virtual void PlaylistCollectionChange()
    {
      this.\u0001.\u0084\u0005((object) this.\u0001, new EventArgs());
    }

    public virtual void PlaylistCollectionPlaylistAdded([In] string obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0014.\u0010(obj0));
    }

    public virtual void PlaylistCollectionPlaylistRemoved([In] string obj0)
    {
      this.\u0001.\u001D\u0005((object) this.\u0001, new \u0014.\u0012(obj0));
    }
  }
}
