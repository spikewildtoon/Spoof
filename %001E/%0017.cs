// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001A;
using \u001E;
using \u0083;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;

namespace \u001E
{
  internal class \u0017 : \u0015
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly int \u0001;
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
    private static readonly string \u0019;
    private static readonly string \u001A;
    private static readonly string \u001B;
    private readonly string \u001C;
    private readonly string \u001D;
    private readonly string \u001E;

    protected virtual string ProcessName
    {
      get
      {
        return \u0016.\u0001.\u001D\u0005();
      }
    }

    protected virtual string ThreadName
    {
      get
      {
        return \u0002\u007F.\u007E\u0095\u0098((object) \u007F\u0080.\u0090\u0098());
      }
    }

    protected virtual string MachineName
    {
      get
      {
        return \u008E\u001E.\u0094\u0095();
      }
    }

    protected virtual string AppDomain
    {
      get
      {
        return \u0002\u007F.\u007E\u0090\u0094((object) \u0082\u0081.\u008F\u0094());
      }
    }

    protected virtual string ProcessID
    {
      get
      {
        return \u0016.\u0001.\u001D\u0005().ToString((IFormatProvider) \u008B\u0084.\u0014\u009C());
      }
    }

    protected virtual string ManagedThreadID
    {
      get
      {
        return \u0005\u0081.\u007E\u0089\u0098((object) \u007F\u0080.\u0090\u0098()).ToString((IFormatProvider) \u008B\u0084.\u0014\u009C());
      }
    }

    public event EventHandler<\u0014> LogFileCompressed;

    static \u0017()
    {
      \u0004.\u001D\u0005(typeof (\u0017));
      \u0017.\u0001 = 1048576;
      \u0017.\u0001 = \u0017.\u0001(65741);
      \u0017.\u0002 = \u0017.\u0001(65806);
      \u0017.\u0003 = \u0017.\u0001(65843);
      \u0017.\u0004 = \u0017.\u0001(65864);
      \u0017.\u0005 = \u0017.\u0001(65877);
      \u0017.\u0006 = \u0017.\u0001(65902);
      \u0017.\u0007 = \u0017.\u0001(65915);
      \u0017.\u0008 = \u0017.\u0001(65932);
      \u0017.\u000E = \u0017.\u0001(65949);
      \u0017.\u000F = \u0017.\u0001(65966);
      \u0017.\u0010 = \u0017.\u0001(65999);
      \u0017.\u0011 = \u0017.\u0001(66020);
      \u0017.\u0012 = \u0017.\u0001(66045);
      \u0017.\u0013 = \u0017.\u0001(66078);
      \u0017.\u0014 = \u0017.\u0001(66103);
      \u0017.\u0015 = \u0017.\u0001(66136);
      \u0017.\u0016 = \u0017.\u0001(66177);
      \u0017.\u0017 = \u0017.\u0001(66222);
      \u0017.\u0018 = \u0017.\u0001(66263);
      \u0017.\u0019 = \u0017.\u0001(66304);
      \u0017.\u001A = \u0017.\u0001(66349);
      \u0017.\u001B = \u0017.\u0001(66422);
    }

    public \u0017(string logFile)
    {
      this.\u001E = \u009C\u0080.\u0005\u009F(logFile);
      this.\u001D = \u009C\u0080.\u0008\u009F(logFile);
      this.\u001C = \u008B\u001E.\u0088\u0093(\u009C\u0080.\u000E\u009F(this.\u001D), \u0017.\u0001(63859), \u009C\u0080.\u0006\u009F(this.\u001D), \u0017.\u0001(65719));
    }

    public \u0017(string directory, string logFile)
      : this(Path.Combine(directory, logFile))
    {
    }

    private string \u0082\u0005()
    {
      try
      {
        return this.ProcessName;
      }
      catch (Exception ex)
      {
        return this.\u001D\u0005(ex);
      }
    }

    private string \u0083\u0005()
    {
      try
      {
        return this.ThreadName;
      }
      catch (Exception ex)
      {
        return this.\u001D\u0005(ex);
      }
    }

    private string \u0084\u0005()
    {
      try
      {
        return this.MachineName;
      }
      catch (Exception ex)
      {
        return this.\u001D\u0005(ex);
      }
    }

    private string \u0086\u0005()
    {
      try
      {
        return this.AppDomain;
      }
      catch (Exception ex)
      {
        return this.\u001D\u0005(ex);
      }
    }

    private string \u0087\u0005()
    {
      try
      {
        return this.ProcessID;
      }
      catch (Exception ex)
      {
        return this.\u001D\u0005(ex);
      }
    }

    private string \u0088\u0005()
    {
      try
      {
        return this.ManagedThreadID;
      }
      catch (Exception ex)
      {
        return this.\u001D\u0005(ex);
      }
    }

    protected string \u001D\u0005(Exception ex)
    {
      return \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u001A, new object[1]{ (object) \u0002\u007F.\u007E\u0090\u0091((object) ex) });
    }

    public void \u0001(Exception ex)
    {
      this.\u0001(ex, (object[]) null);
    }

    public void \u0001(Exception ex, params object[] state)
    {
      Mutex mutex = new Mutex(0 != 0, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0001(65724), new object[1]{ (object) \u0008.Current.Guid }));
      try
      {
        if (!\u0004\u001C.\u007E\u0018\u0098((object) mutex, 1000, true))
          return;
        try
        {
          string logFilePath = \u0081\u0086.\u0011\u009F(this.\u001E, this.\u001D);
          this.\u001D\u0005(logFilePath);
          Stream stream = (Stream) \u008F\u001C.\u0093\u009E(logFilePath, FileMode.Append, FileAccess.Write, FileShare.None);
          try
          {
            StreamWriter writer = new StreamWriter(stream, \u0013.\u0002);
            try
            {
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0017.\u0001);
              DateTime dateTime = \u001D\u0082.\u0011\u0094();
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0005, new object[2]
              {
                (object) dateTime.ToShortDateString(),
                (object) dateTime.ToShortTimeString()
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0006, new object[1]
              {
                (object) \u0002\u007F.\u007E\u0017\u0097((object) \u009C\u0083.\u007E\u0093\u0091((object) ex))
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0007, new object[1]
              {
                (object) \u0002\u007F.\u007E\u0090\u0091((object) ex)
              }));
              WebException webException = ex as WebException;
              if (webException != null)
              {
                \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0018, new object[1]
                {
                  (object) \u0002\u0080.\u007E\u000F\u0003\u0002((object) webException)
                }));
                HttpWebResponse httpWebResponse = \u000E\u0083.\u007E\u0010\u0003\u0002((object) webException) as HttpWebResponse;
                if (httpWebResponse != null)
                  \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0019, new object[1]
                  {
                    (object) \u0006\u0082.\u007E\u009F\u0002\u0002((object) httpWebResponse)
                  }));
              }
              if (\u0002\u007F.\u007E\u0091\u0091((object) ex) != null)
                \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0008, new object[1]
                {
                  (object) \u0002\u007F.\u007E\u0091\u0091((object) ex)
                }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0002, new object[1]
              {
                (object) \u0008.Current.FileVersion
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0003, new object[1]
              {
                (object) \u0002\u007F.\u007E\u0087\u0091((object) \u0015\u007F.\u009A\u0095())
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0004, new object[1]
              {
                (object) \u000E\u007F.\u0099\u0095()
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u000E, new object[1]
              {
                (object) this.\u0084\u0005()
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u000F, new object[1]
              {
                (object) this.\u0086\u0005()
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0011, new object[1]
              {
                (object) this.\u0082\u0005()
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0010, new object[1]
              {
                (object) this.\u0087\u0005()
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0012, new object[1]
              {
                (object) this.\u0088\u0005()
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0013, new object[1]
              {
                (object) this.\u0083\u0005()
              }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0014, new object[1]
              {
                (object) \u0099\u0082.\u007E\u008C\u0098((object) \u007F\u0080.\u0090\u0098())
              }));
              int num1;
              int num2;
              \u0083\u0084.\u0097\u0098(ref num1, ref num2);
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0015, new object[1]{ (object) num1 }));
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0016, new object[1]{ (object) num2 }));
              if (state != null)
              {
                for (int index = 0; index < state.Length; ++index)
                  \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0017, new object[2]
                  {
                    (object) index,
                    (object) \u0002\u007F.\u007E\u0087\u0091(state[index])
                  }));
              }
              this.\u001D\u0005(writer, ex, state);
              \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0017.\u001B);
            }
            finally
            {
              if (writer != null)
                \u001A\u001E.\u007E\u0094\u0092((object) writer);
            }
          }
          finally
          {
            if (stream != null)
              \u001A\u001E.\u007E\u0094\u0092((object) stream);
          }
        }
        catch
        {
        }
        finally
        {
          \u001A\u001E.\u007E\u0086\u0098((object) mutex);
        }
      }
      finally
      {
        if (mutex != null)
          \u001A\u001E.\u007E\u0094\u0092((object) mutex);
      }
    }

    private void \u001D\u0005(string logFilePath)
    {
      if (!\u008F\u0084.\u0092\u009E(logFilePath))
        return;
      try
      {
        FileInfo fileInfo = new FileInfo(logFilePath);
        if (\u001F\u001E.\u007E\u0098\u009E((object) fileInfo) < (long) \u0017.\u0001)
          return;
        string compressedFilePath = \u001A.\u0016.\u001D\u0005(this.\u001E, this.\u001C);
        bool flag;
        try
        {
          FileStream fileStream1 = \u007F\u0082.\u007E\u0099\u009E((object) fileInfo);
          try
          {
            FileStream fileStream2 = \u008F\u001C.\u0093\u009E(compressedFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
              GZipStream gzipStream = new GZipStream((Stream) fileStream2, CompressionMode.Compress);
              try
              {
                \u0091\u0080.\u007E\u0083\u009D((object) fileStream1, (Stream) gzipStream);
              }
              finally
              {
                if (gzipStream != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) gzipStream);
              }
            }
            finally
            {
              if (fileStream2 != null)
                \u001A\u001E.\u007E\u0094\u0092((object) fileStream2);
            }
          }
          finally
          {
            if (fileStream1 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) fileStream1);
          }
          flag = true;
        }
        catch
        {
          flag = false;
          if (\u008F\u0084.\u0092\u009E(compressedFilePath))
            \u009C\u001F.\u0091\u009E(compressedFilePath);
        }
        if (!flag)
          return;
        if (this.\u0001 != null)
          this.\u0001((object) this, new \u0014(compressedFilePath));
        \u009C\u001F.\u0091\u009E(logFilePath);
      }
      catch
      {
      }
    }

    protected virtual void \u001D\u0005(StreamWriter writer, Exception ex, params object[] state)
    {
    }
  }
}
