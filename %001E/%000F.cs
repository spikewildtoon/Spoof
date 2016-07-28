// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001E;
using System.Security.AccessControl;
using System.Security.Principal;

namespace \u001E
{
  internal static class \u000F
  {
    public static DirectorySecurity GetDirectorySecurity
    {
      get
      {
        DirectorySecurity directorySecurity = new DirectorySecurity();
        \u009D\u007F.\u007E\u0008\u0001\u0002((object) directorySecurity, \u000F.\u001D\u0005(WellKnownSidType.CreatorOwnerSid));
        \u009D\u007F.\u007E\u0008\u0001\u0002((object) directorySecurity, \u000F.\u001D\u0005(WellKnownSidType.LocalSystemSid));
        \u009D\u007F.\u007E\u0008\u0001\u0002((object) directorySecurity, \u000F.\u001D\u0005(WellKnownSidType.BuiltinUsersSid));
        \u009D\u007F.\u007E\u0008\u0001\u0002((object) directorySecurity, \u000F.\u001D\u0005(WellKnownSidType.BuiltinAdministratorsSid));
        return directorySecurity;
      }
    }

    private static FileSystemAccessRule \u001D\u0005(WellKnownSidType sid)
    {
      return new FileSystemAccessRule((IdentityReference) new SecurityIdentifier(sid, (SecurityIdentifier) null), FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
    }
  }
}
