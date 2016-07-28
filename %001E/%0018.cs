// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001A;
using \u001E;
using System;
using System.IO;

namespace \u001E
{
  internal sealed class \u0018 : \u0017
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private static readonly string \u0001;

    protected override string ProcessID
    {
      get
      {
        try
        {
          return base.ProcessID;
        }
        catch
        {
          return \u000E.\u001D\u0005().ToString((IFormatProvider) \u008B\u0084.\u0014\u009C());
        }
      }
    }

    protected override string ProcessName
    {
      get
      {
        try
        {
          return base.ProcessName;
        }
        catch
        {
          return \u000E.\u001D\u0005();
        }
      }
    }

    protected virtual string Win32ThreadID
    {
      get
      {
        return \u000E.\u001D\u0005().ToString((IFormatProvider) \u008B\u0084.\u0014\u009C());
      }
    }

    static \u0018()
    {
      \u0004.\u001D\u0005(typeof (\u001E.\u0018));
      \u001E.\u0018.\u0001 = \u001E.\u0018.\u0001(66515);
    }

    public \u0018(string logFile)
      : base(logFile)
    {
    }

    public \u0018(string directory, string logFile)
      : base(directory, logFile)
    {
    }

    private string \u0089\u0005()
    {
      try
      {
        return this.Win32ThreadID;
      }
      catch (Exception ex)
      {
        return this.\u001D\u0005(ex);
      }
    }

    protected override void \u001D\u0005(StreamWriter writer, Exception ex, params object[] state)
    {
      \u0092\u0081.\u007E\u0017\u009F((object) writer, \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u001E.\u0018.\u0001, new object[1]
      {
        (object) this.\u0089\u0005()
      }));
      base.\u001D\u0005(writer, ex, state);
    }
  }
}
