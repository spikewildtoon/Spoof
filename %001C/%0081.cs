// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u001F;
using System.IO;

namespace \u001C
{
  internal sealed class \u0081 : \u0080
  {
    public bool TopMost { get; set; }

    public bool AnimateController { get; set; }

    public bool UseOpacity { get; set; }

    public \u0007 KeyboardLayout { get; set; }

    protected override int? Version
    {
      get
      {
        return new int?(2);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 2;
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
        return new byte[3]{ (byte) 82, (byte) 67, (byte) 83 };
      }
    }

    public \u0081()
    {
      this.TopMost = false;
      this.AnimateController = true;
      this.UseOpacity = true;
      this.KeyboardLayout = \u0007.\u0001;
    }

    public \u0081(BinaryReader reader)
      : base(reader)
    {
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.TopMost);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.AnimateController);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.UseOpacity);
      \u0095\u001F.\u007E\u000F\u009E((object) writer, (byte) this.KeyboardLayout);
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.TopMost = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.AnimateController = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.UseOpacity = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      if (version > 1)
        this.KeyboardLayout = (\u0007) \u0001\u0081.\u007E\u0096\u009D((object) reader);
      else
        this.KeyboardLayout = \u0007.\u0001;
    }
  }
}
