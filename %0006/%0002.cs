// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0006
{
  [TypeLibType(4160)]
  [Guid("6FCAE13D-E492-4584-9C21-D2C052A2A33A")]
  [ComImport]
  public interface \u0002
  {
    [DispId(2500)]
    string title { [DispId(2500), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(2501)]
    float version { [DispId(2501), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(2502)]
    string authorVersion { [DispId(2502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(2503)]
    string author { [DispId(2503), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(2504)]
    string copyright { [DispId(2504), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(2505)]
    string currentViewID { [DispId(2505), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2505), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(2506)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u001E\u0002();

    [DispId(2507)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u000F\u0002([MarshalAs(UnmanagedType.BStr), In] string stringVal);

    [DispId(2508)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0010\u0002([MarshalAs(UnmanagedType.BStr), In] string viewID);

    [DispId(2515)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    object \u0001([MarshalAs(UnmanagedType.BStr), In] string viewID, [In] int x, [In] int y);

    [DispId(2509)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0011\u0002([MarshalAs(UnmanagedType.BStr), In] string viewID);

    [DispId(2510)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string \u0001([MarshalAs(UnmanagedType.BStr), In] string dialogType, [MarshalAs(UnmanagedType.BStr), In] string parameters);

    [DispId(2511)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string \u0004([MarshalAs(UnmanagedType.BStr), In] string bstrString);

    [DispId(2512)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string \u0005([MarshalAs(UnmanagedType.BStr), In] string bstrName);

    [DispId(2513)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0008([MarshalAs(UnmanagedType.BStr), In] string bstrName, [MarshalAs(UnmanagedType.BStr), In] string bstrValue);

    [DispId(2514)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0012\u0002([MarshalAs(UnmanagedType.BStr)] string bstrFilename);

    [DispId(2516)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    object \u0001([MarshalAs(UnmanagedType.BStr), In] string viewID, [In] int nIndex, [In] int x, [In] int y, [In] int nWidth, [In] int nHeight, [MarshalAs(UnmanagedType.BStr), In] string bstrHorizontalAlignment, [MarshalAs(UnmanagedType.BStr), In] string bstrVerticalAlignment);

    [DispId(2518)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([MarshalAs(UnmanagedType.BStr), In] string viewID, [In] int nIndex, [In] int x, [In] int y, [In] int nWidth, [In] int nHeight, [MarshalAs(UnmanagedType.BStr), In] string bstrHorizontalAlignment, [MarshalAs(UnmanagedType.BStr), In] string bstrVerticalAlignment);
  }
}
