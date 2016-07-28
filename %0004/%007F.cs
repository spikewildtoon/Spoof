// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0004
{
  [TypeLibType(4160)]
  [Guid("3614C646-3B3B-4DE7-A81E-930E3F2127B3")]
  [ComImport]
  public interface \u007F
  {
    [DispId(901)]
    int errorCode { [DispId(901), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(902)]
    string errorDescription { [DispId(902), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(903)]
    object errorContext { [DispId(903), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(904)]
    int remedy { [DispId(904), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(905)]
    string customUrl { [DispId(905), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
