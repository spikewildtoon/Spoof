// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace \u001C
{
  internal sealed class \u000E : SafeHandle
  {
    public GCHandle Handle
    {
      get
      {
        return \u0002\u001E.\u009D\u009C(this.handle);
      }
    }

    public override bool IsInvalid
    {
      [PrePrepareMethod, ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] get
      {
        return \u0008\u0081.\u0086\u0096(this.handle, IntPtr.Zero);
      }
    }

    public \u000E(object target, GCHandleType type)
      : base(IntPtr.Zero, true)
    {
      \u0088\u0081.\u001B\u009F();
      try
      {
      }
      finally
      {
        \u0007\u001C.\u0093\u0097((object) this, \u008C\u0081.\u009E\u009C(\u0002\u0082.\u009A\u009C(target, type)));
      }
    }

    [PrePrepareMethod]
    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    protected override bool ReleaseHandle()
    {
      \u0002\u001E.\u009D\u009C(this.handle).Free();
      return true;
    }
  }
}
