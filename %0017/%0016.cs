// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001C;
using \u0081;
using System;
using System.IO;
using TheToonTownSpoofer.IO.Compression.BZip2;

namespace \u0017
{
  internal sealed class \u0016 : Stream
  {
    private \u0081.\u001C \u0001 = (\u0081.\u001C) new \u001D();
    private bool[] \u0001 = new bool[256];
    private byte[] \u0001 = new byte[256];
    private byte[] \u0002 = new byte[256];
    private byte[] \u0003 = new byte[\u0015.\u000E];
    private byte[] \u0004 = new byte[\u0015.\u000E];
    private int[] \u0002 = new int[256];
    private int[][] \u0001 = new int[\u0015.\u0006][];
    private int[][] \u0002 = new int[\u0015.\u0006][];
    private int[][] \u0003 = new int[\u0015.\u0006][];
    private int[] \u0003 = new int[\u0015.\u0006];
    private int \u0013 = -1;
    private int \u0014 = 1;
    private bool \u0003 = true;
    [NonSerialized]
    internal static \u0002 \u0001;
    private const int \u0001 = 1;
    private const int \u0002 = 2;
    private const int \u0003 = 3;
    private const int \u0004 = 4;
    private const int \u0005 = 5;
    private const int \u0006 = 6;
    private const int \u0007 = 7;
    private int \u0008;
    private int \u000E;
    private int \u000F;
    private bool \u0001;
    private int \u0010;
    private int \u0011;
    private int \u0012;
    private int[] \u0001;
    private byte[] \u0005;
    private Stream \u0001;
    private bool \u0002;
    private int \u0015;
    private int \u0016;
    private int \u0017;
    private uint \u0001;
    private int \u0018;
    private int \u0019;
    private int \u001A;
    private int \u001B;
    private int \u001C;
    private int \u001D;
    private int \u001E;
    private int \u001F;
    private byte \u0001;

    public bool IsStreamOwner
    {
      get
      {
        return this.\u0003;
      }
      set
      {
        this.\u0003 = value;
      }
    }

    public override bool CanRead
    {
      get
      {
        return \u0099\u0082.\u007E\u001E\u009D((object) this.\u0001);
      }
    }

    public override bool CanSeek
    {
      get
      {
        return \u0099\u0082.\u007E\u001F\u009D((object) this.\u0001);
      }
    }

    public override bool CanWrite
    {
      get
      {
        return false;
      }
    }

    public override long Length
    {
      get
      {
        return \u001F\u001E.\u007E\u0080\u009D((object) this.\u0001);
      }
    }

    public override long Position
    {
      get
      {
        return \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001);
      }
      set
      {
        throw new NotSupportedException(\u0016.\u0001(27715));
      }
    }

    static \u0016()
    {
      \u0004.\u001D\u0005(typeof (\u0016));
    }

    public \u0016(Stream stream)
    {
      for (int index = 0; index < \u0015.\u0006; ++index)
      {
        this.\u0001[index] = new int[\u0015.\u0002];
        this.\u0002[index] = new int[\u0015.\u0002];
        this.\u0003[index] = new int[\u0015.\u0002];
      }
      this.\u001D\u0005(stream);
      this.\u001E\u0005();
      this.\u001F\u0005();
      this.\u0084\u0005();
    }

    public override void Flush()
    {
      if (this.\u0001 == null)
        return;
      \u001A\u001E.\u007E\u0088\u009D((object) this.\u0001);
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
      throw new NotSupportedException(\u0016.\u0001(27768));
    }

    public override void SetLength(long value)
    {
      throw new NotSupportedException(\u0016.\u0001(27817));
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
      throw new NotSupportedException(\u0016.\u0001(27874));
    }

    public override void WriteByte(byte value)
    {
      throw new NotSupportedException(\u0016.\u0001(27923));
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
      if (buffer == null)
        throw new ArgumentNullException(\u0016.\u0001(15760));
      for (int index = 0; index < count; ++index)
      {
        int num = \u0005\u0081.\u007E\u008E\u009D((object) this);
        if (num == -1)
          return index;
        buffer[offset + index] = (byte) num;
      }
      return count;
    }

    public override void Close()
    {
      if (!this.IsStreamOwner || this.\u0001 == null)
        return;
      \u001A\u001E.\u007E\u0084\u009D((object) this.\u0001);
    }

    public override int ReadByte()
    {
      if (this.\u0002)
        return -1;
      int num = this.\u0013;
      switch (this.\u0014)
      {
        case 3:
          this.\u0088\u0005();
          break;
        case 4:
          this.\u0089\u0005();
          break;
        case 6:
          this.\u008A\u0005();
          break;
        case 7:
          this.\u008B\u0005();
          break;
      }
      return num;
    }

    private void \u001D\u0005()
    {
      this.\u0012 = 0;
      for (int index = 0; index < 256; ++index)
      {
        if (!this.\u0001[index])
          continue;
        this.\u0001[this.\u0012] = (byte) index;
        this.\u0002[index] = (byte) this.\u0012;
        ++this.\u0012;
      }
    }

    private void \u001E\u0005()
    {
      char ch1 = this.\u001D\u0005();
      char ch2 = this.\u001D\u0005();
      char ch3 = this.\u001D\u0005();
      char ch4 = this.\u001D\u0005();
      if ((int) ch1 != 66 || (int) ch2 != 90 || ((int) ch3 != 104 || (int) ch4 < 49) || (int) ch4 > 57)
      {
        this.\u0002 = true;
      }
      else
      {
        this.\u001D\u0005((int) ch4 - 48);
        this.\u0001 = 0U;
      }
    }

    private void \u001F\u0005()
    {
      char ch1 = this.\u001D\u0005();
      char ch2 = this.\u001D\u0005();
      char ch3 = this.\u001D\u0005();
      char ch4 = this.\u001D\u0005();
      char ch5 = this.\u001D\u0005();
      char ch6 = this.\u001D\u0005();
      if ((int) ch1 == 23 && (int) ch2 == 114 && ((int) ch3 == 69 && (int) ch4 == 56) && ((int) ch5 == 80 && (int) ch6 == 144))
        this.\u0080\u0005();
      else if ((int) ch1 != 49 || (int) ch2 != 65 || ((int) ch3 != 89 || (int) ch4 != 38) || ((int) ch5 != 83 || (int) ch6 != 89))
      {
        \u0016.\u008E\u0005();
        this.\u0002 = true;
      }
      else
      {
        this.\u0015 = this.\u001D\u0005();
        this.\u0001 = this.\u001D\u0005(1) == 1;
        this.\u0083\u0005();
        this.\u0001.\u009F\u0002();
        this.\u0014 = 1;
      }
    }

    private void \u007F\u0005()
    {
      this.\u0017 = (int) this.\u0001.Value;
      if (this.\u0015 != this.\u0017)
        \u0016.\u008F\u0005();
      this.\u0001 = (uint) ((int) this.\u0001 << 1 & -1) | this.\u0001 >> 31;
      this.\u0001 = this.\u0001 ^ (uint) this.\u0017;
    }

    private void \u0080\u0005()
    {
      this.\u0016 = this.\u001D\u0005();
      if (this.\u0016 != (int) this.\u0001)
        \u0016.\u008F\u0005();
      this.\u0002 = true;
    }

    private void \u001D\u0005(Stream stream)
    {
      this.\u0001 = stream;
      this.\u0011 = 0;
      this.\u0010 = 0;
    }

    private void \u0081\u0005()
    {
      int num = 0;
      try
      {
        num = \u0005\u0081.\u007E\u008E\u009D((object) this.\u0001);
      }
      catch (Exception ex)
      {
        \u0016.\u008C\u0005();
      }
      if (num == -1)
        \u0016.\u008C\u0005();
      this.\u0010 = this.\u0010 << 8 | num & (int) byte.MaxValue;
      this.\u0011 += 8;
    }

    private int \u001D\u0005(int n)
    {
      while (this.\u0011 < n)
        this.\u0081\u0005();
      int num = this.\u0010 >> this.\u0011 - n & (1 << n) - 1;
      this.\u0011 -= n;
      return num;
    }

    private char \u001D\u0005()
    {
      return (char) this.\u001D\u0005(8);
    }

    private int \u001E\u0005(int numBits)
    {
      return this.\u001D\u0005(numBits);
    }

    private int \u001D\u0005()
    {
      return ((this.\u001D\u0005(8) << 8 | this.\u001D\u0005(8)) << 8 | this.\u001D\u0005(8)) << 8 | this.\u001D\u0005(8);
    }

    private void \u0082\u0005()
    {
      char[][] chArray = new char[\u0015.\u0006][];
      for (int index = 0; index < \u0015.\u0006; ++index)
        chArray[index] = new char[\u0015.\u0002];
      bool[] flagArray = new bool[16];
      for (int index = 0; index < 16; ++index)
        flagArray[index] = this.\u001D\u0005(1) == 1;
      for (int index1 = 0; index1 < 16; ++index1)
      {
        if (flagArray[index1])
        {
          for (int index2 = 0; index2 < 16; ++index2)
            this.\u0001[index1 * 16 + index2] = this.\u001D\u0005(1) == 1;
        }
        else
        {
          for (int index2 = 0; index2 < 16; ++index2)
            this.\u0001[index1 * 16 + index2] = false;
        }
      }
      this.\u001D\u0005();
      int alphaSize = this.\u0012 + 2;
      int num1 = this.\u001D\u0005(3);
      int num2 = this.\u001D\u0005(15);
      for (int index = 0; index < num2; ++index)
      {
        int num3 = 0;
        while (this.\u001D\u0005(1) == 1)
          ++num3;
        this.\u0004[index] = (byte) num3;
      }
      byte[] numArray = new byte[\u0015.\u0006];
      for (int index = 0; index < num1; ++index)
        numArray[index] = (byte) index;
      for (int index1 = 0; index1 < num2; ++index1)
      {
        int index2 = (int) this.\u0004[index1];
        byte num3 = numArray[index2];
        for (; index2 > 0; --index2)
          numArray[index2] = numArray[index2 - 1];
        numArray[0] = num3;
        this.\u0003[index1] = num3;
      }
      for (int index1 = 0; index1 < num1; ++index1)
      {
        int num3 = this.\u001D\u0005(5);
        for (int index2 = 0; index2 < alphaSize; ++index2)
        {
          while (this.\u001D\u0005(1) == 1)
          {
            if (this.\u001D\u0005(1) == 0)
              ++num3;
            else
              --num3;
          }
          chArray[index1][index2] = (char) num3;
        }
      }
      for (int index1 = 0; index1 < num1; ++index1)
      {
        int minLen = 32;
        int maxLen = 0;
        for (int index2 = 0; index2 < alphaSize; ++index2)
        {
          maxLen = \u0099\u0081.\u009E\u0096(maxLen, (int) chArray[index1][index2]);
          minLen = \u0099\u0081.\u009F\u0096(minLen, (int) chArray[index1][index2]);
        }
        \u0016.\u001D\u0005(this.\u0001[index1], this.\u0002[index1], this.\u0003[index1], chArray[index1], minLen, maxLen, alphaSize);
        this.\u0003[index1] = minLen;
      }
    }

    private void \u0083\u0005()
    {
      byte[] numArray = new byte[256];
      int num1 = \u0015.\u0001 * this.\u000F;
      this.\u000E = this.\u001E\u0005(24);
      this.\u0082\u0005();
      int num2 = this.\u0012 + 1;
      int index1 = -1;
      int num3 = 0;
      for (int index2 = 0; index2 <= (int) byte.MaxValue; ++index2)
        this.\u0002[index2] = 0;
      for (int index2 = 0; index2 <= (int) byte.MaxValue; ++index2)
        numArray[index2] = (byte) index2;
      this.\u0008 = -1;
      if (num3 == 0)
      {
        ++index1;
        num3 = \u0015.\u0007;
      }
      int num4 = num3 - 1;
      int index3 = (int) this.\u0003[index1];
      int n1 = this.\u0003[index3];
      int num5;
      int num6;
      for (num5 = this.\u001D\u0005(n1); num5 > this.\u0001[index3][n1]; num5 = num5 << 1 | num6)
      {
        if (n1 > 20)
          throw new BZip2Exception(\u0016.\u0001(27980));
        ++n1;
        while (this.\u0011 < 1)
          this.\u0081\u0005();
        num6 = this.\u0010 >> this.\u0011 - 1 & 1;
        --this.\u0011;
      }
      if (num5 - this.\u0002[index3][n1] < 0 || num5 - this.\u0002[index3][n1] >= \u0015.\u0002)
        throw new BZip2Exception(\u0016.\u0001(27980));
      int num7 = this.\u0003[index3][num5 - this.\u0002[index3][n1]];
      while (num7 != num2)
      {
        if (num7 == \u0015.\u0004 || num7 == \u0015.\u0005)
        {
          int num8 = -1;
          int num9 = 1;
          do
          {
            if (num7 == \u0015.\u0004)
              num8 += num9;
            else if (num7 == \u0015.\u0005)
              num8 += 2 * num9;
            num9 <<= 1;
            if (num4 == 0)
            {
              ++index1;
              num4 = \u0015.\u0007;
            }
            --num4;
            int index2 = (int) this.\u0003[index1];
            int n2 = this.\u0003[index2];
            int num10;
            int num11;
            for (num10 = this.\u001D\u0005(n2); num10 > this.\u0001[index2][n2]; num10 = num10 << 1 | num11)
            {
              ++n2;
              while (this.\u0011 < 1)
                this.\u0081\u0005();
              num11 = this.\u0010 >> this.\u0011 - 1 & 1;
              --this.\u0011;
            }
            num7 = this.\u0003[index2][num10 - this.\u0002[index2][n2]];
          }
          while (num7 == \u0015.\u0004 || num7 == \u0015.\u0005);
          int num12 = num8 + 1;
          byte num13 = this.\u0001[(int) numArray[0]];
          this.\u0002[(int) num13] += num12;
          for (; num12 > 0; --num12)
          {
            ++this.\u0008;
            this.\u0005[this.\u0008] = num13;
          }
          if (this.\u0008 >= num1)
            \u0016.\u008D\u0005();
        }
        else
        {
          ++this.\u0008;
          if (this.\u0008 >= num1)
            \u0016.\u008D\u0005();
          byte num8 = numArray[num7 - 1];
          ++this.\u0002[(int) this.\u0001[(int) num8]];
          this.\u0005[this.\u0008] = this.\u0001[(int) num8];
          for (int index2 = num7 - 1; index2 > 0; --index2)
            numArray[index2] = numArray[index2 - 1];
          numArray[0] = num8;
          if (num4 == 0)
          {
            ++index1;
            num4 = \u0015.\u0007;
          }
          --num4;
          int index4 = (int) this.\u0003[index1];
          int n2 = this.\u0003[index4];
          int num9;
          int num10;
          for (num9 = this.\u001D\u0005(n2); num9 > this.\u0001[index4][n2]; num9 = num9 << 1 | num10)
          {
            ++n2;
            while (this.\u0011 < 1)
              this.\u0081\u0005();
            num10 = this.\u0010 >> this.\u0011 - 1 & 1;
            --this.\u0011;
          }
          num7 = this.\u0003[index4][num9 - this.\u0002[index4][n2]];
        }
      }
    }

    private void \u0084\u0005()
    {
      int[] numArray = new int[257];
      numArray[0] = 0;
      \u0089\u0083.\u0084\u0092((Array) this.\u0002, 0, (Array) numArray, 1, 256);
      for (int index = 1; index <= 256; ++index)
        numArray[index] += numArray[index - 1];
      for (int index = 0; index <= this.\u0008; ++index)
      {
        byte num = this.\u0005[index];
        this.\u0001[numArray[(int) num]] = index;
        ++numArray[(int) num];
      }
      this.\u001B = this.\u0001[this.\u000E];
      this.\u0018 = 0;
      this.\u001E = 0;
      this.\u001A = 256;
      if (this.\u0001)
      {
        this.\u001C = 0;
        this.\u001D = 0;
        this.\u0086\u0005();
      }
      else
        this.\u0087\u0005();
    }

    private void \u0086\u0005()
    {
      if (this.\u001E <= this.\u0008)
      {
        this.\u0019 = this.\u001A;
        this.\u001A = (int) this.\u0005[this.\u001B];
        this.\u001B = this.\u0001[this.\u001B];
        if (this.\u001C == 0)
        {
          this.\u001C = \u0015.\u0001[this.\u001D];
          ++this.\u001D;
          if (this.\u001D == 512)
            this.\u001D = 0;
        }
        --this.\u001C;
        this.\u001A ^= this.\u001C == 1 ? 1 : 0;
        ++this.\u001E;
        this.\u0013 = this.\u001A;
        this.\u0014 = 3;
        this.\u0001.\u0088\u0002(this.\u001A);
      }
      else
      {
        this.\u007F\u0005();
        this.\u001F\u0005();
        this.\u0084\u0005();
      }
    }

    private void \u0087\u0005()
    {
      if (this.\u001E <= this.\u0008)
      {
        this.\u0019 = this.\u001A;
        this.\u001A = (int) this.\u0005[this.\u001B];
        this.\u001B = this.\u0001[this.\u001B];
        ++this.\u001E;
        this.\u0013 = this.\u001A;
        this.\u0014 = 6;
        this.\u0001.\u0088\u0002(this.\u001A);
      }
      else
      {
        this.\u007F\u0005();
        this.\u001F\u0005();
        this.\u0084\u0005();
      }
    }

    private void \u0088\u0005()
    {
      if (this.\u001A != this.\u0019)
      {
        this.\u0014 = 2;
        this.\u0018 = 1;
        this.\u0086\u0005();
      }
      else
      {
        ++this.\u0018;
        if (this.\u0018 < 4)
        {
          this.\u0014 = 2;
          this.\u0086\u0005();
        }
        else
        {
          this.\u0001 = this.\u0005[this.\u001B];
          this.\u001B = this.\u0001[this.\u001B];
          if (this.\u001C == 0)
          {
            this.\u001C = \u0015.\u0001[this.\u001D];
            ++this.\u001D;
            if (this.\u001D == 512)
              this.\u001D = 0;
          }
          --this.\u001C;
          this.\u0001 ^= this.\u001C == 1 ? (byte) 1 : (byte) 0;
          this.\u001F = 0;
          this.\u0014 = 4;
          this.\u0089\u0005();
        }
      }
    }

    private void \u0089\u0005()
    {
      if (this.\u001F < (int) this.\u0001)
      {
        this.\u0013 = this.\u001A;
        this.\u0001.\u0088\u0002(this.\u001A);
        ++this.\u001F;
      }
      else
      {
        this.\u0014 = 2;
        ++this.\u001E;
        this.\u0018 = 0;
        this.\u0086\u0005();
      }
    }

    private void \u008A\u0005()
    {
      if (this.\u001A != this.\u0019)
      {
        this.\u0014 = 5;
        this.\u0018 = 1;
        this.\u0087\u0005();
      }
      else
      {
        ++this.\u0018;
        if (this.\u0018 < 4)
        {
          this.\u0014 = 5;
          this.\u0087\u0005();
        }
        else
        {
          this.\u0001 = this.\u0005[this.\u001B];
          this.\u001B = this.\u0001[this.\u001B];
          this.\u0014 = 7;
          this.\u001F = 0;
          this.\u008B\u0005();
        }
      }
    }

    private void \u008B\u0005()
    {
      if (this.\u001F < (int) this.\u0001)
      {
        this.\u0013 = this.\u001A;
        this.\u0001.\u0088\u0002(this.\u001A);
        ++this.\u001F;
      }
      else
      {
        this.\u0014 = 5;
        ++this.\u001E;
        this.\u0018 = 0;
        this.\u0087\u0005();
      }
    }

    private void \u001D\u0005(int newSize100k)
    {
      if (0 > newSize100k || newSize100k > 9 || (0 > this.\u000F || this.\u000F > 9))
        throw new BZip2Exception(\u0016.\u0001(28001));
      this.\u000F = newSize100k;
      if (newSize100k == 0)
        return;
      int length = \u0015.\u0001 * newSize100k;
      this.\u0005 = new byte[length];
      this.\u0001 = new int[length];
    }

    private static void \u008C\u0005()
    {
      throw new EndOfStreamException(\u0016.\u0001(28026));
    }

    private static void \u008D\u0005()
    {
      throw new BZip2Exception(\u0016.\u0001(28087));
    }

    private static void \u008E\u0005()
    {
      throw new BZip2Exception(\u0016.\u0001(28132));
    }

    private static void \u008F\u0005()
    {
      throw new BZip2Exception(\u0016.\u0001(28181));
    }

    private static void \u001D\u0005(int[] limit, int[] baseArray, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
    {
      int index1 = 0;
      for (int index2 = minLen; index2 <= maxLen; ++index2)
      {
        for (int index3 = 0; index3 < alphaSize; ++index3)
        {
          if ((int) length[index3] != index2)
            continue;
          perm[index1] = index3;
          ++index1;
        }
      }
      for (int index2 = 0; index2 < \u0015.\u0003; ++index2)
        baseArray[index2] = 0;
      for (int index2 = 0; index2 < alphaSize; ++index2)
        ++baseArray[(int) length[index2] + 1];
      for (int index2 = 1; index2 < \u0015.\u0003; ++index2)
        baseArray[index2] += baseArray[index2 - 1];
      for (int index2 = 0; index2 < \u0015.\u0003; ++index2)
        limit[index2] = 0;
      int num1 = 0;
      for (int index2 = minLen; index2 <= maxLen; ++index2)
      {
        int num2 = num1 + (baseArray[index2 + 1] - baseArray[index2]);
        limit[index2] = num2 - 1;
        num1 = num2 << 1;
      }
      for (int index2 = minLen + 1; index2 <= maxLen; ++index2)
        baseArray[index2] = (limit[index2 - 1] + 1 << 1) - baseArray[index2];
    }
  }
}
