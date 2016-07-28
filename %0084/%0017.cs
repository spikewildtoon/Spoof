// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001A;
using Microsoft.Win32.SafeHandles;
using System;
using System.Security.Permissions;

namespace \u0084
{
  [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
  internal sealed class \u0017 : SafeHandleZeroOrMinusOneIsInvalid
  {
    private \u0017()
      : base(true)
    {
    }

    public \u0017(IntPtr preexistingHandle, bool ownsHandle)
      : base(ownsHandle)
    {
      \u0007\u001C.\u0093\u0097((object) this, preexistingHandle);
    }

    protected override bool ReleaseHandle()
    {
      return \u000E.\u001E\u0005(this.handle);
    }
  }
}
