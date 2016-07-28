// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001D;
using \u001E;
using System;

namespace \u001D
{
  internal struct \u000E : IEquatable<\u000E>, IDisposable, ICloneable, IComparable<\u000E>
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public ushort \u0001;
    public ushort \u0002;
    internal IntPtr \u0001;

    static \u000E()
    {
      \u0004.\u001D\u0005(typeof (\u000E));
    }

    public \u000E(string str)
    {
      switch (str)
      {
        case null:
          this.\u0001 = (ushort) 0;
          this.\u0002 = (ushort) 0;
          this.\u0001 = IntPtr.Zero;
          break;
        default:
          \u000E DestinationString;
          if (!\u000E.\u001D\u0005(out DestinationString, str))
            throw new OutOfMemoryException();
          this = DestinationString;
          break;
      }
    }

    public int \u001D\u0005(\u000E unicodeString, bool caseInsensitive)
    {
      return \u000E.\u001D\u0005(ref this, ref unicodeString, caseInsensitive);
    }

    public int CompareTo(\u000E unicodeString)
    {
      return this.\u001D\u0005(unicodeString, false);
    }

    public void Dispose()
    {
      if (\u0008\u0081.\u0086\u0096(this.\u0001, IntPtr.Zero))
        return;
      \u000E.\u001D\u0005(ref this);
      this.\u0001 = IntPtr.Zero;
    }

    public object Clone()
    {
      return (object) this.\u001D\u0005();
    }

    public \u000E \u001D\u0005()
    {
      \u000E StringOut;
      \u000E.\u001D\u0005(\u0015.\u0002 | \u0015.\u0003, ref this, out StringOut).\u001E\u0005();
      return StringOut;
    }

    public bool \u001D\u0005(\u000E unicodeString, bool caseInsensitive)
    {
      return \u000E.\u001D\u0005(ref this, ref unicodeString, caseInsensitive);
    }

    public bool Equals(\u000E unicodeString)
    {
      return this.\u001D\u0005(unicodeString, false);
    }

    public override int GetHashCode()
    {
      return this.\u001D\u0005();
    }

    public int \u001D\u0005(\u0012 algorithm, bool caseInsensitive)
    {
      int HashValue;
      \u000E.\u001D\u0005(ref this, caseInsensitive, algorithm, out HashValue).\u001E\u0005();
      return HashValue;
    }

    public int \u001D\u0005(\u0012 algorithm)
    {
      return this.\u001D\u0005(algorithm, false);
    }

    public int \u001D\u0005()
    {
      return this.\u001D\u0005(\u0012.\u0001);
    }

    public string \u001D\u0005()
    {
      if ((int) this.\u0001 == 0)
        return \u000E.\u0001(5080);
      return \u0005\u0080.\u0003\u009D(this.\u0001, (int) this.\u0001 / 2);
    }

    public override string ToString()
    {
      return this.\u001D\u0005();
    }

    public bool \u001E\u0005(\u000E unicodeString, bool caseInsensitive)
    {
      return \u000E.\u001E\u0005(ref this, ref unicodeString, caseInsensitive);
    }

    public bool \u001D\u0005(\u000E unicodeString)
    {
      return this.\u001E\u0005(unicodeString, false);
    }
  }
}
