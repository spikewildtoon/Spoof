// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u0084;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace \u0084
{
  internal sealed class \u001C : \u0080, IEnumerable, IEnumerable<\u001B>
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
        return new byte[3]
        {
          (byte) 70,
          (byte) 73,
          (byte) 83
        };
      }
    }

    public List<\u001B> Files { get; private set; }

    public \u001C()
    {
      this.Files = new List<\u001B>();
    }

    public \u001C(BinaryReader reader)
      : base(reader)
    {
    }

    public void \u001E\u0005(string filePath)
    {
      \u001B obj = new \u001B(filePath);
      if (this.Files.Contains(obj))
        return;
      this.Files.Add(obj);
    }

    public void \u001F\u0005(string filePath)
    {
      \u001B obj = new \u001B(filePath);
      if (!this.Files.Contains(obj))
        return;
      this.Files.Remove(obj);
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.Files = new List<\u001B>();
      int num = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index = 0; index < num; ++index)
      {
        string displayName = \u0002\u007F.\u007E\u0001\u009E((object) reader);
        string fileName = \u0002\u007F.\u007E\u0001\u009E((object) reader);
        if (\u008F\u0084.\u0092\u009E(fileName))
          this.Files.Add(new \u001B(displayName, fileName));
      }
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.Files.Count);
      foreach (\u001B file in this.Files)
      {
        \u0092\u0081.\u007E\u001A\u009E((object) writer, file.\u0001);
        \u0092\u0081.\u007E\u001A\u009E((object) writer, file.\u0002);
      }
    }

    public IEnumerator<\u001B> GetEnumerator()
    {
      return (IEnumerator<\u001B>) this.Files.GetEnumerator();
    }

    IEnumerator IEnumerable.\u001D\u0005()
    {
      return (IEnumerator) this.GetEnumerator();
    }
  }
}
