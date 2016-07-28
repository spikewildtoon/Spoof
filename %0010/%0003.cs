// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u000F;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0010
{
  [Guid("A915CEA2-72DF-41E1-A576-EF0BAE5E5169")]
  [TypeLibType(4160)]
  [ComImport]
  public interface \u0003 : \u001F
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

    [DispId(10027)]
    string SelectedTaskPane { [DispId(10027), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(10027), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(10009)]
    \u007F DownloadManager { [DispId(10009), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10028)]
    object OnLoginChange { [DispId(10028), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(10029)]
    bool userLoggedIn { [DispId(10029), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10031)]
    string accountType { [DispId(10031), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10032)]
    object OnViewChange { [DispId(10032), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(10035)]
    string libraryLocationType { [DispId(10035), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10036)]
    string libraryLocationID { [DispId(10036), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10037)]
    string selectedItemType { [DispId(10037), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10038)]
    string selectedItemID { [DispId(10038), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10039)]
    string filter { [DispId(10039), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10040)]
    string task { [DispId(10040), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10041)]
    string viewParameters { [DispId(10041), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10045)]
    string basketTitle { [DispId(10045), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10052)]
    object OnSendMessageComplete { [DispId(10052), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(10053)]
    bool ignoreIEHistory { [DispId(10053), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(10054)]
    bool pluginRunning { [DispId(10054), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10055)]
    bool templateBeingDisplayedInLocalLibrary { [DispId(10055), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(10056)]
    object OnChangeViewError { [DispId(10056), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(10057)]
    object OnChangeViewOnlineListError { [DispId(10057), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [DispId(10026)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0004([MarshalAs(UnmanagedType.BStr), In] string bstrKeyName, [MarshalAs(UnmanagedType.BStr), In] string bstrTaskPane, [MarshalAs(UnmanagedType.BStr), In] string bstrParams);

    [DispId(10030)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0097\u0002();

    [DispId(10033)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrLibraryLocationType, [MarshalAs(UnmanagedType.BStr), In] string bstrLibraryLocationID, [MarshalAs(UnmanagedType.BStr), In] string bstrFilter, [MarshalAs(UnmanagedType.BStr), In] string bstrViewParams);

    [DispId(10034)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0001([MarshalAs(UnmanagedType.BStr), In] string bstrLibraryLocationType, [MarshalAs(UnmanagedType.BStr), In] string bstrLibraryLocationID, [MarshalAs(UnmanagedType.BStr), In] string bstrParams, [MarshalAs(UnmanagedType.BStr), In] string bstrFriendlyName, [MarshalAs(UnmanagedType.BStr), In] string bstrListType, [MarshalAs(UnmanagedType.BStr), In] string bstrViewMode);

    [DispId(10042)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0098\u0002();

    [DispId(10043)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0005([In] int lPopupIndex, [MarshalAs(UnmanagedType.BStr), In] string bstrParameters);

    [DispId(10044)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u000E([MarshalAs(UnmanagedType.BStr), In] string bstrViewType, [MarshalAs(UnmanagedType.BStr), In] string bstrViewIDs);

    [DispId(10046)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u000F([MarshalAs(UnmanagedType.BStr), In] string bstrLibraryLocationType, [MarshalAs(UnmanagedType.BStr), In] string bstrLibraryLocationIDs);

    [DispId(10047)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0010([MarshalAs(UnmanagedType.BStr), In] string bstrViewType, [MarshalAs(UnmanagedType.BStr), In] string bstrViewIDs);

    [DispId(10048)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0011([MarshalAs(UnmanagedType.BStr), In] string bstrViewType, [MarshalAs(UnmanagedType.BStr), In] string bstrViewIDs);

    [DispId(10049)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0005([MarshalAs(UnmanagedType.BStr), In] string bstrFriendlyListType, [In] bool fDynamic);

    [DispId(10050)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0086\u0002([In] int lAuthenticationIndex);

    [DispId(10051)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void \u0012([MarshalAs(UnmanagedType.BStr), In] string bstrMsg, [MarshalAs(UnmanagedType.BStr), In] string bstrParam);
  }
}
