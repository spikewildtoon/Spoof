// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001C;
using \u001D;
using \u007F;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace \u007F
{
  internal sealed class \u0012
  {
    private List<string> \u0001 = new List<string>();
    private List<string> \u0002 = new List<string>();
    private List<string> \u0003 = new List<string>();
    private List<\u0006> \u0001 = new List<\u0006>();
    private List<\u0006> \u0002 = new List<\u0006>();
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static Lazy<\u0012> \u0001;

    public static \u0012 Current
    {
      get
      {
        return \u0012.\u0001.Value;
      }
    }

    public ReadOnlyCollection<string> Values
    {
      get
      {
        return this.\u0001.AsReadOnly();
      }
    }

    public ReadOnlyCollection<string> Switches
    {
      get
      {
        return this.\u0002.AsReadOnly();
      }
    }

    public ReadOnlyCollection<string> Flags
    {
      get
      {
        return this.\u0003.AsReadOnly();
      }
    }

    public ReadOnlyCollection<\u0006> FlagPairs
    {
      get
      {
        return this.\u0002.AsReadOnly();
      }
    }

    public ReadOnlyCollection<\u0006> SwitchPairs
    {
      get
      {
        return this.\u0001.AsReadOnly();
      }
    }

    public string OriginalString { get; private set; }

    static \u0012()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u0012)));
      \u0012.\u0001 = \u0012.\u0001(76051);
      \u0012.\u0002 = \u0012.\u0001(76060);
      \u0012.\u0003 = \u0012.\u0001(76065);
      string[] strArray = new string[13]{ \u0012.\u0001(76074), \u0012.\u0001, \u0012.\u0001(76079), \u0012.\u0002, \u0012.\u0001(76128), \u0012.\u0003, \u0012.\u0001(76173), \u0012.\u0003, \u0012.\u0001(76194), \u0012.\u0003, \u0012.\u0001(76173), \u0012.\u0003, \u0012.\u0001(76231) };
      \u0012.\u0004 = \u0007\u007F.\u0089\u0093(strArray);
      \u0012.\u0005 = \u0012.\u0001(76248);
      \u0012.\u0001 = new Lazy<\u0012>(new Func<\u0012>(\u0012.\u001D\u0005));
    }

    public \u0012()
    {
    }

    public \u0012(string args)
    {
      this.\u001E\u0005(args);
    }

    private static \u0012 \u001D\u0005()
    {
      \u0012 obj = new \u0012();
      try
      {
        obj.\u001E\u0005(\u008E\u001E.\u0092\u0095());
      }
      catch (ArgumentNullException ex)
      {
        ex.\u001D\u0005((object) \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0012.\u0005, new object[1]
        {
          (object) \u008E\u001E.\u0092\u0095()
        }));
      }
      catch (ArgumentException ex)
      {
        ex.\u001D\u0005((object) \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0012.\u0005, new object[1]
        {
          (object) \u008E\u001E.\u0092\u0095()
        }));
      }
      return obj;
    }

    public void \u001E\u0005(string args)
    {
      this.OriginalString = args;
      this.\u0001.Clear();
      this.\u0002.Clear();
      this.\u0003.Clear();
      this.\u0002.Clear();
      this.\u0001.Clear();
      if (\u008F\u0084.\u009E\u0092(args))
        return;
      Regex regex = new Regex(\u0012.\u0004);
      try
      {
        if (!\u0016\u001D.\u007E\u0013\u0001\u0002((object) regex, args))
          return;
        IEnumerator enumerator = \u0015\u0082.\u007E\u001A\u0001\u0002((object) \u009C\u0084.\u007E\u0015\u0001\u0002((object) regex, args));
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            Match match = (Match) \u0005\u007F.\u007E\u0092\u0092((object) enumerator);
            string str;
            if ((str = \u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u0012.\u0001))) != null)
            {
              if (!\u0008\u001F.\u009A\u0092(str, \u0012.\u0001(6596)))
              {
                if (!\u0008\u001F.\u009A\u0092(str, \u0012.\u0001(58540)))
                {
                  if (\u0008\u001F.\u009A\u0092(str, \u0012.\u0001(6286)))
                  {
                    string file1 = \u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u0012.\u0003));
                    if (!\u0014.\u001D\u0005(file1, \u008E\u001E.\u0006\u0083()))
                      this.\u0001.Add(file1);
                  }
                }
                else if (\u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u0012.\u0002)), string.Empty))
                  this.\u0002.Add(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u0012.\u0003)));
                else
                  this.\u0001.Add(new \u0006(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u0012.\u0002)), \u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u0012.\u0003))));
              }
              else if (\u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u0012.\u0002)), string.Empty))
                this.\u0003.Add(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u0012.\u0003)));
              else
                this.\u0002.Add(new \u0006(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u0012.\u0002)), \u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u0012.\u0003))));
            }
          }
        }
        finally
        {
          IDisposable disposable = enumerator as IDisposable;
          if (disposable != null)
            \u001A\u001E.\u007E\u0094\u0092((object) disposable);
        }
      }
      finally
      {
      }
    }
  }
}
