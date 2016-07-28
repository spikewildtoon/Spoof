// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u001A;
using \u001D;
using \u001E;
using \u0081;
using \u0082;
using \u0083;
using \u0084;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using TSN.Native.Enums;

namespace \u0081
{
  [ComVisible(true)]
  [EventTrackingEnabled(true)]
  internal sealed class \u001B : ServicedComponent
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly int \u0001;
    private static Dictionary<string, string> \u0001;
    private static Dictionary<byte, string> \u0001;

    static \u001B()
    {
      \u0004.\u001D\u0005(typeof (\u001B));
      \u001B.\u0001 = \u001B.\u0001(95591);
      \u001B.\u0002 = \u001B.\u0001(95608);
      \u001B.\u0001 = 260;
      \u001B.\u0001 = new Dictionary<byte, string>();
    }

    private static Dictionary<string, string> \u001D\u0005()
    {
      string[] strArray = \u009B\u0080.\u0097\u0095();
      Dictionary<string, string> dictionary = new Dictionary<string, string>(strArray.Length);
      StringBuilder lpTargetPath = new StringBuilder(\u001B.\u0001);
      foreach (string str in strArray)
      {
        string lpDeviceName = \u0084\u0080.\u007E\u0006\u0093((object) str, 0, 2);
        \u000E.\u001D\u0005(lpDeviceName, lpTargetPath, \u001B.\u0001);
        dictionary.Add(\u001B.\u001D\u0005(\u0002\u007F.\u007E\u0087\u0091((object) lpTargetPath)), lpDeviceName);
      }
      dictionary.Add(\u0084\u0080.\u007E\u0006\u0093((object) \u001B.\u0002, 0, \u0005\u0081.\u007E\u0001\u0093((object) \u001B.\u0002) - 1), \u001B.\u0001(29983));
      return dictionary;
    }

    private static string \u001D\u0005(string deviceName)
    {
      if (\u001A\u0086.\u000E\u0093(deviceName, 0, \u001B.\u0002, 0, \u0005\u0081.\u007E\u0001\u0093((object) \u001B.\u0002), StringComparison.InvariantCulture) != 0)
        return deviceName;
      string str = \u009C\u007F.\u007E\u0005\u0093((object) deviceName, \u001C\u0081.\u007E\u0013\u0093((object) deviceName, '\\', \u0005\u0081.\u007E\u0001\u0093((object) \u001B.\u0002)) + 1);
      return \u0081\u0086.\u0086\u0093(\u001B.\u0002, str);
    }

    public static List<FileSystemInfo> \u001D\u0005(int processID)
    {
      ThreadStart start = (ThreadStart) null;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001B.\u0002 obj = new \u001B.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = processID;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = new List<FileSystemInfo>();
      try
      {
        if (start == null)
          goto label_5;
label_2:
        Thread thread = new Thread(start);
        \u0099\u001F.\u007E\u0091\u0098((object) thread, true);
        \u001A\u001E.\u007E\u008A\u0098((object) thread);
        if (!\u0095\u0081.\u007E\u008E\u0098((object) thread, 5000))
          \u001A\u001E.\u007E\u008B\u0098((object) thread);
        // ISSUE: reference to a compiler-generated field
        return obj.\u0001.Distinct<FileSystemInfo>((IEqualityComparer<FileSystemInfo>) new \u0019()).ToList<FileSystemInfo>();
label_5:
        // ISSUE: method pointer
        start = new ThreadStart((object) obj, __methodptr(\u001D\u0005));
        goto label_2;
      }
      catch (Exception ex)
      {
        // ISSUE: reference to a compiler-generated field
        ex.\u001D\u0005((object) \u0081\u0086.\u0086\u0093(\u001B.\u0001, obj.\u0001.ToString()));
        return (List<FileSystemInfo>) null;
      }
    }

    public static IEnumerator<FileSystemInfo> \u001D\u0005(uint processId)
    {
      Dictionary<string, string> dictionary = \u001B.\u001D\u0005();
      Interlocked.Exchange<Dictionary<string, string>>(ref \u001B.\u0001, dictionary);
      IntPtr num1 = \u000E.\u001F\u0005();
      bool remote = (long) processId != (long) \u000E.\u001D\u0005(num1);
      ushort num2 = (ushort) processId;
      int SystemInformationLength = 65536;
      NtStatus ntStatus;
      do
      {
        IntPtr SystemInformation = IntPtr.Zero;
        \u0088\u0081.\u001B\u009F();
        \u0088\u0081.\u001B\u009F();
        try
        {
        }
        finally
        {
          SystemInformation = \u001D\u001E.\u0018\u009D(SystemInformationLength);
        }
        int ReturnLength;
        ntStatus = \u000E.\u001D\u0005(\u001F.\u0006, SystemInformation, SystemInformationLength, out ReturnLength);
        switch (ntStatus)
        {
          case NtStatus.InfoLengthMismatch:
            SystemInformationLength = ReturnLength + (int) ushort.MaxValue & -65536;
            break;
          case NtStatus.Success:
            long num3;
            long num4;
            if (\u0006\u0083.\u0088\u0096() == 8)
            {
              num4 = \u0086\u001E.\u0011\u009D(SystemInformation);
              num3 = SystemInformation.ToInt64();
            }
            else
            {
              num4 = (long) \u0012\u0081.\u0010\u009D(SystemInformation);
              num3 = (long) SystemInformation.ToInt32();
            }
            int num5 = \u0006\u0083.\u0088\u0096();
            // ISSUE: type reference
            int num6 = \u0082\u001D.\u0005\u009D(\u009C\u0082.\u0016\u0097(__typeref (\u0008)));
            for (long index = 0; index < num4; ++index)
            {
              // ISSUE: type reference
              \u0008 obj = (\u0008) \u000F\u001E.\u0014\u009D(new IntPtr(num3 + (long) num5), \u009C\u0082.\u0016\u0097(__typeref (\u0008)));
              if ((int) (ushort) obj.\u0001 == (int) num2)
              {
                IntPtr handle = \u001D\u001E.\u0080\u0096((int) obj.\u0001);
                string token;
                string fileName;
                string dosPath;
                // ISSUE: reference to a compiler-generated field
                if (\u001B.\u001D\u0005(handle, processId, obj.\u0001, num1, remote, out token) && \u0008\u001F.\u009A\u0092(token, \u001B.\u0003.\u0001(108230)) && (\u001B.\u001D\u0005(handle, processId, num1, remote, out fileName) && \u001B.\u001D\u0005(fileName, out dosPath)))
                {
                  if (\u008F\u0084.\u0092\u009E(dosPath))
                    yield return (FileSystemInfo) new FileInfo(dosPath);
                  else if (\u008F\u0084.\u001D\u009E(dosPath))
                    yield return (FileSystemInfo) new DirectoryInfo(dosPath);
                }
              }
              num5 += num6;
            }
            break;
        }
        // ISSUE: reference to a compiler-generated method
        this.\u001F\u0005();
      }
      while (ntStatus == NtStatus.InfoLengthMismatch);
    }

    private static bool \u001D\u0005(IntPtr handle, uint processId, IntPtr currentProcess, bool remote, out string fileName)
    {
      \u0082.\u0082 obj = (\u0082.\u0082) null;
      \u0017 lpTargetHandle = (\u0017) null;
      try
      {
        if (remote)
        {
          obj = \u000E.\u001D\u0005(\u0011.\u0001, true, processId);
          if (\u000E.\u001D\u0005(\u0088\u0086.\u007E\u0094\u0097((object) obj), handle, currentProcess, out lpTargetHandle, 0, false, \u0083.\u0081.\u0002))
            handle = \u0088\u0086.\u007E\u0094\u0097((object) lpTargetHandle);
        }
        return \u001B.\u001D\u0005(handle, out fileName, 200);
      }
      finally
      {
        if (remote)
        {
          if (obj != null)
          {
            \u001A\u001E.\u007E\u0096\u0097((object) obj);
            \u001A\u001E.\u007E\u0097\u0097((object) obj);
          }
          if (lpTargetHandle != null)
          {
            \u001A\u001E.\u007E\u0096\u0097((object) lpTargetHandle);
            \u001A\u001E.\u007E\u0097\u0097((object) lpTargetHandle);
          }
        }
      }
    }

    private static bool \u001D\u0005(IntPtr handle, out string fileName, int wait)
    {
      \u001B.\u0001 obj = new \u001B.\u0001(handle);
      // ISSUE: method pointer
      Thread thread = new Thread(new ThreadStart((object) obj, __methodptr(\u001D\u0005)));
      \u0099\u001F.\u007E\u0091\u0098((object) thread, true);
      \u001A\u001E.\u007E\u008A\u0098((object) thread);
      if (\u0095\u0081.\u007E\u008E\u0098((object) thread, wait))
      {
        fileName = obj.\u0001;
        return obj.\u0001;
      }
      try
      {
        \u001A\u001E.\u007E\u008B\u0098((object) thread);
      }
      catch
      {
      }
      fileName = string.Empty;
      return false;
    }

    private static bool \u001D\u0005(IntPtr handle, out string fileName)
    {
      IntPtr ObjectInformation = IntPtr.Zero;
      \u0088\u0081.\u001B\u009F();
      try
      {
        int ReturnLength = 512;
        \u0088\u0081.\u001B\u009F();
        try
        {
        }
        finally
        {
          ObjectInformation = \u001D\u001E.\u0018\u009D(ReturnLength);
        }
        NtStatus ntStatus = \u000E.\u001D\u0005(handle, \u0007.\u0002, ObjectInformation, ReturnLength, out ReturnLength);
        if (ntStatus == NtStatus.BufferOverflow)
        {
          \u0088\u0081.\u001B\u009F();
          try
          {
          }
          finally
          {
            \u008D\u0082.\u0019\u009D(ObjectInformation);
            ObjectInformation = \u001D\u001E.\u0018\u009D(ReturnLength);
          }
          ntStatus = \u000E.\u001D\u0005(handle, \u0007.\u0002, ObjectInformation, ReturnLength, out ReturnLength);
        }
        if (ntStatus == NtStatus.Success)
        {
          fileName = \u0005\u0080.\u0003\u009D(\u001D\u001E.\u0080\u0096(\u0012\u0081.\u0084\u0096(ObjectInformation) + 8), (ReturnLength - 9) / 2);
          return \u0005\u0081.\u007E\u0001\u0093((object) fileName) != 0;
        }
      }
      finally
      {
        \u008D\u0082.\u0019\u009D(ObjectInformation);
      }
      fileName = string.Empty;
      return false;
    }

    private static bool \u001D\u0005(IntPtr handle, uint processId, byte objectType, IntPtr currentProcess, bool remote, out string token)
    {
      token = (string) null;
      if (\u001B.\u0001.ContainsKey(objectType))
      {
        token = \u001B.\u0001[objectType];
        return true;
      }
      if (!\u001B.\u001E\u0005(handle, processId, currentProcess, remote, out token))
        return false;
      \u001B.\u0001.Add(objectType, token);
      return true;
    }

    private static bool \u001E\u0005(IntPtr handle, uint processId, IntPtr currentProcess, bool remote, out string token)
    {
      \u0082.\u0082 obj = (\u0082.\u0082) null;
      \u0017 lpTargetHandle = (\u0017) null;
      try
      {
        if (remote)
        {
          obj = \u000E.\u001D\u0005(\u0011.\u0001, true, processId);
          if (\u000E.\u001D\u0005(\u0088\u0086.\u007E\u0094\u0097((object) obj), handle, currentProcess, out lpTargetHandle, 0, false, \u0083.\u0081.\u0002))
            handle = \u0088\u0086.\u007E\u0094\u0097((object) lpTargetHandle);
        }
        return \u001B.\u001E\u0005(handle, out token);
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0096\u0097((object) obj);
        if (lpTargetHandle != null)
          \u001A\u001E.\u007E\u0096\u0097((object) lpTargetHandle);
      }
    }

    private static bool \u001E\u0005(IntPtr handle, out string token)
    {
      IntPtr ObjectInformation = IntPtr.Zero;
      int ReturnLength = 0;
      token = (string) null;
      if (\u000E.\u001D\u0005(handle, \u0007.\u0003, IntPtr.Zero, 0, out ReturnLength) == NtStatus.InvalidHandle)
        return false;
      \u0088\u0081.\u001B\u009F();
      try
      {
        \u0088\u0081.\u001B\u009F();
        try
        {
        }
        finally
        {
          ObjectInformation = \u001D\u001E.\u0018\u009D(ReturnLength);
        }
        NtStatus status = \u000E.\u001D\u0005(handle, \u0007.\u0003, ObjectInformation, ReturnLength, out ReturnLength);
        if (status.\u001D\u0005() || status.\u007F\u0005())
          return false;
        // ISSUE: type reference
        \u0019 obj = (\u0019) \u000F\u001E.\u0014\u009D(ObjectInformation, \u009C\u0082.\u0016\u0097(__typeref (\u0019)));
        token = obj.\u0001.\u001D\u0005();
        return true;
      }
      finally
      {
        \u008D\u0082.\u0019\u009D(ObjectInformation);
      }
    }

    private static bool \u001D\u0005(string devicePath, out string dosPath)
    {
      int num = \u0005\u0081.\u007E\u0001\u0093((object) devicePath);
      while (num > 0 && (num = \u001C\u0081.\u007E\u0016\u0093((object) devicePath, '\\', num - 1)) != -1)
      {
        string str;
        if (\u001B.\u0001.TryGetValue(\u0084\u0080.\u007E\u0006\u0093((object) devicePath, 0, num), out str))
        {
          dosPath = \u0081\u0086.\u0086\u0093(str, \u009C\u007F.\u007E\u0005\u0093((object) devicePath, num));
          return \u0005\u0081.\u007E\u0001\u0093((object) dosPath) != 0;
        }
      }
      dosPath = string.Empty;
      return false;
    }

    private sealed class \u0001
    {
      public readonly IntPtr \u0001;
      public string \u0001;
      public bool \u0001;

      public \u0001(IntPtr handle)
      {
        this.\u0001 = handle;
      }

      public void \u001D\u0005()
      {
        this.\u0001 = \u001B.\u001D\u0005(this.\u0001, out this.\u0001);
      }
    }
  }
}
