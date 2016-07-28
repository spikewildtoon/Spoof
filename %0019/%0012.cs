// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0019;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace \u0019
{
  internal static class \u0012
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0012()
    {
      \u0004.\u001D\u0005(typeof (\u0012));
    }

    public static KeyValuePair<string, DirectoryInfo>[] \u001D\u0005(DirectoryInfo directory)
    {
      List<KeyValuePair<string, DirectoryInfo>> keyValuePairList = new List<KeyValuePair<string, DirectoryInfo>>();
      keyValuePairList.Add(new KeyValuePair<string, DirectoryInfo>(\u0002\u007F.\u007E\u0084\u009E((object) directory), directory));
      for (DirectoryInfo directoryInfo = \u0001\u0086.\u007E\u008A\u009E((object) directory); directoryInfo != null; directoryInfo = \u0001\u0086.\u007E\u008A\u009E((object) directoryInfo))
        keyValuePairList.Add(new KeyValuePair<string, DirectoryInfo>(\u0002\u007F.\u007E\u0084\u009E((object) directoryInfo), directoryInfo));
      keyValuePairList.Reverse();
      return keyValuePairList.ToArray();
    }

    public static string[] \u001D\u0005(string directory, string searchPattern, string extension)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      return ((IEnumerable<string>) \u001E\u0084.\u001F\u009E(directory, searchPattern)).Where<string>(new Func<string, bool>((object) new \u0012.\u0001() { \u0001 = extension }, __methodptr(\u001D\u0005))).ToArray<string>();
    }

    public static bool \u001D\u0005(string directory)
    {
      if (\u009A\u0084.\u001E\u009E(directory).Length <= 0)
        return \u009A\u0084.\u007F\u009E(directory).Length > 0;
      return true;
    }

    public static bool \u001E\u0005(string directory)
    {
      return \u009A\u0084.\u001E\u009E(directory).Length > 0;
    }

    public static bool \u001F\u0005(string file)
    {
      try
      {
        Stream stream = (Stream) \u008F\u001C.\u0093\u009E(file, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        try
        {
        }
        finally
        {
          if (stream != null)
            \u001A\u001E.\u007E\u0094\u0092((object) stream);
        }
      }
      catch (IOException ex)
      {
        if (\u001D\u0086.\u0017\u009D((Exception) ex) == -2147024864)
          return true;
      }
      return false;
    }

    public static bool \u007F\u0005(string filePath)
    {
      if (!\u008F\u0084.\u0092\u009E(filePath))
        throw new FileNotFoundException(\u0012.\u0001(44646), filePath);
      bool flag;
      try
      {
        FileStream fileStream = \u008F\u001C.\u0093\u009E(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
        try
        {
          flag = true;
        }
        finally
        {
          if (fileStream != null)
            \u001A\u001E.\u007E\u0094\u0092((object) fileStream);
        }
      }
      catch (IOException ex)
      {
        flag = false;
      }
      return flag;
    }

    public static void \u001D\u0005(string filename, byte[] bytes)
    {
      Stream destination = (Stream) \u008F\u001C.\u0093\u009E(filename, FileMode.Create, FileAccess.Write, FileShare.None);
      try
      {
        bytes.\u001D\u0005(destination);
      }
      finally
      {
        if (destination != null)
          \u001A\u001E.\u007E\u0094\u0092((object) destination);
      }
    }

    public static byte[] \u001D\u0005(string filename)
    {
      Stream str = (Stream) \u008F\u001C.\u0093\u009E(filename, FileMode.Open, FileAccess.Read, FileShare.None);
      try
      {
        byte[] buffer = new byte[\u001F\u001E.\u007E\u0080\u009D((object) str)];
        str.\u001D\u0005(buffer);
        return buffer;
      }
      finally
      {
        if (str != null)
          \u001A\u001E.\u007E\u0094\u0092((object) str);
      }
    }

    public static string \u001D\u0005(string filePath)
    {
      Stream stream = (Stream) \u008F\u001C.\u0093\u009E(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
      try
      {
        StreamReader streamReader = new StreamReader(stream);
        try
        {
          return \u0002\u007F.\u007E\u0012\u009F((object) streamReader);
        }
        finally
        {
          if (streamReader != null)
            \u001A\u001E.\u007E\u0094\u0092((object) streamReader);
        }
      }
      finally
      {
        if (stream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) stream);
      }
    }

    public static void \u001D\u0005(byte[] data, string filePath)
    {
      Stream destination = (Stream) \u008F\u001C.\u0093\u009E(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
      try
      {
        data.\u001D\u0005(destination);
      }
      finally
      {
        if (destination != null)
          \u001A\u001E.\u007E\u0094\u0092((object) destination);
      }
    }

    public static void \u001D\u0005(Stream source_stream, string filePath)
    {
      Stream stream = (Stream) \u008F\u001C.\u0093\u009E(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
      try
      {
        \u0091\u0080.\u007E\u0083\u009D((object) source_stream, stream);
      }
      finally
      {
        if (stream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) stream);
      }
    }

    public static long \u001D\u0005(string filePath)
    {
      FileInfo fileInfo = new FileInfo(filePath);
      if (\u0099\u0082.\u007E\u0086\u009E((object) fileInfo))
        return \u001F\u001E.\u007E\u0098\u009E((object) fileInfo);
      return 0;
    }

    public static DateTime \u001D\u0005(string filePath)
    {
      FileInfo fileInfo = new FileInfo(filePath);
      return \u0008\u007F.\u007E\u0088\u009E((object) fileInfo);
    }

    public static void \u001D\u0005(string filePath, out long fileSize, out DateTime createdDate)
    {
      FileInfo fileInfo = new FileInfo(filePath);
      fileSize = \u001F\u001E.\u007E\u0098\u009E((object) fileInfo);
      createdDate = \u0008\u007F.\u007E\u0088\u009E((object) fileInfo);
    }

    public static void \u001D\u0005(string source_file, string destination_file, bool overwrite)
    {
      if (overwrite && \u008F\u0084.\u0092\u009E(destination_file))
        \u009C\u001F.\u0091\u009E(destination_file);
      \u0096\u0083.\u0096\u009E(source_file, destination_file);
    }
  }
}
