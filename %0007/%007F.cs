// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0007;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace \u0007
{
  [Guid("BAB3768B-8883-4AEC-9F9B-E14C947913EF")]
  [ClassInterface(0)]
  [ComImport]
  public sealed class \u007F : \u0080, \u0081
  {
    [DispId(6307)]
    public virtual int showFlags { [DispId(6307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(6307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    internal \u007F();

    [DispId(6301)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual void \u0092\u0002();

    [DispId(6302)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual void \u0004([In] int nID, [MarshalAs(UnmanagedType.BStr), In] string bstrItem);

    [DispId(6303)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual void \u0093\u0002();

    [DispId(6304)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual void \u0005([In] int nID, [In] bool newVal);

    [DispId(6305)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual void \u0006([In] int nID, [In] bool newVal);

    [DispId(6306)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual void \u0007([In] int nID, [In] bool newVal);

    [DispId(6308)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual int \u007F\u0003();

    [DispId(6309)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual void \u001B\u0002([In] int nID);
  }
}
