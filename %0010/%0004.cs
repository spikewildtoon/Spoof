// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u000F;
using \u0010;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0010
{
  [TypeLibType(4160)]
  [Guid("2D7EF888-1D3C-484A-A906-9F49D99BB344")]
  [ComImport]
  public interface \u0004 : \u001D
  {
    [DispId(10005)]
    string version { [DispId(10005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10012)]
    string appColorLight { [DispId(10012), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10018)]
    object OnColorChange { [DispId(10018), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(10013)]
    string appColorMedium { [DispId(10013), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10014)]
    string appColorDark { [DispId(10014), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10015)]
    string appColorButtonHighlight { [DispId(10015), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10016)]
    string appColorButtonShadow { [DispId(10016), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10017)]
    string appColorButtonHoverFace { [DispId(10017), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10001)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0013([MarshalAs(UnmanagedType.BStr), In] string bstrTOC, [MarshalAs(UnmanagedType.BStr), In] string bstrMetadata);

    [DispId(10002)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0099\u0002();

    [DispId(10007)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([In] \u0005 type, [MarshalAs(UnmanagedType.BStr), In] string bstrTypeId, [MarshalAs(UnmanagedType.BStr), In] string bstrMetadata, [In] bool fRenameRegroupFiles);

    [DispId(10008)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string \u0010([MarshalAs(UnmanagedType.BStr), In] string bstrRequestID);

    [DispId(10011)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u009A\u0002();

    [DispId(10010)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool \u001E\u0003();

    [DispId(10023)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrTitle, [MarshalAs(UnmanagedType.BStr), In] string bstrArtist, [MarshalAs(UnmanagedType.BStr), In] string bstrAlbum, [MarshalAs(UnmanagedType.BStr), In] string bstrUFID, [MarshalAs(UnmanagedType.BStr), In] string bstrWMID);
  }
}
