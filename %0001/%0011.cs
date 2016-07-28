// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace \u0001
{
  internal sealed class \u0011
  {
    private static Hashtable \u0001 = new Hashtable();

    [DllImport("kernel32", EntryPoint = "MoveFileEx")]
    private static extern bool \u001D\u0005([In] string obj0, [In] string obj1, [In] int obj2);

    [SpecialName]
    internal static bool \u001D\u0005()
    {
      try
      {
        string lower = Process.GetCurrentProcess().MainModule.ModuleName.ToLower();
        if (lower == \u0006.\u001D\u0005(269))
          return true;
        if (lower == \u0006.\u001D\u0005(282))
          return true;
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    internal static void \u001D\u0005()
    {
      try
      {
        AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(\u0011.\u001D\u0005);
        if (!Assembly.GetExecutingAssembly().GlobalAssemblyCache || !\u0011.\u001D\u0005())
          return;
        string[] strArray = \u0006.\u001D\u0005(303).Split(',');
        int index = 0;
        while (index < strArray.Length - 1)
        {
          try
          {
            string @string = Encoding.UTF8.GetString(Convert.FromBase64String(strArray[index]));
            string str1 = strArray[index + 1];
            if (str1.Length > 0)
            {
              if ((int) str1[0] == 91)
              {
                int num = str1.IndexOf(']');
                string str2 = str1.Substring(1, num - 1);
                string name = str1.Substring(num + 1);
                bool flag = str2.IndexOf('z') >= 0;
                if (str2.IndexOf('f') >= 0)
                {
                  Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
                  if (manifestResourceStream != null)
                  {
                    int count = (int) manifestResourceStream.Length;
                    byte[] buffer = new byte[count];
                    manifestResourceStream.Read(buffer, 0, count);
                    if (flag)
                      buffer = \u000E.\u001D\u0005(buffer);
                    try
                    {
                      string path1 = string.Format(\u0006.\u001D\u0005(521), (object) Path.GetTempPath(), (object) name);
                      Directory.CreateDirectory(path1);
                      \u0011.\u0001 obj = new \u0011.\u0001(@string);
                      string path2 = path1 + obj.\u0001 + \u0006.\u001D\u0005(534);
                      if (!File.Exists(path2))
                      {
                        FileStream fileStream = File.OpenWrite(path2);
                        fileStream.Write(buffer, 0, buffer.Length);
                        fileStream.Close();
                      }
                      \u0012.\u001D\u0005(path2);
                      try
                      {
                        File.Delete(path2);
                        Directory.Delete(path1);
                      }
                      catch
                      {
                      }
                    }
                    catch (Exception ex)
                    {
                    }
                  }
                }
              }
            }
          }
          catch (Exception ex)
          {
          }
          index += 2;
        }
      }
      catch (Exception ex)
      {
      }
    }

    internal static Assembly \u001D\u0005([In] object obj0, [In] ResolveEventArgs obj1)
    {
      \u0011.\u0001 obj = new \u0011.\u0001(obj1.Name);
      string base64String1 = Convert.ToBase64String(Encoding.UTF8.GetBytes(obj.\u001D\u0005(false)));
      string[] strArray = \u0006.\u001D\u0005(303).Split(',');
      string name = string.Empty;
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      int index1 = 0;
      while (index1 < strArray.Length - 1)
      {
        if (strArray[index1] == base64String1)
        {
          name = strArray[index1 + 1];
          break;
        }
        index1 += 2;
      }
      if (name.Length == 0 && obj.\u0003.Length == 0)
      {
        string base64String2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(obj.\u0001));
        int index2 = 0;
        while (index2 < strArray.Length - 1)
        {
          if (strArray[index2] == base64String2)
          {
            name = strArray[index2 + 1];
            break;
          }
          index2 += 2;
        }
      }
      if (name.Length > 0)
      {
        if ((int) name[0] == 91)
        {
          int num = name.IndexOf(']');
          string str = name.Substring(1, num - 1);
          flag1 = str.IndexOf('z') >= 0;
          flag2 = str.IndexOf('g') >= 0;
          flag3 = str.IndexOf('t') >= 0;
          name = name.Substring(num + 1);
        }
        lock (\u0011.\u0001)
        {
          if (\u0011.\u0001.ContainsKey((object) name))
            return (Assembly) \u0011.\u0001[(object) name];
          Stream local_12 = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
          if (local_12 != null)
          {
            int local_13 = (int) local_12.Length;
            byte[] local_14 = new byte[local_13];
            local_12.Read(local_14, 0, local_13);
            if (flag1)
              local_14 = \u000E.\u001D\u0005(local_14);
            if (flag2)
            {
              try
              {
                string local_15 = string.Format(\u0006.\u001D\u0005(521), (object) Path.GetTempPath(), (object) name);
                Directory.CreateDirectory(local_15);
                string local_16 = local_15 + obj.\u0001 + \u0006.\u001D\u0005(534);
                if (!File.Exists(local_16))
                {
                  Assembly local_17 = (Assembly) null;
                  FileStream local_18 = File.OpenWrite(local_16);
                  local_18.Write(local_14, 0, local_14.Length);
                  local_18.Close();
                  if (\u0012.\u001D\u0005(local_16))
                    local_17 = Assembly.Load(obj.\u001D\u0005(true));
                  File.Delete(local_16);
                  Directory.Delete(local_15);
                  if (local_17 != null)
                  {
                    if (\u0011.\u0001.ContainsKey((object) name))
                      local_17 = (Assembly) \u0011.\u0001[(object) name];
                    else
                      \u0011.\u0001.Add((object) name, (object) local_17);
                    return local_17;
                  }
                }
              }
              catch
              {
              }
            }
            Assembly local_19 = (Assembly) null;
            if (!flag3)
            {
              try
              {
                local_19 = Assembly.Load(local_14);
              }
              catch (FileLoadException exception_1)
              {
                flag3 = true;
              }
              catch (BadImageFormatException exception_2)
              {
                flag3 = true;
              }
            }
            if (flag3)
            {
              try
              {
                string local_20 = string.Format(\u0006.\u001D\u0005(521), (object) Path.GetTempPath(), (object) name);
                Directory.CreateDirectory(local_20);
                string local_21 = local_20 + obj.\u0001 + \u0006.\u001D\u0005(534);
                if (!File.Exists(local_21))
                {
                  FileStream local_22 = File.OpenWrite(local_21);
                  local_22.Write(local_14, 0, local_14.Length);
                  local_22.Close();
                  \u0011.\u001D\u0005(local_21, (string) null, 4);
                  \u0011.\u001D\u0005(local_20, (string) null, 4);
                }
                local_19 = Assembly.LoadFile(local_21);
              }
              catch
              {
              }
            }
            \u0011.\u0001[(object) name] = (object) local_19;
            return local_19;
          }
        }
      }
      return (Assembly) null;
    }

    internal struct \u0001
    {
      public string \u0001;
      public Version \u0001;
      public string \u0002;
      public string \u0003;

      public \u0001([In] string obj0)
      {
        this.\u0001 = new Version();
        this.\u0002 = string.Empty;
        this.\u0003 = string.Empty;
        this.\u0001 = string.Empty;
        string str1 = obj0;
        char[] chArray = new char[1]{ ',' };
        foreach (string str2 in str1.Split(chArray))
        {
          string str3 = str2.Trim();
          if (str3.StartsWith(\u0006.\u001D\u0005(624)))
            this.\u0001 = new Version(str3.Substring(8));
          else if (str3.StartsWith(\u0006.\u001D\u0005(637)))
          {
            this.\u0002 = str3.Substring(8);
            if (this.\u0002 == \u0006.\u001D\u0005(577))
              this.\u0002 = string.Empty;
          }
          else if (str3.StartsWith(\u0006.\u001D\u0005(650)))
          {
            this.\u0003 = str3.Substring(15);
            if (this.\u0003 == \u0006.\u001D\u0005(615))
              this.\u0003 = string.Empty;
          }
          else
            this.\u0001 = str3;
        }
      }

      public string \u001D\u0005([In] bool obj0)
      {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(this.\u0001);
        if (obj0)
          goto label_2;
label_1:
        stringBuilder.Append(\u0006.\u001D\u0005(560));
        stringBuilder.Append(this.\u0002.Length == 0 ? \u0006.\u001D\u0005(577) : this.\u0002);
        stringBuilder.Append(\u0006.\u001D\u0005(590));
        stringBuilder.Append(this.\u0003.Length == 0 ? \u0006.\u001D\u0005(615) : this.\u0003);
        return stringBuilder.ToString();
label_2:
        stringBuilder.Append(\u0006.\u001D\u0005(543));
        stringBuilder.Append((object) this.\u0001);
        goto label_1;
      }
    }
  }
}
