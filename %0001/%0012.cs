﻿// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0001
{
  internal sealed class \u0012
  {
    [DllImport("fusion", EntryPoint = "CreateAssemblyCache", CharSet = CharSet.Auto)]
    internal static extern int \u001D\u0005(out \u0012.\u0007 ppAsmCache, uint dwReserved);

    public static bool \u001D\u0005([In] string obj0)
    {
      \u0012.\u0007 ppAsmCache = (\u0012.\u0007) null;
      return \u0012.\u001D\u0005(out ppAsmCache, 0U) == 0 && ppAsmCache.\u0002(0U, obj0, IntPtr.Zero) == 0;
    }

    public struct \u0001
    {
      public int \u0001;
      public int \u0002;
    }

    public struct \u0002
    {
      public \u0012.\u0001 \u0001;
      public long \u0001;
      public Guid \u0001;
      public \u0012.\u0001 \u0002;
      public int \u0001;
      public int \u0002;
      public int \u0003;
      public \u0012.\u0001 \u0003;
      public string \u0001;
      public int \u0004;
      public int \u0005;
    }

    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("0000000c-0000-0000-C000-000000000046")]
    [ComImport]
    public interface \u0003
    {
      void \u0001(IntPtr pv, uint cb, out uint pcbRead);

      void \u0002(IntPtr pv, uint cb, out uint pcbWritten);

      void \u0001(long dlibMove, uint dwOrigin, out ulong plibNewPosition);

      void \u0001(ulong libNewSize);

      void \u0001(\u0012.\u0003 pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten);

      void \u0001(uint grfCommitFlags);

      void \u0080();

      void \u0001(ulong libOffset, ulong cb, uint dwLockType);

      void \u0002(ulong libOffset, ulong cb, uint dwLockType);

      void \u0001(out \u0012.\u0002 pstatstg, uint grfStatFlag);

      void \u0001(out \u0012.\u0003 ppstm);
    }

    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("7c23ff90-33af-11d3-95da-00a024a85b51")]
    [ComImport]
    internal interface \u0004
    {
      void \u0001(\u0012.\u0005 pName);

      void \u0001(out \u0012.\u0005 ppName);

      void \u0001([MarshalAs(UnmanagedType.LPWStr)] string szName, int pvValue, uint cbValue, uint dwFlags);

      void \u0001([MarshalAs(UnmanagedType.LPWStr)] string szName, out int pvValue, ref uint pcbValue, uint dwFlags);

      void \u0001(out int wzDynamicDir, ref uint pdwSize);
    }

    [Guid("CD193BC0-B4BC-11d2-9833-00C04FC31D2E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    internal interface \u0005
    {
      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(uint PropertyId, IntPtr pvProperty, uint cbProperty);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(uint PropertyId, IntPtr pvProperty, ref uint pcbProperty);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001();

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(IntPtr szDisplayName, ref uint pccDisplayName, uint dwDisplayFlags);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(object refIID, object pAsmBindSink, \u0012.\u0004 pApplicationContext, [MarshalAs(UnmanagedType.LPWStr)] string szCodeBase, long llFlags, int pvReserved, uint cbReserved, out int ppv);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(out uint lpcwBuffer, out int pwzName);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(out uint pdwVersionHi, out uint pdwVersionLow);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(\u0012.\u0005 pName, uint dwCmpFlags);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(out \u0012.\u0005 pName);
    }

    [Guid("9e3aaeb4-d1cd-11d2-bab9-00c04f8eceae")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    internal interface \u0006
    {
      void \u0001([MarshalAs(UnmanagedType.LPWStr)] string pszName, uint dwFormat, uint dwFlags, uint dwMaxSize, out \u0012.\u0003 ppStream);

      void \u0002(\u0012.\u0005 pName);

      void \u0001(uint dwFlags);

      void \u0002(uint dwFlags);
    }

    [Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    internal interface \u0007
    {
      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pvReserved, out uint pulDisposition);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pAsmInfo);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(uint dwFlags, IntPtr pvReserved, out \u0012.\u0006 ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0001(out object ppAsmScavenger);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int \u0002(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, IntPtr pvReserved);
    }
  }
}
