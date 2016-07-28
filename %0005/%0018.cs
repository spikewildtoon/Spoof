// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0005
{
  [TypeLibType(256)]
  [Guid("39C2F8D5-1CF2-4D5E-AE09-D73492CF9EAA")]
  [InterfaceType(1)]
  [ComImport]
  public interface \u0018
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int \u0001([In] \u0081 wmplt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    \u0080 \u0001([In] \u0081 wmplt, [In] int lIndex);
  }
}
