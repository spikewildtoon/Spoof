// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0002;
using \u0004;
using \u0010;
using \u0011;
using \u0012;
using \u0013;
using \u0014;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace \u0010
{
  internal sealed class \u001E : AxHost
  {
    [NonSerialized]
    internal static \u0001.\u0002 \u0001;
    private \u0004.\u0011 \u0001;
    private \u0014.\u0013 \u0001;
    private AxHost.ConnectionPointCookie \u0001;
    private \u001F \u0001;
    private \u0080 \u0001;
    private \u0082 \u0001;
    private \u0011.\u0002 \u0001;
    private \u0011.\u0004 \u0001;
    private \u0006 \u0001;
    private \u0008 \u0001;
    private \u000F \u0001;
    private \u0011.\u0011 \u0001;
    private \u0011.\u0013 \u0001;
    private \u0015 \u0001;
    private \u0017 \u0001;
    private EventHandler \u0001;
    private EventHandler \u0002;
    private EventHandler \u0003;
    private EventHandler \u0004;
    private \u0019 \u0001;
    private \u001B \u0001;
    private \u001D \u0001;
    private \u001F \u0001;
    private \u0080 \u0001;
    private \u0082 \u0001;
    private \u0012.\u0002 \u0001;
    private \u0012.\u0004 \u0001;
    private \u0006 \u0001;
    private \u0008 \u0001;
    private \u000F \u0001;
    private \u0012.\u0011 \u0001;
    private \u0012.\u0013 \u0001;
    private \u0015 \u0001;
    private \u0017 \u0001;
    private \u0019 \u0001;
    private \u001B \u0001;
    private \u001D \u0001;
    private \u001F \u0001;
    private \u0080 \u0001;
    private \u0082 \u0001;
    private \u0013.\u0002 \u0001;
    private EventHandler \u0005;
    private \u0013.\u0004 \u0001;
    private EventHandler \u0006;
    private \u0006 \u0001;
    private \u0008 \u0001;
    private EventHandler \u0007;
    private \u000F \u0001;
    private \u0013.\u0011 \u0001;
    private \u0013.\u0013 \u0001;
    private \u0015 \u0001;
    private \u0017 \u0001;
    private \u0019 \u0001;
    private \u001B \u0001;
    private \u001D \u0001;
    private \u001F \u0001;
    private \u0080 \u0001;
    private \u0082 \u0001;
    private \u0014.\u0002 \u0001;
    private EventHandler \u0008;
    private \u0014.\u0004 \u0001;
    private \u0006 \u0001;
    private \u0008 \u0001;
    private EventHandler \u000E;
    private \u000F \u0001;
    private \u0014.\u0011 \u0001;

    static \u001E()
    {
      \u0001.\u0004.\u001D\u0005(typeof (\u001E));
    }

    public \u001E()
      : base(\u001E.\u0001(1034))
    {
    }

    [SpecialName]
    public virtual void \u001D\u0005([In] string obj0)
    {
      if (this.\u0001 == null)
        throw new AxHost.InvalidActiveXStateException(\u001E.\u0001(1083), AxHost.ActiveXInvokeKind.PropertySet);
      this.\u0001.URL = obj0;
    }

    [SpecialName]
    public virtual \u0016 \u001D\u0005()
    {
      if (this.\u0001 == null)
        throw new AxHost.InvalidActiveXStateException(\u001E.\u0001(1088), AxHost.ActiveXInvokeKind.PropertyGet);
      return this.\u0001.playState;
    }

    [SpecialName]
    public virtual \u0017 \u001D\u0005()
    {
      if (this.\u0001 == null)
        throw new AxHost.InvalidActiveXStateException(\u001E.\u0001(1101), AxHost.ActiveXInvokeKind.PropertyGet);
      return this.\u0001.controls;
    }

    [SpecialName]
    public virtual \u0018 \u001D\u0005()
    {
      if (this.\u0001 == null)
        throw new AxHost.InvalidActiveXStateException(\u001E.\u0001(1118), AxHost.ActiveXInvokeKind.PropertyGet);
      return this.\u0001.settings;
    }

    [SpecialName]
    public void \u001D\u0005([In] \u0082 obj0)
    {
      \u0082 obj = this.\u0001;
      \u0082 comparand;
      do
      {
        comparand = obj;
        obj = Interlocked.CompareExchange<\u0082>(ref this.\u0001, comparand + obj0, comparand);
      }
      while (obj != comparand);
    }

    protected override void CreateSink()
    {
      try
      {
        this.\u0001 = new \u0014.\u0013(this);
        this.\u0001 = new AxHost.ConnectionPointCookie((object) this.\u0001, (object) this.\u0001, typeof (\u0005));
      }
      catch (Exception ex)
      {
      }
    }

    protected override void DetachSink()
    {
      try
      {
        this.\u0001.Disconnect();
      }
      catch (Exception ex)
      {
      }
    }

    protected override void AttachInterfaces()
    {
      try
      {
        this.\u0001 = (\u0004.\u0011) this.GetOcx();
      }
      catch (Exception ex)
      {
      }
    }

    internal void \u001D\u0005([In] object obj0, [In] \u007F obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0081 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0011.\u0001 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0003 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0005 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0007 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u000E obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0011.\u0010 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0011.\u0012 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0011.\u0014 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0016 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0018 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] EventArgs obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001E\u0005([In] object obj0, [In] EventArgs obj1)
    {
      if (this.\u0002 == null)
        return;
      this.\u0002(obj0, obj1);
    }

    internal void \u001F\u0005([In] object obj0, [In] EventArgs obj1)
    {
      if (this.\u0003 == null)
        return;
      this.\u0003(obj0, obj1);
    }

    internal void \u007F\u0005([In] object obj0, [In] EventArgs obj1)
    {
      if (this.\u0004 == null)
        return;
      this.\u0004(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u001A obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u001C obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u001E obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u007F obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0081 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0012.\u0001 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0003 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0005 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0007 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u000E obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0012.\u0010 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0012.\u0012 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0012.\u0014 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0016 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0018 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u001A obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u001C obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u001E obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u007F obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0081 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0013.\u0001 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0003 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u0080\u0005([In] object obj0, [In] EventArgs obj1)
    {
      if (this.\u0005 == null)
        return;
      this.\u0005(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0005 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u0081\u0005([In] object obj0, [In] EventArgs obj1)
    {
      if (this.\u0006 == null)
        return;
      this.\u0006(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0007 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u000E obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u0082\u0005([In] object obj0, [In] EventArgs obj1)
    {
      if (this.\u0007 == null)
        return;
      this.\u0007(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0013.\u0010 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0013.\u0012 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0013.\u0014 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0016 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0018 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u001A obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u001C obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u001E obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u007F obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0081 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0014.\u0001 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0003 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u0083\u0005([In] object obj0, [In] EventArgs obj1)
    {
      if (this.\u0008 == null)
        return;
      this.\u0008(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0005 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0007 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u000E obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u0084\u0005([In] object obj0, [In] EventArgs obj1)
    {
      if (this.\u000E == null)
        return;
      this.\u000E(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0014.\u0010 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }

    internal void \u001D\u0005([In] object obj0, [In] \u0014.\u0012 obj1)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001(obj0, obj1);
    }
  }
}
