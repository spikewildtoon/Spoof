// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0002;
using \u0005;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0005
{
  [TypeLibType(4160)]
  [Guid("46AD648D-53F1-4A74-92E2-2A1B68D63FD4")]
  [ComImport]
  public interface \u0013 : \u0001
  {
    [DispId(401)]
    int count { [DispId(401), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(402)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string \u0005([In] int lIndex);

    [DispId(1451)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool \u0001([MarshalAs(UnmanagedType.Interface), In] \u0013 pIWMPStringCollection2);

    [DispId(1452)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string \u0001([In] int lCollectionIndex, [MarshalAs(UnmanagedType.BStr), In] string bstrItemName);

    [DispId(1453)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int \u0001([In] int lCollectionIndex, [MarshalAs(UnmanagedType.BStr), In] string bstrType, [MarshalAs(UnmanagedType.BStr), In] string bstrLanguage);

    [DispId(1454)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    object \u0001([In] int lCollectionIndex, [MarshalAs(UnmanagedType.BStr), In] string bstrType, [MarshalAs(UnmanagedType.BStr), In] string bstrLanguage, [In] int lAttributeIndex);
  }
}
