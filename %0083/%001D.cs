// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0016;
using \u001B;
using \u001C;
using \u001E;
using \u0081;
using \u0082;
using \u0083;
using System;
using System.Windows.Forms;
using TSN.wyUpdate.Controls;

namespace \u0083
{
  internal sealed class \u001D : \u0015.\u0016
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private \u0014 \u0001;
    private readonly \u0016.\u001F \u0001;
    private \u0002 \u0001;
    private \u000E \u0001;
    private \u000E \u0002;
    private string \u0006;
    private string \u0007;
    private bool \u0001;

    public string UpdaterExitedPrematurely_Title
    {
      get
      {
        return this.\u0001.UpdaterExitedPrematurely_Title;
      }
      set
      {
        this.\u0001.UpdaterExitedPrematurely_Title = value;
      }
    }

    public string UpdaterExitedPrematurely
    {
      get
      {
        return this.\u0001.UpdaterExitedPrematurely;
      }
      set
      {
        this.\u0001.UpdaterExitedPrematurely = value;
      }
    }

    public string Arguments { get; set; }

    public string Changes
    {
      get
      {
        if (!this.\u0001)
          return this.\u0007;
        RichTextBox richTextBox = new RichTextBox();
        try
        {
          \u0092\u0081.\u007E\u009B\u008E((object) richTextBox, this.\u0007);
          return \u0002\u007F.\u007E\u001C\u0084((object) richTextBox);
        }
        finally
        {
          if (richTextBox != null)
            \u001A\u001E.\u007E\u0094\u0092((object) richTextBox);
        }
      }
    }

    public string RawChanges
    {
      get
      {
        return this.\u0007;
      }
    }

    public bool AreChangesRTF
    {
      get
      {
        return this.\u0001;
      }
    }

    public bool ClosingForInstall { get; private set; }

    public DateTime LastCheckDate
    {
      get
      {
        return this.\u0001.LastCheckedForUpdate;
      }
    }

    public \u0002 UpdateStepOn
    {
      get
      {
        return this.\u0001;
      }
      private set
      {
        this.\u0001 = value;
        if (value == \u0002.\u0002 || value == \u0002.\u0004 || value == \u0002.\u0006)
          return;
        if (value == \u0002.\u0001)
          this.\u0001.\u001F\u0005();
        this.\u0001.UpdateStepOn = value;
        this.\u0001.\u001D\u0005();
      }
    }

    public \u000E UpdateType
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        this.\u0002 = value;
        this.\u0001 = value;
      }
    }

    public string Version
    {
      get
      {
        return this.\u0006;
      }
    }

    public string wyUpdateLocation
    {
      get
      {
        return this.\u0001.wyUpdateLocation;
      }
      set
      {
        this.\u0001.wyUpdateLocation = value;
      }
    }

    public string ServiceName { get; set; }

    public bool UseCloseAppNow { get; set; }

    public event EventHandler<\u0005> BeforeChecking;

    public event EventHandler<\u0005> BeforeDownloading;

    public event EventHandler<\u0005> BeforeExtracting;

    public event EventHandler Canceled;

    public event EventHandler<\u0010> CheckingFailed;

    public event EventHandler ClosingAborted;

    public event EventHandler<\u0010> DownloadingFailed;

    public event EventHandler<\u0010> ExtractingFailed;

    public event EventHandler<\u0005> ProgressChanged;

    public event EventHandler ReadyToBeInstalled;

    public event EventHandler UpdateAvailable;

    public event EventHandler<\u0010> UpdateFailed;

    public event EventHandler<\u0011> UpdateSuccessful;

    public event EventHandler<\u0011> UpToDate;

    public event EventHandler UpdateStepMismatch;

    public event EventHandler CloseAppNow;

    static \u001D()
    {
      \u0004.\u001D\u0005(typeof (\u001D));
      \u001D.\u0001 = \u001D.\u0001(104928);
      \u001D.\u0002 = \u001D.\u0001(105009);
      \u001D.\u0003 = \u001D.\u0001(105086);
      \u001D.\u0004 = \u001D.\u0001(105199);
      \u001D.\u0005 = \u001D.\u0001(105280);
    }

    public \u001D()
    {
      EventHandler<\u0003> eventHandler1 = (EventHandler<\u0003>) null;
      this.\u0001 = new \u0016.\u001F();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.\u0001 = \u0014.Instance;
      \u0016.\u001F obj = this.\u0001;
      if (eventHandler1 == null)
      {
        // ISSUE: method pointer
        eventHandler1 = new EventHandler<\u0003>((object) this, __methodptr(\u001D\u0005));
      }
      EventHandler<\u0003> eventHandler2 = eventHandler1;
      obj.ProgressChanged += eventHandler2;
      this.\u0001.PipeServerDisconnected += (EventHandler<\u0003>) ((sender, e) =>
      {
        if (this.UpdateStepOn != \u0002.\u0002 && this.UpdateStepOn != \u0002.\u0004 && this.UpdateStepOn != \u0002.\u0006)
          return;
        this.\u001D\u0005(this.UpdateStepOn, new \u0010(true, e.UpdateHelperData.ExtraData[0], e.UpdateHelperData.ExtraData[1]));
      });
      this.\u0001.UpdateStepMismatch += (EventHandler<\u0005>) ((sender, e) =>
      {
        if (e.PreviousStep == \u001F.\u0015.\u0005 && this.\u0002 != null)
          \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
        if (e.Response == \u0080.\u0004)
          goto label_9;
label_6:
        if (this.\u0005 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0005, (object) this, EventArgs.Empty);
        return;
label_9:
        switch (this.\u0001.UpdateStep)
        {
          case \u001F.\u0015.\u0001:
            this.UpdateStepOn = \u0002.\u0002;
            goto label_6;
          case \u001F.\u0015.\u0003:
            this.UpdateStepOn = \u0002.\u0004;
            goto label_6;
          case \u001F.\u0015.\u0004:
            this.UpdateStepOn = \u0002.\u0006;
            goto label_6;
          default:
            goto label_6;
        }
      });
      this.\u0001.Canceled += (EventHandler) ((sender, e) =>
      {
        if (this.\u0001 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, e);
      });
    }

    protected override void \u001D\u0005()
    {
      if (this.\u0001 != null)
        goto label_2;
label_1:
      base.\u001D\u0005();
      return;
label_2:
      this.\u0001.Dispose();
      goto label_1;
    }

    public void \u0081\u0005()
    {
      if (this.\u0001 == null)
        throw new FailedToInitializeException();
      if (this.UpdateStepOn == \u0002.\u0001)
        throw new Exception(\u001D.\u0004);
      if (this.UpdateStepOn == \u0002.\u0002)
        throw new Exception(\u001D.\u0003);
      if (this.UpdateStepOn == \u0002.\u0004)
        throw new Exception(\u001D.\u0002);
      if (this.UpdateStepOn == \u0002.\u0006)
        throw new Exception(\u001D.\u0001);
      this.\u0001 = \u000E.\u0001;
      if (this.UpdateStepOn == \u0002.\u0003)
        this.\u0086\u0005();
      else if (this.UpdateStepOn == \u0002.\u0005)
        this.\u0087\u0005();
      else
        this.\u0084\u0005();
    }

    public void \u0082\u0005()
    {
      if (this.\u0001 == null)
        throw new FailedToInitializeException();
      this.\u0001.\u0089\u0005();
      this.\u0083\u0005();
    }

    private void \u0083\u0005()
    {
      if (this.UpdateStepOn == \u0002.\u0002)
        this.UpdateStepOn = \u0002.\u0001;
      else
        this.UpdateStepOn = \u0002.\u0003;
    }

    public bool \u001D\u0005(bool recheck)
    {
      if (this.\u0001 == null)
        throw new FailedToInitializeException();
      if (this.UpdateStepOn != \u0002.\u0001 && (!recheck || this.UpdateStepOn != \u0002.\u0003))
        return false;
      \u0005 e = new \u0005();
      if (this.\u0001 != null)
        this.\u0001((object) this, e);
      if (e.Cancel)
      {
        this.\u0001.\u0089\u0005();
        return false;
      }
      this.UpdateStepOn = \u0002.\u0002;
      if (recheck)
        this.\u0001.\u0083\u0005();
      else
        this.\u0001.\u0084\u0005();
      return true;
    }

    public bool \u0082\u0005()
    {
      return this.\u001D\u0005(false);
    }

    private void \u0084\u0005()
    {
      this.\u0001.\u001D\u0005(this.ServiceName ?? \u008E\u001E.\u0006\u0083(), this.\u0001.AutoUpdateID, this.Arguments, this.ServiceName != null);
    }

    private void \u0086\u0005()
    {
      \u0005 e = new \u0005();
      if (this.\u0002 != null)
        this.\u0002((object) this, e);
      if (e.Cancel)
      {
        this.\u0001.\u0089\u0005();
      }
      else
      {
        this.UpdateStepOn = \u0002.\u0004;
        this.\u0001.\u0086\u0005();
      }
    }

    private void \u0087\u0005()
    {
      \u0005 e = new \u0005();
      if (this.\u0003 != null)
        this.\u0003((object) this, e);
      if (e.Cancel)
      {
        this.\u0001.\u0089\u0005();
      }
      else
      {
        this.UpdateStepOn = \u0002.\u0006;
        this.\u0001.\u0087\u0005();
      }
    }

    private void \u001D\u0005(\u001F.\u0015 updateStepOn)
    {
      switch (updateStepOn)
      {
        case \u001F.\u0015.\u0001:
          if (\u008F\u0084.\u009E\u0092(this.\u0006))
          {
            this.\u008B\u0005();
            break;
          }
          if (this.\u0001 != \u000E.\u0002 && this.\u0001 != \u000E.\u0001)
          {
            this.\u0088\u0005();
            break;
          }
          this.UpdateStepOn = \u0002.\u0003;
          this.\u0086\u0005();
          break;
        case \u001F.\u0015.\u0003:
          if (this.\u0001 == \u000E.\u0001)
          {
            this.\u0087\u0005();
            break;
          }
          this.\u0089\u0005();
          break;
        case \u001F.\u0015.\u0004:
          this.\u008A\u0005();
          break;
      }
    }

    private void \u0088\u0005()
    {
      this.UpdateStepOn = \u0002.\u0003;
      if (this.\u0004 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0004, (object) this, EventArgs.Empty);
    }

    private void \u0089\u0005()
    {
      this.UpdateStepOn = \u0002.\u0005;
      if (this.\u0003 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0003, (object) this, EventArgs.Empty);
    }

    private void \u008A\u0005()
    {
      this.UpdateStepOn = \u0002.\u0007;
      if (this.\u0003 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0003, (object) this, EventArgs.Empty);
    }

    private void \u008B\u0005()
    {
      this.UpdateStepOn = \u0002.\u0001;
      if (this.\u0002 == null)
        return;
      this.\u0002((object) this, new \u0011(this.\u0006));
    }

    private void \u001D\u0005(\u0002 us, \u0010 args)
    {
      this.\u0083\u0005();
      switch (us)
      {
        case \u0002.\u0002:
          if (this.\u0001 == null)
            break;
          this.\u0001((object) this, args);
          break;
        case \u0002.\u0004:
          if (this.\u0002 == null)
            break;
          this.\u0002((object) this, args);
          break;
        case \u0002.\u0006:
          if (this.\u0003 == null)
            break;
          this.\u0003((object) this, args);
          break;
      }
    }

    private static \u0002 \u001D\u0005(\u001F.\u0015 us)
    {
      switch (us)
      {
        case \u001F.\u0015.\u0001:
          return \u0002.\u0002;
        case \u001F.\u0015.\u0003:
          return \u0002.\u0004;
        case \u001F.\u0015.\u0004:
          return \u0002.\u0006;
        default:
          throw new Exception(\u001D.\u0005);
      }
    }

    public void \u008C\u0005()
    {
      if (this.\u0001.UpdateStepOn != \u0002.\u0007)
        return;
      this.ClosingForInstall = true;
      this.\u0084\u0005();
    }

    public void \u008D\u0005()
    {
      if (this.\u0001 == null)
        throw new FailedToInitializeException();
      if (this.ClosingForInstall)
        return;
      this.\u0001 = this.\u0001.UpdateStepOn;
      if (this.UpdateStepOn != \u0002.\u0001)
      {
        this.\u0006 = this.\u0001.UpdateVersion;
        this.\u0007 = this.\u0001.ChangesInLatestVersion;
        this.\u0001 = this.\u0001.ChangesIsRTF;
        switch (this.UpdateStepOn)
        {
          case \u0002.\u0003:
            if (this.\u0001 == \u000E.\u0002 || this.\u0001 == \u000E.\u0001)
            {
              this.\u0086\u0005();
              break;
            }
            this.\u0088\u0005();
            break;
          case \u0002.\u0005:
            if (this.\u0001 == \u000E.\u0001)
            {
              this.\u0087\u0005();
              break;
            }
            this.\u0089\u0005();
            break;
          case \u0002.\u0007:
            this.\u008A\u0005();
            break;
        }
      }
      else
      {
        switch (this.\u0001.AutoUpdaterStatus)
        {
          case \u0012.\u0002:
            this.\u0006 = this.\u0001.UpdateVersion;
            this.\u0007 = this.\u0001.ChangesInLatestVersion;
            this.\u0001 = this.\u0001.ChangesIsRTF;
            if (this.\u0001 != null)
            {
              this.\u0001((object) this, new \u0011(this.\u0006));
              break;
            }
            break;
          case \u0012.\u0003:
            if (this.\u0004 != null)
            {
              this.\u0004((object) this, new \u0010(this.\u0001.ErrorTitle, this.\u0001.ErrorMessage));
              break;
            }
            break;
        }
        this.\u0001.\u001F\u0005();
        this.\u0001.\u001D\u0005();
      }
    }
  }
}
