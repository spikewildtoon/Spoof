// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0018;
using \u001A;
using \u001D;
using System;
using System.IO;
using System.Text;

namespace \u001D
{
  internal static class \u0013
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
    private static string \u0011;
    private static bool \u0001;
    private static \u0013.\u0001 \u0001;

    private static string DateTimeStamp
    {
      get
      {
        return \u001D\u0082.\u0011\u0094().ToString(\u0013.\u0008);
      }
    }

    public static string LogFile
    {
      get
      {
        return \u0013.\u0011;
      }
    }

    static \u0013()
    {
      \u0004.\u001D\u0005(typeof (\u0013));
      \u0013.\u0001 = \u0013.\u0001(63593);
      \u0013.\u0002 = \u0013.\u0001(63602);
      \u0013.\u0003 = \u0013.\u0001(29780);
      \u0013.\u0004 = \u0013.\u0001(63607);
      \u0013.\u0005 = \u0013.\u0001(63620);
      \u0013.\u0006 = \u0013.\u0001(63633);
      \u0013.\u0007 = \u0013.\u0001(63694);
      \u0013.\u0008 = \u0013.\u0001(63735);
      \u0013.\u000E = \u0013.\u0001(63764);
      \u0013.\u000F = \u0013.\u0003;
      \u0013.\u0010 = \u0013.\u0001(29775);
      \u0013.\u0001 = false;
      \u0013.\u0011 = (string) null;
    }

    public static void \u001D\u0005(string logDirectory)
    {
      if (\u0013.\u0001)
        return;
      if (\u008F\u0084.\u009E\u0092(logDirectory))
        throw new NullReferenceException(\u0013.\u0007);
      if (!\u008F\u0084.\u001D\u009E(logDirectory))
        throw new DirectoryNotFoundException(\u0013.\u0006);
      \u0013.\u0011 = \u0016.\u001D\u0005(logDirectory, \u0081\u0086.\u0086\u0093(\u0013.DateTimeStamp, \u0013.\u0005), \u0013.\u0001);
      \u0013.\u0001 = new \u0013.\u0001(\u0013.\u0011);
      \u0013.\u0001 = true;
    }

    public static void \u001D\u0005()
    {
      if (!\u0013.\u0001)
        return;
      \u0013.\u0001.Dispose();
      \u0013.\u0001 = false;
    }

    public static void \u001D\u0005(string message, bool appendDate = true)
    {
      \u0013.\u001D\u0005(message, appendDate, (object[]) null);
    }

    public static void \u001D\u0005(string message, params object[] parameters)
    {
      \u0013.\u001D\u0005(message, true, parameters);
    }

    public static void \u001D\u0005(string message, bool appendDate = true, params object[] parameters)
    {
      if (!\u0013.\u0001)
        return;
      if (parameters != null && parameters.Length != 0)
        goto label_17;
label_15:
      \u0013.\u0001.\u001D\u0005(message, appendDate);
      return;
label_17:
      StringBuilder stringBuilder1 = new StringBuilder();
      StringBuilder stringBuilder2 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, message);
      StringBuilder stringBuilder3 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0013.\u000E);
      for (int index1 = 0; index1 < parameters.Length; ++index1)
      {
        if (index1 > 0)
        {
          StringBuilder stringBuilder4 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0013.\u0010);
        }
        object obj = parameters[index1];
        Array array = obj as Array;
        if (array != null)
        {
          StringBuilder stringBuilder5 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0013.\u0002);
          for (int index2 = 0; index2 < \u0005\u0081.\u007E\u0089\u0092((object) array); ++index2)
          {
            if (index2 > 0)
            {
              StringBuilder stringBuilder6 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0013.\u0010);
            }
            StringBuilder stringBuilder7 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0002\u007F.\u007E\u0087\u0091(\u009F\u007F.\u007E\u0087\u0092((object) array, index2)));
          }
          StringBuilder stringBuilder8 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0013.\u0003);
        }
        else
        {
          StringBuilder stringBuilder9 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0002\u007F.\u007E\u0087\u0091(obj));
        }
      }
      StringBuilder stringBuilder10 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0013.\u000F);
      message = \u0002\u007F.\u007E\u0087\u0091((object) stringBuilder1);
      StringBuilder stringBuilder11 = \u008C\u001F.\u007E\u009B\u0093((object) stringBuilder1);
      goto label_15;
    }

    private sealed class \u0001 : \u0016
    {
      private readonly Stream \u0001;
      private readonly StreamWriter \u0001;
      private readonly object \u0001;

      public \u0001(string logFile)
      {
        this.\u0001 = new object();
        try
        {
          this.\u0001 = (Stream) \u008F\u001C.\u0093\u009E(logFile, FileMode.Append, FileAccess.Write, FileShare.Read);
          this.\u0001 = new StreamWriter(this.\u0001, \u0013.\u0003);
        }
        catch (Exception ex)
        {
          if (this.\u0001 != null)
            \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
          this.\u0001 = (Stream) null;
          if (this.\u0001 != null)
            \u001A\u001E.\u007E\u0015\u009F((object) this.\u0001);
          this.\u0001 = (StreamWriter) null;
          ex.\u001D\u0005((object) logFile);
        }
      }

      public void \u001D\u0005(string message, bool appendDate)
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
          if (this.\u0001 == null)
            return;
          try
          {
            if (appendDate)
              \u0092\u0081.\u007E\u0017\u009F((object) this.\u0001, \u0014\u0084.\u007F\u0093(\u0013.\u0004, (object) \u0013.DateTimeStamp, (object) message));
            else
              \u0092\u0081.\u007E\u0017\u009F((object) this.\u0001, message);
            \u001A\u001E.\u007E\u0016\u009F((object) this.\u0001);
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005((object) message);
          }
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }

      protected override void \u001D\u0005()
      {
        if (this.\u0001 != null)
          \u001A\u001E.\u007E\u0015\u009F((object) this.\u0001);
        if (this.\u0001 != null)
          \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
        base.\u001D\u0005();
      }
    }
  }
}
