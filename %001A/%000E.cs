// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0018;
using \u0019;
using \u001A;
using \u001B;
using \u001C;
using \u001D;
using \u007F;
using \u0080;
using \u0081;
using \u0082;
using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using TSN.Native.Enums;

namespace \u001A
{
  internal static class \u000E
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public const string \u0001 = "kernel32.dll";
    public const string \u0002 = "user32.dll";
    public const string \u0003 = "gdi32.dll";
    public const string \u0004 = "ntdll.dll";
    public static readonly uint \u0001;
    private static readonly string \u0005;
    private static readonly string \u0006;
    public static readonly IntPtr \u0001;
    public static readonly IntPtr \u0002;
    public static readonly IntPtr \u0003;
    public static readonly IntPtr \u0004;
    public static readonly IntPtr \u0005;

    static \u000E()
    {
      \u0004.\u001D\u0005(typeof (\u000E));
      \u000E.\u0001 = 2147942583U;
      \u000E.\u0005 = \u000E.\u0001(49550);
      \u000E.\u0006 = \u000E.\u0001(49595);
      \u000E.\u0001 = new IntPtr(-1);
      \u000E.\u0002 = new IntPtr(1);
      \u000E.\u0003 = new IntPtr(-2);
      \u000E.\u0004 = new IntPtr(0);
      \u000E.\u0005 = new IntPtr(-1);
    }

    [DllImport("kernel32.dll", EntryPoint = "GetSystemInfo")]
    public static extern void \u001D\u0005([In, Out] ref \u0083.\u001E lpSystemInfo);

    [DllImport("kernel32.dll", EntryPoint = "GetVersionEx", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool \u001D\u0005([In, Out] ref \u0015.\u0018 osVersionInfo);

    [DllImport("user32.dll", EntryPoint = "EnableMenuItem")]
    public static extern bool \u001D\u0005(IntPtr hMenu, \u0010 uIDEnableItem, \u0084.\u001A uEnable);

    [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
    public static extern IntPtr \u001D\u0005(IntPtr hWnd, bool bRevert);

    [DllImport("user32.dll", EntryPoint = "ShutdownBlockReasonCreate", CharSet = CharSet.Unicode)]
    public static extern bool \u001D\u0005(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] string pwszReason);

    [DllImport("user32.dll", EntryPoint = "ShutdownBlockReasonDestroy")]
    public static extern bool \u001D\u0005(IntPtr hWnd);

    [DllImport("kernel32.dll", EntryPoint = "SetProcessAffinityMask", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool \u001D\u0005(HandleRef handle, IntPtr mask);

    [DllImport("user32.dll", EntryPoint = "GetWindowPlacement", CharSet = CharSet.Auto)]
    public static extern bool \u001D\u0005(HandleRef hWnd, ref \u0007 placement);

    [DllImport("user32.dll", EntryPoint = "SetWindowPlacement", CharSet = CharSet.Auto)]
    public static extern bool \u001E\u0005(HandleRef hWnd, ref \u0007 placement);

    [DllImport("kernel32.dll", EntryPoint = "CreateFile", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern SafeFileHandle \u001D\u0005(string pipeName, \u001B.\u0015 dwDesiredAccess, \u001F.\u0018 dwShareMode, IntPtr lpSecurityAttributes, \u0013 dwCreationDisposition, \u0083.\u0001 dwFlagsAndAttributes, IntPtr hTemplate);

    [DllImport("user32.dll", EntryPoint = "MessageBeep", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool \u001D\u0005(\u007F.\u0015 type);

    [DllImport("user32.dll", EntryPoint = "SetFocus", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr \u001D\u0005(HandleRef hWnd);

    [DllImport("user32.dll", EntryPoint = "GetFocus", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr \u001D\u0005();

    [DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
    public static extern IntPtr \u001E\u0005();

    [DllImport("ntdll.dll", EntryPoint = "RtlHashUnicodeString")]
    public static extern NtStatus \u001D\u0005([In] ref \u000E String, [In] bool CaseInSensitive, [In] \u0012 HashAlgorithm, out int HashValue);

    [DllImport("ntdll.dll", EntryPoint = "RtlCompareUnicodeString")]
    public static extern int \u001D\u0005([In] ref \u000E String1, [In] ref \u000E String2, [In] bool CaseInSensitive);

    [DllImport("ntdll.dll", EntryPoint = "RtlCreateUnicodeString")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool \u001D\u0005(out \u000E DestinationString, [MarshalAs(UnmanagedType.LPWStr), In] string SourceString);

    [DllImport("ntdll.dll", EntryPoint = "RtlDuplicateUnicodeString")]
    public static extern NtStatus \u001D\u0005([In] \u001E.\u0015 Flags, [In] ref \u000E StringIn, out \u000E StringOut);

    [DllImport("ntdll.dll", EntryPoint = "RtlEqualUnicodeString")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool \u001D\u0005([In] ref \u000E String1, [In] ref \u000E String2, [In] bool CaseInSensitive);

    [DllImport("ntdll.dll", EntryPoint = "RtlFreeUnicodeString")]
    public static extern void \u001D\u0005([In] ref \u000E UnicodeString);

    [DllImport("ntdll.dll", EntryPoint = "RtlPrefixUnicodeString")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool \u001E\u0005([In] ref \u000E String1, [In] ref \u000E String2, [In] bool CaseInSensitive);

    [DllImport("ntdll.dll", EntryPoint = "NtQuerySystemInformation")]
    public static extern NtStatus \u001D\u0005([In] \u0083.\u001F SystemInformationClass, [In] IntPtr SystemInformation, [In] int SystemInformationLength, out int ReturnLength);

    [DllImport("ntdll.dll", EntryPoint = "NtQueryObject")]
    public static extern NtStatus \u001D\u0005([In] IntPtr Handle, [In] \u0007 ObjectInformationClass, [In] IntPtr ObjectInformation, [In] int ObjectInformationLength, out int ReturnLength);

    [DllImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = true)]
    public static extern \u0082.\u0082 \u001D\u0005([In] \u0011 dwDesiredAccess, [MarshalAs(UnmanagedType.Bool), In] bool bInheritHandle, [In] uint dwProcessId);

    [DllImport("kernel32.dll", EntryPoint = "DuplicateHandle", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool \u001D\u0005([In] IntPtr hSourceProcessHandle, [In] IntPtr hSourceHandle, [In] IntPtr hTargetProcessHandle, out \u0084.\u0017 lpTargetHandle, [In] int dwDesiredAccess, [MarshalAs(UnmanagedType.Bool), In] bool bInheritHandle, [In] \u0083.\u0081 dwOptions);

    [DllImport("kernel32.dll", EntryPoint = "QueryDosDevice", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern int \u001D\u0005([In] string lpDeviceName, [Out] StringBuilder lpTargetPath, [In] int ucchMax);

    [DllImport("ntdll.dll", EntryPoint = "RtlFillMemory")]
    public static extern void \u001D\u0005([In] IntPtr Destination, [In] IntPtr Length, [In] byte Fill);

    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    [DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool \u001E\u0005([In] IntPtr hObject);

    [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
    public static extern IntPtr \u001F\u0005();

    [DllImport("kernel32.dll", EntryPoint = "GetProcessId", SetLastError = true)]
    public static extern int \u001D\u0005([In] IntPtr Process);

    [DllImport("ntdll.dll", EntryPoint = "RtlNtStatusToDosError")]
    public static extern Win32Error \u001D\u0005([In] NtStatus Status);

    [DllImport("ntdll.dll", EntryPoint = "RtlMoveMemory")]
    public static extern void \u001D\u0005([In] IntPtr Destination, [In] IntPtr Source, [In] IntPtr Length);

    [DllImport("ntdll.dll", EntryPoint = "RtlFindMessage")]
    public static extern NtStatus \u001D\u0005([In] IntPtr DllHandle, [In] int MessageTableId, [In] int MessageLanguageId, [In] int MessageId, out IntPtr MessageEntry);

    [DllImport("ntdll.dll", EntryPoint = "RtlZeroMemory")]
    public static extern void \u001D\u0005([In] IntPtr Destination, [In] IntPtr Length);

    [DllImport("kernel32.dll", EntryPoint = "FormatMessage", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern int \u001D\u0005([In] int Flags, [In, Optional] IntPtr Source, [In] int MessageId, [In] int LanguageId, [In] IntPtr Buffer, [In] int Size, [In, Optional] IntPtr Arguments);

    [DllImport("kernel32.dll", EntryPoint = "FindResource", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern IntPtr \u001D\u0005([In, Optional] IntPtr hModule, [MarshalAs(UnmanagedType.LPWStr), In] string lpName, [In] string lpType);

    [DllImport("kernel32.dll", EntryPoint = "LoadResource", SetLastError = true)]
    public static extern IntPtr \u001D\u0005([In, Optional] IntPtr hModule, [In] IntPtr hResInfo);

    [DllImport("kernel32.dll", EntryPoint = "LockResource", SetLastError = true)]
    public static extern IntPtr \u001D\u0005([In] IntPtr hResData);

    [DllImport("kernel32.dll", EntryPoint = "SizeofResource", SetLastError = true)]
    public static extern uint \u001D\u0005([In, Optional] IntPtr hModule, [In] IntPtr hResInfo);

    [DllImport("user32.dll", EntryPoint = "CreateIconFromResource", SetLastError = true)]
    public static extern IntPtr \u001D\u0005([In] IntPtr presbits, [In] uint dwResSize, [In] bool fIcon, [In] uint dwVer);

    [DllImport("user32.dll", EntryPoint = "UpdateLayeredWindow", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pprSrc, int crKey, ref \u0008 pblend, int dwFlags);

    [DllImport("user32.dll", EntryPoint = "GetDC", SetLastError = true)]
    public static extern IntPtr \u001E\u0005(IntPtr hwnd);

    [DllImport("user32.dll", EntryPoint = "RegisterHotKey", SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hWnd, int id, \u0016 fsModifiers, Keys vk);

    [DllImport("user32.dll", EntryPoint = "UnregisterHotKey", SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hWnd, int id);

    [DllImport("kernel32.dll", EntryPoint = "OpenMutex", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern SafeWaitHandle \u001D\u0005(MutexRights desiredAccess, bool inheritHandle, string name);

    [DllImport("user32.dll", EntryPoint = "DrawIconEx", SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hDC, int xLeft, int yTop, IntPtr hIcon, int cxWidth, int cyWidth, int istepIfAniCur, IntPtr hbrFlickerFreeDraw, \u0013 diFlags);

    [DllImport("user32.dll", EntryPoint = "LoadImage", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern IntPtr \u001D\u0005(IntPtr hInst, string lpsz, \u0010 uType, int cx, int cy, \u0011 uFlags);

    [DllImport("user32.dll", EntryPoint = "LoadImage", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr \u001D\u0005(IntPtr hInst, [MarshalAs(UnmanagedType.SysInt)] int lpsz, \u0010 uType, int cx, int cy, \u0011 uFlags);

    [DllImport("user32.dll", EntryPoint = "CopyImage", SetLastError = true)]
    public static extern IntPtr \u001D\u0005(IntPtr hImage, \u0010 uType, int cxDesired, int cyDesired, \u0012 uFlags);

    [DllImport("user32.dll", EntryPoint = "DestroyCursor", SetLastError = true)]
    public static extern bool \u001F\u0005(IntPtr hCursor);

    [DllImport("user32.dll", EntryPoint = "SendInput", SetLastError = true)]
    public static extern uint \u001D\u0005(uint nInputs, \u0007[] pInputs, int cbSize);

    [DllImport("user32.dll", EntryPoint = "mouse_event")]
    public static extern void \u001D\u0005(\u0083.\u0080 dwFlags, uint dx, uint dy, uint dwData, IntPtr dwExtraInfo);

    [DllImport("kernel32.dll", EntryPoint = "GetModuleHandle", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern IntPtr \u001D\u0005([In, Optional] string moduleName);

    [DllImport("kernel32.dll", EntryPoint = "GetModuleFileName", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern int \u001D\u0005([In] IntPtr hModule, [Out] StringBuilder lpFilename, [MarshalAs(UnmanagedType.U4), In] int nSize);

    [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", SetLastError = true)]
    public static extern int \u001D\u0005();

    [DllImport("kernel32.dll", EntryPoint = "GetCurrentThreadId", SetLastError = true)]
    public static extern uint \u001D\u0005();

    [DllImport("user32.dll", EntryPoint = "GetWindowRect", SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hwnd, out \u0008 lpRect);

    [DllImport("user32.dll", EntryPoint = "MapWindowPoints", SetLastError = true)]
    public static extern int \u001D\u0005(IntPtr hwndFrom, IntPtr hwndTo, ref \u0008 lpPoints, uint cPoints);

    [DllImport("user32.dll", EntryPoint = "SetWindowPos", SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, \u0004 flags);

    [DllImport("user32.dll", EntryPoint = "SetWindowPos", SetLastError = true)]
    public static extern bool \u001D\u0005(HandleRef hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, \u0004 flags);

    [DllImport("user32.dll", EntryPoint = "SetWindowPos", SetLastError = true)]
    public static extern bool \u001D\u0005(HandleRef hWnd, HandleRef hWndInsertAfter, int X, int Y, int cx, int cy, \u0004 flags);

    [DllImport("user32.dll", EntryPoint = "AnimateWindow", CharSet = CharSet.Auto)]
    public static extern bool \u001D\u0005(HandleRef windowHandle, int time, \u000F flags);

    [DllImport("user32.dll", EntryPoint = "GetWindowDC", SetLastError = true)]
    public static extern IntPtr \u001F\u0005(IntPtr hWnd);

    [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC", SetLastError = true)]
    public static extern IntPtr \u007F\u0005(IntPtr hDC);

    [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap", SetLastError = true)]
    public static extern IntPtr \u001D\u0005(IntPtr hDC, int nWidth, int nHeight);

    [DllImport("gdi32.dll", EntryPoint = "SelectObject", SetLastError = true)]
    public static extern IntPtr \u001E\u0005(IntPtr hDC, IntPtr hObject);

    [DllImport("gdi32.dll", EntryPoint = "BitBlt", SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, \u0011 dwRop);

    [DllImport("gdi32.dll", EntryPoint = "DeleteDC", SetLastError = true)]
    public static extern bool \u007F\u0005(IntPtr hDC);

    [DllImport("user32.dll", EntryPoint = "ReleaseDC", SetLastError = true)]
    public static extern int \u001D\u0005(IntPtr hWnd, IntPtr hDC);

    [DllImport("gdi32.dll", EntryPoint = "DeleteObject", SetLastError = true)]
    public static extern bool \u0080\u0005(IntPtr hObject);

    [DllImport("user32.dll", EntryPoint = "GetDesktopWindow", SetLastError = true)]
    public static extern IntPtr \u007F\u0005();

    [DllImport("user32.dll", EntryPoint = "SetForegroundWindow", SetLastError = true)]
    public static extern bool \u001D\u0005(HandleRef hwnd);

    [DllImport("user32.dll", EntryPoint = "SetForegroundWindow", SetLastError = true)]
    public static extern bool \u0081\u0005(IntPtr hwnd);

    [DllImport("user32.dll", EntryPoint = "ShowWindowAsync")]
    public static extern bool \u001D\u0005(IntPtr hWnd, \u0006 cmdShow);

    [DllImport("user32.dll", EntryPoint = "ShowWindow")]
    public static extern bool \u001D\u0005(HandleRef hWnd, \u0006 cmdShow);

    [DllImport("user32.dll", EntryPoint = "SetWindowLong", SetLastError = true)]
    private static extern int \u001D\u0005(IntPtr hWnd, \u0012 nIndex, int dwNewLong);

    [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr", SetLastError = true)]
    private static extern IntPtr \u001D\u0005(IntPtr hWnd, \u0012 nIndex, IntPtr dwNewLong);

    [DllImport("user32.dll", EntryPoint = "GetWindowLong", SetLastError = true)]
    private static extern uint \u001D\u0005(IntPtr hWnd, \u0012 nIndex);

    [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr", SetLastError = true)]
    private static extern IntPtr \u001D\u0005(IntPtr hWnd, \u0012 nIndex);

    [DllImport("user32.dll", EntryPoint = "GetSystemMetrics", SetLastError = true)]
    public static extern int \u001D\u0005(\u0010 smIndex);

    [DllImport("user32.dll", EntryPoint = "GetClientRect", SetLastError = true)]
    public static extern bool \u001E\u0005(IntPtr hWnd, out \u0008 lpRect);

    [DllImport("user32.dll", EntryPoint = "GetClassLong", SetLastError = true)]
    private static extern uint \u001D\u0005(HandleRef hWnd, \u0012 nIndex);

    [DllImport("user32.dll", EntryPoint = "GetClassLongPtr", SetLastError = true)]
    private static extern IntPtr \u001D\u0005(HandleRef hWnd, \u0012 nIndex);

    [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes", SetLastError = true)]
    public static extern bool \u001D\u0005([In] HandleRef hWnd, [In] uint crKey, [In] byte bAlpha, [In] \u0015.\u007F dwFlags);

    [DllImport("user32.dll", EntryPoint = "SetParent", SetLastError = true)]
    public static extern IntPtr \u001F\u0005(IntPtr hWndChild, IntPtr hWndNewParent);

    [DllImport("user32.dll", EntryPoint = "MoveWindow", SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

    [DllImport("user32.dll", EntryPoint = "ClientToScreen", SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hWnd, ref Point lpPoint);

    [DllImport("user32.dll", EntryPoint = "SendNotifyMessage", SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hWnd, \u0015.\u001B msg, \u0010 wParam, int lParam);

    [DllImport("user32.dll", EntryPoint = "SetCursorPos", SetLastError = true)]
    public static extern bool \u001D\u0005(int X, int Y);

    [DllImport("user32.dll", EntryPoint = "PostMessage", SetLastError = true)]
    public static extern bool \u001D\u0005(IntPtr hWnd, \u0015.\u001B Msg, int wParam, int lParam);

    [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
    public static extern IntPtr \u001D\u0005(IntPtr hWnd, \u0015.\u001B Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
    public static extern IntPtr \u001D\u0005(IntPtr hWnd, \u0015.\u001B Msg, IntPtr wParam, ref \u0003 lParam);

    [DllImport("user32.dll", EntryPoint = "SendMessageTimeout", SetLastError = true)]
    public static extern IntPtr \u001D\u0005(IntPtr hWnd, \u0015.\u001B Msg, IntPtr wParam, ref \u0003 lParam, \u001F.\u0017 fuFlags, uint uTimeout, out IntPtr lpdwResult);

    [DllImport("kernel32.dll", EntryPoint = "LocalFree", SetLastError = true)]
    public static extern IntPtr \u0080\u0005(IntPtr p);

    [DllImport("kernel32.dll", EntryPoint = "LocalAlloc", SetLastError = true)]
    public static extern IntPtr \u001D\u0005(\u0014 flag, IntPtr size);

    [DllImport("user32.dll", EntryPoint = "ScreenToClient", SetLastError = true)]
    public static extern bool \u001E\u0005(IntPtr handle, ref Point point);

    [DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
    public static extern int \u001D\u0005(IntPtr hWnd, out int processId);

    [DllImport("user32.dll", EntryPoint = "GetWindow", SetLastError = true)]
    public static extern IntPtr \u001D\u0005(IntPtr hWnd, \u0008 uCmd);

    [DllImport("user32.dll", EntryPoint = "SystemParametersInfo", SetLastError = true)]
    public static extern bool \u001D\u0005(\u0014 action, uint param, ref uint vparam, uint init);

    [DllImport("user32.dll", EntryPoint = "EnumWindows", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool \u001D\u0005(\u000E.\u0001 lpEnumFunc, IntPtr lParam);

    [DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
    public static extern bool \u0082\u0005(IntPtr hWnd);

    [DllImport("user32.dll", EntryPoint = "UpdateWindow")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool \u0083\u0005(IntPtr hWnd);

    [DllImport("user32.dll", EntryPoint = "RedrawWindow")]
    public static extern bool \u001D\u0005(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, \u000F flags);

    [DllImport("user32.dll", EntryPoint = "GetMessageExtraInfo")]
    public static extern IntPtr \u0080\u0005();

    [DllImport("user32.dll", EntryPoint = "InvalidateRect")]
    public static extern bool \u001D\u0005(IntPtr hWnd, IntPtr lpRect, bool bErase);

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    public static extern IntPtr \u001D\u0005(IntPtr hwnd, \u0015.\u001B wMsg, bool wParam, int lParam);

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    public static extern IntPtr \u001D\u0005(IntPtr hwnd, \u0015.\u001B wMsg, int wParam, int lParam);

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    public static extern IntPtr \u001D\u0005(HandleRef hwnd, \u0015.\u001B wMsg, bool wParam, int lParam);

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    public static extern IntPtr \u001D\u0005(HandleRef hwnd, \u0015.\u001B wMsg, int wParam, int lParam);

    [DllImport("user32.dll", EntryPoint = "GetParent", SetLastError = true)]
    public static extern IntPtr \u0081\u0005(IntPtr hWnd);

    [DllImport("user32.dll", EntryPoint = "IsChild")]
    public static extern bool \u001D\u0005(IntPtr hWndParent, IntPtr hWnd);

    [DllImport("user32.dll", EntryPoint = "IsWindow")]
    public static extern bool \u0084\u0005(IntPtr hWndParent);

    public static string \u001D\u0005(IntPtr dllHandle, int messageTableId, int messageLanguageId, int messageId)
    {
      IntPtr MessageEntry;
      if (\u000E.\u001D\u0005(dllHandle, messageTableId, messageLanguageId, messageId, out MessageEntry).\u001D\u0005())
        return (string) null;
      \u000F obj = new \u000F(MessageEntry);
      string str;
      try
      {
        str = (obj.\u001D\u0005<\u0002>().\u0001 & \u0012.\u0002) != \u0012.\u0002 ? obj.\u001D\u0005(\u0002.\u0001) : obj.\u001E\u0005(\u0002.\u0001);
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
      return str;
    }

    public static bool \u001D\u0005(string name)
    {
      switch (name)
      {
        case null:
          throw new ArgumentNullException(\u000E.\u0001(49541));
        default:
          if (\u0005\u0081.\u007E\u0001\u0093((object) name) == 0)
            throw new ArgumentException(\u000E.\u0006);
          if (\u0005\u0081.\u007E\u0001\u0093((object) name) > 260)
            throw new ArgumentException(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u000E.\u0005, new object[1]{ (object) name }));
          SafeWaitHandle safeWaitHandle = \u000E.\u001D\u0005(MutexRights.Synchronize, false, name);
          try
          {
            return !\u0099\u0082.\u007E\u0095\u0097((object) safeWaitHandle);
          }
          finally
          {
            if (safeWaitHandle != null)
              \u001A\u001E.\u007E\u0094\u0092((object) safeWaitHandle);
          }
      }
    }

    public static long \u001D\u0005(IntPtr hWnd, \u0012 nIndex)
    {
      long num = !\u000F\u0080.\u009B\u0095() ? (long) \u000E.\u001D\u0005(hWnd, nIndex) : \u000E.\u001D\u0005(hWnd, nIndex).ToInt64();
      if (num == 0L)
        throw new Win32Exception();
      return num;
    }

    public static IntPtr \u001E\u0005(HandleRef hWnd, \u0012 nIndex)
    {
      if (!\u000F\u0080.\u009B\u0095())
      {
        uint num = \u000E.\u001D\u0005(hWnd, nIndex);
        if ((int) num == 0)
          throw new Win32Exception();
        return new IntPtr((long) num);
      }
      IntPtr num1 = \u000E.\u001D\u0005(hWnd, nIndex);
      if (\u0008\u0081.\u0086\u0096(num1, IntPtr.Zero))
        throw new Win32Exception();
      return num1;
    }

    public static void \u001D\u0005(IntPtr hWnd, \u0012 nIndex, int dwNewLong)
    {
      if (\u000F\u0080.\u009B\u0095())
      {
        if (\u0008\u0081.\u0086\u0096(\u000E.\u001D\u0005(hWnd, nIndex, new IntPtr(dwNewLong)), IntPtr.Zero))
          throw new Win32Exception();
      }
      else if (\u000E.\u001D\u0005(hWnd, nIndex, dwNewLong) == 0)
        throw new Win32Exception();
    }

    public static string \u001D\u0005()
    {
      StringBuilder lpFilename = (StringBuilder) null;
      try
      {
        lpFilename = new StringBuilder(1024);
        IntPtr hModule = \u000E.\u001D\u0005((string) null);
        if (\u0008\u0081.\u0086\u0096(hModule, IntPtr.Zero))
          throw new Win32Exception();
        if (\u000E.\u001D\u0005(hModule, lpFilename, \u0005\u0081.\u007E\u009A\u0093((object) lpFilename)) == 0)
          throw new Win32Exception();
        return \u0002\u007F.\u007E\u0087\u0091((object) lpFilename);
      }
      finally
      {
        StringBuilder stringBuilder = \u008C\u001F.\u007E\u009B\u0093((object) lpFilename);
      }
    }

    public static uint \u001E\u0005()
    {
      uint vparam = 0;
      if (!\u000E.\u001D\u0005(\u0014.\u0001, 0U, ref vparam, 0U))
      {
        new Win32Exception().\u001D\u0005();
        vparam = 31U;
      }
      else if (vparam > 31U)
        vparam = 31U;
      return vparam;
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static Process \u001D\u0005(IntPtr hWnd)
    {
      int processId;
      if (\u000E.\u001D\u0005(hWnd, out processId) != 0)
        return \u009E\u0082.\u0012\u0004\u0002(processId);
      throw new Win32Exception();
    }

    public static short \u001D\u0005(byte a, byte b)
    {
      return (short) ((int) (byte) ((int) a & (int) byte.MaxValue) | (int) (byte) ((int) b & (int) byte.MaxValue) << 8);
    }

    public static byte \u001D\u0005(short a)
    {
      return (byte) ((int) a & (int) byte.MaxValue);
    }

    public static byte \u001E\u0005(short a)
    {
      return (byte) ((int) a >> 8);
    }

    public static int \u001D\u0005(short a, short b)
    {
      return (int) a & (int) ushort.MaxValue | ((int) b & (int) ushort.MaxValue) << 16;
    }

    public static short \u001D\u0005(int a)
    {
      return (short) (a >> 16);
    }

    public delegate bool \u0001(IntPtr hWnd, IntPtr lParam);
  }
}
