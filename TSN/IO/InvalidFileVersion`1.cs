// Decompiled with JetBrains decompiler
// Type: TSN.IO.InvalidFileVersion`1
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace TSN.IO
{
  [Serializable]
  public sealed class InvalidFileVersion<T> : IOException
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    public T MinimumVersion { get; private set; }

    public T MaximumVersion { get; private set; }

    public T ActualVersion { get; private set; }

    static InvalidFileVersion()
    {
      \u0004.\u001D\u0005(typeof (InvalidFileVersion<>));
    }

    public InvalidFileVersion(T minimumVersion, T maximumVersion, T actualVersion)
      : base(InvalidFileVersion<T>.\u001D\u0005(minimumVersion, maximumVersion, actualVersion))
    {
      this.MinimumVersion = minimumVersion;
      this.MaximumVersion = maximumVersion;
      this.ActualVersion = actualVersion;
    }

    private InvalidFileVersion(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      // ISSUE: type reference
      this.ActualVersion = (T) \u001C\u001C.\u007E\u000E\u009C((object) info, \u0006.\u001D\u0005(62619), \u009C\u0082.\u0016\u0097(__typeref (T)));
      // ISSUE: type reference
      this.MinimumVersion = (T) \u001C\u001C.\u007E\u000E\u009C((object) info, \u0006.\u001D\u0005(62640), \u009C\u0082.\u0016\u0097(__typeref (T)));
      // ISSUE: type reference
      this.MaximumVersion = (T) \u001C\u001C.\u007E\u000E\u009C((object) info, \u0006.\u001D\u0005(62661), \u009C\u0082.\u0016\u0097(__typeref (T)));
    }

    private static string \u001D\u0005(T minimumVersion, T maximumVersion, T actualVersion)
    {
      return \u0013\u001C.\u0080\u0093(\u0006.\u001D\u0005(62445), (object) minimumVersion, (object) maximumVersion, (object) actualVersion);
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      // ISSUE: type reference
      \u009D\u0086.\u007E\u0006\u009C((object) info, \u0006.\u001D\u0005(62619), (object) this.ActualVersion, \u009C\u0082.\u0016\u0097(__typeref (T)));
      // ISSUE: type reference
      \u009D\u0086.\u007E\u0006\u009C((object) info, \u0006.\u001D\u0005(62640), (object) this.MinimumVersion, \u009C\u0082.\u0016\u0097(__typeref (T)));
      // ISSUE: type reference
      \u009D\u0086.\u007E\u0006\u009C((object) info, \u0006.\u001D\u0005(62661), (object) this.MaximumVersion, \u009C\u0082.\u0016\u0097(__typeref (T)));
      \u0001\u0083.\u0092\u0091((object) this, info, context);
    }
  }
}
