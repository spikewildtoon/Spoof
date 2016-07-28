// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0018;
using \u0084;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace \u0014
{
  internal class \u0017 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private bool \u0001;
    private \u001B \u0001;
    private bool \u0002;
    private IContainer \u0001;
    protected SaveFileDialog \u0001;
    protected OpenFileDialog \u0001;

    protected bool CanSave { get; set; }

    public bool FileModified
    {
      get
      {
        return this.\u0001;
      }
      protected set
      {
        if (this.\u0002)
          return;
        this.\u0001 = value;
        this.\u001D\u0005(this.\u0001, this.\u0001);
      }
    }

    protected \u001B FileName
    {
      get
      {
        return this.\u0001;
      }
      private set
      {
        if (this.\u0002)
          return;
        this.\u0001 = value;
        this.\u001D\u0005(this.\u0001, this.\u0001);
      }
    }

    protected bool PromptToSaveOnClose { get; set; }

    static \u0017()
    {
      \u0004.\u001D\u0005(typeof (\u0017));
    }

    public \u0017()
    {
      this.CanSave = true;
      this.PromptToSaveOnClose = true;
      this.\u007F\u0005();
    }

    protected void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
    }

    protected void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u001F\u0005();
    }

    protected void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u001F\u0005(this.FileName);
    }

    protected void \u007F\u0005(object sender, EventArgs e)
    {
      this.\u007F\u0005();
    }

    protected void \u0080\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001D\u0005(object sender, FormClosingEventArgs e)
    {
      if (!this.PromptToSaveOnClose || !this.CanSave)
        return;
      \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, !this.\u0080\u0005());
    }

    protected virtual void \u001D\u0005()
    {
      throw new NotImplementedException();
    }

    protected void \u001E\u0005()
    {
      this.\u0002 = true;
      try
      {
        if (!this.\u0080\u0005())
          return;
        this.\u001D\u0005();
        this.\u0002 = false;
        this.FileName = (\u001B) null;
        this.FileModified = false;
      }
      finally
      {
        this.\u0002 = false;
      }
    }

    protected virtual void \u001D\u0005(\u001B fileName)
    {
    }

    protected virtual bool \u001D\u0005(\u001B fileName)
    {
      throw new NotImplementedException();
    }

    protected bool \u001F\u0005(\u001B fileName)
    {
      if (\u001B.\u001D\u0005(fileName, (object) null))
        return this.\u007F\u0005();
      string str = \u009C\u0080.\u0005\u009F(fileName.\u0002);
      if (!\u008F\u0084.\u001D\u009E(str))
      {
        DirectoryInfo directoryInfo = \u0081\u0083.\u001B\u009E(str);
      }
      this.\u0002 = true;
      bool flag;
      try
      {
        flag = this.\u001D\u0005(fileName);
      }
      finally
      {
        this.\u0002 = false;
      }
      if (flag)
        this.FileModified = false;
      return flag;
    }

    protected virtual bool \u001D\u0005(out \u001B fileName)
    {
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) == DialogResult.OK)
      {
        fileName = new \u001B(\u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
        return true;
      }
      fileName = (\u001B) null;
      return false;
    }

    protected bool \u007F\u0005()
    {
      \u001B fileName;
      if (!this.\u001D\u0005(out fileName))
        return false;
      bool flag = this.\u001F\u0005(fileName);
      if (flag)
        goto label_4;
label_1:
      return flag;
label_4:
      this.FileName = fileName;
      this.\u001D\u0005(this.FileName);
      goto label_1;
    }

    protected virtual void \u001E\u0005(\u001B fileName)
    {
    }

    protected virtual bool \u001E\u0005(\u001B fileName)
    {
      throw new NotImplementedException();
    }

    protected virtual bool \u001E\u0005(out \u001B fileName)
    {
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) == DialogResult.OK)
      {
        fileName = new \u001B(\u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
        return true;
      }
      fileName = (\u001B) null;
      return false;
    }

    protected void \u001F\u0005()
    {
      if (!this.\u0080\u0005())
        return;
      this.\u0002 = true;
      \u001B fileName;
      bool flag;
      try
      {
        flag = this.\u001E\u0005(out fileName) && this.\u001E\u0005(fileName);
      }
      finally
      {
        this.\u0002 = false;
      }
      if (!flag)
        return;
      this.FileName = fileName;
      this.FileModified = false;
      this.\u001E\u0005(this.FileName);
    }

    protected virtual void \u001D\u0005(\u001B fileName, bool modified)
    {
    }

    private bool \u0080\u0005()
    {
      if (!this.FileModified)
        return true;
      switch (\u0017.\u001E\u0005(\u0017.\u0001(2119), \u0017.\u0001(2160), \u0016.\u0006, \u0016.\u0007, \u0016.\u0002))
      {
        case DialogResult.Yes:
          return this.\u001F\u0005(this.FileName);
        case DialogResult.No:
          return true;
        default:
          return false;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u007F\u0005()
    {
      this.\u0001 = new SaveFileDialog();
      this.\u0001 = new OpenFileDialog();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0092\u0081.\u007E\u0093\u008A((object) this.\u0001, \u0017.\u0001(2177));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(284, 262));
      \u0092\u0081.\u0010\u0084((object) this, \u0017.\u0001(2178));
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0017.\u0001(2178));
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
