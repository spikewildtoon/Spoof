// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001C;
using \u0081;
using System;
using System.IO;
using TheToonTownSpoofer.IO.Compression.BZip2;

namespace \u001C
{
  internal sealed class \u0014 : Stream
  {
    private readonly int[] \u0001 = new int[14]{ 1, 4, 13, 40, 121, 364, 1093, 3280, 9841, 29524, 88573, 265720, 797161, 2391484 };
    private bool \u0001 = true;
    private \u0081.\u001C \u0001 = (\u0081.\u001C) new \u001D();
    private bool[] \u0001 = new bool[256];
    private char[] \u0001 = new char[256];
    private char[] \u0002 = new char[256];
    private char[] \u0003 = new char[\u0015.\u000E];
    private char[] \u0004 = new char[\u0015.\u000E];
    private int[] \u0005 = new int[\u0015.\u0002];
    private int \u0019 = -1;
    [NonSerialized]
    internal static \u0002 \u0001;
    private const int \u0001 = 2097152;
    private const int \u0002 = -2097153;
    private const int \u0003 = 15;
    private const int \u0004 = 0;
    private const int \u0005 = 20;
    private const int \u0006 = 10;
    private const int \u0007 = 1000;
    private int \u0008;
    private int \u000E;
    private int \u000F;
    private bool \u0002;
    private int \u0010;
    private int \u0011;
    private int \u0012;
    private int \u0013;
    private byte[] \u0001;
    private int[] \u0002;
    private int[] \u0003;
    private short[] \u0001;
    private int[] \u0004;
    private int \u0014;
    private int \u0015;
    private int \u0016;
    private int \u0017;
    private bool \u0003;
    private int \u0018;
    private int \u001A;
    private uint \u0001;
    private uint \u0002;
    private int \u001B;
    private Stream \u0001;
    private bool \u0004;

    public bool IsStreamOwner
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
      }
    }

    public override bool CanRead
    {
      get
      {
        return false;
      }
    }

    public override bool CanSeek
    {
      get
      {
        return false;
      }
    }

    public override bool CanWrite
    {
      get
      {
        return \u0099\u0082.\u007E\u007F\u009D((object) this.\u0001);
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
        throw new NotSupportedException(\u0014.\u0001(59492));
      }
    }

    public int BytesWritten
    {
      get
      {
        return this.\u0010;
      }
    }

    static \u0014()
    {
      \u0004.\u001D\u0005(typeof (\u0014));
    }

    public \u0014(Stream stream)
      : this(stream, 9)
    {
    }

    public \u0014(Stream stream, int blockSize)
    {
      this.\u001D\u0005(stream);
      this.\u0015 = 50;
      if (blockSize > 9)
        blockSize = 9;
      if (blockSize < 1)
        blockSize = 1;
      this.\u000F = blockSize;
      this.\u0089\u0005();
      this.\u001F\u0005();
      this.\u007F\u0005();
    }

    ~\u0014()
    {
      try
      {
        \u0099\u001F.\u007E\u0087\u009D((object) this, false);
      }
      finally
      {
        \u001A\u001E.\u008C\u0091((object) this);
      }
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
      throw new NotSupportedException(\u0014.\u0001(59549));
    }

    public override void SetLength(long value)
    {
      throw new NotSupportedException(\u0014.\u0001(59598));
    }

    public override int ReadByte()
    {
      throw new NotSupportedException(\u0014.\u0001(59655));
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
      throw new NotSupportedException(\u0014.\u0001(59712));
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
      if (buffer == null)
        throw new ArgumentNullException(\u0014.\u0001(17280));
      if (offset < 0)
        throw new ArgumentOutOfRangeException(\u0014.\u0001(59761));
      if (count < 0)
        throw new ArgumentOutOfRangeException(\u0014.\u0001(59770));
      if (buffer.Length - offset < count)
        throw new ArgumentException(\u0014.\u0001(59779));
      for (int index = 0; index < count; ++index)
        \u0095\u001F.\u007E\u0090\u009D((object) this, buffer[offset + index]);
    }

    public override void WriteByte(byte value)
    {
      int num = (256 + (int) value) % 256;
      if (this.\u0019 == -1)
      {
        this.\u0019 = num;
        ++this.\u001A;
      }
      else if (this.\u0019 != num)
      {
        this.\u001E\u0005();
        this.\u001A = 1;
        this.\u0019 = num;
      }
      else
      {
        ++this.\u001A;
        if (this.\u001A <= 254)
          return;
        this.\u001E\u0005();
        this.\u0019 = -1;
        this.\u001A = 0;
      }
    }

    public override void Close()
    {
      \u0099\u001F.\u007E\u0087\u009D((object) this, true);
      \u001A\u001E.\u0005\u0096((object) this);
    }

    private void \u001D\u0005()
    {
      this.\u0013 = 0;
      for (int index = 0; index < 256; ++index)
      {
        if (!this.\u0001[index])
          continue;
        this.\u0001[this.\u0013] = (char) index;
        this.\u0002[index] = (char) this.\u0013;
        ++this.\u0013;
      }
    }

    private void \u001E\u0005()
    {
      if (this.\u0008 >= this.\u001B)
      {
        this.\u0080\u0005();
        this.\u007F\u0005();
        this.\u001E\u0005();
      }
      else
      {
        this.\u0001[this.\u0019] = true;
        for (int index = 0; index < this.\u001A; int num = index++)
          this.\u0001.\u0088\u0002(this.\u0019);
        switch (this.\u001A)
        {
          case 1:
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) this.\u0019;
            break;
          case 2:
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) this.\u0019;
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) this.\u0019;
            break;
          case 3:
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) this.\u0019;
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) this.\u0019;
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) this.\u0019;
            break;
          default:
            this.\u0001[this.\u001A - 4] = true;
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) this.\u0019;
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) this.\u0019;
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) this.\u0019;
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) this.\u0019;
            ++this.\u0008;
            this.\u0001[this.\u0008 + 1] = (byte) (this.\u001A - 4);
            break;
        }
      }
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        \u0099\u001F.\u0087\u009D((object) this, disposing);
        if (this.\u0004)
          return;
        this.\u0004 = true;
        if (this.\u001A > 0)
          this.\u001E\u0005();
        this.\u0019 = -1;
        this.\u0080\u0005();
        this.\u0081\u0005();
        \u001A\u001E.\u007E\u0088\u009D((object) this);
      }
      finally
      {
        if (disposing && this.IsStreamOwner)
          \u001A\u001E.\u007E\u0084\u009D((object) this.\u0001);
      }
    }

    public override void Flush()
    {
      \u001A\u001E.\u007E\u0088\u009D((object) this.\u0001);
    }

    private void \u001F\u0005()
    {
      this.\u0010 = 0;
      this.\u0018 = 0;
      this.\u001D\u0005(66);
      this.\u001D\u0005(90);
      this.\u001D\u0005(104);
      this.\u001D\u0005(48 + this.\u000F);
      this.\u0002 = 0U;
    }

    private void \u007F\u0005()
    {
      this.\u0001.\u009F\u0002();
      this.\u0008 = -1;
      for (int index = 0; index < 256; ++index)
        this.\u0001[index] = false;
      this.\u001B = \u0015.\u0001 * this.\u000F - 20;
    }

    private void \u0080\u0005()
    {
      if (this.\u0008 < 0)
        return;
      this.\u0001 = (uint) this.\u0001.Value;
      this.\u0002 = this.\u0002 << 1 | this.\u0002 >> 31;
      this.\u0002 ^= this.\u0001;
      this.\u0088\u0005();
      this.\u001D\u0005(49);
      this.\u001D\u0005(65);
      this.\u001D\u0005(89);
      this.\u001D\u0005(38);
      this.\u001D\u0005(83);
      this.\u001D\u0005(89);
      this.\u001E\u0005((int) this.\u0001);
      if (this.\u0002)
      {
        this.\u001D\u0005(1, 1);
        ++this.\u0018;
      }
      else
        this.\u001D\u0005(1, 0);
      this.\u0084\u0005();
    }

    private void \u0081\u0005()
    {
      this.\u001D\u0005(23);
      this.\u001D\u0005(114);
      this.\u001D\u0005(69);
      this.\u001D\u0005(56);
      this.\u001D\u0005(80);
      this.\u001D\u0005(144);
      this.\u001E\u0005((int) this.\u0002);
      this.\u0082\u0005();
    }

    private void \u001D\u0005(Stream stream)
    {
      this.\u0001 = stream;
      this.\u0012 = 0;
      this.\u0011 = 0;
      this.\u0010 = 0;
    }

    private void \u0082\u0005()
    {
      while (this.\u0012 > 0)
      {
        int num = this.\u0011 >> 24;
        \u0095\u001F.\u007E\u0090\u009D((object) this.\u0001, (byte) num);
        this.\u0011 <<= 8;
        this.\u0012 -= 8;
        ++this.\u0010;
      }
    }

    private void \u001D\u0005(int n, int v)
    {
      while (this.\u0012 >= 8)
      {
        int num = this.\u0011 >> 24;
        \u0095\u001F.\u007E\u0090\u009D((object) this.\u0001, (byte) num);
        this.\u0011 <<= 8;
        this.\u0012 -= 8;
        ++this.\u0010;
      }
      this.\u0011 |= v << 32 - this.\u0012 - n;
      this.\u0012 += n;
    }

    private void \u001D\u0005(int c)
    {
      this.\u001D\u0005(8, c);
    }

    private void \u001E\u0005(int u)
    {
      this.\u001D\u0005(8, u >> 24 & (int) byte.MaxValue);
      this.\u001D\u0005(8, u >> 16 & (int) byte.MaxValue);
      this.\u001D\u0005(8, u >> 8 & (int) byte.MaxValue);
      this.\u001D\u0005(8, u & (int) byte.MaxValue);
    }

    private void \u001E\u0005(int numBits, int c)
    {
      this.\u001D\u0005(numBits, c);
    }

    private void \u0083\u0005()
    {
      char[][] chArray1 = new char[\u0015.\u0006][];
      for (int index = 0; index < \u0015.\u0006; ++index)
        chArray1[index] = new char[\u0015.\u0002];
      int v1 = 0;
      int alphaSize = this.\u0013 + 2;
      for (int index1 = 0; index1 < \u0015.\u0006; ++index1)
      {
        for (int index2 = 0; index2 < alphaSize; ++index2)
          chArray1[index1][index2] = '\x000F';
      }
      if (this.\u0014 <= 0)
        \u0014.\u008B\u0005();
      int v2 = this.\u0014 >= 200 ? (this.\u0014 >= 600 ? (this.\u0014 >= 1200 ? (this.\u0014 >= 2400 ? 6 : 5) : 4) : 3) : 2;
      int num1 = v2;
      int num2 = this.\u0014;
      int num3 = 0;
      while (num1 > 0)
      {
        int num4 = num2 / num1;
        int num5 = 0;
        int index1 = num3 - 1;
        while (num5 < num4 && index1 < alphaSize - 1)
        {
          ++index1;
          num5 += this.\u0005[index1];
        }
        if (index1 > num3 && num1 != v2 && (num1 != 1 && (v2 - num1) % 2 == 1))
        {
          num5 -= this.\u0005[index1];
          --index1;
        }
        for (int index2 = 0; index2 < alphaSize; ++index2)
          chArray1[num1 - 1][index2] = index2 < num3 || index2 > index1 ? '\x000F' : char.MinValue;
        --num1;
        num3 = index1 + 1;
        num2 -= num5;
      }
      int[][] numArray1 = new int[\u0015.\u0006][];
      for (int index = 0; index < \u0015.\u0006; ++index)
        numArray1[index] = new int[\u0015.\u0002];
      int[] numArray2 = new int[\u0015.\u0006];
      short[] numArray3 = new short[\u0015.\u0006];
      for (int index1 = 0; index1 < \u0015.\u0008; ++index1)
      {
        for (int index2 = 0; index2 < v2; ++index2)
          numArray2[index2] = 0;
        for (int index2 = 0; index2 < v2; ++index2)
        {
          for (int index3 = 0; index3 < alphaSize; ++index3)
            numArray1[index2][index3] = 0;
        }
        v1 = 0;
        int num4 = 0;
        int num5;
        for (int index2 = 0; index2 < this.\u0014; index2 = num5 + 1)
        {
          num5 = index2 + \u0015.\u0007 - 1;
          if (num5 >= this.\u0014)
            num5 = this.\u0014 - 1;
          for (int index3 = 0; index3 < v2; ++index3)
            numArray3[index3] = (short) 0;
          if (v2 == 6)
          {
            int num6;
            short num7 = (short) (num6 = 0);
            short num8 = (short) num6;
            short num9 = (short) num6;
            short num10 = (short) num6;
            short num11 = (short) num6;
            short num12 = (short) num6;
            for (int index3 = index2; index3 <= num5; ++index3)
            {
              short num13 = this.\u0001[index3];
              num12 += (short) chArray1[0][(int) num13];
              num11 += (short) chArray1[1][(int) num13];
              num10 += (short) chArray1[2][(int) num13];
              num9 += (short) chArray1[3][(int) num13];
              num8 += (short) chArray1[4][(int) num13];
              num7 += (short) chArray1[5][(int) num13];
            }
            numArray3[0] = num12;
            numArray3[1] = num11;
            numArray3[2] = num10;
            numArray3[3] = num9;
            numArray3[4] = num8;
            numArray3[5] = num7;
          }
          else
          {
            for (int index3 = index2; index3 <= num5; ++index3)
            {
              short num6 = this.\u0001[index3];
              for (int index4 = 0; index4 < v2; ++index4)
                numArray3[index4] += (short) chArray1[index4][(int) num6];
            }
          }
          int num14 = 999999999;
          int index5 = -1;
          for (int index3 = 0; index3 < v2; ++index3)
          {
            if ((int) numArray3[index3] < num14)
            {
              num14 = (int) numArray3[index3];
              index5 = index3;
            }
          }
          num4 += num14;
          ++numArray2[index5];
          this.\u0003[v1] = (char) index5;
          ++v1;
          for (int index3 = index2; index3 <= num5; ++index3)
            ++numArray1[index5][(int) this.\u0001[index3]];
        }
        for (int index2 = 0; index2 < v2; ++index2)
          \u0014.\u001D\u0005(chArray1[index2], numArray1[index2], alphaSize, 20);
      }
      if (v2 >= 8)
        \u0014.\u008B\u0005();
      if (v1 >= 32768 || v1 > 2 + 900000 / \u0015.\u0007)
        \u0014.\u008B\u0005();
      char[] chArray2 = new char[\u0015.\u0006];
      for (int index = 0; index < v2; ++index)
        chArray2[index] = (char) index;
      for (int index1 = 0; index1 < v1; ++index1)
      {
        char ch1 = this.\u0003[index1];
        int index2 = 0;
        char ch2 = chArray2[index2];
        while ((int) ch1 != (int) ch2)
        {
          ++index2;
          char ch3 = ch2;
          ch2 = chArray2[index2];
          chArray2[index2] = ch3;
        }
        chArray2[0] = ch2;
        this.\u0004[index1] = (char) index2;
      }
      int[][] numArray4 = new int[\u0015.\u0006][];
      for (int index = 0; index < \u0015.\u0006; ++index)
        numArray4[index] = new int[\u0015.\u0002];
      for (int index1 = 0; index1 < v2; ++index1)
      {
        int minLen = 32;
        int maxLen = 0;
        for (int index2 = 0; index2 < alphaSize; ++index2)
        {
          if ((int) chArray1[index1][index2] > maxLen)
            maxLen = (int) chArray1[index1][index2];
          if ((int) chArray1[index1][index2] < minLen)
            minLen = (int) chArray1[index1][index2];
        }
        if (maxLen > 20)
          \u0014.\u008B\u0005();
        if (minLen < 1)
          \u0014.\u008B\u0005();
        \u0014.\u001D\u0005(numArray4[index1], chArray1[index1], minLen, maxLen, alphaSize);
      }
      bool[] flagArray = new bool[16];
      for (int index1 = 0; index1 < 16; ++index1)
      {
        flagArray[index1] = false;
        for (int index2 = 0; index2 < 16; ++index2)
        {
          if (this.\u0001[index1 * 16 + index2])
            flagArray[index1] = true;
        }
      }
      for (int index = 0; index < 16; ++index)
      {
        if (flagArray[index])
          this.\u001D\u0005(1, 1);
        else
          this.\u001D\u0005(1, 0);
      }
      for (int index1 = 0; index1 < 16; ++index1)
      {
        if (flagArray[index1])
        {
          for (int index2 = 0; index2 < 16; ++index2)
          {
            if (this.\u0001[index1 * 16 + index2])
              this.\u001D\u0005(1, 1);
            else
              this.\u001D\u0005(1, 0);
          }
        }
      }
      this.\u001D\u0005(3, v2);
      this.\u001D\u0005(15, v1);
      for (int index1 = 0; index1 < v1; ++index1)
      {
        for (int index2 = 0; index2 < (int) this.\u0004[index1]; ++index2)
          this.\u001D\u0005(1, 1);
        this.\u001D\u0005(1, 0);
      }
      for (int index1 = 0; index1 < v2; ++index1)
      {
        int v3 = (int) chArray1[index1][0];
        this.\u001D\u0005(5, v3);
        for (int index2 = 0; index2 < alphaSize; ++index2)
        {
          for (; v3 < (int) chArray1[index1][index2]; ++v3)
            this.\u001D\u0005(2, 2);
          for (; v3 > (int) chArray1[index1][index2]; --v3)
            this.\u001D\u0005(2, 3);
          this.\u001D\u0005(1, 0);
        }
      }
      int index6 = 0;
      int num15 = 0;
      while (num15 < this.\u0014)
      {
        int num4 = num15 + \u0015.\u0007 - 1;
        if (num4 >= this.\u0014)
          num4 = this.\u0014 - 1;
        for (int index1 = num15; index1 <= num4; ++index1)
          this.\u001D\u0005((int) chArray1[(int) this.\u0003[index6]][(int) this.\u0001[index1]], numArray4[(int) this.\u0003[index6]][(int) this.\u0001[index1]]);
        num15 = num4 + 1;
        ++index6;
      }
      if (index6 == v1)
        return;
      \u0014.\u008B\u0005();
    }

    private void \u0084\u0005()
    {
      this.\u001E\u0005(24, this.\u000E);
      this.\u008A\u0005();
      this.\u0083\u0005();
    }

    private void \u001D\u0005(int lo, int hi, int d)
    {
      int num1 = hi - lo + 1;
      if (num1 < 2)
        return;
      int index1 = 0;
      while (this.\u0001[index1] < num1)
        ++index1;
      for (int index2 = index1 - 1; index2 >= 0; --index2)
      {
        int num2 = this.\u0001[index2];
        int index3 = lo + num2;
        while (index3 <= hi)
        {
          int num3 = this.\u0003[index3];
          int index4 = index3;
          while (this.\u001D\u0005(this.\u0003[index4 - num2] + d, num3 + d))
          {
            this.\u0003[index4] = this.\u0003[index4 - num2];
            index4 -= num2;
            if (index4 <= lo + num2 - 1)
              break;
          }
          this.\u0003[index4] = num3;
          int index5 = index3 + 1;
          if (index5 <= hi)
          {
            int num4 = this.\u0003[index5];
            int index6 = index5;
            while (this.\u001D\u0005(this.\u0003[index6 - num2] + d, num4 + d))
            {
              this.\u0003[index6] = this.\u0003[index6 - num2];
              index6 -= num2;
              if (index6 <= lo + num2 - 1)
                break;
            }
            this.\u0003[index6] = num4;
            int index7 = index5 + 1;
            if (index7 <= hi)
            {
              int num5 = this.\u0003[index7];
              int index8 = index7;
              while (this.\u001D\u0005(this.\u0003[index8 - num2] + d, num5 + d))
              {
                this.\u0003[index8] = this.\u0003[index8 - num2];
                index8 -= num2;
                if (index8 <= lo + num2 - 1)
                  break;
              }
              this.\u0003[index8] = num5;
              index3 = index7 + 1;
              if (this.\u0016 > this.\u0017 && this.\u0003)
                return;
            }
            else
              break;
          }
          else
            break;
        }
      }
    }

    private void \u001E\u0005(int p1, int p2, int n)
    {
      for (; n > 0; --n)
      {
        int num = this.\u0003[p1];
        this.\u0003[p1] = this.\u0003[p2];
        this.\u0003[p2] = num;
        ++p1;
        ++p2;
      }
    }

    private void \u001F\u0005(int loSt, int hiSt, int dSt)
    {
      \u0014.\u0001[] objArray = new \u0014.\u0001[1000];
      int index1 = 0;
      objArray[index1].\u0001 = loSt;
      objArray[index1].\u0002 = hiSt;
      objArray[index1].\u0003 = dSt;
      int index2 = index1 + 1;
      while (index2 > 0)
      {
        if (index2 >= 1000)
          \u0014.\u008B\u0005();
        --index2;
        int index3 = objArray[index2].\u0001;
        int hi = objArray[index2].\u0002;
        int d = objArray[index2].\u0003;
        if (hi - index3 < 20 || d > 10)
        {
          this.\u001D\u0005(index3, hi, d);
          if (this.\u0016 > this.\u0017 && this.\u0003)
            break;
        }
        else
        {
          int num1 = (int) \u0014.\u001D\u0005(this.\u0001[this.\u0003[index3] + d + 1], this.\u0001[this.\u0003[hi] + d + 1], this.\u0001[this.\u0003[index3 + hi >> 1] + d + 1]);
          int index4;
          int p1 = index4 = index3;
          int index5;
          int index6 = index5 = hi;
          while (true)
          {
            while (p1 <= index6)
            {
              int num2 = (int) this.\u0001[this.\u0003[p1] + d + 1] - num1;
              if (num2 == 0)
              {
                int num3 = this.\u0003[p1];
                this.\u0003[p1] = this.\u0003[index4];
                this.\u0003[index4] = num3;
                ++index4;
                ++p1;
              }
              else if (num2 <= 0)
                ++p1;
              else
                break;
            }
            while (p1 <= index6)
            {
              int num2 = (int) this.\u0001[this.\u0003[index6] + d + 1] - num1;
              if (num2 == 0)
              {
                int num3 = this.\u0003[index6];
                this.\u0003[index6] = this.\u0003[index5];
                this.\u0003[index5] = num3;
                --index5;
                --index6;
              }
              else if (num2 >= 0)
                --index6;
              else
                break;
            }
            if (p1 <= index6)
            {
              int num2 = this.\u0003[p1];
              this.\u0003[p1] = this.\u0003[index6];
              this.\u0003[index6] = num2;
              ++p1;
              --index6;
            }
            else
              break;
          }
          if (index5 < index4)
          {
            objArray[index2].\u0001 = index3;
            objArray[index2].\u0002 = hi;
            objArray[index2].\u0003 = d + 1;
            ++index2;
          }
          else
          {
            int n1 = index4 - index3 < p1 - index4 ? index4 - index3 : p1 - index4;
            this.\u001E\u0005(index3, p1 - n1, n1);
            int n2 = hi - index5 < index5 - index6 ? hi - index5 : index5 - index6;
            this.\u001E\u0005(p1, hi - n2 + 1, n2);
            int num2 = index3 + p1 - index4 - 1;
            int num3 = hi - (index5 - index6) + 1;
            objArray[index2].\u0001 = index3;
            objArray[index2].\u0002 = num2;
            objArray[index2].\u0003 = d;
            int index7 = index2 + 1;
            objArray[index7].\u0001 = num2 + 1;
            objArray[index7].\u0002 = num3 - 1;
            objArray[index7].\u0003 = d + 1;
            int index8 = index7 + 1;
            objArray[index8].\u0001 = num3;
            objArray[index8].\u0002 = hi;
            objArray[index8].\u0003 = d;
            index2 = index8 + 1;
          }
        }
      }
    }

    private void \u0086\u0005()
    {
      int[] numArray1 = new int[256];
      int[] numArray2 = new int[256];
      bool[] flagArray = new bool[256];
      for (int index = 0; index < \u0015.\u000F; ++index)
        this.\u0001[this.\u0008 + index + 2] = this.\u0001[index % (this.\u0008 + 1) + 1];
      for (int index = 0; index <= this.\u0008 + \u0015.\u000F; ++index)
        this.\u0002[index] = 0;
      this.\u0001[0] = this.\u0001[this.\u0008 + 1];
      if (this.\u0008 < 4000)
      {
        for (int index = 0; index <= this.\u0008; ++index)
          this.\u0003[index] = index;
        this.\u0003 = false;
        this.\u0016 = this.\u0017 = 0;
        this.\u001D\u0005(0, this.\u0008, 0);
      }
      else
      {
        int num1 = 0;
        for (int index = 0; index <= (int) byte.MaxValue; ++index)
          flagArray[index] = false;
        for (int index = 0; index <= 65536; ++index)
          this.\u0004[index] = 0;
        int num2 = (int) this.\u0001[0];
        for (int index = 0; index <= this.\u0008; ++index)
        {
          int num3 = (int) this.\u0001[index + 1];
          ++this.\u0004[(num2 << 8) + num3];
          num2 = num3;
        }
        for (int index = 1; index <= 65536; ++index)
          this.\u0004[index] += this.\u0004[index - 1];
        int num4 = (int) this.\u0001[1];
        for (int index1 = 0; index1 < this.\u0008; ++index1)
        {
          int num3 = (int) this.\u0001[index1 + 2];
          int index2 = (num4 << 8) + num3;
          num4 = num3;
          --this.\u0004[index2];
          this.\u0003[this.\u0004[index2]] = index1;
        }
        int index3 = ((int) this.\u0001[this.\u0008 + 1] << 8) + (int) this.\u0001[1];
        --this.\u0004[index3];
        this.\u0003[this.\u0004[index3]] = this.\u0008;
        for (int index1 = 0; index1 <= (int) byte.MaxValue; ++index1)
          numArray1[index1] = index1;
        int num5 = 1;
        do
        {
          num5 = 3 * num5 + 1;
        }
        while (num5 <= 256);
        do
        {
          num5 /= 3;
          for (int index1 = num5; index1 <= (int) byte.MaxValue; ++index1)
          {
            int num3 = numArray1[index1];
            int index2 = index1;
            while (this.\u0004[numArray1[index2 - num5] + 1 << 8] - this.\u0004[numArray1[index2 - num5] << 8] > this.\u0004[num3 + 1 << 8] - this.\u0004[num3 << 8])
            {
              numArray1[index2] = numArray1[index2 - num5];
              index2 -= num5;
              if (index2 <= num5 - 1)
                break;
            }
            numArray1[index2] = num3;
          }
        }
        while (num5 != 1);
        for (int index1 = 0; index1 <= (int) byte.MaxValue; ++index1)
        {
          int index2 = numArray1[index1];
          for (int index4 = 0; index4 <= (int) byte.MaxValue; ++index4)
          {
            int index5 = (index2 << 8) + index4;
            if ((this.\u0004[index5] & 2097152) != 2097152)
            {
              int loSt = this.\u0004[index5] & -2097153;
              int hiSt = (this.\u0004[index5 + 1] & -2097153) - 1;
              if (hiSt > loSt)
              {
                this.\u001F\u0005(loSt, hiSt, 2);
                num1 += hiSt - loSt + 1;
                if (this.\u0016 > this.\u0017 && this.\u0003)
                  return;
              }
              this.\u0004[index5] |= 2097152;
            }
          }
          flagArray[index2] = true;
          if (index1 < (int) byte.MaxValue)
          {
            int num3 = this.\u0004[index2 << 8] & -2097153;
            int num6 = (this.\u0004[index2 + 1 << 8] & -2097153) - num3;
            int num7 = 0;
            while (num6 >> num7 > 65534)
              ++num7;
            for (int index4 = 0; index4 < num6; ++index4)
            {
              int index5 = this.\u0003[num3 + index4];
              int num8 = index4 >> num7;
              this.\u0002[index5] = num8;
              if (index5 < \u0015.\u000F)
                this.\u0002[index5 + this.\u0008 + 1] = num8;
            }
            if (num6 - 1 >> num7 > (int) ushort.MaxValue)
              \u0014.\u008B\u0005();
          }
          for (int index4 = 0; index4 <= (int) byte.MaxValue; ++index4)
            numArray2[index4] = this.\u0004[(index4 << 8) + index2] & -2097153;
          for (int index4 = this.\u0004[index2 << 8] & -2097153; index4 < (this.\u0004[index2 + 1 << 8] & -2097153); ++index4)
          {
            int index5 = (int) this.\u0001[this.\u0003[index4]];
            if (!flagArray[index5])
            {
              this.\u0003[numArray2[index5]] = this.\u0003[index4] == 0 ? this.\u0008 : this.\u0003[index4] - 1;
              ++numArray2[index5];
            }
          }
          for (int index4 = 0; index4 <= (int) byte.MaxValue; ++index4)
            this.\u0004[(index4 << 8) + index2] |= 2097152;
        }
      }
    }

    private void \u0087\u0005()
    {
      int num = 0;
      int index1 = 0;
      for (int index2 = 0; index2 < 256; ++index2)
        this.\u0001[index2] = false;
      for (int index2 = 0; index2 <= this.\u0008; ++index2)
      {
        if (num == 0)
        {
          num = \u0015.\u0001[index1];
          ++index1;
          if (index1 == 512)
            index1 = 0;
        }
        --num;
        this.\u0001[index2 + 1] ^= num == 1 ? (byte) 1 : (byte) 0;
        this.\u0001[index2 + 1] &= byte.MaxValue;
        this.\u0001[(int) this.\u0001[index2 + 1]] = true;
      }
    }

    private void \u0088\u0005()
    {
      this.\u0017 = this.\u0015 * this.\u0008;
      this.\u0016 = 0;
      this.\u0002 = false;
      this.\u0003 = true;
      this.\u0086\u0005();
      if (this.\u0016 > this.\u0017 && this.\u0003)
      {
        this.\u0087\u0005();
        this.\u0017 = this.\u0016 = 0;
        this.\u0002 = true;
        this.\u0003 = false;
        this.\u0086\u0005();
      }
      this.\u000E = -1;
      for (int index = 0; index <= this.\u0008; ++index)
      {
        if (this.\u0003[index] == 0)
        {
          this.\u000E = index;
          break;
        }
      }
      if (this.\u000E != -1)
        return;
      \u0014.\u008B\u0005();
    }

    private bool \u001D\u0005(int i1, int i2)
    {
      byte num1 = this.\u0001[i1 + 1];
      byte num2 = this.\u0001[i2 + 1];
      if ((int) num1 != (int) num2)
        return (int) num1 > (int) num2;
      ++i1;
      ++i2;
      byte num3 = this.\u0001[i1 + 1];
      byte num4 = this.\u0001[i2 + 1];
      if ((int) num3 != (int) num4)
        return (int) num3 > (int) num4;
      ++i1;
      ++i2;
      byte num5 = this.\u0001[i1 + 1];
      byte num6 = this.\u0001[i2 + 1];
      if ((int) num5 != (int) num6)
        return (int) num5 > (int) num6;
      ++i1;
      ++i2;
      byte num7 = this.\u0001[i1 + 1];
      byte num8 = this.\u0001[i2 + 1];
      if ((int) num7 != (int) num8)
        return (int) num7 > (int) num8;
      ++i1;
      ++i2;
      byte num9 = this.\u0001[i1 + 1];
      byte num10 = this.\u0001[i2 + 1];
      if ((int) num9 != (int) num10)
        return (int) num9 > (int) num10;
      ++i1;
      ++i2;
      byte num11 = this.\u0001[i1 + 1];
      byte num12 = this.\u0001[i2 + 1];
      if ((int) num11 != (int) num12)
        return (int) num11 > (int) num12;
      ++i1;
      ++i2;
      int num13 = this.\u0008 + 1;
      do
      {
        byte num14 = this.\u0001[i1 + 1];
        byte num15 = this.\u0001[i2 + 1];
        if ((int) num14 != (int) num15)
          return (int) num14 > (int) num15;
        int num16 = this.\u0002[i1];
        int num17 = this.\u0002[i2];
        if (num16 != num17)
          return num16 > num17;
        ++i1;
        ++i2;
        byte num18 = this.\u0001[i1 + 1];
        byte num19 = this.\u0001[i2 + 1];
        if ((int) num18 != (int) num19)
          return (int) num18 > (int) num19;
        int num20 = this.\u0002[i1];
        int num21 = this.\u0002[i2];
        if (num20 != num21)
          return num20 > num21;
        ++i1;
        ++i2;
        byte num22 = this.\u0001[i1 + 1];
        byte num23 = this.\u0001[i2 + 1];
        if ((int) num22 != (int) num23)
          return (int) num22 > (int) num23;
        int num24 = this.\u0002[i1];
        int num25 = this.\u0002[i2];
        if (num24 != num25)
          return num24 > num25;
        ++i1;
        ++i2;
        byte num26 = this.\u0001[i1 + 1];
        byte num27 = this.\u0001[i2 + 1];
        if ((int) num26 != (int) num27)
          return (int) num26 > (int) num27;
        int num28 = this.\u0002[i1];
        int num29 = this.\u0002[i2];
        if (num28 != num29)
          return num28 > num29;
        ++i1;
        ++i2;
        if (i1 > this.\u0008)
        {
          i1 -= this.\u0008;
          --i1;
        }
        if (i2 > this.\u0008)
        {
          i2 -= this.\u0008;
          --i2;
        }
        num13 -= 4;
        ++this.\u0016;
      }
      while (num13 >= 0);
      return false;
    }

    private void \u0089\u0005()
    {
      int length = \u0015.\u0001 * this.\u000F;
      this.\u0001 = new byte[length + 1 + \u0015.\u000F];
      this.\u0002 = new int[length + \u0015.\u000F];
      this.\u0003 = new int[length];
      this.\u0004 = new int[65537];
      if (this.\u0001 != null && this.\u0002 != null && this.\u0003 != null)
      {
        int[] numArray = this.\u0004;
      }
      this.\u0001 = new short[2 * length];
    }

    private void \u008A\u0005()
    {
      char[] chArray = new char[256];
      this.\u001D\u0005();
      int index1 = this.\u0013 + 1;
      for (int index2 = 0; index2 <= index1; int num = index2++)
        this.\u0005[index2] = 0;
      int index3 = 0;
      int num1 = 0;
      for (int index2 = 0; index2 < this.\u0013; ++index2)
        chArray[index2] = (char) index2;
      for (int index2 = 0; index2 <= this.\u0008; ++index2)
      {
        char ch1 = this.\u0002[(int) this.\u0001[this.\u0003[index2]]];
        int index4 = 0;
        char ch2 = chArray[index4];
        while ((int) ch1 != (int) ch2)
        {
          ++index4;
          char ch3 = ch2;
          ch2 = chArray[index4];
          chArray[index4] = ch3;
        }
        chArray[0] = ch2;
        if (index4 == 0)
        {
          ++num1;
        }
        else
        {
          if (num1 > 0)
          {
            int num2 = num1 - 1;
            while (true)
            {
              switch (num2 % 2)
              {
                case 0:
                  this.\u0001[index3] = (short) \u0015.\u0004;
                  ++index3;
                  ++this.\u0005[\u0015.\u0004];
                  break;
                case 1:
                  this.\u0001[index3] = (short) \u0015.\u0005;
                  ++index3;
                  ++this.\u0005[\u0015.\u0005];
                  break;
              }
              if (num2 >= 2)
                num2 = (num2 - 2) / 2;
              else
                break;
            }
            num1 = 0;
          }
          this.\u0001[index3] = (short) (index4 + 1);
          ++index3;
          ++this.\u0005[index4 + 1];
        }
      }
      if (num1 > 0)
      {
        int num2 = num1 - 1;
        while (true)
        {
          switch (num2 % 2)
          {
            case 0:
              this.\u0001[index3] = (short) \u0015.\u0004;
              ++index3;
              ++this.\u0005[\u0015.\u0004];
              break;
            case 1:
              this.\u0001[index3] = (short) \u0015.\u0005;
              ++index3;
              ++this.\u0005[\u0015.\u0005];
              break;
          }
          if (num2 >= 2)
            num2 = (num2 - 2) / 2;
          else
            break;
        }
      }
      this.\u0001[index3] = (short) index1;
      int num3 = index3 + 1;
      ++this.\u0005[index1];
      this.\u0014 = num3;
    }

    private static void \u008B\u0005()
    {
      throw new BZip2Exception(\u0014.\u0001(59816));
    }

    private static void \u001D\u0005(char[] len, int[] freq, int alphaSize, int maxLen)
    {
      int[] numArray1 = new int[\u0015.\u0002 + 2];
      int[] numArray2 = new int[\u0015.\u0002 * 2];
      int[] numArray3 = new int[\u0015.\u0002 * 2];
      for (int index = 0; index < alphaSize; ++index)
        numArray2[index + 1] = (freq[index] == 0 ? 1 : freq[index]) << 8;
label_2:
      int index1 = alphaSize;
      int index2 = 0;
      numArray1[0] = 0;
      numArray2[0] = 0;
      numArray3[0] = -2;
      for (int index3 = 1; index3 <= alphaSize; ++index3)
      {
        numArray3[index3] = -1;
        ++index2;
        numArray1[index2] = index3;
        int index4 = index2;
        int index5 = numArray1[index4];
        while (numArray2[index5] < numArray2[numArray1[index4 >> 1]])
        {
          numArray1[index4] = numArray1[index4 >> 1];
          index4 >>= 1;
        }
        numArray1[index4] = index5;
      }
      if (index2 >= \u0015.\u0002 + 2)
        \u0014.\u008B\u0005();
      while (index2 > 1)
      {
        int index3 = numArray1[1];
        numArray1[1] = numArray1[index2];
        int index4 = index2 - 1;
        int index5 = 1;
        int num1 = 0;
        int index6 = numArray1[index5];
        while (true)
        {
          int index7 = index5 << 1;
          if (index7 <= index4)
          {
            if (index7 < index4 && numArray2[numArray1[index7 + 1]] < numArray2[numArray1[index7]])
              ++index7;
            if (numArray2[index6] >= numArray2[numArray1[index7]])
            {
              numArray1[index5] = numArray1[index7];
              index5 = index7;
            }
            else
              break;
          }
          else
            break;
        }
        numArray1[index5] = index6;
        int index8 = numArray1[1];
        numArray1[1] = numArray1[index4];
        int num2 = index4 - 1;
        int index9 = 1;
        num1 = 0;
        int index10 = numArray1[index9];
        while (true)
        {
          int index7 = index9 << 1;
          if (index7 <= num2)
          {
            if (index7 < num2 && numArray2[numArray1[index7 + 1]] < numArray2[numArray1[index7]])
              ++index7;
            if (numArray2[index10] >= numArray2[numArray1[index7]])
            {
              numArray1[index9] = numArray1[index7];
              index9 = index7;
            }
            else
              break;
          }
          else
            break;
        }
        numArray1[index9] = index10;
        ++index1;
        numArray3[index3] = numArray3[index8] = index1;
        numArray2[index1] = (int) (((long) numArray2[index3] & 4294967040L) + ((long) numArray2[index8] & 4294967040L)) | 1 + ((numArray2[index3] & (int) byte.MaxValue) > (numArray2[index8] & (int) byte.MaxValue) ? numArray2[index3] & (int) byte.MaxValue : numArray2[index8] & (int) byte.MaxValue);
        numArray3[index1] = -1;
        index2 = num2 + 1;
        numArray1[index2] = index1;
        int index11 = index2;
        int index12 = numArray1[index11];
        while (numArray2[index12] < numArray2[numArray1[index11 >> 1]])
        {
          numArray1[index11] = numArray1[index11 >> 1];
          index11 >>= 1;
        }
        numArray1[index11] = index12;
      }
      if (index1 >= \u0015.\u0002 * 2)
        \u0014.\u008B\u0005();
      bool flag = false;
      for (int index3 = 1; index3 <= alphaSize; ++index3)
      {
        int num = 0;
        int index4 = index3;
        while (numArray3[index4] >= 0)
        {
          index4 = numArray3[index4];
          ++num;
        }
        len[index3 - 1] = (char) num;
        if (num > maxLen)
          flag = true;
      }
      if (!flag)
        return;
      for (int index3 = 1; index3 < alphaSize; ++index3)
      {
        int num = 1 + (numArray2[index3] >> 8) / 2;
        numArray2[index3] = num << 8;
      }
      goto label_2;
    }

    private static void \u001D\u0005(int[] code, char[] length, int minLen, int maxLen, int alphaSize)
    {
      int num = 0;
      for (int index1 = minLen; index1 <= maxLen; ++index1)
      {
        for (int index2 = 0; index2 < alphaSize; ++index2)
        {
          if ((int) length[index2] != index1)
            continue;
          code[index2] = num;
          ++num;
        }
        num <<= 1;
      }
    }

    private static byte \u001D\u0005(byte a, byte b, byte c)
    {
      if ((int) a > (int) b)
      {
        byte num = a;
        a = b;
        b = num;
      }
      if ((int) b > (int) c)
        goto label_6;
label_1:
      if ((int) a > (int) b)
        b = a;
      return b;
label_6:
      byte num1 = b;
      b = c;
      c = num1;
      goto label_1;
    }

    private struct \u0001
    {
      public int \u0001;
      public int \u0002;
      public int \u0003;
    }
  }
}
