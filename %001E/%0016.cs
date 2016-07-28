// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u0019;
using \u001A;
using \u001E;
using \u0080;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace \u001E
{
  internal sealed class \u0016 : IDisposable
  {
    private IntPtr \u0001 = IntPtr.Zero;
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private Cursor \u0001;

    internal IntPtr Handle
    {
      get
      {
        return this.\u0001;
      }
    }

    public Cursor Cursor
    {
      get
      {
        return this.\u0001;
      }
    }

    static \u0016()
    {
      \u0004.\u001D\u0005(typeof (\u0016));
      \u0016.\u0001 = \u0016.\u0001(65628);
      \u0016.\u0002 = \u0016.\u0001(65681);
    }

    public \u0016(string fileName)
    {
      IntPtr cursor = \u000E.\u001D\u0005(\u0004\u0080.\u0016\u009D(\u0018\u007F.\u007E\u0014\u0097((object) \u009C\u0083.\u008B\u0091((object) this))), fileName, \u0010.\u0003, 0, 0, \u0011.\u0004);
      if (\u0008\u0081.\u0086\u0096(cursor, IntPtr.Zero))
        throw new Win32Exception(\u0006\u0083.\u0012\u009D(), \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0016.\u0001, new object[1]{ (object) fileName }));
      this.\u001D\u0005(cursor);
    }

    public \u0016(IntPtr handle)
    {
      if (\u0008\u0081.\u0086\u0096(handle, IntPtr.Zero))
        throw new ArgumentException(\u0016.\u0002);
      this.\u001D\u0005(handle);
    }

    public \u0016(int iEmbeddedWin32ResourceID, string sResourceTypeName)
    {
      // ISSUE: unable to decompile the method.
    }

    ~\u0016()
    {
      try
      {
        this.\u001D\u0005(false);
      }
      finally
      {
        \u001A\u001E.\u008C\u0091((object) this);
      }
    }

    private void \u001D\u0005(IntPtr cursor)
    {
      this.\u0001 = cursor;
      if (!\u0008\u0081.\u0087\u0096(this.\u0001, IntPtr.Zero))
        return;
      this.\u0001 = new Cursor(this.\u0001);
    }

    public void Dispose()
    {
      this.\u001D\u0005(true);
      \u001A\u001E.\u0005\u0096((object) this);
    }

    private void \u001D\u0005(bool disposing)
    {
      if (\u0008\u0081.\u0087\u0096(this.\u0001, IntPtr.Zero))
      {
        \u000E.\u001F\u0005(this.\u0001);
        this.\u0001 = IntPtr.Zero;
      }
      if (!disposing || !\u0090\u0086.\u0005\u008A(this.\u0001, (Cursor) null))
        return;
      \u001A\u001E.\u007E\u0002\u008A((object) this.\u0001);
      this.\u0001 = (Cursor) null;
    }
  }
}
