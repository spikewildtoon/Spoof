// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0019;
using \u001D;
using \u001E;
using \u0081;
using \u0082;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace \u001A
{
  internal sealed class \u0080
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly ushort \u0001;
    private static readonly uint \u0001;

    public event EventHandler<\u0005> ProgressChanged;

    static \u0080()
    {
      \u0004.\u001D\u0005(typeof (\u001A.\u0080));
      \u001A.\u0080.\u0001 = (ushort) 2;
      \u001A.\u0080.\u0001 = 4276877996U;
    }

    private static void \u001D\u0005(\u001C.\u0016 pd, BinaryWriter write_stream, uint length, uint copy_pos)
    {
      int num1;
      int num2 = num1 = (int) copy_pos - (int) pd.\u0006;
      \u0087\u0083.\u007E\u0014\u009E((object) write_stream, (ushort) length);
      if ((int) length == 0)
        return;
      \u0011\u001F.\u007E\u0015\u009E((object) write_stream, num2);
      pd.\u0006 = copy_pos + length;
    }

    private static void \u001D\u0005(BinaryWriter write_stream, uint length, byte[] buffer, uint buffer_pos)
    {
      \u0087\u0083.\u007E\u0014\u009E((object) write_stream, (ushort) length);
      if (length <= 0U)
        return;
      \u0016\u0086.\u007E\u0011\u009E((object) write_stream, buffer, (int) buffer_pos, (int) length);
    }

    private static void \u001D\u0005(\u001C.\u0016 pd, BinaryWriter write_stream, uint add_length, byte[] add_buffer, uint copy_length, uint copy_pos)
    {
      if ((int) add_length == 0 && (int) copy_length == 0)
        return;
      uint buffer_pos = 0;
      while (add_length > (uint) ushort.MaxValue)
      {
        \u001A.\u0080.\u001D\u0005(write_stream, (uint) ushort.MaxValue, add_buffer, buffer_pos);
        buffer_pos += (uint) ushort.MaxValue;
        add_length -= (uint) ushort.MaxValue;
        \u001A.\u0080.\u001D\u0005(pd, write_stream, 0U, 0U);
      }
      \u001A.\u0080.\u001D\u0005(write_stream, add_length, add_buffer, buffer_pos);
      while (copy_length > (uint) ushort.MaxValue)
      {
        \u001A.\u0080.\u001D\u0005(pd, write_stream, (uint) ushort.MaxValue, copy_pos);
        copy_pos += (uint) ushort.MaxValue;
        copy_length -= (uint) ushort.MaxValue;
        \u001A.\u0080.\u001D\u0005(write_stream, 0U, (byte[]) null, 0U);
      }
      \u001A.\u0080.\u001D\u0005(pd, write_stream, copy_length, copy_pos);
    }

    private static void \u001D\u0005(\u001C.\u0016 pd, BinaryWriter write_stream)
    {
      uint add_length = (uint) pd.\u0001.Sum<byte[]>((Func<byte[], int>) (item => item.Length));
      byte[] add_buffer = new byte[(IntPtr) add_length];
      int num = 0;
      while (pd.\u0001.Count > 0)
      {
        byte[] numArray = pd.\u0001.Dequeue();
        \u0083\u0081.\u007E\u008C\u0092((object) numArray, (Array) add_buffer, num);
        num += numArray.Length;
      }
      \u001A.\u0080.\u001D\u0005(pd, write_stream, add_length, add_buffer, pd.\u0004, pd.\u0005);
      pd.\u0004 = 0U;
    }

    public static void \u001D\u0005(\u001C.\u0016 pd, BinaryWriter write_stream, uint add_length, byte[] add_buffer, uint start_pos, uint copy_length, uint copy_pos)
    {
      if ((int) add_length != 0)
        goto label_8;
label_2:
      if ((int) copy_length == 0)
        return;
      if ((int) pd.\u0004 == 0)
      {
        pd.\u0005 = copy_pos;
        pd.\u0004 = copy_length;
        return;
      }
      if ((int) pd.\u0005 + (int) pd.\u0004 == (int) copy_pos)
      {
        pd.\u0004 += copy_length;
        return;
      }
      \u001A.\u0080.\u001D\u0005(pd, write_stream);
      pd.\u0005 = copy_pos;
      pd.\u0004 = copy_length;
      return;
label_8:
      if ((int) pd.\u0004 != 0)
        \u001A.\u0080.\u001D\u0005(pd, write_stream);
      byte[] numArray = new byte[(IntPtr) add_length];
      \u001F\u0080.\u0086\u0092((Array) add_buffer, (long) start_pos, (Array) numArray, 0L, (long) add_length);
      pd.\u0001.Enqueue(numArray);
      goto label_2;
    }

    private static uint \u001D\u0005(byte[] buf1, uint new_pos, byte[] buf2, uint copy_pos, uint max_length, uint min_length)
    {
      if (min_length > 2U && (min_length >= max_length || ((int) buf1[(IntPtr) (min_length + new_pos)] != (int) buf2[(IntPtr) (min_length + copy_pos)] || ((int) buf1[(IntPtr) (min_length - 1U + new_pos)] != (int) buf2[(IntPtr) (min_length - 1U + copy_pos)] || (int) buf1[(IntPtr) (min_length - 2U + new_pos)] != (int) buf2[(IntPtr) (min_length - 2U + copy_pos)]))))
        return 0;
      uint num;
      for (num = 0U; num < max_length && (int) buf1[(IntPtr) new_pos] == (int) buf2[(IntPtr) copy_pos]; ++num)
      {
        ++new_pos;
        ++copy_pos;
      }
      return num;
    }

    private static void \u001D\u0005(uint new_pos, ref uint copy_pos, ref ushort copy_length, uint[] hash_table, uint[] link_table, byte[] buffer_orig, uint length_orig, byte[] buffer_new, uint length_new)
    {
      copy_length = (ushort) 0;
      uint num1 = \u001A.\u0080.\u001D\u0005(buffer_new, new_pos);
      if (-1 == (int) hash_table[(IntPtr) num1])
        return;
      copy_pos = hash_table[(IntPtr) num1];
      copy_length = (ushort) \u001A.\u0080.\u001D\u0005(buffer_new, new_pos, buffer_orig, copy_pos, \u0005\u0083.\u0001\u0097(\u0005\u0083.\u0001\u0097(length_new - new_pos, length_orig - copy_pos), (uint) ushort.MaxValue), 0U);
      for (uint copy_pos1 = link_table[(IntPtr) copy_pos]; (int) copy_pos1 != -1; copy_pos1 = link_table[(IntPtr) copy_pos1])
      {
        ushort num2 = (ushort) \u001A.\u0080.\u001D\u0005(buffer_new, new_pos, buffer_orig, copy_pos1, \u0005\u0083.\u0001\u0097(\u0005\u0083.\u0001\u0097(length_new - new_pos, length_orig - copy_pos1), (uint) ushort.MaxValue), (uint) copy_length);
        if ((int) num2 > (int) copy_length)
        {
          copy_pos = copy_pos1;
          copy_length = num2;
        }
      }
    }

    private static void \u001D\u0005(BinaryWriter write_stream, Stream stream_orig, Stream stream_new)
    {
      \u000F\u0083.\u007E\u0016\u009E((object) write_stream, \u001A.\u0080.\u0001);
      \u0087\u0083.\u007E\u0014\u009E((object) write_stream, \u001A.\u0080.\u0001);
      \u000F\u0083.\u007E\u0016\u009E((object) write_stream, (uint) \u001F\u001E.\u007E\u0080\u009D((object) stream_orig));
      \u009F\u001D.\u007E\u0007\u009E((object) write_stream).\u001D\u0005(stream_orig.\u001D\u0005());
      \u000F\u0083.\u007E\u0016\u009E((object) write_stream, (uint) \u001F\u001E.\u007E\u0080\u009D((object) stream_new));
      \u009F\u001D.\u007E\u0007\u009E((object) write_stream).\u001D\u0005(stream_new.\u001D\u0005());
    }

    private static void \u001E\u0005(\u001C.\u0016 pd, BinaryWriter write_stream)
    {
      \u001A.\u0080.\u001D\u0005(pd, write_stream);
      \u001A.\u0080.\u001D\u0005(write_stream, 0U, (byte[]) null, 0U);
      \u001A.\u0080.\u001D\u0005(pd, write_stream, 0U, 0U);
    }

    private static uint \u001D\u0005(byte[] buffer, uint index)
    {
      uint num1 = 0;
      for (int index1 = 0; index1 < 9; int num2 = index1++)
        num1 ^= (uint) buffer[(long) index1 + (long) index] << index1 * 2 % 24;
      return (num1 ^ num1 >> 24) & 16777215U;
    }

    private static void \u001D\u0005(byte[] buffer_orig, uint length_orig, uint[] hash_table, uint[] link_table)
    {
      for (int index = 0; (long) index < 16777216L; ++index)
        hash_table[index] = uint.MaxValue;
      for (int index = 0; (long) index < (long) length_orig; ++index)
        link_table[index] = uint.MaxValue;
      if (length_orig < 9U)
        return;
      for (uint index = 0; (long) index < (long) (buffer_orig.Length - 9); ++index)
      {
        uint num = \u001A.\u0080.\u001D\u0005(buffer_orig, index);
        link_table[(IntPtr) index] = hash_table[(IntPtr) num];
        hash_table[(IntPtr) num] = index;
      }
    }

    private static void \u001D\u0005(\u001C.\u0016 pd, BinaryWriter write_stream, uint offset_orig, Stream stream_orig, Stream stream_new)
    {
      uint length_orig = (uint) \u001F\u001E.\u007E\u0080\u009D((object) stream_orig);
      uint length_new = (uint) \u001F\u001E.\u007E\u0080\u009D((object) stream_new);
      \u0012\u0080.\u007E\u0082\u009D((object) stream_orig, 0L);
      \u0012\u0080.\u007E\u0082\u009D((object) stream_new, 0L);
      byte[] numArray1 = new byte[(IntPtr) length_orig];
      byte[] numArray2 = new byte[(IntPtr) length_new];
      stream_orig.\u001D\u0005(numArray1);
      stream_new.\u001D\u0005(numArray2);
      uint[] link_table = new uint[(IntPtr) length_orig];
      if (pd.\u0001 == null)
        pd.\u0001 = new uint[new IntPtr(16777216)];
      \u001A.\u0080.\u001D\u0005(numArray1, length_orig, pd.\u0001, link_table);
      uint new_pos = 0;
      uint start_pos = new_pos;
      if (length_new >= 9U)
      {
        while (new_pos < length_new - 9U)
        {
          uint copy_pos = 0;
          ushort copy_length = 0;
          \u001A.\u0080.\u001D\u0005(new_pos, ref copy_pos, ref copy_length, pd.\u0001, link_table, numArray1, length_orig, numArray2, length_new);
          if ((int) copy_length < 9)
          {
            ++new_pos;
          }
          else
          {
            int num = (int) new_pos - (int) start_pos;
            \u001A.\u0080.\u001D\u0005(pd, write_stream, (uint) num, numArray2, start_pos, (uint) copy_length, copy_pos + offset_orig);
            new_pos += (uint) copy_length;
            start_pos = new_pos;
          }
        }
      }
      if ((int) start_pos != (int) length_new)
      {
        uint add_length = length_new - start_pos;
        \u001A.\u0080.\u001D\u0005(pd, write_stream, add_length, numArray2, start_pos, 0U, 0U);
        uint num = start_pos + add_length;
      }
    }

    public static void \u001D\u0005(\u001C.\u0016 pd, \u001E.\u0080 type, BinaryWriter write_stream, uint offset_orig, uint offset_new, Stream stream_orig, Stream stream_new)
    {
      switch (type - 1)
      {
        case \u001E.\u0080.\u0001:
          if (!\u007F.\u001D\u0005(stream_orig, stream_new))
          {
            type = \u001E.\u0080.\u0001;
            break;
          }
          break;
        case \u001E.\u0080.\u0002:
          if (!\u001C.\u001A.\u001D\u0005(stream_orig, stream_new))
          {
            type = \u001E.\u0080.\u0001;
            break;
          }
          break;
      }
      switch (type)
      {
        case \u001E.\u0080.\u0002:
          \u007F.\u001D\u0005(pd, write_stream, offset_orig, offset_new, stream_orig, stream_new);
          break;
        case \u001E.\u0080.\u0003:
          \u001C.\u001A.\u001D\u0005(pd, write_stream, offset_orig, offset_new, stream_orig, stream_new);
          break;
        default:
          \u001A.\u0080.\u001D\u0005(pd, write_stream, offset_orig, stream_orig, stream_new);
          break;
      }
    }

    public static void \u001D\u0005(string originalFile, string newFile, string patchFile)
    {
      Stream stream_orig = (Stream) \u008F\u001C.\u0093\u009E(originalFile, FileMode.Open, FileAccess.Read, FileShare.None);
      try
      {
        Stream stream_new = (Stream) \u008F\u001C.\u0093\u009E(newFile, FileMode.Open, FileAccess.Read, FileShare.None);
        try
        {
          Stream stream_patch = (Stream) \u008F\u001C.\u0093\u009E(patchFile, FileMode.Create, FileAccess.Write, FileShare.None);
          try
          {
            \u001A.\u0080.\u001D\u0005(stream_orig, stream_new, stream_patch, \u001A.\u0080.\u001D\u0005(originalFile, newFile));
          }
          finally
          {
            if (stream_patch != null)
              \u001A\u001E.\u007E\u0094\u0092((object) stream_patch);
          }
        }
        finally
        {
          if (stream_new != null)
            \u001A\u001E.\u007E\u0094\u0092((object) stream_new);
        }
      }
      finally
      {
        if (stream_orig != null)
          \u001A\u001E.\u007E\u0094\u0092((object) stream_orig);
      }
    }

    private static \u001E.\u0080 \u001D\u0005(string file1, string file2)
    {
      \u001E.\u0080 obj1 = \u001A.\u0080.\u001D\u0005(file1);
      \u001E.\u0080 obj2 = \u001A.\u0080.\u001D\u0005(file2);
      if (obj1 != obj2)
        return \u001E.\u0080.\u0001;
      return obj1;
    }

    public static \u001E.\u0080 \u001D\u0005(string file)
    {
      \u001E.\u0080 obj;
      string str;
      if ((str = \u0002\u007F.\u007E\u0019\u0093((object) \u009C\u0080.\u0006\u009F(file))) != null)
      {
        if (!\u0008\u001F.\u009A\u0092(str, \u001A.\u0080.\u0001(53738)))
        {
          if (\u0008\u001F.\u009A\u0092(str, \u001A.\u0080.\u0001(51487)))
          {
            obj = \u001E.\u0080.\u0002;
            goto label_6;
          }
        }
        else
        {
          obj = \u001E.\u0080.\u0003;
          goto label_6;
        }
      }
      obj = \u001E.\u0080.\u0001;
label_6:
      return obj;
    }

    private static void \u001D\u0005(Stream stream_orig, Stream stream_new, Stream stream_patch, \u001E.\u0080 type)
    {
      \u0010 obj1 = new \u0010(stream_orig);
      try
      {
        \u0010 obj2 = new \u0010(stream_new);
        try
        {
          \u0010 obj3 = new \u0010(stream_patch);
          try
          {
            BinaryWriter write_stream = new BinaryWriter((Stream) obj3);
            try
            {
              \u001A.\u0080.\u001D\u0005(write_stream, (Stream) obj1, (Stream) obj2);
              \u001C.\u0016 pd = new \u001C.\u0016();
              \u001A.\u0080.\u001D\u0005(pd, type, write_stream, 0U, 0U, (Stream) obj1, (Stream) obj2);
              \u001A.\u0080.\u001E\u0005(pd, write_stream);
              pd.\u0001 = (Queue<byte[]>) null;
              pd.\u0001 = (uint[]) null;
            }
            finally
            {
              if (write_stream != null)
                \u001A\u001E.\u007E\u0094\u0092((object) write_stream);
            }
          }
          finally
          {
            if (obj3 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj3);
          }
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    public void \u001D\u0005(Stream stream_orig, Stream stream_patch, Stream stream_dest)
    {
      this.\u001D\u0005(stream_orig, stream_patch, stream_dest, new uint?(), \u0080.\u0016.\u0001, new uint?(), \u0080.\u0016.\u0001, true, true);
    }

    public void \u001D\u0005(Stream stream_orig, Stream stream_patch, Stream stream_dest, uint? overrideExpectedStartingFileLength, \u0080.\u0016 overrideExpectedStartingHash, uint? overrideExpectedResultingFileLength, \u0080.\u0016 overrideExpectedResultingHash, bool validate_expected, bool validate_result)
    {
      \u0010 obj1 = new \u0010(stream_orig);
      try
      {
        \u0010 obj2 = new \u0010(stream_patch);
        try
        {
          \u0010 stream = new \u0010(stream_dest);
          try
          {
            BinaryReader binaryReader = new BinaryReader((Stream) obj1);
            try
            {
              BinaryReader reader = new BinaryReader((Stream) obj2);
              try
              {
                BinaryWriter binaryWriter = new BinaryWriter((Stream) stream);
                try
                {
                  int num1 = (int) \u0004\u0081.\u007E\u009A\u009D((object) reader);
                  ushort num2 = \u0095\u0084.\u007E\u0098\u009D((object) reader);
                  uint num3 = \u0004\u0081.\u007E\u009A\u009D((object) reader);
                  \u0080.\u0016 val2_1 = \u009F\u001D.\u007E\u0093\u009D((object) reader).\u001D\u0005();
                  uint num4 = \u0004\u0081.\u007E\u009A\u009D((object) reader);
                  \u0080.\u0016 val2_2 = \u009F\u001D.\u007E\u0093\u009D((object) reader).\u001D\u0005();
                  uint num5 = 0;
                  if (validate_expected)
                  {
                    if (\u001F\u001E.\u007E\u0080\u009D((object) obj1) != (long) num3 && (!overrideExpectedStartingFileLength.HasValue || (int) overrideExpectedStartingFileLength.Value != (int) num3))
                      throw new InvalidDataException(\u0014\u0084.\u007F\u0093(\u001A.\u0080.\u0001(53747), (object) \u001F\u001E.\u007E\u0080\u009D((object) obj1), (object) num3));
                    \u0080.\u0016 obj3 = stream_orig.\u001D\u0005();
                    if (\u0080.\u0016.\u001E\u0005(obj3, val2_1) && (\u0080.\u0016.\u001D\u0005(overrideExpectedStartingHash, \u0080.\u0016.\u0001) || \u0080.\u0016.\u001E\u0005(overrideExpectedStartingHash, obj3)))
                      throw new InvalidDataException(\u0014\u0084.\u007F\u0093(\u001A.\u0080.\u0001(53848), (object) obj3, (object) val2_1));
                  }
                  byte[] buffer = new byte[4096];
                  int num6 = 0;
                  uint num7;
                  uint num8;
                  do
                  {
                    ushort num9;
                    num7 = (uint) (num9 = \u0095\u0084.\u007E\u0098\u009D((object) reader));
                    while ((int) num9 > 0 && !reader.\u001D\u0005())
                    {
                      int num10 = reader.Read(buffer, 0, (int) num9 > 4096 ? 4096 : (int) num9);
                      \u0016\u0086.\u007E\u0011\u009E((object) binaryWriter, buffer, 0, num10);
                      num9 -= (ushort) num10;
                      num5 += (uint) (ushort) num10;
                      if (this.\u0001 != null)
                      {
                        int num11 = \u0005.\u001D\u0005((long) num5, (long) num4);
                        if (num6 != num11)
                        {
                          num6 = num11;
                          this.\u0001((object) this, new \u0005((long) num5, (long) num4));
                        }
                      }
                    }
                    ushort num12;
                    num8 = (uint) (num12 = \u0095\u0084.\u007E\u0098\u009D((object) reader));
                    if ((int) num12 > 0)
                    {
                      int num10 = \u0005\u0081.\u007E\u0099\u009D((object) reader);
                      if ((int) num2 < 2)
                      {
                        long num11 = \u0002\u0086.\u007E\u008B\u009D((object) \u009F\u001D.\u007E\u0093\u009D((object) binaryReader), (long) num10, SeekOrigin.Begin);
                      }
                      else
                      {
                        long num13 = \u0002\u0086.\u007E\u008B\u009D((object) \u009F\u001D.\u007E\u0093\u009D((object) binaryReader), (long) num10, SeekOrigin.Current);
                      }
                      while ((int) num12 > 0 && !reader.\u001D\u0005())
                      {
                        int num14 = binaryReader.Read(buffer, 0, (int) num12 > 4096 ? 4096 : (int) num12);
                        \u0016\u0086.\u007E\u0011\u009E((object) binaryWriter, buffer, 0, num14);
                        num12 -= (ushort) num14;
                        num5 += (uint) (ushort) num14;
                        if (this.\u0001 != null)
                        {
                          int num15 = \u0005.\u001D\u0005((long) num5, (long) num4);
                          if (num6 != num15)
                          {
                            num6 = num15;
                            this.\u0001((object) this, new \u0005((long) num5, (long) num4));
                          }
                        }
                      }
                    }
                  }
                  while ((int) num8 != 0 || (int) num7 != 0);
                  if (!validate_result)
                    return;
                  if (\u001F\u001E.\u007E\u0080\u009D((object) stream) != (long) num4)
                  {
                    if (overrideExpectedResultingFileLength.HasValue)
                    {
                      uint? nullable = overrideExpectedResultingFileLength;
                      long num9 = \u001F\u001E.\u007E\u0080\u009D((object) stream);
                      if (((long) nullable.GetValueOrDefault() != num9 ? 1 : (!nullable.HasValue ? 1 : 0)) == 0)
                        goto label_31;
                    }
                    throw new InvalidDataException(\u0014\u0084.\u007F\u0093(\u001A.\u0080.\u0001(53945), (object) \u001F\u001E.\u007E\u0080\u009D((object) stream), (object) num4));
                  }
label_31:
                  \u0080.\u0016 obj4 = stream.\u001D\u0005();
                  if (\u0080.\u0016.\u001E\u0005(obj4, val2_2) && (\u0080.\u0016.\u001D\u0005(overrideExpectedResultingHash, \u0080.\u0016.\u0001) || \u0080.\u0016.\u001E\u0005(overrideExpectedResultingHash, obj4)))
                    throw new InvalidDataException(\u0014\u0084.\u007F\u0093(\u001A.\u0080.\u0001(54054), (object) obj4, (object) val2_2));
                }
                finally
                {
                  if (binaryWriter != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) binaryWriter);
                }
              }
              finally
              {
                if (reader != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) reader);
              }
            }
            finally
            {
              if (binaryReader != null)
                \u001A\u001E.\u007E\u0094\u0092((object) binaryReader);
            }
          }
          finally
          {
            if (stream != null)
              \u001A\u001E.\u007E\u0094\u0092((object) stream);
          }
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    public static void \u001D\u0005(Stream compressed_patch_stream, string destination_file, uint? overrideExpectedStartingFileLength, \u0080.\u0016 overrideExpectedStartingHash, uint? overrideExpectedResultingFileLength, \u0080.\u0016 overrideExpectedResultingHash, EventHandler<\u0005> progressChanged)
    {
      string destination_file1 = \u0081\u0086.\u0086\u0093(destination_file, \u001A.\u0080.\u0001(54143));
      try
      {
        MemoryStream memoryStream = new MemoryStream();
        try
        {
          \u0018.\u0018.\u001D\u0005(compressed_patch_stream, (Stream) memoryStream, false);
          \u0012\u0080.\u007E\u0082\u009D((object) memoryStream, 0L);
          \u0012.\u001D\u0005(destination_file, destination_file1, true);
          Stream stream_orig = (Stream) \u008F\u001C.\u0093\u009E(destination_file1, FileMode.Open, FileAccess.Read, FileShare.None);
          try
          {
            Stream stream_dest = (Stream) \u008F\u001C.\u0093\u009E(destination_file, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
            try
            {
              \u001A.\u0080 obj = new \u001A.\u0080();
              if (progressChanged != null)
                obj.ProgressChanged += progressChanged;
              obj.\u001D\u0005(stream_orig, (Stream) memoryStream, stream_dest, overrideExpectedStartingFileLength, overrideExpectedStartingHash, overrideExpectedResultingFileLength, overrideExpectedResultingHash, false, false);
            }
            finally
            {
              if (stream_dest != null)
                \u001A\u001E.\u007E\u0094\u0092((object) stream_dest);
            }
          }
          finally
          {
            if (stream_orig != null)
              \u001A\u001E.\u007E\u0094\u0092((object) stream_orig);
          }
        }
        finally
        {
          if (memoryStream != null)
            \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
        }
      }
      finally
      {
        if (\u008F\u0084.\u0092\u009E(destination_file1))
          \u009C\u001F.\u0091\u009E(destination_file1);
      }
    }
  }
}
