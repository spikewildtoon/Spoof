﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0010;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u000F
{
  [TypeLibType(4160)]
  [Guid("C9470E8E-3F6B-46A9-A0A9-452815C34297")]
  [ComImport]
  public interface \u0082
  {
    [DispId(1251)]
    string sourceURL { [DispId(1251), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1252)]
    int size { [DispId(1252), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1253)]
    string type { [DispId(1253), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1254)]
    int progress { [DispId(1254), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1255)]
    \u0001 downloadState { [DispId(1255), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1256)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u008F();

    [DispId(1257)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u009A();

    [DispId(1258)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0096\u0002();
  }
}