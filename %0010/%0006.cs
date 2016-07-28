// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u000F;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0010
{
  [Guid("F81B2A59-02BC-4003-8B2F-C124AF66FC66")]
  [TypeLibType(4160)]
  [ComImport]
  public interface \u0006 : \u001C
  {
    [DispId(10005)]
    string version { [DispId(10005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10012)]
    string appColorLight { [DispId(10012), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10018)]
    object OnColorChange { [DispId(10018), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }
  }
}
