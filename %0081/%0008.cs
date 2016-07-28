// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001A;
using \u0081;
using System;
using System.Runtime.CompilerServices;

namespace \u0081
{
  internal struct \u0008 : IDisposable
  {
    private IntPtr \u0001;

    internal IntPtr hObject
    {
      get
      {
        return this.\u0001;
      }
    }

    internal \u0008(IntPtr hObject)
    {
      this.\u0001 = hObject;
    }

    [SpecialName]
    public static \u0008 \u001D\u0005(IntPtr hObject)
    {
      return new \u0008(hObject);
    }

    [SpecialName]
    public static IntPtr \u001D\u0005(\u0008 hObject)
    {
      return hObject.hObject;
    }

    public void Dispose()
    {
      if (!\u0008\u0081.\u0087\u0096(this.\u0001, IntPtr.Zero))
        return;
      \u000E.\u0080\u0005(this.\u0001);
    }
  }
}
