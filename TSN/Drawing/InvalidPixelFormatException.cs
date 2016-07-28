// Decompiled with JetBrains decompiler
// Type: TSN.Drawing.InvalidPixelFormatException
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace TSN.Drawing
{
  [Serializable]
  public sealed class InvalidPixelFormatException : Exception
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    public PixelFormat PixelFormat { get; private set; }

    static InvalidPixelFormatException()
    {
      \u0004.\u001D\u0005(typeof (InvalidPixelFormatException));
    }

    public InvalidPixelFormatException(PixelFormat pixelFormat)
    {
      this.PixelFormat = pixelFormat;
    }

    private InvalidPixelFormatException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      // ISSUE: type reference
      this.PixelFormat = (PixelFormat) \u001C\u001C.\u007E\u000E\u009C((object) info, InvalidPixelFormatException.\u0001(105529), \u009C\u0082.\u0016\u0097(__typeref (PixelFormat)));
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      \u0001\u0083.\u0092\u0091((object) this, info, context);
      // ISSUE: type reference
      \u009D\u0086.\u007E\u0006\u009C((object) info, InvalidPixelFormatException.\u0001(105529), (object) this.PixelFormat, \u009C\u0082.\u0016\u0097(__typeref (PixelFormat)));
    }
  }
}
