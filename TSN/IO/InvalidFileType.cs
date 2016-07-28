// Decompiled with JetBrains decompiler
// Type: TSN.IO.InvalidFileType
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace TSN.IO
{
  [Serializable]
  public sealed class InvalidFileType : IOException
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string g_sFileMessage;
    private static readonly string g_sStreamMessage;

    public string FileName { get; private set; }

    static InvalidFileType()
    {
      \u0004.\u001D\u0005(typeof (InvalidFileType));
      InvalidFileType.g_sFileMessage = InvalidFileType.\u0001(44753);
      InvalidFileType.g_sStreamMessage = InvalidFileType.\u0001(44891);
    }

    public InvalidFileType(string fileName)
      : base(InvalidFileType.\u001D\u0005(fileName, (byte[]) null, (byte[]) null))
    {
      this.FileName = fileName;
    }

    public InvalidFileType(byte[] expectedHeader, byte[] actualHeader)
      : base(InvalidFileType.\u001D\u0005(string.Empty, expectedHeader, actualHeader))
    {
    }

    public InvalidFileType(string expectedHeader, string actualHeader)
      : base(InvalidFileType.\u001D\u0005(string.Empty, expectedHeader, actualHeader))
    {
    }

    public InvalidFileType(string fileName, byte[] expectedHeader, byte[] actualHeader)
      : base(InvalidFileType.\u001D\u0005(fileName, expectedHeader, actualHeader))
    {
      this.FileName = fileName;
    }

    public InvalidFileType(string fileName, string expectedHeader, string actualHeader)
      : base(InvalidFileType.\u001D\u0005(fileName, expectedHeader, actualHeader))
    {
      this.FileName = fileName;
    }

    private InvalidFileType(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.FileName = \u0090\u0083.\u007E\u0010\u009C((object) info, InvalidFileType.\u0001(44720));
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      \u0001\u0083.\u0092\u0091((object) this, info, context);
      // ISSUE: type reference
      \u009D\u0086.\u007E\u0006\u009C((object) info, InvalidFileType.\u0001(44720), (object) this.FileName, \u009C\u0082.\u0016\u0097(__typeref (string)));
    }

    private static string \u001D\u0005(string fileName, byte[] expectedHeader, byte[] actualHeader)
    {
      if (\u008F\u0084.\u009E\u0092(fileName))
        return \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, InvalidFileType.g_sStreamMessage, new object[2]{ (object) InvalidFileType.\u001D\u0005(expectedHeader), (object) InvalidFileType.\u001D\u0005(actualHeader) });
      return \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, InvalidFileType.g_sFileMessage, new object[3]{ (object) fileName, (object) InvalidFileType.\u001D\u0005(expectedHeader), (object) InvalidFileType.\u001D\u0005(actualHeader) });
    }

    private static string \u001D\u0005(string fileName, string expectedHeader, string actualHeader)
    {
      if (\u008F\u0084.\u009E\u0092(fileName))
        return string.Format((IFormatProvider) \u0013.\u0001, InvalidFileType.g_sStreamMessage, new object[2]{ (object) (expectedHeader ?? InvalidFileType.\u0001(2969)), (object) (actualHeader ?? InvalidFileType.\u0001(2969)) });
      return string.Format((IFormatProvider) \u0013.\u0001, InvalidFileType.g_sFileMessage, (object) fileName, (object) (expectedHeader ?? InvalidFileType.\u0001(2969)), (object) (actualHeader ?? InvalidFileType.\u0001(2969)));
    }

    private static string \u001D\u0005(byte[] b)
    {
      if (b == null)
        return InvalidFileType.\u0001(2969);
      string str = string.Empty;
      for (int index = 0; index < b.Length; ++index)
      {
        if (\u0008\u001F.\u009B\u0092(str, string.Empty))
          str = \u0081\u0086.\u0086\u0093(str, InvalidFileType.\u0001(28290));
        str = \u0081\u0086.\u0086\u0093(str, b[index].ToString((IFormatProvider) \u0013.\u0001));
      }
      return str;
    }
  }
}
