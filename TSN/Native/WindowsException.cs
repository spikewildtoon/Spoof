// Decompiled with JetBrains decompiler
// Type: TSN.Native.WindowsException
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001E;
using \u001F;
using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using TSN.Native.Enums;

namespace TSN.Native
{
  [Serializable]
  public sealed class WindowsException : Exception
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private string m_sMessage;

    public bool IsNT_STATUS { get; private set; }

    public Win32Error ErrorCode { get; private set; }

    public NtStatus Status { get; private set; }

    public override string Message
    {
      get
      {
        if (this.m_sMessage == null)
          goto label_2;
label_1:
        return this.m_sMessage;
label_2:
        this.m_sMessage = !this.IsNT_STATUS || this.Status == NtStatus.AccessDenied || this.Status == NtStatus.AccessViolation ? this.ErrorCode.\u001D\u0005() : this.Status.\u001D\u0005() ?? \u009E\u0081.\u001F\u0093(WindowsException.\u0001(34250), (object) (int) this.Status);
        goto label_1;
      }
    }

    static WindowsException()
    {
      \u0004.\u001D\u0005(typeof (WindowsException));
    }

    public WindowsException()
    {
    }

    public WindowsException(Win32Error errorCode)
    {
      this.ErrorCode = errorCode;
    }

    public WindowsException(NtStatus status)
    {
      this.Status = status;
      this.ErrorCode = status.\u001D\u0005();
      this.IsNT_STATUS = true;
    }

    private WindowsException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.m_sMessage = \u0090\u0083.\u007E\u0010\u009C((object) info, WindowsException.\u0001(34106));
      // ISSUE: type reference
      this.Status = (NtStatus) \u001C\u001C.\u007E\u000E\u009C((object) info, WindowsException.\u0001(34139), \u009C\u0082.\u0016\u0097(__typeref (NtStatus)));
      // ISSUE: type reference
      this.ErrorCode = (Win32Error) \u001C\u001C.\u007E\u000E\u009C((object) info, WindowsException.\u0001(34172), \u009C\u0082.\u0016\u0097(__typeref (Win32Error)));
      this.IsNT_STATUS = \u0016\u001D.\u007E\u000F\u009C((object) info, WindowsException.\u0001(34209));
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      \u0001\u0083.\u0092\u0091((object) this, info, context);
      \u008B\u0083.\u007E\u0007\u009C((object) info, WindowsException.\u0001(34106), (object) this.m_sMessage);
      // ISSUE: type reference
      \u009D\u0086.\u007E\u0006\u009C((object) info, WindowsException.\u0001(34139), (object) this.Status, \u009C\u0082.\u0016\u0097(__typeref (NtStatus)));
      // ISSUE: type reference
      \u009D\u0086.\u007E\u0006\u009C((object) info, WindowsException.\u0001(34172), (object) this.ErrorCode, \u009C\u0082.\u0016\u0097(__typeref (Win32Error)));
      \u009A\u007F.\u007E\u0008\u009C((object) info, WindowsException.\u0001(34209), this.IsNT_STATUS);
    }
  }
}
