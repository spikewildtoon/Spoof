// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0001
{
  [InterfaceType(1)]
  [Guid("3DF47861-7DF1-4C1F-A81B-4C26F0F7A7C6")]
  [TypeLibType(256)]
  [ComImport]
  public interface \u0080
  {
    [DispId(1610678272)]
    string name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    \u0081 type { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    \u0082 mediaCollection { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool \u0001([MarshalAs(UnmanagedType.Interface), In] \u0080 pIWMPLibrary);
  }
}
