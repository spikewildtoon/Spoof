// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0008;
using \u0010;
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace \u0010
{
  internal sealed class \u001B : \u001E, IDisposable
  {
    private IConnectionPointContainer \u0001;
    private ArrayList \u0001;
    private IConnectionPoint \u0001;

    private void \u001D\u0005()
    {
      IConnectionPoint ppCP = (IConnectionPoint) null;
      Guid riid = new Guid(new byte[16]{ (byte) 164, (byte) 90, (byte) 244, (byte) 149, (byte) 10, (byte) 237, (byte) 210, (byte) 17, (byte) 186, (byte) 103, (byte) 0, (byte) 0, (byte) 248, (byte) 8, (byte) 85, (byte) 230 });
      this.\u0001.FindConnectionPoint(ref riid, out ppCP);
      this.\u0001 = ppCP;
      this.\u0001 = new ArrayList();
    }

    public virtual void add_ondragbegin([In] \u001F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u001A obj = new \u001A();
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

    public virtual void remove_ondragbegin([In] \u001F obj0)
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
          \u001A obj = (\u001A) this.\u0001[index];
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

    public virtual void add_ondragend([In] \u007F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u001A obj = new \u001A();
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

    public virtual void remove_ondragend([In] \u007F obj0)
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
          \u001A obj = (\u001A) this.\u0001[index];
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

    public virtual void add_onpositionchange([In] \u0080 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u001A obj = new \u001A();
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

    public virtual void remove_onpositionchange([In] \u0080 obj0)
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
          \u001A obj = (\u001A) this.\u0001[index];
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
            this.\u0001.Unadvise(((\u001A) this.\u0001[index]).\u0001);
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
