// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0018;
using \u0019;
using \u001A;
using \u001D;
using \u001E;
using \u007F;
using \u0080;
using \u0081;
using \u0082;
using \u0083;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;

namespace \u001A
{
  internal static class \u001D
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    private static readonly string \u0007;
    private static readonly string \u0008;
    private static readonly string \u000E;
    private static readonly string \u000F;
    private static readonly string \u0010;
    private static readonly string \u0011;
    private static readonly string \u0012;
    private static readonly string \u0013;
    private static readonly string \u0014;
    private static readonly string \u0015;
    private static readonly string \u0016;
    private static readonly string \u0017;
    private static readonly string \u0018;
    private static readonly int \u0001;
    public static Icon \u0001;

    public static Icon Icon
    {
      get
      {
        return \u001A.\u001D.\u0001;
      }
    }

    static \u001D()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u001A.\u001D)));
      \u001A.\u001D.\u0001 = \u001A.\u001D.\u0001(51504);
      \u001A.\u001D.\u0002 = \u001A.\u001D.\u0001(51870);
      \u001A.\u001D.\u0003 = \u001A.\u001D.\u0001(51891);
      \u001A.\u001D.\u0004 = \u001A.\u001D.\u0001(52089);
      \u001A.\u001D.\u0005 = \u001A.\u001D.\u0001(52130);
      \u001A.\u001D.\u0006 = \u001A.\u001D.\u0001(52227);
      \u001A.\u001D.\u0007 = \u001A.\u001D.\u0001(52324);
      \u001A.\u001D.\u0008 = \u001A.\u001D.\u0001(52429);
      \u001A.\u001D.\u000E = \u001A.\u001D.\u0001(52446);
      \u001A.\u001D.\u000F = \u001A.\u001D.\u0001(52551);
      \u001A.\u001D.\u0010 = \u001A.\u001D.\u0001(52584);
      \u001A.\u001D.\u0011 = \u001A.\u001D.\u0001(52629);
      \u001A.\u001D.\u0012 = \u001A.\u001D.\u0001(52867);
      \u001A.\u001D.\u0013 = \u001A.\u001D.\u0001(52900);
      \u001A.\u001D.\u0014 = \u001A.\u001D.\u0001(52929);
      \u001A.\u001D.\u0015 = \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u001A.\u001D.\u0014, new object[1]
      {
        (object) \u0008.Current.Guid
      });
      \u001A.\u001D.\u0016 = \u0081\u0086.\u0086\u0093(\u001A.\u001D.\u0015, \u001A.\u001D.\u0001(52966));
      \u001A.\u001D.\u0017 = \u001A.\u001D.\u0001(52975);
      \u001A.\u001D.\u0018 = \u001A.\u001D.\u0001(52988);
      \u001A.\u001D.\u0001 = 12;
    }

    [STAThread]
    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
    private static void \u001D\u0005()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001D.\u0001 obj1 = new \u001A.\u001D.\u0001();
      \u0088\u0081.\u0012\u0083();
      \u0095\u0083.\u0016\u0083(false);
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = (Mutex) null;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = (MemoryMappedFile) null;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0002 = (Mutex) null;
      \u0082\u007F obj2 = \u0082\u007F.\u007E\u0094\u0098;
      Thread thread = \u007F\u0080.\u0090\u0098();
      CultureInfo cultureInfo1;
      \u0082\u007F.\u007E\u0093\u0098((object) \u007F\u0080.\u0090\u0098(), cultureInfo1 = \u0013.\u0001);
      CultureInfo cultureInfo2 = cultureInfo1;
      obj2((object) thread, cultureInfo2);
      \u001E.\u0018 obj3 = new \u001E.\u0018(\u001A.\u007F.\u0017);
      \u001E.\u001D.Logger = (\u0015) obj3;
      obj3.LogFileCompressed += (EventHandler<\u0014>) ((obj, arg) => \u0081.\u0080.Instance.CreatedFileArchive.\u001E\u0005(arg.CompressedFilePath));
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      obj1.\u0001 = new Action(obj1.\u001D\u0005);
      // ISSUE: reference to a compiler-generated field
      obj1.\u0002 = false;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      obj1.\u0002 = new Action(obj1.\u001E\u0005);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      obj1.\u0003 = new Action(obj1.\u001F\u0005);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      obj1.\u0001 = new Action<Exception, string>(obj1.\u001D\u0005);
      // ISSUE: reference to a compiler-generated method
      UnhandledExceptionEventHandler exceptionEventHandler1 = new UnhandledExceptionEventHandler(obj1.\u001D\u0005);
      \u009C\u001E.\u007E\u0091\u0094((object) \u0082\u0081.\u008F\u0094(), exceptionEventHandler1);
      // ISSUE: reference to a compiler-generated method
      ThreadExceptionEventHandler exceptionEventHandler2 = new ThreadExceptionEventHandler(obj1.\u001D\u0005);
      \u0084\u0083.\u0010\u0083(exceptionEventHandler2);
      \u009E\u001F.\u0017\u0083(UnhandledExceptionMode.CatchException);
      \u0016.\u0081 obj4 = \u0015\u007F.\u009A\u0095().\u001D\u0005();
      if (obj4 > \u0016.\u0081.\u0001)
      {
        if (obj4 < \u0016.\u0081.\u0010)
        {
          \u0017.\u001D\u0005(\u001A.\u001D.\u0003, \u001A.\u001D.\u0004);
          \u0088\u0081.\u0013\u0083();
          return;
        }
      }
      try
      {
        try
        {
          // ISSUE: reference to a compiler-generated field
          obj1.\u0002 = new Mutex(false, \u001A.\u001D.\u0016);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (!(obj1.\u0001 = \u0099\u0082.\u007E\u001A\u0098((object) obj1.\u0002)))
          {
            \u001E\u001E.\u0091\u0095(1);
            \u0088\u0081.\u0013\u0083();
          }
          else if (\u000E.\u001D\u0005(\u001A.\u001D.\u0015))
          {
            \u001A.\u001D.\u001E\u0005();
            \u001E\u001E.\u0091\u0095(1);
            \u0088\u0081.\u0013\u0083();
          }
          else if (\u0012.Current.Flags.Contains(\u001A.\u001D.\u0017))
          {
            \u001E\u001E.\u0091\u0095(0);
            \u0088\u0081.\u0013\u0083();
          }
          else if (\u0012.Current.Flags.Contains(\u001A.\u001D.\u0018))
          {
            if (\u0017.\u001E\u0005(\u001A.\u001D.\u0007, \u001A.\u001D.\u0008, \u0018.\u0016.\u0006, \u0018.\u0016.\u0007) == DialogResult.Yes)
            {
              \u0018.\u0082 obj5 = new \u0018.\u0082();
              try
              {
                \u0097\u0082.\u0014\u0083((Form) obj5);
              }
              finally
              {
                if (obj5 != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) obj5);
              }
            }
            \u0088\u0081.\u0013\u0083();
          }
          else
          {
            try
            {
              // ISSUE: reference to a compiler-generated field
              obj1.\u0001 = new Mutex(false, \u001A.\u001D.\u0015);
            }
            catch (Exception ex)
            {
              // ISSUE: reference to a compiler-generated field
              \u001A\u001E.\u007E\u0003\u0092((object) obj1.\u0002);
              ex.\u001D\u0005();
              \u0017.\u001E\u0005(\u001A.\u001D.\u000E, \u001A.\u001D.\u000F);
              \u0088\u0081.\u0013\u0083();
              return;
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (!(obj1.\u0002 = \u009F\u001E.\u007E\u0019\u0098((object) obj1.\u0001, TimeSpan.Zero, false)))
            {
              \u001A.\u001D.\u001E\u0005();
              \u001E\u001E.\u0091\u0095(1);
              \u0088\u0081.\u0013\u0083();
            }
            else
            {
              try
              {
                // ISSUE: reference to a compiler-generated field
                obj1.\u0001 = \u0012\u007F.\u0088\u0005\u0002(\u001A.\u001D.\u0013, 4L, MemoryMappedFileAccess.ReadWrite);
              }
              catch (IOException ex)
              {
                ex.\u001D\u0005();
                // ISSUE: reference to a compiler-generated field
                \u001A\u001E.\u007E\u0003\u0092((object) obj1.\u0003);
                if (\u001D\u0086.\u0017\u009D((Exception) ex) == (int) \u000E.\u0001)
                {
                  \u001A.\u001D.\u001E\u0005();
                  \u001E\u001E.\u0091\u0095(1);
                  \u0088\u0081.\u0013\u0083();
                  return;
                }
              }
              Icon icon = \u001A.\u001D.\u0001 = \u0006\u0081.\u000E\u0080(\u008E\u001E.\u0006\u0083());
              try
              {
                \u0014 instance = \u0014.Instance;
                DateTime dateTime = \u001D\u0082.\u0011\u0094();
                if (instance.UpdateStepOn != \u0002.\u0007)
                {
                  if (\u0081.\u0080.Instance.ApplicationSettings.UpdateType != \u000E.\u0004)
                  {
                    if (\u001B\u0082.\u001F\u0094(dateTime, instance.LastCheckedForUpdate).TotalDays < 14.0)
                      goto label_39;
                  }
                  else
                    goto label_39;
                }
                bool flag1 = false;
                try
                {
                  \u0008 obj5 = new \u0008(true);
                  try
                  {
                    \u0097\u0082.\u0014\u0083((Form) obj5);
                    switch (obj5.UpdateResult)
                    {
                      case \u0006.\u0005:
                      case \u0006.\u0007:
                        flag1 = true;
                        break;
                      case \u0006.\u0006:
                        instance.UpdateStepOn = \u0002.\u0001;
                        flag1 = true;
                        \u0088\u0081.\u0013\u0083();
                        return;
                    }
                  }
                  finally
                  {
                    if (obj5 != null)
                      \u001A\u001E.\u007E\u0094\u0092((object) obj5);
                  }
                }
                finally
                {
                  if (flag1)
                  {
                    instance.LastCheckedForUpdate = dateTime;
                    instance.\u001D\u0005();
                  }
                }
label_39:
                try
                {
                  \u0006 obj5 = new \u0006();
                  try
                  {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    \u001A.\u001D.\u0002 obj6 = new \u001A.\u001D.\u0002();
                    // ISSUE: reference to a compiler-generated field
                    obj6.\u0001 = obj1;
                    // ISSUE: reference to a compiler-generated field
                    obj6.\u0001 = new \u0007();
                    try
                    {
                      // ISSUE: reference to a compiler-generated method
                      obj5.DataReceived += new EventHandler<\u0012>(obj6.\u001D\u0005);
                      // ISSUE: reference to a compiler-generated field
                      if (obj1.\u0001 != null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        MemoryMappedViewStream mappedViewStream = \u007F\u0086.\u007E\u0089\u0005\u0002((object) obj1.\u0001, 0L, (long) \u001A.\u001D.\u0001, MemoryMappedFileAccess.ReadWrite);
                        try
                        {
                          BinaryWriter binaryWriter = new BinaryWriter((Stream) mappedViewStream, \u0013.\u0001);
                          try
                          {
                            \u0011\u001F.\u007E\u0015\u009E((object) binaryWriter, \u0005\u0081.\u007E\u009F\u0003\u0002((object) \u000F\u001F.\u0014\u0004\u0002()));
                            \u0012\u0080.\u007E\u0017\u009E((object) binaryWriter, \u0088\u0086.\u007E\u0089\u0086((object) obj5).ToInt64());
                          }
                          finally
                          {
                            if (binaryWriter != null)
                              \u001A\u001E.\u007E\u0094\u0092((object) binaryWriter);
                          }
                        }
                        finally
                        {
                          if (mappedViewStream != null)
                            \u001A\u001E.\u007E\u0094\u0092((object) mappedViewStream);
                        }
                      }
                      // ISSUE: reference to a compiler-generated field
                      \u001A\u001E.\u007E\u0003\u0092((object) obj1.\u0001);
                      bool flag2 = \u0012.Current.Flags.Contains(\u001A.\u001D.\u0001(51495));
                      try
                      {
                        if (flag2)
                        {
                          \u0013.\u001D\u0005(\u001A.\u007F.DebugLogDirectory);
                          \u0081.\u0080.Instance.CreatedFileArchive.\u001E\u0005(\u0013.LogFile);
                          \u0013.\u001D\u0005(\u001A.\u001D.\u0006, false);
                          \u0013.\u001D\u0005(\u001A.\u001D.\u0005, false);
                        }
                        // ISSUE: reference to a compiler-generated field
                        \u0018\u0080.\u0015\u0083((ApplicationContext) obj6.\u0001);
                      }
                      finally
                      {
                        if (flag2)
                        {
                          \u0013.\u001D\u0005(\u001A.\u001D.\u0006, false);
                          \u0013.\u001D\u0005();
                        }
                      }
                    }
                    finally
                    {
                      // ISSUE: reference to a compiler-generated field
                      if (obj6.\u0001 != null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        \u001A\u001E.\u007E\u0094\u0092((object) obj6.\u0001);
                      }
                    }
                  }
                  finally
                  {
                    if (obj5 != null)
                      \u001A\u001E.\u007E\u0094\u0092((object) obj5);
                  }
                }
                finally
                {
                  \u0081.\u0080.\u001D\u0005();
                }
              }
              finally
              {
                if (icon != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) icon);
              }
            }
          }
        }
        finally
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0003\u0092((object) obj1.\u0001);
        }
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        \u001A\u001E.\u007E\u0003\u0092((object) obj1.\u0002);
        // ISSUE: reference to a compiler-generated field
        \u001A\u001E.\u007E\u0003\u0092((object) obj1.\u0003);
        \u0084\u0083.\u0011\u0083(exceptionEventHandler2);
      }
    }

    private static void \u001E\u0005()
    {
      MemoryMappedFile memoryMappedFile = \u0012\u0086.\u0087\u0005\u0002(\u001A.\u001D.\u0013, MemoryMappedFileRights.Read);
      try
      {
        MemoryMappedViewStream mappedViewStream = \u007F\u0086.\u007E\u0089\u0005\u0002((object) memoryMappedFile, 0L, (long) \u001A.\u001D.\u0001, MemoryMappedFileAccess.Read);
        try
        {
          BinaryReader binaryReader = new BinaryReader((Stream) mappedViewStream);
          try
          {
            int num1 = \u0005\u0081.\u007E\u0099\u009D((object) binaryReader);
            long num2 = \u001F\u001E.\u007E\u009B\u009D((object) binaryReader);
            Process process1 = \u000F\u001F.\u0014\u0004\u0002();
            try
            {
              Process process2 = \u009E\u0082.\u0012\u0004\u0002(num1);
              try
              {
                if (\u0099\u0082.\u007E\u0006\u0004\u0002((object) process2) && \u0013.\u001D\u0005(new IntPtr(num2), \u008E\u001E.\u0092\u0095(), new IntPtr(\u0005\u0081.\u007E\u009F\u0003\u0002((object) process1)), 5000U))
                  return;
                \u0017.\u001D\u0005(\u001A.\u001D.\u0011, \u001A.\u001D.\u0012);
              }
              finally
              {
                if (process2 != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) process2);
              }
            }
            finally
            {
              if (process1 != null)
                \u001A\u001E.\u007E\u0094\u0092((object) process1);
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
          if (mappedViewStream != null)
            \u001A\u001E.\u007E\u0094\u0092((object) mappedViewStream);
        }
      }
      finally
      {
        if (memoryMappedFile != null)
          \u001A\u001E.\u007E\u0094\u0092((object) memoryMappedFile);
      }
    }
  }
}
