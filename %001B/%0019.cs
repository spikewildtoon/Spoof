// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0017;
using \u0019;
using \u001D;
using \u001E;
using \u0084;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace \u001B
{
  internal sealed class \u0019 : \u0014.\u0080
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    protected override int? Version
    {
      get
      {
        return new int?(2);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 2;
      }
    }

    protected override int MinimumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override byte[] Header
    {
      get
      {
        return new byte[3]{ (byte) 80, (byte) 80, (byte) 83 };
      }
    }

    public \u001B.\u0019.\u0001 Properties { get; set; }

    public List<Uri> DownloadUrls { get; private set; }

    public Dictionary<string, \u0015> FILES { get; private set; }

    static \u0019()
    {
      \u0004.\u001D\u0005(typeof (\u001B.\u0019));
    }

    public \u0019()
    {
      this.DownloadUrls = new List<Uri>();
      this.FILES = new Dictionary<string, \u0015>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      this.Properties = new \u001B.\u0019.\u0001();
    }

    public \u0019(BinaryReader reader)
      : base(reader)
    {
    }

    public void \u001D\u0005(\u001B.\u0019 data)
    {
      this.Properties = data.Properties.\u0001();
      this.DownloadUrls = new List<Uri>((IEnumerable<Uri>) data.DownloadUrls);
      this.FILES = new Dictionary<string, \u0015>((IDictionary<string, \u0015>) data.FILES);
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.DownloadUrls = new List<Uri>();
      this.FILES = new Dictionary<string, \u0015>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      this.Properties = new \u001B.\u0019.\u0001();
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) this.FILES), ref flag);
        this.FILES.Clear();
        int num = (int) \u0011\u001C.\u007E\u0097\u009D((object) reader);
        for (short index = 0; (int) index < num; ++index)
        {
          \u0015 obj2 = new \u0015();
          string key = \u0002\u007F.\u007E\u0001\u009E((object) reader);
          obj2.Version = \u0002\u007F.\u007E\u0001\u009E((object) reader);
          obj2.ExpectedSize = \u001F\u001E.\u007E\u009B\u009D((object) reader);
          obj2.ExpectedHash = \u009F\u001D.\u007E\u0093\u009D((object) reader).\u001D\u0005();
          obj2.ForceRecheck = version > 1 && \u0099\u0082.\u007E\u0095\u009D((object) reader);
          this.FILES.Add(key, obj2);
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) this.FILES), ref flag);
        \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.FILES.Count);
        foreach (KeyValuePair<string, \u0015> keyValuePair in this.FILES)
        {
          \u0092\u0081.\u007E\u001A\u009E((object) writer, keyValuePair.Key);
          \u0092\u0081.\u007E\u001A\u009E((object) writer, keyValuePair.Value.Version);
          \u0012\u0080.\u007E\u0017\u009E((object) writer, keyValuePair.Value.ExpectedSize);
          \u009F\u001D.\u007E\u0007\u009E((object) writer).\u001D\u0005(keyValuePair.Value.ExpectedHash);
          \u0099\u001F.\u007E\u000E\u009E((object) writer, keyValuePair.Value.ForceRecheck);
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    public void \u001D\u0005(string name, \u001A.\u001B patch, \u0080.\u0016? hashOverride = null, long? sizeOverride = null)
    {
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) this.FILES), ref flag);
        \u0015 obj2 = patch.\u001D\u0005();
        if (hashOverride.HasValue)
          obj2.ExpectedHash = hashOverride.Value;
        if (sizeOverride.HasValue)
          obj2.ExpectedSize = sizeOverride.Value;
        if (this.FILES.ContainsKey(name))
          this.FILES[name] = obj2;
        else
          this.FILES.Add(name, obj2);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    public void \u001D\u0005(string name, \u0015 file, \u0080.\u0016? hashOverride = null, long? sizeOverride = null)
    {
      \u0015 file1 = file.\u001D\u0005();
      if (hashOverride.HasValue)
        goto label_3;
label_1:
      if (sizeOverride.HasValue)
        goto label_4;
label_2:
      this.\u001D\u0005(name, file1);
      return;
label_4:
      file1.ExpectedSize = sizeOverride.Value;
      goto label_2;
label_3:
      file1.ExpectedHash = hashOverride.Value;
      goto label_1;
    }

    private void \u001D\u0005(string name, \u0015 file)
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) this.FILES), ref flag);
        if (this.FILES.ContainsKey(name))
          this.FILES[name] = file;
        else
          this.FILES.Add(name, file);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    public void \u001D\u0005(\u001B.\u0019 data, HashSet<string> filesUpdated, string installPath)
    {
      bool flag1 = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) this.FILES), ref flag1);
        bool flag2 = false;
        HashSet<string> stringSet;
        try
        {
          \u0098\u0082.\u0081\u0098((object) (stringSet = filesUpdated), ref flag2);
          if (data == null)
          {
            foreach (string str1 in filesUpdated)
            {
              string key = \u0081\u0086.\u0086\u0093(str1, \u001B.\u0019.\u0001(51590));
              string str2 = \u0081\u0086.\u0011\u009F(installPath, key);
              \u0015 obj2 = new \u0015(\u0012.\u001D\u0005(str2), \u0004.\u001D\u0005(str2), (string) null);
              if (this.FILES.ContainsKey(key))
              {
                obj2.Version = this.FILES[key].Version;
                this.FILES[key] = obj2;
              }
              else
                this.FILES.Add(key, obj2);
            }
          }
          else
          {
            bool flag3 = false;
            object obj2;
            try
            {
              \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) data.FILES), ref flag3);
              foreach (string str1 in filesUpdated)
              {
                string key = \u0081\u0086.\u0086\u0093(str1, \u001B.\u0019.\u0001(51590));
                string str2 = \u0081\u0086.\u0011\u009F(installPath, key);
                \u0015 obj3 = new \u0015(\u0012.\u001D\u0005(str2), \u0004.\u001D\u0005(str2), data.FILES[key].Version);
                if (this.FILES.ContainsKey(key))
                  this.FILES[key] = obj3;
                else
                  this.FILES.Add(key, obj3);
              }
              foreach (KeyValuePair<string, \u0015> keyValuePair in data.FILES)
              {
                if (!this.FILES.ContainsKey(keyValuePair.Key))
                  this.FILES.Add(keyValuePair.Key, keyValuePair.Value.\u001D\u0005());
                else
                  this.FILES[keyValuePair.Key].Version = keyValuePair.Value.Version;
              }
            }
            finally
            {
              if (flag3)
                \u001A\u001E.\u0082\u0098(obj2);
            }
          }
        }
        finally
        {
          if (flag2)
            \u001A\u001E.\u0082\u0098((object) stringSet);
        }
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    public Dictionary<string, \u001B.\u001A> \u001D\u0005(\u001B.\u0019 data, string installFolder, bool usingVirtualServer, bool canMoveOrInstallFiles, HashSet<string> changedFiles, out bool success)
    {
      Dictionary<string, \u001B.\u001A> dictionary = new Dictionary<string, \u001B.\u001A>();
      success = true;
      bool flag1 = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) this.FILES), ref flag1);
        bool flag2 = false;
        object obj2;
        try
        {
          \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) data.FILES), ref flag2);
          foreach (KeyValuePair<string, \u0015> keyValuePair in data.FILES)
          {
            \u001B.\u0019.\u0002 obj3;
            bool flag3;
            if (usingVirtualServer && \u007F.\u001D\u0005(keyValuePair.Key))
            {
              obj3 = new \u001B.\u0019.\u0002(keyValuePair.Key, \u0081\u0086.\u0086\u0093(keyValuePair.Key, \u001B.\u0019.\u0001(55501)), \u0081\u0086.\u0011\u009F(installFolder, \u0081\u0086.\u0086\u0093(keyValuePair.Key, \u001B.\u0019.\u0001(55501))), keyValuePair.Key, \u0081\u0086.\u0011\u009F(installFolder, keyValuePair.Key), true);
              flag3 = true;
            }
            else
            {
              obj3 = new \u001B.\u0019.\u0002(keyValuePair.Key, keyValuePair.Key, \u0081\u0086.\u0011\u009F(installFolder, keyValuePair.Key), \u0081\u0086.\u0086\u0093(keyValuePair.Key, \u001B.\u0019.\u0001(55501)), \u0081\u0086.\u0011\u009F(installFolder, \u0081\u0086.\u0086\u0093(keyValuePair.Key, \u001B.\u0019.\u0001(55501))), false);
              flag3 = false;
            }
            bool flag4;
            \u0080.\u0016 actualFileHash1;
            \u0007 obj4 = !(flag4 = this.FILES.ContainsKey(keyValuePair.Key)) ? keyValuePair.Value.\u001D\u0005(obj3.FilePath, out actualFileHash1) : keyValuePair.Value.\u001D\u0005(this.FILES[keyValuePair.Key], obj3.FilePath, out actualFileHash1);
            if (obj4 != \u0007.\u0003)
            {
              if (!canMoveOrInstallFiles)
              {
                success = false;
                break;
              }
              if (obj4 == \u0007.\u0002 && keyValuePair.Value.\u001D\u0005(actualFileHash1))
              {
                obj3.FileDetails = keyValuePair.Value.\u001D\u0005(actualFileHash1);
                dictionary.Add(keyValuePair.Key, (\u001B.\u001A) obj3);
              }
              else if (flag3)
              {
                \u0080.\u0016 actualFileHash2;
                long actualFileSize;
                switch (keyValuePair.Value.\u001D\u0005(obj3.AltFilePath, out actualFileHash2, out actualFileSize))
                {
                  case \u0007.\u0001:
                    obj3.FileDetails = keyValuePair.Value.\u001D\u0005();
                    dictionary.Add(keyValuePair.Key, (\u001B.\u001A) obj3);
                    break;
                  case \u0007.\u0002:
                    if (keyValuePair.Value.\u001D\u0005(actualFileHash2))
                    {
                      \u0012.\u001D\u0005(obj3.AltFilePath, obj3.FilePath, true);
                      obj3.FileDetails = keyValuePair.Value.\u001D\u0005(actualFileHash2);
                      this.\u001D\u0005(keyValuePair.Key, new \u0015(actualFileSize, actualFileHash2, string.Empty));
                      dictionary.Add(keyValuePair.Key, (\u001B.\u001A) obj3);
                      \u0081.\u0080.Instance.CreatedFileArchive.\u001E\u0005(obj3.FilePath);
                      \u0081.\u0080.Instance.CreatedFileArchive.\u001F\u0005(obj3.AltFilePath);
                      break;
                    }
                    obj3.FileDetails = keyValuePair.Value.\u001D\u0005();
                    dictionary.Add(keyValuePair.Key, (\u001B.\u001A) obj3);
                    break;
                  case \u0007.\u0003:
                    \u008F\u0081.\u0090\u009E(obj3.AltFilePath, obj3.FilePath, true);
                    this.\u001D\u0005(keyValuePair.Key, keyValuePair.Value, new \u0080.\u0016?(), new long?());
                    \u0081.\u0080.Instance.CreatedFileArchive.\u001E\u0005(obj3.FilePath);
                    break;
                }
              }
              else
              {
                obj3.FileDetails = keyValuePair.Value.\u001D\u0005();
                dictionary.Add(keyValuePair.Key, (\u001B.\u001A) obj3);
              }
              string str = \u009C\u0080.\u000E\u009F(keyValuePair.Key);
              if (!changedFiles.Contains(str))
                changedFiles.Add(str);
            }
            else if (!flag4)
              this.\u001D\u0005(keyValuePair.Key, keyValuePair.Value, new \u0080.\u0016?(), new long?());
            if (flag3 && !\u008F\u0084.\u0092\u009E(obj3.AltFilePath) && \u008F\u0084.\u0092\u009E(obj3.FilePath))
            {
              \u008F\u0081.\u0090\u009E(obj3.FilePath, obj3.AltFilePath, true);
              string str = \u009C\u0080.\u000E\u009F(keyValuePair.Key);
              if (!changedFiles.Contains(str))
                changedFiles.Add(str);
              \u0081.\u0080.Instance.CreatedFileArchive.\u001E\u0005(obj3.AltFilePath);
            }
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
      return dictionary;
    }

    public string \u001D\u0005(string PANDA_DOWNLOAD_URL)
    {
      StringBuilder stringBuilder1 = new StringBuilder();
      StringBuilder stringBuilder2 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55510), (object) this.Properties.PATCHER_VERSION_STRING_SERVER));
      StringBuilder stringBuilder3 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55559), (object) this.Properties.PATCHER_VERSION_STRING_SERVER_OSX));
      StringBuilder stringBuilder4 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55612), (object) this.Properties.GAME_VERSION_TEXT));
      StringBuilder stringBuilder5 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55645), (object) this.Properties.DOWNLOAD_PATCHER_CURRENT_VERSION));
      StringBuilder stringBuilder6 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55698), (object) this.Properties.DOWNLOAD_PATCHER_CURRENT_VERSION_OSX));
      StringBuilder stringBuilder7 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
      StringBuilder stringBuilder8 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55755), (object) this.Properties.ACCOUNT_SERVER));
      StringBuilder stringBuilder9 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
      StringBuilder stringBuilder10 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55784), (object) this.Properties.GAME_SERVER));
      StringBuilder stringBuilder11 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55809), (object) PANDA_DOWNLOAD_URL));
      StringBuilder stringBuilder12 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
      StringBuilder stringBuilder13 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55842), (object) this.Properties.PATCHER_BASE_URL_HEAVY_LIFTING));
      StringBuilder stringBuilder14 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
      StringBuilder stringBuilder15 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55891), (object) this.Properties.WEB_PAGE_LOGIN_RPC));
      StringBuilder stringBuilder16 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
      StringBuilder stringBuilder17 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
      StringBuilder stringBuilder18 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
      StringBuilder stringBuilder19 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55924), (object) this.Properties.REQUIRED_INSTALL_FILES));
      StringBuilder stringBuilder20 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(55965), (object) this.Properties.REQUIRED_INSTALL_FILES_OSX));
      StringBuilder stringBuilder21 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
      if (!\u008F\u0084.\u009E\u0092(this.Properties.REMOVE_OLD_FILE_LIST))
      {
        StringBuilder stringBuilder22 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(56010), (object) this.Properties.REMOVE_OLD_FILE_LIST));
        StringBuilder stringBuilder23 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
      }
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) this.FILES), ref flag);
        foreach (KeyValuePair<string, \u0015> keyValuePair in this.FILES)
        {
          StringBuilder stringBuilder22 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0014\u0084.\u007F\u0093(\u001B.\u0019.\u0001(56047), (object) keyValuePair.Key, (object) keyValuePair.Value.Version));
        }
        StringBuilder stringBuilder23 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
        foreach (KeyValuePair<string, \u0015> keyValuePair in this.FILES)
        {
          StringBuilder stringBuilder22 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009E\u0081.\u001F\u0093(\u001B.\u0019.\u0001(56080), (object) keyValuePair.Key));
          StringBuilder stringBuilder24 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0007\u001E.\u0081\u0093(\u001B.\u0019.\u0001(56089), new object[4]{ (object) keyValuePair.Key, (object) keyValuePair.Value.Version, (object) keyValuePair.Value.ExpectedSize, (object) keyValuePair.Value.ExpectedHash }));
        }
        StringBuilder stringBuilder25 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
        StringBuilder stringBuilder26 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
      StringBuilder stringBuilder27 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u001B.\u0019.\u0001(56122));
      return \u0002\u007F.\u007E\u0087\u0091((object) stringBuilder1);
    }

    public void \u001E\u0005(string data)
    {
      Regex regex1 = new Regex(\u001B.\u0019.\u0001(56143));
      Regex regex2 = new Regex(\u001B.\u0019.\u0001(56236));
      string[] strArray1 = \u0093\u0082.\u007E\u0003\u0093((object) data, new char[2]{ '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
      bool flag1 = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) this.FILES), ref flag1);
        this.FILES.Clear();
        foreach (string str in strArray1)
        {
          string[] strArray2 = \u009D\u001F.\u007E\u0002\u0093((object) str, new char[1]{ '=' });
          if (strArray2.Length == 2)
          {
            string key1;
            if ((key1 = strArray2[0]) != null)
            {
              // ISSUE: reference to a compiler-generated field
              if (\u0084.\u0080.\u0002 == null)
              {
                // ISSUE: reference to a compiler-generated field
                \u0084.\u0080.\u0002 = new Dictionary<string, int>(13)
                {
                  {
                    \u001B.\u0019.\u0001(56345),
                    0
                  },
                  {
                    \u001B.\u0019.\u0001(56386),
                    1
                  },
                  {
                    \u001B.\u0019.\u0001(3956),
                    2
                  },
                  {
                    \u001B.\u0019.\u0001(56431),
                    3
                  },
                  {
                    \u001B.\u0019.\u0001(56476),
                    4
                  },
                  {
                    \u001B.\u0019.\u0001(3998),
                    5
                  },
                  {
                    \u001B.\u0019.\u0001(3981),
                    6
                  },
                  {
                    \u001B.\u0019.\u0001(56525),
                    7
                  },
                  {
                    \u001B.\u0019.\u0001(56550),
                    8
                  },
                  {
                    \u001B.\u0019.\u0001(56591),
                    9
                  },
                  {
                    \u001B.\u0019.\u0001(56616),
                    10
                  },
                  {
                    \u001B.\u0019.\u0001(56649),
                    11
                  },
                  {
                    \u001B.\u0019.\u0001(56686),
                    12
                  }
                };
              }
              int num;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: explicit non-virtual call
              if (__nonvirtual (\u0084.\u0080.\u0002.TryGetValue(key1, out num)))
              {
                switch (num)
                {
                  case 0:
                    this.Properties.PATCHER_VERSION_STRING_SERVER = strArray2[1];
                    continue;
                  case 1:
                    this.Properties.PATCHER_VERSION_STRING_SERVER_OSX = strArray2[1];
                    continue;
                  case 2:
                    this.Properties.GAME_VERSION_TEXT = strArray2[1];
                    continue;
                  case 3:
                    this.Properties.DOWNLOAD_PATCHER_CURRENT_VERSION = strArray2[1];
                    continue;
                  case 4:
                    this.Properties.DOWNLOAD_PATCHER_CURRENT_VERSION_OSX = strArray2[1];
                    continue;
                  case 5:
                    this.Properties.ACCOUNT_SERVER = strArray2[1];
                    continue;
                  case 6:
                    this.Properties.GAME_SERVER = strArray2[1];
                    continue;
                  case 7:
                    this.Properties.PANDA_DOWNLOAD_URL = strArray2[1];
                    try
                    {
                      bool flag2 = false;
                      object obj2;
                      try
                      {
                        \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) this.DownloadUrls), ref flag2);
                        this.DownloadUrls.Insert(this.DownloadUrls.Count, new Uri(\u001B.\u0019.\u001E\u0005(this.Properties.PANDA_DOWNLOAD_URL)));
                        continue;
                      }
                      finally
                      {
                        if (flag2)
                          \u001A\u001E.\u0082\u0098(obj2);
                      }
                    }
                    catch (Exception ex)
                    {
                      ex.\u001D\u0005((object) strArray2[1]);
                      continue;
                    }
                  case 8:
                    this.Properties.PATCHER_BASE_URL_HEAVY_LIFTING = strArray2[1];
                    string[] strArray3 = \u0093\u0082.\u007E\u0003\u0093((object) this.Properties.PATCHER_BASE_URL_HEAVY_LIFTING, new char[1]{ ';' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int index = strArray3.Length - 1; index >= 0; --index)
                    {
                      try
                      {
                        bool flag2 = false;
                        object obj2;
                        try
                        {
                          \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) this.DownloadUrls), ref flag2);
                          this.DownloadUrls.Insert(0, new Uri(\u001B.\u0019.\u001E\u0005(strArray3[0])));
                        }
                        finally
                        {
                          if (flag2)
                            \u001A\u001E.\u0082\u0098(obj2);
                        }
                      }
                      catch (Exception ex)
                      {
                        ex.\u001D\u0005((object) strArray3[index]);
                      }
                    }
                    continue;
                  case 9:
                    this.Properties.WEB_PAGE_LOGIN_RPC = strArray2[1];
                    continue;
                  case 10:
                    this.Properties.REQUIRED_INSTALL_FILES = strArray2[1];
                    continue;
                  case 11:
                    this.Properties.REQUIRED_INSTALL_FILES_OSX = strArray2[1];
                    continue;
                  case 12:
                    this.Properties.REMOVE_OLD_FILE_LIST = strArray2[1];
                    continue;
                }
              }
            }
            if (\u0016\u001D.\u007E\u0017\u0093((object) strArray2[0], \u001B.\u0019.\u0001(56715)))
            {
              Match match = \u0017\u001F.\u007E\u0014\u0001\u0002((object) regex1, strArray2[0]);
              long expectedSize;
              \u0080.\u0016 expectedHash;
              if (\u0099\u0082.\u007E\u0017\u0001\u0002((object) match) && !\u0016\u001D.\u007E\u0010\u0093((object) \u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001B.\u0019.\u0001(56724))), \u001B.\u0019.\u0001(56737)) && \u001B.\u0019.\u001D\u0005(\u0002\u007F.\u007E\u001B\u0093((object) strArray2[1]), out expectedSize, out expectedHash))
              {
                if (!this.FILES.ContainsKey(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001B.\u0019.\u0001(56724)))))
                  this.FILES.Add(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001B.\u0019.\u0001(56724))), new \u0015());
                \u0015 obj2 = this.FILES[\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001B.\u0019.\u0001(56724)))];
                obj2.Version = \u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001B.\u0019.\u0001(56742)));
                obj2.ExpectedHash = expectedHash;
                obj2.ExpectedSize = expectedSize;
              }
            }
            else if (\u0016\u001D.\u007E\u0017\u0093((object) strArray2[0], \u001B.\u0019.\u0001(56759)))
            {
              Match match = \u0017\u001F.\u007E\u0014\u0001\u0002((object) regex2, strArray2[0]);
              uint expectedFileSize;
              \u0080.\u0016 expectedHash;
              uint resultingFileSize;
              \u0080.\u0016 resultingHash;
              if (\u0099\u0082.\u007E\u0017\u0001\u0002((object) match) && !\u0016\u001D.\u007E\u0010\u0093((object) \u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001B.\u0019.\u0001(56724))), \u001B.\u0019.\u0001(56737)) && \u001B.\u0019.\u001D\u0005(\u0002\u007F.\u007E\u001B\u0093((object) strArray2[1]), out expectedFileSize, out expectedHash, out resultingFileSize, out resultingHash))
              {
                \u001A.\u001B obj2 = new \u001A.\u001B();
                obj2.ExpectedFileSize = expectedFileSize;
                obj2.ExpectedHash = expectedHash;
                obj2.ResultingFileSize = resultingFileSize;
                obj2.ResultingHash = resultingHash;
                obj2.Version = \u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001B.\u0019.\u0001(56742)));
                string key2 = \u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001B.\u0019.\u0001(56724)));
                if (!this.FILES.ContainsKey(key2))
                  this.FILES.Add(key2, new \u0015());
                bool flag2 = false;
                object obj3;
                try
                {
                  \u0098\u0082.\u0081\u0098(obj3 = \u0005\u007F.\u007E\u0016\u0092((object) this.FILES[key2].Patches), ref flag2);
                  this.FILES[key2].Patches.Add(obj2);
                }
                finally
                {
                  if (flag2)
                    \u001A\u001E.\u0082\u0098(obj3);
                }
              }
            }
          }
        }
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    private static string \u001E\u0005(string downloadUrl)
    {
      if (!\u0016\u001D.\u007E\u0011\u0093((object) downloadUrl, \u001B.\u0019.\u0001(56768)))
        downloadUrl = \u0089\u001D.\u0083\u0093((object) downloadUrl, (object) '/');
      return downloadUrl;
    }

    private static bool \u001D\u0005(string data, out uint expectedFileSize, out \u0080.\u0016 expectedHash, out uint resultingFileSize, out \u0080.\u0016 resultingHash)
    {
      expectedFileSize = 0U;
      expectedHash = new \u0080.\u0016();
      resultingFileSize = 0U;
      resultingHash = new \u0080.\u0016();
      int startIndex = 0;
      string hash;
      if (!data.\u001D\u0005(' ', ref startIndex, out hash) || (!\u001F\u0081.\u009D\u0097(hash, ref expectedFileSize) || !data.\u001D\u0005(' ', ref startIndex, out hash) || !hash.\u001F\u0005()))
        return false;
      expectedHash = new \u0080.\u0016(hash);
      if (!data.\u001D\u0005(' ', ref startIndex, out hash) || !\u001F\u0081.\u009D\u0097(hash, ref resultingFileSize) || (!data.\u001D\u0005(ref startIndex, out hash) || !hash.\u001F\u0005()))
        return false;
      resultingHash = new \u0080.\u0016(hash);
      return true;
    }

    private static bool \u001D\u0005(string data, out long expectedSize, out \u0080.\u0016 expectedHash)
    {
      expectedSize = 0L;
      expectedHash = new \u0080.\u0016();
      int startIndex = 0;
      string hash;
      long num;
      if (!data.\u001D\u0005(' ', ref startIndex, out hash) || !\u0097\u001F.\u001B\u0096(hash, ref num) || (!data.\u001D\u0005(ref startIndex, out hash) || !hash.\u001F\u0005()))
        return false;
      expectedHash = new \u0080.\u0016(hash);
      expectedSize = num;
      return true;
    }

    internal sealed class \u0001 : \u0005<\u001B.\u0019.\u0001>
    {
      public string PATCHER_VERSION_STRING_SERVER { get; set; }

      public string PATCHER_VERSION_STRING_SERVER_OSX { get; set; }

      public string GAME_VERSION_TEXT { get; set; }

      public string DOWNLOAD_PATCHER_CURRENT_VERSION { get; set; }

      public string DOWNLOAD_PATCHER_CURRENT_VERSION_OSX { get; set; }

      public string ACCOUNT_SERVER { get; set; }

      public string GAME_SERVER { get; set; }

      public string PANDA_DOWNLOAD_URL { get; set; }

      public string PATCHER_BASE_URL_HEAVY_LIFTING { get; set; }

      public string WEB_PAGE_LOGIN_RPC { get; set; }

      public string REQUIRED_INSTALL_FILES { get; set; }

      public string REQUIRED_INSTALL_FILES_OSX { get; set; }

      public string REMOVE_OLD_FILE_LIST { get; set; }

      public \u001B.\u0019.\u0001 \u0001()
      {
        return new \u001B.\u0019.\u0001() { ACCOUNT_SERVER = this.ACCOUNT_SERVER, DOWNLOAD_PATCHER_CURRENT_VERSION = this.DOWNLOAD_PATCHER_CURRENT_VERSION, DOWNLOAD_PATCHER_CURRENT_VERSION_OSX = this.DOWNLOAD_PATCHER_CURRENT_VERSION_OSX, GAME_SERVER = this.GAME_SERVER, GAME_VERSION_TEXT = this.GAME_VERSION_TEXT, PANDA_DOWNLOAD_URL = this.PANDA_DOWNLOAD_URL, PATCHER_BASE_URL_HEAVY_LIFTING = this.PATCHER_BASE_URL_HEAVY_LIFTING, PATCHER_VERSION_STRING_SERVER = this.PATCHER_VERSION_STRING_SERVER, PATCHER_VERSION_STRING_SERVER_OSX = this.PATCHER_VERSION_STRING_SERVER_OSX, REMOVE_OLD_FILE_LIST = this.REMOVE_OLD_FILE_LIST, REQUIRED_INSTALL_FILES = this.REQUIRED_INSTALL_FILES, REQUIRED_INSTALL_FILES_OSX = this.REQUIRED_INSTALL_FILES_OSX, WEB_PAGE_LOGIN_RPC = this.WEB_PAGE_LOGIN_RPC };
      }
    }

    private sealed class \u0002 : \u001B.\u001A
    {
      public new \u0015 FileDetails
      {
        get
        {
          return this.FileDetails;
        }
        set
        {
          this.FileDetails = value;
        }
      }

      public \u0002(string phaseName, string fileName, string filePath, string altFileName, string altFilePath, bool virtualized)
        : base(phaseName, fileName, filePath, altFileName, altFilePath, virtualized)
      {
      }
    }
  }
}
