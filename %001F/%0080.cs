// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u001B;
using \u001C;
using \u0080;
using \u0083;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;

namespace \u001F
{
  internal sealed class \u0080
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private List<KeyValuePair<\u0016, \u0013>> \u0001;
    private ReadOnlyCollection<KeyValuePair<\u0016, \u0013>> \u0001;

    public ReadOnlyCollection<KeyValuePair<\u0016, \u0013>> Patches
    {
      get
      {
        if (this.\u0001 == null)
          return (ReadOnlyCollection<KeyValuePair<\u0016, \u0013>>) null;
        if (this.\u0001 == null)
          this.\u0001 = this.\u0001.AsReadOnly();
        return this.\u0001;
      }
    }

    public Uri DownloadUri { get; private set; }

    public \u0016 Hash { get; private set; }

    public Version MinimumVersion { get; private set; }

    static \u0080()
    {
      \u0004.\u001D\u0005(typeof (\u001F.\u0080));
    }

    private \u0080(\u0016 hash, Uri downloadUri, Version mininumVersion, List<KeyValuePair<\u0016, \u0013>> patches)
    {
      if (\u008E\u0081.\u008A\u0002\u0002(downloadUri, (Uri) null))
        throw new ArgumentNullException(\u001F.\u0080.\u0001(75050));
      this.Hash = hash;
      this.DownloadUri = downloadUri;
      this.MinimumVersion = mininumVersion;
      this.\u0001 = patches;
    }

    public static bool \u001D\u0005(string data, bool loaderPack, out \u001F.\u0080 parser)
    {
      parser = (\u001F.\u0080) null;
      string[] strArray1 = \u0093\u0082.\u007E\u0003\u0093((object) data, new char[2]{ '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
      Version mininumVersion = (Version) null;
      Uri downloadUri = (Uri) null;
      \u0016 hash = \u0016.\u0001;
      for (int index = 0; index < strArray1.Length; ++index)
      {
        string str1 = strArray1[index];
        if (!\u0016\u001D.\u007E\u0017\u0093((object) str1, \u001F.\u0080.\u0001(66081)))
        {
          string[] strArray2 = \u009D\u001F.\u007E\u0002\u0093((object) str1, new char[1]{ '=' });
          if (strArray2.Length == 2)
          {
            if (\u008F\u0084.\u009E\u0092(strArray2[1]))
              return false;
            string str2;
            if ((str2 = strArray2[0]) != null)
            {
              if (!\u0008\u001F.\u009A\u0092(str2, \u001F.\u0080.\u0001(75067)))
              {
                if (!\u0008\u001F.\u009A\u0092(str2, \u001F.\u0080.\u0001(75088)))
                {
                  if (\u0008\u001F.\u009A\u0092(str2, \u001F.\u0080.\u0001(75097)))
                  {
                    Uri uri;
                    if (!\u009B\u0084.\u008C\u0002\u0002(strArray2[1], UriKind.Absolute, ref uri) || !uri.\u001D\u0005())
                      return false;
                    downloadUri = uri;
                  }
                }
                else
                {
                  if (!strArray2[1].\u001F\u0005())
                    return false;
                  hash = new \u0016(strArray2[1]);
                }
              }
              else
              {
                Regex regex = new Regex(\u001F.\u0080.\u0001(75114));
                if (\u0016\u001D.\u007E\u0013\u0001\u0002((object) regex, strArray2[1]))
                {
                  Match match = \u0017\u001F.\u007E\u0014\u0001\u0002((object) regex, strArray2[1]);
                  mininumVersion = new Version(\u0095\u0082.\u0019\u0096(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001F.\u0080.\u0001(75183)))), \u0095\u0082.\u0019\u0096(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001F.\u0080.\u0001(75192)))), \u0095\u0082.\u0019\u0096(\u0002\u007F.\u007E\u0016\u0001\u0002((object) \u0091\u0081.\u007E\u0018\u0001\u0002((object) \u008B\u0082.\u007E\u0019\u0001\u0002((object) match), \u001F.\u0080.\u0001(75201)))), 0);
                }
              }
            }
          }
        }
      }
      if (\u008E\u0081.\u008A\u0002\u0002(downloadUri, (Uri) null))
        return false;
      parser = new \u001F.\u0080(hash, downloadUri, mininumVersion, (List<KeyValuePair<\u0016, \u0013>>) null);
      return true;
    }

    public static bool \u001E\u0005(string data, bool loaderPack, out \u001F.\u0080 parser)
    {
      parser = (\u001F.\u0080) null;
      string[] lines = \u0093\u0082.\u007E\u0003\u0093((object) data, new char[2]{ '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
      List<KeyValuePair<\u0016, \u0013>> patches = (List<KeyValuePair<\u0016, \u0013>>) null;
      Uri downloadUri = (Uri) null;
      \u0016 hash = \u0016.\u0001;
      Version mininumVersion = (Version) null;
      for (int index = 0; index < lines.Length; ++index)
      {
        string str1 = lines[index];
        if (!\u0016\u001D.\u007E\u0017\u0093((object) str1, \u001F.\u0080.\u0001(66081)))
        {
          string[] strArray = \u009D\u001F.\u007E\u0002\u0093((object) str1, new char[1]{ '=' });
          if (strArray.Length == 2)
          {
            string str2;
            if (!\u001F.\u0080.\u001D\u0005(lines, strArray[1], ref index, out str2))
              return false;
            string str3;
            if ((str3 = strArray[0]) != null)
            {
              if (!\u0008\u001F.\u009A\u0092(str3, \u001F.\u0080.\u0001(75210)))
              {
                if (!\u0008\u001F.\u009A\u0092(str3, \u001F.\u0080.\u0001(68684)))
                {
                  if (!\u0008\u001F.\u009A\u0092(str3, \u001F.\u0080.\u0001(75088)))
                  {
                    if (\u0008\u001F.\u009A\u0092(str3, \u001F.\u0080.\u0001(75231)) && !\u001F.\u0080.\u001D\u0005(str2, out patches))
                      return false;
                  }
                  else
                  {
                    if (!str2.\u001F\u0005())
                      return false;
                    hash = new \u0016(str2);
                  }
                }
                else
                {
                  Uri uri;
                  if (\u008F\u0084.\u009E\u0092(str2) || !\u009B\u0084.\u008C\u0002\u0002(str2, UriKind.Absolute, ref uri) || !uri.\u001D\u0005())
                    return false;
                  downloadUri = uri;
                }
              }
              else if (\u008F\u0084.\u009E\u0092(str2) || !\u0095\u001B.\u0012\u0098(str2, ref mininumVersion))
                return false;
            }
          }
        }
      }
      if (\u008E\u0081.\u008A\u0002\u0002(downloadUri, (Uri) null))
        return false;
      if (\u009B\u001E.\u0013\u0098(mininumVersion, (Version) null))
        mininumVersion = \u0008.Current.FileVersion;
      parser = new \u001F.\u0080(hash, downloadUri, mininumVersion, patches);
      return true;
    }

    private static bool \u001D\u0005(string patch_data, out List<KeyValuePair<\u0016, \u0013>> patches)
    {
      patches = (List<KeyValuePair<\u0016, \u0013>>) null;
      List<KeyValuePair<\u0016, \u0013>> keyValuePairList = new List<KeyValuePair<\u0016, \u0013>>();
      \u0093\u0082 obj = \u0093\u0082.\u007E\u0003\u0093;
      string str = patch_data;
      char[] chArray = new char[2]{ '\n', '\r' };
      int num = 1;
      foreach (string line in obj((object) str, chArray, (StringSplitOptions) num))
      {
        \u0016? expectedHash;
        \u0013 data;
        if (!\u001F.\u0080.\u001D\u0005(line, out expectedHash, out data))
          return false;
        keyValuePairList.Add(new KeyValuePair<\u0016, \u0013>(expectedHash.Value, data));
      }
      patches = keyValuePairList;
      return true;
    }

    private static bool \u001D\u0005(string line, out \u0016? expectedHash, out \u0013 data)
    {
      expectedHash = new \u0016?();
      data = (\u0013) null;
      int startIndex = 0;
      line = \u0002\u007F.\u007E\u001B\u0093((object) line);
      string hash;
      if (!line.\u001D\u0005(' ', ref startIndex, out hash) || !hash.\u001F\u0005())
        return false;
      expectedHash = new \u0016?(new \u0016(hash));
      if (!line.\u001D\u0005(ref startIndex, out hash) || \u008F\u0084.\u009E\u0092(hash))
        return false;
      string[] strArray = \u009D\u001F.\u007E\u0002\u0093((object) hash, new char[1]{ ' ' });
      Uri uri;
      Version minimumVersion;
      Version expectedContentPackVersion;
      if (strArray.Length != 3 || !\u009B\u0084.\u008C\u0002\u0002(strArray[0], UriKind.Absolute, ref uri) || (!uri.\u001D\u0005() || !\u0095\u001B.\u0012\u0098(strArray[1], ref minimumVersion)) || !\u0095\u001B.\u0012\u0098(strArray[2], ref expectedContentPackVersion))
        return false;
      data = new \u0013(uri, minimumVersion, expectedContentPackVersion);
      return true;
    }

    private static bool \u001D\u0005(string[] lines, string line_value, ref int index, out string value)
    {
      value = (string) null;
      if (\u0016\u001D.\u007E\u0017\u0093((object) line_value, \u001F.\u0080.\u0001(64321)))
      {
        if (\u0016\u001D.\u007E\u0011\u0093((object) line_value, \u001F.\u0080.\u0001(30499)))
        {
          if (\u0005\u0081.\u007E\u0001\u0093((object) line_value) <= 2)
            return false;
          value = \u0084\u0080.\u007E\u0006\u0093((object) line_value, 1, \u0005\u0081.\u007E\u0001\u0093((object) line_value) - 2);
          return true;
        }
        StringBuilder stringBuilder1 = new StringBuilder();
        StringBuilder stringBuilder2 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u009C\u007F.\u007E\u0005\u0093((object) line_value, 1));
        int num = -1;
        for (int index1 = index + 1; index1 < lines.Length; ++index1)
        {
          if (\u0016\u001D.\u007E\u0011\u0093((object) lines[index1], \u001F.\u0080.\u0001(30499)))
          {
            num = index1;
            break;
          }
        }
        if (num == -1)
          return false;
        index = index + 1;
        while (index <= num)
        {
          if (index == num)
          {
            StringBuilder stringBuilder3 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u0084\u0080.\u007E\u0006\u0093((object) lines[index], 0, \u0080\u001E.\u007E\u0012\u0093((object) lines[index], '}')));
          }
          else
          {
            StringBuilder stringBuilder4 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, \u008E\u001E.\u0098\u0095());
            StringBuilder stringBuilder5 = \u007F\u0083.\u007E\u009D\u0093((object) stringBuilder1, lines[index]);
          }
          ++index;
        }
        value = \u0002\u007F.\u007E\u0087\u0091((object) stringBuilder1);
        return true;
      }
      value = line_value;
      return true;
    }

    public bool \u001D\u0005(\u0016 currentHash, Version currentVersion, out int startIndex)
    {
      for (int index = 0; index < this.\u0001.Count; ++index)
      {
        KeyValuePair<\u0016, \u0013> keyValuePair = this.\u0001[index];
        if (\u0016.\u001D\u0005(keyValuePair.Key, currentHash) && \u009B\u001E.\u0013\u0098(keyValuePair.Value.ExpectedContentPackVersion, currentVersion))
        {
          startIndex = index;
          return true;
        }
      }
      startIndex = -1;
      return false;
    }
  }
}
