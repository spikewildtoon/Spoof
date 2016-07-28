// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0019;
using \u001D;
using \u0080;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Threading;
using TSN.Collections;

namespace \u0080
{
  internal sealed class \u0018 : \u0015.\u0016
  {
    private readonly List<\u0082> \u0002 = new List<\u0082>();
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
    private static readonly List<\u0082> \u0001;
    private static readonly List<\u0018> \u0001;
    private static Dictionary<\u0018, \u001A.\u001E> \u0001;
    private static Dictionary<\u0018, \u0082> \u0001;
    public static readonly ReadOnlyDictionary<\u0018, \u0082> \u0001;
    public static readonly ReadOnlyDictionary<\u0018, \u001A.\u001E> \u0001;
    private readonly List<\u001B.\u001B> \u0001;

    public static ReadOnlyCollection<\u0082> AvailableDistricts
    {
      get
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag);
          return \u0018.\u0001.AsReadOnly();
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
    }

    public static ReadOnlyCollection<\u0018> OpenToonTownWindows
    {
      get
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag);
          return \u0018.\u0001.AsReadOnly();
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
    }

    public bool IsLogging
    {
      get
      {
        if (this.LogMonitor == null)
          return false;
        return this.LogMonitor.Running;
      }
    }

    public \u001F.\u001C ToonTownProcess { get; private set; }

    public string Username { get; private set; }

    public \u001A.\u001C LogMonitor { get; private set; }

    public \u0080.\u0001 ServerType { get; private set; }

    public \u0082 District { get; private set; }

    public \u001A.\u001E? Invasion { get; private set; }

    public \u001A.\u0019 Playground { get; private set; }

    private List<\u001B.\u001B> SafeFileStates
    {
      get
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) this.\u0001), ref flag);
          return this.\u0001;
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
    }

    public ReadOnlyCollection<\u001B.\u001B> FileStates
    {
      get
      {
        return this.SafeFileStates.AsReadOnly();
      }
    }

    public static event EventHandler<\u001D.\u0019> WindowInvasionStateChanged;

    public static event EventHandler<\u007F.\u001D> WindowDistrictChanged;

    public static event EventHandler<\u001C.\u001C> InvasionNotDetected;

    public static event EventHandler WindowClosed;

    public event EventHandler<\u001D.\u0019> InvasionStateChanged;

    public event EventHandler<\u007F.\u001D> DistrictChanged;

    static \u0018()
    {
      \u0004.\u001D\u0005(typeof (\u0018));
      \u0018.\u0001 = \u0018.\u0001(88999);
      \u0018.\u0002 = \u0018.\u0001(89036);
      \u0018.\u0003 = \u0018.\u0001(89077);
      \u0018.\u0004 = \u0018.\u0001(45012);
      \u0018.\u0005 = \u0018.\u0001(45033);
      \u0018.\u0006 = \u0018.\u0001(89098);
      \u0018.\u0007 = \u0018.\u0001(89123);
      \u0018.\u0008 = \u0018.\u0001(89168);
      \u0018.\u0001 = new List<\u0082>();
      \u0018.\u0001 = new List<\u0018>();
      \u0018.\u0001 = new Dictionary<\u0018, \u001A.\u001E>();
      \u0018.\u0001 = new Dictionary<\u0018, \u0082>();
      \u0018.\u0001 = new ReadOnlyDictionary<\u0018, \u0082>((IDictionary<\u0018, \u0082>) \u0018.\u0001);
      \u0018.\u0001 = new ReadOnlyDictionary<\u0018, \u001A.\u001E>((IDictionary<\u0018, \u001A.\u001E>) \u0018.\u0001);
    }

    private \u0018(Process p, \u0080.\u0001 serverType, string username, bool isOpen = true)
      : this(serverType, username)
    {
      if (p == null)
        throw new ArgumentNullException(\u0018.\u0001(88994));
      this.ToonTownProcess = new \u001F.\u001C(p, true, isOpen);
      this.ToonTownProcess.ProcessExited += new EventHandler(this.\u001D\u0005);
    }

    private \u0018(IntPtr hWnd, \u0080.\u0001 serverType, string username)
      : this(serverType, username)
    {
      this.ToonTownProcess = new \u001F.\u001C();
      // ISSUE: method pointer
      this.ToonTownProcess.ProcessExited += new EventHandler((object) this, __methodptr(\u001D\u0005));
      this.ToonTownProcess.MainWindowHandle = hWnd;
    }

    private \u0018(\u0080.\u0001 serverType, string username)
    {
      this.\u0001 = new List<\u001B.\u001B>();
      this.ServerType = serverType;
      this.Username = username;
      this.Playground = \u001A.\u0019.\u0001;
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag);
        \u0018.\u0001.Add(this);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private static void \u0081\u0005()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0018.\u0001 obj1 = new \u0018.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = new HashSet<\u0082>();
      bool flag1 = false;
      object obj2;
      try
      {
        \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag1);
        bool flag2 = false;
        object obj3;
        try
        {
          \u0098\u0082.\u0081\u0098(obj3 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag2);
          foreach (\u0018 obj4 in \u0018.\u0001)
          {
            bool flag3 = false;
            object obj5;
            try
            {
              \u0098\u0082.\u0081\u0098(obj5 = \u0005\u007F.\u007E\u0016\u0092((object) obj4.\u0002), ref flag3);
              // ISSUE: reference to a compiler-generated method
              obj4.\u0002.ForEach(new Action<\u0082>(obj1.\u001D\u0005));
            }
            finally
            {
              if (flag3)
                \u001A\u001E.\u0082\u0098(obj5);
            }
          }
        }
        finally
        {
          if (flag2)
            \u001A\u001E.\u0082\u0098(obj3);
        }
        // ISSUE: reference to a compiler-generated field
        foreach (\u0082 obj4 in obj1.\u0001)
        {
          if (!\u0018.\u0001.Contains(obj4))
            \u0018.\u0001.Add(obj4);
        }
        // ISSUE: reference to a compiler-generated method
        ((IEnumerable<\u0082>) \u0018.\u0001.Where<\u0082>(new Func<\u0082, bool>(obj1.\u001D\u0005)).ToArray<\u0082>()).\u001D\u0005<\u0082>((Action<\u0082>) (d => \u0018.\u0001.Remove(d)));
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj2);
      }
    }

    public static bool \u001D\u0005(\u0080.\u0001 type, string username)
    {
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag);
        foreach (\u0018 obj2 in \u0018.\u0001)
        {
          if (obj2.ServerType == type && \u0008\u001F.\u009A\u0092(obj2.Username, username))
            return true;
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
      return false;
    }

    public static bool \u001D\u0005(IntPtr hWnd, out \u0018 wnd)
    {
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag);
        foreach (\u0018 obj2 in \u0018.\u0001)
        {
          if (\u0008\u0081.\u0086\u0096(obj2.ToonTownProcess.MainWindowHandle, hWnd))
          {
            wnd = obj2;
            return true;
          }
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
      wnd = (\u0018) null;
      return false;
    }

    public static HashSet<string> \u001D\u0005()
    {
      HashSet<string> stringSet = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag);
        foreach (\u0018 obj2 in \u0018.\u0001)
        {
          if (obj2.LogMonitor != null)
          {
            string logFileName = obj2.LogMonitor.LogFileName;
            if (!\u008F\u0084.\u009E\u0092(logFileName) && !stringSet.Contains(logFileName))
              stringSet.Add(logFileName);
          }
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
      return stringSet;
    }

    private static void \u001D\u0005(\u0018 window)
    {
      if (\u0018.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) \u0018.\u0001, (object) window, EventArgs.Empty);
    }

    private static void \u001D\u0005(\u0018 window, \u0082 district)
    {
      if (\u0018.\u0001 == null)
        return;
      \u0018.\u0001((object) window, new \u001C.\u001C(district));
    }

    private static void \u001D\u0005(\u0018 window, \u001A.\u001E state)
    {
      if (\u0018.\u0001 == null)
        return;
      \u0018.\u0001((object) window, new \u001D.\u0019(state));
    }

    private static void \u001E\u0005(\u0018 window, \u0082 district)
    {
      if (\u0018.\u0001 == null)
        return;
      \u0018.\u0001((object) window, new \u007F.\u001D(district));
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public static \u0018 \u001D\u0005(Process p, \u0080.\u0001 serverType, string username, bool isOpen = true)
    {
      try
      {
        \u0099\u001F.\u007E\u000F\u0004\u0002((object) p, true);
        return new \u0018(p, serverType, username, isOpen);
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        return (\u0018) null;
      }
    }

    public static \u0018 \u001D\u0005(IntPtr hWnd, \u0080.\u0001 serverType, string username)
    {
      try
      {
        return new \u0018(hWnd, serverType, username);
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        return (\u0018) null;
      }
    }

    public void \u0082\u0005()
    {
      // ISSUE: method pointer
      int num = \u001E\u0086.\u0099\u0098(new WaitCallback((object) this, __methodptr(\u001D\u0005))) ? 1 : 0;
    }

    public bool \u0080\u0005()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0018.\u0002 obj1 = new \u0018.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0002 = false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0018.\u0003 obj2 = new \u0018.\u0003();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new ManualResetEventSlim(false);
      try
      {
        try
        {
          // ISSUE: reference to a compiler-generated method
          this.ToonTownProcess.ProcessExited += new EventHandler(obj2.\u001D\u0005);
          // ISSUE: reference to a compiler-generated method
          int num = \u001E\u0086.\u0099\u0098(new WaitCallback(obj2.\u001D\u0005)) ? 1 : 0;
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0004\u0099((object) obj2.\u0001);
        }
        finally
        {
          // ISSUE: reference to a compiler-generated field
          obj1.\u0002 = true;
        }
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj2.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj2.\u0001);
        }
      }
      // ISSUE: reference to a compiler-generated field
      return obj1.\u0001;
    }

    private bool \u001D\u0005(EventHandler endOfStream = null)
    {
      string logFile;
      if (!\u0018.\u001D\u0005(this.ToonTownProcess.Process, out logFile))
        return false;
      this.LogMonitor = new \u001A.\u001C(logFile);
      this.LogMonitor.FileStateRead += (EventHandler<\u0014.\u0015>) ((obj, e) => this.SafeFileStates.Add(e.FileState));
      this.LogMonitor.InvasionStateChanged += (EventHandler<\u001D.\u0019>) ((obj, e) =>
      {
        bool flag = false;
        object obj1;
        try
        {
          \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag);
          switch (e.InvasionState.\u0001)
          {
            case \u007F.\u001B.\u0001:
            case \u007F.\u001B.\u0003:
              if (\u0018.\u0001.ContainsKey(this))
                \u0018.\u0001[this] = e.InvasionState;
              else
                \u0018.\u0001.Add(this, e.InvasionState);
              this.Invasion = new \u001A.\u001E?(e.InvasionState);
              break;
            case \u007F.\u001B.\u0002:
              if (\u0018.\u0001.ContainsKey(this))
                \u0018.\u0001.Remove(this);
              this.Invasion = new \u001A.\u001E?();
              break;
          }
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj1);
        }
        if (this.\u0002 != null)
          this.\u0002((object) this, e);
        \u0018.\u001D\u0005(this, e.InvasionState);
      });
      this.LogMonitor.DistrictChanged += (EventHandler<\u007F.\u001D>) ((obj, e) =>
      {
        this.District = e.District;
        this.Invasion = new \u001A.\u001E?();
        bool flag1 = false;
        object obj1;
        try
        {
          \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag1);
          if (\u0018.\u0001.ContainsKey(this))
            \u0018.\u0001.Remove(this);
        }
        finally
        {
          if (flag1)
            \u001A\u001E.\u0082\u0098(obj1);
        }
        if (this.\u0002 != null)
          this.\u0002((object) this, e);
        bool flag2 = false;
        object obj2;
        try
        {
          \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag2);
          if (\u0018.\u0001.ContainsKey(this))
            \u0018.\u0001[this] = e.District;
          else
            \u0018.\u0001.Add(this, e.District);
        }
        finally
        {
          if (flag2)
            \u001A\u001E.\u0082\u0098(obj2);
        }
        \u0018.\u001E\u0005(this, e.District);
      });
      this.LogMonitor.LoggedOut += (EventHandler) ((obj, e) =>
      {
        this.District = (\u0082) null;
        this.Invasion = new \u001A.\u001E?();
        bool flag1 = false;
        object obj1;
        try
        {
          \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag1);
          if (\u0018.\u0001.ContainsKey(this))
            \u0018.\u0001.Remove(this);
        }
        finally
        {
          if (flag1)
            \u001A\u001E.\u0082\u0098(obj1);
        }
        if (this.\u0002 != null)
          this.\u0002((object) this, (\u007F.\u001D) null);
        bool flag2 = false;
        object obj2;
        try
        {
          \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag2);
          if (\u0018.\u0001.ContainsKey(this))
            \u0018.\u0001[this] = (\u0082) null;
          else
            \u0018.\u0001.Add(this, (\u0082) null);
        }
        finally
        {
          if (flag2)
            \u001A\u001E.\u0082\u0098(obj2);
        }
        \u0018.\u001E\u0005(this, (\u0082) null);
      });
      this.LogMonitor.AvailableDistrictsChanged += (EventHandler<\u0014.\u0016>) ((obj, e) =>
      {
        bool flag = false;
        object obj1;
        try
        {
          \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) this.\u0002), ref flag);
          this.\u0002.Clear();
          foreach (uint shard in e.Shards)
          {
            \u0082 obj2 = \u0082.\u001D\u0005(shard);
            if (!this.\u0002.Contains(obj2))
              this.\u0002.Add(obj2);
          }
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj1);
        }
        \u0018.\u0081\u0005();
      });
      this.LogMonitor.NoInvasionDetected += (EventHandler) ((obj, e) => \u0018.\u001D\u0005(this, this.District));
      this.LogMonitor.PlaygroundChanged += (EventHandler<\u001C.\u001E>) ((obj, e) => this.Playground = e.Playground);
      if (endOfStream != null)
        this.LogMonitor.ReadingPaused += endOfStream;
      this.LogMonitor.\u0081\u0005();
      return true;
    }

    private static bool \u001D\u0005(Process p, out string logFile)
    {
      \u0013.\u001D\u0005(\u0018.\u0008, true);
      List<FileSystemInfo> fileSystemInfoList = \u0081.\u001B.\u001D\u0005(\u0005\u0081.\u007E\u009F\u0003\u0002((object) p));
      if (fileSystemInfoList == null)
        \u0013.\u001D\u0005(\u0018.\u0006, true);
      else
        goto label_13;
label_7:
      string directory = (string) null;
      if ((\u001F\u001C.\u007E\u0007\u0004\u0002((object) p) == null || \u008F\u0084.\u009E\u0092(directory = \u0002\u007F.\u007E\u0087\u0004\u0002((object) \u001F\u001C.\u007E\u0007\u0004\u0002((object) p)))) && \u001D\u007F.\u007E\u0003\u0004\u0002((object) p) != null)
        directory = \u009C\u0080.\u0005\u009F(\u0002\u007F.\u007E\u001E\u0004\u0002((object) \u001D\u007F.\u007E\u0003\u0004\u0002((object) p)));
      if (!\u008F\u0084.\u009E\u0092(directory) && \u008F\u0084.\u001D\u009E(directory))
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0018.\u0004 obj = new \u0018.\u0004();
        \u0013.\u001D\u0005(\u0018.\u0003, new object[1]
        {
          (object) directory
        });
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = \u0008\u007F.\u007E\u000E\u0004\u0002((object) p);
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = \u0018.\u001D\u0005();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        string[] array = ((IEnumerable<string>) \u0012.\u001D\u0005(directory, \u0018.\u0004, \u0018.\u0005)).Where<string>(new Func<string, bool>(obj.\u001D\u0005)).Where<string>((Func<string, bool>) (file => \u0012.\u001F\u0005(file))).Where<string>(new Func<string, bool>(obj.\u001E\u0005)).ToArray<string>();
        if (array.Length == 1)
        {
          logFile = array[0];
          \u0013.\u001D\u0005(\u0018.\u0002, new object[1]
          {
            (object) logFile
          });
          return true;
        }
      }
      \u0013.\u001D\u0005(\u0018.\u0001, true);
      logFile = (string) null;
      return false;
label_13:
      using (List<FileSystemInfo>.Enumerator enumerator = fileSystemInfoList.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          FileSystemInfo current = enumerator.Current;
          if (current is FileInfo && \u0008\u0080.\u0099\u0092(\u0002\u007F.\u007E\u0083\u009E((object) current), \u0018.\u0005, StringComparison.OrdinalIgnoreCase) && (\u0003\u0084.\u007E\u0018\u0093((object) \u0002\u007F.\u007E\u0084\u009E((object) current), \u0018.\u0001(18807), StringComparison.OrdinalIgnoreCase) && \u0099\u0082.\u007E\u0086\u009E((object) current)))
          {
            logFile = \u0002\u007F.\u007E\u0082\u009E((object) current);
            \u0013.\u001D\u0005(\u0018.\u0007, new object[1]
            {
              (object) logFile
            });
            return true;
          }
        }
        goto label_7;
      }
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.LogMonitor != null)
      {
        this.LogMonitor.\u0082\u0005();
        this.LogMonitor = (\u001A.\u001C) null;
      }
      \u001D.\u0001 connectSettings = \u0081.\u0080.Instance.ConnectSettings;
      \u001B.\u0019 toonTownVersionData1 = connectSettings.ActualToonTownVersionData;
      \u001B.\u0019 toonTownVersionData2 = connectSettings.ActualTestToonTownVersionData;
      \u001B.\u0019 toonTownVersionData3 = connectSettings.SpoofedToonTownVersionData;
      bool spoofedToonTownEnabled = connectSettings.SpoofedToonTownEnabled;
      bool flag1 = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) toonTownVersionData1.FILES), ref flag1);
        bool flag2 = false;
        object obj2;
        try
        {
          \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) toonTownVersionData2.FILES), ref flag2);
          bool flag3 = false;
          object obj3;
          try
          {
            \u0098\u0082.\u0081\u0098(obj3 = \u0005\u007F.\u007E\u0016\u0092((object) toonTownVersionData3.FILES), ref flag3);
            IEnumerator<\u001B.\u001B> enumerator = this.FileStates.GetEnumerator();
            try
            {
              while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
              {
                \u001B.\u001B current = enumerator.Current;
                if (!current.UpToDate)
                {
                  switch (this.ServerType)
                  {
                    case \u0080.\u0001.\u0002:
                      if (toonTownVersionData1.FILES.ContainsKey(current.FileName))
                        toonTownVersionData1.FILES[current.FileName].ForceRecheck = true;
                      if (spoofedToonTownEnabled && toonTownVersionData3.FILES.ContainsKey(current.FileName))
                      {
                        toonTownVersionData3.FILES[current.FileName].ForceRecheck = true;
                        continue;
                      }
                      continue;
                    case \u0080.\u0001.\u0003:
                      if (toonTownVersionData2.FILES.ContainsKey(current.FileName))
                      {
                        toonTownVersionData2.FILES[current.FileName].ForceRecheck = true;
                        continue;
                      }
                      continue;
                    default:
                      continue;
                  }
                }
              }
            }
            finally
            {
              if (enumerator != null)
                \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
            }
          }
          finally
          {
            if (flag3)
              \u001A\u001E.\u0082\u0098(obj3);
          }
        }
        finally
        {
          if (flag2)
            \u001A\u001E.\u0082\u0098(obj2);
        }
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj1);
      }
      this.Dispose();
    }

    protected override void \u001D\u0005()
    {
      bool flag1 = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag1);
        if (\u0018.\u0001.Contains(this))
          \u0018.\u0001.Remove(this);
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj1);
      }
      bool flag2 = false;
      object obj2;
      try
      {
        \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) this.\u0002), ref flag2);
        this.\u0002.Clear();
      }
      finally
      {
        if (flag2)
          \u001A\u001E.\u0082\u0098(obj2);
      }
      bool flag3 = false;
      object obj3;
      try
      {
        \u0098\u0082.\u0081\u0098(obj3 = \u0005\u007F.\u007E\u0016\u0092((object) \u0018.\u0001), ref flag3);
        if (\u0018.\u0001.ContainsKey(this))
          \u0018.\u0001.Remove(this);
      }
      finally
      {
        if (flag3)
          \u001A\u001E.\u0082\u0098(obj3);
      }
      this.District = (\u0082) null;
      \u0018.\u0081\u0005();
      if (this.\u0002 != null)
        this.\u0002((object) this, new \u007F.\u001D((\u0082) null));
      \u0018.\u001D\u0005(this);
      \u0018.\u001E\u0005(this, (\u0082) null);
      this.ToonTownProcess.Dispose();
      base.\u001D\u0005();
    }
  }
}
