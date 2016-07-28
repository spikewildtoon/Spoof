// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0080;
using System.IO;

namespace \u001B
{
  internal sealed class \u0003 : \u0014.\u0080
  {
    protected override int? Version
    {
      get
      {
        return new int?(1);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override int MinimumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override byte[] Header
    {
      get
      {
        return new byte[3]{ (byte) 65, (byte) 67, (byte) 83 };
      }
    }

    public string Username { get; set; }

    public string Password { get; set; }

    public string ReferenceName { get; set; }

    public \u0001 ToonTownAccountType { get; set; }

    public \u0003(string referenceName, string username, string password, \u0001 type)
    {
      this.ReferenceName = referenceName;
      this.Username = username;
      this.Password = password;
      this.ToonTownAccountType = type;
    }

    public \u0003(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.Username = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      this.Password = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      this.ReferenceName = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      this.ToonTownAccountType = (\u0001) \u0011\u001C.\u007E\u0097\u009D((object) reader);
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0092\u0081.\u007E\u001A\u009E((object) writer, this.Username);
      \u0092\u0081.\u007E\u001A\u009E((object) writer, this.Password);
      \u0092\u0081.\u007E\u001A\u009E((object) writer, this.ReferenceName);
      \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.ToonTownAccountType);
    }

    public override string ToString()
    {
      return this.ReferenceName;
    }
  }
}
