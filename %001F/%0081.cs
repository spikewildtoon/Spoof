// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001D;
using \u001E;
using \u0080;
using \u0081;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace \u001F
{
  internal sealed class \u0081 : \u0014.\u0080
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public Dictionary<string, \u001F.\u0081.\u0001> \u0001;

    protected override int? Version
    {
      get
      {
        return new int?(1);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 1;
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
        return new byte[3]{ (byte) 67, (byte) 80, (byte) 83 };
      }
    }

    public Guid ID { get; set; }

    public string FileName { get; set; }

    public \u001D.\u001D InstallState { get; set; }

    public Uri UpdateUri { get; set; }

    public string Name { get; set; }

    public \u0016 DataHash { get; set; }

    public bool AutoUpdate { get; set; }

    public \u001E.\u0081 VersionType { get; set; }

    public bool LoaderPack { get; set; }

    public DateTime DateInstalled { get; set; }

    public System.Version ContentPackVersion { get; set; }

    static \u0081()
    {
      \u0004.\u001D\u0005(typeof (\u001F.\u0081));
    }

    public \u0081(\u001C.\u001A cp, \u0016 contentPackHash, string fileName)
    {
      this.\u0001 = new Dictionary<string, \u001F.\u0081.\u0001>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      this.ID = cp.ID;
      this.FileName = fileName;
      this.Name = cp.Name;
      this.DateInstalled = \u001D\u0082.\u0011\u0094();
      this.InstallState = \u001D.\u001D.\u0001;
      this.UpdateUri = cp.UpdateUri;
      this.DataHash = contentPackHash;
      this.AutoUpdate = \u008E\u0081.\u008B\u0002\u0002(cp.UpdateUri, (Uri) null);
      this.VersionType = cp.Type;
      this.LoaderPack = cp.LoaderPack;
      this.ContentPackVersion = cp.Version;
      foreach (KeyValuePair<string, \u0016> keyValuePair in cp.ItemIndex)
      {
        if (!this.\u0001.ContainsKey(keyValuePair.Key) && \u007F.\u001F\u0005(keyValuePair.Key))
        {
          if (this.\u001D\u0005(keyValuePair.Key))
            this.\u0001.Add(keyValuePair.Key, new \u001F.\u0081.\u0001(keyValuePair.Value, \u001D.\u001D.\u0001));
          else
            this.\u0001.Add(keyValuePair.Key, new \u001F.\u0081.\u0001(keyValuePair.Value, \u001D.\u001D.\u0004));
        }
      }
    }

    public \u0081(BinaryReader reader)
      : base(reader)
    {
    }

    public static \u001F.\u0081 \u001D\u0005(Guid id)
    {
      foreach (\u001F.\u0081 contentPack in \u0081.\u0080.Instance.ConnectSettings.ContentPacks)
      {
        if (\u0018\u001E.\u000E\u0096(contentPack.ID, id))
          return contentPack;
      }
      return (\u001F.\u0081) null;
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.\u0001 = new Dictionary<string, \u001F.\u0081.\u0001>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      this.ID = reader.\u001D\u0005();
      this.FileName = \u0081\u0086.\u0011\u009F(\u007F.ContentPackDataDirectory, \u0002\u007F.\u007E\u0001\u009E((object) reader));
      this.Name = \u0002\u007F.\u007E\u0001\u009E((object) reader);
      this.DateInstalled = reader.\u001D\u0005();
      this.InstallState = (\u001D.\u001D) \u0011\u001C.\u007E\u0097\u009D((object) reader);
      this.UpdateUri = reader.\u001D\u0005();
      this.DataHash = reader.\u001D\u0005();
      this.AutoUpdate = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.VersionType = (\u001E.\u0081) \u0011\u001C.\u007E\u0097\u009D((object) reader);
      this.LoaderPack = \u0099\u0082.\u007E\u0095\u009D((object) reader);
      this.ContentPackVersion = reader.\u001D\u0005();
      int num = \u0005\u0081.\u007E\u0099\u009D((object) reader);
      for (int index = 0; index < num; ++index)
        this.\u0001.Add(\u0002\u007F.\u007E\u0001\u009E((object) reader), new \u001F.\u0081.\u0001(reader.\u001D\u0005(), (\u001D.\u001D) \u0011\u001C.\u007E\u0097\u009D((object) reader)));
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      writer.\u001D\u0005(this.ID);
      \u0092\u0081.\u007E\u001A\u009E((object) writer, \u009C\u0080.\u0008\u009F(this.FileName));
      \u0092\u0081.\u007E\u001A\u009E((object) writer, this.Name);
      writer.\u001D\u0005(this.DateInstalled);
      \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.InstallState);
      writer.\u001D\u0005(this.UpdateUri);
      writer.\u001D\u0005(this.DataHash);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.AutoUpdate);
      \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) this.VersionType);
      \u0099\u001F.\u007E\u000E\u009E((object) writer, this.LoaderPack);
      writer.\u001D\u0005(this.ContentPackVersion);
      \u0011\u001F.\u007E\u0015\u009E((object) writer, this.\u0001.Count);
      foreach (KeyValuePair<string, \u001F.\u0081.\u0001> keyValuePair in this.\u0001)
      {
        \u0092\u0081.\u007E\u001A\u009E((object) writer, keyValuePair.Key);
        writer.\u001D\u0005(keyValuePair.Value.\u0001);
        \u0010\u001E.\u007E\u0013\u009E((object) writer, (short) keyValuePair.Value.\u0001);
      }
    }

    private bool \u001D\u0005(string item)
    {
      bool flag1 = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) \u0081.\u0080.Instance.ConnectSettings.ContentPacks), ref flag1);
        foreach (\u001F.\u0081 contentPack in \u0081.\u0080.Instance.ConnectSettings.ContentPacks)
        {
          if (contentPack != this)
          {
            bool flag2 = false;
            object obj2;
            try
            {
              \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) contentPack.\u0001), ref flag2);
              if (contentPack.\u0001.ContainsKey(item))
              {
                switch (contentPack.\u0001[item].\u0001)
                {
                  case \u001D.\u001D.\u0002:
                  case \u001D.\u001D.\u0004:
                    return true;
                  default:
                    goto label_16;
                }
              }
            }
            finally
            {
              if (flag2)
                \u001A\u001E.\u0082\u0098(obj2);
            }
          }
        }
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj1);
      }
label_16:
      return false;
    }

    public void \u001D\u0005()
    {
      this.DateInstalled = \u001D\u0082.\u0011\u0094();
      HashSet<string> stringSet = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      bool flag = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) this.\u0001), ref flag);
        \u001C.\u001A obj2 = new \u001C.\u001A(this.FileName, false, false);
        try
        {
          foreach (KeyValuePair<string, \u0016> keyValuePair in obj2.ItemIndex)
          {
            if (this.\u0001.ContainsKey(keyValuePair.Key))
            {
              if (\u0016.\u001E\u0005(keyValuePair.Value, this.\u0001[keyValuePair.Key].\u0001))
              {
                if (this.\u0001[keyValuePair.Key].\u0001 == \u001D.\u001D.\u0002)
                  this.\u0001[keyValuePair.Key].\u0001 = \u001D.\u001D.\u0004;
                this.\u0001[keyValuePair.Key].\u0001 = keyValuePair.Value;
              }
            }
            else if (\u007F.\u001F\u0005(keyValuePair.Key))
            {
              if (this.\u001D\u0005(keyValuePair.Key))
              {
                this.\u0001.Add(keyValuePair.Key, new \u001F.\u0081.\u0001(keyValuePair.Value, \u001D.\u001D.\u0001));
              }
              else
              {
                this.\u0001.Add(keyValuePair.Key, new \u001F.\u0081.\u0001(keyValuePair.Value, \u001D.\u001D.\u0004));
                this.InstallState = \u001D.\u001D.\u0004;
              }
            }
          }
          foreach (KeyValuePair<string, \u001F.\u0081.\u0001> keyValuePair in this.\u0001)
          {
            if (!obj2.ItemIndex.ContainsKey(keyValuePair.Key))
            {
              if (keyValuePair.Value.\u0001 == \u001D.\u001D.\u0002)
                keyValuePair.Value.\u0001 = \u001D.\u001D.\u0005;
              else
                stringSet.Add(keyValuePair.Key);
            }
          }
          this.Name = obj2.Name;
          this.UpdateUri = obj2.UpdateUri;
          this.VersionType = obj2.Type;
          this.ContentPackVersion = obj2.Version;
          this.LoaderPack = obj2.LoaderPack;
          if (this.VersionType == \u001E.\u0081.\u0001)
            this.DataHash = obj2.DataHash;
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
        if (this.VersionType != \u001E.\u0081.\u0001)
        {
          Stream stream = (Stream) \u008F\u001C.\u0093\u009E(this.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
          try
          {
            this.DataHash = stream.\u001D\u0005();
          }
          finally
          {
            if (stream != null)
              \u001A\u001E.\u007E\u0094\u0092((object) stream);
          }
        }
        this.\u0001.\u001D\u0005<string, \u001F.\u0081.\u0001>((IEnumerable<string>) stringSet);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    public static void \u001D\u0005(HashSet<string> modifiedFiles)
    {
      if (!\u0081.\u0080.Instance.ConnectSettings.SpoofedToonTownEnabled)
        return;
      bool flag1 = false;
      object obj1;
      try
      {
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) \u0081.\u0080.Instance.ConnectSettings.ContentPacks), ref flag1);
        foreach (\u001F.\u0081 contentPack in \u0081.\u0080.Instance.ConnectSettings.ContentPacks)
        {
          bool flag2 = false;
          object obj2;
          try
          {
            \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) contentPack.\u0001), ref flag2);
            foreach (KeyValuePair<string, \u001F.\u0081.\u0001> keyValuePair in contentPack.\u0001)
            {
              string multifile_name;
              if (keyValuePair.Value.\u0001 != \u001D.\u001D.\u0001 && \u007F.\u001D\u0005(keyValuePair.Key, out multifile_name))
              {
                switch (keyValuePair.Value.\u0001)
                {
                  case \u001D.\u001D.\u0002:
                    if (modifiedFiles.Contains(multifile_name))
                    {
                      contentPack.\u0001[keyValuePair.Key].\u0001 = \u001D.\u001D.\u0004;
                      continue;
                    }
                    continue;
                  case \u001D.\u001D.\u0003:
                    if (modifiedFiles.Contains(multifile_name))
                    {
                      contentPack.\u0001[keyValuePair.Key].\u0001 = \u001D.\u001D.\u0001;
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
            if (flag2)
              \u001A\u001E.\u0082\u0098(obj2);
          }
        }
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj1);
      }
    }

    public static void \u001D\u0005(string installDirectory, out HashSet<string> changedMultiFiles)
    {
      changedMultiFiles = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      if (!\u0081.\u0080.Instance.ConnectSettings.SpoofedToonTownEnabled)
        return;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001F.\u0081.\u0002 obj1 = new \u001F.\u0081.\u0002();
      Dictionary<\u001F.\u0081, Dictionary<string, HashSet<string>>> dictionary1 = new Dictionary<\u001F.\u0081, Dictionary<string, HashSet<string>>>();
      Dictionary<string, Dictionary<\u001F.\u0081, HashSet<string>>> dictionary2 = new Dictionary<string, Dictionary<\u001F.\u0081, HashSet<string>>>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = new Dictionary<string, HashSet<string>>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      bool flag = false;
      object obj2;
      try
      {
        \u0098\u0082.\u0081\u0098(obj2 = \u0005\u007F.\u007E\u0016\u0092((object) \u0081.\u0080.Instance.ConnectSettings.ContentPacks), ref flag);
        foreach (\u001F.\u0081 contentPack in \u0081.\u0080.Instance.ConnectSettings.ContentPacks)
        {
          if (!contentPack.LoaderPack)
          {
            Dictionary<string, HashSet<string>> installingFiles;
            Dictionary<string, HashSet<string>> uninstallingFiles;
            contentPack.\u001D\u0005(out installingFiles, out uninstallingFiles);
            if (installingFiles.Count > 0)
              dictionary1.Add(contentPack, installingFiles);
            foreach (KeyValuePair<string, HashSet<string>> keyValuePair in installingFiles)
            {
              // ISSUE: reference to a compiler-generated field
              if (!obj1.\u0001.ContainsKey(keyValuePair.Key))
              {
                // ISSUE: reference to a compiler-generated field
                obj1.\u0001.Add(keyValuePair.Key, new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093()));
              }
              foreach (string str in keyValuePair.Value)
              {
                // ISSUE: reference to a compiler-generated field
                if (!obj1.\u0001[keyValuePair.Key].Contains(str))
                {
                  // ISSUE: reference to a compiler-generated field
                  obj1.\u0001[keyValuePair.Key].Add(str);
                }
              }
            }
            foreach (KeyValuePair<string, HashSet<string>> keyValuePair in uninstallingFiles)
            {
              Dictionary<\u001F.\u0081, HashSet<string>> dictionary3;
              if (dictionary2.ContainsKey(keyValuePair.Key))
                dictionary3 = dictionary2[keyValuePair.Key];
              else
                dictionary2.Add(keyValuePair.Key, dictionary3 = new Dictionary<\u001F.\u0081, HashSet<string>>());
              HashSet<string> stringSet;
              if (dictionary3.ContainsKey(contentPack))
                stringSet = dictionary3[contentPack];
              else
                dictionary3.Add(contentPack, stringSet = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093()));
              foreach (string str in keyValuePair.Value)
              {
                if (!stringSet.Contains(str))
                  stringSet.Add(str);
              }
            }
          }
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj2);
      }
      // ISSUE: reference to a compiler-generated method
      dictionary2.\u001D\u0005<KeyValuePair<string, Dictionary<\u001F.\u0081, HashSet<string>>>>(new Action<KeyValuePair<string, Dictionary<\u001F.\u0081, HashSet<string>>>>(obj1.\u001D\u0005));
      foreach (KeyValuePair<string, Dictionary<\u001F.\u0081, HashSet<string>>> keyValuePair in dictionary2.Where<KeyValuePair<string, Dictionary<\u001F.\u0081, HashSet<string>>>>((Func<KeyValuePair<string, Dictionary<\u001F.\u0081, HashSet<string>>>, bool>) (item => item.Value.Count == 0)).ToArray<KeyValuePair<string, Dictionary<\u001F.\u0081, HashSet<string>>>>())
        dictionary2.Remove(keyValuePair.Key);
      Dictionary<\u001F.\u0081, \u001C.\u001A> dictionary4 = new Dictionary<\u001F.\u0081, \u001C.\u001A>();
      try
      {
        // ISSUE: reference to a compiler-generated field
        IEnumerator<string> enumerator = obj1.\u0001.Keys.Union<string>((IEnumerable<string>) dictionary2.Keys, (IEqualityComparer<string>) \u0093\u001B.\u0092\u0093()).GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            string current = enumerator.Current;
            string str1 = \u0081\u0086.\u0011\u009F(installDirectory, \u0081\u0086.\u0086\u0093(current, \u001F.\u0081.\u0001(53256)));
            if (\u008F\u0084.\u0092\u009E(str1))
            {
              Stream str2 = (Stream) \u008F\u001C.\u0093\u009E(str1, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
              try
              {
                \u007F obj3 = new \u007F(str2);
                try
                {
                  if (!changedMultiFiles.Contains(current))
                    changedMultiFiles.Add(current);
                  obj3.\u0084\u0005();
                  if (dictionary2.ContainsKey(current))
                  {
                    string str3 = \u0081\u0086.\u0011\u009F(installDirectory, \u0081\u0086.\u0086\u0093(current, \u001F.\u0081.\u0001(75250)));
                    if (\u008F\u0084.\u0092\u009E(str3))
                    {
                      Stream str4 = (Stream) \u008F\u001C.\u0093\u009E(str3, FileMode.Open, FileAccess.Read, FileShare.None);
                      try
                      {
                        \u007F obj4 = new \u007F(str4);
                        try
                        {
                          HashSet<string> stringSet = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
                          foreach (KeyValuePair<\u001F.\u0081, HashSet<string>> keyValuePair in dictionary2[current])
                          {
                            foreach (string str5 in keyValuePair.Value)
                            {
                              if (!stringSet.Contains(str5))
                                stringSet.Add(str5);
                            }
                          }
                          obj4.\u001E\u0005((IEnumerable<string>) stringSet);
                          foreach (KeyValuePair<\u001F.\u0081, HashSet<string>> keyValuePair in dictionary2[current])
                          {
                            foreach (string name in keyValuePair.Value)
                            {
                              if (obj4.\u007F\u0005(name) && obj3.\u007F\u0005(name))
                                obj4[name].\u001D\u0005(obj3[name]);
                            }
                            if (keyValuePair.Key.InstallState == \u001D.\u001D.\u0003)
                            {
                              foreach (string index in keyValuePair.Value)
                              {
                                switch (keyValuePair.Key.\u0001[index].\u0001)
                                {
                                  case \u001D.\u001D.\u0003:
                                    keyValuePair.Key.\u0001[index].\u0001 = \u001D.\u001D.\u0001;
                                    continue;
                                  case \u001D.\u001D.\u0005:
                                    continue;
                                  default:
                                    keyValuePair.Key.\u0001[index].\u0001 = \u001D.\u001D.\u0004;
                                    continue;
                                }
                              }
                            }
                            else
                            {
                              foreach (string index in keyValuePair.Value)
                              {
                                if (keyValuePair.Key.\u0001[index].\u0001 != \u001D.\u001D.\u0005)
                                  keyValuePair.Key.\u0001[index].\u0001 = \u001D.\u001D.\u0001;
                              }
                            }
                          }
                        }
                        finally
                        {
                          if (obj4 != null)
                            \u001A\u001E.\u007E\u0094\u0092((object) obj4);
                        }
                      }
                      finally
                      {
                        if (str4 != null)
                          \u001A\u001E.\u007E\u0094\u0092((object) str4);
                      }
                    }
                  }
                  foreach (KeyValuePair<\u001F.\u0081, Dictionary<string, HashSet<string>>> keyValuePair in dictionary1)
                  {
                    if (keyValuePair.Value.ContainsKey(current))
                    {
                      \u001F.\u0081 key = keyValuePair.Key;
                      if (!dictionary4.ContainsKey(keyValuePair.Key))
                        dictionary4.Add(keyValuePair.Key, new \u001C.\u001A(keyValuePair.Key.FileName, false, true));
                      \u007F data = dictionary4[keyValuePair.Key].Data;
                      foreach (string name in keyValuePair.Value[current])
                      {
                        if (data.\u007F\u0005(name) && obj3.\u007F\u0005(name))
                        {
                          \u001B obj4 = data[name];
                          obj4.\u001D\u0005(obj3[name]);
                          obj4.Data = (byte[]) null;
                          key.\u0001[name].\u0001 = \u001D.\u001D.\u0002;
                        }
                        else
                          key.\u0001[name].\u0001 = \u001D.\u001D.\u0001;
                      }
                    }
                  }
                  obj3.\u0086\u0005();
                }
                finally
                {
                  if (obj3 != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) obj3);
                }
              }
              finally
              {
                if (str2 != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) str2);
              }
            }
            else if (dictionary2.ContainsKey(current))
            {
              foreach (KeyValuePair<\u001F.\u0081, HashSet<string>> keyValuePair in dictionary2[current])
              {
                if (keyValuePair.Key.InstallState == \u001D.\u001D.\u0003)
                {
                  foreach (string index in keyValuePair.Value)
                  {
                    switch (keyValuePair.Key.\u0001[index].\u0001)
                    {
                      case \u001D.\u001D.\u0003:
                        keyValuePair.Key.\u0001[index].\u0001 = \u001D.\u001D.\u0001;
                        continue;
                      case \u001D.\u001D.\u0005:
                        continue;
                      default:
                        keyValuePair.Key.\u0001[index].\u0001 = \u001D.\u001D.\u0004;
                        continue;
                    }
                  }
                }
                else
                {
                  foreach (string index in keyValuePair.Value)
                  {
                    if (keyValuePair.Key.\u0001[index].\u0001 != \u001D.\u001D.\u0005)
                      keyValuePair.Key.\u0001[index].\u0001 = \u001D.\u001D.\u0001;
                  }
                }
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
        foreach (KeyValuePair<\u001F.\u0081, \u001C.\u001A> keyValuePair in dictionary4)
          keyValuePair.Value.Dispose();
      }
      foreach (\u001F.\u0081 contentPack in \u0081.\u0080.Instance.ConnectSettings.ContentPacks)
        contentPack.\u001E\u0005();
    }

    private void \u001E\u0005()
    {
      bool flag1 = false;
      object obj1;
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u001F.\u0081.\u0003 obj2 = new \u001F.\u0081.\u0003();
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = this;
        \u0098\u0082.\u0081\u0098(obj1 = \u0005\u007F.\u007E\u0016\u0092((object) this.\u0001), ref flag1);
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
        // ISSUE: reference to a compiler-generated method
        this.\u0001.Keys.\u001D\u0005<string>(new Action<string>(obj2.\u001D\u0005));
        // ISSUE: reference to a compiler-generated field
        this.\u0001.\u001D\u0005<string, \u001F.\u0081.\u0001>((IEnumerable<string>) obj2.\u0001);
      }
      finally
      {
        if (flag1)
          \u001A\u001E.\u0082\u0098(obj1);
      }
      switch (this.InstallState)
      {
        case \u001D.\u001D.\u0003:
          bool flag2 = false;
          foreach (KeyValuePair<string, \u001F.\u0081.\u0001> keyValuePair in this.\u0001)
          {
            if (keyValuePair.Value.\u0001 == \u001D.\u001D.\u0003)
            {
              flag2 = true;
              break;
            }
          }
          if (flag2)
          {
            this.InstallState = \u001D.\u001D.\u0003;
            break;
          }
          this.InstallState = \u001D.\u001D.\u0001;
          break;
        case \u001D.\u001D.\u0004:
          if (this.LoaderPack)
            break;
          bool flag3 = false;
          foreach (KeyValuePair<string, \u001F.\u0081.\u0001> keyValuePair in this.\u0001)
          {
            if (keyValuePair.Value.\u0001 == \u001D.\u001D.\u0004)
            {
              flag3 = true;
              break;
            }
          }
          if (flag3)
          {
            this.InstallState = \u001D.\u001D.\u0004;
            break;
          }
          this.InstallState = \u001D.\u001D.\u0002;
          break;
      }
    }

    private void \u001D\u0005(out Dictionary<string, HashSet<string>> installingFiles, out Dictionary<string, HashSet<string>> uninstallingFiles)
    {
      installingFiles = new Dictionary<string, HashSet<string>>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      uninstallingFiles = new Dictionary<string, HashSet<string>>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      if (this.InstallState == \u001D.\u001D.\u0001)
        return;
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u0005\u007F.\u007E\u0016\u0092((object) this.\u0001), ref flag);
        foreach (KeyValuePair<string, \u001F.\u0081.\u0001> keyValuePair in this.\u0001)
        {
          string multifile_name;
          if (keyValuePair.Value.\u0001 != \u001D.\u001D.\u0001 && \u007F.\u001D\u0005(keyValuePair.Key, out multifile_name))
          {
            if (this.InstallState == \u001D.\u001D.\u0003)
            {
              switch (keyValuePair.Value.\u0001)
              {
                case \u001D.\u001D.\u0002:
                case \u001D.\u001D.\u0003:
                case \u001D.\u001D.\u0005:
                  if (!uninstallingFiles.ContainsKey(multifile_name))
                    uninstallingFiles.Add(multifile_name, new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093()));
                  uninstallingFiles[multifile_name].Add(keyValuePair.Key);
                  continue;
                default:
                  continue;
              }
            }
            else
            {
              switch (keyValuePair.Value.\u0001)
              {
                case \u001D.\u001D.\u0003:
                case \u001D.\u001D.\u0005:
                  if (!uninstallingFiles.ContainsKey(multifile_name))
                    uninstallingFiles.Add(multifile_name, new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093()));
                  uninstallingFiles[multifile_name].Add(keyValuePair.Key);
                  continue;
                case \u001D.\u001D.\u0004:
                  if (!installingFiles.ContainsKey(multifile_name))
                    installingFiles.Add(multifile_name, new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093()));
                  installingFiles[multifile_name].Add(keyValuePair.Key);
                  continue;
                default:
                  continue;
              }
            }
          }
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    internal sealed class \u0001
    {
      public \u0016 \u0001;
      public \u001D.\u001D \u0001;

      public \u0001(\u0016 hash, \u001D.\u001D state)
      {
        this.\u0001 = hash;
        this.\u0001 = state;
      }
    }
  }
}
