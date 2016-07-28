// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0005;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0005
{
  [Guid("1BB1592F-F040-418A-9F71-17C7512B4D70")]
  [InterfaceType(1)]
  [ComImport]
  public interface \u0015 : \u0014
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0019([MarshalAs(UnmanagedType.BStr), In] string bstrPlugin);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u001A([MarshalAs(UnmanagedType.BStr), In] string bstrTaskPane);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0003([MarshalAs(UnmanagedType.BStr), In] string bstrTaskPane, [MarshalAs(UnmanagedType.BStr), In] string bstrURL, [MarshalAs(UnmanagedType.BStr), In] string bstrFriendlyName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u001B([MarshalAs(UnmanagedType.BStr), In] string bstrPriority);
  }
}
