// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0082;
using System;

namespace \u0082
{
  internal static class \u0002
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private const uint \u0001 = 8;
    private const uint \u0002 = 33;
    private const uint \u0003 = 9;
    private const byte \u0001 = 32;
    private const byte \u0002 = 16;
    private const uint \u0004 = 1024;
    private const uint \u0005 = 2048;
    private const uint \u0006 = 16384;
    private const uint \u0007 = 49151;
    private const byte \u0003 = 14;
    private const uint \u0008 = 16383;
    private const uint \u000E = 65539;

    static \u0002()
    {
      \u0004.\u001D\u0005(typeof (\u0002));
    }

    public static unsafe void \u001D\u0005(byte[] src, out byte[] dst)
    {
      uint num1 = (uint) (src.Length + src.Length / 16 + 64 + 3);
      dst = new byte[(IntPtr) num1];
      uint num2;
      uint num3;
      if ((long) src.Length > 13L)
      {
        fixed (byte* numPtr1 = new byte[new IntPtr(65539)])
          fixed (byte* numPtr2 = src)
            fixed (byte* numPtr3 = dst)
            {
              byte** numPtr4 = (byte**) numPtr1;
              byte* numPtr5 = numPtr2 + src.Length;
              byte* numPtr6 = numPtr2 + src.Length - 8 - 5;
              byte* numPtr7 = numPtr2;
              byte* input = numPtr2 + 4;
              byte* numPtr8 = numPtr3;
              bool flag1 = false;
              bool flag2 = false;
              do
              {
                uint num4 = 0;
                uint idx = \u0002.\u001D\u0005(input);
                byte* numPtr9 = input - (long) ((IntPtr) (input - ((IntPtr*) ((IntPtr) numPtr4 + (IntPtr) ((long) idx * (long) sizeof (byte*))))->ToInt64()) / 1);
                // ISSUE: cast to a reference type
                if (numPtr9 < (byte&) numPtr2 || (num4 = (uint) (input - numPtr9)) <= 0U || num4 > 49151U)
                  flag1 = true;
                else if (num4 > 2048U && (int) numPtr9[3] != (int) input[3])
                {
                  idx = \u0002.\u001D\u0005(idx);
                  numPtr9 = input - (long) ((IntPtr) (input - ((IntPtr*) ((IntPtr) numPtr4 + (IntPtr) ((long) idx * (long) sizeof (byte*))))->ToInt64()) / 1);
                  // ISSUE: cast to a reference type
                  if (numPtr9 < (byte&) numPtr2 || (num4 = (uint) (input - numPtr9)) <= 0U || num4 > 49151U)
                    flag1 = true;
                  else if (num4 > 2048U && (int) numPtr9[3] != (int) input[3])
                    flag1 = true;
                }
                if (!flag1 && (int) *(ushort*) numPtr9 == (int) *(ushort*) input && (int) numPtr9[2] == (int) input[2])
                  flag2 = true;
                flag1 = false;
                if (!flag2)
                {
                  *(IntPtr*) ((IntPtr) numPtr4 + (IntPtr) ((long) idx * (long) sizeof (byte*))) = (IntPtr) input;
                  ++input;
                  if (input >= numPtr6)
                    break;
                }
                else
                {
                  flag2 = false;
                  *(IntPtr*) ((IntPtr) numPtr4 + (IntPtr) ((long) idx * (long) sizeof (byte*))) = (IntPtr) input;
                  if (input - numPtr7 > 0L)
                  {
                    uint num5 = (uint) (input - numPtr7);
                    if (num5 <= 3U)
                    {
                      IntPtr num6 = (IntPtr) (numPtr8 + -2);
                      int num7 = (int) (byte) ((uint) *(byte*) num6 | (uint) (byte) num5);
                      *(sbyte*) num6 = (sbyte) num7;
                    }
                    else if (num5 <= 18U)
                    {
                      *numPtr8++ = (byte) (num5 - 3U);
                    }
                    else
                    {
                      uint num6 = num5 - 18U;
                      byte* numPtr10 = numPtr8;
                      IntPtr num7 = new IntPtr(1);
                      byte* numPtr11 = numPtr10 + num7.ToInt64();
                      int num8 = 0;
                      *numPtr10 = (byte) num8;
                      while (num6 > (uint) byte.MaxValue)
                      {
                        num6 -= (uint) byte.MaxValue;
                        *numPtr11++ = (byte) 0;
                      }
                      byte* numPtr12 = numPtr11;
                      IntPtr num9 = new IntPtr(1);
                      numPtr8 = numPtr12 + num9.ToInt64();
                      int num10 = (int) (byte) num6;
                      *numPtr12 = (byte) num10;
                    }
                    do
                    {
                      *numPtr8++ = *numPtr7++;
                    }
                    while (--num5 > 0U);
                  }
                  byte* numPtr13 = input + 3;
                  int num11 = (int) numPtr9[3];
                  byte* numPtr14 = numPtr13;
                  IntPtr num12 = new IntPtr(1);
                  input = numPtr14 + num12.ToInt64();
                  int num13 = (int) *numPtr14;
                  if (num11 != num13 || (int) numPtr9[4] != (int) *input++ || ((int) numPtr9[5] != (int) *input++ || (int) numPtr9[6] != (int) *input++) || ((int) numPtr9[7] != (int) *input++ || (int) numPtr9[8] != (int) *input++))
                  {
                    --input;
                    uint num5 = (uint) (input - numPtr7);
                    if (num4 <= 2048U)
                    {
                      uint num6 = num4 - 1U;
                      byte* numPtr10 = numPtr8;
                      IntPtr num7 = new IntPtr(1);
                      byte* numPtr11 = numPtr10 + num7.ToInt64();
                      int num8 = (int) (byte) ((int) num5 - 1 << 5 | ((int) num6 & 7) << 2);
                      *numPtr10 = (byte) num8;
                      byte* numPtr12 = numPtr11;
                      IntPtr num9 = new IntPtr(1);
                      numPtr8 = numPtr12 + num9.ToInt64();
                      int num10 = (int) (byte) (num6 >> 3);
                      *numPtr12 = (byte) num10;
                    }
                    else if (num4 <= 16384U)
                    {
                      uint num6 = num4 - 1U;
                      byte* numPtr10 = numPtr8;
                      IntPtr num7 = new IntPtr(1);
                      byte* numPtr11 = numPtr10 + num7.ToInt64();
                      int num8 = (int) (byte) (32 | (int) num5 - 2);
                      *numPtr10 = (byte) num8;
                      byte* numPtr12 = numPtr11;
                      IntPtr num9 = new IntPtr(1);
                      byte* numPtr15 = numPtr12 + num9.ToInt64();
                      int num10 = (int) (byte) (((int) num6 & 63) << 2);
                      *numPtr12 = (byte) num10;
                      byte* numPtr16 = numPtr15;
                      IntPtr num14 = new IntPtr(1);
                      numPtr8 = numPtr16 + num14.ToInt64();
                      int num15 = (int) (byte) (num6 >> 6);
                      *numPtr16 = (byte) num15;
                    }
                    else
                    {
                      uint num6 = num4 - 16384U;
                      byte* numPtr10 = numPtr8;
                      IntPtr num7 = new IntPtr(1);
                      byte* numPtr11 = numPtr10 + num7.ToInt64();
                      int num8 = (int) (byte) (16 | (int) ((num6 & 16384U) >> 11) | (int) num5 - 2);
                      *numPtr10 = (byte) num8;
                      byte* numPtr12 = numPtr11;
                      IntPtr num9 = new IntPtr(1);
                      byte* numPtr15 = numPtr12 + num9.ToInt64();
                      int num10 = (int) (byte) (((int) num6 & 63) << 2);
                      *numPtr12 = (byte) num10;
                      byte* numPtr16 = numPtr15;
                      IntPtr num14 = new IntPtr(1);
                      numPtr8 = numPtr16 + num14.ToInt64();
                      int num15 = (int) (byte) (num6 >> 6);
                      *numPtr16 = (byte) num15;
                    }
                  }
                  else
                  {
                    for (byte* numPtr10 = numPtr9 + 8 + 1; input < numPtr5 && (int) *numPtr10 == (int) *input; ++input)
                      ++numPtr10;
                    uint num5 = (uint) (input - numPtr7);
                    uint num6;
                    byte* numPtr11;
                    if (num4 <= 16384U)
                    {
                      num6 = num4 - 1U;
                      if (num5 <= 33U)
                      {
                        byte* numPtr10 = numPtr8;
                        IntPtr num7 = new IntPtr(1);
                        numPtr11 = numPtr10 + num7.ToInt64();
                        int num8 = (int) (byte) (32 | (int) num5 - 2);
                        *numPtr10 = (byte) num8;
                      }
                      else
                      {
                        uint num7 = num5 - 33U;
                        byte* numPtr10 = numPtr8;
                        IntPtr num8 = new IntPtr(1);
                        byte* numPtr12 = numPtr10 + num8.ToInt64();
                        int num9 = 32;
                        *numPtr10 = (byte) num9;
                        while (num7 > (uint) byte.MaxValue)
                        {
                          num7 -= (uint) byte.MaxValue;
                          *numPtr12++ = (byte) 0;
                        }
                        byte* numPtr15 = numPtr12;
                        IntPtr num10 = new IntPtr(1);
                        numPtr11 = numPtr15 + num10.ToInt64();
                        int num14 = (int) (byte) num7;
                        *numPtr15 = (byte) num14;
                      }
                    }
                    else
                    {
                      num6 = num4 - 16384U;
                      if (num5 <= 9U)
                      {
                        byte* numPtr10 = numPtr8;
                        IntPtr num7 = new IntPtr(1);
                        numPtr11 = numPtr10 + num7.ToInt64();
                        int num8 = (int) (byte) (16 | (int) ((num6 & 16384U) >> 11) | (int) num5 - 2);
                        *numPtr10 = (byte) num8;
                      }
                      else
                      {
                        uint num7 = num5 - 9U;
                        byte* numPtr10 = numPtr8;
                        IntPtr num8 = new IntPtr(1);
                        byte* numPtr12 = numPtr10 + num8.ToInt64();
                        int num9 = (int) (byte) (16U | (num6 & 16384U) >> 11);
                        *numPtr10 = (byte) num9;
                        while (num7 > (uint) byte.MaxValue)
                        {
                          num7 -= (uint) byte.MaxValue;
                          *numPtr12++ = (byte) 0;
                        }
                        byte* numPtr15 = numPtr12;
                        IntPtr num10 = new IntPtr(1);
                        numPtr11 = numPtr15 + num10.ToInt64();
                        int num14 = (int) (byte) num7;
                        *numPtr15 = (byte) num14;
                      }
                    }
                    byte* numPtr16 = numPtr11;
                    IntPtr num15 = new IntPtr(1);
                    byte* numPtr17 = numPtr16 + num15.ToInt64();
                    int num16 = (int) (byte) (((int) num6 & 63) << 2);
                    *numPtr16 = (byte) num16;
                    byte* numPtr18 = numPtr17;
                    IntPtr num17 = new IntPtr(1);
                    numPtr8 = numPtr18 + num17.ToInt64();
                    int num18 = (int) (byte) (num6 >> 6);
                    *numPtr18 = (byte) num18;
                  }
                  numPtr7 = input;
                }
              }
              while (input < numPtr6);
              num2 = (uint) (numPtr8 - numPtr3);
              num3 = (uint) (numPtr5 - numPtr7);
            }
      }
      else
        goto label_63;
label_49:
      if (num3 > 0U)
      {
        uint num4 = (uint) src.Length - num3;
        if ((int) num2 == 0 && num3 <= 238U)
          dst[(IntPtr) num2++] = (byte) (17U + num3);
        else if (num3 <= 3U)
          dst[(IntPtr) (num2 - 2U)] |= (byte) num3;
        else if (num3 <= 18U)
        {
          dst[(IntPtr) num2++] = (byte) (num3 - 3U);
        }
        else
        {
          uint num5 = num3 - 18U;
          byte[] numArray1 = dst;
          int num6 = (int) num2;
          int num7 = 1;
          uint num8 = (uint) (num6 + num7);
          IntPtr index1 = (IntPtr) (uint) num6;
          int num9 = 0;
          numArray1[index1] = (byte) num9;
          while (num5 > (uint) byte.MaxValue)
          {
            num5 -= (uint) byte.MaxValue;
            dst[(IntPtr) num8++] = (byte) 0;
          }
          byte[] numArray2 = dst;
          int num10 = (int) num8;
          int num11 = 1;
          num2 = (uint) (num10 + num11);
          IntPtr index2 = (IntPtr) (uint) num10;
          int num12 = (int) (byte) num5;
          numArray2[index2] = (byte) num12;
        }
        do
        {
          dst[(IntPtr) num2++] = src[(IntPtr) num4++];
        }
        while (--num3 > 0U);
      }
      byte[] numArray3 = dst;
      int num19 = (int) num2;
      int num20 = 1;
      uint num21 = (uint) (num19 + num20);
      IntPtr index3 = (IntPtr) (uint) num19;
      int num22 = 17;
      numArray3[index3] = (byte) num22;
      byte[] numArray4 = dst;
      int num23 = (int) num21;
      int num24 = 1;
      uint num25 = (uint) (num23 + num24);
      IntPtr index4 = (IntPtr) (uint) num23;
      int num26 = 0;
      numArray4[index4] = (byte) num26;
      byte[] numArray5 = dst;
      int num27 = (int) num25;
      int num28 = 1;
      uint num29 = (uint) (num27 + num28);
      IntPtr index5 = (IntPtr) (uint) num27;
      int num30 = 0;
      numArray5[index5] = (byte) num30;
      if ((long) dst.Length == (long) num29)
        return;
      byte[] numArray6 = new byte[(IntPtr) num29];
      \u0089\u0083.\u0005\u0095((Array) dst, 0, (Array) numArray6, 0, (int) num29);
      dst = numArray6;
      return;
label_63:
      num3 = (uint) src.Length;
      num2 = 0U;
      goto label_49;
    }

    public static unsafe void \u001D\u0005(byte[] src, byte[] dst)
    {
      uint num1 = 0;
      fixed (byte* numPtr1 = src)
        fixed (byte* numPtr2 = dst)
        {
          byte* numPtr3 = (byte*) null;
          byte* numPtr4 = numPtr1 + src.Length;
          byte* numPtr5 = numPtr2 + dst.Length;
          byte* numPtr6 = numPtr1;
          byte* numPtr7 = numPtr2;
          bool flag1 = false;
          bool flag2 = false;
          bool flag3 = false;
          bool flag4 = false;
          bool flag5 = false;
          bool flag6 = false;
          if ((int) *numPtr6 > 17)
          {
            num1 = (uint) *numPtr6++ - 17U;
            if (num1 < 4U)
            {
              flag2 = true;
            }
            else
            {
              if (numPtr5 - numPtr7 < (long) num1)
                throw new OverflowException(\u0002.\u0001(97285));
              if (numPtr4 - numPtr6 < (long) (num1 + 1U))
                throw new OverflowException(\u0002.\u0001(97306));
              do
              {
                *numPtr7++ = *numPtr6++;
              }
              while (--num1 > 0U);
              flag5 = true;
            }
          }
          while (!flag6 && numPtr6 < numPtr4)
          {
            if (!flag2 && !flag5)
            {
              num1 = (uint) *numPtr6++;
              if (num1 >= 16U)
              {
                flag1 = true;
              }
              else
              {
                if ((int) num1 == 0)
                {
                  if (numPtr4 - numPtr6 < 1L)
                    throw new OverflowException(\u0002.\u0001(97306));
                  while ((int) *numPtr6 == 0)
                  {
                    num1 += (uint) byte.MaxValue;
                    ++numPtr6;
                    if (numPtr4 - numPtr6 < 1L)
                      throw new OverflowException(\u0002.\u0001(97306));
                  }
                  num1 += 15U + (uint) *numPtr6++;
                }
                if (numPtr5 - numPtr7 < (long) (num1 + 3U))
                  throw new OverflowException(\u0002.\u0001(97285));
                if (numPtr4 - numPtr6 < (long) (num1 + 4U))
                  throw new OverflowException(\u0002.\u0001(97306));
                int num2 = 0;
                while (num2 < 4)
                {
                  *numPtr7 = *numPtr6;
                  ++num2;
                  ++numPtr7;
                  ++numPtr6;
                }
                if (--num1 > 0U)
                {
                  if (num1 >= 4U)
                  {
                    do
                    {
                      int num3 = 0;
                      while (num3 < 4)
                      {
                        *numPtr7 = *numPtr6;
                        ++num3;
                        ++numPtr7;
                        ++numPtr6;
                      }
                      num1 -= 4U;
                    }
                    while (num1 >= 4U);
                    if (num1 > 0U)
                    {
                      do
                      {
                        *numPtr7++ = *numPtr6++;
                      }
                      while (--num1 > 0U);
                    }
                  }
                  else
                  {
                    do
                    {
                      *numPtr7++ = *numPtr6++;
                    }
                    while (--num1 > 0U);
                  }
                }
              }
            }
            if (!flag1 && !flag2)
            {
              flag5 = false;
              num1 = (uint) *numPtr6++;
              if (num1 < 16U)
              {
                byte* numPtr8 = numPtr7 - 2049 - (int) (num1 >> 2) - ((int) *numPtr6++ << 2);
                // ISSUE: cast to a reference type
                if (numPtr8 < (byte&) numPtr2 || numPtr8 >= numPtr7)
                  throw new OverflowException(\u0002.\u0001(97327));
                if (numPtr5 - numPtr7 < 3L)
                  throw new OverflowException(\u0002.\u0001(97285));
                byte* numPtr9 = numPtr7;
                IntPtr num2 = new IntPtr(1);
                byte* numPtr10 = numPtr9 + num2.ToInt64();
                byte* numPtr11 = numPtr8;
                IntPtr num3 = new IntPtr(1);
                byte* numPtr12 = numPtr11 + num3.ToInt64();
                int num4 = (int) *numPtr11;
                *numPtr9 = (byte) num4;
                byte* numPtr13 = numPtr10;
                IntPtr num5 = new IntPtr(1);
                byte* numPtr14 = numPtr13 + num5.ToInt64();
                byte* numPtr15 = numPtr12;
                IntPtr num6 = new IntPtr(1);
                byte* numPtr16 = numPtr15 + num6.ToInt64();
                int num7 = (int) *numPtr15;
                *numPtr13 = (byte) num7;
                byte* numPtr17 = numPtr14;
                IntPtr num8 = new IntPtr(1);
                numPtr7 = numPtr17 + num8.ToInt64();
                byte* numPtr18 = numPtr16;
                IntPtr num9 = new IntPtr(1);
                numPtr3 = numPtr18 + num9.ToInt64();
                int num10 = (int) *numPtr18;
                *numPtr17 = (byte) num10;
                flag3 = true;
              }
            }
            flag1 = false;
label_44:
            byte* numPtr19;
            if (num1 >= 64U)
            {
              numPtr19 = numPtr7 - 1 - ((int) (num1 >> 2) & 7) - ((int) *numPtr6++ << 3);
              num1 = (num1 >> 5) - 1U;
              // ISSUE: cast to a reference type
              if (numPtr19 < (byte&) numPtr2 || numPtr19 >= numPtr7)
                throw new OverflowException(\u0002.\u0001(97327));
              if (numPtr5 - numPtr7 < (long) (num1 + 2U))
                throw new OverflowException(\u0002.\u0001(97285));
              flag4 = true;
            }
            else if (num1 >= 32U)
            {
              num1 &= 31U;
              if ((int) num1 == 0)
              {
                if (numPtr4 - numPtr6 < 1L)
                  throw new OverflowException(\u0002.\u0001(97306));
                while ((int) *numPtr6 == 0)
                {
                  num1 += (uint) byte.MaxValue;
                  ++numPtr6;
                  if (numPtr4 - numPtr6 < 1L)
                    throw new OverflowException(\u0002.\u0001(97306));
                }
                num1 += 31U + (uint) *numPtr6++;
              }
              numPtr19 = numPtr7 - 1 - ((int) *(ushort*) numPtr6 >> 2);
              numPtr6 += 2;
            }
            else if (num1 >= 16U)
            {
              byte* numPtr8 = numPtr7 - (((int) num1 & 8) << 11);
              num1 &= 7U;
              if ((int) num1 == 0)
              {
                if (numPtr4 - numPtr6 < 1L)
                  throw new OverflowException(\u0002.\u0001(97306));
                while ((int) *numPtr6 == 0)
                {
                  num1 += (uint) byte.MaxValue;
                  ++numPtr6;
                  if (numPtr4 - numPtr6 < 1L)
                    throw new OverflowException(\u0002.\u0001(97306));
                }
                num1 += 7U + (uint) *numPtr6++;
              }
              numPtr19 = numPtr8 - ((int) *(ushort*) numPtr6 >> 2);
              numPtr6 += 2;
              if (numPtr19 == numPtr7)
                flag6 = true;
              else
                numPtr19 -= 16384;
            }
            else
            {
              byte* numPtr8 = numPtr7 - 1 - (int) (num1 >> 2) - ((int) *numPtr6++ << 2);
              // ISSUE: cast to a reference type
              if (numPtr8 < (byte&) numPtr2 || numPtr8 >= numPtr7)
                throw new OverflowException(\u0002.\u0001(97327));
              if (numPtr5 - numPtr7 < 2L)
                throw new OverflowException(\u0002.\u0001(97285));
              byte* numPtr9 = numPtr7;
              IntPtr num2 = new IntPtr(1);
              byte* numPtr10 = numPtr9 + num2.ToInt64();
              byte* numPtr11 = numPtr8;
              IntPtr num3 = new IntPtr(1);
              byte* numPtr12 = numPtr11 + num3.ToInt64();
              int num4 = (int) *numPtr11;
              *numPtr9 = (byte) num4;
              byte* numPtr13 = numPtr10;
              IntPtr num5 = new IntPtr(1);
              numPtr7 = numPtr13 + num5.ToInt64();
              byte* numPtr14 = numPtr12;
              IntPtr num6 = new IntPtr(1);
              numPtr19 = numPtr14 + num6.ToInt64();
              int num7 = (int) *numPtr14;
              *numPtr13 = (byte) num7;
              flag3 = true;
            }
            if (!flag6 && !flag3 && !flag4)
            {
              // ISSUE: cast to a reference type
              if (numPtr19 < (byte&) numPtr2 || numPtr19 >= numPtr7)
                throw new OverflowException(\u0002.\u0001(97327));
              if (numPtr5 - numPtr7 < (long) (num1 + 2U))
                throw new OverflowException(\u0002.\u0001(97285));
            }
            if (!flag6 && num1 >= 6U && (numPtr7 - numPtr19 >= 4L && !flag3) && !flag4)
            {
              int num2 = 0;
              while (num2 < 4)
              {
                *numPtr7 = *numPtr19;
                ++num2;
                ++numPtr7;
                ++numPtr19;
              }
              num1 -= 2U;
              do
              {
                int num3 = 0;
                while (num3 < 4)
                {
                  *numPtr7 = *numPtr19;
                  ++num3;
                  ++numPtr7;
                  ++numPtr19;
                }
                num1 -= 4U;
              }
              while (num1 >= 4U);
              if (num1 > 0U)
              {
                do
                {
                  *numPtr7++ = *numPtr19++;
                }
                while (--num1 > 0U);
              }
            }
            else if (!flag6 && !flag3)
            {
              flag4 = false;
              byte* numPtr8 = numPtr7;
              IntPtr num2 = new IntPtr(1);
              byte* numPtr9 = numPtr8 + num2.ToInt64();
              byte* numPtr10 = numPtr19;
              IntPtr num3 = new IntPtr(1);
              byte* numPtr11 = numPtr10 + num3.ToInt64();
              int num4 = (int) *numPtr10;
              *numPtr8 = (byte) num4;
              byte* numPtr12 = numPtr9;
              IntPtr num5 = new IntPtr(1);
              numPtr7 = numPtr12 + num5.ToInt64();
              byte* numPtr13 = numPtr11;
              IntPtr num6 = new IntPtr(1);
              byte* numPtr14 = numPtr13 + num6.ToInt64();
              int num7 = (int) *numPtr13;
              *numPtr12 = (byte) num7;
              do
              {
                *numPtr7++ = *numPtr14++;
              }
              while (--num1 > 0U);
            }
            if (!flag6 && !flag2)
            {
              flag3 = false;
              num1 = (uint) numPtr6[-2] & 3U;
              if ((int) num1 == 0)
                continue;
            }
            if (!flag6)
            {
              flag2 = false;
              if (numPtr5 - numPtr7 < (long) num1)
                throw new OverflowException(\u0002.\u0001(97285));
              if (numPtr4 - numPtr6 < (long) (num1 + 1U))
                throw new OverflowException(\u0002.\u0001(97306));
              byte* numPtr8 = numPtr7++;
              byte* numPtr9 = numPtr6;
              IntPtr num2 = new IntPtr(1);
              byte* numPtr10 = numPtr9 + num2.ToInt64();
              int num3 = (int) *numPtr9;
              *numPtr8 = (byte) num3;
              if (num1 > 1U)
              {
                *numPtr7++ = *numPtr10++;
                if (num1 > 2U)
                  *numPtr7++ = *numPtr10++;
              }
              byte* numPtr11 = numPtr10;
              IntPtr num4 = new IntPtr(1);
              numPtr6 = numPtr11 + num4.ToInt64();
              num1 = (uint) *numPtr11;
            }
            if (!flag6 && numPtr6 < numPtr4)
              goto label_44;
          }
          if (!flag6)
            throw new OverflowException(\u0002.\u0001(97352));
          if (numPtr6 > numPtr4)
            throw new OverflowException(\u0002.\u0001(97306));
          if (numPtr6 < numPtr4)
            throw new OverflowException(\u0002.\u0001(97381));
        }
    }

    private static unsafe uint \u001D\u0005(byte* input)
    {
      return \u0002.\u001D\u0005(\u0002.\u001D\u0005(33U, \u0002.\u001D\u0005(input, (byte) 5, (byte) 5, (byte) 6)) >> 5, (byte) 0);
    }

    private static uint \u001D\u0005(uint idx)
    {
      return (uint) ((int) idx & 2047 ^ 8223);
    }

    private static uint \u001D\u0005(uint v, byte s)
    {
      return (v & 16383U >> (int) s) << (int) s;
    }

    private static uint \u001D\u0005(uint a, uint b)
    {
      return a * b;
    }

    private static unsafe uint \u001D\u0005(byte* input, byte s1, byte s2)
    {
      return ((uint) input[2] << (int) s2 ^ (uint) input[1]) << (int) s1 ^ (uint) *input;
    }

    private static unsafe uint \u001D\u0005(byte* input, byte s1, byte s2, byte s3)
    {
      return \u0002.\u001D\u0005(input + 1, s2, s3) << (int) s1 ^ (uint) *input;
    }
  }
}
