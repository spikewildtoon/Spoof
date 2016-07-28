// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u0018;
using \u001A;
using \u0083;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace \u0018
{
  internal sealed class \u000F : \u0016
  {
    private static Dictionary<Type, int> \u0001 = new Dictionary<Type, int>();

    public IntPtr Memory { get; private set; }

    public int Size { get; private set; }

    public \u000F(IntPtr memory)
      : this(memory, 0)
    {
    }

    public \u000F(IntPtr memory, int offset)
      : this(memory, offset, 0)
    {
    }

    public \u000F(IntPtr memory, int offset, int size)
    {
      this.Memory = memory.\u001E\u0005(offset);
      this.Size = size;
    }

    private static int \u001D\u0005(Type structType)
    {
      bool flag = false;
      Dictionary<Type, int> dictionary;
      try
      {
        \u0098\u0082.\u0081\u0098((object) (dictionary = \u000F.\u0001), ref flag);
        int num;
        if (\u000F.\u0001.ContainsKey(structType))
          num = \u000F.\u0001[structType];
        else
          \u000F.\u0001.Add(structType, num = \u0082\u001D.\u0005\u009D(structType));
        return num;
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098((object) dictionary);
      }
    }

    [SpecialName]
    public static IntPtr \u001D\u0005(\u000F memory)
    {
      return memory.Memory;
    }

    [SpecialName]
    public static unsafe void* \u001D\u0005(\u000F memory)
    {
      return memory.Memory.ToPointer();
    }

    protected override void \u001D\u0005()
    {
      this.Memory = IntPtr.Zero;
      this.Size = 0;
      base.\u001D\u0005();
    }

    public void \u001D\u0005<T>()
    {
      this.\u001D\u0005<T>(0);
    }

    public void \u001D\u0005<T>(int index)
    {
      this.\u001D\u0005<T>(0, index);
    }

    public void \u001D\u0005<T>(int offset, int index)
    {
      if (index == 0)
      {
        // ISSUE: type reference
        \u001C\u0082.\u0015\u009D(this.Memory.\u001E\u0005(offset), \u009C\u0082.\u0016\u0097(__typeref (T)));
      }
      else
      {
        // ISSUE: type reference
        // ISSUE: type reference
        \u001C\u0082.\u0015\u009D(this.Memory.\u001E\u0005(offset + \u000F.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (T))) * index), \u009C\u0082.\u0016\u0097(__typeref (T)));
      }
    }

    public static T \u001D\u0005<T>(IntPtr ptr)
    {
      // ISSUE: type reference
      return (T) \u000F\u001E.\u0014\u009D(ptr, \u009C\u0082.\u0016\u0097(__typeref (T)));
    }

    public string \u001D\u0005(int offset)
    {
      return \u0006\u0080.\u0001\u009D(this.Memory.\u001E\u0005(offset));
    }

    public string \u001D\u0005(int offset, int length)
    {
      return \u0005\u0080.\u0002\u009D(this.Memory.\u001E\u0005(offset), length);
    }

    public byte[] \u001D\u0005(int length)
    {
      return this.\u001D\u0005(0, length);
    }

    public byte[] \u001D\u0005(int offset, int length)
    {
      byte[] buffer = new byte[length];
      this.\u001D\u0005(offset, buffer, 0, length);
      return buffer;
    }

    public void \u001D\u0005(byte[] buffer, int startIndex, int length)
    {
      this.\u001D\u0005(0, buffer, startIndex, length);
    }

    public void \u001D\u0005(int offset, byte[] buffer, int startIndex, int length)
    {
      \u009B\u001B.\u000F\u009D(this.Memory.\u001E\u0005(offset), buffer, startIndex, length);
    }

    public int \u001D\u0005(int offset)
    {
      return this.\u001D\u0005(offset, 0);
    }

    public unsafe int \u001D\u0005(int offset, int index)
    {
      return *(int*) ((IntPtr) \u008D\u0080.\u0083\u0096(this.Memory) + offset + (IntPtr) index * 4);
    }

    public int[] \u001D\u0005(int offset, int count)
    {
      int[] numArray = new int[count];
      \u008A\u0080.\u000E\u009D(this.Memory.\u001E\u0005(offset), numArray, 0, count);
      return numArray;
    }

    public IntPtr \u001D\u0005(int offset)
    {
      return this.\u001D\u0005(offset, 0);
    }

    public unsafe IntPtr \u001D\u0005(int offset, int index)
    {
      return *(IntPtr*) ((IntPtr) \u008D\u0080.\u0083\u0096(this.Memory) + offset + (IntPtr) index * sizeof (IntPtr));
    }

    public void \u001D\u0005(IntPtr buffer, int destOffset, int srcOffset, int length)
    {
      \u000E.\u001D\u0005(buffer.\u001E\u0005(destOffset), this.Memory.\u001E\u0005(srcOffset), length.\u001D\u0005());
    }

    public uint \u001D\u0005(int offset)
    {
      return this.\u001D\u0005(offset, 0);
    }

    public unsafe uint \u001D\u0005(int offset, int index)
    {
      return *(uint*) ((IntPtr) \u008D\u0080.\u0083\u0096(this.Memory) + offset + (IntPtr) index * 4);
    }

    public T \u001D\u0005<T>() where T : struct
    {
      return this.\u001D\u0005<T>(0);
    }

    public T \u001D\u0005<T>(int index) where T : struct
    {
      return this.\u001D\u0005<T>(0, index);
    }

    public T \u001D\u0005<T>(int offset, int index) where T : struct
    {
      if (index == 0)
      {
        // ISSUE: type reference
        return (T) \u000F\u001E.\u0014\u009D(this.Memory.\u001E\u0005(offset), \u009C\u0082.\u0016\u0097(__typeref (T)));
      }
      // ISSUE: type reference
      // ISSUE: type reference
      return (T) \u000F\u001E.\u0014\u009D(this.Memory.\u001E\u0005(offset + \u000F.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (T))) * index), \u009C\u0082.\u0016\u0097(__typeref (T)));
    }

    public string \u001E\u0005(int offset)
    {
      return \u0006\u0080.\u0004\u009D(this.Memory.\u001E\u0005(offset));
    }

    public string \u001E\u0005(int offset, int length)
    {
      return \u0005\u0080.\u0003\u009D(this.Memory.\u001E\u0005(offset), length);
    }

    public void \u001D\u0005(int offset, int length, byte value)
    {
      \u000E.\u001D\u0005(this.Memory.\u001E\u0005(offset), length.\u001D\u0005(), value);
    }

    public unsafe void \u001D\u0005(int offset, byte b)
    {
      *(sbyte*) ((IntPtr) \u008D\u0080.\u0083\u0096(this.Memory) + offset) = (sbyte) b;
    }

    public void \u001D\u0005(int offset, byte[] b)
    {
      \u0089\u0080.\u0008\u009D(b, 0, this.Memory.\u001E\u0005(offset), b.Length);
    }

    public unsafe void \u001D\u0005(int offset, short i)
    {
      *(short*) ((IntPtr) \u008D\u0080.\u0083\u0096(this.Memory) + offset) = i;
    }

    public unsafe void \u001D\u0005(int offset, int i)
    {
      *(int*) ((IntPtr) \u008D\u0080.\u0083\u0096(this.Memory) + offset) = i;
    }

    public unsafe void \u001D\u0005(int offset, IntPtr i)
    {
      *(IntPtr*) ((IntPtr) \u008D\u0080.\u0083\u0096(this.Memory) + offset) = i;
    }

    public void \u001D\u0005(int offset, IntPtr buffer, int length)
    {
      \u000E.\u001D\u0005(this.Memory.\u001E\u0005(offset), buffer, length.\u001D\u0005());
    }

    public void \u001D\u0005<T>(T s) where T : struct
    {
      this.\u001D\u0005<T>(0, s);
    }

    public void \u001D\u0005<T>(int index, T s) where T : struct
    {
      this.\u001D\u0005<T>(0, index, s);
    }

    public void \u001D\u0005<T>(int offset, int index, T s) where T : struct
    {
      if (index == 0)
      {
        \u0090\u0084.\u0013\u009D((object) s, this.Memory.\u001E\u0005(offset), false);
      }
      else
      {
        // ISSUE: type reference
        \u0090\u0084.\u0013\u009D((object) s, this.Memory.\u001E\u0005(offset + \u000F.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (T))) * index), false);
      }
    }

    public unsafe void \u001D\u0005(int offset, string s)
    {
      string str = s;
      IntPtr num1 = (IntPtr) str;
      if (num1 != IntPtr.Zero)
      {
        int num2 = \u0006\u0083.\u001A\u009F();
        num1 += (IntPtr) num2;
      }
      char* chPtr = (char*) num1;
      this.\u001D\u0005(offset, \u009B\u0083.\u0082\u0096((void*) chPtr), \u0005\u0081.\u007E\u0001\u0093((object) s) * 2);
      str = (string) null;
    }

    public void \u001E\u0005(int offset, int length)
    {
      \u000E.\u001D\u0005(this.Memory.\u001E\u0005(offset), length.\u001D\u0005());
    }
  }
}
