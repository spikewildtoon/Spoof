// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0015;
using \u0017;
using \u0019;
using \u0081;
using \u0084;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace \u001A
{
  internal sealed class \u001C : \u0016
  {
    private int \u0002 = 500;
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly int \u0001;
    private \u001F.\u007F \u0001;
    private bool \u0001;
    private Stream \u0001;
    private \u001B.\u001B \u0001;
    private readonly string \u0001;
    private readonly object \u0001;
    private readonly byte[] \u0001;
    private readonly StringBuilder \u0001;
    private readonly ManualResetEventSlim \u0001;
    private ManualResetEventSlim \u0002;
    private bool \u0002;

    public string LogFileName
    {
      get
      {
        return this.\u0001;
      }
    }

    public bool Running
    {
      get
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
          return this.\u0001;
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
    }

    private bool HasData
    {
      get
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
          return \u001F\u001E.\u007E\u0080\u009D((object) this.\u0001) != \u001F\u001E.\u007E\u0081\u009D((object) this.\u0001);
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
    }

    public \u001F.\u007F LogMonitoringPrecision
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
        switch (this.\u0001)
        {
          case \u001F.\u007F.\u0001:
            this.\u0002 = 1000;
            break;
          case \u001F.\u007F.\u0003:
            this.\u0002 = 10;
            break;
          default:
            this.\u0002 = 500;
            break;
        }
      }
    }

    public event EventHandler ReadingPaused;

    public event EventHandler<\u0014.\u0015> FileStateRead;

    public event EventHandler<\u001D.\u0019> InvasionStateChanged;

    public event EventHandler<\u0018> CoordinatesChanged;

    public event EventHandler<\u007F.\u001D> DistrictChanged;

    public event EventHandler<\u0016> AvailableDistrictsChanged;

    public event EventHandler NoInvasionDetected;

    public event EventHandler<\u001C.\u001E> PlaygroundChanged;

    public event EventHandler LoggedOut;

    static \u001C()
    {
      \u0004.\u001D\u0005(typeof (\u001A.\u001C));
      \u001A.\u001C.\u0001 = 1024;
    }

    private \u001C()
    {
      this.LogMonitoringPrecision = \u001F.\u007F.\u0002;
      this.\u0001 = new StringBuilder();
      this.\u0001 = new byte[\u001A.\u001C.\u0001];
      this.\u0001 = new object();
      this.\u0001 = new ManualResetEventSlim(false);
    }

    public \u001C(Stream str)
      : this()
    {
      this.\u0001 = str;
    }

    public \u001C(string logFile)
      : this()
    {
      this.\u0001 = logFile;
      this.\u0001 = (Stream) new FileStream(this.\u0001, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
    }

    protected override void \u001D\u0005()
    {
      this.\u0082\u0005();
      \u001A\u001E.\u007E\u0007\u0099((object) this.\u0001);
      StringBuilder stringBuilder = \u008C\u001F.\u007E\u009B\u0093((object) this.\u0001);
      base.\u001D\u0005();
    }

    public void \u0081\u0005()
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
        if (this.\u0001)
          return;
        this.\u0001 = true;
        \u001A\u001E.\u007E\u0003\u0099((object) this.\u0001);
        IAsyncResult asyncResult = \u0093\u001D.\u007E\u0089\u009D((object) this.\u0001, this.\u0001, 0, \u001A.\u001C.\u0001, new AsyncCallback(this.\u001D\u0005), (object) null);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    public void \u0082\u0005()
    {
      bool flag = false;
      try
      {
        \u0098\u0082.\u0081\u0098(this.\u0001, ref flag);
        if (!this.\u0001)
          return;
        ManualResetEventSlim manualResetEventSlim = this.\u0002 = new ManualResetEventSlim(false);
        try
        {
          this.\u0001 = false;
          \u001A\u001E.\u007E\u0002\u0099((object) this.\u0001);
          if (flag)
          {
            flag = false;
            \u001A\u001E.\u0082\u0098(this.\u0001);
          }
          \u001A\u001E.\u007E\u0004\u0099((object) this.\u0002);
          \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
        }
        finally
        {
          if (manualResetEventSlim != null)
            \u001A\u001E.\u007E\u0094\u0092((object) manualResetEventSlim);
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(this.\u0001);
        if (!this.IsDisposing)
          this.Dispose();
      }
    }

    private void \u0083\u0005()
    {
      while (this.\u0001 && !this.HasData)
      {
        int num = \u0095\u0081.\u007E\u0006\u0099((object) this.\u0001, this.\u0002) ? 1 : 0;
      }
    }

    private void \u001D\u0005(IAsyncResult asyncResult)
    {
      try
      {
        bool flag1 = false;
        object obj1;
        int num;
        try
        {
          \u0098\u0082.\u0081\u0098(obj1 = this.\u0001, ref flag1);
          num = \u0088\u0080.\u007E\u008A\u009D((object) this.\u0001, asyncResult);
        }
        finally
        {
          if (flag1)
            \u001A\u001E.\u0082\u0098(obj1);
        }
        for (int index = 0; index < num; ++index)
        {
          switch ((char) this.\u0001[index])
          {
            case '\n':
            case '\r':
              if (\u0005\u0081.\u007E\u009C\u0093((object) this.\u0001) > 0)
              {
                bool flag2 = false;
                object obj2;
                try
                {
                  \u0098\u0082.\u0081\u0098(obj2 = this.\u0001, ref flag2);
                  if (!this.\u0001)
                    return;
                  this.\u001D\u0005(\u0002\u007F.\u007E\u0087\u0091((object) this.\u0001));
                }
                finally
                {
                  if (flag2)
                    \u001A\u001E.\u0082\u0098(obj2);
                }
                StringBuilder stringBuilder = \u008C\u001F.\u007E\u009B\u0093((object) this.\u0001);
                break;
              }
              break;
            default:
              StringBuilder stringBuilder1 = \u0084\u007F.\u007E\u009E\u0093((object) this.\u0001, (char) this.\u0001[index]);
              break;
          }
        }
        if (this.HasData)
          return;
        if (this.\u0001 != null)
          \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
        this.\u0083\u0005();
      }
      finally
      {
        bool flag = false;
        object obj;
        try
        {
          \u0098\u0082.\u0081\u0098(obj = this.\u0001, ref flag);
          if (this.\u0002 == null)
          {
            if (this.\u0001)
            {
              IAsyncResult asyncResult1 = \u0093\u001D.\u007E\u0089\u009D((object) this.\u0001, this.\u0001, 0, \u001A.\u001C.\u0001, new AsyncCallback(this.\u001D\u0005), (object) null);
            }
          }
          else
            \u001A\u001E.\u007E\u0002\u0099((object) this.\u0002);
        }
        finally
        {
          if (flag)
            \u001A\u001E.\u0082\u0098(obj);
        }
      }
    }

    private void \u0084\u0005()
    {
      if (this.\u0002 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
    }

    private void \u001D\u0005(\u001B.\u001B state)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0014.\u0015(state));
    }

    private void \u001D\u0005(\u001A.\u001E state)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u001D.\u0019(state));
    }

    private void \u001D\u0005(\u0006 coords)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0018(coords));
    }

    private void \u001D\u0005(uint shardID)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u007F.\u001D(shardID));
    }

    private void \u0086\u0005()
    {
      if (this.\u0003 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0003, (object) this, EventArgs.Empty);
    }

    private void \u001D\u0005(HashSet<uint> shards)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u0016(shards));
    }

    private void \u001D\u0005(string filePath, string fileName)
    {
      string key;
      if ((key = \u0002\u007F.\u007E\u0019\u0093((object) fileName)) == null)
        return;
      // ISSUE: reference to a compiler-generated field
      if (\u0080.\u0001 == null)
      {
        // ISSUE: reference to a compiler-generated field
        \u0080.\u0001 = new Dictionary<string, int>(31)
        {
          {
            \u001A.\u001C.\u0001(49841),
            0
          },
          {
            \u001A.\u001C.\u0001(49858),
            1
          },
          {
            \u001A.\u001C.\u0001(49891),
            2
          },
          {
            \u001A.\u001C.\u0001(49928),
            3
          },
          {
            \u001A.\u001C.\u0001(49965),
            4
          },
          {
            \u001A.\u001C.\u0001(50002),
            5
          },
          {
            \u001A.\u001C.\u0001(50031),
            6
          },
          {
            \u001A.\u001C.\u0001(50060),
            7
          },
          {
            \u001A.\u001C.\u0001(50085),
            8
          },
          {
            \u001A.\u001C.\u0001(50114),
            9
          },
          {
            \u001A.\u001C.\u0001(50147),
            10
          },
          {
            \u001A.\u001C.\u0001(50180),
            11
          },
          {
            \u001A.\u001C.\u0001(50213),
            12
          },
          {
            \u001A.\u001C.\u0001(50242),
            13
          },
          {
            \u001A.\u001C.\u0001(50271),
            14
          },
          {
            \u001A.\u001C.\u0001(50300),
            15
          },
          {
            \u001A.\u001C.\u0001(50329),
            16
          },
          {
            \u001A.\u001C.\u0001(50366),
            17
          },
          {
            \u001A.\u001C.\u0001(50407),
            18
          },
          {
            \u001A.\u001C.\u0001(50448),
            19
          },
          {
            \u001A.\u001C.\u0001(50489),
            20
          },
          {
            \u001A.\u001C.\u0001(50514),
            21
          },
          {
            \u001A.\u001C.\u0001(50543),
            22
          },
          {
            \u001A.\u001C.\u0001(50572),
            23
          },
          {
            \u001A.\u001C.\u0001(50601),
            24
          },
          {
            \u001A.\u001C.\u0001(50634),
            25
          },
          {
            \u001A.\u001C.\u0001(50671),
            26
          },
          {
            \u001A.\u001C.\u0001(50708),
            27
          },
          {
            \u001A.\u001C.\u0001(50737),
            28
          },
          {
            \u001A.\u001C.\u0001(50766),
            29
          },
          {
            \u001A.\u001C.\u0001(50795),
            30
          }
        };
      }
      int num;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: explicit non-virtual call
      if (!__nonvirtual (\u0080.\u0001.TryGetValue(key, out num)))
        return;
      switch (num)
      {
        case 0:
          this.\u001D\u0005(\u001A.\u0019.\u0002);
          break;
        case 1:
          this.\u001D\u0005(\u001A.\u0019.\u0003);
          break;
        case 2:
          this.\u001D\u0005(\u001A.\u0019.\u0005);
          break;
        case 3:
          this.\u001D\u0005(\u001A.\u0019.\u0004);
          break;
        case 4:
          this.\u001D\u0005(\u001A.\u0019.\u0006);
          break;
        case 5:
          this.\u001D\u0005(\u001A.\u0019.\u0007);
          break;
        case 6:
          this.\u001D\u0005(\u001A.\u0019.\u0008);
          break;
        case 7:
          this.\u001D\u0005(\u001A.\u0019.\u000E);
          break;
        case 8:
          this.\u001D\u0005(\u001A.\u0019.\u000F);
          break;
        case 9:
          this.\u001D\u0005(\u001A.\u0019.\u0011);
          break;
        case 10:
          this.\u001D\u0005(\u001A.\u0019.\u0010);
          break;
        case 11:
          this.\u001D\u0005(\u001A.\u0019.\u0012);
          break;
        case 12:
          this.\u001D\u0005(\u001A.\u0019.\u0013);
          break;
        case 13:
          this.\u001D\u0005(\u001A.\u0019.\u0015);
          break;
        case 14:
          this.\u001D\u0005(\u001A.\u0019.\u0016);
          break;
        case 15:
          this.\u001D\u0005(\u001A.\u0019.\u0014);
          break;
        case 16:
          this.\u001D\u0005(\u001A.\u0019.\u0017);
          break;
        case 17:
          this.\u001D\u0005(\u001A.\u0019.\u001A);
          break;
        case 18:
          this.\u001D\u0005(\u001A.\u0019.\u0019);
          break;
        case 19:
          this.\u001D\u0005(\u001A.\u0019.\u0018);
          break;
        case 20:
          this.\u001D\u0005(\u001A.\u0019.\u001B);
          break;
        case 21:
          this.\u001D\u0005(\u001A.\u0019.\u001C);
          break;
        case 22:
          this.\u001D\u0005(\u001A.\u0019.\u001E);
          break;
        case 23:
          this.\u001D\u0005(\u001A.\u0019.\u001D);
          break;
        case 24:
          this.\u001D\u0005(\u001A.\u0019.\u001F);
          break;
        case 25:
          this.\u001D\u0005(\u001A.\u0019.\u007F);
          break;
        case 26:
          this.\u001D\u0005(\u001A.\u0019.\u0080);
          break;
        case 27:
          this.\u001D\u0005(\u001A.\u0019.\u0082);
          break;
        case 28:
          this.\u001D\u0005(\u001A.\u0019.\u0083);
          break;
        case 29:
          this.\u001D\u0005(\u001A.\u0019.\u0084);
          break;
        case 30:
          this.\u001D\u0005(\u001A.\u0019.\u0086);
          break;
      }
    }

    private void \u001D\u0005(string id)
    {
      string str;
      if ((str = id) == null || !\u0008\u001F.\u009A\u0092(str, \u001A.\u001C.\u0001(50812)))
        return;
      this.\u001D\u0005(\u001A.\u0019.\u0081);
    }

    private void \u001D\u0005(\u001A.\u0019 playground)
    {
      if (this.\u0001 == null)
        return;
      this.\u0001((object) this, new \u001C.\u001E(playground));
    }

    private void \u0087\u0005()
    {
      this.\u001D\u0005(\u001A.\u0019.\u0001);
    }

    public bool \u001D\u0005(string line)
    {
      if (\u008F\u0084.\u009E\u0092(line))
        return false;
      char ch = \u008C\u0086.\u007E\u009C\u0092((object) line, 0);
      switch (ch)
      {
        case ':':
          DateTime dateTime;
          string data1;
          if (\u001A.\u001C.\u001D\u0005(line, out dateTime, out data1))
          {
            \u001A.\u001E? state;
            if (\u001A.\u001C.\u001D\u0005(data1, out state))
            {
              this.\u0002 = false;
              this.\u001D\u0005(state.Value);
              return true;
            }
            string data2;
            if (\u001A.\u001C.\u001F\u0005(data1, out data2))
            {
              uint shardID;
              if (\u001A.\u001C.\u001D\u0005(data2, out shardID))
              {
                this.\u0002 = true;
                this.\u001D\u0005(shardID);
                return true;
              }
              if (\u001A.\u001C.\u007F\u0005(data2))
              {
                this.\u0002 = false;
                this.\u0086\u0005();
                return true;
              }
              break;
            }
            if (this.\u0002 && \u001A.\u001C.\u001F\u0005(data1))
            {
              this.\u0002 = false;
              this.\u0084\u0005();
              return true;
            }
            string data3;
            if (\u001A.\u001C.\u0080\u0005(data1, out data3))
            {
              string phaseName;
              if (\u001A.\u001C.\u007F\u0005(data3, out phaseName))
              {
                this.\u0001 = new \u001B.\u001B(phaseName);
                return true;
              }
              if (this.\u0001 != null)
              {
                bool exists;
                if (\u001A.\u001C.\u001E\u0005(data3, out exists))
                {
                  this.\u0001.FileExists = exists;
                  if (!exists)
                    this.\u001D\u0005(this.\u0001);
                  return true;
                }
                string clientMd5;
                string expectedMd5;
                if (\u001A.\u001C.\u001D\u0005(data3, out clientMd5, out expectedMd5))
                {
                  this.\u0001.ClientMd5 = clientMd5;
                  this.\u0001.ExpectedMd5 = expectedMd5;
                  return true;
                }
                int clientSize;
                int expectedSize;
                if (\u001A.\u001C.\u001D\u0005(data3, out clientSize, out expectedSize))
                {
                  this.\u0001.ClientSize = clientSize;
                  this.\u0001.ExpectedSize = expectedSize;
                  return true;
                }
                bool upToDate;
                if (\u001A.\u001C.\u001D\u0005(data3, out upToDate))
                {
                  this.\u0001.UpToDate = upToDate;
                  this.\u001D\u0005(this.\u0001);
                  this.\u0001 = (\u001B.\u001B) null;
                  return true;
                }
                break;
              }
              break;
            }
            string filePath;
            if (\u001A.\u001C.\u001E\u0005(data1, out filePath))
            {
              int startIndex = 0;
              string fileName;
              if (filePath.\u001E\u0005('/', ref startIndex) && filePath.\u001D\u0005(ref startIndex, out fileName))
              {
                this.\u001D\u0005(filePath, fileName);
                return true;
              }
              break;
            }
            string id;
            if (\u001A.\u001C.\u001D\u0005(data1, out id))
            {
              this.\u001D\u0005(id);
              return true;
            }
            if (\u001A.\u001C.\u001E\u0005(data1))
            {
              this.\u0087\u0005();
              return true;
            }
            break;
          }
          break;
        case 'C':
          \u0006? coords;
          if (\u0016\u001D.\u007E\u0017\u0093((object) line, \u001A.\u001C.\u0001(50821)) && \u001A.\u001C.\u001D\u0005(line, out coords))
          {
            this.\u001D\u0005(coords.Value);
            return true;
          }
          break;
        default:
          HashSet<uint> shards;
          if ((int) ch == 123 && \u001A.\u001C.\u001D\u0005(line, out shards))
          {
            this.\u001D\u0005(shards);
            return true;
          }
          break;
      }
      return false;
    }

    private static bool \u001E\u0005(string line)
    {
      return line.\u001D\u0005(\u001A.\u001C.\u0001(50846));
    }

    private static bool \u001D\u0005(string line, out string id)
    {
      int startIndex = 0;
      id = (string) null;
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(50887), ref startIndex))
        return false;
      return line.\u001D\u0005(ref startIndex, out id);
    }

    private static bool \u001E\u0005(string line, out string filePath)
    {
      int startIndex = 0;
      filePath = (string) null;
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(50936), ref startIndex))
        return false;
      return line.\u001D\u0005(ref startIndex, out filePath);
    }

    private static bool \u001F\u0005(string line)
    {
      return line.\u001D\u0005(\u001A.\u001C.\u0001(50957));
    }

    private static bool \u001D\u0005(string line, out HashSet<uint> shards)
    {
      shards = (HashSet<uint>) null;
      int startIndex = 0;
      if (!line.\u001D\u0005('{', ref startIndex))
        return false;
      shards = new HashSet<uint>();
      uint shard;
      while (\u001A.\u001C.\u001D\u0005(line, ref startIndex, out shard))
      {
        if (!shards.Contains(shard))
          shards.Add(shard);
        if (!line.\u001D\u0005(\u001A.\u001C.\u0001(28624), ref startIndex))
          break;
      }
      return true;
    }

    private static bool \u001D\u0005(string line, ref int startIndex, out uint shard)
    {
      shard = 0U;
      string str;
      return line.\u001D\u0005(':', ref startIndex, out str) && \u001F\u0081.\u009D\u0097(str, ref shard) && (line.\u001D\u0005(\u001A.\u001C.\u0001(51022), ref startIndex) && line.\u001D\u0005('>', ref startIndex));
    }

    private static bool \u001F\u0005(string line, out string data)
    {
      data = (string) null;
      int startIndex = 0;
      string str;
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(51115), ref startIndex) || !line.\u001D\u0005(ref startIndex, out str) || \u008F\u0084.\u009E\u0092(str))
        return false;
      data = str;
      return true;
    }

    private static bool \u007F\u0005(string line)
    {
      return line.\u001D\u0005(\u001A.\u001C.\u0001(51144));
    }

    private static bool \u001D\u0005(string line, out uint shardID)
    {
      shardID = 0U;
      int startIndex = 0;
      string str;
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(51165), ref startIndex) || !line.\u001D\u0005(ref startIndex, out str))
        return false;
      return \u001F\u0081.\u009D\u0097(str, ref shardID);
    }

    private static bool \u001D\u0005(string line, out int clientSize, out int expectedSize)
    {
      clientSize = 0;
      expectedSize = 0;
      int startIndex = 0;
      string str;
      int num1;
      int num2;
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(51186), ref startIndex) || !line.\u001D\u0005(' ', ref startIndex, out str) || (!\u0090\u0081.\u001A\u0096(\u0002\u007F.\u007E\u001B\u0093((object) str), ref num1) || !line.\u001D\u0005(\u001A.\u001C.\u0001(51203), ref startIndex) || (!line.\u001D\u0005(ref startIndex, out str) || !\u0090\u0081.\u001A\u0096(\u0002\u007F.\u007E\u001B\u0093((object) str), ref num2))))
        return false;
      clientSize = num1;
      expectedSize = num2;
      return true;
    }

    private static bool \u001D\u0005(string line, out string clientMd5, out string expectedMd5)
    {
      clientMd5 = (string) null;
      expectedMd5 = (string) null;
      int startIndex = 0;
      string str1;
      string str2;
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(51224), ref startIndex) || !line.\u001D\u0005(' ', ref startIndex, out str1) || (!line.\u001D\u0005(\u001A.\u001C.\u0001(51241), ref startIndex) || !line.\u001D\u0005(ref startIndex, out str2)))
        return false;
      string str3 = \u0002\u007F.\u007E\u0019\u0093((object) \u0002\u007F.\u007E\u001B\u0093((object) str1));
      string str4 = \u0002\u007F.\u007E\u0019\u0093((object) \u0002\u007F.\u007E\u001B\u0093((object) str2));
      if (\u0005\u0081.\u007E\u0001\u0093((object) str3) != 32 || \u0005\u0081.\u007E\u0001\u0093((object) str4) != 32)
        return false;
      clientMd5 = str3;
      expectedMd5 = str4;
      return true;
    }

    private static bool \u001D\u0005(string line, out bool upToDate)
    {
      upToDate = false;
      if (line.\u001D\u0005(\u001A.\u001C.\u0001(51262)))
      {
        upToDate = true;
        return true;
      }
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(51287)))
        return false;
      upToDate = false;
      return true;
    }

    private static bool \u001E\u0005(string line, out bool exists)
    {
      exists = false;
      if (line.\u001D\u0005(\u001A.\u001C.\u0001(51312)))
      {
        exists = true;
        return true;
      }
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(51329)))
        return false;
      exists = false;
      return true;
    }

    private static bool \u007F\u0005(string line, out string phaseName)
    {
      phaseName = (string) null;
      int startIndex = 0;
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(51358), ref startIndex))
        return false;
      line.\u001D\u0005(\u001A.\u001C.\u0001(51375), ref startIndex);
      string str1;
      if (!line.\u001D\u0005(ref startIndex, out str1))
        return false;
      string str2 = \u0002\u007F.\u007E\u0019\u0093((object) str1);
      if (\u0089\u0086.\u007E\u0014\u0093((object) str2, \u001A.\u001C.\u0001(51380)) == -1)
        return false;
      phaseName = str2;
      return true;
    }

    private static bool \u0080\u0005(string line, out string data)
    {
      data = (string) null;
      int startIndex = 0;
      string str;
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(51385), ref startIndex) || !line.\u001D\u0005(ref startIndex, out str))
        return false;
      data = str;
      return true;
    }

    private static bool \u001D\u0005(string line, out \u001A.\u001E? state)
    {
      state = new \u001A.\u001E?();
      int startIndex = 0;
      string str;
      byte num1;
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(51402), ref startIndex) || !line.\u001D\u0005(' ', ref startIndex, out str) || (!\u0097\u001B.\u0006\u0095(str, ref num1) || !line.\u001D\u0005(\u001A.\u001C.\u0001(51415), ref startIndex) || !line.\u001D\u0005(',', ref startIndex, out str)))
        return false;
      string key = str;
      uint cogsRemaining;
      int num2;
      if (!line.\u001D\u0005(\u001A.\u001C.\u0001(51428), ref startIndex) || !line.\u001D\u0005(',', ref startIndex, out str) || (!\u001F\u0081.\u009D\u0097(str, ref cogsRemaining) || !line.\u001D\u0005(\u001A.\u001C.\u0001(51449), ref startIndex)) || (!line.\u001D\u0005(ref startIndex, out str) || !\u0090\u0081.\u001A\u0096(str, ref num2)))
        return false;
      \u0006 cog = !\u0006.Cogs.ContainsKey(key) ? \u0006.\u0001 : \u0006.Cogs[key];
      state = new \u001A.\u001E?(new \u001A.\u001E((\u007F.\u001B) num1, cog, cogsRemaining, num2 != 0));
      return true;
    }

    private static bool \u001D\u0005(string line, out DateTime dateTime, out string data)
    {
      dateTime = new DateTime();
      data = (string) null;
      int startIndex = 1;
      string str = (string) null;
      byte num1;
      byte num2;
      short num3;
      byte num4;
      byte num5;
      byte num6;
      if (!line.\u001D\u0005('-', ref startIndex, out str) || !\u0097\u001B.\u0006\u0095(str, ref num1) || (!line.\u001D\u0005('-', ref startIndex, out str) || (!\u0097\u001B.\u0006\u0095(str, ref num2) || !line.\u001D\u0005(' ', ref startIndex, out str)) || (!\u0093\u0084.\u0016\u0096(str, ref num3) || !line.\u001D\u0005(':', ref startIndex, out str) || (!\u0097\u001B.\u0006\u0095(str, ref num4) || !line.\u001D\u0005(':', ref startIndex, out str))) || (!\u0097\u001B.\u0006\u0095(str, ref num5) || !line.\u001D\u0005(' ', ref startIndex, out str) || !\u0097\u001B.\u0006\u0095(str, ref num6))))
        return false;
      dateTime = new DateTime((int) num3, (int) num1, (int) num2, (int) num4, (int) num5, (int) num6);
      data = startIndex < \u0005\u0081.\u007E\u0001\u0093((object) line) ? \u009C\u007F.\u007E\u0005\u0093((object) line, startIndex) : (string) null;
      return true;
    }

    private static bool \u001D\u0005(string line, out \u0006? coords)
    {
      coords = new \u0006?();
      int startIndex = 0;
      string str;
      if (!line.\u001D\u0005('=', ref startIndex) || !line.\u001D\u0005('(', ref startIndex) || !line.\u001D\u0005(')', ref startIndex, out str))
        return false;
      string[] strArray = \u0093\u0082.\u007E\u0003\u0093((object) str, new char[2]{ ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
      float x;
      float y;
      float z;
      float num;
      if (strArray.Length != 3 || !\u001C\u001E.\u0080\u0097(strArray[0], ref x) || (!\u001C\u001E.\u0080\u0097(strArray[1], ref y) || !\u001C\u001E.\u0080\u0097(strArray[2], ref z)) || (!line.\u001D\u0005(\u001A.\u001C.\u0001(51466), ref startIndex) || !line.\u001D\u0005(',', ref startIndex, out str) || !\u001C\u001E.\u0080\u0097(str, ref num)))
        return false;
      float h = num % 360f;
      if ((double) h < 0.0)
        h += 360f;
      coords = new \u0006?(new \u0006(x, y, z, h));
      return true;
    }

    public static void \u001D\u0005(string directory, int maxLogFiles)
    {
      foreach (string str in ((IEnumerable<string>) \u0012.\u001D\u0005(directory, \u001A.\u001C.\u0001(42657), \u001A.\u001C.\u0001(42678))).OrderByDescending<string, string>((Func<string, string>) (file => file)).Skip<string>(maxLogFiles).ToArray<string>())
      {
        try
        {
          \u009C\u001F.\u0091\u009E(str);
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005((object) str);
        }
      }
    }
  }
}
