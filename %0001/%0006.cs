// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace \u0001
{
  internal sealed class \u0006
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static string \u0001;
    private static string \u0002;
    private static byte[] \u0001;
    private static Hashtable \u0001;
    private static bool \u0001;
    private static int \u0001;

    static \u0006()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u0006)));
      \u0006.\u0001 = "1";
      \u0006.\u0002 = "171";
      \u0006.\u0001 = (byte[]) null;
      \u0006.\u0001 = (Hashtable) null;
      \u0006.\u0001 = false;
      \u0006.\u0001 = 0;
      if (\u0008\u001F.\u009A\u0092(\u0006.\u0001, "1"))
      {
        \u0006.\u0001 = true;
        \u0006.\u0001 = new Hashtable();
      }
      \u0006.\u0001 = \u0095\u0082.\u001B\u0095(\u0006.\u0002);
      Assembly assembly = \u0006\u007F.\u001D\u009B();
      Stream stream = \u009A\u001D.\u007E\u007F\u009B((object) assembly, "{b039a871-4cc9-4341-8b41-ac2e69db4046}");
      try
      {
        int num1 = \u0090\u0082.\u0019\u0095(\u001F\u001E.\u007E\u0080\u009D((object) stream));
        byte[] numArray = new byte[(int) checked ((uint) num1)];
        int num2 = \u0080\u0081.\u007E\u008D\u009D((object) stream, numArray, 0, num1);
        \u0006.\u0001 = \u000E.\u001D\u0005(numArray);
        \u001A\u001E.\u007E\u0084\u009D((object) stream);
      }
      finally
      {
        if (stream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) stream);
      }
    }

    public static string \u001D\u0005([In] int obj0)
    {
      obj0 -= \u0006.\u0001;
      if (\u0006.\u0001)
      {
        string str = (string) \u008B\u001D.\u007E\u0095\u0099((object) \u0006.\u0001, (object) obj0);
        switch (str)
        {
          case null:
            break;
          default:
            return str;
        }
      }
      int num1 = obj0;
      byte[] numArray1 = \u0006.\u0001;
      int index1 = num1;
      int num2 = 1;
      int num3 = index1 + num2;
      int num4 = (int) numArray1[index1];
      int num5;
      if ((num4 & 128) == 0)
      {
        num5 = num4;
        if (num5 == 0)
          return string.Empty;
      }
      else if ((num4 & 64) == 0)
      {
        num5 = ((num4 & 63) << 8) + (int) \u0006.\u0001[num3++];
      }
      else
      {
        int num6 = (num4 & 31) << 24;
        byte[] numArray2 = \u0006.\u0001;
        int index2 = num3;
        int num7 = 1;
        int num8 = index2 + num7;
        int num9 = (int) numArray2[index2] << 16;
        int num10 = num6 + num9;
        byte[] numArray3 = \u0006.\u0001;
        int index3 = num8;
        int num11 = 1;
        int num12 = index3 + num11;
        int num13 = (int) numArray3[index3] << 8;
        int num14 = num10 + num13;
        byte[] numArray4 = \u0006.\u0001;
        int index4 = num12;
        int num15 = 1;
        num3 = index4 + num15;
        int num16 = (int) numArray4[index4];
        num5 = num14 + num16;
      }
      try
      {
        byte[] numArray2 = \u000F\u007F.\u007F\u0095(\u001E\u007F.\u007E\u0019\u009C((object) \u001D\u001F.\u001B\u009C(), \u0006.\u0001, num3, num5));
        string str = \u009C\u0080.\u008A\u0093(\u001E\u007F.\u007E\u0019\u009C((object) \u001D\u001F.\u001B\u009C(), numArray2, 0, numArray2.Length));
        if (\u0006.\u0001)
        {
          try
          {
            \u001E\u0081.\u007E\u0093\u0099((object) \u0006.\u0001, (object) obj0, (object) str);
          }
          catch
          {
          }
        }
        return str;
      }
      catch
      {
        return (string) null;
      }
    }
  }
}
