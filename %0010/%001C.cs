// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0002;
using \u000E;
using \u000F;
using System.Runtime.InteropServices;

namespace \u0010
{
  [ClassInterface(ClassInterfaceType.None)]
  [TypeLibType(TypeLibTypeFlags.FHidden)]
  internal sealed class \u001C : \u0007
  {
    public \u0008 \u0001;
    public \u000F.\u000E \u0001;
    public \u000F.\u000F \u0001;
    public \u0010 \u0001;
    public \u0011 \u0001;
    public \u0012 \u0001;
    public \u0013 \u0001;
    public \u0014 \u0001;
    public \u000E.\u000F \u0001;
    public \u0010 \u0001;
    public \u0011 \u0001;
    public \u0012 \u0001;
    public \u0013 \u0001;
    public \u0014 \u0001;
    public \u0015 \u0001;
    public \u0016 \u0001;
    public \u0017 \u0001;
    public \u0018 \u0001;
    public \u0019 \u0001;
    public \u001A \u0001;
    public \u001B \u0001;
    public \u001C \u0001;
    public \u001D \u0001;
    public \u001E \u0001;
    public \u001F \u0001;
    public \u007F \u0001;
    public \u0080 \u0001;
    public \u0081 \u0001;
    public \u0082 \u0001;
    public \u000F.\u0001 \u0001;
    public \u000F.\u0002 \u0001;
    public \u0003 \u0001;
    public \u0004 \u0001;
    public \u0005 \u0001;
    public \u0006 \u0001;
    public \u0007 \u0001;
    public int \u0001;

    internal \u001C()
    {
      this.\u0001 = 0;
      this.\u0001 = (\u0008) null;
      this.\u0001 = (\u000F.\u000E) null;
      this.\u0001 = (\u000F.\u000F) null;
      this.\u0001 = (\u0010) null;
      this.\u0001 = (\u0011) null;
      this.\u0001 = (\u0012) null;
      this.\u0001 = (\u0013) null;
      this.\u0001 = (\u0014) null;
      this.\u0001 = (\u000E.\u000F) null;
      this.\u0001 = (\u0010) null;
      this.\u0001 = (\u0011) null;
      this.\u0001 = (\u0012) null;
      this.\u0001 = (\u0013) null;
      this.\u0001 = (\u0014) null;
      this.\u0001 = (\u0015) null;
      this.\u0001 = (\u0016) null;
      this.\u0001 = (\u0017) null;
      this.\u0001 = (\u0018) null;
      this.\u0001 = (\u0019) null;
      this.\u0001 = (\u001A) null;
      this.\u0001 = (\u001B) null;
      this.\u0001 = (\u001C) null;
      this.\u0001 = (\u001D) null;
      this.\u0001 = (\u001E) null;
      this.\u0001 = (\u001F) null;
      this.\u0001 = (\u007F) null;
      this.\u0001 = (\u0080) null;
      this.\u0001 = (\u0081) null;
      this.\u0001 = (\u0082) null;
      this.\u0001 = (\u000F.\u0001) null;
      this.\u0001 = (\u000F.\u0002) null;
      this.\u0001 = (\u0003) null;
      this.\u0001 = (\u0004) null;
      this.\u0001 = (\u0005) null;
      this.\u0001 = (\u0006) null;
      this.\u0001 = (\u0007) null;
    }

    public virtual void PlaylistCollectionPlaylistSetAsDeleted([In] string obj0, [In] bool obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    public virtual void ModeChange([In] string obj0, [In] bool obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    public virtual void MediaError([In] object obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void OpenPlaylistSwitch([In] object obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void DomainChange([In] string obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void StringCollectionChange([In] object obj0, [In] \u0003 obj1, [In] int obj2)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1, obj2);
    }

    public virtual void MediaCollectionMediaAdded([In] object obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void MediaCollectionMediaRemoved([In] object obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void OpenStateChange([In] int obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void PlayStateChange([In] int obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void AudioLanguageChange([In] int obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void StatusChange()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001();
    }

    public virtual void ScriptCommand([In] string obj0, [In] string obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    public virtual void NewStream()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001();
    }

    public virtual void Disconnect([In] int obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void Buffering([In] bool obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void Error()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001();
    }

    public virtual void Warning([In] int obj0, [In] int obj1, [In] string obj2)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1, obj2);
    }

    public virtual void EndOfStream([In] int obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void PositionChange([In] double obj0, [In] double obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    public virtual void MarkerHit([In] int obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void DurationUnitChange([In] int obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void CdromMediaChange([In] int obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void PlaylistChange([In] object obj0, [In] \u0014 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    public virtual void CurrentPlaylistChange([In] \u0014 obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void CurrentPlaylistItemAvailable([In] string obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void MediaChange([In] object obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void CurrentMediaItemAvailable([In] string obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void CurrentItemChange([In] object obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void MediaCollectionChange()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001();
    }

    public virtual void MediaCollectionAttributeStringAdded([In] string obj0, [In] string obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    public virtual void MediaCollectionAttributeStringRemoved([In] string obj0, [In] string obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    public virtual void MediaCollectionAttributeStringChanged([In] string obj0, [In] string obj1, [In] string obj2)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1, obj2);
    }

    public virtual void PlaylistCollectionChange()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001();
    }

    public virtual void PlaylistCollectionPlaylistAdded([In] string obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }

    public virtual void PlaylistCollectionPlaylistRemoved([In] string obj0)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0);
    }
  }
}
