// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u001A;
using \u001F;
using \u0083;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace \u001F
{
  internal sealed class \u0003 : \u0015.\u0016
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private readonly \u001B.\u0019 \u0001;
    private readonly string \u0002;
    private readonly \u001B.\u0019 \u0002;
    private readonly Task \u0001;
    private readonly bool \u0001;
    private readonly HashSet<string> \u0001;
    private readonly CancellationTokenSource \u0001;
    private bool \u0002;

    private bool Canceling
    {
      get
      {
        return \u0099\u0082.\u007E\u0008\u0099((object) this.\u0001);
      }
    }

    public event EventHandler<\u0081.\u0019> VersionMismatch;

    public event EventHandler<\u0006> DownloadProgressChanged;

    public event EventHandler<\u0005> ProgressChanged;

    public event EventHandler<\u001F.\u001F> InstallerStateChanged;

    public event EventHandler ResetCounters;

    static \u0003()
    {
      \u0004.\u001D\u0005(typeof (\u0003));
      \u0003.\u0001 = \u0003.\u0001(17959);
    }

    public \u0003(\u001B.\u0019 liveToonTown, \u0080.\u0001 server, bool usingVirtualServer)
    {
      this.\u0001 = new HashSet<string>();
      this.\u0001 = new CancellationTokenSource();
      this.\u0001 = liveToonTown;
      switch (server)
      {
        case \u0080.\u0001.\u0002:
          this.\u0002 = \u007F.ToonTownOpenDataDirectory;
          this.\u0002 = \u0081.\u0080.Instance.ConnectSettings.ActualToonTownVersionData;
          break;
        case \u0080.\u0001.\u0003:
          this.\u0002 = \u007F.ToonTownTestDataDirectory;
          this.\u0002 = \u0081.\u0080.Instance.ConnectSettings.ActualTestToonTownVersionData;
          break;
      }
      this.\u0002.Properties = this.\u0001.Properties.\u0001();
      this.\u0001 = usingVirtualServer;
      this.\u0001 = new Task((Action) (() => this.\u0082\u0005()));
    }

    public void \u0080\u0005(bool internalCancel)
    {
      if (this.Canceling)
        return;
      this.\u0002 = internalCancel;
      \u001A\u001E.\u007E\u0010\u0099((object) this.\u0001);
    }

    protected override void \u001D\u0005()
    {
      this.\u0080\u0005(true);
      \u001A\u001E.\u007E\u001B\u0099((object) this.\u0001);
      \u001A\u001E.\u007E\u001A\u0099((object) this.\u0001);
      \u001A\u001E.\u007E\u0011\u0099((object) this.\u0001);
      base.\u001D\u0005();
    }

    public void \u0081\u0005()
    {
      \u001A\u001E.\u007E\u0017\u0099((object) this.\u0001);
    }

    private void \u0082\u0005()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0003.\u0002 obj1 = new \u0003.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = \u001D.\u0017.\u0001;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      obj1.\u0001 = new Action<\u001D.\u0017, \u001B.\u0080>((object) obj1, __methodptr(\u001D\u0005));
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0003.\u0003 obj2 = new \u0003.\u0003();
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = obj1;
        bool flag1 = \u0016.\u0001.\u001D\u0005(\u0003.\u0001) > 0;
        bool success;
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = this.\u0002.\u001D\u0005(this.\u0001, this.\u0002, this.\u0001, !flag1, this.\u0001, out success);
        // ISSUE: reference to a compiler-generated field
        bool flag2 = obj2.\u0001.Count == 0;
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = \u0081.\u0080.Instance.CreatedFileArchive;
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = \u0081.\u0080.Instance.ConnectSettings.SpoofedToonTownVersionData;
        if (this.\u0001)
        {
          bool flag3 = false;
          object obj3;
          try
          {
            \u0098\u0082.\u0081\u0098(obj3 = \u0005\u007F.\u007E\u0016\u0092((object) this.\u0002.FILES), ref flag3);
            bool flag4 = false;
            object obj4;
            List<KeyValuePair<string, \u0017.\u0015>> list;
            try
            {
              // ISSUE: reference to a compiler-generated field
              \u0098\u0082.\u0081\u0098(obj4 = \u0005\u007F.\u007E\u0016\u0092((object) obj2.\u0001.FILES), ref flag4);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              list = obj2.\u0001.FILES.Where<KeyValuePair<string, \u0017.\u0015>>(new Func<KeyValuePair<string, \u0017.\u0015>, bool>(obj2.\u001D\u0005)).ToList<KeyValuePair<string, \u0017.\u0015>>();
            }
            finally
            {
              if (flag4)
                \u001A\u001E.\u0082\u0098(obj4);
            }
            if (flag1)
            {
              if (list.Count > 0)
                success = false;
            }
            else
            {
              foreach (KeyValuePair<string, \u0017.\u0015> keyValuePair in list)
              {
                string filePath = \u0081\u0086.\u0011\u009F(this.\u0002, keyValuePair.Key);
                string str1 = \u0081\u0086.\u0011\u009F(this.\u0002, \u0081\u0086.\u0086\u0093(keyValuePair.Key, \u0003.\u0001(56798)));
                if (\u008F\u0084.\u0092\u009E(str1))
                {
                  \u008F\u0081.\u0090\u009E(str1, filePath, true);
                  // ISSUE: reference to a compiler-generated field
                  obj2.\u0001.\u001D\u0005(keyValuePair.Key, this.\u0002.FILES[keyValuePair.Key], new \u0080.\u0016?(), new long?());
                  \u0081.\u0080.Instance.CreatedFileArchive.\u001E\u0005(filePath);
                  string str2 = \u009C\u0080.\u000E\u009F(keyValuePair.Key);
                  if (!this.\u0001.Contains(str2))
                    this.\u0001.Add(str2);
                }
              }
            }
          }
          finally
          {
            if (flag3)
              \u001A\u001E.\u0082\u0098(obj3);
          }
        }
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = (Action) (() =>
        {
          if (this.\u0001 == null)
            return;
          \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
        });
        if (this.Canceling)
        {
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001(\u001D.\u0017.\u0006, \u001B.\u0080.\u0004);
          return;
        }
        if (!success)
        {
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001(\u001D.\u0017.\u0006, \u001B.\u0080.\u0002);
          return;
        }
        if (this.\u0001.Count == 0 && flag2 && flag1)
        {
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001(\u001D.\u0017.\u0006, \u001B.\u0080.\u0001);
          return;
        }
        if (flag1)
        {
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001(\u001D.\u0017.\u0006, \u001B.\u0080.\u0002);
          return;
        }
        if (!flag2)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          \u0003.\u0004 obj3 = new \u0003.\u0004();
          // ISSUE: reference to a compiler-generated field
          obj3.\u0001 = obj2;
          // ISSUE: reference to a compiler-generated field
          obj3.\u0001 = obj1;
          List<\u0003.\u0001> array1 = new List<\u0003.\u0001>();
          int simultaneousDownloads = \u0081.\u0080.Instance.ConnectSettings.MaximumSimultaneousDownloads;
          TaskFactory taskFactory1 = new TaskFactory((TaskScheduler) new \u0005(\u0099\u0081.\u009F\u0096(3, \u0099\u0081.\u009E\u0096(1, simultaneousDownloads))));
          // ISSUE: reference to a compiler-generated field
          foreach (\u001B.\u001A fileUpdateDetails in obj2.\u0001.Values)
          {
            if (fileUpdateDetails.FileDetails.Patches.Count > 0)
            {
              \u0003.\u0001 obj4 = (\u0003.\u0001) null;
              for (int index = 0; index < fileUpdateDetails.FileDetails.Patches.Count; ++index)
              {
                \u001A.\u001B patchDetails = fileUpdateDetails.FileDetails.Patches[index];
                Queue<Uri> remotePaths = new Queue<Uri>();
                foreach (Uri downloadUrl in this.\u0001.DownloadUrls)
                  remotePaths.Enqueue(new Uri(downloadUrl, \u0014\u0084.\u007F\u0093(\u0003.\u0001(68233), (object) fileUpdateDetails.PhaseName, (object) patchDetails.Version)));
                if (remotePaths.Count > 0)
                {
                  \u0003.\u0001 obj5 = new \u0003.\u0001(fileUpdateDetails, patchDetails, index == 0, (Stream) new MemoryStream(), remotePaths);
                  array1.Add(obj5);
                  if (obj4 != null)
                    obj4.NextPatchDownloadData = obj5;
                  obj4 = obj5;
                }
              }
            }
            else
            {
              Queue<Uri> remotePaths = new Queue<Uri>();
              foreach (Uri downloadUrl in this.\u0001.DownloadUrls)
                remotePaths.Enqueue(new Uri(downloadUrl, \u0014\u0084.\u007F\u0093(\u0003.\u0001(68258), (object) fileUpdateDetails.PhaseName, (object) fileUpdateDetails.FileDetails.Version)));
              if (remotePaths.Count > 0)
              {
                \u0003.\u0001 obj4 = new \u0003.\u0001(fileUpdateDetails, (Stream) new MemoryStream(), remotePaths);
                array1.Add(obj4);
              }
            }
          }
          // ISSUE: reference to a compiler-generated field
          obj3.\u0001 = 0L;
          // ISSUE: reference to a compiler-generated field
          obj3.\u0002 = 0L;
          Task[] taskArray1 = new Task[array1.Count];
          for (int index = 0; index < array1.Count; ++index)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: reference to a compiler-generated method
            taskArray1[index] = \u0003\u0082.\u007E\u007F\u0099((object) taskFactory1, new Action(new \u0003.\u0005()
            {
              \u0001 = obj3,
              \u0001 = obj2,
              \u0001 = obj1,
              \u0001 = array1[index]
            }.\u001D\u0005));
          }
          \u0010\u0080.\u001C\u0099(taskArray1);
          ((IEnumerable<Task>) taskArray1).\u001D\u0005<Task>();
          // ISSUE: reference to a compiler-generated method
          Action action1 = new Action(obj1.\u001D\u0005);
          if (this.Canceling)
          {
            array1.\u001D\u0005<\u0003.\u0001>();
            \u001A\u001E.\u007E\u0003\u0092((object) action1);
            return;
          }
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001(\u001D.\u0017.\u0002, \u001B.\u0080.\u0001);
          // ISSUE: reference to a compiler-generated field
          obj3.\u0001 = new List<\u001B.\u001A>();
          // ISSUE: reference to a compiler-generated field
          obj3.\u0001 = new List<Task>();
          // ISSUE: reference to a compiler-generated field
          obj3.\u0001 = new TaskFactory((TaskScheduler) new \u0005(2));
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0003\u0092((object) obj2.\u0001);
          Task[] taskArray2 = new Task[array1.Count];
          for (int index1 = 0; index1 < array1.Count; ++index1)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            \u0003.\u0006 obj4 = new \u0003.\u0006();
            // ISSUE: reference to a compiler-generated field
            obj4.\u0001 = obj3;
            // ISSUE: reference to a compiler-generated field
            obj4.\u0001 = obj2;
            // ISSUE: reference to a compiler-generated field
            obj4.\u0001 = obj1;
            // ISSUE: reference to a compiler-generated field
            obj4.\u0001 = array1[index1];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            obj4.\u0001.Downloader.PacketReceived += new EventHandler<\u0019.\u0019>(obj3.\u001D\u0005);
            bool flag3 = false;
            \u0003.\u0001 obj5;
            try
            {
              // ISSUE: reference to a compiler-generated field
              \u0098\u0082.\u0081\u0098((object) (obj5 = obj4.\u0001), ref flag3);
              Task[] taskArray3 = taskArray2;
              int index2 = index1;
              // ISSUE: reference to a compiler-generated field
              \u0003.\u0001 obj6 = obj4.\u0001;
              TaskFactory taskFactory2 = taskFactory1;
              // ISSUE: reference to a compiler-generated method
              Action action2 = new Action(obj4.\u001D\u0005);
              Task task1;
              Task task2 = task1 = taskFactory2.StartNew(action2);
              obj6.DownloadTask = task1;
              Task task3 = task2;
              taskArray3[index2] = task3;
            }
            finally
            {
              if (flag3)
                \u001A\u001E.\u0082\u0098((object) obj5);
            }
          }
          \u0010\u0080.\u001C\u0099(taskArray2);
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001(\u001D.\u0017.\u0003, \u001B.\u0080.\u0001);
          bool flag4 = false;
          // ISSUE: reference to a compiler-generated field
          \u0098\u0082.\u0081\u0098((object) obj3.\u0001, ref flag4);
          try
          {
            // ISSUE: reference to a compiler-generated field
            while (obj3.\u0001.Count > 0)
            {
              // ISSUE: reference to a compiler-generated field
              Task[] array2 = obj3.\u0001.ToArray();
              // ISSUE: reference to a compiler-generated field
              obj3.\u0001.Clear();
              if (flag4)
              {
                // ISSUE: reference to a compiler-generated field
                \u001A\u001E.\u0082\u0098((object) obj3.\u0001);
                flag4 = false;
              }
              \u0010\u0080.\u001C\u0099(array2);
              ((IEnumerable<Task>) array2).\u001D\u0005<Task>();
              // ISSUE: reference to a compiler-generated field
              \u0098\u0082.\u0081\u0098((object) obj3.\u0001, ref flag4);
            }
          }
          catch (Exception ex)
          {
            \u009C\u001F.\u0016\u0095(\u0002\u007F.\u007E\u0090\u0091((object) ex));
          }
          finally
          {
            if (flag4)
            {
              // ISSUE: reference to a compiler-generated field
              \u001A\u001E.\u0082\u0098((object) obj3.\u0001);
            }
          }
          // ISSUE: reference to a compiler-generated field
          foreach (\u001B.\u001A obj4 in obj3.\u0001)
          {
            \u008F\u0081.\u0090\u009E(obj4.FilePath, obj4.AltFilePath, true);
            // ISSUE: reference to a compiler-generated field
            obj2.\u0001.\u001E\u0005(obj4.AltFilePath);
          }
          if (this.Canceling)
          {
            array1.\u001D\u0005<\u0003.\u0001>();
            \u001A\u001E.\u007E\u0003\u0092((object) action1);
            return;
          }
        }
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001(\u001D.\u0017.\u0005, \u001B.\u0080.\u0001);
        // ISSUE: reference to a compiler-generated field
        \u001A\u001E.\u007E\u0003\u0092((object) obj2.\u0001);
        if (!\u0082.\u0015.\u001D\u0005(this.\u0001, this.\u0002))
        {
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001(\u001D.\u0017.\u0006, \u001B.\u0080.\u0003);
          return;
        }
        if (this.\u0001)
        {
          \u001F.\u0081.\u001D\u0005(this.\u0001);
          if (!this.Canceling)
          {
            // ISSUE: reference to a compiler-generated field
            obj1.\u0001(\u001D.\u0017.\u0007, \u001B.\u0080.\u0001);
            using (List<\u001F.\u0081>.Enumerator enumerator = \u0081.\u0080.Instance.ConnectSettings.ContentPacks.GetEnumerator())
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              \u0003.\u0007 obj3 = new \u0003.\u0007();
              // ISSUE: reference to a compiler-generated field
              obj3.\u0001 = obj2;
              // ISSUE: reference to a compiler-generated field
              obj3.\u0001 = obj1;
              while (enumerator.MoveNext())
              {
                // ISSUE: reference to a compiler-generated field
                obj3.\u0001 = enumerator.Current;
                if (!this.Canceling)
                {
                  // ISSUE: reference to a compiler-generated field
                  switch (obj3.\u0001.InstallState)
                  {
                    case \u001D.\u001D.\u0002:
                      // ISSUE: reference to a compiler-generated field
                      if (!obj3.\u0001.AutoUpdate)
                        continue;
                      goto case \u001D.\u001D.\u0004;
                    case \u001D.\u001D.\u0004:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      if (obj3.\u0001.AutoUpdate || obj3.\u0001.LoaderPack)
                      {
                        MemoryStream memoryStream = new MemoryStream();
                        byte[] numArray;
                        try
                        {
                          // ISSUE: reference to a compiler-generated field
                          string source = \u0002\u007F.\u007E\u0088\u0002\u0002((object) obj3.\u0001.UpdateUri);
                          string str = !source.Contains<char>('?') ? \u0089\u001D.\u0083\u0093((object) source, (object) '?') : \u0089\u001D.\u0083\u0093((object) source, (object) '&');
                          Version fileVersion = \u0008.Current.FileVersion;
                          string uriString;
                          // ISSUE: reference to a compiler-generated field
                          if (obj3.\u0001.VersionType == \u001E.\u0081.\u0001)
                            uriString = \u0081\u0086.\u0086\u0093(str, \u0013\u001C.\u0080\u0093(\u0003.\u0001(68275), (object) \u0005\u0081.\u007E\u0008\u0098((object) fileVersion), (object) \u0005\u0081.\u007E\u000E\u0098((object) fileVersion), (object) \u0005\u0081.\u007E\u000F\u0098((object) fileVersion)));
                          else
                            uriString = \u0081\u0086.\u0086\u0093(str, \u0007\u001E.\u0081\u0093(\u0003.\u0001(68296), new object[4]
                            {
                              (object) \u0005\u0081.\u007E\u0008\u0098((object) fileVersion),
                              (object) \u0005\u0081.\u007E\u000E\u0098((object) fileVersion),
                              (object) \u0005\u0081.\u007E\u000F\u0098((object) fileVersion),
                              (object) \u0005\u0081.\u007E\u0010\u0098((object) fileVersion)
                            }));
                          \u0083.\u0017 obj4 = new \u0083.\u0017(new Uri(uriString), (Stream) memoryStream, false);
                          Task task = new Task(new Action<object>(obj4.\u001E\u0005), (object) \u0092\u001D.\u007E\u000E\u0099((object) this.\u0001));
                          try
                          {
                            \u001A\u001E.\u007E\u0018\u0099((object) task);
                          }
                          finally
                          {
                            if (task != null)
                              \u001A\u001E.\u007E\u0094\u0092((object) task);
                          }
                          if (obj4.DownloadCompleted)
                            numArray = \u0086\u0083.\u007E\u0003\u009F((object) memoryStream);
                          else
                            continue;
                        }
                        finally
                        {
                          if (memoryStream != null)
                            \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
                        }
                        string data = \u0099\u0084.\u007E\u0018\u009C((object) \u001D\u001F.\u0016\u009C(), numArray);
                        bool flag3 = false;
                        // ISSUE: reference to a compiler-generated method
                        Func<\u001F.\u0080, bool> func1 = new Func<\u001F.\u0080, bool>(obj3.\u001D\u0005);
                        \u001F.\u0080 parser;
                        // ISSUE: reference to a compiler-generated field
                        switch (obj3.\u0001.VersionType)
                        {
                          case \u001E.\u0081.\u0001:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (\u001F.\u0080.\u001D\u0005(data, obj3.\u0001.LoaderPack, out parser) && (obj3.\u0001.LoaderPack || \u0080.\u0016.\u001E\u0005(parser.Hash, obj3.\u0001.DataHash)))
                            {
                              flag3 = func1(parser);
                              break;
                            }
                            break;
                          case \u001E.\u0081.\u0002:
                            // ISSUE: reference to a compiler-generated method
                            Func<\u001F.\u0081, \u001F.\u0080, int, bool> func2 = new Func<\u001F.\u0081, \u001F.\u0080, int, bool>(obj2.\u001D\u0005);
                            // ISSUE: reference to a compiler-generated field
                            if (\u001F.\u0080.\u001E\u0005(data, obj3.\u0001.LoaderPack, out parser))
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (obj3.\u0001.LoaderPack)
                              {
                                flag3 = func1(parser);
                                break;
                              }
                              // ISSUE: reference to a compiler-generated field
                              if (\u0080.\u0016.\u001E\u0005(parser.Hash, obj3.\u0001.DataHash) && \u0080.\u0016.\u001E\u0005(parser.Hash, \u0080.\u0016.\u0001))
                              {
                                int startIndex;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                flag3 = parser.Patches == null || !parser.\u001D\u0005(obj3.\u0001.DataHash, obj3.\u0001.ContentPackVersion, out startIndex) ? func1(parser) : func2(obj3.\u0001, parser, startIndex);
                                break;
                              }
                              break;
                            }
                            break;
                        }
                        if (flag3)
                        {
                          // ISSUE: reference to a compiler-generated field
                          obj3.\u0001.\u001D\u0005();
                          continue;
                        }
                        continue;
                      }
                      continue;
                    default:
                      continue;
                  }
                }
                else
                  break;
              }
            }
            // ISSUE: reference to a compiler-generated field
            obj1.\u0001(\u001D.\u0017.\u000F, \u001B.\u0080.\u0001);
            HashSet<string> changedMultiFiles;
            \u001F.\u0081.\u001D\u0005(this.\u0002, out changedMultiFiles);
            // ISSUE: reference to a compiler-generated field
            obj1.\u0001(\u001D.\u0017.\u0004, \u001B.\u0080.\u0001);
            // ISSUE: reference to a compiler-generated field
            obj2.\u0001.Properties = this.\u0001.Properties.\u0001();
            // ISSUE: reference to a compiler-generated field
            obj2.\u0001.\u001D\u0005(this.\u0001, changedMultiFiles, this.\u0002);
          }
        }
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001(\u001D.\u0017.\u0006, \u001B.\u0080.\u0003);
        return;
      }
      finally
      {
        \u0081.\u0080.\u001D\u0005();
        \u0088\u0081.\u0004\u0096();
      }
      if (this.Canceling)
      {
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001(\u001D.\u0017.\u0006, \u001B.\u0080.\u0004);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001(\u001D.\u0017.\u0006, \u001B.\u0080.\u0001);
      }
    }

    private sealed class \u0001 : \u0004.\u0002
    {
      public \u001B.\u001A FileUpdateDetails { get; private set; }

      public \u001A.\u001B PatchDetails { get; private set; }

      public Task DownloadTask { get; set; }

      public \u0003.\u0001 NextPatchDownloadData { get; set; }

      public \u0004 Downloader { get; set; }

      public \u0004.\u0003 DownloadState { get; set; }

      public bool IsFirstPatch { get; private set; }

      public \u0001(\u001B.\u001A fileUpdateDetails, \u001A.\u001B patchDetails, bool isFirstPatch, Stream destinationStream, Queue<Uri> remotePaths)
        : base(destinationStream, remotePaths)
      {
        this.DownloadState = \u0004.\u0003.\u0001;
        this.FileUpdateDetails = fileUpdateDetails;
        this.PatchDetails = patchDetails;
        this.IsFirstPatch = isFirstPatch;
      }

      public \u0001(\u001B.\u001A fileUpdateDetails, Stream destinationStream, Queue<Uri> remotePaths)
        : this(fileUpdateDetails, (\u001A.\u001B) null, false, destinationStream, remotePaths)
      {
      }
    }
  }
}
