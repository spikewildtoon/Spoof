// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0008;
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace \u0010
{
  internal sealed class \u0011 : \u0008.\u0008, IDisposable
  {
    private IConnectionPointContainer \u0001;
    private ArrayList \u0001;
    private IConnectionPoint \u0001;

    private void \u001D\u0005()
    {
      IConnectionPoint ppCP = (IConnectionPoint) null;
      Guid riid = new Guid(new byte[16]{ (byte) 49, (byte) 141, (byte) 252, (byte) 80, (byte) 172, (byte) 103, (byte) 211, (byte) 17, (byte) 189, (byte) 76, (byte) 0, (byte) 192, (byte) 79, (byte) 110, (byte) 165, (byte) 174 });
      this.\u0001.FindConnectionPoint(ref riid, out ppCP);
      this.\u0001 = ppCP;
      this.\u0001 = new ArrayList();
    }

    public virtual void add_onblur([In] \u000E obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onblur([In] \u000E obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_onfocus([In] \u000F obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onfocus([In] \u000F obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_onclick([In] \u0008.\u0010 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onclick([In] \u0008.\u0010 obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_ondblclick([In] \u0011 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_ondblclick([In] \u0011 obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_onmousedown([In] \u0012 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onmousedown([In] \u0012 obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_onmouseup([In] \u0013 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onmouseup([In] \u0013 obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_onmousemove([In] \u0014 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onmousemove([In] \u0014 obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_onmouseover([In] \u0015 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onmouseover([In] \u0015 obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_onmouseout([In] \u0016 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onmouseout([In] \u0016 obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_onkeypress([In] \u0017 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onkeypress([In] \u0017 obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_onkeydown([In] \u0018 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onkeydown([In] \u0018 obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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

    public virtual void add_onkeyup([In] \u0019 obj0)
    {
      bool lockTaken;
      try
      {
        Monitor.Enter((object) this, ref lockTaken);
        if (this.\u0001 == null)
          this.\u001D\u0005();
        \u0010.\u0010 obj = new \u0010.\u0010();
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

    public virtual void remove_onkeyup([In] \u0019 obj0)
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
          \u0010.\u0010 obj = (\u0010.\u0010) this.\u0001[index];
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
            this.\u0001.Unadvise(((\u0010.\u0010) this.\u0001[index]).\u0001);
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
