// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0002;
using \u0003;
using \u0004;
using \u0010;
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace \u0010
{
  internal sealed class \u0019 : \u0007, IDisposable
  {
    private IConnectionPointContainer \u0001;
    private ArrayList \u0001;
    private IConnectionPoint \u0001;

    private void \u001D\u0005()
    {
      IConnectionPoint ppCP = (IConnectionPoint) null;
      Guid riid = new Guid(new byte[16]{ (byte) 81, (byte) 42, (byte) 245, (byte) 107, (byte) 74, (byte) 57, (byte) 211, (byte) 17, (byte) 177, (byte) 83, (byte) 0, (byte) 192, (byte) 79, (byte) 121, (byte) 250, (byte) 166 });
      this.\u0001.FindConnectionPoint(ref riid, out ppCP);
      this.\u0001 = ppCP;
      this.\u0001 = new ArrayList();
    }

    public virtual void add_CdromBurnError([In] \u0004.\u0004 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CdromBurnError([In] \u0004.\u0004 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_LibraryConnect([In] \u0005 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_LibraryConnect([In] \u0005 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_LibraryDisconnect([In] \u0006 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_LibraryDisconnect([In] \u0006 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_FolderScanStateChange([In] \u0007 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_FolderScanStateChange([In] \u0007 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_StringCollectionChange([In] \u0008 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_StringCollectionChange([In] \u0008 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MediaCollectionMediaAdded([In] \u000E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MediaCollectionMediaAdded([In] \u000E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MediaCollectionMediaRemoved([In] \u000F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MediaCollectionMediaRemoved([In] \u000F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_PlaylistCollectionPlaylistSetAsDeleted([In] \u0006 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_PlaylistCollectionPlaylistSetAsDeleted([In] \u0006 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_ModeChange([In] \u0007 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_ModeChange([In] \u0007 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MediaError([In] \u0008 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MediaError([In] \u0008 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_OpenPlaylistSwitch([In] \u000E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_OpenPlaylistSwitch([In] \u000E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_DomainChange([In] \u000F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DomainChange([In] \u000F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_SwitchedToPlayerApplication([In] \u0003.\u0010 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_SwitchedToPlayerApplication([In] \u0003.\u0010 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_SwitchedToControl([In] \u0011 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_SwitchedToControl([In] \u0011 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_PlayerDockedStateChange([In] \u0012 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_PlayerDockedStateChange([In] \u0012 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_PlayerReconnect([In] \u0013 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_PlayerReconnect([In] \u0013 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_Click([In] \u0014 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_Click([In] \u0014 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_DoubleClick([In] \u0015 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DoubleClick([In] \u0015 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_KeyDown([In] \u0016 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_KeyDown([In] \u0016 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_KeyPress([In] \u0017 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_KeyPress([In] \u0017 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_KeyUp([In] \u0018 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_KeyUp([In] \u0018 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MouseDown([In] \u0019 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MouseDown([In] \u0019 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MouseMove([In] \u001A obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MouseMove([In] \u001A obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MouseUp([In] \u001B obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MouseUp([In] \u001B obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_DeviceConnect([In] \u001C obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DeviceConnect([In] \u001C obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_DeviceDisconnect([In] \u001D obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DeviceDisconnect([In] \u001D obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_DeviceStatusChange([In] \u001E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DeviceStatusChange([In] \u001E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_DeviceSyncStateChange([In] \u001F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DeviceSyncStateChange([In] \u001F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_DeviceSyncError([In] \u007F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DeviceSyncError([In] \u007F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_CreatePartnershipComplete([In] \u0080 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CreatePartnershipComplete([In] \u0080 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_DeviceEstimation([In] \u0081 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DeviceEstimation([In] \u0081 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_CdromRipStateChange([In] \u0082 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CdromRipStateChange([In] \u0082 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_CdromRipMediaError([In] \u0001 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CdromRipMediaError([In] \u0001 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_CdromBurnStateChange([In] \u0004.\u0002 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CdromBurnStateChange([In] \u0004.\u0002 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_CdromBurnMediaError([In] \u0004.\u0003 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CdromBurnMediaError([In] \u0004.\u0003 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_OpenStateChange([In] \u0008 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_OpenStateChange([In] \u0008 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_PlayStateChange([In] \u000E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_PlayStateChange([In] \u000E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_AudioLanguageChange([In] \u000F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_AudioLanguageChange([In] \u000F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_StatusChange([In] \u0002.\u0010 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_StatusChange([In] \u0002.\u0010 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_ScriptCommand([In] \u0011 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_ScriptCommand([In] \u0011 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_NewStream([In] \u0012 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_NewStream([In] \u0012 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_Disconnect([In] \u0013 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_Disconnect([In] \u0013 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_Buffering([In] \u0014 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_Buffering([In] \u0014 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_Error([In] \u0015 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_Error([In] \u0015 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_Warning([In] \u0016 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_Warning([In] \u0016 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_EndOfStream([In] \u0017 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_EndOfStream([In] \u0017 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_PositionChange([In] \u0018 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_PositionChange([In] \u0018 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MarkerHit([In] \u0019 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MarkerHit([In] \u0019 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_DurationUnitChange([In] \u001A obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DurationUnitChange([In] \u001A obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_CdromMediaChange([In] \u001B obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CdromMediaChange([In] \u001B obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_PlaylistChange([In] \u001C obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_PlaylistChange([In] \u001C obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_CurrentPlaylistChange([In] \u001D obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CurrentPlaylistChange([In] \u001D obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_CurrentPlaylistItemAvailable([In] \u001E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CurrentPlaylistItemAvailable([In] \u001E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MediaChange([In] \u001F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MediaChange([In] \u001F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_CurrentMediaItemAvailable([In] \u007F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CurrentMediaItemAvailable([In] \u007F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_CurrentItemChange([In] \u0080 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CurrentItemChange([In] \u0080 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MediaCollectionChange([In] \u0081 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MediaCollectionChange([In] \u0081 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MediaCollectionAttributeStringAdded([In] \u0082 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MediaCollectionAttributeStringAdded([In] \u0082 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MediaCollectionAttributeStringRemoved([In] \u0001 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MediaCollectionAttributeStringRemoved([In] \u0001 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_MediaCollectionAttributeStringChanged([In] \u0003.\u0002 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_MediaCollectionAttributeStringChanged([In] \u0003.\u0002 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_PlaylistCollectionChange([In] \u0003.\u0003 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_PlaylistCollectionChange([In] \u0003.\u0003 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_PlaylistCollectionPlaylistAdded([In] \u0003.\u0004 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_PlaylistCollectionPlaylistAdded([In] \u0003.\u0004 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void add_PlaylistCollectionPlaylistRemoved([In] \u0005 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0018 obj = new \u0018();
        int pdwCookie = 0;
        this.\u0001.Advise((object) obj, out pdwCookie);
        obj.\u0001 = pdwCookie;
        obj.\u0001 = obj0;
        this.\u0001.Add((object) obj);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void remove_PlaylistCollectionPlaylistRemoved([In] \u0005 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          \u0018 obj = (\u0018) this.\u0001[index];
          if (obj.\u0001 != null && ((obj.\u0001.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.\u0001.RemoveAt(index);
            this.\u0001.Unadvise(obj.\u0001);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.\u0001);
              this.\u0001 = (IConnectionPoint) null;
              this.\u0001 = (ArrayList) null;
              return;
            }
            goto label_11;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_12;
label_11:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public override void Finalize()
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          return;
        int count = this.\u0001.Count;
        int index = 0;
        if (0 < count)
        {
          do
          {
            this.\u0001.Unadvise(((\u0018) this.\u0001[index]).\u0001);
            ++index;
          }
          while (index < count);
        }
        Marshal.ReleaseComObject((object) this.\u0001);
      }
      catch (Exception ex)
      {
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) this);
      }
    }

    public virtual void Dispose()
    {
      this.Finalize();
      GC.SuppressFinalize((object) this);
    }
  }
}
