// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0016;
using \u001E;
using \u0081;
using System;
using System.IO;

namespace \u0016
{
  internal class \u007F
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private readonly string \u0001;
    private readonly string \u0002;
    private static readonly object \u0001;

    public DateTime LastCheckedForUpdate { get; set; }

    public \u0002 UpdateStepOn { get; set; }

    public string UpdateVersion { get; set; }

    public string ChangesInLatestVersion { get; set; }

    public bool ChangesIsRTF { get; set; }

    public string ErrorTitle { get; private set; }

    public string ErrorMessage { get; private set; }

    public \u0012 AutoUpdaterStatus { get; private set; }

    public string AutoUpdateID
    {
      get
      {
        if (\u008F\u0084.\u009E\u0092(this.\u0001))
          return \u009C\u0080.\u0008\u009F(\u008E\u001E.\u0006\u0083());
        return this.\u0001;
      }
    }

    static \u007F()
    {
      \u0004.\u001D\u0005(typeof (\u007F));
      \u007F.\u0001 = new object();
    }

    protected \u007F(string autoUpdateID, string autoUpdateFilePath)
    {
      this.\u0001 = autoUpdateID;
      this.\u0002 = autoUpdateFilePath;
      this.AutoUpdaterStatus = \u0012.\u0001;
      bool flag = false;
      try
      {
        if (\u008F\u0084.\u0092\u009E(autoUpdateFilePath))
          this.\u001E\u0005();
        else
          flag = true;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        flag = true;
      }
      if (!flag)
        return;
      this.LastCheckedForUpdate = DateTime.MinValue;
      this.UpdateStepOn = \u0002.\u0001;
    }

    public void \u001D\u0005()
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u007F.\u0001, ref flag);
        FileStream fileStream = new FileStream(this.\u0002, FileMode.Create, FileAccess.Write);
        try
        {
          \u0013.\u001D\u0005((Stream) fileStream, \u007F.\u0001(26513));
          \u0013.\u001D\u0005((Stream) fileStream, (byte) 1, this.LastCheckedForUpdate);
          \u0013.\u001D\u0005((Stream) fileStream, (byte) 2, (int) this.UpdateStepOn);
          if (!\u008F\u0084.\u009E\u0092(this.UpdateVersion))
            \u0013.\u001D\u0005((Stream) fileStream, (byte) 4, this.UpdateVersion);
          if (!\u008F\u0084.\u009E\u0092(this.ChangesInLatestVersion))
          {
            \u0013.\u001D\u0005((Stream) fileStream, (byte) 5, this.ChangesInLatestVersion);
            \u0013.\u001D\u0005((Stream) fileStream, (byte) 6, this.ChangesIsRTF);
          }
          \u0095\u001F.\u007E\u0090\u009D((object) fileStream, byte.MaxValue);
        }
        finally
        {
          if (fileStream != null)
            \u001A\u001E.\u007E\u0094\u0092((object) fileStream);
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    private void \u001E\u0005()
    {
      bool flag = false;
      object obj;
      try
      {
        \u0098\u0082.\u0081\u0098(obj = \u007F.\u0001, ref flag);
        FileStream fileStream = new FileStream(this.\u0002, FileMode.Open, FileAccess.Read);
        try
        {
          if (!\u0082.\u0081.\u001D\u0005((Stream) fileStream, \u007F.\u0001(26513)))
            throw new Exception(\u007F.\u0001(26522));
          for (byte index = (byte) \u0005\u0081.\u007E\u008E\u009D((object) fileStream); !\u0082.\u0081.\u001D\u0005((Stream) fileStream, index, byte.MaxValue); index = (byte) \u0005\u0081.\u007E\u008E\u009D((object) fileStream))
          {
            switch (index)
            {
              case 1:
                this.LastCheckedForUpdate = \u0082.\u0081.\u001D\u0005((Stream) fileStream);
                break;
              case 2:
                this.UpdateStepOn = (\u0002) \u0082.\u0081.\u001D\u0005((Stream) fileStream);
                break;
              case 3:
                this.AutoUpdaterStatus = (\u0012) \u0082.\u0081.\u001D\u0005((Stream) fileStream);
                break;
              case 4:
                this.UpdateVersion = \u0082.\u0081.\u001D\u0005((Stream) fileStream);
                break;
              case 5:
                this.ChangesInLatestVersion = \u0082.\u0081.\u001D\u0005((Stream) fileStream);
                break;
              case 6:
                this.ChangesIsRTF = \u0082.\u0081.\u001D\u0005((Stream) fileStream);
                break;
              case 7:
                this.ErrorTitle = \u0082.\u0081.\u001D\u0005((Stream) fileStream);
                break;
              case 8:
                this.ErrorMessage = \u0082.\u0081.\u001D\u0005((Stream) fileStream);
                break;
              default:
                \u0082.\u0081.\u001D\u0005((Stream) fileStream, index);
                break;
            }
          }
        }
        finally
        {
          if (fileStream != null)
            \u001A\u001E.\u007E\u0094\u0092((object) fileStream);
        }
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098(obj);
      }
    }

    public void \u001F\u0005()
    {
      this.AutoUpdaterStatus = \u0012.\u0001;
      this.UpdateVersion = (string) null;
      this.ChangesInLatestVersion = (string) null;
      this.ChangesIsRTF = false;
      this.ErrorTitle = (string) null;
      this.ErrorMessage = (string) null;
    }
  }
}
