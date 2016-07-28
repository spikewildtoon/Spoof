// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001E;
using System;

namespace \u001E
{
  internal struct \u0010 : IEquatable<\u0010>, IEquatable<string>
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    public static readonly int \u0001;
    public unsafe fixed char \u0001[256];
    public byte \u0001;

    public unsafe char this[int index]
    {
      get
      {
        fixed (char* chPtr = &this.\u0001.\u0001)
          return chPtr[index];
      }
      set
      {
        fixed (char* chPtr = &this.\u0001.\u0001)
          chPtr[index] = value;
      }
    }

    static \u0010()
    {
      \u0004.\u001D\u0005(typeof (\u0010));
      \u0010.\u0001 = \u0010.\u0001(65244);
      \u0010.\u0002 = \u0010.\u0001(65317);
      \u0010.\u0001 = (int) byte.MaxValue;
    }

    public unsafe \u0010(string str)
    {
      switch (str)
      {
        case null:
          throw new ArgumentNullException(\u0010.\u0001(65165));
        default:
          if (\u0005\u0081.\u007E\u0001\u0093((object) str) > \u0010.\u0001)
            throw new ArgumentException(\u0010.\u0001);
          // ISSUE: reference to a compiler-generated field
          fixed (char* chPtr = &this.\u0001.\u0001)
          {
            for (int index = 0; index < \u0005\u0081.\u007E\u0001\u0093((object) str); ++index)
              chPtr[index] = \u008C\u0086.\u007E\u009C\u0092((object) str, index);
            chPtr[\u0005\u0081.\u007E\u0001\u0093((object) str)] = char.MinValue;
          }
          this.\u0001 = (byte) \u0005\u0081.\u007E\u0001\u0093((object) str);
          break;
      }
    }

    public unsafe \u0010(\u0010 str, int startIndex, int length)
    {
      if (startIndex >= (int) str.\u0001)
        throw new ArgumentException(\u0010.\u0001(65170));
      if (length > (int) str.\u0001 - startIndex)
        throw new ArgumentException(\u0010.\u0001(65211));
      if (length > \u0010.\u0001)
        throw new ArgumentException(\u0010.\u0001);
      // ISSUE: reference to a compiler-generated field
      fixed (char* dest = &this.\u0001.\u0001)
      {
        // ISSUE: reference to a compiler-generated field
        \u0010.\u001D\u0005(dest, &str.\u0001.\u0001 + startIndex, length);
        dest[length] = char.MinValue;
      }
      this.\u0001 = (byte) length;
    }

    public unsafe \u0010(char* str, int length)
    {
      if (length > \u0010.\u0001)
        throw new ArgumentException(\u0010.\u0001);
      // ISSUE: reference to a compiler-generated field
      fixed (char* dest = &this.\u0001.\u0001)
      {
        \u0010.\u001D\u0005(dest, str, length);
        dest[length] = char.MinValue;
      }
      this.\u0001 = (byte) length;
    }

    public unsafe void \u001D\u0005(char c)
    {
      if ((int) this.\u0001 + 1 > \u0010.\u0001)
        throw new InvalidOperationException(\u0010.\u0002);
      // ISSUE: reference to a compiler-generated field
      fixed (char* chPtr = &this.\u0001.\u0001)
      {
        chPtr[this.\u0001++] = c;
        chPtr[this.\u0001] = char.MinValue;
      }
    }

    public unsafe void \u001D\u0005(\u0010 str)
    {
      if ((int) this.\u0001 + (int) str.\u0001 > \u0010.\u0001)
        throw new InvalidOperationException(\u0010.\u0002);
      // ISSUE: reference to a compiler-generated field
      fixed (char* chPtr = &this.\u0001.\u0001)
      {
        // ISSUE: reference to a compiler-generated field
        \u0010.\u001E\u0005(chPtr + this.\u0001, &str.\u0001.\u0001, (int) str.\u0001);
        this.\u0001 += str.\u0001;
        chPtr[this.\u0001] = char.MinValue;
      }
    }

    public unsafe void \u001D\u0005(string str)
    {
      if ((int) this.\u0001 + \u0005\u0081.\u007E\u0001\u0093((object) str) > \u0010.\u0001)
        throw new InvalidOperationException(\u0010.\u0002);
      // ISSUE: reference to a compiler-generated field
      fixed (char* chPtr = &this.\u0001.\u0001)
      {
        for (int index = 0; index < \u0005\u0081.\u007E\u0001\u0093((object) str); ++index)
          chPtr[this.\u0001++] = \u008C\u0086.\u007E\u009C\u0092((object) str, index);
        chPtr[this.\u0001] = char.MinValue;
      }
    }

    public unsafe int \u001D\u0005(\u0010 str)
    {
      // ISSUE: reference to a compiler-generated field
      fixed (char* buf1 = &this.\u0001.\u0001)
      {
        // ISSUE: reference to a compiler-generated field
        int num = \u0010.\u001D\u0005(buf1, &str.\u0001.\u0001, (int) this.\u0001 < (int) str.\u0001 ? (int) this.\u0001 : (int) str.\u0001);
        if (num != 0)
          return num;
        return (int) this.\u0001 - (int) str.\u0001;
      }
    }

    public unsafe bool \u001D\u0005(\u0010 str)
    {
      if ((int) str.\u0001 > (int) this.\u0001)
        return false;
      // ISSUE: reference to a compiler-generated field
      fixed (char* chPtr = &this.\u0001.\u0001)
      {
        // ISSUE: reference to a compiler-generated field
        return \u0010.\u001D\u0005(chPtr + ((int) this.\u0001 - (int) str.\u0001), &str.\u0001.\u0001, (int) str.\u0001) == 0;
      }
    }

    public override bool Equals(object other)
    {
      if (other is \u0010)
        return this.Equals((\u0010) other);
      if (!(other is string))
        return false;
      return this.Equals((string) other);
    }

    public unsafe bool Equals(\u0010 other)
    {
      if ((int) this.\u0001 != (int) other.\u0001)
        return false;
      // ISSUE: reference to a compiler-generated field
      fixed (char* chPtr = &this.\u0001.\u0001)
      {
        for (int index = 0; index < (int) other.\u0001; int num = index++)
        {
          // ISSUE: reference to a compiler-generated field
          if ((int) chPtr[index] != (int) (&other.\u0001.\u0001)[index])
            return false;
        }
      }
      return true;
    }

    public unsafe bool Equals(string other)
    {
      if ((int) this.\u0001 != \u0005\u0081.\u007E\u0001\u0093((object) other))
        return false;
      // ISSUE: reference to a compiler-generated field
      fixed (char* chPtr = &this.\u0001.\u0001)
      {
        for (int index = 0; index < \u0005\u0081.\u007E\u0001\u0093((object) other); ++index)
        {
          if ((int) chPtr[index] != (int) \u008C\u0086.\u007E\u009C\u0092((object) other, index))
            return false;
        }
      }
      return true;
    }

    public unsafe int \u001D\u0005(char c)
    {
      // ISSUE: reference to a compiler-generated field
      fixed (char* buf = &this.\u0001.\u0001)
      {
        char* chPtr = \u0010.\u001D\u0005(buf, c, (int) this.\u0001);
        if ((IntPtr) chPtr == IntPtr.Zero)
          return -1;
        return (int) (chPtr - buf);
      }
    }

    public override int GetHashCode()
    {
      return 352654597 * \u0005\u0081.\u007E\u008A\u0091((object) this.ToString());
    }

    public unsafe bool \u001E\u0005(\u0010 str)
    {
      if ((int) str.\u0001 > (int) this.\u0001)
        return false;
      // ISSUE: reference to a compiler-generated field
      fixed (char* buf1 = &this.\u0001.\u0001)
      {
        // ISSUE: reference to a compiler-generated field
        return \u0010.\u001D\u0005(buf1, &str.\u0001.\u0001, (int) str.\u0001) == 0;
      }
    }

    public \u0010 \u001D\u0005(int startIndex)
    {
      return this.\u001D\u0005(startIndex, (int) this.\u0001 - startIndex);
    }

    public \u0010 \u001D\u0005(int startIndex, int length)
    {
      return new \u0010(this, startIndex, length);
    }

    public override unsafe string ToString()
    {
      // ISSUE: reference to a compiler-generated field
      fixed (char* chPtr = &this.\u0001.\u0001)
        return new string(chPtr, 0, (int) this.\u0001);
    }
  }
}
