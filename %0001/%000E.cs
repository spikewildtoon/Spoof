// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace \u0001
{
  internal sealed class \u000E
  {
    public static byte[] \u001D\u0005([In] byte[] obj0)
    {
      Assembly callingAssembly = Assembly.GetCallingAssembly();
      if (callingAssembly != Assembly.GetExecutingAssembly())
      {
        byte[] numArray = new byte[160]
        {
          (byte) 0,
          (byte) 36,
          (byte) 0,
          (byte) 0,
          (byte) 4,
          (byte) 128,
          (byte) 0,
          (byte) 0,
          (byte) 148,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 6,
          (byte) 2,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 36,
          (byte) 0,
          (byte) 0,
          (byte) 82,
          (byte) 83,
          (byte) 65,
          (byte) 49,
          (byte) 0,
          (byte) 4,
          (byte) 0,
          (byte) 0,
          (byte) 1,
          (byte) 0,
          (byte) 1,
          (byte) 0,
          (byte) 129,
          (byte) 216,
          (byte) 197,
          (byte) 192,
          (byte) 165,
          (byte) 98,
          (byte) 40,
          (byte) 194,
          (byte) 113,
          (byte) 31,
          (byte) 242,
          (byte) 73,
          (byte) 172,
          (byte) 217,
          (byte) 46,
          (byte) 43,
          (byte) 188,
          (byte) 40,
          (byte) 117,
          (byte) 218,
          (byte) 218,
          (byte) 5,
          (byte) 206,
          (byte) 122,
          (byte) 32,
          (byte) 127,
          (byte) 177,
          (byte) 200,
          (byte) 166,
          (byte) 240,
          (byte) 27,
          (byte) 206,
          (byte) 144,
          (byte) 253,
          (byte) 0,
          (byte) 189,
          (byte) 93,
          (byte) 129,
          (byte) 177,
          (byte) 25,
          (byte) 223,
          (byte) 229,
          (byte) 21,
          (byte) 192,
          (byte) 175,
          (byte) 63,
          (byte) 200,
          (byte) 26,
          (byte) 76,
          (byte) 152,
          (byte) 19,
          (byte) 35,
          (byte) 184,
          (byte) 248,
          (byte) 168,
          (byte) 155,
          (byte) 203,
          (byte) 239,
          (byte) 248,
          (byte) 161,
          (byte) 92,
          (byte) 125,
          (byte) 248,
          (byte) 29,
          (byte) 233,
          (byte) 31,
          (byte) 5,
          (byte) 150,
          (byte) 127,
          (byte) 24,
          (byte) 189,
          (byte) 168,
          (byte) 135,
          (byte) 89,
          (byte) 217,
          (byte) 184,
          (byte) 138,
          (byte) 170,
          (byte) 78,
          (byte) 233,
          (byte) 99,
          (byte) 230,
          (byte) 196,
          (byte) 222,
          (byte) 74,
          (byte) 79,
          (byte) 203,
          (byte) 229,
          (byte) 97,
          (byte) 109,
          (byte) 51,
          (byte) 11,
          (byte) 108,
          (byte) 118,
          (byte) 160,
          (byte) 27,
          (byte) 124,
          (byte) 115,
          (byte) 38,
          (byte) 224,
          (byte) 24,
          (byte) 220,
          (byte) 195,
          (byte) 77,
          (byte) 78,
          (byte) 222,
          (byte) 114,
          (byte) 237,
          (byte) 155,
          (byte) 226,
          (byte) 191,
          (byte) 165,
          (byte) 51,
          (byte) 5,
          (byte) 169,
          (byte) 17,
          (byte) 0,
          (byte) 228,
          (byte) 126,
          (byte) 151,
          (byte) 193,
          (byte) 81,
          (byte) 70,
          (byte) 22,
          (byte) 164,
          (byte) 105,
          (byte) 128,
          (byte) 165
        };
        byte[] publicKey = callingAssembly.GetName().GetPublicKey();
        if (publicKey == null)
          return (byte[]) null;
        if (publicKey.Length != 160)
          return (byte[]) null;
        for (int index = 0; index < 160; ++index)
        {
          if ((int) publicKey[index] != (int) numArray[index])
            return (byte[]) null;
        }
      }
      \u000E.\u0007 obj1 = new \u000E.\u0007(obj0);
      byte[] numArray1 = new byte[0];
      int num1 = obj1.\u001E\u0005();
      if (num1 == 67324752)
      {
        short num2 = (short) obj1.\u001D\u0005();
        int num3 = obj1.\u001D\u0005();
        int num4 = obj1.\u001D\u0005();
        if (num1 != 67324752 || (int) num2 != 20 || (num3 != 0 || num4 != 8))
          throw new FormatException("Wrong Header Signature");
        obj1.\u001E\u0005();
        obj1.\u001E\u0005();
        obj1.\u001E\u0005();
        int num5 = obj1.\u001E\u0005();
        int count1 = obj1.\u001D\u0005();
        int count2 = obj1.\u001D\u0005();
        if (count1 > 0)
        {
          byte[] buffer = new byte[(int) checked ((uint) count1)];
          obj1.Read(buffer, 0, count1);
        }
        if (count2 > 0)
        {
          byte[] buffer = new byte[(int) checked ((uint) count2)];
          obj1.Read(buffer, 0, count2);
        }
        byte[] buffer1 = new byte[(int) checked ((uint) unchecked (obj1.Length - obj1.Position))];
        obj1.Read(buffer1, 0, buffer1.Length);
        \u000E.\u0001 obj2 = new \u000E.\u0001(buffer1);
        numArray1 = new byte[(int) checked ((uint) num5)];
        obj2.\u001D\u0005(numArray1, 0, numArray1.Length);
      }
      else
      {
        int num2 = num1 >> 24;
        if (num1 - (num2 << 24) != 8223355)
          throw new FormatException("Unknown Header");
        if (num2 == 1)
        {
          int num3 = obj1.\u001E\u0005();
          numArray1 = new byte[(int) checked ((uint) num3)];
          int num4 = 0;
          while (num4 < num3)
          {
            int num5 = obj1.\u001E\u0005();
            int num6 = obj1.\u001E\u0005();
            byte[] buffer = new byte[(int) checked ((uint) num5)];
            obj1.Read(buffer, 0, buffer.Length);
            new \u000E.\u0001(buffer).\u001D\u0005(numArray1, num4, num6);
            num4 += num6;
          }
        }
        if (num2 == 2)
        {
          DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
          cryptoServiceProvider.Key = new byte[8]
          {
            (byte) 248,
            (byte) 67,
            (byte) 52,
            byte.MaxValue,
            (byte) 86,
            (byte) 31,
            (byte) 177,
            (byte) 110
          };
          cryptoServiceProvider.IV = new byte[8]
          {
            (byte) 248,
            (byte) 27,
            (byte) 11,
            (byte) 69,
            (byte) 66,
            (byte) 182,
            (byte) 32,
            (byte) 56
          };
          byte[] numArray2 = cryptoServiceProvider.CreateDecryptor().TransformFinalBlock(obj0, 4, obj0.Length - 4);
          cryptoServiceProvider.Clear();
          numArray1 = \u000E.\u001D\u0005(numArray2);
        }
      }
      obj1.Close();
      return numArray1;
    }

    internal sealed class \u0001
    {
      private static int[] \u0001 = new int[29]
      {
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        13,
        15,
        17,
        19,
        23,
        27,
        31,
        35,
        43,
        51,
        59,
        67,
        83,
        99,
        115,
        131,
        163,
        195,
        227,
        258
      };
      private static int[] \u0002 = new int[29]
      {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        1,
        1,
        1,
        1,
        2,
        2,
        2,
        2,
        3,
        3,
        3,
        3,
        4,
        4,
        4,
        4,
        5,
        5,
        5,
        5,
        0
      };
      private static int[] \u0003 = new int[30]
      {
        1,
        2,
        3,
        4,
        5,
        7,
        9,
        13,
        17,
        25,
        33,
        49,
        65,
        97,
        129,
        193,
        257,
        385,
        513,
        769,
        1025,
        1537,
        2049,
        3073,
        4097,
        6145,
        8193,
        12289,
        16385,
        24577
      };
      private static int[] \u0004 = new int[30]
      {
        0,
        0,
        0,
        0,
        1,
        1,
        2,
        2,
        3,
        3,
        4,
        4,
        5,
        5,
        6,
        6,
        7,
        7,
        8,
        8,
        9,
        9,
        10,
        10,
        11,
        11,
        12,
        12,
        13,
        13
      };
      private int \u0001;
      private int \u0002;
      private int \u0003;
      private int \u0004;
      private int \u0005;
      private bool \u0001;
      private \u000E.\u0002 \u0001;
      private \u000E.\u0003 \u0001;
      private \u000E.\u0005 \u0001;
      private \u000E.\u0004 \u0001;
      private \u000E.\u0004 \u0002;

      public \u0001([In] byte[] obj0)
      {
        this.\u0001 = new \u000E.\u0002();
        this.\u0001 = new \u000E.\u0003();
        this.\u0001 = 2;
        this.\u0001.\u001D\u0005(obj0, 0, obj0.Length);
      }

      private bool \u001D\u0005()
      {
        int num1 = this.\u0001.\u001D\u0005();
        while (num1 >= 258)
        {
          switch (this.\u0001)
          {
            case 7:
              int num2;
              while (((num2 = this.\u0001.\u001D\u0005(this.\u0001)) & -256) == 0)
              {
                this.\u0001.\u001D\u0005(num2);
                if (--num1 < 258)
                  return true;
              }
              if (num2 < 257)
              {
                if (num2 < 0)
                  return false;
                this.\u0002 = (\u000E.\u0004) null;
                this.\u0001 = (\u000E.\u0004) null;
                this.\u0001 = 2;
                return true;
              }
              this.\u0003 = \u000E.\u0001.\u0001[num2 - 257];
              this.\u0002 = \u000E.\u0001.\u0002[num2 - 257];
              goto case 8;
            case 8:
              if (this.\u0002 > 0)
              {
                this.\u0001 = 8;
                int num3 = this.\u0001.\u001D\u0005(this.\u0002);
                if (num3 < 0)
                  return false;
                this.\u0001.\u001D\u0005(this.\u0002);
                this.\u0003 += num3;
              }
              this.\u0001 = 9;
              goto case 9;
            case 9:
              int index = this.\u0002.\u001D\u0005(this.\u0001);
              if (index < 0)
                return false;
              this.\u0004 = \u000E.\u0001.\u0003[index];
              this.\u0002 = \u000E.\u0001.\u0004[index];
              goto case 10;
            case 10:
              if (this.\u0002 > 0)
              {
                this.\u0001 = 10;
                int num3 = this.\u0001.\u001D\u0005(this.\u0002);
                if (num3 < 0)
                  return false;
                this.\u0001.\u001D\u0005(this.\u0002);
                this.\u0004 += num3;
              }
              this.\u0001.\u001D\u0005(this.\u0003, this.\u0004);
              num1 -= this.\u0003;
              this.\u0001 = 7;
              continue;
            default:
              continue;
          }
        }
        return true;
      }

      private bool \u001E\u0005()
      {
        switch (this.\u0001)
        {
          case 2:
            if (this.\u0001)
            {
              this.\u0001 = 12;
              return false;
            }
            int num = this.\u0001.\u001D\u0005(3);
            if (num < 0)
              return false;
            this.\u0001.\u001D\u0005(3);
            if ((num & 1) != 0)
              this.\u0001 = true;
            switch (num >> 1)
            {
              case 0:
                this.\u0001.\u001D\u0005();
                this.\u0001 = 3;
                break;
              case 1:
                this.\u0001 = \u000E.\u0004.\u0001;
                this.\u0002 = \u000E.\u0004.\u0002;
                this.\u0001 = 7;
                break;
              case 2:
                this.\u0001 = new \u000E.\u0005();
                this.\u0001 = 6;
                break;
            }
            return true;
          case 3:
            if ((this.\u0005 = this.\u0001.\u001D\u0005(16)) < 0)
              return false;
            this.\u0001.\u001D\u0005(16);
            this.\u0001 = 4;
            goto case 4;
          case 4:
            if (this.\u0001.\u001D\u0005(16) < 0)
              return false;
            this.\u0001.\u001D\u0005(16);
            this.\u0001 = 5;
            goto case 5;
          case 5:
            this.\u0005 -= this.\u0001.\u001D\u0005(this.\u0001, this.\u0005);
            if (this.\u0005 != 0)
              return !this.\u0001.\u001D\u0005();
            this.\u0001 = 2;
            return true;
          case 6:
            if (!this.\u0001.\u001D\u0005(this.\u0001))
              return false;
            this.\u0001 = this.\u0001.\u001D\u0005();
            this.\u0002 = this.\u0001.\u001E\u0005();
            this.\u0001 = 7;
            goto case 7;
          case 7:
          case 8:
          case 9:
          case 10:
            return this.\u001D\u0005();
          case 12:
            return false;
          default:
            return false;
        }
      }

      public int \u001D\u0005([In] byte[] obj0, [In] int obj1, [In] int obj2)
      {
        int num1 = 0;
        do
        {
          if (this.\u0001 != 11)
            goto label_5;
label_2:
          continue;
label_5:
          int num2 = this.\u0001.\u001D\u0005(obj0, obj1, obj2);
          obj1 += num2;
          num1 += num2;
          obj2 -= num2;
          if (obj2 != 0)
            goto label_2;
          else
            goto label_1;
        }
        while (this.\u001E\u0005() || this.\u0001.\u001E\u0005() > 0 && this.\u0001 != 11);
        goto label_3;
label_1:
        return num1;
label_3:
        return num1;
      }
    }

    internal sealed class \u0002
    {
      private int \u0001 = 0;
      private int \u0002 = 0;
      private uint \u0001 = 0;
      private int \u0003 = 0;
      private byte[] \u0001;

      public int \u001D\u0005([In] int obj0)
      {
        if (this.\u0003 < obj0)
          goto label_3;
label_2:
        return (int) ((long) this.\u0001 & (long) ((1 << obj0) - 1));
label_3:
        if (this.\u0001 == this.\u0002)
          return -1;
        this.\u0001 |= (uint) (((int) this.\u0001[this.\u0001++] & (int) byte.MaxValue | ((int) this.\u0001[this.\u0001++] & (int) byte.MaxValue) << 8) << this.\u0003);
        this.\u0003 += 16;
        goto label_2;
      }

      public void \u001D\u0005([In] int obj0)
      {
        this.\u0001 >>= obj0;
        this.\u0003 -= obj0;
      }

      [SpecialName]
      public int \u001D\u0005()
      {
        return this.\u0003;
      }

      [SpecialName]
      public int \u001E\u0005()
      {
        return this.\u0002 - this.\u0001 + (this.\u0003 >> 3);
      }

      public void \u001D\u0005()
      {
        this.\u0001 >>= this.\u0003 & 7;
        this.\u0003 &= -8;
      }

      [SpecialName]
      public bool \u001D\u0005()
      {
        return this.\u0001 == this.\u0002;
      }

      public int \u001D\u0005([In] byte[] obj0, [In] int obj1, [In] int obj2)
      {
        int num1 = 0;
        while (this.\u0003 > 0 && obj2 > 0)
        {
          obj0[obj1++] = (byte) this.\u0001;
          this.\u0001 >>= 8;
          this.\u0003 -= 8;
          int num2 = obj2--;
          ++num1;
        }
        if (obj2 == 0)
          return num1;
        int num3 = this.\u0002 - this.\u0001;
        if (obj2 > num3)
          obj2 = num3;
        Array.Copy((Array) this.\u0001, this.\u0001, (Array) obj0, obj1, obj2);
        this.\u0001 += obj2;
        if ((this.\u0001 - this.\u0002 & 1) != 0)
        {
          this.\u0001 = (uint) this.\u0001[this.\u0001++] & (uint) byte.MaxValue;
          this.\u0003 = 8;
        }
        return num1 + obj2;
      }

      public void \u001D\u0005([In] byte[] obj0, [In] int obj1, [In] int obj2)
      {
        if (this.\u0001 < this.\u0002)
          throw new InvalidOperationException();
        int num = obj1 + obj2;
        if (0 > obj1 || (obj1 > num || num > obj0.Length))
          throw new ArgumentOutOfRangeException();
        if ((obj2 & 1) != 0)
        {
          this.\u0001 |= (uint) (((int) obj0[obj1++] & (int) byte.MaxValue) << this.\u0003);
          this.\u0003 += 8;
        }
        this.\u0001 = obj0;
        this.\u0001 = obj1;
        this.\u0002 = num;
      }
    }

    internal sealed class \u0003
    {
      private byte[] \u0001 = new byte[(int) checked ((uint) \u000E.\u0003.\u0001)];
      private int \u0003 = 0;
      private int \u0004 = 0;
      private static int \u0001 = 32768;
      private static int \u0002 = \u000E.\u0003.\u0001 - 1;

      public void \u001D\u0005([In] int obj0)
      {
        if (this.\u0004++ == \u000E.\u0003.\u0001)
          throw new InvalidOperationException();
        this.\u0001[this.\u0003++] = (byte) obj0;
        this.\u0003 &= \u000E.\u0003.\u0002;
      }

      private void \u001D\u0005([In] int obj0, [In] int obj1, [In] int obj2)
      {
        while (obj1-- > 0)
        {
          this.\u0001[this.\u0003++] = this.\u0001[obj0++];
          this.\u0003 &= \u000E.\u0003.\u0002;
          obj0 &= \u000E.\u0003.\u0002;
        }
      }

      public void \u001D\u0005([In] int obj0, [In] int obj1)
      {
        if ((this.\u0004 += obj0) > \u000E.\u0003.\u0001)
          throw new InvalidOperationException();
        int sourceIndex = this.\u0003 - obj1 & \u000E.\u0003.\u0002;
        int num = \u000E.\u0003.\u0001 - obj0;
        if (sourceIndex <= num && this.\u0003 < num)
        {
          if (obj0 <= obj1)
          {
            Array.Copy((Array) this.\u0001, sourceIndex, (Array) this.\u0001, this.\u0003, obj0);
            this.\u0003 += obj0;
          }
          else
          {
            while (obj0-- > 0)
              this.\u0001[this.\u0003++] = this.\u0001[sourceIndex++];
          }
        }
        else
          this.\u001D\u0005(sourceIndex, obj0, obj1);
      }

      public int \u001D\u0005([In] \u000E.\u0002 obj0, [In] int obj1)
      {
        obj1 = Math.Min(Math.Min(obj1, \u000E.\u0003.\u0001 - this.\u0004), obj0.\u001E\u0005());
        int num1 = \u000E.\u0003.\u0001 - this.\u0003;
        int num2;
        if (obj1 > num1)
        {
          num2 = obj0.\u001D\u0005(this.\u0001, this.\u0003, num1);
          if (num2 == num1)
            num2 += obj0.\u001D\u0005(this.\u0001, 0, obj1 - num1);
        }
        else
          num2 = obj0.\u001D\u0005(this.\u0001, this.\u0003, obj1);
        this.\u0003 = this.\u0003 + num2 & \u000E.\u0003.\u0002;
        this.\u0004 += num2;
        return num2;
      }

      public int \u001D\u0005()
      {
        return \u000E.\u0003.\u0001 - this.\u0004;
      }

      public int \u001E\u0005()
      {
        return this.\u0004;
      }

      public int \u001D\u0005([In] byte[] obj0, [In] int obj1, [In] int obj2)
      {
        int num1 = this.\u0003;
        if (obj2 <= this.\u0004)
          goto label_7;
        else
          goto label_6;
label_1:
        int num2 = obj2;
        int length = obj2 - num1;
        if (length > 0)
        {
          Array.Copy((Array) this.\u0001, \u000E.\u0003.\u0001 - length, (Array) obj0, obj1, length);
          obj1 += length;
          obj2 = num1;
        }
        Array.Copy((Array) this.\u0001, num1 - obj2, (Array) obj0, obj1, obj2);
        this.\u0004 -= num2;
        if (this.\u0004 < 0)
          throw new InvalidOperationException();
        return num2;
label_6:
        obj2 = this.\u0004;
        goto label_1;
label_7:
        num1 = this.\u0003 - this.\u0004 + obj2 & \u000E.\u0003.\u0002;
        goto label_1;
      }
    }

    internal sealed class \u0004
    {
      private static int \u0001 = 15;
      private short[] \u0001;
      public static \u000E.\u0004 \u0001;
      public static \u000E.\u0004 \u0002;

      static \u0004()
      {
        byte[] numArray1 = new byte[288];
        int num1 = 0;
        while (num1 < 144)
          numArray1[num1++] = (byte) 8;
        while (num1 < 256)
          numArray1[num1++] = (byte) 9;
        while (num1 < 280)
          numArray1[num1++] = (byte) 7;
        while (num1 < 288)
          numArray1[num1++] = (byte) 8;
        \u000E.\u0004.\u0001 = new \u000E.\u0004(numArray1);
        byte[] numArray2 = new byte[32];
        int num2 = 0;
        while (num2 < 32)
          numArray2[num2++] = (byte) 5;
        \u000E.\u0004.\u0002 = new \u000E.\u0004(numArray2);
      }

      public \u0004([In] byte[] obj0)
      {
        this.\u001D\u0005(obj0);
      }

      private void \u001D\u0005([In] byte[] obj0)
      {
        int[] numArray1 = new int[(int) checked ((uint) unchecked (\u000E.\u0004.\u0001 + 1))];
        int[] numArray2 = new int[(int) checked ((uint) unchecked (\u000E.\u0004.\u0001 + 1))];
        for (int index1 = 0; index1 < obj0.Length; ++index1)
        {
          int num1 = (int) obj0[index1];
          if (num1 <= 0)
            continue;
          int[] numArray3;
          int index2;
          int num2 = (numArray3 = numArray1)[(IntPtr) (index2 = num1)] + 1;
          numArray3[index2] = num2;
        }
        int num3 = 0;
        int num4 = 512;
        for (int index = 1; index <= \u000E.\u0004.\u0001; ++index)
        {
          numArray2[index] = num3;
          num3 += numArray1[index] << 16 - index;
          if (index >= 10)
          {
            int num1 = numArray2[index] & 130944;
            int num2 = num3 & 130944;
            num4 += num2 - num1 >> 16 - index;
          }
        }
        this.\u0001 = new short[(int) checked ((uint) num4)];
        int num5 = 512;
        for (int index = \u000E.\u0004.\u0001; index >= 10; --index)
        {
          int num1 = num3 & 130944;
          num3 -= numArray1[index] << 16 - index;
          int num2 = num3 & 130944;
          while (num2 < num1)
          {
            this.\u0001[(int) \u000E.\u0006.\u001D\u0005(num2)] = (short) (-num5 << 4 | index);
            num5 += 1 << index - 9;
            num2 += 128;
          }
        }
        for (int index1 = 0; index1 < obj0.Length; ++index1)
        {
          int index2 = (int) obj0[index1];
          if (index2 != 0)
          {
            int num1 = numArray2[index2];
            int index3 = (int) \u000E.\u0006.\u001D\u0005(num1);
            if (index2 <= 9)
            {
              do
              {
                this.\u0001[index3] = (short) (index1 << 4 | index2);
                index3 += 1 << index2;
              }
              while (index3 < 512);
            }
            else
            {
              int num2 = (int) this.\u0001[index3 & 511];
              int num6 = 1 << (num2 & 15);
              int num7 = -(num2 >> 4);
              do
              {
                this.\u0001[num7 | index3 >> 9] = (short) (index1 << 4 | index2);
                index3 += 1 << index2;
              }
              while (index3 < num6);
            }
            numArray2[index2] = num1 + (1 << 16 - index2);
          }
        }
      }

      public int \u001D\u0005([In] \u000E.\u0002 obj0)
      {
        int index;
        if ((index = obj0.\u001D\u0005(9)) < 0)
        {
          int num1 = obj0.\u001D\u0005();
          int num2 = (int) this.\u0001[obj0.\u001D\u0005(num1)];
          if (num2 < 0 || (num2 & 15) > num1)
            return -1;
          obj0.\u001D\u0005(num2 & 15);
          return num2 >> 4;
        }
        int num3;
        if ((num3 = (int) this.\u0001[index]) < 0)
        {
          int num1 = -(num3 >> 4);
          int num2 = num3 & 15;
          int num4;
          if ((num4 = obj0.\u001D\u0005(num2)) >= 0)
          {
            int num5 = (int) this.\u0001[num1 | num4 >> 9];
            obj0.\u001D\u0005(num5 & 15);
            return num5 >> 4;
          }
          int num6 = obj0.\u001D\u0005();
          int num7 = obj0.\u001D\u0005(num6);
          int num8 = (int) this.\u0001[num1 | num7 >> 9];
          if ((num8 & 15) > num6)
            return -1;
          obj0.\u001D\u0005(num8 & 15);
          return num8 >> 4;
        }
        obj0.\u001D\u0005(num3 & 15);
        return num3 >> 4;
      }
    }

    internal sealed class \u0005
    {
      private static readonly int[] \u0001 = new int[3]{ 3, 3, 11 };
      private static readonly int[] \u0002 = new int[3]{ 2, 3, 7 };
      private static readonly int[] \u0003 = new int[19]
      {
        16,
        17,
        18,
        0,
        8,
        7,
        9,
        6,
        10,
        5,
        11,
        4,
        12,
        3,
        13,
        2,
        14,
        1,
        15
      };
      private byte[] \u0001;
      private byte[] \u0002;
      private \u000E.\u0004 \u0001;
      private int \u0001;
      private int \u0002;
      private int \u0003;
      private int \u0004;
      private int \u0005;
      private int \u0006;
      private byte \u0001;
      private int \u0007;

      public bool \u001D\u0005([In] \u000E.\u0002 obj0)
      {
        while (true)
        {
          switch (this.\u0001)
          {
            case 0:
              this.\u0002 = obj0.\u001D\u0005(5);
              if (this.\u0002 >= 0)
              {
                this.\u0002 += 257;
                obj0.\u001D\u0005(5);
                this.\u0001 = 1;
                goto case 1;
              }
              else
                goto label_1;
            case 1:
              this.\u0003 = obj0.\u001D\u0005(5);
              if (this.\u0003 >= 0)
              {
                ++this.\u0003;
                obj0.\u001D\u0005(5);
                this.\u0005 = this.\u0002 + this.\u0003;
                this.\u0002 = new byte[(int) checked ((uint) this.\u0005)];
                this.\u0001 = 2;
                goto case 2;
              }
              else
                goto label_3;
            case 2:
              this.\u0004 = obj0.\u001D\u0005(4);
              if (this.\u0004 >= 0)
              {
                this.\u0004 += 4;
                obj0.\u001D\u0005(4);
                this.\u0001 = new byte[19];
                this.\u0007 = 0;
                this.\u0001 = 3;
                goto case 3;
              }
              else
                goto label_6;
            case 3:
              for (; this.\u0007 < this.\u0004; ++this.\u0007)
              {
                int num = obj0.\u001D\u0005(3);
                if (num < 0)
                  return false;
                obj0.\u001D\u0005(3);
                this.\u0001[\u000E.\u0005.\u0003[this.\u0007]] = (byte) num;
              }
              this.\u0001 = new \u000E.\u0004(this.\u0001);
              this.\u0001 = (byte[]) null;
              this.\u0007 = 0;
              this.\u0001 = 4;
              goto case 4;
            case 4:
              int num1;
              while (((num1 = this.\u0001.\u001D\u0005(obj0)) & -16) == 0)
              {
                this.\u0002[this.\u0007++] = this.\u0001 = (byte) num1;
                if (this.\u0007 == this.\u0005)
                  return true;
              }
              if (num1 >= 0)
              {
                if (num1 >= 17)
                  this.\u0001 = (byte) 0;
                this.\u0006 = num1 - 16;
                this.\u0001 = 5;
                goto case 5;
              }
              else
                goto label_17;
            case 5:
              int num2 = \u000E.\u0005.\u0002[this.\u0006];
              int num3 = obj0.\u001D\u0005(num2);
              if (num3 >= 0)
              {
                obj0.\u001D\u0005(num2);
                int num4 = num3 + \u000E.\u0005.\u0001[this.\u0006];
                while (num4-- > 0)
                  this.\u0002[this.\u0007++] = this.\u0001;
                if (this.\u0007 != this.\u0005)
                {
                  this.\u0001 = 4;
                  continue;
                }
                goto label_27;
              }
              else
                goto label_22;
            default:
              continue;
          }
        }
label_1:
        return false;
label_3:
        return false;
label_6:
        return false;
label_17:
        return false;
label_22:
        return false;
label_27:
        return true;
      }

      public \u000E.\u0004 \u001D\u0005()
      {
        byte[] numArray = new byte[(int) checked ((uint) this.\u0002)];
        Array.Copy((Array) this.\u0002, 0, (Array) numArray, 0, this.\u0002);
        return new \u000E.\u0004(numArray);
      }

      public \u000E.\u0004 \u001E\u0005()
      {
        byte[] numArray = new byte[(int) checked ((uint) this.\u0003)];
        Array.Copy((Array) this.\u0002, this.\u0002, (Array) numArray, 0, this.\u0003);
        return new \u000E.\u0004(numArray);
      }
    }

    internal sealed class \u0006
    {
      private static int \u0001 = 16384;
      private static int \u0002 = 286;
      private static int \u0003 = 30;
      private static int \u0004 = 19;
      private static int \u0005 = 16;
      private static int \u0006 = 17;
      private static int \u0007 = 18;
      private static int \u0008 = 256;
      private static int[] \u0001 = new int[19]
      {
        16,
        17,
        18,
        0,
        8,
        7,
        9,
        6,
        10,
        5,
        11,
        4,
        12,
        3,
        13,
        2,
        14,
        1,
        15
      };
      private static byte[] \u0001 = new byte[16]
      {
        (byte) 0,
        (byte) 8,
        (byte) 4,
        (byte) 12,
        (byte) 2,
        (byte) 10,
        (byte) 6,
        (byte) 14,
        (byte) 1,
        (byte) 9,
        (byte) 5,
        (byte) 13,
        (byte) 3,
        (byte) 11,
        (byte) 7,
        (byte) 15
      };
      private static short[] \u0001 = new short[(int) checked ((uint) \u000E.\u0006.\u0002)];
      private static byte[] \u0002 = new byte[(int) checked ((uint) \u000E.\u0006.\u0002)];
      private static short[] \u0002;
      private static byte[] \u0003;

      static \u0006()
      {
        int index1;
        for (index1 = 0; index1 < 144; \u000E.\u0006.\u0002[index1++] = (byte) 8)
          \u000E.\u0006.\u0001[index1] = \u000E.\u0006.\u001D\u0005(48 + index1 << 8);
        for (; index1 < 256; \u000E.\u0006.\u0002[index1++] = (byte) 9)
          \u000E.\u0006.\u0001[index1] = \u000E.\u0006.\u001D\u0005(256 + index1 << 7);
        for (; index1 < 280; \u000E.\u0006.\u0002[index1++] = (byte) 7)
          \u000E.\u0006.\u0001[index1] = \u000E.\u0006.\u001D\u0005(index1 - 256 << 9);
        for (; index1 < \u000E.\u0006.\u0002; \u000E.\u0006.\u0002[index1++] = (byte) 8)
          \u000E.\u0006.\u0001[index1] = \u000E.\u0006.\u001D\u0005(index1 - 88 << 8);
        \u000E.\u0006.\u0002 = new short[(int) checked ((uint) \u000E.\u0006.\u0003)];
        \u000E.\u0006.\u0003 = new byte[(int) checked ((uint) \u000E.\u0006.\u0003)];
        for (int index2 = 0; index2 < \u000E.\u0006.\u0003; ++index2)
        {
          \u000E.\u0006.\u0002[index2] = \u000E.\u0006.\u001D\u0005(index2 << 11);
          \u000E.\u0006.\u0003[index2] = (byte) 5;
        }
      }

      public static short \u001D\u0005([In] int obj0)
      {
        return (short) ((int) \u000E.\u0006.\u0001[obj0 & 15] << 12 | (int) \u000E.\u0006.\u0001[obj0 >> 4 & 15] << 8 | (int) \u000E.\u0006.\u0001[obj0 >> 8 & 15] << 4 | (int) \u000E.\u0006.\u0001[obj0 >> 12]);
      }
    }

    internal sealed class \u0007 : MemoryStream
    {
      public \u0007([In] byte[] obj0)
        : base(obj0, false)
      {
      }

      public int \u001D\u0005()
      {
        return this.ReadByte() | this.ReadByte() << 8;
      }

      public int \u001E\u0005()
      {
        return this.\u001D\u0005() | this.\u001D\u0005() << 16;
      }
    }
  }
}
